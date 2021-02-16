<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebFormsTraining.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="login" method="post" runat="server" style="text-align: center">
        <div style="text-align:left" >
            <a runat="server"   href="~/Default2" > Back to Home Screen </a>
        </div>
   
        <div>

        </div>
   
        <div>
            <h1>Welcome, please login</h1>
        </div>
        <div>
            <p> USERNAME:  <asp:TextBox Id="usernameTxt" runat="server"></asp:TextBox></p>
            <p> PASSWORD:  <asp:TextBox Id="passwordTxt" TextMode="Password" runat="server"></asp:TextBox></p>
            <p><asp:Button Id="loginBtn" Text="Login"  OnClick="LoginBtn_Click"  runat="server"></asp:Button></p>
        </div>
        <div>
            <p><asp:Label Id="infoLbl" runat="server"></asp:Label></p>
        </div>
    </form>
</body>
</html>
