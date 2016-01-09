using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieManiacs.ViewModels
{
    public class MovieVM
    {
        public int Id { get; set; }
        public string title { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<System.DateTime> ReleaseDate { get; set; }
        public string imageurl { get; set; }
        public Nullable<int> Rank { get; set; }
        public string genre { get; set; }
        public string description { get; set; }
        public string starring { get; set; }
    }
}