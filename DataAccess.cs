using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebFormsTraining
{
    public class DataAccess
    {


        // THIS METHOD WAS JUST FOR TESTING REASONS
        /*
          public void InsertToDB( string clientID)
          {
              var clientToSearch = clientID;


              var connectionString = ConfigurationManager.ConnectionStrings["bankingAppDbConnection"].ConnectionString;
              var insertStatement = "INSERT into Client (ClientNumber, ClientName) values (@Number, @Name)";

              using (var sqlConnection = new SqlConnection(connectionString))
              {
                  sqlConnection.Open();
                  using (var sqlCommand = new SqlCommand(insertStatement, sqlConnection))
                  {
                      sqlCommand.Parameters.AddWithValue("Number", 1232);
                      sqlCommand.Parameters.AddWithValue("Name", "Peter");
                      sqlCommand.ExecuteNonQuery();
                  }

              }
          }
                    */


        public DataTable GetAccount(string clientId)
        {
          // establish connection
            var connectionString = ConfigurationManager.ConnectionStrings["bankingAppDbConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

             // call stored procedure with parameter
                var sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@clientNumber", SqlDbType.Int);
                sqlCommand.Parameters["@clientNumber"].Value = clientId;
                sqlCommand.CommandText = "getAccount";


              // return the result in a Data Table
                using (SqlDataAdapter dAdapter = new SqlDataAdapter(sqlCommand))
                {
                    DataSet ds = new DataSet();
                    dAdapter.Fill(ds);

                    connection.Close();

                    return ds.Tables[0];
                }
            
            }

        }




    }
}