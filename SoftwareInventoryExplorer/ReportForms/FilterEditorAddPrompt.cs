using SoftwareInventoryExplorer.data.Reporting;
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
    public partial class FilterEditorAddPrompt : Form
    {
        private const FilterType DEFAULT_FILTER_TYPE = FilterType.APPROVED_SOFTWARE_LIST;

        public FilterEditorAddPrompt()
        {
            InitializeComponent();
        }

        public FilterType SelectedFilterType
        {
            get
            {
                return (FilterType)filterTypeDropDown.SelectedItem;
            }
        }

        private void bindFilterTypeDropDown()
        {
            List<KeyValuePair<String, object>> enumValues = new List<KeyValuePair<string, object>>();
            foreach (FilterType currentType in Enum.GetValues(typeof(FilterType)))
            {
                enumValues.Add(new KeyValuePair<string, object>(currentType.ToString(), currentType));
            }
            filterTypeDropDown.DisplayMember = "Key";
            filterTypeDropDown.ValueMember = "Value";
            filterTypeDropDown.DataSource = enumValues;
            filterTypeDropDown.SelectedValue = DEFAULT_FILTER_TYPE;
        }

        private void FilterEditorAddPrompt_Load(object sender, EventArgs e)
        {
            bindFilterTypeDropDown();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
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
