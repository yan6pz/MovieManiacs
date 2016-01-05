using Core.InfoModels;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IMovieRepository
    {
        Movie FindByMovieName(string username);
        List<Movie> GetAllMovies();
    }
}
