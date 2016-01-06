using Core.InfoModels;
using Data;
using System.Collections.Generic;

namespace WCFDatabaseProvider.Helpers
{
    public static class MovieHelper
    {
        public static void ParseMovies(this Movies movie, ref List<Movie> movies)
        {
            movies.Add(new Movie()
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
            });
        }
    }
}