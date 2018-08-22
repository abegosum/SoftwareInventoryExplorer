using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareInventoryExplorer.data;
using SoftwareInventoryExplorer.data.Reporting;

namespace SoftwareInventoryExplorer.Project
{
    public class InventoryProject
    {
        private List<ApprovedSoftwareList> _approvedSoftwareLists;
        public List<ApprovedSoftwareList> ApprovedSoftwareLists
        {
            get
            {
                if (_approvedSoftwareLists == null)
                {
                    _approvedSoftwareLists = new List<ApprovedSoftwareList>();
                }
                return _approvedSoftwareLists;
            }
            set
            {
                _approvedSoftwareLists = value;
            }
        }

        private List<SoftwareInventoryTableEntry> _sccmTableEntries;
        public List<SoftwareInventoryTableEntry> SccmTableEntries {
            get
            {
                if (_sccmTableEntries == null)
                {
                    _sccmTableEntries = new List<SoftwareInventoryTableEntry>();
                }
                return _sccmTableEntries;
            }
            set
            {
                _sccmTableEntries = value;
            }
        }

        public String OpenTabKey { get; set; }

        private List<String> _tabOrder;
        public List<String> TabOrder
        {
            get
            {
                if (_tabOrder == null)
                {
                    _tabOrder = new List<string>();
                }
                return _tabOrder;
            }
            set { _tabOrder = value; }
        }

        private List<SoftwareReport> _reports;
        public List<SoftwareReport> Reports
        {
            get
            {
                if (_reports == null)
                {
                    _reports = new List<SoftwareReport>();
                }
                return _reports;
            }
            set
            {
                _reports = value;
            }
        }

        public Nullable<int> SccmSoftwareScrollPosition { get; set; }

        public ApprovedSoftwareList getApprovedSoftwareListByName(String name)
        {
            return
                (from softwareList in ApprovedSoftwareLists
                 where softwareList.Name.Equals(name)
                 select softwareList).First<ApprovedSoftwareList>();
        }
    }
}
