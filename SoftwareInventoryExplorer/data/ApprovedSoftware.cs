using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareInventoryExplorer.data
{

    public class ApprovedSoftware
    {
        public enum ApprovedByCodes
        {
            ALL = 0,
            FULL_VERSION = 1,
            MAJOR_VERSION = 2,
            MAJOR_VERSION_OR_GREATER = 3,
        }

        public ApprovedByCodes ApprovedBy { get; set; }
        public Software SoftwareExample { get; set; }

        public bool softwareMatches(Software software)
        {
            bool result = false;
            switch (ApprovedBy)
            {
                case ApprovedByCodes.ALL:
                    result = SoftwareExample.SoftwareCode.Equals(software.SoftwareCode);
                    break;
                case ApprovedByCodes.FULL_VERSION:
                    result = SoftwareExample.SoftwareCode.Equals(software.SoftwareCode) && 
                        SoftwareExample.ProductVersionString.Equals(software.ProductVersionString);
                    break;
                case ApprovedByCodes.MAJOR_VERSION:
                    result = SoftwareExample.SoftwareCode.Equals(software.SoftwareCode) &&
                        SoftwareExample.MajorVersion == software.MajorVersion;
                    break;
                case ApprovedByCodes.MAJOR_VERSION_OR_GREATER:
                    result = SoftwareExample.SoftwareCode.Equals(software.SoftwareCode) &&
                        software.MajorVersion >= SoftwareExample.MajorVersion;
                    break;

            }
            return result;
        }

        public override bool Equals(Object obj)
        {
            bool result = false;
            if (obj is ApprovedSoftware)
            {
                ApprovedSoftware testingSoftware = (ApprovedSoftware)obj;
                if (testingSoftware.ApprovedBy == ApprovedBy)
                {
                    result = testingSoftware.SoftwareExample.SoftwareCode.Equals(SoftwareExample.SoftwareCode);
                    switch (ApprovedBy)
                    {
                        case ApprovedByCodes.FULL_VERSION:
                            result = result &&
                                testingSoftware.SoftwareExample.ProductVersionString.Equals(SoftwareExample.ProductVersionString);
                            break;
                        case ApprovedByCodes.MAJOR_VERSION:
                            result = result &&
                                testingSoftware.SoftwareExample.MajorVersion == SoftwareExample.MajorVersion;
                            break;
                        case ApprovedByCodes.MAJOR_VERSION_OR_GREATER:
                            result = result &&
                                testingSoftware.SoftwareExample.MajorVersion >= SoftwareExample.MajorVersion;
                            break;
                    }
                }
            }
            return result;
        }
    }

}
