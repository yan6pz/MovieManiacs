
using MovieManiacs.Models;
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
    public class HomeController : Controller
    {


        public ActionResult Index()
        {

            return View();
        }
    }
}
