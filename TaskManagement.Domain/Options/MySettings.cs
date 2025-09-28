using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Domain.Options
{
    public class MySettingsjjjjj
    {
        public const string BindingName = "MySettings";
        public SQLServerConfigOption SQLServerConfig { get; set; }

        public class SQLServerConfigOption
        {
            public string Connection { get; set; }
        }
    }
}
