using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieManiacs.Controllers
{
    public class BaseApiController : ApiController
    {
        public UserService UserService { get; set; }
        public MovieService MovieService { get; set; }

        public BaseApiController()
        {
            UserService = new UserService();
            MovieService = new MovieService();
        }
    }
}
