using System;

namespace HpSubscriptions.Models
{
    public class SubscriptionRecordViewModel
    {
        public long Id { get; set; }

        public string Type { get; set; }

        public DateTime Created { get; set; }
    }
}