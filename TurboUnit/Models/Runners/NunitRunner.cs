using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TurboUnit
{
    public class NUnitRunner : TestRunner
    {
        public string OutputFilePath { get; private set; }
        
        // Constructor
        public NUnitRunner(string nunitConsolePath, string outputFilePath, List<FileData> testAssmebliesToRun)
            : base(nunitConsolePath, testAssmebliesToRun)
        {
            if (!nunitConsolePath.EndsWith("nunit-console.exe", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("The specified NUnit console path was not a path to the NUnit console");
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
            OutputFilePath = outputFilePath;
        }

        protected override string GetArgs(List<FileData> assemblyFiles)
        {
            List<string> args = assemblyFiles.Select(a => a.Path).ToList();
            args.Add("/xml:" + OutputFilePath);
            args.Add("/nologo");
            args.Add("/labels");
            string argsString = String.Join(" ", args.Select(a => "\"" + a + "\"").ToArray());
            return argsString;
        }

        protected override void HandleConsoleOutput(string consoleOutput)
        {
            TestResult testResult = ParseTestResultFromConsoleLine(consoleOutput);
            if (testResult != null)
            {
                OnTestResultReceived(testResult);
            }
        }

        public override void Run()
        {            
            // Listen for the process finished event and publish our own test complete event when done
            base.ProcessFinished += OnTestRunComplete;

            // Start the test run
            base.Run();
        }

        #region Helpers

        private void OnTestRunComplete()
        {
            try
            {
                List<TestResult> testResults = ParseTestResultsFile(OutputFilePath);
                OnTestRunCompleted(testResults);
            }
            catch (Exception e)
            {
                OnError("Error running NUNit tests", "There was an error running the NUNit tests specified. See the console output pane for more details", e);
            }
        }

        private List<TestResult> ParseTestResultsFile(string testResultFilePath)
        {
            if (!File.Exists(testResultFilePath))
            {
                throw new FileNotFoundException("The specified test output file does not exist");
            }
            
            List<TestResult> testResults = new List<TestResult>();
            XElement rootNode = XElement.Load(testResultFilePath);
            foreach (XElement testCaseNode in rootNode.Descendants("test-case"))
            {
                testResults.Add(ParseTestResultFromOutputFileNode(testCaseNode));
            }
            return testResults;
        }

        private TestResult ParseTestResultFromOutputFileNode(XElement testCaseNode)
        {
            string fullTestName = null;
            bool didRun = false;
            string result = null;
            string message = null;

            try
            {
                fullTestName = testCaseNode.Attribute("name").Value;
                didRun = Convert.ToBoolean(testCaseNode.Attribute("executed").Value);
                result = testCaseNode.Attribute("result").Value;

                if (result == "Failure")
                {
                    message = testCaseNode.Element("failure").Element("message").Value.Trim();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error parsing " + fullTestName, e);
            }
            
            return ConvertToTestResult(fullTestName, didRun, result, message);
        }

        private TestResult ConvertToTestResult(string fullTestName, bool didRun, string result, string message)
        {
            TestStatus status;
            switch (result)
            {
                case "Success":
                    status = TestStatus.Passed;
                    break;
                case "Failure":
                    status = TestStatus.Failed;
                    break;
                case "Ignored":
                    status = TestStatus.Skipped;
                    break;
                default:
                    status = TestStatus.Unknown;
                    break;
            }

            return new TestResult(fullTestName, status, message);
        }

        private TestResult ParseTestResultFromConsoleLine(string consoleOutput)
        {
            if (consoleOutput.StartsWith("*****"))
            {
                string fullTestName = consoleOutput.Substring(6);
                return new TestResult(fullTestName, TestStatus.CompleteButUnknown, null);
            }
            else if (consoleOutput.Contains(") Ignored : "))
            {
                string fullTestName = consoleOutput.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)[1];
                return new TestResult(fullTestName, TestStatus.Skipped, null);
            }
            else
            {
                return null;
            }
        }        
        
        #endregion
    }
}
