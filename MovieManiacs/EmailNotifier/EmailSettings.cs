using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailNotifier
{
    class EmailSettings
    {
        public string Host { get; set; }
        public int? Port { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool SSL { get; set; }

        public EmailSettings(string host, int? port, string email, string password, bool ssl)
        {
            Host = host;
            Port = port;
            Email = email;
            Password = password;
            SSL = ssl;
        }
    }
}
