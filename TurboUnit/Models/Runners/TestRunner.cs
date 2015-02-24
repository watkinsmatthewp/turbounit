using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TurboUnit
{
    public abstract class TestRunner : ConsoleAppRunner
    {
        // Private members
        private List<FileData> _testAssembliesToRun;
        
        // Properties
        public bool InProgress { get; private set; }
        
        #region Publish events

        public delegate void TestResultReceivedDelegate(TestResult testResult);
        public event TestResultReceivedDelegate TestResultReceived;
        protected void OnTestResultReceived(TestResult testResult)
        {
            if (TestResultReceived != null)
            {
                TestResultReceived(testResult);
            }
        }

        public delegate void TestRunCompletedDelegate(List<TestResult> testResults);
        public event TestRunCompletedDelegate TestRunCompleted;
        protected void OnTestRunCompleted(List<TestResult> testResults)
        {
            if (TestRunCompleted != null)
            {
                TestRunCompleted(testResults);
            }
        }

        public delegate void ErrorDelegate(string title, string message, Exception e);
        public event ErrorDelegate Error;
        protected void OnError(string title, string message, Exception e)
        {
            if (Error != null)
            {
                Error(title, message, e);
            }
        }


        #endregion

        // Overrides
        protected abstract string GetArgs(List<FileData> assemblyFiles);
        protected abstract void HandleConsoleOutput(string consoleOutput);

        // Constructor
        public TestRunner(string testRunnerConsolePath, List<FileData> testAssembliesToRun)
            : base(testRunnerConsolePath, true, null)
        {
            if (!testRunnerConsolePath.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("The specified test runner console path was not a path to an application");
            }
            if (testAssembliesToRun == null || testAssembliesToRun.Count == 0)
            {
                throw new ArgumentException("Cannot run 0 test assemblies");
            }

            _testAssembliesToRun = testAssembliesToRun;
        }

        // Methods
        public override void Run()
        {
            Args = GetArgs(_testAssembliesToRun);

            // Subscribe to console output
            base.ConsoleOutputReceived += HandleNonNullConsoleOutput;
            base.ProcessFinished += () => { InProgress = false; };

            // Run the console app
            InProgress = true;
            base.Run();
        }

        private void HandleNonNullConsoleOutput(string message)
        {
            if (message != null)
            {
                HandleConsoleOutput(message);
            }
        }
    
    }
}
