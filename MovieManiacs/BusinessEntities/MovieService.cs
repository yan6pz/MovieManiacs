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

        public void CreateNewMovie(string title, string description, string genre, DateTime ReleaseDate, string starring, string imageurl)
        {
            Movie movie = new Movie();
            movie.Name = title;
            movie.Description = description;
            movie.Genre = genre;
            movie.ReleaseDate = ReleaseDate;
            movie.Starring = starring;
            movie.ImageUrl = imageurl;
            client.CreateNewMovie(movie);

        }


    }
}
