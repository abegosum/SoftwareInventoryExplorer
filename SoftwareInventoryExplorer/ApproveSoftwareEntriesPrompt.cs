using SoftwareInventoryExplorer.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareInventoryExplorer
{
    public partial class ApproveSoftwareEntriesPrompt : Form
    {

        public int NumberOfEntries { get; set; }

        public List<ApprovedSoftwareList> ApprovedSoftwareLists { get; set;}

        public ApprovedSoftwareList SelectedList
        {
            get
            {
                return (ApprovedSoftwareList)listsDropDown.SelectedItem;
            }
        }

        public ApprovedSoftware.ApprovedByCodes ApprovalCode
        {
            get
            {
                KeyValuePair<String, ApprovedSoftware.ApprovedByCodes> keyValuePair = 
                    (KeyValuePair<String, ApprovedSoftware.ApprovedByCodes>)approvalTypeDropDown.SelectedItem;
                return keyValuePair.Value;
            }
        }

        public ApproveSoftwareEntriesPrompt()
        {
            InitializeComponent();
        }

        private void setNumberOfEntriesLabel()
        {
            StringBuilder labelTextBuilder = new StringBuilder("Approving ");
            labelTextBuilder.Append(NumberOfEntries.ToString());
            labelTextBuilder.Append(" Software Entries");
            approvingEntriesLabel.Text = labelTextBuilder.ToString();
        }

        private void populateApprovalTypeDropDown()
        {
            List<KeyValuePair<String, ApprovedSoftware.ApprovedByCodes>> options = new List<KeyValuePair<string, ApprovedSoftware.ApprovedByCodes>>();
            options.Add(new KeyValuePair<string, ApprovedSoftware.ApprovedByCodes>("Approve all Versions", ApprovedSoftware.ApprovedByCodes.ALL));
            options.Add(new KeyValuePair<string, ApprovedSoftware.ApprovedByCodes>("Approve this specific version", ApprovedSoftware.ApprovedByCodes.FULL_VERSION));
            options.Add(new KeyValuePair<string, ApprovedSoftware.ApprovedByCodes>("Approve this major version", ApprovedSoftware.ApprovedByCodes.MAJOR_VESION));
            approvalTypeDropDown.DisplayMember = "Key";
            approvalTypeDropDown.DataSource = options;
        }

        private void ApproveSoftwareEntriesPrompt_Load(object sender, EventArgs e)
        {
            setNumberOfEntriesLabel();
            listsDropDown.DisplayMember = "Name";
            listsDropDown.DataSource = ApprovedSoftwareLists;
            populateApprovalTypeDropDown();
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
