using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareInventoryExplorer.data
{
    public class SoftwareInventoryTableEntry
    {
        public int Count { get; set; }
        public Software Software { get; set; }
        public bool IsHighlighted { get; set; }
        public Nullable<int> BackgroundColor { get; set; }
        public Nullable<int> ForegroundColor { get; set; }
    }
}
