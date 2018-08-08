using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareInventoryExplorer.Util
{
    public static class Extensions
    {
        public static Object GetValue(this SqlDataReader reader, String columnName)
        {
            return reader.GetValue(reader.GetOrdinal(columnName));
        }

        public static bool IsEmpty(this String checkingString)
        {
            return checkingString.Trim().Equals(String.Empty);
        }

        public static bool IsNullOrEmpty(this String checkingString)
        {
            return checkingString == null || IsEmpty(checkingString);
        }
    }
}
