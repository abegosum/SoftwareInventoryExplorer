using SoftwareInventoryExplorer.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareInventoryExplorer.data.Reporting
{
    public enum FilterType
    {
        LOGICAL_AND,
        LOGICAL_OR,
        APPROVED_SOFTWARE_LIST,
    }

    public class ReportFilter
    {

        public FilterType FilterType { get; set; }

        public ReportFilter Filter1 { get; set; }

        public ReportFilter Filter2 { get; set; }

        public bool IsNegated { get; set; }

        public String ApprovedSoftwareListName { get; set; }

        public bool isFiltered(Software item, InventoryProject projectContext)
        {
            bool result = false;
            switch (FilterType)
            {
                case FilterType.LOGICAL_AND:
                    result = (Filter1.isFiltered(item, projectContext) && Filter2.isFiltered(item, projectContext));
                    break;
                case FilterType.LOGICAL_OR:
                    result = (Filter1.isFiltered(item, projectContext) || Filter2.isFiltered(item, projectContext));
                    break;
                case FilterType.APPROVED_SOFTWARE_LIST:
                    ApprovedSoftwareList listToApply = projectContext.getApprovedSoftwareListByName(ApprovedSoftwareListName);
                    IEnumerable<ApprovedSoftware> matchingEntries =
                        from approvedSoftware in listToApply.ApprovedSoftwares
                        where approvedSoftware.SoftwareExample.SoftwareCode.Equals(item.SoftwareCode)
                        select approvedSoftware;
                    foreach (ApprovedSoftware checkingEntry in matchingEntries)
                    {
                        if (checkingEntry.softwareMatches(item))
                        {
                            result = true;
                            break;
                        }
                    }
                    break;
            }
            if (IsNegated)
            {
                result = !result;
            }
            return result;
        }

        public override string ToString()
        {
            StringBuilder filterDescription = new StringBuilder();
            switch (FilterType)
            {
                case FilterType.APPROVED_SOFTWARE_LIST:
                    filterDescription.Append("software is ");
                    if (IsNegated)
                    {
                        filterDescription.Append("not in ");
                    } else
                    {
                        filterDescription.Append("in ");
                    }
                    filterDescription.Append("the list '");
                    filterDescription.Append(ApprovedSoftwareListName);
                    filterDescription.Append("'");
                    break;
                case FilterType.LOGICAL_AND:
                    if (IsNegated)
                    {
                        filterDescription.Append("neither ");
                        filterDescription.Append(Filter1.ToString());
                        filterDescription.Append(" nor ");
                        filterDescription.Append(Filter2.ToString());
                    } else
                    {
                        filterDescription.Append("both ");
                        filterDescription.Append(Filter1.ToString());
                        filterDescription.Append(" and ");
                        filterDescription.Append(Filter2.ToString());
                    }
                    break;
                case FilterType.LOGICAL_OR:
                    if (IsNegated)
                    {
                        filterDescription.Append("not ");
                        filterDescription.Append(Filter1.ToString());
                        filterDescription.Append(" and not ");
                        filterDescription.Append(Filter2.ToString());
                    }
                    else
                    {
                        filterDescription.Append("either ");
                        filterDescription.Append(Filter1.ToString());
                        filterDescription.Append(" or ");
                        filterDescription.Append(Filter2.ToString());
                    }
                    break;
            }
            return filterDescription.ToString();
        }
    }
}
