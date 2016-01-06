using MovieManiacs.ViewModels;
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
    }
}
