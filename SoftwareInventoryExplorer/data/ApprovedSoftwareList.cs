using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareInventoryExplorer.data
{
    public class ApprovedSoftwareList { 

        public String Name { get; set; }
        private DateTime _created;
        public DateTime Created
        {
            get
            {
                if (_created == null)
                {
                    _created = DateTime.Now;
                }
                return _created;
            }
            set
            {
                _created = value;
            }
        }
        public Nullable<int> BackgroundColor { get; set; }
        public Nullable<int> ForegroundColor { get; set; }

        public ApprovedSoftwareList() { }

        public ApprovedSoftwareList(String name) : this(name, DateTime.Now) { }

        public ApprovedSoftwareList(String name, DateTime created) : this(name, created, new List<ApprovedSoftware>()) { }

        public ApprovedSoftwareList(String name, DateTime created, List<ApprovedSoftware> approvedSoftware)
        {
            this.Name = name;
            this.Created = created;
            this._approvedSoftware = approvedSoftware;
        }

        private List<ApprovedSoftware> _approvedSoftware;
        public List<ApprovedSoftware> ApprovedSoftwares
        {
            get
            {
                if (_approvedSoftware == null)
                {
                    _approvedSoftware = new List<ApprovedSoftware>();
                }
                return _approvedSoftware;
            }
        }

        private ApprovedSoftware createApprovedSoftwareEntry(ApprovedSoftware.ApprovedByCodes approvedBy, Software software)
        {
            ApprovedSoftware approved = new ApprovedSoftware()
            {
                ApprovedBy = approvedBy,
                SoftwareExample = software
            };
            return approved;
        }

        private bool approvalIsInList(ApprovedSoftware testingEntry)
        {
            bool result = false;
            foreach (ApprovedSoftware approvedSoftware in ApprovedSoftwares)
            {
                if (approvedSoftware.Equals(testingEntry))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public bool softwareIsInList(Software software)
        {
            bool result = false;
            foreach (ApprovedSoftware approval in ApprovedSoftwares)
            {
                if (approval.softwareMatches(software))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public void addSoftware(ApprovedSoftware.ApprovedByCodes approvedBy, Software software)
        {
            ApprovedSoftware approved = createApprovedSoftwareEntry(approvedBy, software);
            if (!approvalIsInList(approved)) {
                ApprovedSoftwares.Add(approved);
            }
        }

        public bool removeSoftware(ApprovedSoftware toRemove)
        {
            ApprovedSoftware removingEntry = null;
            foreach (ApprovedSoftware approvedSoftware in ApprovedSoftwares)
            {
                if (approvedSoftware.Equals(toRemove))
                {
                    removingEntry = approvedSoftware;
                }
            }
            if (removingEntry != null)
            {
                ApprovedSoftwares.Remove(removingEntry);
            }
            return removingEntry != null;
        }

        public bool removeSoftware(ApprovedSoftware.ApprovedByCodes approvedBy, Software software)
        {
            return removeSoftware(createApprovedSoftwareEntry(approvedBy, software));
        }
    }
}
