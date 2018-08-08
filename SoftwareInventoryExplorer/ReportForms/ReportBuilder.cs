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
    public partial class ReportBuilder : Form
    {

        private InventoryProject _projectContext;

        public ReportBuilder(InventoryProject projectContext)
        {
            InitializeComponent();
            _projectContext = projectContext;
        }

        private SoftwareReport _report;
        public SoftwareReport Report
        {
            get
            {
                if (_report == null)
                {
                    _report = new SoftwareReport();
                }
                return _report;
            }
            set
            {
                _report = value;
            }
        }

        private void refreshFilterTableFromReport()
        {
            DataTable filtersTable = createFiltersTable();
            foreach (ReportFilter filter in Report.Filters)
            {
                filtersTable.Rows.Add(createRowForFilter(filtersTable, filter));
            }
            filtersGridView.DataSource = filtersTable;
        }

        private void loadFormFromReport()
        {
            bindReportSourcesDropDown();
            reportNameTextBox.Text = Report.Name;
            reportSourceDropDown.SelectedValue = Report.DataSource;
            modifiedByLabel.Text = "Created by: " + Report.CreatedBy;
            modifiedDateLabel.Text = "Created on: " + Report.CreationDate.ToString();
            refreshFilterTableFromReport();
        }

        private void updateReportFromForm()
        {
            Report.Name = reportNameTextBox.Text;
            Report.DataSource = (ReportDataSource) reportSourceDropDown.SelectedValue;
        }

        private DataTable createFiltersTable()
        {
            DataTable result = new DataTable();
            result.Columns.Add("Description");
            result.Columns.Add("Filter Type");
            return result;
        }

        private DataRow createRowForFilter(DataTable sourceTable, ReportFilter filter)
        {
            DataRow result = sourceTable.NewRow();
            result["Description"] = filter.ToString();
            result["Filter Type"] = filter.FilterType;
            return result;
        }

        private void bindReportSourcesDropDown()
        {
            List<KeyValuePair<String, Object>> enumTypes = new List<KeyValuePair<String, Object>>();
            foreach (ReportDataSource source in Enum.GetValues(typeof(ReportDataSource)))
            {
                KeyValuePair<String, Object> currentEnumVal = new KeyValuePair<string, object>(source.ToString(), source);
                enumTypes.Add(currentEnumVal);
            }
            reportSourceDropDown.DisplayMember = "Key";
            reportSourceDropDown.ValueMember = "Value";
            reportSourceDropDown.DataSource = enumTypes;
        }

        private ReportFilter showEditApprovedSoftwareListFilterForm(ReportFilter reportFilter)
        {
            ReportFilter result = null;
            if (_projectContext.ApprovedSoftwareLists.Count > 0)
            {
                AddApprovedSoftwareListFilterForm form = new AddApprovedSoftwareListFilterForm(_projectContext);
                form.Filter = reportFilter;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    result = form.Filter;
                }
            } else
            {
                MessageBox.Show("No approved software lists exist.");
            }
            return result;
        }

        private ReportFilter getSelectedFilter()
        {
            ReportFilter result = null;
            if (filtersGridView.SelectedRows.Count > 0)
            {
                int filterIndex = filtersGridView.SelectedRows[0].Index;
                result = Report.Filters[filterIndex];
            }
            return result;
        }

        private void promptToEditFilter(ReportFilter filter)
        {
            switch (filter.FilterType)
            {
                case FilterType.APPROVED_SOFTWARE_LIST:
                    showEditApprovedSoftwareListFilterForm(filter);
                    break;
            }
        }

        private void deleteFilter(ReportFilter filter)
        {
            Report.Filters.Remove(filter);
        }

        private void ReportBuilder_Load(object sender, EventArgs e)
        {
            loadFormFromReport();
        }

        private void addFilterButton_Click(object sender, EventArgs e)
        {
            ReportFilter addingFilter = null;
            FilterEditorAddPrompt typePrompt = new FilterEditorAddPrompt();
            if (typePrompt.ShowDialog() == DialogResult.OK)
            {
                addingFilter = showEditApprovedSoftwareListFilterForm(null);
            }
            if (addingFilter != null)
            {
                Report.Filters.Add(addingFilter);
                refreshFilterTableFromReport();
            }
        }

        private void saveOrCreateButton_Click(object sender, EventArgs e)
        {
            updateReportFromForm();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void filtersGridView_SelectionChanged(object sender, EventArgs e)
        {
            bool somethingSelected = filtersGridView.SelectedRows.Count > 0;
            editFilterButton.Enabled = somethingSelected;
            deleteFilterButton.Enabled = somethingSelected;
        }

        private void editFilterButton_Click(object sender, EventArgs e)
        {
            promptToEditFilter(getSelectedFilter());
            loadFormFromReport();
        }

        private void deleteFilterButton_Click(object sender, EventArgs e)
        {
            ReportFilter selectedFilter = getSelectedFilter();
            if (selectedFilter != null &&
                MessageBox.Show("Are you certain you want to delete this filter?", "Delete Filter", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteFilter(getSelectedFilter());
                loadFormFromReport();
            }
        }
    }
}
