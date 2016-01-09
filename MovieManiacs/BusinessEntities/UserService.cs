using Core.InfoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class UserService
    {
        public DataProvider.DataProviderClient client = new DataProvider.DataProviderClient();

        public User GetByUserName(string userName)
        {
            var user = client.GetUserByUserName(userName);
            var result = new User() { Id = user.Id, Email = user.Email };
            return result;
        }
        public User FindById(int id)
        {
            var user = client.FindUserById(id);
            var result = new User() { Id = user.Id, Email = user.Email };
            return result;
        }

        public IEnumerable<User> GetAllUserFriends(int userId)
        {
            var friends = client.GetUserFriends(userId);
            return friends;        
        }

        public IEnumerable<Movie> GetUserMovies(int userId)
        {
            var movies = client.GetUserMovies(userId);
            return movies;
        }
    }
}
