using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CSE_DEPT.Utils
{
    class Connection
    {

        public static string ConnectionString { get { return ConfigurationManager.ConnectionStrings["CSE_DEPTConnectionString"].ConnectionString; } }

    }
}
