using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TryingStuffCommon.Model;

namespace TryingStuffServicev2
{
    [ServiceContract]
    public interface IEntryPointService
    {
        [OperationContract]
        bool SaveSong(Song s);

        [OperationContract]
        bool SaveArtist(Artist a);

        [OperationContract]
        Rating[] GetRatings();

        [OperationContract]
        IEnumerable<Song> SongsByPlace();
    }
}
