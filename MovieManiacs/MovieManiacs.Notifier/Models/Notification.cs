using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieManiacs.Notifier.Models
{
    public class Notification
    {
        public int rank { get; set; }
        public int userId { get; set; }
        public string message { get; set; }
    }
}