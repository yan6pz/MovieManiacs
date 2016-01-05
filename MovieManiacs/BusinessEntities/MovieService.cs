using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class MovieService
    {
        public DataProvider.DataProviderClient client = new DataProvider.DataProviderClient();

        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<System.DateTime> ReleaseDate { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<int> Rank { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string Starring { get; set; }

        public MovieService FindByMovieName(string movieName)
        {
            var movie = client.FindByMovieName(movieName);
            var result = new MovieService()
            {
                Id = movie.Id,
                Name = movie.Name,
                Year = movie.Year,
                ReleaseDate = movie.ReleaseDate,
                ImageUrl = movie.ImageUrl,
                Rank = movie.Rank,
                Genre = movie.Genre,
                Description = movie.Description,
                Starring = movie.Starring
            };
            return result;
        }
    }
}
