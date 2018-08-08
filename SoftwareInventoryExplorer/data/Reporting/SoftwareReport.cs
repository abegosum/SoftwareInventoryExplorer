using SoftwareInventoryExplorer.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareInventoryExplorer.data.Reporting
{
    public class SoftwareReport
    {
        public ReportDataSource DataSource { get; set; }

        public String Name { get; set; }

        private Nullable<DateTime> _creationDate;
        public DateTime CreationDate
        {
            get
            {
                if (_creationDate == null)
                {
                    _creationDate = DateTime.Now;
                }
                return _creationDate.Value;
            }
            set
            {
                _creationDate = value;
            }
        }

        private String _createdBy;
        public String CreatedBy
        {
            get
            {
                if (_createdBy == null)
                {
                    _createdBy = Environment.UserName;
                }
                return _createdBy;
            }
            set
            {
                _createdBy = value;
            }
        }

        private List<ReportFilter> _filters;
        public List<ReportFilter> Filters
        {
            get
            {
                if (_filters == null)
                {
                    _filters = new List<ReportFilter>();
                }
                return _filters;
            }
            set { _filters = value; }
        }

        public List<SoftwareInventoryTableEntry> runReport(InventoryProject projectContext)
        {
            List<SoftwareInventoryTableEntry> result = new List<SoftwareInventoryTableEntry>();
            ReportableDataProviding reportableDataProvider = ReportDataSourceFactory.getDataSource(DataSource);
            foreach (SoftwareInventoryTableEntry softwareEntry in reportableDataProvider.getReportableData())
            {
                bool include = true;
                foreach(ReportFilter filter in Filters)
                {
                    if (filter.isFiltered(softwareEntry.Software, projectContext))
                    {
                        include = false;
                        break;
                    }
                }
                if (include)
                {
                    result.Add(softwareEntry);
                }
            }
            return result;
        }
    }
}
