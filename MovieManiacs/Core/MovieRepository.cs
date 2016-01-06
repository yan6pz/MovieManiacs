using Data;
using System.Collections.Generic;
using System.Linq;
namespace Core
{
    public class MovieRepository : BaseRepository<Movies>, IMovieRepository
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
    }
}
