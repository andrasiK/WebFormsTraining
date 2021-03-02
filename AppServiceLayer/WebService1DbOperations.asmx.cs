using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using DataLayer;
using System.Data.SqlClient;

namespace ServiceLayer
{
    /// <summary>
    /// Summary description for WebService1DbOperations
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1DbOperations : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "This is my first Web Service";
        }


        [WebMethod]
        public DataTable Get(string s)
        {
            DataTable dataTable = new DataTable();
            DataAccess dataAccess = new DataAccess();
            dataTable = dataAccess.GetAccount(s);
            return dataTable;
        }

        // !!!!
        // will need an other GET() service or a decision inside the existing one, 
        // for the case when the selection is based on the account number-

        [WebMethod]
        public int Insert(string accNbr, string accType, string accLanguage, string accBalance, string clientNumber)
        {
            int returnCode;
            DataAccess dataAccess = new DataAccess();
            returnCode = dataAccess.InsertNewAccount(accNbr, accType, accLanguage, accBalance, clientNumber);
            return returnCode;
        }


    }
}
