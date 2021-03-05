using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsTraining.ServiceReference2;
using Wrapper;

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

            // instatiate proxy object and call web service
            WebFormsTraining.ServiceReference2.WebServiceDBSoapClient webService2Db = new ServiceReference2.WebServiceDBSoapClient();

            bool isAccountBasedSearch = false;
            List<ServiceReference2.Account> accountList = new List<ServiceReference2.Account>();
            accountList = webService2Db.Get(clientID, isAccountBasedSearch).ToList();
            

            if (accountList.Count > 0)
            {
                GridView1.DataSource = accountList;
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

        // attach an "onclick" event to the data rows
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";
                e.Row.ToolTip = "Click to select this row";
            }
        }

        // event handler for click
        public void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            string accNumb = row.Cells[0].Text;
            Response.Redirect("~/Account.aspx?AccountNumber=" + accNumb);
        }

        /*
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            string id = row.Cells[0].Text;
            Response.Redirect("Details.aspx?ID=" + id);
        }
        */

      

    }
}