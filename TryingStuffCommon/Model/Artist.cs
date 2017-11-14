using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace TryingStuffCommon.Model
{
    [Table(Name = "Artists")]
    public class Artist
    {
        private string _name;
        private EntitySet<Song> _songs;

        public Artist()
        {
            Songs = new EntitySet<Song>();
        }

        [Column(IsPrimaryKey = true, Storage = "_name")]
        public string Name
        {
            get { return _name; }
            set { this._name = value; }
        }

        [Association(Storage = "_songs",
            ThisKey = "Name", OtherKey = "AName")]
        public EntitySet<Song> Songs
        {
            get { return _songs; }
            private set { _songs = value; }
        }
    }
}