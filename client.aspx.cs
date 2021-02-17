using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsTraining
{
    public partial class client : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // get userName stored in session
            string userName = (string)Session["UserName"];
            User.Text = userName;

            string clientID = Request.QueryString["clientID"];
            string language = Request.QueryString["language"];
            clientDetailsLabel.Text = "Client ID: " + clientID + "|| Selected Language:" + language;
        }
    }
}