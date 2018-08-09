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

        private ApprovedSoftwareList _selectedList;
        public ApprovedSoftwareList SelectedList
        {
            get
            {
                if (_selectedList == null)
                {
                    if (listsDropDown.SelectedItem == null)
                    {
                        _selectedList = getOrCreateApprovedSoftwareListByName(listsDropDown.Text.Trim());
                    }
                    else
                    {
                        _selectedList = (ApprovedSoftwareList)listsDropDown.SelectedItem;
                    }
                }
                return _selectedList;
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

        private ApprovedSoftwareList getOrCreateApprovedSoftwareListByName(String name)
        {
            ApprovedSoftwareList newList = null;
            List<ApprovedSoftwareList> matchingLists =
                (from list in ApprovedSoftwareLists
                 where list.Name.Equals(name)
                 select list).ToList();
            if (matchingLists.Count == 1)
            {
                newList = matchingLists.First();
            } else
            {
                newList = new ApprovedSoftwareList()
                {
                    Name = name
                };
            }
            return newList;
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
