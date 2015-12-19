using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class UserService
    {
        public DataProvider.DataProviderClient client = new DataProvider.DataProviderClient();

        public int Id { get; set; }
        public string UserName { get; set; }
        public Guid Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }


        public UserService GetByUserName(string userName)
        {
            var user = client.GetUserByUserName(userName);
            var result = new UserService() { Id = user.Id, Email = user.Email };
            return result;
        }
    }
}
