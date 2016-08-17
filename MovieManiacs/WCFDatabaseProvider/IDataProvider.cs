using Core.InfoModels;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

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
        User FindUserById(int id);

        [OperationContract]
        IEnumerable<User> GetUserFriends(int userId);

        [OperationContract]
        IEnumerable<User> GetAllUsers();


        [OperationContract]
        IEnumerable<Movie> GetUserMovies(int userId);

        [OperationContract]
        void CreateNewUser(User user);
        [OperationContract]
        Task CreateAsync(User user);
        #endregion

        #region Movies

        [OperationContract]
        Movie FindByMovieName(string movieName);

        [OperationContract]
        List<Movie> GetAllMovies();

        [OperationContract]
        void CreateNewMovie(Movie movie);


        #endregion
    }
}
