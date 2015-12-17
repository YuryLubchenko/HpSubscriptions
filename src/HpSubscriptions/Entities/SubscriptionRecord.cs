using System;

namespace HpSubscriptions.Entities
{
    public class SubscriptionRecord
    {
        public SubscriptionRecord()
        {
            Created = DateTime.UtcNow;
        }

        public long Id { get; set; }
        
        public string Type { get; set; }
        
        public string Content { get; set; }

        public string ContentType { get; set; }

        public DateTime Created { get; set; }
    }
}