using SoftwareInventoryExplorer.data;
using SoftwareInventoryExplorer.data.Reporting;
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

namespace SoftwareInventoryExplorer.ReportForms
{
    public partial class ReportDisplay : Form
    {

        private SoftwareReport _report;

        private InventoryProject _projectContext;

        public ReportDisplay(SoftwareReport report, InventoryProject projectContext)
        {
            InitializeComponent();
            _report = report;
            _projectContext = projectContext;
        }

        private DataTable createSoftwareTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Install Count");
            table.Columns.Add("Software Name");
            table.Columns.Add("Display Name");
            table.Columns.Add("Version");
            table.Columns.Add("Major Version");
            table.Columns.Add("Minor Version");
            table.Columns.Add("Software Code");
            return table;
        }

        private DataRow getRowForReportEntry(DataTable reportTable, SoftwareInventoryTableEntry entry)
        {
            DataRow row = reportTable.NewRow();
            row["Install Count"] = entry.Count;
            row["Software Name"] = entry.Software.ProductName;
            row["Display Name"] = entry.Software.DisplayName;
            row["Version"] = entry.Software.ProductVersionString;
            row["Major Version"] = entry.Software.MajorVersion;
            row["Minor Version"] = entry.Software.MinorVersion;
            row["Software Code"] = entry.Software.SoftwareCode;
            return row;
        }

        private void loadTableFromReportResults(List<SoftwareInventoryTableEntry> entries)
        {
            DataTable table = createSoftwareTable();
            foreach (SoftwareInventoryTableEntry entry in entries)
            {
                table.Rows.Add(getRowForReportEntry(table, entry));
            }
            reportResultsGridView.DataSource = table;
        }

        private void populateFormFromReport()
        {
            reportNameLabel.Text = _report.Name;
            loadTableFromReportResults(_report.runReport(_projectContext));
        }

        private void ReportDisplay_Load(object sender, EventArgs e)
        {
            populateFormFromReport();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
