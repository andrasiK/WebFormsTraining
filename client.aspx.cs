using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsTraining
{
    public partial class client : System.Web.UI.Page
    {  
        string clientID;
        protected void Page_Load(object sender, EventArgs e)
        {

            // get userName stored in session
            string userName = (string)Session["UserName"];
            User.Text = userName;

            clientID = Request.QueryString["clientID"];

            // access to DB and pass Client ID as a parameter
            var db = new DataAccess();
   
            DataTable dt = db.GetAccount(clientID);

            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                clientDetailsLabel.Text = "No Record Found";
            }


            // this is not needed anymore
            //   string language = Request.QueryString["language"];
            //   clientDetailsLabel.Text = "Client ID: " + clientID + "|| Selected Language:" + language;
        }
    }
}