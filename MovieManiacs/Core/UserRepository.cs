using Core.InfoModels;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class UserRepository : BaseRepository<Users>, IUserRepository
    {

        public UserRepository(MovieManiacsContext context)
         : base(context)
        { }

        public User FindByUsername(string username)
        {
            var result= this.Context.Users.FirstOrDefault(u => u.UserName == username);
            var user = new User() { Id = result.Id , UserName = result.UserName ,Password =result.Password, FirstName = result.FirstName ,LastName = result.LastName, Email = result.Email, RegistrationDate = result.RegistrationDate };
            return user;
        }
    }
}
