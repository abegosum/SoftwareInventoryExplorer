using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareInventoryExplorer.Util;

namespace SoftwareInventoryExplorer
{
    public partial class ConnestionStringPrompt : Form
    {
        private const String TEST_QUERY = "SELECT TOP (1) [ResourceID] FROM [dbo].[v_GS_INSTALLED_SOFTWARE]";
        
        public ConnestionStringPrompt()
        {
            InitializeComponent();
        }

        private bool TestConnectionString(String connectionString)
        {
            bool result = true;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = TEST_QUERY;
            command.Connection = connection;
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
            } catch (SqlException ex)
            {
                if (ex.Message.ToLower().Contains("login failed"))
                {
                    MessageBox.Show("Login failed.", "Connection Error");
                } else if (ex.Message.ToLower().Contains("server was not found or was not accessible"))
                {
                    MessageBox.Show("Problem connecting to server.  Please check servername and network connectivity.", "Connection Error");
                } else
                {
                    throw;
                }
                result = false;
            } finally {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            
            return result;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            okButton.Enabled = false;
            String newConnectionString = connectionStringTextBox.Text;
            if (TestConnectionString(newConnectionString))
            {
                AppSettings appSettings = AppSettings.GetInstance();
                appSettings.ConnectionString = newConnectionString;
                appSettings.Save();
                DialogResult = DialogResult.OK;
                MessageBox.Show("Connection string saved.", "Success");
                Close();
            }
            okButton.Enabled = true;
        }

        private void ConnestionStringPrompt_Load(object sender, EventArgs e)
        {
            String connectionString = AppSettings.GetInstance().ConnectionString;
            if (! connectionString.IsNullOrEmpty())
            {
                connectionStringTextBox.Text = connectionString;
            }
        }
    }
}
