using System.Web;
using System.Web.Routing;
using Sitecore.Pipelines.HttpRequest;

namespace SessionEnder.PipelineProcessors
{
    using Sitecore.Diagnostics;
    using Sitecore.Pipelines;

    // TODO: \App_Config\include\AbortSitecoreForKnownRoutes.config created automatically when creating AbortSitecoreForKnownRoutes class.

    internal class AbortSitecoreForKnownRoutes : HttpRequestProcessor
    {
        public override void Process(HttpRequestArgs args)
        {
            var routeCollection = RouteTable.Routes;
            var routeData = routeCollection.GetRouteData(new HttpContextWrapper(args.Context));

            if (routeData == null) return;

            HttpContext.Current.RemapHandler(
                routeData.RouteHandler.GetHttpHandler(HttpContext.Current.Request.RequestContext));
            args.AbortPipeline();
        }
    }
}