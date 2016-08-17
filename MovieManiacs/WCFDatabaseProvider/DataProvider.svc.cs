using Core;
using Core.InfoModels;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public User FindUserById(int id)
        {
            var result = this.UserRepository.FindById(id);
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

        public IEnumerable<User> GetAllUsers()
        {
            var friends = this.UserRepository.GetAllUsers().ToList();
            var userFriends = new List<User>();
            friends.ForEach(f => f.ParseUserFriend(ref userFriends));
            return userFriends;
        }

        public IEnumerable<Movie> GetUserMovies(int userId)
        {
            var movies = this.UserRepository.GetUserMovies(userId).ToList();
            var userMovies = new List<Movie>();
            movies.ForEach(m => m.ParseMovies(ref userMovies));
            return userMovies;
        }

        public void CreateNewUser(User user)
        {
            var userDb = new Users()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Password = user.Password,
                RegistrationDate = DateTime.Now,
                UserName = user.UserName,
                ImageUrl=user.ImageUrl,
                Email=user.Email
            };
            this.UserRepository.Create(userDb);
        }

        public async Task CreateAsync(User user)
        {
            var userDb = new Users()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Password = user.Password,
                RegistrationDate = DateTime.Now,
                UserName = user.UserName,
                ImageUrl = user.ImageUrl,
                Email = user.Email
            };
            await this.UserRepository.CreateAsync(userDb);
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

        public void CreateNewMovie(Movie movie)
        {
            var user=this.UserRepository.FindById(movie.UserId);
            var movieDb = new Movies()
            {
                Name = movie.Name,
                Year = movie.Year,
                ReleaseDate = movie.ReleaseDate,
                ImageUrl = movie.ImageUrl,
                Rank = movie.Rank,
                Genre = movie.Genre,
                Description = movie.Description,
                Starring = movie.Starring,
                
    };
            movieDb.Users.Add(user);
            this.MovieRepository.Create(movieDb);
        }

        #endregion

    }
}
