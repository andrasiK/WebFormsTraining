using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsTraining
{
    public class MessageReader
    {

        public void GetMessagesToSession()
        {
            List<ServiceReference2.Message> messageList = new List<ServiceReference2.Message>();
            WebFormsTraining.ServiceReference2.WebServiceDBSoapClient webService2Db = new ServiceReference2.WebServiceDBSoapClient();
            messageList = webService2Db.GetMessages().ToList();

            HttpContext.Current.Session["Message"] = messageList;

        }
    }
}