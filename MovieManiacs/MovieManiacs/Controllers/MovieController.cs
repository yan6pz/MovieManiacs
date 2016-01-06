using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

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

        // GET api/values/5
        public string Get(int id)
        {
            string result = String.Empty;
            var movies = base.MovieService.GetAllMovies();
            foreach (var movie in movies)
            {
                result = result + movie.Name + "";
            }
            //var list = JsonConvert.SerializeObject(movies,
             //Formatting.None,
             //new JsonSerializerSettings()
             //{
             //    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
             //});

            return result;
        }


        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
