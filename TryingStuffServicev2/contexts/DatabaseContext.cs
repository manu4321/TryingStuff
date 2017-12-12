using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryingStuffCommon.Model;

namespace TryingStuffServicev2.ado
{
    public class DatabaseContext: DataContext
    {
        public Table<Artist> Artists;
        public Table<Song> Songs;

        public DatabaseContext() : this(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString) { }
        public DatabaseContext(string conn) : base(conn)
        {
            Artists = this.GetTable<Artist>();
            Songs = this.GetTable<Song>();
        }
    }
}
