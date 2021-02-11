using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace WebFormsTraining
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected void LoginBtn_Click(object sender, EventArgs e)
        {
           
            infoLbl.Text = "Username: " + usernameTxt.Text + "||" +
                           "Password: " + passwordTxt.Text;

            log.Info("Username: " + usernameTxt.Text + ", " + "Password : " + passwordTxt.Text );
            
        }
    }
}