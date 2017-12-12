using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TryingStuffCommon.Model;
using TryingStuffServicev2.dao;

namespace TryingStuffServicev2
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    class EntryPointServiceImpl : IEntryPointService
    {
        public Dao Dao { get; set; }
        public EntryPointServiceImpl()
        {
            Dao = new Dao();
        }
        public Rating[] GetRatings()
        {
            return Dao.GetRatings();
        }

        public bool SaveArtist(Artist a)
        {
            return false;
        }

        public bool SaveSong(Song s)
        {
            return Dao.SaveSong(s);
        }

        public IEnumerable<Song> SongsByPlace()
        {
            throw new NotImplementedException();
        }
    }
}
