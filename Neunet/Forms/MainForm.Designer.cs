﻿namespace Neunet.Forms
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.samplesImage = new Neunet.Images.Charts2D.SamplesImage();
            this.coefficientsImage = new Neunet.Images.CoefficientsImage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.samplesLabel = new System.Windows.Forms.Label();
            this.derivativesImage = new Neunet.Images.CoefficientsImage();
            this.coefficientsLabel = new System.Windows.Forms.Label();
            this.derivativesLabel = new System.Windows.Forms.Label();
            this.nSampleTextBox = new Neunet.UserControls.IntegerTextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.learnButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.messageStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.changedStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.historyImage = new Neunet.Images.HistoryImage();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.newButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openTrainingSetImageFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTrainingSetLabelFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.calculationSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.applicationDataFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.commonAppDataFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.samplesImage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.coefficientsImage, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.derivativesImage, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.coefficientsLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.derivativesLabel, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 308);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // samplesImage
            // 
            this.samplesImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.samplesImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.samplesImage.Location = new System.Drawing.Point(3, 26);
            this.samplesImage.Margin = new System.Windows.Forms.Padding(0);
            this.samplesImage.Name = "samplesImage";
            this.samplesImage.Size = new System.Drawing.Size(831, 181);
            this.samplesImage.TabIndex = 0;
            // 
            // coefficientsImage
            // 
            this.coefficientsImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.coefficientsImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coefficientsImage.Location = new System.Drawing.Point(3, 233);
            this.coefficientsImage.Margin = new System.Windows.Forms.Padding(0);
            this.coefficientsImage.Name = "coefficientsImage";
            this.coefficientsImage.Size = new System.Drawing.Size(831, 23);
            this.coefficientsImage.TabIndex = 8;
            this.coefficientsImage.Values = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.samplesLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 20);
            this.panel1.TabIndex = 1;
            // 
            // samplesLabel
            // 
            this.samplesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.samplesLabel.Location = new System.Drawing.Point(0, 0);
            this.samplesLabel.Name = "samplesLabel";
            this.samplesLabel.Size = new System.Drawing.Size(831, 20);
            this.samplesLabel.TabIndex = 7;
            this.samplesLabel.Text = "Samples";
            this.samplesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // derivativesImage
            // 
            this.derivativesImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.derivativesImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.derivativesImage.Location = new System.Drawing.Point(3, 282);
            this.derivativesImage.Margin = new System.Windows.Forms.Padding(0);
            this.derivativesImage.Name = "derivativesImage";
            this.derivativesImage.Size = new System.Drawing.Size(831, 23);
            this.derivativesImage.TabIndex = 12;
            this.derivativesImage.Values = null;
            // 
            // coefficientsLabel
            // 
            this.coefficientsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coefficientsLabel.Location = new System.Drawing.Point(6, 210);
            this.coefficientsLabel.Name = "coefficientsLabel";
            this.coefficientsLabel.Size = new System.Drawing.Size(825, 20);
            this.coefficientsLabel.TabIndex = 13;
            this.coefficientsLabel.Text = "Coefficients";
            this.coefficientsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // derivativesLabel
            // 
            this.derivativesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.derivativesLabel.Location = new System.Drawing.Point(6, 259);
            this.derivativesLabel.Name = "derivativesLabel";
            this.derivativesLabel.Size = new System.Drawing.Size(825, 20);
            this.derivativesLabel.TabIndex = 14;
            this.derivativesLabel.Text = "Derivatives";
            this.derivativesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nSampleTextBox
            // 
            this.nSampleTextBox.Format = "G";
            this.nSampleTextBox.Location = new System.Drawing.Point(411, 8);
            this.nSampleTextBox.MaxValue = 100000;
            this.nSampleTextBox.MinValue = 1;
            this.nSampleTextBox.Name = "nSampleTextBox";
            this.nSampleTextBox.Size = new System.Drawing.Size(75, 20);
            this.nSampleTextBox.TabIndex = 1;
            this.nSampleTextBox.Text = "25";
            this.nSampleTextBox.Value = 25;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(330, 6);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // learnButton
            // 
            this.learnButton.Location = new System.Drawing.Point(168, 6);
            this.learnButton.Name = "learnButton";
            this.learnButton.Size = new System.Drawing.Size(75, 23);
            this.learnButton.TabIndex = 2;
            this.learnButton.Text = "Learn";
            this.learnButton.UseVisualStyleBackColor = true;
            this.learnButton.Click += new System.EventHandler(this.LearnButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(249, 6);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.messageStatusLabel,
            this.changedStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 536);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(837, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // messageStatusLabel
            // 
            this.messageStatusLabel.Name = "messageStatusLabel";
            this.messageStatusLabel.Size = new System.Drawing.Size(56, 17);
            this.messageStatusLabel.Text = "Message.";
            // 
            // changedStatusLabel
            // 
            this.changedStatusLabel.Name = "changedStatusLabel";
            this.changedStatusLabel.Size = new System.Drawing.Size(145, 17);
            this.changedStatusLabel.Text = "The network has changed.";
            this.changedStatusLabel.Visible = false;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.historyImage);
            this.mainPanel.Controls.Add(this.buttonPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(837, 200);
            this.mainPanel.TabIndex = 11;
            // 
            // historyImage
            // 
            this.historyImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.historyImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyImage.InnerConnection = Neunet.Images.ConnectionTypeEnum.Line;
            this.historyImage.Location = new System.Drawing.Point(0, 34);
            this.historyImage.Magnification = 1;
            this.historyImage.Margin = new System.Windows.Forms.Padding(0);
            this.historyImage.Name = "historyImage";
            this.historyImage.OuterConnection = Neunet.Images.ConnectionTypeEnum.Line;
            this.historyImage.PointSize = 14F;
            this.historyImage.Size = new System.Drawing.Size(837, 166);
            this.historyImage.TabIndex = 10;
            this.historyImage.VAxisText = "Cost value";
            this.historyImage.ViewPoints = false;
            this.historyImage.Zoom = 0.95F;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.newButton);
            this.buttonPanel.Controls.Add(this.editButton);
            this.buttonPanel.Controls.Add(this.stopButton);
            this.buttonPanel.Controls.Add(this.nSampleTextBox);
            this.buttonPanel.Controls.Add(this.learnButton);
            this.buttonPanel.Controls.Add(this.calculateButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Padding = new System.Windows.Forms.Padding(3);
            this.buttonPanel.Size = new System.Drawing.Size(837, 34);
            this.buttonPanel.TabIndex = 11;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(6, 6);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 8;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.NewMenuItem_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(87, 6);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditMenuItem_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.toolsMenu,
            this.helpMenu});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(837, 24);
            this.mainMenuStrip.TabIndex = 12;
            this.mainMenuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.toolStripSeparator2,
            this.openMenuItem,
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.toolStripSeparator1,
            this.openTrainingSetImageFileMenuItem,
            this.openTrainingSetLabelFileMenuItem,
            this.toolStripSeparator4,
            this.exitMenuItem});
            this.fileMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // newMenuItem
            // 
            this.newMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.Size = new System.Drawing.Size(220, 22);
            this.newMenuItem.Text = "&New";
            this.newMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(217, 6);
            // 
            // openMenuItem
            // 
            this.openMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuItem.Size = new System.Drawing.Size(220, 22);
            this.openMenuItem.Text = "&Open";
            this.openMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(220, 22);
            this.saveMenuItem.Text = "&Save";
            this.saveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.Size = new System.Drawing.Size(220, 22);
            this.saveAsMenuItem.Text = "Save &As";
            this.saveAsMenuItem.Click += new System.EventHandler(this.SaveAsMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // openTrainingSetImageFileMenuItem
            // 
            this.openTrainingSetImageFileMenuItem.Name = "openTrainingSetImageFileMenuItem";
            this.openTrainingSetImageFileMenuItem.Size = new System.Drawing.Size(220, 22);
            this.openTrainingSetImageFileMenuItem.Text = "Open training set image file";
            this.openTrainingSetImageFileMenuItem.Click += new System.EventHandler(this.OpenTrainingSetImageFileMenuItem_Click);
            // 
            // openTrainingSetLabelFileMenuItem
            // 
            this.openTrainingSetLabelFileMenuItem.Name = "openTrainingSetLabelFileMenuItem";
            this.openTrainingSetLabelFileMenuItem.Size = new System.Drawing.Size(220, 22);
            this.openTrainingSetLabelFileMenuItem.Text = "Open training set label file";
            this.openTrainingSetLabelFileMenuItem.Click += new System.EventHandler(this.OpenTrainingSetLabelFileMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(217, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(220, 22);
            this.exitMenuItem.Text = "E&xit";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculationSettingsToolStripMenuItem,
            this.toolStripSeparator5,
            this.applicationDataFolder,
            this.commonAppDataFolderToolStripMenuItem,
            this.programFolderToolStripMenuItem});
            this.toolsMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(46, 20);
            this.toolsMenu.Text = "&Tools";
            // 
            // calculationSettingsToolStripMenuItem
            // 
            this.calculationSettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.calculationSettingsToolStripMenuItem.Name = "calculationSettingsToolStripMenuItem";
            this.calculationSettingsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.calculationSettingsToolStripMenuItem.Text = "Calculation settings";
            this.calculationSettingsToolStripMenuItem.Click += new System.EventHandler(this.CalculationSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(202, 6);
            // 
            // applicationDataFolder
            // 
            this.applicationDataFolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.applicationDataFolder.Name = "applicationDataFolder";
            this.applicationDataFolder.Size = new System.Drawing.Size(205, 22);
            this.applicationDataFolder.Text = "AppData folder";
            this.applicationDataFolder.ToolTipText = "folder: C:\\Users\\<user>\\AppData\\Roaming\\FRESH3";
            this.applicationDataFolder.Click += new System.EventHandler(this.ApplicationDataFolder_Click);
            // 
            // commonAppDataFolderToolStripMenuItem
            // 
            this.commonAppDataFolderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.commonAppDataFolderToolStripMenuItem.Name = "commonAppDataFolderToolStripMenuItem";
            this.commonAppDataFolderToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.commonAppDataFolderToolStripMenuItem.Text = "CommonAppData folder";
            this.commonAppDataFolderToolStripMenuItem.Click += new System.EventHandler(this.CommonAppDataFolderToolStripMenuItem_Click);
            // 
            // programFolderToolStripMenuItem
            // 
            this.programFolderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.programFolderToolStripMenuItem.Name = "programFolderToolStripMenuItem";
            this.programFolderToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.programFolderToolStripMenuItem.Text = "Program folder";
            this.programFolderToolStripMenuItem.Click += new System.EventHandler(this.ProgramFolderToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.mainPanel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer.Size = new System.Drawing.Size(837, 512);
            this.splitContainer.SplitterDistance = 200;
            this.splitContainer.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 558);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.statusStrip);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            this.buttonPanel.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Images.Charts2D.SamplesImage samplesImage;
        private System.Windows.Forms.Label samplesLabel;
        private System.Windows.Forms.Button learnButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel messageStatusLabel;
        private Images.CoefficientsImage coefficientsImage;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem calculationSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem applicationDataFolder;
        private System.Windows.Forms.ToolStripMenuItem commonAppDataFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openTrainingSetImageFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTrainingSetLabelFileMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel changedStatusLabel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panel1;
        private UserControls.IntegerTextBox nSampleTextBox;
        private Images.HistoryImage historyImage;
        private System.Windows.Forms.Panel buttonPanel;
        private Images.CoefficientsImage derivativesImage;
        private System.Windows.Forms.Label coefficientsLabel;
        private System.Windows.Forms.Label derivativesLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button newButton;
    }
}

