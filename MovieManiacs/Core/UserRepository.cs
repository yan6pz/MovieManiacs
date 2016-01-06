using Data;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public class UserRepository : BaseRepository<Users>, IUserRepository
    {

        public UserRepository(MovieManiacsContext context)
         : base(context)
        { }

        public Users FindByUsername(string username)
        {
            var result= this.Context.Users.FirstOrDefault(u => u.UserName == username);
        
            return result;
        }

        public IEnumerable<Users> GetUserFriends(int userId)
        {
            var result = this.Context.Users.Find(userId);
            return result.Users1;
        }
    }
}
