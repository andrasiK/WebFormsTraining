using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using WebFormsTraining.ServiceReference2;

namespace WebFormsTraining
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


 
        }

        void Session_Start(object sender, EventArgs e)
        {
            
            // Load Message table data from DB to session

            MessageReader reader = new MessageReader();
            reader.GetMessagesToSession();
        }

    }
}