﻿using SoftwareInventoryExplorer.data;
using SoftwareInventoryExplorer.Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareInventoryExplorer.Util;
using System.IO;
using SoftwareInventoryExplorer.ReportForms;
using SoftwareInventoryExplorer.data.Reporting;

namespace SoftwareInventoryExplorer
{
    public partial class MainForm : Form
    {

        #region Properties and private members
        private String _projectPath;

        private bool _edited = false;

        private InventoryProject _openProject;
        public InventoryProject OpenProject
        {
            get
            {
                if (_openProject == null)
                {
                    _openProject = new InventoryProject();
                }
                setPageTitleWithProject();
                return _openProject;
            }
        }

        private Dictionary<String, TabPage> _tabPages;
        private Dictionary<String, TabPage> TabPages
        {
            get
            {
                if (_tabPages == null)
                {
                    _tabPages = new Dictionary<string, TabPage>();
                }
                return _tabPages;
            }
        }
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region Data Table Creation and Population
        private DataTable createSoftwareTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Software Name");
            table.Columns.Add("Display Name");
            table.Columns.Add("Version");
            table.Columns.Add("Major Version");
            table.Columns.Add("Minor Version");
            table.Columns.Add("Software Code");
            return table;
        }

        private DataTable createSccmSoftwareTable()
        {
            DataTable table = createSoftwareTable();
            DataColumn col = table.Columns.Add("Install Count");
            col.SetOrdinal(0);
            return table;
        }

        private DataTable createApprovedSoftwareTable()
        {
            DataTable table = createSoftwareTable();
            DataColumn col = table.Columns.Add("Approval Type");
            col.SetOrdinal(0);
            return table;
        }

        private DataTable createReportTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Name");
            table.Columns.Add("Author");
            table.Columns.Add("Created Date");
            return table;
        }

        private DataRow createRowFromReport(DataTable reportTable, SoftwareReport report)
        {
            DataRow result = reportTable.NewRow();
            result["Name"] = report.Name;
            result["Author"] = report.CreatedBy;
            result["Created Date"] = report.CreationDate;
            return result;
        }

        private void loadReportDataFromList(List<SoftwareReport> reports)
        {
            DataTable table = createReportTable();
            foreach (SoftwareReport report in reports)
            {
                table.Rows.Add(createRowFromReport(table, report));
            }
            reportsDataGridView.DataSource = table;
            reportsDataGridView.ClearSelection();
            reportsDataGridView.CurrentCell = null;
        }

        private void loadSccmDataFromTableEntryList(List<SoftwareInventoryTableEntry> tableEntries)
        {
            DataTable table = createSccmSoftwareTable();
            foreach (SoftwareInventoryTableEntry entry in tableEntries)
            {
                DataRow row = table.NewRow();
                row["Install Count"] = entry.Count;
                row["Software Name"] = entry.Software.ProductName;
                row["Display Name"] = entry.Software.DisplayName;
                row["Version"] = entry.Software.ProductVersionString;
                row["Major Version"] = entry.Software.MajorVersion;
                row["Minor Version"] = entry.Software.MinorVersion;
                row["Software Code"] = entry.Software.SoftwareCode;
                table.Rows.Add(row);
            }
            sccmDataTable.DataSource = table;
            for (int i = 0; i < sccmDataTable.RowCount; i++)
            {
                if (tableEntries[i].IsHighlighted)
                {
                    highlightSccmRow(sccmDataTable.Rows[i], tableEntries[i].ForegroundColor, tableEntries[i].BackgroundColor);
                }
                else
                {
                    unhighlightSccmRow(sccmDataTable.Rows[i]);
                }
            }
            sccmDataTable.ClearSelection();
            sccmDataTable.CurrentCell = null;
        }

        private void loadApprovedSoftwareTableFromList(List<ApprovedSoftware> approvedSoftware)
        {
            DataTable table = createApprovedSoftwareTable();
            foreach (ApprovedSoftware item in approvedSoftware)
            {
                DataRow row = table.NewRow();
                row["Approval Type"] = item.ApprovedBy;
                row["Software Name"] = item.SoftwareExample.ProductName;
                row["Display Name"] = item.SoftwareExample.DisplayName;
                row["Software Code"] = item.SoftwareExample.SoftwareCode;
                switch (item.ApprovedBy)
                {
                    case ApprovedSoftware.ApprovedByCodes.MAJOR_VERSION:
                    case ApprovedSoftware.ApprovedByCodes.MAJOR_VERSION_OR_GREATER:
                        row["Version"] = null;
                        row["Major Version"] = item.SoftwareExample.MajorVersion;
                        row["Minor Version"] = null;
                        break;
                    case ApprovedSoftware.ApprovedByCodes.FULL_VERSION:
                        row["Version"] = item.SoftwareExample.ProductVersionString;
                        row["Major Version"] = item.SoftwareExample.MajorVersion;
                        row["Minor Version"] = item.SoftwareExample.MinorVersion;
                        break;
                    case ApprovedSoftware.ApprovedByCodes.ALL:
                        row["Version"] = null;
                        row["Major Version"] = null;
                        row["Minor Version"] = null;
                        break;
                }
                table.Rows.Add(row);
            }
            approvedSoftwareDataGrid.DataSource = table;
            approvedSoftwareDataGrid.ClearSelection();
            approvedSoftwareDataGrid.CurrentCell = null;
        }

        private void highlightSccmRow(DataGridViewRow row, Nullable<int> foregroundColorArgb, Nullable<int> backgroundColorArgb)
        {

            Color foregroundColor = SystemColors.ControlText;
            Color backgroundColor = Color.LightGreen;
            if (foregroundColorArgb != null)
            {
                foregroundColor = Color.FromArgb(foregroundColorArgb.Value);
            }
            if (backgroundColorArgb != null)
            {
                backgroundColor = Color.FromArgb(backgroundColorArgb.Value);
            }
            row.DefaultCellStyle.ForeColor = foregroundColor;
            row.DefaultCellStyle.BackColor = backgroundColor;
        }

        private void unhighlightSccmRow(DataGridViewRow row)
        {
            row.DefaultCellStyle.BackColor = Color.White;
            row.DefaultCellStyle.ForeColor = SystemColors.ControlText;
        }

        private List<SoftwareInventoryTableEntry> getDataFromSccm()
        {

            SccmDataProvider dataProvider = new SccmDataProvider();
            List<SoftwareInventoryTableEntry> tableEntries = dataProvider.getSoftwareInventoryFromSccm();
            return tableEntries;
        }

        private void databindApprovedSoftwareLists()
        {
            approvedListsBox.DataSource = null;
            approvedListsBox.DataSource = OpenProject.ApprovedSoftwareLists;
            approvedListsBox.DisplayMember = "Name";
        }

        private void approveSelectedSoftware(ApprovedSoftwareList list, ApprovedSoftware.ApprovedByCodes approvedBy)
        {
            foreach (DataGridViewRow row in sccmDataTable.SelectedRows)
            {
                _edited = true;
                int currentIndex = row.Index;
                list.addSoftware(approvedBy, OpenProject.SccmTableEntries[currentIndex].Software);
                OpenProject.SccmTableEntries[currentIndex].IsHighlighted = true;
                highlightSccmRow(row, list.ForegroundColor, list.BackgroundColor);
            }
        }

        private bool softwareIdShouldBeHighlighted(Software softwareExample)
        {
            bool result = false;
            foreach (ApprovedSoftwareList list in OpenProject.ApprovedSoftwareLists)
            {
                result = list.softwareIsInList(softwareExample);
                result = true;
            }
            return result;
        }

        private void highlightSoftwareEntries(List<SoftwareInventoryTableEntry> entries)
        {
            //get all approved software codes from all lists
            List<string> allApprovedSoftwareCodes = new List<string>();
            foreach (ApprovedSoftwareList list in OpenProject.ApprovedSoftwareLists)
            {
                List<string> currentListSoftwareCodes =
                    (from entry in list.ApprovedSoftwares
                     select entry.SoftwareExample.SoftwareCode
                    ).ToList();
                allApprovedSoftwareCodes = allApprovedSoftwareCodes.Concat(currentListSoftwareCodes).ToList();
            }
            allApprovedSoftwareCodes = allApprovedSoftwareCodes.Distinct().ToList();
            //filter table entries to only relevant entries
            List<SoftwareInventoryTableEntry> relevantEntries =
                (from entry in entries
                 where allApprovedSoftwareCodes.Contains(entry.Software.SoftwareCode)
                 select entry).ToList();
            //for each list, highlight the relevant entries and remove them from the set to be checked
            foreach (ApprovedSoftwareList list in OpenProject.ApprovedSoftwareLists)
            {
                relevantEntries = relevantEntries.Except(hightlightSoftwareEntiresForList(relevantEntries, list)).ToList();
            }
        }

        private void refreshHighlights()
        {
            int tableScrollPosition = sccmDataTable.FirstDisplayedScrollingRowIndex;
            highlightSoftwareEntries(OpenProject.SccmTableEntries);
            loadSccmDataFromTableEntryList(OpenProject.SccmTableEntries);
            sccmDataTable.FirstDisplayedScrollingRowIndex = tableScrollPosition;
        }
        #endregion

        #region UI Setup
        private void setPageTitleWithProject()
        {
            StringBuilder titleBuilder = new StringBuilder("Software Inventory Explorer - ");
            if (_projectPath.IsNullOrEmpty())
            {
                titleBuilder.Append("Unnamed Project");
            } else
            {
                String filename = Path.GetFileName(_projectPath);
                titleBuilder.Append(filename);
            }
            if (_edited)
            {
                titleBuilder.Append("*");
            }
            Text = titleBuilder.ToString();
        }

        private void loadSccmEntriesFromProject()
        {
            loadSccmDataFromTableEntryList(OpenProject.SccmTableEntries);
            if (OpenProject.SccmSoftwareScrollPosition != null) sccmDataTable.FirstDisplayedScrollingRowIndex = OpenProject.SccmSoftwareScrollPosition.Value;
        }

        private void setupUiFromProject()
        {
            if (OpenProject.SccmTableEntries != null && OpenProject.SccmTableEntries.Count > 0)
            {
                displayTabPage("sccmViewTab", false);
                loadSccmEntriesFromProject();
                programTabControl.SelectTab(TabPages["sccmViewTab"]);
            }
            databindApprovedSoftwareLists();
            if (OpenProject.ApprovedSoftwareLists != null && OpenProject.ApprovedSoftwareLists.Count > 0)
            {
                displayTabPage("approvedSoftwareLists", false);
            }
            if (OpenProject.Reports != null && OpenProject.Reports.Count > 0)
            {
                displayTabPage("reports", false);
                loadReportDataFromList(OpenProject.Reports);
            }
            if (!OpenProject.OpenTabKey.IsNullOrEmpty())
            {
                programTabControl.SelectedTab = TabPages[OpenProject.OpenTabKey];
            }
        }

        private void gatherTabPagesAndHide()
        {
            foreach (TabPage page in programTabControl.TabPages)
            {
                TabPages[page.Name] = page;
                programTabControl.TabPages.Remove(page);
            }
            programTabControl.Visible = false;
            _edited = false;
            OpenProject.OpenTabKey = null;
        }

        private void displayTabPage(String tabname)
        {
            displayTabPage(tabname, true);
        }

        private void displayTabPage(String tabName, bool updateSelectedTab)
        {
            programTabControl.Visible = true;
            if (!programTabControl.TabPages.Contains(TabPages[tabName]))
            {
                programTabControl.TabPages.Add(TabPages[tabName]);
            }
            if (updateSelectedTab) programTabControl.SelectedTab = TabPages[tabName];
        }
        #endregion

        #region Prompts
        private DialogResult promptForConnectionString()
        {
            ConnestionStringPrompt prompt = new ConnestionStringPrompt();
            return prompt.ShowDialog();
        }

        private String promptForNewSoftwareList(bool showSoftwareListAfterCreation)
        {
            ApprovedSoftwareListNamePrompt namePrompt = new ApprovedSoftwareListNamePrompt();
            namePrompt.ShowDialog();
            String listName = null;
            if (namePrompt.DialogResult == DialogResult.OK)
            {
                listName = namePrompt.ApprovedSoftwareListName;
                _edited = true;
                ApprovedSoftwareList newList = new ApprovedSoftwareList(listName);
                OpenProject.ApprovedSoftwareLists.Add(newList);
                databindApprovedSoftwareLists();
                if (showSoftwareListAfterCreation)
                {
                    displayTabPage("approvedSoftwareLists");
                    approvedListsBox.SelectedItem = newList;
                }
            }
            return listName;
        }

        private bool promptForNewSoftwareListIfNoneAvailable(bool showSoftwareListAfterCreation)
        {
            String resultName = null;
            if (OpenProject.ApprovedSoftwareLists.Count == 0)
            {
                resultName = promptForNewSoftwareList(showSoftwareListAfterCreation);
            }
            else
            {
                resultName = OpenProject.ApprovedSoftwareLists.First<ApprovedSoftwareList>().Name;
            }
            return resultName != null;
        }
        #endregion

        #region Project Saving and Opening
        private void openProject()
        {
            flushAllDataSources();
            gatherTabPagesAndHide();
            if (openProjectFileDialog.ShowDialog() == DialogResult.OK)
            {
                String filePath = openProjectFileDialog.FileName;
                _openProject = InventoryProjectManager.openProject(filePath);
                setupUiFromProject();
                _edited = false;
                _projectPath = filePath;
                setPageTitleWithProject();
            }
        }

        private void saveProject()
        {
            if (_projectPath.IsNullOrEmpty())
            {
                saveProjectAs();
            } else
            {
                saveProjectToFile(_projectPath);
            }
        }

        private void saveProjectAs()
        {
            if (saveProjectFileDialog.ShowDialog() == DialogResult.OK)
            {
                String filePath = saveProjectFileDialog.FileName;
                saveProjectToFile(filePath);
            }
        }

        private void saveProjectToFile(String filePath)
        {
            if (sccmDataTable.RowCount > 0)
            {
                OpenProject.SccmSoftwareScrollPosition = sccmDataTable.FirstDisplayedScrollingRowIndex;
            }
            InventoryProjectManager.saveProject(OpenProject, filePath);
            _edited = false;
            _projectPath = filePath;
            setPageTitleWithProject();
        }

        private void flushAllDataSources()
        {
            approvedSoftwareDataGrid.DataSource = null;
            reportsDataGridView.DataSource = null;
            approvedListsBox.DataSource = null;
            sccmDataTable.DataSource = null;
        }

        private void newProject()
        {
            bool cancelled = false;
            if (_edited)
            {
                SaveBeforeClosePrompt prompt = new SaveBeforeClosePrompt();
                if (prompt.ShowDialog() == DialogResult.Cancel)
                {
                    cancelled = true;
                }
            }
            if (!cancelled)
            {
                flushAllDataSources();
                _projectPath = null;
                _openProject = new InventoryProject();
                gatherTabPagesAndHide();
                _edited = false;
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            gatherTabPagesAndHide();
        }

        #region Menu Event Handlers
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void setSCCMConnectionStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            promptForConnectionString();
        }

        private void getDataFromSCCMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String connectionString = AppSettings.GetInstance().ConnectionString;
            if (connectionString == null || connectionString.Trim().Equals(String.Empty))
            {
                if (promptForConnectionString() != DialogResult.OK)
                {
                    return;
                }
            }
            displayTabPage("sccmViewTab");
            List<SoftwareInventoryTableEntry> entries = getDataFromSccm();
            highlightSoftwareEntries(entries);
            _edited = true;
            OpenProject.SccmTableEntries = entries;
            loadSccmDataFromTableEntryList(entries);
        }

        private void approvedSoftwareListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            promptForNewSoftwareList(true);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveProject();
        }

        private void openInventoryProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openProject();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveProjectAs();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            promptToCreateReport();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void newInventoryProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newProject();
        }
        #endregion

        #region Context Menu Event Handlers
        private void addSelectedSoftwareToApprovedSoftwareListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            promptToAddSelectedSccmEntriesToList();
        }

        private void runReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            runSelectedReport();
        }

        private void editReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            promptToEditReport(getSelectedSoftwareReport());
        }

        private void deleteReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteSelectedReport();
        }

        private void deleteSelectedFromListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteSelectedApprovedEntries();
        }
        #endregion

        #region Report Helpers
        private void deleteReportAndReloadDataView(SoftwareReport report)
        {
            OpenProject.Reports.Remove(report);
            _edited = true;
            loadReportDataFromList(OpenProject.Reports);
        }

        private void promptToCreateReport()
        {
            ReportBuilder form = new ReportBuilder(OpenProject);
            if (form.ShowDialog() == DialogResult.OK)
            {
                OpenProject.Reports.Add(form.Report);
                loadReportDataFromList(OpenProject.Reports);
                displayTabPage("reports");
            }
        }

        private void promptToEditReport(SoftwareReport report)
        {
            ReportBuilder form = new ReportBuilder(OpenProject);
            form.Report = report;
            if (form.ShowDialog() == DialogResult.OK)
            {
                loadReportDataFromList(OpenProject.Reports);
                displayTabPage("reports");
            }
        }

        private void runSelectedReport()
        {
            ReportDisplay displayForm = new ReportDisplay(getSelectedSoftwareReport(), OpenProject);
            displayForm.ShowDialog();
        }

        private void deleteSelectedReport()
        {
            SoftwareReport report = getSelectedSoftwareReport();
            if (report != null)
            {
                if (MessageBox.Show("Are you certain you wish to delete the selected report?", "Delete Report", MessageBoxButtons.OKCancel)
                    == DialogResult.OK)
                {
                    deleteReportAndReloadDataView(report);
                }
            }
        }

        private SoftwareReport getSelectedSoftwareReport()
        {
            int selectedRowIndex = reportsDataGridView.SelectedRows[0].Index;
            SoftwareReport selectedReport = OpenProject.Reports[selectedRowIndex];
            return selectedReport;
        }
        #endregion

        #region SCCM Data Helpers
        private List<SoftwareInventoryTableEntry> hightlightSoftwareEntiresForList(List<SoftwareInventoryTableEntry> entries, ApprovedSoftwareList list)
        {
            List<SoftwareInventoryTableEntry> highlightedEntries = new List<SoftwareInventoryTableEntry>();
            foreach (ApprovedSoftware approval in list.ApprovedSoftwares)
            {
                List<SoftwareInventoryTableEntry> matchingEntries =
                    (from entry in entries
                     where approval.softwareMatches(entry.Software)
                     select entry).ToList();
                foreach (SoftwareInventoryTableEntry entry in matchingEntries)
                {
                    entry.IsHighlighted = true;
                    entry.ForegroundColor = list.ForegroundColor;
                    entry.BackgroundColor = list.BackgroundColor;
                    highlightedEntries.Add(entry);
                }
            }
            return highlightedEntries;
        }

        private void promptToAddSelectedSccmEntriesToList()
        {
            if (sccmDataTable.SelectedRows.Count > 0)
            {
                if (promptForNewSoftwareListIfNoneAvailable(false))
                {
                    ApproveSoftwareEntriesPrompt dialogPrompt = new ApproveSoftwareEntriesPrompt();
                    dialogPrompt.NumberOfEntries = sccmDataTable.SelectedRows.Count;
                    dialogPrompt.ApprovedSoftwareLists = OpenProject.ApprovedSoftwareLists;
                    if (dialogPrompt.ShowDialog() == DialogResult.OK)
                    {
                        if (!OpenProject.ApprovedSoftwareLists.Contains(dialogPrompt.SelectedList))
                        {
                            OpenProject.ApprovedSoftwareLists.Add(dialogPrompt.SelectedList);
                            databindApprovedSoftwareLists();
                        }
                        approveSelectedSoftware(dialogPrompt.SelectedList, dialogPrompt.ApprovalCode);
                        approvedListsBox.SelectedItem = dialogPrompt.SelectedList;
                        loadApprovedSoftwareTableFromList(dialogPrompt.SelectedList.ApprovedSoftwares);
                        refreshHighlights();
                        displayTabPage("approvedSoftwareLists");
                    }
                }
            }
            else
            {
                MessageBox.Show("No entries selected.");
            }
        }
        #endregion

        #region Approval List Helpers
        private List<ApprovedSoftware> getSelectedApprovalEntries()
        {
            List<ApprovedSoftware> result = new List<ApprovedSoftware>();
            ApprovedSoftwareList selectedApprovedSoftwareList = getSelectedApprovedSoftwareList();
            foreach (DataGridViewBand row in approvedSoftwareDataGrid.SelectedRows)
            {
                int index = row.Index;
                result.Add(selectedApprovedSoftwareList.ApprovedSoftwares[index]);
            }
            return result;
        }

        private ApprovedSoftwareList getSelectedApprovedSoftwareList()
        {
            ApprovedSoftwareList result = null;
            result = (ApprovedSoftwareList)approvedListsBox.SelectedItem;
            return result;
        }

        private void deleteSelectedApprovedEntries()
        {
            if (MessageBox.Show("Are you certain you want to delete the selected software from the list?", "Delete Approved Software", MessageBoxButtons.OKCancel) ==
    DialogResult.OK)
            {
                ApprovedSoftwareList selectedApprovedSoftwareList = getSelectedApprovedSoftwareList();
                foreach (ApprovedSoftware entry in getSelectedApprovalEntries())
                {
                    // Accessing the list directly is faster than the native .removeSoftware method,
                    // which looks for value equivalence vs actual identity.
                    selectedApprovedSoftwareList.ApprovedSoftwares.Remove(entry);
                }
                loadApprovedSoftwareTableFromList(selectedApprovedSoftwareList.ApprovedSoftwares);
            }
        }

        private void updateColorDisplaySample()
        {
            ApprovedSoftwareList list = getSelectedApprovedSoftwareList();
            Color foregroundColor = SystemColors.ControlText;
            Color backgroundColor = Color.LightGreen;
            if (list.ForegroundColor != null)
            {
                foregroundColor = Color.FromArgb(list.ForegroundColor.Value);
            }
            if (list.BackgroundColor != null)
            {
                backgroundColor = Color.FromArgb(list.BackgroundColor.Value);
            }
            colorDisplayExampleLabel.ForeColor = foregroundColor;
            colorDisplayExampleLabel.BackColor = backgroundColor;
        }
        #endregion

        #region SCCM Data Tab Events
        private void addApprovedButton_Click(object sender, EventArgs e)
        {
            promptToAddSelectedSccmEntriesToList();
        }

        private void sccmDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            Software softwareExample = OpenProject.SccmTableEntries[index].Software;
            InstalledMachinesList machinesList = new InstalledMachinesList(softwareExample);
            machinesList.ShowDialog();
        }
        #endregion

        #region Approval List Tab Events
        private void approvedListsBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ApprovedSoftwareList approvedSoftwareList = (ApprovedSoftwareList)approvedListsBox.SelectedItem;
            if (approvedSoftwareList != null)
            {
                loadApprovedSoftwareTableFromList(approvedSoftwareList.ApprovedSoftwares);
                updateColorDisplaySample();
            }
        }

        private void approvedSoftwareDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            bool somethingSelected = approvedSoftwareDataGrid.SelectedRows.Count > 0;
            deleteFromApprovedListButton.Enabled = somethingSelected;
        }

        private void deleteFromApprovedListButton_Click(object sender, EventArgs e)
        {
            deleteSelectedApprovedEntries();
        }

        private void setColorsButton_Click(object sender, EventArgs e)
        {
            ApprovedSoftwareList selectedList = getSelectedApprovedSoftwareList();
            BackgroundAndForegroundColorDialog colorDialog = new BackgroundAndForegroundColorDialog(selectedList.ForegroundColor, selectedList.BackgroundColor);
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedList.ForegroundColor = colorDialog.ForegroundColor;
                selectedList.BackgroundColor = colorDialog.BackgroundColor;
                updateColorDisplaySample();
                highlightSoftwareEntries(OpenProject.SccmTableEntries);
                loadSccmEntriesFromProject();
                _edited = true;
                setPageTitleWithProject();
            }
        }

        private void deleteListButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete Approved List?", "Are you certain you want to delete this approved software list?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                OpenProject.ApprovedSoftwareLists.Remove(getSelectedApprovedSoftwareList());
                databindApprovedSoftwareLists();
            }
        }
        #endregion

        #region Main Form Event Handlers
        private void programTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            _edited = true;
            if (programTabControl.SelectedTab != null)
            {
                OpenProject.OpenTabKey = programTabControl.SelectedTab.Name;
            } 
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_edited)
            {
                SaveBeforeClosePrompt prompt = new SaveBeforeClosePrompt();
                DialogResult result = prompt.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    saveProject();
                }
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion

        #region Reports Tab Events
        private void reportsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            bool anySelected = reportsDataGridView.SelectedRows.Count > 0;
            deleteReportButton.Enabled = anySelected;
            runReportButton.Enabled = anySelected;
            editReportButton.Enabled = anySelected;
        }

        private void addReportButton_Click(object sender, EventArgs e)
        {
            promptToCreateReport();
        }

        private void editReportButton_Click(object sender, EventArgs e)
        {
            promptToEditReport(getSelectedSoftwareReport());
        }

        private void runReportButton_Click(object sender, EventArgs e)
        {
            runSelectedReport();
        }

        private void deleteReportButton_Click(object sender, EventArgs e)
        {
            deleteSelectedReport();
        }

        private void reportsDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo hitTest = reportsDataGridView.HitTest(e.X, e.Y);
                reportsDataGridView.ClearSelection();
                reportsDataGridView.Rows[hitTest.RowIndex].Selected = true;
            }
        }
        #endregion

    }
}
