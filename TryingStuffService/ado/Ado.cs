using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TryingStuffService.ado
{
    public class Ado
    {
        public string ConnStr { get; set; }
        public Ado(): this(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString){ }
        public Ado(string conn)
        {
            ConnStr = conn;
        }
    }
}