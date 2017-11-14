using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TryingStuffCommon.Model;

namespace TryingStuffService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
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
