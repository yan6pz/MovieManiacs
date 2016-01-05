﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieManiacs.Controllers
{
    public class ValuesController : BaseApiController
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

        // GET api/values/5
        public string Get(int id)
        {
            var movie = base.MovieService.FindByMovieName("The Shawshank Redemption");
            return movie.Name + movie.Starring;
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
