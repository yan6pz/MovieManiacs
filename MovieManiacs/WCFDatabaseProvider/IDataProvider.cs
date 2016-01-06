using Core.InfoModels;
using System.Collections.Generic;
using System.ServiceModel;

namespace WCFDatabaseProvider
{
    [ServiceContract]
    public interface IDataProvider
    {
        #region Users

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        User GetUserByUserName(string username);

        [OperationContract]
        IEnumerable<User> GetUserFriends(int userId);
        #endregion

        #region Movies

        [OperationContract]
        Movie FindByMovieName(string movieName);

        [OperationContract]
        List<Movie> GetAllMovies();


        #endregion
    }
}
