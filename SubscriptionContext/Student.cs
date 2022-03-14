using System;
using System.Collections.Generic;
using System.Linq;
using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class student : Base
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscription { get; set; }
        public bool IsPremium => Subscription.Any(x => !x.IsInactive);
    }
}