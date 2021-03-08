using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Wrapper
{
    public class Account
    {

        public int AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string AccountLanguage { get; set; }
        public int AccountBalance { get; set; }
        public int ClientNumber { get; set; }


    }   


}
