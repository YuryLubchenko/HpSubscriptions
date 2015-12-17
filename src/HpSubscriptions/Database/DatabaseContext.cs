using System.Data.Entity;
using HpSubscriptions.Entities;

namespace HpSubscriptions.Database
{
    public class DatabaseContext: DbContext
    {
        public DbSet<SubscriptionRecord> Records { get; set; }

        public DatabaseContext():base("HpSubscriptionsConnection")
        {
            
        }
    }
}