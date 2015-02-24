using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TurboUnit.Models.Runners
{
    public class MsTestRunner : TestRunner
    {
        public string OutputFilePath { get; set; }

        // Constructor 
        public MsTestRunner(string msTestConsolePath, string outputFilePath, List<FileData> testAssembliesToRun)
            : base(msTestConsolePath, testAssembliesToRun)
        {
            if (!msTestConsolePath.EndsWith("mstest.exe", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("The specified MSTest console path was not a path to the NUnit console");
            }

            if (!outputFilePath.EndsWith(".trx", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("The specified MSTest output file path was not a valid TRX file path");
            }

            string directory = Path.GetDirectoryName(outputFilePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            if (File.Exists(outputFilePath))
            {
                File.Delete(outputFilePath);
            }
        }

        protected override string GetArgs(List<FileData> assemblyFiles)
        {
            List<string> args = assemblyFiles.Select(a => "/testcontainer:" + a.Path).ToList();
            args.Add(@"/resultsfile:C\NUnitRunner\TestResults\" + OutputFilePath);
            return String.Join(" ", args.Select(a => "\"" + a + "\"").ToArray());
        }

        protected override void HandleConsoleOutput(string consoleOutput)
        {
            TestResult testResult = ParseTestResult(consoleOutput);
            if (testResult != null)
            {
                OnTestResultReceived(testResult);
            }
        }

        private TestResult ParseTestResult(string consoleOutput)
        {
            return null;
        }
    }
}
