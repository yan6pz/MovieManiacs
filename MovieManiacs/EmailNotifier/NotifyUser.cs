using BusinessEntities;
using Core;
using Data;
using Hangfire;
using System;

namespace EmailNotifier
{
    public class NotifyUser
    {
        public bool AddToQueue(int id, string message, string subject)
        {
            BackgroundJob.Enqueue(() => ExecuteTask(id, message, subject));

            RecurringJob.AddOrUpdate(string.Format("comment_{0}", id), () => ExecuteTask(id, message, subject),
                    string.Format("{0} {1} {2} {3} {4}", DateTime.UtcNow.Minute, DateTime.UtcNow.Hour, "*", "*", "1-5"));

            return true;
        }

        public void ExecuteTask(int id, string message, string subject)

        {
            // Create DB Context
            using (var dbContext = new MovieManiacsContext())
            {
                NotifyViaSMTP(id, message, subject);

            }

        }

        public bool NotifyViaSMTP(int id, string message, string subject)
        {
            var userService = new UserService();
            var user = userService.FindById(id);
            var emailSender = new EmailSender();

            var result = emailSender.Send(user.Email, subject, message);
            return result;
        }
    }
}
