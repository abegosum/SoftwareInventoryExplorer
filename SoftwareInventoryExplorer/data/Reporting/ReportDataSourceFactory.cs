using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareInventoryExplorer.data.Reporting
{

    public enum ReportDataSource
    {
        SCCM,
    }

    public static class ReportDataSourceFactory
    {
        public static ReportableDataProviding getDataSource(ReportDataSource reportDataSource)
        {
            ReportableDataProviding result = null;
            switch (reportDataSource)
            {
                case ReportDataSource.SCCM:
                    result = new SccmReportableDataSource();
                    break;
            }
            return result;
        }
    }
}
