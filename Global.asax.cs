using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using WebFormsTraining.ServiceReference2;
using Wrapper;

namespace WebFormsTraining
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


         // load messages to application variable
            List<ServiceReference2.Message> messageList = new List<ServiceReference2.Message>();
            WebFormsTraining.ServiceReference2.WebServiceDBSoapClient webService2Db = new ServiceReference2.WebServiceDBSoapClient();
            messageList = webService2Db.GetMessages().ToList();

            List<string> msgListString = new List<string>();

            msgListString.Add("K");



            int i = 0;
                for (int j = 0; j < ((messageList.Count)*4); j++)
                {
                if (i < messageList.Count)
                {
                    msgListString[j] = messageList[i].MessageId.ToString();
                    msgListString.Add(msgListString[j]);
                    j++;

                    msgListString[j] = messageList[i].MessageLanguage.ToString();
                    msgListString.Add(msgListString[j]);
                    j++;

                    msgListString[j] = messageList[i].MessageText.ToString();
                    msgListString.Add(msgListString[j]);
                    j++;

                    msgListString[j] = messageList[i].CustomId.ToString();
                    msgListString.Add(msgListString[j]);
                }
         
              
                    i++;
                }
                
               
                

            


            Application["Messages"] = msgListString;



        }

        void Session_Start(object sender, EventArgs e)
        {
            
            // Load Message table data from DB to session
            /*
            MessageReader reader = new MessageReader();
            reader.GetMessagesToSession();
            */
        }

    }
}