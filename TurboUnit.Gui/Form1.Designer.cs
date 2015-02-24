namespace TurboUnit.Gui
{
    partial class frm_TurboUnit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TurboUnit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_AssemblyDirectory = new System.Windows.Forms.TextBox();
            this.btn_SelectAssemblyDirectory = new System.Windows.Forms.Button();
            this.btn_RunTests = new System.Windows.Forms.Button();
            this.btn_CancelTestRun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNegativeRegex = new System.Windows.Forms.TextBox();
            this.txt_PositiveRegex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Summary = new System.Windows.Forms.Panel();
            this.lbl_PassedText = new System.Windows.Forms.Label();
            this.lbl_PendingNumber = new System.Windows.Forms.Label();
            this.lbl_PendingText = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_Assemblies = new System.Windows.Forms.TabPage();
            this.list_AssemblyFiles = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_Output = new System.Windows.Forms.TabPage();
            this.txt_ConsoleOutput = new System.Windows.Forms.TextBox();
            this.tab_TestsPending = new System.Windows.Forms.TabPage();
            this.list_TestsPending = new System.Windows.Forms.ListView();
            this.TestName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TestClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TestMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_TestsPassed = new System.Windows.Forms.TabPage();
            this.list_TestsPassed = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_TestsInconclusive = new System.Windows.Forms.TabPage();
            this.list_TestsInconclusive = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_TestsFailed = new System.Windows.Forms.TabPage();
            this.list_TestsFailed = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_TestsSkipped = new System.Windows.Forms.TabPage();
            this.list_TestsSkipped = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_OpenPreset = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_SaveAsPreset = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_PassedNumber = new System.Windows.Forms.Label();
            this.lbl_InconclusiveText = new System.Windows.Forms.Label();
            this.lbl_InconclusiveNumber = new System.Windows.Forms.Label();
            this.lbl_FailedText = new System.Windows.Forms.Label();
            this.lbl_FailedNumber = new System.Windows.Forms.Label();
            this.lbl_SkippedTest = new System.Windows.Forms.Label();
            this.lbl_SkippedNumber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_Summary.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tab_Assemblies.SuspendLayout();
            this.tab_Output.SuspendLayout();
            this.tab_TestsPending.SuspendLayout();
            this.tab_TestsPassed.SuspendLayout();
            this.tab_TestsInconclusive.SuspendLayout();
            this.tab_TestsFailed.SuspendLayout();
            this.tab_TestsSkipped.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txt_AssemblyDirectory);
            this.panel1.Controls.Add(this.btn_SelectAssemblyDirectory);
            this.panel1.Controls.Add(this.btn_RunTests);
            this.panel1.Controls.Add(this.btn_CancelTestRun);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNegativeRegex);
            this.panel1.Controls.Add(this.txt_PositiveRegex);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 87);
            this.panel1.TabIndex = 0;
            // 
            // txt_AssemblyDirectory
            // 
            this.txt_AssemblyDirectory.Location = new System.Drawing.Point(105, 3);
            this.txt_AssemblyDirectory.Name = "txt_AssemblyDirectory";
            this.txt_AssemblyDirectory.ReadOnly = true;
            this.txt_AssemblyDirectory.Size = new System.Drawing.Size(793, 20);
            this.txt_AssemblyDirectory.TabIndex = 11;
            // 
            // btn_SelectAssemblyDirectory
            // 
            this.btn_SelectAssemblyDirectory.Location = new System.Drawing.Point(905, 1);
            this.btn_SelectAssemblyDirectory.Name = "btn_SelectAssemblyDirectory";
            this.btn_SelectAssemblyDirectory.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectAssemblyDirectory.TabIndex = 10;
            this.btn_SelectAssemblyDirectory.Text = "Select";
            this.btn_SelectAssemblyDirectory.UseVisualStyleBackColor = true;
            this.btn_SelectAssemblyDirectory.Click += new System.EventHandler(this.btn_SelectAssemblyDirectory_Click);
            // 
            // btn_RunTests
            // 
            this.btn_RunTests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RunTests.Enabled = false;
            this.btn_RunTests.Location = new System.Drawing.Point(906, 55);
            this.btn_RunTests.Name = "btn_RunTests";
            this.btn_RunTests.Size = new System.Drawing.Size(75, 23);
            this.btn_RunTests.TabIndex = 8;
            this.btn_RunTests.Text = "Run";
            this.btn_RunTests.UseVisualStyleBackColor = true;
            this.btn_RunTests.Click += new System.EventHandler(this.btn_RunTests_Click);
            // 
            // btn_CancelTestRun
            // 
            this.btn_CancelTestRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CancelTestRun.Enabled = false;
            this.btn_CancelTestRun.Location = new System.Drawing.Point(905, 28);
            this.btn_CancelTestRun.Name = "btn_CancelTestRun";
            this.btn_CancelTestRun.Size = new System.Drawing.Size(75, 23);
            this.btn_CancelTestRun.TabIndex = 7;
            this.btn_CancelTestRun.Text = "Cancel";
            this.btn_CancelTestRun.UseVisualStyleBackColor = true;
            this.btn_CancelTestRun.Click += new System.EventHandler(this.btn_CancelTestRun_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Negative Regex";
            // 
            // txtNegativeRegex
            // 
            this.txtNegativeRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNegativeRegex.Location = new System.Drawing.Point(105, 57);
            this.txtNegativeRegex.Name = "txtNegativeRegex";
            this.txtNegativeRegex.Size = new System.Drawing.Size(795, 20);
            this.txtNegativeRegex.TabIndex = 5;
            this.txtNegativeRegex.TextChanged += new System.EventHandler(this.txtNegativeRegex_TextChanged);
            // 
            // txt_PositiveRegex
            // 
            this.txt_PositiveRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PositiveRegex.Location = new System.Drawing.Point(105, 30);
            this.txt_PositiveRegex.Name = "txt_PositiveRegex";
            this.txt_PositiveRegex.Size = new System.Drawing.Size(795, 20);
            this.txt_PositiveRegex.TabIndex = 4;
            this.txt_PositiveRegex.TextChanged += new System.EventHandler(this.txt_PositiveRegex_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Positive Regex";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assembly Directory";
            // 
            // panel_Summary
            // 
            this.panel_Summary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Summary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Summary.Controls.Add(this.lbl_SkippedNumber);
            this.panel_Summary.Controls.Add(this.lbl_SkippedTest);
            this.panel_Summary.Controls.Add(this.lbl_FailedNumber);
            this.panel_Summary.Controls.Add(this.lbl_FailedText);
            this.panel_Summary.Controls.Add(this.lbl_InconclusiveNumber);
            this.panel_Summary.Controls.Add(this.lbl_InconclusiveText);
            this.panel_Summary.Controls.Add(this.lbl_PassedNumber);
            this.panel_Summary.Controls.Add(this.lbl_PassedText);
            this.panel_Summary.Controls.Add(this.lbl_PendingNumber);
            this.panel_Summary.Controls.Add(this.lbl_PendingText);
            this.panel_Summary.Location = new System.Drawing.Point(13, 647);
            this.panel_Summary.Name = "panel_Summary";
            this.panel_Summary.Size = new System.Drawing.Size(984, 48);
            this.panel_Summary.TabIndex = 1;
            // 
            // lbl_PassedText
            // 
            this.lbl_PassedText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_PassedText.AutoSize = true;
            this.lbl_PassedText.Location = new System.Drawing.Point(5, 27);
            this.lbl_PassedText.Name = "lbl_PassedText";
            this.lbl_PassedText.Size = new System.Drawing.Size(42, 13);
            this.lbl_PassedText.TabIndex = 2;
            this.lbl_PassedText.Text = "Passed";
            // 
            // lbl_PendingNumber
            // 
            this.lbl_PendingNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_PendingNumber.AutoSize = true;
            this.lbl_PendingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PendingNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_PendingNumber.Location = new System.Drawing.Point(75, 6);
            this.lbl_PendingNumber.Name = "lbl_PendingNumber";
            this.lbl_PendingNumber.Size = new System.Drawing.Size(13, 13);
            this.lbl_PendingNumber.TabIndex = 1;
            this.lbl_PendingNumber.Text = "0";
            // 
            // lbl_PendingText
            // 
            this.lbl_PendingText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_PendingText.AutoSize = true;
            this.lbl_PendingText.Location = new System.Drawing.Point(5, 6);
            this.lbl_PendingText.Name = "lbl_PendingText";
            this.lbl_PendingText.Size = new System.Drawing.Size(46, 13);
            this.lbl_PendingText.TabIndex = 0;
            this.lbl_PendingText.Text = "Pending";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tab_Assemblies);
            this.tabControl.Controls.Add(this.tab_Output);
            this.tabControl.Controls.Add(this.tab_TestsPending);
            this.tabControl.Controls.Add(this.tab_TestsPassed);
            this.tabControl.Controls.Add(this.tab_TestsInconclusive);
            this.tabControl.Controls.Add(this.tab_TestsFailed);
            this.tabControl.Controls.Add(this.tab_TestsSkipped);
            this.tabControl.Location = new System.Drawing.Point(13, 120);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(984, 521);
            this.tabControl.TabIndex = 2;
            // 
            // tab_Assemblies
            // 
            this.tab_Assemblies.Controls.Add(this.list_AssemblyFiles);
            this.tab_Assemblies.Location = new System.Drawing.Point(4, 22);
            this.tab_Assemblies.Name = "tab_Assemblies";
            this.tab_Assemblies.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Assemblies.Size = new System.Drawing.Size(976, 495);
            this.tab_Assemblies.TabIndex = 0;
            this.tab_Assemblies.Text = "Assemblies";
            this.tab_Assemblies.UseVisualStyleBackColor = true;
            // 
            // list_AssemblyFiles
            // 
            this.list_AssemblyFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.FilePath,
            this.FileSize});
            this.list_AssemblyFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_AssemblyFiles.FullRowSelect = true;
            this.list_AssemblyFiles.Location = new System.Drawing.Point(3, 3);
            this.list_AssemblyFiles.Name = "list_AssemblyFiles";
            this.list_AssemblyFiles.Size = new System.Drawing.Size(970, 489);
            this.list_AssemblyFiles.TabIndex = 2;
            this.list_AssemblyFiles.UseCompatibleStateImageBehavior = false;
            this.list_AssemblyFiles.View = System.Windows.Forms.View.Details;
            // 
            // FileName
            // 
            this.FileName.Text = "File name";
            this.FileName.Width = 337;
            // 
            // FilePath
            // 
            this.FilePath.Text = "Directory";
            this.FilePath.Width = 546;
            // 
            // FileSize
            // 
            this.FileSize.Text = "Size (KB)";
            // 
            // tab_Output
            // 
            this.tab_Output.Controls.Add(this.txt_ConsoleOutput);
            this.tab_Output.Location = new System.Drawing.Point(4, 22);
            this.tab_Output.Name = "tab_Output";
            this.tab_Output.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Output.Size = new System.Drawing.Size(976, 495);
            this.tab_Output.TabIndex = 2;
            this.tab_Output.Text = "Output";
            this.tab_Output.UseVisualStyleBackColor = true;
            // 
            // txt_ConsoleOutput
            // 
            this.txt_ConsoleOutput.AcceptsReturn = true;
            this.txt_ConsoleOutput.BackColor = System.Drawing.Color.Black;
            this.txt_ConsoleOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ConsoleOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConsoleOutput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ConsoleOutput.Location = new System.Drawing.Point(3, 3);
            this.txt_ConsoleOutput.Multiline = true;
            this.txt_ConsoleOutput.Name = "txt_ConsoleOutput";
            this.txt_ConsoleOutput.ReadOnly = true;
            this.txt_ConsoleOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_ConsoleOutput.Size = new System.Drawing.Size(970, 489);
            this.txt_ConsoleOutput.TabIndex = 0;
            this.txt_ConsoleOutput.WordWrap = false;
            // 
            // tab_TestsPending
            // 
            this.tab_TestsPending.Controls.Add(this.list_TestsPending);
            this.tab_TestsPending.Location = new System.Drawing.Point(4, 22);
            this.tab_TestsPending.Name = "tab_TestsPending";
            this.tab_TestsPending.Padding = new System.Windows.Forms.Padding(3);
            this.tab_TestsPending.Size = new System.Drawing.Size(976, 495);
            this.tab_TestsPending.TabIndex = 1;
            this.tab_TestsPending.Text = "Pending";
            this.tab_TestsPending.UseVisualStyleBackColor = true;
            // 
            // list_TestsPending
            // 
            this.list_TestsPending.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TestName,
            this.TestClass,
            this.TestMessage});
            this.list_TestsPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_TestsPending.FullRowSelect = true;
            this.list_TestsPending.GridLines = true;
            this.list_TestsPending.Location = new System.Drawing.Point(3, 3);
            this.list_TestsPending.Name = "list_TestsPending";
            this.list_TestsPending.Size = new System.Drawing.Size(970, 489);
            this.list_TestsPending.TabIndex = 2;
            this.list_TestsPending.UseCompatibleStateImageBehavior = false;
            this.list_TestsPending.View = System.Windows.Forms.View.Details;
            // 
            // TestName
            // 
            this.TestName.Text = "Name";
            this.TestName.Width = 351;
            // 
            // TestClass
            // 
            this.TestClass.Text = "Class";
            this.TestClass.Width = 290;
            // 
            // TestMessage
            // 
            this.TestMessage.Text = "Message";
            this.TestMessage.Width = 324;
            // 
            // tab_TestsPassed
            // 
            this.tab_TestsPassed.Controls.Add(this.list_TestsPassed);
            this.tab_TestsPassed.Location = new System.Drawing.Point(4, 22);
            this.tab_TestsPassed.Name = "tab_TestsPassed";
            this.tab_TestsPassed.Size = new System.Drawing.Size(976, 495);
            this.tab_TestsPassed.TabIndex = 3;
            this.tab_TestsPassed.Text = "Passed";
            this.tab_TestsPassed.UseVisualStyleBackColor = true;
            // 
            // list_TestsPassed
            // 
            this.list_TestsPassed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.list_TestsPassed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_TestsPassed.FullRowSelect = true;
            this.list_TestsPassed.GridLines = true;
            this.list_TestsPassed.Location = new System.Drawing.Point(0, 0);
            this.list_TestsPassed.Name = "list_TestsPassed";
            this.list_TestsPassed.Size = new System.Drawing.Size(976, 495);
            this.list_TestsPassed.TabIndex = 3;
            this.list_TestsPassed.UseCompatibleStateImageBehavior = false;
            this.list_TestsPassed.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 351;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Class";
            this.columnHeader2.Width = 290;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Message";
            this.columnHeader3.Width = 324;
            // 
            // tab_TestsInconclusive
            // 
            this.tab_TestsInconclusive.Controls.Add(this.list_TestsInconclusive);
            this.tab_TestsInconclusive.Location = new System.Drawing.Point(4, 22);
            this.tab_TestsInconclusive.Name = "tab_TestsInconclusive";
            this.tab_TestsInconclusive.Size = new System.Drawing.Size(976, 495);
            this.tab_TestsInconclusive.TabIndex = 6;
            this.tab_TestsInconclusive.Text = "Inconclusive";
            this.tab_TestsInconclusive.UseVisualStyleBackColor = true;
            // 
            // list_TestsInconclusive
            // 
            this.list_TestsInconclusive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.list_TestsInconclusive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_TestsInconclusive.FullRowSelect = true;
            this.list_TestsInconclusive.GridLines = true;
            this.list_TestsInconclusive.Location = new System.Drawing.Point(0, 0);
            this.list_TestsInconclusive.Name = "list_TestsInconclusive";
            this.list_TestsInconclusive.Size = new System.Drawing.Size(976, 495);
            this.list_TestsInconclusive.TabIndex = 4;
            this.list_TestsInconclusive.UseCompatibleStateImageBehavior = false;
            this.list_TestsInconclusive.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Name";
            this.columnHeader10.Width = 351;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Class";
            this.columnHeader11.Width = 290;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Message";
            this.columnHeader12.Width = 324;
            // 
            // tab_TestsFailed
            // 
            this.tab_TestsFailed.Controls.Add(this.list_TestsFailed);
            this.tab_TestsFailed.Location = new System.Drawing.Point(4, 22);
            this.tab_TestsFailed.Name = "tab_TestsFailed";
            this.tab_TestsFailed.Size = new System.Drawing.Size(976, 495);
            this.tab_TestsFailed.TabIndex = 4;
            this.tab_TestsFailed.Text = "Failed";
            this.tab_TestsFailed.UseVisualStyleBackColor = true;
            // 
            // list_TestsFailed
            // 
            this.list_TestsFailed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.list_TestsFailed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_TestsFailed.FullRowSelect = true;
            this.list_TestsFailed.GridLines = true;
            this.list_TestsFailed.Location = new System.Drawing.Point(0, 0);
            this.list_TestsFailed.Name = "list_TestsFailed";
            this.list_TestsFailed.Size = new System.Drawing.Size(976, 495);
            this.list_TestsFailed.TabIndex = 4;
            this.list_TestsFailed.UseCompatibleStateImageBehavior = false;
            this.list_TestsFailed.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 351;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Class";
            this.columnHeader5.Width = 290;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Message";
            this.columnHeader6.Width = 324;
            // 
            // tab_TestsSkipped
            // 
            this.tab_TestsSkipped.Controls.Add(this.list_TestsSkipped);
            this.tab_TestsSkipped.Location = new System.Drawing.Point(4, 22);
            this.tab_TestsSkipped.Name = "tab_TestsSkipped";
            this.tab_TestsSkipped.Size = new System.Drawing.Size(976, 495);
            this.tab_TestsSkipped.TabIndex = 5;
            this.tab_TestsSkipped.Text = "Skipped";
            this.tab_TestsSkipped.UseVisualStyleBackColor = true;
            // 
            // list_TestsSkipped
            // 
            this.list_TestsSkipped.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.list_TestsSkipped.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_TestsSkipped.FullRowSelect = true;
            this.list_TestsSkipped.GridLines = true;
            this.list_TestsSkipped.Location = new System.Drawing.Point(0, 0);
            this.list_TestsSkipped.Name = "list_TestsSkipped";
            this.list_TestsSkipped.Size = new System.Drawing.Size(976, 495);
            this.list_TestsSkipped.TabIndex = 4;
            this.list_TestsSkipped.UseCompatibleStateImageBehavior = false;
            this.list_TestsSkipped.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Name";
            this.columnHeader7.Width = 351;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Class";
            this.columnHeader8.Width = 290;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Message";
            this.columnHeader9.Width = 324;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_OpenPreset,
            this.menu_SaveAsPreset});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menu_OpenPreset
            // 
            this.menu_OpenPreset.Name = "menu_OpenPreset";
            this.menu_OpenPreset.Size = new System.Drawing.Size(147, 22);
            this.menu_OpenPreset.Text = "Open preset";
            this.menu_OpenPreset.Click += new System.EventHandler(this.menu_OpenPreset_Click);
            // 
            // menu_SaveAsPreset
            // 
            this.menu_SaveAsPreset.Name = "menu_SaveAsPreset";
            this.menu_SaveAsPreset.Size = new System.Drawing.Size(147, 22);
            this.menu_SaveAsPreset.Text = "Save as preset";
            this.menu_SaveAsPreset.Click += new System.EventHandler(this.menu_SaveAsPreset_Click);
            // 
            // lbl_PassedNumber
            // 
            this.lbl_PassedNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_PassedNumber.AutoSize = true;
            this.lbl_PassedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PassedNumber.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_PassedNumber.Location = new System.Drawing.Point(75, 27);
            this.lbl_PassedNumber.Name = "lbl_PassedNumber";
            this.lbl_PassedNumber.Size = new System.Drawing.Size(14, 13);
            this.lbl_PassedNumber.TabIndex = 3;
            this.lbl_PassedNumber.Text = "0";
            // 
            // lbl_InconclusiveText
            // 
            this.lbl_InconclusiveText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_InconclusiveText.AutoSize = true;
            this.lbl_InconclusiveText.Location = new System.Drawing.Point(150, 27);
            this.lbl_InconclusiveText.Name = "lbl_InconclusiveText";
            this.lbl_InconclusiveText.Size = new System.Drawing.Size(67, 13);
            this.lbl_InconclusiveText.TabIndex = 4;
            this.lbl_InconclusiveText.Text = "Inconclusive";
            // 
            // lbl_InconclusiveNumber
            // 
            this.lbl_InconclusiveNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_InconclusiveNumber.AutoSize = true;
            this.lbl_InconclusiveNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InconclusiveNumber.ForeColor = System.Drawing.Color.Orange;
            this.lbl_InconclusiveNumber.Location = new System.Drawing.Point(220, 27);
            this.lbl_InconclusiveNumber.Name = "lbl_InconclusiveNumber";
            this.lbl_InconclusiveNumber.Size = new System.Drawing.Size(14, 13);
            this.lbl_InconclusiveNumber.TabIndex = 5;
            this.lbl_InconclusiveNumber.Text = "0";
            // 
            // lbl_FailedText
            // 
            this.lbl_FailedText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_FailedText.AutoSize = true;
            this.lbl_FailedText.Location = new System.Drawing.Point(295, 27);
            this.lbl_FailedText.Name = "lbl_FailedText";
            this.lbl_FailedText.Size = new System.Drawing.Size(35, 13);
            this.lbl_FailedText.TabIndex = 6;
            this.lbl_FailedText.Text = "Failed";
            // 
            // lbl_FailedNumber
            // 
            this.lbl_FailedNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_FailedNumber.AutoSize = true;
            this.lbl_FailedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FailedNumber.ForeColor = System.Drawing.Color.Red;
            this.lbl_FailedNumber.Location = new System.Drawing.Point(365, 27);
            this.lbl_FailedNumber.Name = "lbl_FailedNumber";
            this.lbl_FailedNumber.Size = new System.Drawing.Size(14, 13);
            this.lbl_FailedNumber.TabIndex = 7;
            this.lbl_FailedNumber.Text = "0";
            // 
            // lbl_SkippedTest
            // 
            this.lbl_SkippedTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_SkippedTest.AutoSize = true;
            this.lbl_SkippedTest.Location = new System.Drawing.Point(150, 6);
            this.lbl_SkippedTest.Name = "lbl_SkippedTest";
            this.lbl_SkippedTest.Size = new System.Drawing.Size(46, 13);
            this.lbl_SkippedTest.TabIndex = 8;
            this.lbl_SkippedTest.Text = "Skipped";
            // 
            // lbl_SkippedNumber
            // 
            this.lbl_SkippedNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_SkippedNumber.AutoSize = true;
            this.lbl_SkippedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SkippedNumber.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_SkippedNumber.Location = new System.Drawing.Point(220, 6);
            this.lbl_SkippedNumber.Name = "lbl_SkippedNumber";
            this.lbl_SkippedNumber.Size = new System.Drawing.Size(14, 13);
            this.lbl_SkippedNumber.TabIndex = 9;
            this.lbl_SkippedNumber.Text = "0";
            // 
            // frm_TurboUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 707);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel_Summary);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_TurboUnit";
            this.Text = "TurboUnit";
            this.Load += new System.EventHandler(this.frm_TurboUnit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Summary.ResumeLayout(false);
            this.panel_Summary.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tab_Assemblies.ResumeLayout(false);
            this.tab_Output.ResumeLayout(false);
            this.tab_Output.PerformLayout();
            this.tab_TestsPending.ResumeLayout(false);
            this.tab_TestsPassed.ResumeLayout(false);
            this.tab_TestsInconclusive.ResumeLayout(false);
            this.tab_TestsFailed.ResumeLayout(false);
            this.tab_TestsSkipped.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNegativeRegex;
        private System.Windows.Forms.TextBox txt_PositiveRegex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_RunTests;
        private System.Windows.Forms.Button btn_CancelTestRun;
        private System.Windows.Forms.Panel panel_Summary;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_Assemblies;
        private System.Windows.Forms.TabPage tab_TestsPending;
        private System.Windows.Forms.TabPage tab_Output;
        private System.Windows.Forms.ListView list_TestsPending;
        private System.Windows.Forms.ColumnHeader TestClass;
        private System.Windows.Forms.ColumnHeader TestName;
        private System.Windows.Forms.ColumnHeader TestMessage;
        private System.Windows.Forms.ListView list_AssemblyFiles;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader FilePath;
        private System.Windows.Forms.ColumnHeader FileSize;
        private System.Windows.Forms.TextBox txt_ConsoleOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_OpenPreset;
        private System.Windows.Forms.ToolStripMenuItem menu_SaveAsPreset;
        private System.Windows.Forms.Button btn_SelectAssemblyDirectory;
        private System.Windows.Forms.TextBox txt_AssemblyDirectory;
        private System.Windows.Forms.Label lbl_PendingText;
        private System.Windows.Forms.TabPage tab_TestsPassed;
        private System.Windows.Forms.ListView list_TestsPassed;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabPage tab_TestsFailed;
        private System.Windows.Forms.TabPage tab_TestsSkipped;
        private System.Windows.Forms.ListView list_TestsFailed;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView list_TestsSkipped;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TabPage tab_TestsInconclusive;
        private System.Windows.Forms.ListView list_TestsInconclusive;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label lbl_PassedText;
        private System.Windows.Forms.Label lbl_PendingNumber;
        private System.Windows.Forms.Label lbl_SkippedNumber;
        private System.Windows.Forms.Label lbl_SkippedTest;
        private System.Windows.Forms.Label lbl_FailedNumber;
        private System.Windows.Forms.Label lbl_FailedText;
        private System.Windows.Forms.Label lbl_InconclusiveNumber;
        private System.Windows.Forms.Label lbl_InconclusiveText;
        private System.Windows.Forms.Label lbl_PassedNumber;



    }
}

