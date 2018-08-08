using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareInventoryExplorer.data.Reporting
{
    public class SccmReportableDataSource : ReportableDataProviding
    {

        private SccmDataProvider _sccmDataProvider;
        private SccmDataProvider SccmDataProvider
        {
            get
            {
                if (_sccmDataProvider == null)
                {
                    _sccmDataProvider = new SccmDataProvider();
                }
                return _sccmDataProvider;
            }
        }

        public List<SoftwareInventoryTableEntry> getReportableData()
        {
            return SccmDataProvider.getSoftwareInventoryFromSccm();

        }
    }
}
