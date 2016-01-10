using EmailNotifier;
using MovieManiacs.Notifier.Models;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MovieManiacs.Notifier.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class NotifyController : ApiController
    {
        [HttpPost]
        [Route("notify/send")]
        public void test(Notification notify)
        {
            var service =new NotifyUser();
            service.AddToQueue(notify.userId, notify.message+" "+notify.rank, "Notification");
        }
    }
}
