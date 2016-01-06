using Core.InfoModels;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IUserRepository
    {
        Users FindByUsername(string username);
        IEnumerable<Users> GetUserFriends(int userId);
    }
}
