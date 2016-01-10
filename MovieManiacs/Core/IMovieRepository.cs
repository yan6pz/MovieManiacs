using Core.InfoModels;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IMovieRepository : IBaseRepository<Movies>
    {
        Movies FindByMovieName(string username);
        IEnumerable<Movies> GetAllMovies();
        void CreateNewMovie(Movie movie);
    }
}
