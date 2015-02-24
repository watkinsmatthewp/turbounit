using System;
using System.Diagnostics;
using System.IO;

namespace TurboUnit
{
    public class ConsoleAppRunner
    {
        private string _programPath;
        private bool _hidden;
        private int _processID;

        public string Args { get; protected set; }

        // Delegates
        public delegate void ConsoleOutputReceivedDelegate(string message);
        public event ConsoleOutputReceivedDelegate ConsoleOutputReceived;
        public delegate void ProcessFinishedDelegate();
        public event ProcessFinishedDelegate ProcessFinished;

        public ConsoleAppRunner(string programPath, bool hidden, string args = null)
        {
            if (String.IsNullOrWhiteSpace(programPath))
            {
                throw new ArgumentException("The specified NUnit console path was not a path to the NUnit console");
            }
            if (!File.Exists(programPath))
            {
                throw new FileNotFoundException("Could not find the NUnit console path at the specified location");
            }
            _programPath = programPath;

            _hidden = hidden;
            Args = args;
        }

        #region Publish events

        private void OnConsoleOutputReceived(string message)
        {
            if (ConsoleOutputReceived != null)
            {
                ConsoleOutputReceived(message);
            }
        }

        private void OnProcessFinished()
        {
            if (ProcessFinished != null)
            {
                ProcessFinished();
            }
        }

        #endregion

        public virtual void Run()
        {
            // Create the process
            Process process = new Process();
            process.StartInfo.FileName = _programPath;
            process.StartInfo.Arguments = Args;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.EnableRaisingEvents = true;

            // (Hide)
            if (_hidden)
            {
                process.StartInfo.CreateNoWindow = _hidden;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            }

            process.OutputDataReceived += process_OutputDataReceived;
            process.Exited += process_Exited;
            process.Disposed += process_Disposed;

            // Start
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            _processID = process.Id;
        }

        private void process_Disposed(object sender, EventArgs e)
        {
            OnProcessFinished();
        }

        private void process_Exited(object sender, EventArgs e)
        {
            OnProcessFinished();
        }

        private void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            OnConsoleOutputReceived(e.Data);
        }

        public void Kill()
        {
            Process process = Process.GetProcessById(_processID);
            try
            {
                if (!process.HasExited)
                {
                    process.Kill();
                }
            }
            catch (ArgumentException)
            {
                // This probably means the process has already died-- that's OK
            }
        }

        public static void KillAllProcessesWithName(string name)
        {
            Process[] processes = Process.GetProcessesByName(name);
            foreach (Process process in processes)
            {
                if (!process.HasExited)
                {
                    try
                    {
                        process.Kill();
                    }
                    catch (ArgumentException)
                    {
                        // This probably means the process has already died-- that's OK
                    }
                }
            }
        }
    }
}