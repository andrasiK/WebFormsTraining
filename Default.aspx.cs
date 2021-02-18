using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebFormsTraining
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // get userName stored in session
            string userName = (string)Session["UserName"];
            User.Text = userName;
        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                var connectionString = ConfigurationManager.ConnectionStrings["bankingAppDbConnection"].ConnectionString;
                var insertStatement = "INSERT into Client (ClientNumber, ClientName) values (@Number, @Name)";

                using (var sqlConnection = new SqlConnection(connectionString)) 
                {
                    sqlConnection.Open();
                    using (var sqlCommand = new SqlCommand(insertStatement, sqlConnection)) 
                    {
                        sqlCommand.Parameters.AddWithValue("Number", 1212);
                        sqlCommand.Parameters.AddWithValue("Name", "Peter");
                        sqlCommand.ExecuteNonQuery();
                    }
                
                }


                    Response.Redirect("Client.aspx?clientID=" + clientSrch.Text + "&language=" + countryList.Text);
            }

        }
    }
}