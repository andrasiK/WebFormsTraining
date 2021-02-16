using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// Some setup for the logger
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace WebFormsTraining
{

    
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // instatiate a logger
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            // label is not needed anymore
            //    
            //    infoLbl.Text = "Username: " + usernameTxt.Text + "||" +
            //                   "Password: " + passwordTxt.Text;
            //

            // Store Username in session
            HttpContext.Current.Session["UserName"] = usernameTxt.Text; 


            // log the credentials into C:\Logs\RollingFileLog.txt
            log.Info("Username: " + usernameTxt.Text + ", " + "Password : " + passwordTxt.Text );

            Response.Redirect("Default.aspx");

        }
    }
}