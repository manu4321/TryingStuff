using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryingStuffCommon.Model;
using TryingStuffServicev2.ado;

namespace TryingStuffServicev2.dao
{
    class Dao
    {
        private DatabaseContext Db { set; get; }
        public Dao()
        {
            Db = new DatabaseContext();
        }

        public Rating[] GetRatings()
        {
            return Db.Songs.GroupBy(sa => sa.Name)
            .Select(g => new Rating
            {
                SongId = g.First().Id,
                SongName = g.First().Name,
                Rate = g.Sum(v => v.Rating),
                AuthorName = g.First().AName
            }).OrderByDescending(g => g.Rate).ToArray();
        }

        public Artist GetArtistByName(string name)
        {
            //for now let's make name unique
            return Db.Artists.First(a => a.Name == name);
        }

        public Song GetSongById(int id)
        {
            return Db.Songs.First(s => s.Id == id);
        }

        internal bool SaveSong(Song s)
        {
            Song song = GetSongById(s.Id);
            if(song == null)
            {
                //new song
                song = s;
            }
            else
            {
                //old song. Update with given values
                song.AName = s.AName;
                song.Name = s.Name;
                song.Rating = s.Rating;
                
            }

            Db.Songs.InsertOnSubmit(song);
            Db.SubmitChanges();
            return true;
        }
    }
}
