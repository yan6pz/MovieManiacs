using Core.InfoModels;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IUserRepository:IBaseRepository<Users>
    {
        Users FindByUsername(string username);
        Users FindById(int id);
        IEnumerable<Users> GetUserFriends(int userId);
        IEnumerable<Movies> GetUserMovies(int userId);
        void CreateNewUser(User user);
    }
}
