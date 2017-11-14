using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryingStuffCommon.Model
{
    [Table(Name="Songs")]
    public class Song
    {
        private int _id;
        private int _rating;
        private EntityRef<Artist> _artist;
        private string _name;
        private string _aName;

        [Column(IsPrimaryKey = true, Storage = "_id", IsDbGenerated = true)]
        public int Id
        {
            get { return _id; }
            private set { this._id = value; }
        }

        [Column(Storage = "_rating")]
        public int Rating
        {
            get; set;
        }

        [Column(Storage = "_name")]
        public string Name
        {
            get { return _name; }
            set { this._name = value; }

        }

        [Association(Storage = "_artist", ThisKey = "AName")]
        public Artist Author
        {
            get { return _artist.Entity; }
            set { this._artist.Entity = value; }

        }

        [Column(Storage = "_aName")]
        public string AName
        {
            get { return _aName; }
            set { this._aName = value; }
        }
    }
}
