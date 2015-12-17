using System.Threading.Tasks;
using System.Web.Http;
using HpSubscriptions.Database;
using HpSubscriptions.Entities;

namespace HpSubscriptions.Controllers.Api
{
    public class SubscriptionsController: ApiController
    {
        [Route("api/subscriptions/{subscriptionType}")]
        [HttpPost]
        public async Task<IHttpActionResult> Post(string subscriptionType)
        {
            string content = await Request.Content.ReadAsStringAsync();

            using (var context = new DatabaseContext())
            {
                context.Records.Add(new SubscriptionRecord
                {
                    Type = subscriptionType,
                    Content = content,
                    ContentType = Request.Content.Headers.ContentType.MediaType
                });

                await context.SaveChangesAsync();
            }

            return Ok();
        }
    }
}