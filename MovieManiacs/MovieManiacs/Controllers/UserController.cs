using MovieManiacs.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;

namespace MovieManiacs.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : BaseApiController
    {
        //[AllowCrossSiteJson]
        [Route("api/friends/{userId}")]
        public IEnumerable<UserVM> Get(int userId)
        {
            var results = base.UserService.GetAllUserFriends(userId);
            var friends = new List<UserVM>();
            foreach (var result in results)
            {
                friends.Add(new UserVM()
                {
                    Id = result.Id,
                    UserName = result.UserName,
                    firstName = result.FirstName,
                    lastName = result.LastName,
                    email = result.Email,
                    RegistrationDate = result.RegistrationDate,
                    imageUrl = result.ImageUrl,
                });
            }
            return friends;
          
        }

        [Route("api/users/all")]
        public IEnumerable<UserVM> GetAllUsers()
        {
            var results = base.UserService.GetAllUsers();
            var friends = new List<UserVM>();
            foreach (var result in results)
            {
                friends.Add(new UserVM()
                {
                    Id = result.Id,
                    UserName = result.UserName,
                    firstName = result.FirstName,
                    lastName = result.LastName,
                    email = result.Email,
                    RegistrationDate = result.RegistrationDate,
                    imageUrl = result.ImageUrl,
                });
            }
            return friends;

        }

        [HttpPost]
        [Route("api/users/new")]
        public void AddNewUser(UserVM user)
        {
            user = new UserVM();
            base.UserService.CreateNewUser(user.firstName,user.lastName, user.Password, user.RegistrationDate, user.email);

        }


        [HttpPost]
        [Route("api/users/newasync")]
        public async Task AddNewUserAsync(UserVM user)
        {

            user = new UserVM();
            await base.UserService.CreateNewUserAsync(user.firstName, user.lastName, user.Password, user.RegistrationDate, user.email);
        }

        //[AllowCrossSiteJson]
        [Route("api/usermovies/{userId}")]
        public IEnumerable<MovieVM> GetUserMovies(int userId)
        {
            var results = base.UserService.GetUserMovies(userId);
            var movies = new List<MovieVM>();
            foreach (var result in results)
            {
                movies.Add(new MovieVM()
                {
                    Id = result.Id,
                    title = result.Name,
                    Year = result.Year,
                    ReleaseDate = result.ReleaseDate,
                    imageurl = result.ImageUrl,
                    Rank = result.Rank,
                    genre = result.Genre,
                    description = result.Description,
                    starring = result.Starring
                });
            }
            return movies;

        }
    }
}
