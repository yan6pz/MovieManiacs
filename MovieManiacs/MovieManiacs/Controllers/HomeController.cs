using MovieManiacs.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace MovieManiacs.Controllers
{
    public class HomeController : BaseApiController
    {
        public JsonResult Index()
        {

            var user = base.UserService.GetByUserName("yanis");
            return new JsonResult
            {
                Data = JsonConvert.SerializeObject(new { Email = user.Email })
            };
        }
    }
}
