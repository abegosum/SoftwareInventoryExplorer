namespace SoftwareInventoryExplorer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInventoryProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approvedSoftwareListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getDataFromSCCMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSCCMConnectionStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programTabControl = new System.Windows.Forms.TabControl();
            this.sccmViewTab = new System.Windows.Forms.TabPage();
            this.addApprovedButton = new System.Windows.Forms.Button();
            this.sccmDataTable = new System.Windows.Forms.DataGridView();
            this.sccmGridRightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addSelectedSoftwareToApprovedSoftwareListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approvedSoftwareLists = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.approvedListsBox = new System.Windows.Forms.ListBox();
            this.colorDisplayExampleLabel = new System.Windows.Forms.Label();
            this.setColorsButton = new System.Windows.Forms.Button();
            this.deleteListButton = new System.Windows.Forms.Button();
            this.deleteFromApprovedListButton = new System.Windows.Forms.Button();
            this.approvedSoftwareDataGrid = new System.Windows.Forms.DataGridView();
            this.approvedSoftwareRightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSelectedFromListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reports = new System.Windows.Forms.TabPage();
            this.addReportButton = new System.Windows.Forms.Button();
            this.editReportButton = new System.Windows.Forms.Button();
            this.deleteReportButton = new System.Windows.Forms.Button();
            this.runReportButton = new System.Windows.Forms.Button();
            this.reportsDataGridView = new System.Windows.Forms.DataGridView();
            this.reportRightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.runReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveProjectFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.newInventoryProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.programTabControl.SuspendLayout();
            this.sccmViewTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sccmDataTable)).BeginInit();
            this.sccmGridRightClickMenu.SuspendLayout();
            this.approvedSoftwareLists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.approvedSoftwareDataGrid)).BeginInit();
            this.approvedSoftwareRightClickMenu.SuspendLayout();
            this.reports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataGridView)).BeginInit();
            this.reportRightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newInventoryProjectToolStripMenuItem,
            this.openInventoryProjectToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.addToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openInventoryProjectToolStripMenuItem
            // 
            this.openInventoryProjectToolStripMenuItem.Name = "openInventoryProjectToolStripMenuItem";
            this.openInventoryProjectToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.openInventoryProjectToolStripMenuItem.Text = "Open Inventory Project";
            this.openInventoryProjectToolStripMenuItem.Click += new System.EventHandler(this.openInventoryProjectToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.approvedSoftwareListToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // approvedSoftwareListToolStripMenuItem
            // 
            this.approvedSoftwareListToolStripMenuItem.Name = "approvedSoftwareListToolStripMenuItem";
            this.approvedSoftwareListToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.approvedSoftwareListToolStripMenuItem.Text = "Approved Software List";
            this.approvedSoftwareListToolStripMenuItem.Click += new System.EventHandler(this.approvedSoftwareListToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getDataFromSCCMToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // getDataFromSCCMToolStripMenuItem
            // 
            this.getDataFromSCCMToolStripMenuItem.Name = "getDataFromSCCMToolStripMenuItem";
            this.getDataFromSCCMToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.getDataFromSCCMToolStripMenuItem.Text = "Get Data from SCCM";
            this.getDataFromSCCMToolStripMenuItem.Click += new System.EventHandler(this.getDataFromSCCMToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setSCCMConnectionStringToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // setSCCMConnectionStringToolStripMenuItem
            // 
            this.setSCCMConnectionStringToolStripMenuItem.Name = "setSCCMConnectionStringToolStripMenuItem";
            this.setSCCMConnectionStringToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.setSCCMConnectionStringToolStripMenuItem.Text = "Set SCCM Connection String";
            this.setSCCMConnectionStringToolStripMenuItem.Click += new System.EventHandler(this.setSCCMConnectionStringToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // programTabControl
            // 
            this.programTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.programTabControl.Controls.Add(this.sccmViewTab);
            this.programTabControl.Controls.Add(this.approvedSoftwareLists);
            this.programTabControl.Controls.Add(this.reports);
            this.programTabControl.Location = new System.Drawing.Point(12, 27);
            this.programTabControl.Name = "programTabControl";
            this.programTabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.programTabControl.SelectedIndex = 0;
            this.programTabControl.Size = new System.Drawing.Size(776, 369);
            this.programTabControl.TabIndex = 1;
            this.programTabControl.SelectedIndexChanged += new System.EventHandler(this.programTabControl_SelectedIndexChanged);
            // 
            // sccmViewTab
            // 
            this.sccmViewTab.Controls.Add(this.addApprovedButton);
            this.sccmViewTab.Controls.Add(this.sccmDataTable);
            this.sccmViewTab.Location = new System.Drawing.Point(4, 22);
            this.sccmViewTab.Name = "sccmViewTab";
            this.sccmViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.sccmViewTab.Size = new System.Drawing.Size(768, 343);
            this.sccmViewTab.TabIndex = 2;
            this.sccmViewTab.Text = "Software in SCCM";
            this.sccmViewTab.UseVisualStyleBackColor = true;
            // 
            // addApprovedButton
            // 
            this.addApprovedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addApprovedButton.Location = new System.Drawing.Point(487, 314);
            this.addApprovedButton.Name = "addApprovedButton";
            this.addApprovedButton.Size = new System.Drawing.Size(275, 23);
            this.addApprovedButton.TabIndex = 1;
            this.addApprovedButton.Text = "Add Selected Software to an Approved Software List";
            this.addApprovedButton.UseVisualStyleBackColor = true;
            this.addApprovedButton.Click += new System.EventHandler(this.addApprovedButton_Click);
            // 
            // sccmDataTable
            // 
            this.sccmDataTable.AllowUserToAddRows = false;
            this.sccmDataTable.AllowUserToDeleteRows = false;
            this.sccmDataTable.AllowUserToOrderColumns = true;
            this.sccmDataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sccmDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sccmDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.sccmDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sccmDataTable.ContextMenuStrip = this.sccmGridRightClickMenu;
            this.sccmDataTable.Location = new System.Drawing.Point(3, 6);
            this.sccmDataTable.Name = "sccmDataTable";
            this.sccmDataTable.ReadOnly = true;
            this.sccmDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sccmDataTable.Size = new System.Drawing.Size(759, 302);
            this.sccmDataTable.TabIndex = 0;
            this.sccmDataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sccmDataTable_CellDoubleClick);
            // 
            // sccmGridRightClickMenu
            // 
            this.sccmGridRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSelectedSoftwareToApprovedSoftwareListToolStripMenuItem});
            this.sccmGridRightClickMenu.Name = "sccmGridRightClickMenu";
            this.sccmGridRightClickMenu.ShowImageMargin = false;
            this.sccmGridRightClickMenu.Size = new System.Drawing.Size(307, 26);
            // 
            // addSelectedSoftwareToApprovedSoftwareListToolStripMenuItem
            // 
            this.addSelectedSoftwareToApprovedSoftwareListToolStripMenuItem.Name = "addSelectedSoftwareToApprovedSoftwareListToolStripMenuItem";
            this.addSelectedSoftwareToApprovedSoftwareListToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.addSelectedSoftwareToApprovedSoftwareListToolStripMenuItem.Text = "Add Selected Software to Approved Software List";
            this.addSelectedSoftwareToApprovedSoftwareListToolStripMenuItem.Click += new System.EventHandler(this.addSelectedSoftwareToApprovedSoftwareListToolStripMenuItem_Click);
            // 
            // approvedSoftwareLists
            // 
            this.approvedSoftwareLists.Controls.Add(this.splitContainer1);
            this.approvedSoftwareLists.Location = new System.Drawing.Point(4, 22);
            this.approvedSoftwareLists.Name = "approvedSoftwareLists";
            this.approvedSoftwareLists.Size = new System.Drawing.Size(768, 343);
            this.approvedSoftwareLists.TabIndex = 3;
            this.approvedSoftwareLists.Text = "Approved Software Lists";
            this.approvedSoftwareLists.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.approvedListsBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.colorDisplayExampleLabel);
            this.splitContainer1.Panel2.Controls.Add(this.setColorsButton);
            this.splitContainer1.Panel2.Controls.Add(this.deleteListButton);
            this.splitContainer1.Panel2.Controls.Add(this.deleteFromApprovedListButton);
            this.splitContainer1.Panel2.Controls.Add(this.approvedSoftwareDataGrid);
            this.splitContainer1.Size = new System.Drawing.Size(768, 343);
            this.splitContainer1.SplitterDistance = 137;
            this.splitContainer1.TabIndex = 0;
            // 
            // approvedListsBox
            // 
            this.approvedListsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.approvedListsBox.FormattingEnabled = true;
            this.approvedListsBox.Location = new System.Drawing.Point(0, 0);
            this.approvedListsBox.Name = "approvedListsBox";
            this.approvedListsBox.Size = new System.Drawing.Size(138, 342);
            this.approvedListsBox.TabIndex = 1;
            this.approvedListsBox.SelectedValueChanged += new System.EventHandler(this.approvedListsBox_SelectedValueChanged);
            // 
            // colorDisplayExampleLabel
            // 
            this.colorDisplayExampleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.colorDisplayExampleLabel.AutoSize = true;
            this.colorDisplayExampleLabel.BackColor = System.Drawing.Color.Transparent;
            this.colorDisplayExampleLabel.Location = new System.Drawing.Point(179, 322);
            this.colorDisplayExampleLabel.Name = "colorDisplayExampleLabel";
            this.colorDisplayExampleLabel.Size = new System.Drawing.Size(111, 13);
            this.colorDisplayExampleLabel.TabIndex = 6;
            this.colorDisplayExampleLabel.Text = "Color Display Example";
            // 
            // setColorsButton
            // 
            this.setColorsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.setColorsButton.Location = new System.Drawing.Point(86, 317);
            this.setColorsButton.Name = "setColorsButton";
            this.setColorsButton.Size = new System.Drawing.Size(75, 23);
            this.setColorsButton.TabIndex = 5;
            this.setColorsButton.Text = "Set Colors";
            this.setColorsButton.UseVisualStyleBackColor = true;
            this.setColorsButton.Click += new System.EventHandler(this.setColorsButton_Click);
            // 
            // deleteListButton
            // 
            this.deleteListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteListButton.Location = new System.Drawing.Point(4, 316);
            this.deleteListButton.Name = "deleteListButton";
            this.deleteListButton.Size = new System.Drawing.Size(75, 23);
            this.deleteListButton.TabIndex = 4;
            this.deleteListButton.Text = "Delete List";
            this.deleteListButton.UseVisualStyleBackColor = true;
            // 
            // deleteFromApprovedListButton
            // 
            this.deleteFromApprovedListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteFromApprovedListButton.Enabled = false;
            this.deleteFromApprovedListButton.Location = new System.Drawing.Point(447, 317);
            this.deleteFromApprovedListButton.Name = "deleteFromApprovedListButton";
            this.deleteFromApprovedListButton.Size = new System.Drawing.Size(177, 23);
            this.deleteFromApprovedListButton.TabIndex = 3;
            this.deleteFromApprovedListButton.Text = "Delete Selected From List";
            this.deleteFromApprovedListButton.UseVisualStyleBackColor = true;
            this.deleteFromApprovedListButton.Click += new System.EventHandler(this.deleteFromApprovedListButton_Click);
            // 
            // approvedSoftwareDataGrid
            // 
            this.approvedSoftwareDataGrid.AllowUserToAddRows = false;
            this.approvedSoftwareDataGrid.AllowUserToDeleteRows = false;
            this.approvedSoftwareDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.approvedSoftwareDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.approvedSoftwareDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.approvedSoftwareDataGrid.ContextMenuStrip = this.approvedSoftwareRightClickMenu;
            this.approvedSoftwareDataGrid.Location = new System.Drawing.Point(3, 3);
            this.approvedSoftwareDataGrid.Name = "approvedSoftwareDataGrid";
            this.approvedSoftwareDataGrid.ReadOnly = true;
            this.approvedSoftwareDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.approvedSoftwareDataGrid.Size = new System.Drawing.Size(621, 308);
            this.approvedSoftwareDataGrid.TabIndex = 2;
            this.approvedSoftwareDataGrid.SelectionChanged += new System.EventHandler(this.approvedSoftwareDataGrid_SelectionChanged);
            // 
            // approvedSoftwareRightClickMenu
            // 
            this.approvedSoftwareRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedFromListToolStripMenuItem});
            this.approvedSoftwareRightClickMenu.Name = "approvedSoftwareRightClickMenu";
            this.approvedSoftwareRightClickMenu.ShowImageMargin = false;
            this.approvedSoftwareRightClickMenu.Size = new System.Drawing.Size(180, 26);
            // 
            // deleteSelectedFromListToolStripMenuItem
            // 
            this.deleteSelectedFromListToolStripMenuItem.Name = "deleteSelectedFromListToolStripMenuItem";
            this.deleteSelectedFromListToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.deleteSelectedFromListToolStripMenuItem.Text = "Delete Selected from List";
            this.deleteSelectedFromListToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedFromListToolStripMenuItem_Click);
            // 
            // reports
            // 
            this.reports.Controls.Add(this.addReportButton);
            this.reports.Controls.Add(this.editReportButton);
            this.reports.Controls.Add(this.deleteReportButton);
            this.reports.Controls.Add(this.runReportButton);
            this.reports.Controls.Add(this.reportsDataGridView);
            this.reports.Location = new System.Drawing.Point(4, 22);
            this.reports.Name = "reports";
            this.reports.Padding = new System.Windows.Forms.Padding(3);
            this.reports.Size = new System.Drawing.Size(768, 343);
            this.reports.TabIndex = 4;
            this.reports.Text = "Reports";
            this.reports.UseVisualStyleBackColor = true;
            // 
            // addReportButton
            // 
            this.addReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addReportButton.Location = new System.Drawing.Point(6, 314);
            this.addReportButton.Name = "addReportButton";
            this.addReportButton.Size = new System.Drawing.Size(95, 23);
            this.addReportButton.TabIndex = 4;
            this.addReportButton.Text = "Create Report";
            this.addReportButton.UseVisualStyleBackColor = true;
            this.addReportButton.Click += new System.EventHandler(this.addReportButton_Click);
            // 
            // editReportButton
            // 
            this.editReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editReportButton.Enabled = false;
            this.editReportButton.Location = new System.Drawing.Point(503, 314);
            this.editReportButton.Name = "editReportButton";
            this.editReportButton.Size = new System.Drawing.Size(116, 23);
            this.editReportButton.TabIndex = 3;
            this.editReportButton.Text = "Edit Selected Report";
            this.editReportButton.UseVisualStyleBackColor = true;
            this.editReportButton.Click += new System.EventHandler(this.editReportButton_Click);
            // 
            // deleteReportButton
            // 
            this.deleteReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteReportButton.Enabled = false;
            this.deleteReportButton.Location = new System.Drawing.Point(625, 314);
            this.deleteReportButton.Name = "deleteReportButton";
            this.deleteReportButton.Size = new System.Drawing.Size(137, 23);
            this.deleteReportButton.TabIndex = 2;
            this.deleteReportButton.Text = "Delete Selected Report";
            this.deleteReportButton.UseVisualStyleBackColor = true;
            this.deleteReportButton.Click += new System.EventHandler(this.deleteReportButton_Click);
            // 
            // runReportButton
            // 
            this.runReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.runReportButton.Enabled = false;
            this.runReportButton.Location = new System.Drawing.Point(363, 314);
            this.runReportButton.Name = "runReportButton";
            this.runReportButton.Size = new System.Drawing.Size(134, 23);
            this.runReportButton.TabIndex = 1;
            this.runReportButton.Text = "Run Selected Report";
            this.runReportButton.UseVisualStyleBackColor = true;
            this.runReportButton.Click += new System.EventHandler(this.runReportButton_Click);
            // 
            // reportsDataGridView
            // 
            this.reportsDataGridView.AllowUserToAddRows = false;
            this.reportsDataGridView.AllowUserToDeleteRows = false;
            this.reportsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.reportsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsDataGridView.ContextMenuStrip = this.reportRightClickMenu;
            this.reportsDataGridView.Location = new System.Drawing.Point(6, 26);
            this.reportsDataGridView.MultiSelect = false;
            this.reportsDataGridView.Name = "reportsDataGridView";
            this.reportsDataGridView.ReadOnly = true;
            this.reportsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportsDataGridView.Size = new System.Drawing.Size(756, 282);
            this.reportsDataGridView.TabIndex = 0;
            this.reportsDataGridView.SelectionChanged += new System.EventHandler(this.reportsDataGridView_SelectionChanged);
            this.reportsDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.reportsDataGridView_MouseDown);
            // 
            // reportRightClickMenu
            // 
            this.reportRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runReportToolStripMenuItem,
            this.editReportToolStripMenuItem,
            this.deleteReportToolStripMenuItem});
            this.reportRightClickMenu.Name = "reportRightClickMenu";
            this.reportRightClickMenu.ShowImageMargin = false;
            this.reportRightClickMenu.Size = new System.Drawing.Size(121, 70);
            // 
            // runReportToolStripMenuItem
            // 
            this.runReportToolStripMenuItem.Name = "runReportToolStripMenuItem";
            this.runReportToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.runReportToolStripMenuItem.Text = "Run Report";
            this.runReportToolStripMenuItem.Click += new System.EventHandler(this.runReportToolStripMenuItem_Click);
            // 
            // editReportToolStripMenuItem
            // 
            this.editReportToolStripMenuItem.Name = "editReportToolStripMenuItem";
            this.editReportToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.editReportToolStripMenuItem.Text = "Edit Report";
            this.editReportToolStripMenuItem.Click += new System.EventHandler(this.editReportToolStripMenuItem_Click);
            // 
            // deleteReportToolStripMenuItem
            // 
            this.deleteReportToolStripMenuItem.Name = "deleteReportToolStripMenuItem";
            this.deleteReportToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.deleteReportToolStripMenuItem.Text = "Delete Report";
            this.deleteReportToolStripMenuItem.Click += new System.EventHandler(this.deleteReportToolStripMenuItem_Click);
            // 
            // openProjectFileDialog
            // 
            this.openProjectFileDialog.FileName = "*.sieproj";
            this.openProjectFileDialog.Filter = "Software Inventory Explorer Files|*.sieproj|All files|*.*";
            this.openProjectFileDialog.SupportMultiDottedExtensions = true;
            // 
            // saveProjectFileDialog
            // 
            this.saveProjectFileDialog.FileName = "NewProject.sieproj";
            this.saveProjectFileDialog.Filter = "Software Inventory Explorer Files|*.sieproj|All files|*.*";
            // 
            // newInventoryProjectToolStripMenuItem
            // 
            this.newInventoryProjectToolStripMenuItem.Name = "newInventoryProjectToolStripMenuItem";
            this.newInventoryProjectToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.newInventoryProjectToolStripMenuItem.Text = "New Inventory Project";
            this.newInventoryProjectToolStripMenuItem.Click += new System.EventHandler(this.newInventoryProjectToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.programTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Software Inventory Explorer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.programTabControl.ResumeLayout(false);
            this.sccmViewTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sccmDataTable)).EndInit();
            this.sccmGridRightClickMenu.ResumeLayout(false);
            this.approvedSoftwareLists.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.approvedSoftwareDataGrid)).EndInit();
            this.approvedSoftwareRightClickMenu.ResumeLayout(false);
            this.reports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataGridView)).EndInit();
            this.reportRightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInventoryProjectToolStripMenuItem;
        private System.Windows.Forms.TabControl programTabControl;
        private System.Windows.Forms.TabPage sccmViewTab;
        private System.Windows.Forms.DataGridView sccmDataTable;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getDataFromSCCMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSCCMConnectionStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approvedSoftwareListToolStripMenuItem;
        private System.Windows.Forms.TabPage approvedSoftwareLists;
        private System.Windows.Forms.DataGridView approvedSoftwareDataGrid;
        private System.Windows.Forms.ListBox approvedListsBox;
        private System.Windows.Forms.Button addApprovedButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openProjectFileDialog;
        private System.Windows.Forms.SaveFileDialog saveProjectFileDialog;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.TabPage reports;
        private System.Windows.Forms.Button deleteFromApprovedListButton;
        private System.Windows.Forms.Button addReportButton;
        private System.Windows.Forms.Button editReportButton;
        private System.Windows.Forms.Button deleteReportButton;
        private System.Windows.Forms.Button runReportButton;
        private System.Windows.Forms.DataGridView reportsDataGridView;
        private System.Windows.Forms.ContextMenuStrip sccmGridRightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem addSelectedSoftwareToApprovedSoftwareListToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip reportRightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem runReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteReportToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip approvedSoftwareRightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedFromListToolStripMenuItem;
        private System.Windows.Forms.Button setColorsButton;
        private System.Windows.Forms.Button deleteListButton;
        private System.Windows.Forms.Label colorDisplayExampleLabel;
        private System.Windows.Forms.ToolStripMenuItem newInventoryProjectToolStripMenuItem;
    }
}

