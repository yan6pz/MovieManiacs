using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    class EmailService
    {
        private async Task ScheduleNotifications()
        {

                HttpClientHandler handler = new HttpClientHandler()
                {
                    UseDefaultCredentials = true 
                };

                using (HttpClient client = new HttpClient(handler))
                {
                    client.BaseAddress = new Uri("http://localhost:63640/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    await client.GetAsync("notify/send/" + 2);
                }
            
        }
    }
}
