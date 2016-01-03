﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.InfoModels
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<System.DateTime> ReleaseDate { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<int> Rank { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string Starring { get; set; }
    }
}