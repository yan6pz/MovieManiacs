using EmailNotifier;
using System.Web.Http;

namespace MovieManiacs.Notifier.Controllers
{
    [AllowAnonymous]
    public class NotifyController : ApiController
    {
        [HttpGet]
        [Route("notify/send/{id}")]
        public IHttpActionResult test(int? id)
        {
            var service =new NotifyUser();
            service.AddToQueue(id.Value,"You have voted up.","Notification");
            return Ok();
        }
    }
}
