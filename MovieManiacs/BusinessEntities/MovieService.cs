using Core.InfoModels;
using System;
using System.Collections.Generic;

namespace BusinessEntities
{
    public class MovieService
    {
        public DataProvider.DataProviderClient client = new DataProvider.DataProviderClient();

        public Movie FindByMovieName(string movieName)
        {
            var movie = client.FindByMovieName(movieName);

            return movie;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            var movies = client.GetAllMovies();
            return movies;
        }

    }
}
