using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryingStuffCommon.Model
{
    public class Rating
    {
        public int SongId { get; set; }
        public string SongName { get; set; }
        public int Rate { get; set; }
        public string AuthorName { get; set; }
        public string RatingByUser { get; set; }
    }
}
