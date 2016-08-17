using Data;
using System.Collections.Generic;
using System.Linq;
using Core.InfoModels;
using System;
using System.Threading.Tasks;

namespace Core
{
    public class UserRepository : BaseRepository<Users>, IBaseRepository<Users>, IUserRepository
    {

        public UserRepository(MovieManiacsContext context)
         : base(context)
        { }

        public Users FindByUsername(string username)
        {
            var result= this.Context.Users.FirstOrDefault(u => u.UserName == username);
        
            return result;
        }

        public Users FindById(int id)
        {
            var result = this.Context.Users.Find(id);

            return result;
        }

        public IEnumerable<Users> GetUserFriends(int userId)
        {
            var result = this.Context.Users.Find(userId);
            return result.Users1;
        }

        public IEnumerable<Users> GetAllUsers()
        {
            return this.Context.Users;
        }


        public IEnumerable<Movies> GetUserMovies(int userId)
        {
            var result = this.Context.Users.Find(userId);
            return result.Movies;
        }

        public void CreateNewUser(User user)
        {
            
        }

        public void Add(IEnumerable<User> entities)
        {
            throw new NotImplementedException();
        }

        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Attach(User entity)
        {
            throw new NotImplementedException();
        }

        public void Create(IEnumerable<User> entities)
        {
            throw new NotImplementedException();
        }

        public int Create(Users entity)
        {
            return base.Create(entity);
        }

        public override  Task<int> CreateAsync(Users entity)
        {
            return base.CreateAsync(entity);
        }

        IList<Users> IBaseRepository<Users>.GetAll()
        {
            throw new NotImplementedException();
        }

        public int Delete(IEnumerable<User> entities)
        {
            throw new NotImplementedException();
        }

        public int Delete(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
