using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareInventoryExplorer.Util;

namespace SoftwareInventoryExplorer.data
{
    class SccmDataProvider
    {
        private const String SCCM_SOFTWARE_INV_SUMMARY_QUERY = @"
            select count(ResourceID) as install_count, 
	               softwareCode0 as software_code, 
	               ProductName0 as product_name,
	               ARPDisplayName0 as display_name,
	               ProductVersion0 as product_version_string,
	               VersionMajor0 as major_version,
	               VersionMinor0 as minor_version
            from v_GS_INSTALLED_SOFTWARE 
            group by SoftwareCode0, 
		             ProductName0, 
		             ARPDisplayName0, 
		             ProductVersion0, 
		             VersionMajor0, 
		             versionMinor0 
            order by productname0, SoftwareCode0, ProductVersion0
            ";

        private const String SCCM_MACHINE_SOFTWARE_QUERY = @"
            select s.Domain0 as domain,
                   s.Name0 as system_name,
	               s.SystemRole0 as system_role,
	               s.SystemType0 as system_type
            from v_gs_system s
            left join v_GS_INSTALLED_SOFTWARE sw on s.ResourceID = sw.ResourceID
            where sw.SoftwareCode0 = @software_code
            ";

        private SqlConnection createSqlConnection()
        {
            String connectionString = AppSettings.GetInstance().ConnectionString;
            return new SqlConnection(connectionString);
        }

        public List<SoftwareInventoryTableEntry> getSoftwareInventoryFromSccm()
        {
            List<SoftwareInventoryTableEntry> result = new List<SoftwareInventoryTableEntry>();
            using (SqlConnection connection = createSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SCCM_SOFTWARE_INV_SUMMARY_QUERY);
                command.Connection = connection;
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Software software = new Software()
                        {
                            ProductName = (String)dataReader.GetValue("product_name"),
                            DisplayName = (String)dataReader.GetValue("display_name"),
                            ProductVersionString = (String)dataReader.GetValue("product_version_string"),
                            MajorVersion = (int)dataReader.GetValue("major_version"),
                            MinorVersion = (int)dataReader.GetValue("minor_version"),
                            SoftwareCode = (String)dataReader.GetValue("software_code")
                        };
                        result.Add(new SoftwareInventoryTableEntry()
                        {
                            Count = dataReader.GetInt32(dataReader.GetOrdinal("install_count")),
                            Software = software
                        });
                    }
                }
            }
            return result;
        }

        public List<ComputerSystem> getInstalledSystemsForSoftware(Software software)
        {
            return getInstalledSystemsForSoftware(software.SoftwareCode);
        }

        public List<ComputerSystem> getInstalledSystemsForSoftware(string softwareCode)
        {
            List<ComputerSystem> result = new List<ComputerSystem>();
            using (SqlConnection connection = createSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SCCM_MACHINE_SOFTWARE_QUERY);
                command.Parameters.AddWithValue("@software_code", softwareCode);
                command.Connection = connection;
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        ComputerSystem system = new ComputerSystem()
                        {
                            Domain = (String)dataReader.GetValue("domain"),
                            Name = (String)dataReader.GetValue("system_name"),
                            Role = (String)dataReader.GetValue("system_role"),
                            Type = (String)dataReader.GetValue("system_type"),
                        };
                        result.Add(system);
                    }
                }
            }
            return result;
        }
    }
}
