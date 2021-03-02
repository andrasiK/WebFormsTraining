using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AppDataLayer;
using System.Data;

namespace AppServiceLayer
{
    /// <summary>
    /// Summary description for WebServiceDB
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceDB : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public DataTable Get(string s, bool isAccountBasedSearch)
        {
            if (isAccountBasedSearch == false)
            {
                DataTable dataTable = new DataTable();
                DataAccess dataAccess = new DataAccess();
                dataTable = dataAccess.GetAccount(s);
                return dataTable;
            }
            else
            {
                DataTable dataTable = new DataTable();
                DataAccess dataAccess = new DataAccess();
                dataTable = dataAccess.GetAccountAccountNmb(s);
                return dataTable;
            }

        }

        
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
