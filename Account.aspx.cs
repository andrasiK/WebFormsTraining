using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Threading;
using CustomControls;

namespace WebFormsTraining
{
    public partial class Account : System.Web.UI.Page
    {
        string accNmb;

        
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterClientScriptInclude("JavaScript", ResolveUrl("~/JavaScript.js"));

            string userName = (string)Session["UserName"];
            User.Text = userName;

            accNmb = Request.QueryString["AccountNumber"];

            if (accNmb != null)
            {
                bool isAccountBasedSearch = true;

                AccNumber.Attributes.Add("ReadOnly","ReadOnly");
                AccNumber.BorderStyle = BorderStyle.None;
                AccType.Attributes.Add("ReadOnly", "ReadOnly");
                AccType.BorderStyle = BorderStyle.None;
                AccLanguage.Attributes.Add("ReadOnly", "ReadOnly");
                AccLanguage.BorderStyle = BorderStyle.None;
                AccBalance.Attributes.Add("ReadOnly", "ReadOnly");
                AccBalance.BorderStyle = BorderStyle.None;
                ClientId.Attributes.Add("ReadOnly", "ReadOnly");
                ClientId.BorderStyle = BorderStyle.None;

                createAcc.Visible = false;

                WebFormsTraining.ServiceReference2.WebServiceDBSoapClient webService2 = new ServiceReference2.WebServiceDBSoapClient();

                List<ServiceReference2.Account> account = new List<ServiceReference2.Account>();
                account = webService2.Get(accNmb, isAccountBasedSearch).ToList();
                
                AccNumber.Text = account[0].AccountNumber.ToString();
                AccType.Text = account[0].AccountType;
                AccLanguage.Text = account[0].AccountLanguage;
                AccBalance.Text = account[0].AccountBalance.ToString();
                ClientId.Text = account[0].ClientNumber.ToString();
        
            }
            /*
            // use the custom control for label

            var messageList = (List<ServiceReference2.Message>)Session["Message"];
            var language =(string) Session["Language"];
            
            foreach (var item in messageList)
            {
                if (item.MessageLanguage == language )
                {
                    switch (item.MessageId)
                    {
                        case 1:
                            accountNumber.LabelText = item.MessageText;
                            break;
                        case 2:
                            accountType.LabelText = item.MessageText;
                            break;
                        case 3:
                            accountLanguage.LabelText = item.MessageText;
                            break;
                        case 4:
                            accountBalance.LabelText = item.MessageText;
                            break;
                        case 5:
                            cId.LabelText = item.MessageText;
                            break;
                        case 6:
                            accountNumber.LabelText = item.MessageText;
                            break;
                        case 7:
                            accountType.LabelText = item.MessageText;
                            break;
                        case 8:
                            accountLanguage.LabelText = item.MessageText;
                            break;
                        case 9:
                            accountBalance.LabelText = item.MessageText;
                            break;
                        case 10:
                            cId.LabelText = item.MessageText;
                            break;

                    }
                }
                
                
                
                
               
              
            }
            
            */


            
        }

        protected void CreateAcc_Click(object sender, EventArgs e)
        {

            ServiceReference2.WebServiceDBSoapClient webService2 = new ServiceReference2.WebServiceDBSoapClient();

            var insertError = webService2.Insert(AccNumber.Text, AccType.Text, AccLanguage.Text, AccBalance.Text, ClientId.Text); 
                 
            if (insertError == 1)
            {
                errorLabel.Attributes.Add("style", "color:Red;");
                errorLabel.Text = "Some error happened during the insertion to database!";
            }
            if (insertError == 2)
            {
                errorLabel.Attributes.Add("style", "color:Red;");
                errorLabel.Text = "Please fill out all of the fields and use valid values!";
            }
            else
            {
                Response.Redirect("Client.aspx?clientID=" + ClientId.Text);
            }

            
        }

    }
}