using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stefanini.Types
{
    public class DatabaseConnectionSettings
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public bool IntegratedSecurity { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Schema { get; set; }
    }
}
