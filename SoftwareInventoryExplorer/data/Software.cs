using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareInventoryExplorer.data
{
    public class Software
    {
        public String SoftwareCode { get; set; }
        public String DisplayName { get; set; }
        public String ProductName { get; set; }
        public Nullable<int> MajorVersion { get; set; }
        public Nullable<int> MinorVersion { get; set; }
        public String ProductVersionString { get; set; }
    }
}
