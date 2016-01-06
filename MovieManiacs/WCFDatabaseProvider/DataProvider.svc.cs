using Core;
using Core.InfoModels;
using Data;
using System.Collections.Generic;
using System.Linq;
using WCFDatabaseProvider.Helpers;

namespace WCFDatabaseProvider
{
    public class DataProvider : IDataProvider
    {
        public IUserRepository UserRepository { get; set; }
        public IMovieRepository MovieRepository { get; set; }

        public DataProvider()
        {
            var context=new  MovieManiacsContext();
            this.UserRepository = new UserRepository(context);
            this.MovieRepository = new MovieRepository(context);
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }


        #region User

        public User GetUserByUserName(string username)
        {
            var result = this.UserRepository.FindByUsername(username);
            var user = new User()
            {
                Id = result.Id,
                UserName = result.UserName,
                FirstName = result.FirstName,
                LastName = result.LastName,
                Email = result.Email,
                RegistrationDate = result.RegistrationDate
            };
            return user;
        }

        public IEnumerable<User> GetUserFriends(int userId)
        {
            var friends = this.UserRepository.GetUserFriends(userId).ToList();
            var userFriends = new List<User>();
            friends.ForEach(f => f.ParseUserFriend(ref userFriends));
            return userFriends;
        }



        #endregion
        #region Movie
        public Movie FindByMovieName(string movieName)
        {
            var result = this.MovieRepository.FindByMovieName(movieName);
            var movie = new Movie()
            {
                Id = result.Id,
                Name = result.Name,
                Year = result.Year,
                ReleaseDate = result.ReleaseDate,
                ImageUrl = result.ImageUrl,
                Rank = result.Rank,
                Genre = result.Genre,
                Description = result.Description,
                Starring = result.Starring
            };
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            var movies = this.MovieRepository.GetAllMovies().ToList();
            var allMovies = new List<Movie>();
            movies.ForEach(m => m.ParseMovies(ref allMovies));
            return allMovies;
        }

#endregion

    }
}
