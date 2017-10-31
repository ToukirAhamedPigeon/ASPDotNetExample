using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ASPDotNetExample
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["Application"] = 0;
            Application["Session"] = 0;
            Application["Application"]=(int)Application["Application"]+1;
        }
        void Session_Start(object sender, EventArgs e)
        {
            Application["Session"] = (int)Application["Session"] + 1;
        }

        void Session_End(object sender, EventArgs e)
        {
            Application["Session"] = (int)Application["Session"] - 1;
        }

        void Application_End(object sender, EventArgs e)
        {
            Application["Application"] = (int)Application["Application"] - 1;
        }
    }
}