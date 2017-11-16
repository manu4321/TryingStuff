using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryingStuffServicev2.ado
{
    public class Ado
    {
        public string ConnStr { get; set; }
        public Ado() : this(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString) { }
        public Ado(string conn)
        {
            ConnStr = conn;
        }
    }
}
