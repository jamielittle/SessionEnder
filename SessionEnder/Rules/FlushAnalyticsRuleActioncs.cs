using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Rules.Actions;

namespace SessionEnder.Rules
{
    public class FlushAnalyticsRuleAction<T> : RuleAction<T> where T : Sitecore.Rules.RuleContext
    {
        public override void Apply(T ruleContext)
        {
            FlushAnalytics();
        }

        private void FlushAnalytics()
        {
            SessionEnder ender = new SessionEnder();
            ender.EndSession();
        }
    }
}
