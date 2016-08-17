using Core.InfoModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public IEnumerable<User> GetAllUsers()
        {
            var friends = client.GetAllUsers();
            return friends;
        }

        public IEnumerable<Movie> GetUserMovies(int userId)
        {
            var movies = client.GetUserMovies(userId);
            return movies;
        }

        public void CreateNewUser(string firstName, string lastName, Guid Password, DateTime RegistrationDate, string email)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < 1000; i++)
            {
                User user = new User();
                user.FirstName = "new";
                user.LastName = "newOne";
                user.Password = new Guid();
                user.RegistrationDate = DateTime.Now;
                user.Email = "email@test.com";
                user.UserName = "yanis";
                user.ImageUrl = "http://www.clipartbest.com/cliparts/yTk/4Rd/yTk4RdqEc.jpeg";
                client.CreateNewUser(user);
        }
        sw.Stop();
            Console.WriteLine("Elapsed={0}", sw.Elapsed);
        }

        public async Task CreateNewUserAsync(string firstName, string lastName, Guid Password, DateTime RegistrationDate, string email)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < 1000; i++)
            {
                User user = new User();
                user.FirstName = "new";
                user.LastName = "newOne";
                user.Password = new Guid();
                user.RegistrationDate = DateTime.Now;
                user.Email = "email@test.com";
                user.UserName = "yanis";
                user.ImageUrl = "http://www.clipartbest.com/cliparts/yTk/4Rd/yTk4RdqEc.jpeg";
                await client.CreateAsync(user);
            }
            sw.Stop();
            Console.WriteLine("Elapsed={0}", sw.Elapsed);

        }
    }
}
