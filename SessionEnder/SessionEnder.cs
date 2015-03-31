using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Analytics;
using Sitecore.Analytics.Tracking;

namespace SessionEnder
{
    public class SessionEnder
    {
        public string EndSession()
        {
            string result = string.Empty;   

            if (Tracker.Current != null)
            {
                if (Tracker.Current.IsActive)
                {
                    Sitecore.Analytics.Tracker.Current.EndVisit(true);
                    //System.Web.HttpContext.Current.Session.Abandon();
                    result = "Analytics Flushed";
                }
            }
            else
            {
                result = "Tracker is not active";
            }
            return result;
        }
    }
}
