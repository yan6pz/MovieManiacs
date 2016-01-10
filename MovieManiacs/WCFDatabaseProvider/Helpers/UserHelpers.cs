using Core.InfoModels;
using Data;
using System.Collections.Generic;

namespace WCFDatabaseProvider.Helpers
{
    public static class UserHelpers
    {
        public static void ParseUserFriend(this Users friend,ref List<User> userFriends)
        {
            userFriends.Add(new User
            {
                Id = friend.Id,
                UserName = friend.UserName,
                FirstName = friend.FirstName,
                LastName = friend.LastName,
                Email = friend.Email,
                ImageUrl=friend.ImageUrl,
                RegistrationDate = friend.RegistrationDate
            });
        }
    }
}