using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Wrapper;


namespace AppDataLayer
{

public class DataAccess
    {

        // Get account details based on client ID
        public List<Account> GetAccount(string clientId)
        {
            // establish connection
            string connectionString = ConfigurationManager.ConnectionStrings["bankingAppDbConnection2"].ConnectionString;
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


                //  map the data table values to an Account type list and return it
                using (SqlDataAdapter dAdapter = new SqlDataAdapter(sqlCommand))
                {
                    DataSet ds = new DataSet();
                    dAdapter.Fill(ds);
                    DataTable dt = ds.Tables[0];

                    List<Account> accountList = new List<Account>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Account account = new Account();
                        account.AccountNumber = Convert.ToInt32(dt.Rows[i]["AccountNumber"]);
                        account.AccountType = dt.Rows[i]["AccountType"].ToString();
                        account.AccountLanguage = dt.Rows[i]["AccountLanguage"].ToString();
                        account.AccountBalance = Convert.ToInt32(dt.Rows[i]["AccountBalance"]);
                        account.ClientNumber = Convert.ToInt32(dt.Rows[i]["ClientNumber"]);
                        accountList.Add(account);
                    }

                    connection.Close();

                    return accountList;
                }

            }

        }

        // method to call 'getAccount' stored procedure with account number parameter 
        public List<Account> GetAccountAccountNmb(string accountNumber)
        {
            // establish connection
            var connectionString = ConfigurationManager.ConnectionStrings["bankingAppDbConnection2"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // call stored procedure with parameter
                var sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@accountNumber", SqlDbType.Int);
                sqlCommand.Parameters["@accountNumber"].Value = accountNumber;
                sqlCommand.CommandText = "getAccount";


                // return the result in a Data Table
                using (SqlDataAdapter dAdapter = new SqlDataAdapter(sqlCommand))
                {
                    DataSet ds = new DataSet();
                    dAdapter.Fill(ds);

                    DataTable dt = ds.Tables[0];
                    Account account = new Account();
                    List<Account> accountList = new List<Account>();

                    account.AccountNumber = Convert.ToInt32(dt.Rows[0]["AccountNumber"]);
                    account.AccountType = dt.Rows[0]["AccountType"].ToString();
                    account.AccountLanguage = dt.Rows[0]["AccountLanguage"].ToString();
                    account.AccountBalance = Convert.ToInt32(dt.Rows[0]["AccountBalance"]);
                    account.ClientNumber = Convert.ToInt32(dt.Rows[0]["ClientNumber"]);
                    accountList.Add(account);

                    connection.Close();

                    return accountList;
                }

            }

        }

        public int InsertNewAccount(string accNbr, string accType, string accLanguage, string accBalance, string clientNumber)
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["bankingAppDbConnection2"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // call stored procedure with parameter
                    var sqlCommand = new SqlCommand();
                    sqlCommand.Connection = connection;
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.Add("@AccountNumber", SqlDbType.Int);
                    sqlCommand.Parameters["@AccountNumber"].Value = accNbr;
                    sqlCommand.Parameters.Add("@AccountType", SqlDbType.VarChar);
                    sqlCommand.Parameters["@AccountType"].Value = accType;
                    sqlCommand.Parameters.Add("@AccountLanguage", SqlDbType.VarChar);
                    sqlCommand.Parameters["@AccountLanguage"].Value = accLanguage;
                    sqlCommand.Parameters.Add("@AccountBalance", SqlDbType.Int);
                    sqlCommand.Parameters["@AccountBalance"].Value = accBalance;
                    sqlCommand.Parameters.Add("@ClientNumber", SqlDbType.Int);
                    sqlCommand.Parameters["@ClientNumber"].Value = clientNumber;

                    sqlCommand.CommandText = "insertAccount";
                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (FormatException)
                    {
                        return 2;
                    }


                    return 0;

                }
            }
            catch (SqlException ex)
            {
                return 1;
            }

        }


    }




}
