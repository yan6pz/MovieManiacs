using MovieManiacs.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
                    emails = result.Email,
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
            base.UserService.CreateNewUser(user.firstName, user.Password, user.RegistrationDate, user.emails);

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
