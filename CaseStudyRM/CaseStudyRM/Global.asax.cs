using System.Collections;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CaseStudyRM
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        
        protected void Application_BeginRequest()
        {
            string allowedOrigin =  "http://127.0.0.1:5000/";
            var origin = HttpContext.Current.Request.Headers["Origin"];
            if (origin != null && allowedOrigin.Contains(origin))
            {
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", origin);
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET,POST");
                //Need to add more later , will see when required
            }
        }
    }
}