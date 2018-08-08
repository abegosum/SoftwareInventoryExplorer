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

namespace SoftwareInventoryExplorer
{
    public partial class ApprovedSoftwareListNamePrompt : Form
    {

        public String ApprovedSoftwareListName
        {
            get
            {
                return nameTextBox.Text;
            }
        }

        public ApprovedSoftwareListNamePrompt()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!ApprovedSoftwareListName.IsNullOrEmpty())
            {
                DialogResult = DialogResult.OK;
                Close();
            } else
            {
                MessageBox.Show("You must enter a name for the new list.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
