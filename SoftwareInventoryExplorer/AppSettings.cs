using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareInventoryExplorer
{
    class AppSettings : ApplicationSettingsBase
    {
        private const String CONNECTION_STRING_KEY = "ConnectionString";

        private static AppSettings _instance;

        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public String ConnectionString
        {
            get
            {
                return ((String)this[CONNECTION_STRING_KEY]);
            }
            set
            {
                this[CONNECTION_STRING_KEY] = value;
            }
        }

        public static AppSettings GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AppSettings();
            }
            return _instance;
        }
    }
}
