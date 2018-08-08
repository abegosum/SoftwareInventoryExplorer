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
    public partial class AddApprovedSoftwareListFilterForm : Form
    {

        private InventoryProject _projectContext;

        public AddApprovedSoftwareListFilterForm(InventoryProject projectContext)
        {
            InitializeComponent();
            _projectContext = projectContext;
        }

        private ReportFilter _filter;
        public ReportFilter Filter
        {
            get
            {
                if (_filter == null)
                {
                    _filter = new ReportFilter();
                    _filter.FilterType = FilterType.APPROVED_SOFTWARE_LIST;
                }
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }

        private void bindNegationComboBox()
        {
            List<KeyValuePair<String, bool>> boxSelections = new List<KeyValuePair<string, bool>>();
            boxSelections.Add(new KeyValuePair<string, bool>("IN", false));
            boxSelections.Add(new KeyValuePair<string, bool>("NOT IN", true));
            negationComboBox.DisplayMember = "Key";
            negationComboBox.ValueMember = "Value";
            negationComboBox.DataSource = boxSelections;
            negationComboBox.SelectedValue = false;
        }

        private void bindApprovedSoftwareListComboBox()
        {
            approvedSoftwareListDropDown.DisplayMember = "Name";
            approvedSoftwareListDropDown.DataSource = _projectContext.ApprovedSoftwareLists;
        }

        private void updateFilterFromForm()
        {
            Filter.ApprovedSoftwareListName = ((ApprovedSoftwareList) approvedSoftwareListDropDown.SelectedItem).Name;
            Filter.IsNegated = (bool)negationComboBox.SelectedValue;
        }

        private void AddApprovedSoftwareListFilterForm_Load(object sender, EventArgs e)
        {
            if (_filter != null)
            {
                addEditButton.Text = "Edit Filter";
                Text = "Edit Approved Software List Filter";
            }
            bindNegationComboBox();
            bindApprovedSoftwareListComboBox();
        }

        private void addEditButton_Click(object sender, EventArgs e)
        {
            updateFilterFromForm();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
