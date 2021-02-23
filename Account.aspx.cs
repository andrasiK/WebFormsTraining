using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebFormsTraining
{
    public partial class Account : System.Web.UI.Page
    {
        string accNmb;
        protected void Page_Load(object sender, EventArgs e)
        {
            accNmb = Request.QueryString["AccountNumber"];

            var db = new DataAccess();

            DataTable dt        = db.GetAccountAccountNmb(accNmb);
            AccNumber.Text      = dt.Rows[0][0].ToString();
            AccType.Text        = dt.Rows[0][1].ToString();
            AccLanguage.Text    = dt.Rows[0][2].ToString();
            AccBalance.Text     = dt.Rows[0][3].ToString();
        }
    }
}