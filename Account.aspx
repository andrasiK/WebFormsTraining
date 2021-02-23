<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="WebFormsTraining.Account" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:50%; margin:0 auto; text-align:center;">
            <h1>Account Detail Page</h1>
        </div>
        <div id="details" style="width:800px; margin:0 auto;">
             <p>Account Number:  <asp:TextBox Id="AccNumber" BorderStyle="None" runat="server"></asp:TextBox> </p>
             <p>Account Type:    <asp:TextBox Id="AccType" BorderStyle="None" runat="server"></asp:TextBox> </p>
             <p>Account Language:<asp:TextBox Id="AccLanguage" BorderStyle="None" runat="server"></asp:TextBox> </p>
             <p>Account Balance: <asp:TextBox Id="AccBalance" BorderStyle="None" runat="server"></asp:TextBox> </p>
        </div>
    </form>
</body>
</html>
