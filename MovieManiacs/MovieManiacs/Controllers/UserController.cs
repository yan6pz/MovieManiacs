﻿using MovieManiacs.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace MovieManiacs.Controllers
{
    public class UserController : BaseApiController
    {
        [AllowCrossSiteJson]
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
                    FirstName = result.FirstName,
                    LastName = result.LastName,
                    Email = result.Email,
                    RegistrationDate = result.RegistrationDate
                });
            }
            return friends;
          
        }

        [AllowCrossSiteJson]
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
                    Year = result.Year,
                    ReleaseDate = result.ReleaseDate,
                    ImageUrl = result.ImageUrl,
                    Rank = result.Rank,
                    Genre = result.Genre,
                    Description = result.Description,
                    Starring = result.Starring
                });
            }
            return movies;

        }
    }
}
