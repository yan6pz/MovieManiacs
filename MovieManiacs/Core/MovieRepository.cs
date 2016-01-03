using Core.InfoModels;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Core
{
    public class MovieRepository : BaseRepository<Movies>, IMovieRepository
    {
        public MovieRepository(MovieManiacsContext context)
         : base(context)
        { }

        public Movie FindByMovieName(string moviename)
        {
            var result = this.Context.Movies.FirstOrDefault(u => u.Name == moviename);
            var movie = new Movie() { Id = result.Id, Name = result.Name ,  Year = result.Year ,
                ReleaseDate = result.ReleaseDate,ImageUrl = result.ImageUrl, Rank = result.Rank,
                Genre = result.Genre,Description= result.Description,Starring = result.Starring };
            return movie;
        }
    }
}
