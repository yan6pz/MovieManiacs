using BusinessEntities;
using Core;

namespace EmailNotifier
{
    public class NotifyUser
    {
        public bool NotifyViaSMTP(int id,string message,string subject)
        {
            var userService = new UserService();
            var user=userService.FindById(id);
            var emailSender = new EmailSender();

            var result = emailSender.Send(user.Email,subject,message);
            return result;
        }
    }
}
