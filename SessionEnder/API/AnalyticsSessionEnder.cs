using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;
using System.Web.UI.WebControls.WebParts;
using Sitecore.Analytics;
using Sitecore.Analytics.Tracking;
using Sitecore.Services.Infrastructure.Web.Http;

namespace SessionEnder.API
{
    public class AnalyticsSessionEnderController : ApiController
    {
        [HttpGet]
        public string EndAnalyticsSession()
        {
            string result = "Analytics Not Flushed";

            SessionEnder session = new SessionEnder();
            result = session.EndSession();

            return result;
        }
    }
}
