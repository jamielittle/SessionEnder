using System.Web.Http;
using System.Web.Routing;
using Sitecore.Services.Core.Configuration;
using Sitecore.Services.Infrastructure.Sitecore;

namespace SessionEnder.PipelineProcessors
{
    using Sitecore.Diagnostics;
    using Sitecore.Pipelines;

    public class RegisterRoutePipelineProcessor
    {
        public void Process(PipelineArgs args)
        {
            System.Web.Http.GlobalConfiguration.Configuration.Routes.MapHttpRoute("api", "api/{controller}/{action}");

            Log.Info("SessionEnder route has been set up", this);
        }
    }
}