using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieManiacs.ViewModels
{
    public class UserVM
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public System.Guid Password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emails { get; set; }
        public System.DateTime RegistrationDate { get; set; }
        public string imageUrl { get; set; }
    }
}