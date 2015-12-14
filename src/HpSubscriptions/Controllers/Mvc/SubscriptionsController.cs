using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using HpSubscriptions.Database;
using HpSubscriptions.Entities;

namespace HpSubscriptions.Controllers.Mvc
{
    public partial class SubscriptionsController : Controller
    {
        // GET: Subscriptions
        [HttpGet]
        public virtual async Task<ActionResult> Index()
        {
            IEnumerable<SubscriptionRecord> records;

            using (var context = new DatabaseContext())
            {
                records = await context.Records.OrderByDescending(x => x.Created).ToListAsync();
            }

            return View(records);
        }

        [HttpGet]
        public virtual async Task<ActionResult> Content(long id)
        {
            SubscriptionRecord record;

            using (var context = new DatabaseContext())
            {
                record = await context.Records.FirstOrDefaultAsync(x => x.Id == id);
            }

            if (record == null)
                return HttpNotFound();

            Response.AddHeader("Content-Disposition",
                "inline; filename=content" + id + ".xml");

            return new FileContentResult(Encoding.UTF8.GetBytes(record.Content), "text/xml");
        }
    }
}