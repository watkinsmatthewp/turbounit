using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurboUnit.Gui
{
    public partial class frm_TurboUnit : Form
    {
        private AssemblyFilterPreset _currentAssemblyFilter = new AssemblyFilterPreset();
        private TurboUnitConfig _config;
        private TestRunner _runner;

        private Stopwatch _testResultStopWatch = new Stopwatch();
        private Queue<TestResult> _testResultQueue = new Queue<TestResult>();
        private Dictionary<string, TestResult> _testResults = new Dictionary<string, TestResult>();

        public frm_TurboUnit()
        {
            InitializeComponent();
        }

        #region UI Event Handlers

        private void frm_TurboUnit_Load(object sender, EventArgs e)
        {
            _config = LoadOrCreateConfig();
            if (_config.IsFirstRun)
            {
                DoFirstRunSetup();
            }
        }

        private void btn_SelectAssemblyDirectory_Click(object sender, EventArgs e)
        {
            string folderPath = GetFolderFromUser("Select a folder that contains assemblies");
            if (folderPath != null)
            {
                SetAssemblyDirectoryPath(folderPath);
                _currentAssemblyFilter.LoadAssemblies(true);
                RefreshFilteredAssemblyList();
            }
        }
        
        private void menu_OpenPreset_Click(object sender, EventArgs e)
        {
            AssemblyFilterPreset filter = GetObjectFromFileFromUser<AssemblyFilterPreset>("Select a preset file", AssemblyFilterPreset.Extension);
            if (filter != null)
            {
                _currentAssemblyFilter = filter;
                txt_AssemblyDirectory.Text = _currentAssemblyFilter.Directories[0];
                txt_PositiveRegex.Text = _currentAssemblyFilter.DoPositiveFilter ? _currentAssemblyFilter.PositiveFilters[0].ToString() : String.Empty;
                txtNegativeRegex.Text = _currentAssemblyFilter.DoNegativeFilter ? _currentAssemblyFilter.NegativeFilters[0].ToString() : String.Empty;
                _currentAssemblyFilter.LoadAssemblies();
                RefreshFilteredAssemblyList();
            }
        }

        private void menu_SaveAsPreset_Click(object sender, EventArgs e)
        {
            if (SaveObjectToUserPath<AssemblyFilterPreset>(_currentAssemblyFilter, AssemblyFilterPreset.Extension))
            {
                ShowMessage("Preset Saved", "Your preset file has been saved");
            }
        }

        private void txt_PositiveRegex_TextChanged(object sender, EventArgs e)
        {
            bool didError;
            Regex newRegex = GetRegex(txt_PositiveRegex, out didError);
            if (!didError)
            {
                if (_currentAssemblyFilter.DoPositiveFilter)
                {
                    _currentAssemblyFilter.PositiveFilters[0] = newRegex;
                }
                else
                {
                    _currentAssemblyFilter.PositiveFilters.Add(newRegex);
                }
                _currentAssemblyFilter.LoadAssemblies();
                RefreshFilteredAssemblyList();
            }
        }

        private void txtNegativeRegex_TextChanged(object sender, EventArgs e)
        {
            bool didError;
            Regex newRegex = GetRegex(txtNegativeRegex, out didError);
            if (!didError)
            {
                if (_currentAssemblyFilter.DoNegativeFilter)
                {
                    _currentAssemblyFilter.NegativeFilters[0] = newRegex;
                }
                else
                {
                    _currentAssemblyFilter.NegativeFilters.Add(newRegex);
                }
                _currentAssemblyFilter.LoadAssemblies();
                RefreshFilteredAssemblyList();
            }
        }

        private void btn_RunTests_Click(object sender, EventArgs e)
        {
            string outputFilePath = @"C:\TurboUnit\TestResults" + DateTime.Now.ToString("yyy_MM_dd_hh_mm_ss") + ".xml";
            _runner = new NUnitRunner(_config.NunitConsolePath, outputFilePath, _currentAssemblyFilter.MatchingAssemblies);

            SubscribeToRunnerEvents();

            txt_ConsoleOutput.Text = "";
            list_TestsPending.Items.Clear();
            ResizeListColumns();
            tabControl.SelectedTab = tab_TestsPending;

            _testResultStopWatch.Start();

            btn_RunTests.Enabled = false;
            btn_CancelTestRun.Enabled = true;
            _runner.Run();
        }

        private void btn_CancelTestRun_Click(object sender, EventArgs e)
        {
            btn_RunTests.Enabled = true;
            btn_CancelTestRun.Enabled = false;
            _runner.Kill();
        }

        #region Runner event listeners

        private void _runner_ConsoleOutputReceived(string message)
        {
            AddLineToConsole(message);
        }

        private void _runner_Error(string title, string message, Exception e)
        {
            ShowError(title, message, e);
        }

        private void _runner_TestRunCompleted(List<TestResult> testResults)
        {
            AddOrUpdateTestResultsInList(testResults);
            UpdateTestResultsSummaries();
            ShowMessage("Test Run Complete", "All tests have finished running");
        }

        private void _runner_TestResultReceived(TestResult testResult)
        {
            _testResultQueue.Enqueue(testResult);
            if (_testResultStopWatch.Elapsed.TotalSeconds >= 1)
            {
                AddOrUpdateTestResultsInList(_testResultQueue);
                UpdateTestResultsSummaries();
                _testResultStopWatch.Restart();
            }
        }

        #endregion

        #endregion

        #region Helpers

        private void SubscribeToRunnerEvents()
        {
            _runner.ConsoleOutputReceived += _runner_ConsoleOutputReceived;
            _runner.TestResultReceived += _runner_TestResultReceived;
            _runner.TestRunCompleted += _runner_TestRunCompleted;
            _runner.Error += _runner_Error;
        }

        private Regex GetRegex(TextBox textBox, out bool didError)
        {
            Regex regex = null;
            didError = false;

            string inputValue = textBox.Text.Trim();
            if (String.IsNullOrWhiteSpace(inputValue))
            {
                textBox.ForeColor = Color.Black;
                textBox.BackColor = Color.White;
            }
            else
            {
                try
                {
                    regex = new Regex(inputValue);
                    textBox.ForeColor = Color.Green;
                    textBox.BackColor = Color.PaleGreen;
                }
                catch (Exception)
                {
                    didError = true;
                    textBox.ForeColor = Color.Red;
                    textBox.BackColor = Color.LightCoral;
                }
            }

            return regex;
        }

        #region UI Updates

        private void SetAssemblyDirectoryPath(string folderPath)
        {
            txt_AssemblyDirectory.Text = folderPath;
            if (_currentAssemblyFilter.Directories.Count == 0)
            {
                _currentAssemblyFilter.Directories.Add(folderPath);
            }
            else
            {
                _currentAssemblyFilter.Directories[0] = folderPath;
            }
        }

        private void LoadAndFilterAssemblies()
        {
            _currentAssemblyFilter.LoadAssemblies();
            RefreshFilteredAssemblyList();
        }

        private void RefreshFilteredAssemblyList()
        {
            SetAssemblyList(_currentAssemblyFilter.MatchingAssemblies);
            if (_currentAssemblyFilter.MatchingAssemblies.Count > 0)
            {
                btn_RunTests.Enabled = true;
            }
            else
            {
                btn_RunTests.Enabled = false;
            }
        }

        private void SetAssemblyList(List<FileData> assemblies)
        {
            list_AssemblyFiles.Items.Clear();
            foreach (FileData assemblyFile in assemblies.OrderBy(f => f.Name))
            {
                ListViewItem row = new ListViewItem()
                {
                    Name = assemblyFile.Path,
                };
                row.SubItems[0].Text = assemblyFile.Name;
                row.SubItems.Add(assemblyFile.Path.Substring(0, assemblyFile.Path.Length - assemblyFile.Name.Length));
                row.SubItems.Add(((int)Math.Ceiling((double)assemblyFile.Size / 1000)).ToString());

                list_AssemblyFiles.Items.Add(row);
            }
        }

        private void AddOrUpdateTestResultsInList(IEnumerable<TestResult> testResults)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(delegate()
                {
                    // re-call this method on the correct thread
                    AddOrUpdateTestResultsInList(testResults);
                }));
            }
            else
            {
                list_TestsPending.BeginUpdate();
                foreach (TestResult testResult in testResults)
                {
                    PutOrMoveTestResultIntoProperListAndUpdateSummary(testResult);
                }
                list_TestsPending.EndUpdate();
                list_TestsPending.Refresh();
            }
        }

        private void AddOrUpdateTestResultInList(TestResult testResult)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(delegate()
                {
                    // re-call this method on the correct thread
                    AddOrUpdateTestResultInList(testResult);
                }));
            }
            else
            {
                list_TestsPending.BeginUpdate();
                PutOrMoveTestResultIntoProperListAndUpdateSummary(testResult);
                ResizeListColumns();
                list_TestsPending.EndUpdate();
            }
        }

        private void PutOrMoveTestResultIntoProperListAndUpdateSummary(TestResult testResult)
        {
            // Update the lists/tabs
            string targetListName = GetProperListPerTestStatus(testResult.CurrentStatus).Name;
            foreach (ListView list in new ListView[] {list_TestsFailed, list_TestsInconclusive, list_TestsPassed, list_TestsPending, list_TestsSkipped })
            {
                if (list.Name == targetListName)
                {
                    ListViewItem row = testResult.ToRow();
                    
                    // This is the target list. Get or create the target group
                    ListViewGroup group = list.Groups[testResult.TestNamespace];
                    if (group != null)
                    {
                        // The group exists. Add or update the product in that group
                        int indexInGroup;
                        if (group.Items.Count == 0)
                        {
                            indexInGroup = -1;
                        }
                        else
                        {
                            indexInGroup = group.Items.IndexOfKey(testResult.TestFullyQualitifedName);
                        }

                        if (indexInGroup == -1)
                        {
                            group.Items.Add(row);
                        }
                        else
                        {
                            group.Items[indexInGroup] = row;
                        }
                    }
                    else
                    {
                        // Create the group and add the item to it
                        group = list.Groups.Add(testResult.TestNamespace, testResult.TestNamespace);
                        group.Items.Add(row);
                        SortGroups(list);
                    }

                    // Add or update the row on this list
                    int indexInList = list.Items.IndexOfKey(testResult.TestFullyQualitifedName);
                    if (indexInList == -1)
                    {
                        list.Items.Add(row);
                    }
                    else
                    {
                        list_TestsPending.Items[indexInList] = row;
                    }
                }
                else
                {
                    // This is not the target list. Remove it from the group and then from list
                    ListViewGroup group = list.Groups[testResult.TestNamespace];
                    if (group != null)
                    {
                        group.Items.RemoveByKey(testResult.TestFullyQualitifedName);
                        if (group.Items.Count == 0)
                        {
                            list.Groups.Remove(group);
                            SortGroups(list);
                        }
                    }
                    list.Items.RemoveByKey(testResult.TestFullyQualitifedName);

                    // Hide the parent tab if the list is empty
                    if (list.Items.Count == 0)
                    {
                        list.Parent.Hide();
                    }
                }
            }
        }

        private void UpdateTestResultsSummaries()
        {
            foreach (TestStatus status in (TestStatus[])Enum.GetValues(typeof(TestStatus)))
            {
                UpdateTestResultSummary(status);
            }
        }

        private void UpdateTestResultSummary(TestStatus testStatus)
        {
            string matchingStatusCountString = _testResults.Count(v => v.Value.CurrentStatus == testStatus).ToString();
            switch (testStatus)
            {
                case TestStatus.AwaitingRun:
                    lbl_PendingNumber.Text = matchingStatusCountString;
                    break;
                case TestStatus.CompleteButUnknown:
                case TestStatus.Running:
                case TestStatus.Unknown:
                case TestStatus.Inconclusive:
                    lbl_InconclusiveNumber.Text = matchingStatusCountString;
                    break;
                case TestStatus.Failed:
                case TestStatus.FailedWithException:
                case TestStatus.Timeout:
                    lbl_FailedNumber.Text = matchingStatusCountString;
                    break;
                case TestStatus.Passed:
                    lbl_PassedNumber.Text = matchingStatusCountString;
                    break;
                case TestStatus.Skipped:
                    lbl_SkippedNumber.Text = matchingStatusCountString;
                    break;
                default:
                    throw new ArgumentException("Cannot figure out which number to increment for a test to that is " + testStatus.ToString());
            }
        }

        private ListView GetProperListPerTestStatus(TestStatus testStatus)
        {
            switch (testStatus)
            {
                case TestStatus.AwaitingRun:
                    return list_TestsPending;
                case TestStatus.CompleteButUnknown:
                case TestStatus.Running:
                case TestStatus.Unknown:
                case TestStatus.Inconclusive:
                    return list_TestsInconclusive;
                case TestStatus.Failed:
                case TestStatus.FailedWithException:
                case TestStatus.Timeout:
                    return list_TestsFailed;
                case TestStatus.Passed:
                    return list_TestsPassed;
                case TestStatus.Skipped:
                    return list_TestsSkipped;
                default:
                    throw new ArgumentException("Cannot figure out which list to assign a test to that is " + testStatus.ToString());
            }
        }

        private void SortGroups(ListView list)
        {
            if (list.Groups.Count > 1)
            {
                ListViewGroup[] groups = new ListViewGroup[list.Groups.Count];
                list_TestsPending.Groups.CopyTo(groups, 0);
                groups = groups.OrderBy(g => g.Name).ToArray();

                list_TestsPending.Groups.Clear();
                list_TestsPending.Groups.AddRange(groups);
            }
        }

        private void AddLineToConsole(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(delegate()
                {
                    // re-call this method on the correct thread
                    AddLineToConsole(message);
                }));
            }
            else
            {
                txt_ConsoleOutput.AppendLine(message);
            }
        }

        private void ShowError(string title, string message, Exception e)
        {
            StringBuilder errorMessage = new StringBuilder();
            if (!String.IsNullOrWhiteSpace(message))
            {
                errorMessage.AppendLine("Message:");
                errorMessage.AppendLine(message);
            }
            if (e != null)
            {
                if (errorMessage.Length > 0)
                {
                    errorMessage.AppendLine();
                    errorMessage.AppendLine();
                }
                errorMessage.AppendLine("Exception Details:");
                errorMessage.AppendLine(e.Message);
                errorMessage.AppendLine(e.StackTrace);
            }

            MessageBox.Show(errorMessage.ToString(), title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowMessage(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResizeListColumns()
        {
            // list_TestResults.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //for (int i = 0; i < list_TestResults.Columns.Count; i++)
            //{
            //    if (list_TestResults.Columns[i].Width < 10)
            //    {
            //        // Probably an empty column. make sure at least the header is visible
            //        list_TestResults.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize);
            //    }
            //}
        }

        private TurboUnitConfig LoadOrCreateConfig()
        {
            TurboUnitConfig config;
            string directory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string configFilePath = Path.Combine(directory, "TurboUnitSettings.json");
            if (File.Exists(configFilePath))
            {
                config = TurboUnitObject.Load<TurboUnitConfig>(configFilePath);
            }
            else
            {
                config = new TurboUnitConfig()
                {
                    ConfigFilePath = configFilePath,
                    IsFirstRun = true
                };
                config.Save(configFilePath);
            }
            return config;
        }

        private void DoFirstRunSetup()
        {
            ShowMessage("First run wizard", "Thank you for using TurboUnit.\n\nSince this is your first time, you will be guided through setup. First, you will need to locate the NUnit console program on your computer (nunit-console.exe). Click Ok to locate this file");
            _config.NunitConsolePath = GetFileFromUser("Locate NUnit Console App", "nunit-console.exe|nunit-console.exe");
            ShowMessage("First run wizard", "Now locate the path of the mstest application");
            _config.MsTestConsolePath = GetFileFromUser("Locate MSTest Console App", "mstest.exe|mstest.exe");
            ShowMessage("First run wizard", "Thank you. you can now use TurboTester");

            _config.IsFirstRun = false;
            _config.Save();
        }

        #region IO

        private string GetFolderFromUser(string title)
        {
            FolderBrowserDialog folderSelector = new FolderBrowserDialog()
            {
                Description = title,
                ShowNewFolderButton = true
            };

            DialogResult result = folderSelector.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                return folderSelector.SelectedPath;
            }
            else
            {
                return null;
            }
        }
        
        private T GetObjectFromFileFromUser<T>(string title, string extension) where T : TurboUnitObject
        {
            string filePath = GetFileFromUser(title, "*." + extension + "|*." + extension);
            if (filePath == null)
            {
                return null;
            }
            else
            {
                return TurboUnitObject.Load<T>(filePath);
            }
        }
        
        private string GetFileFromUser(string title)
        {
            return GetFileFromUser(title, "All Files (*.*)|*.*");
        }

        private string GetFileFromUser(string title, string fileFilter)
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = fileFilter,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                Multiselect = false,
                Title = title
            };

            DialogResult result = fileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                return fileDialog.FileName;
            }
            else
            {
                return null;
            }
        }

        private bool SaveObjectToUserPath<T>(T thisObj, string extension) where T : TurboUnitObject
        {
            SaveFileDialog file = new SaveFileDialog()
            {
                AddExtension = true,
                DefaultExt = extension,
                CheckPathExists = true,
                FileName = DateTime.Now.ToString("yyy-MM0dd-hh-mm-ss") + "." + extension,
                Filter = "*." + extension + "|*." + extension,
                OverwritePrompt = true,
                Title = "Save file"
            };
            DialogResult result = file.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                thisObj.Save(file.FileName);
                ShowMessage("Saved", "Your file has been saved");
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #endregion

        #endregion
    }
}