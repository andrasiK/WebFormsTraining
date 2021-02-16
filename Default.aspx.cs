using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsTraining
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                Response.Redirect("Client.aspx?clientID=" + clientSrch.Text + "&language=" + countryList.Text);
            }

        }
    }
}