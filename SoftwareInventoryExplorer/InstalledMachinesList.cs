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
    public partial class InstalledMachinesList : Form
    {
        private Software _softwareExample;
        private List<ComputerSystem> _systems;

        public InstalledMachinesList(Software softwareExample)
        {
            InitializeComponent();
            _softwareExample = softwareExample;
        }

        private DataTable createSystemsTable()
        {
            DataTable result = new DataTable();
            result.Columns.Add("Role");
            result.Columns.Add("Domain");
            result.Columns.Add("Name");
            result.Columns.Add("Type");
            return result;
        }

        private DataRow createDataRowFromComputerSystem(DataTable table, ComputerSystem system)
        {
            DataRow result = table.NewRow();
            result["Role"] = system.Role;
            result["Domain"] = system.Domain;
            result["Name"] = system.Name;
            result["Type"] = system.Type;
            return result;
        }

        private void populateDataGridFromSystemList(List<ComputerSystem> systems)
        {
            DataTable table = createSystemsTable();
            foreach (ComputerSystem system in systems)
            {
                table.Rows.Add(createDataRowFromComputerSystem(table, system));
            }
            installedMachinesDataGridView.DataSource = table;
        }

        private List<ComputerSystem> getSystemsFromSccm()
        {
            SccmDataProvider provider = new SccmDataProvider();
            return provider.getInstalledSystemsForSoftware(_softwareExample);
        }

        private void InstalledMachinesList_Load(object sender, EventArgs e)
        {
            populateDataGridFromSystemList(getSystemsFromSccm());
            softwareNameLabel.Text = _softwareExample.DisplayName;
            softwareCodeLabel.Text = _softwareExample.SoftwareCode;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
