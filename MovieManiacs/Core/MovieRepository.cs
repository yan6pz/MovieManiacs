using Data;
using System.Collections.Generic;
using System.Linq;
using Core.InfoModels;
using System;

namespace Core
{
    public class MovieRepository : BaseRepository<Movies>, IBaseRepository<Movies> , IMovieRepository
    {
        public MovieRepository(MovieManiacsContext context)
         : base(context)
        { }

        public Movies FindByMovieName(string moviename)
        {
            var result = this.Context.Movies.FirstOrDefault(u => u.Name == moviename);
            return result;
        }

        public IEnumerable<Movies> GetAllMovies()
        {
            var results = this.Context.Movies.AsQueryable();
            return results;
        }

        void IMovieRepository.CreateNewMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        void CreateNewMovie(Movie movie)
        {
        
        }

    }
}
