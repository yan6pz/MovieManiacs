﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using MovieManiacs.ViewModels;
using System.Web.Http.Filters;
using System.Web.Http.Cors;

namespace MovieManiacs.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MovieController : BaseApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        //public string Get(int id)
        //{
        //    var user = base.UserService.GetByUserName("yanis");
        //    return user.Email;
        //}

        //// GET api/values/5
        //public string Get(int id)
        //{
        //    var movie = base.MovieService.FindByMovieName("The Shawshank Redemption");
        //    return movie.Name + movie.Starring;
        //}
        //[DisableCors]
        //[AllowCrossSiteJson]
        [Route("api/movies/all")]
        public IEnumerable<MovieVM> GetAllMovies()
        {
            var results = base.MovieService.GetAllMovies();
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

        [HttpPost]
        [Route("api/movie/new")]
        public void AddNewMovie(MovieVM movie)
        {
            var result = true;
            int userId = 2;
           base.MovieService.CreateNewMovie(userId,movie.title, movie.description, movie.genre, DateTime.Now, movie.starring,movie.imageurl);

        }


        // POST api/values
        [AllowCrossSiteJson]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [AllowCrossSiteJson]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [AllowCrossSiteJson]
        public void Delete(int id)
        {
        }
    }
}
