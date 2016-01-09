using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using MovieManiacs.ViewModels;
using System.Web.Http.Filters;

namespace MovieManiacs.Controllers
{
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

        [AllowCrossSiteJson]
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
