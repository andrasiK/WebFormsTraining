<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Client.aspx.cs" Inherits="WebFormsTraining.client" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Client details</title>
</head>
<body>
    <form id="clientDetails" runat="server">
        <div>
             <a runat="server"   href="~/Default2" > Back to Home Screen </a>
        </div>
        <div style="text-align:right">
            <p>USER:  <asp:TextBox Id="User" ReadOnly="true" BorderStyle="None" runat="server"></asp:TextBox> </p>
        </div>
        <div style="text-align:center">
            <h1>Client Details Page</h1>
        </div>

        <div style="height:50px; align-content:center; height:200px">
            <asp:GridView HorizontalAlign="Center" ID="GridView1" runat="server" Width="103px" Height="57px" OnRowDataBound="OnRowDataBound" OnSelectedIndexChanged="OnSelectedIndexChanged">
            </asp:GridView>
        </div>
        <div style="text-align:center">
            <p><asp:Label Id="clientDetailsLabel" runat="server"></asp:Label></p>
        </div>
        <div style="text-align:center ; margin:auto"  >
             <p><asp:Button Id="addAcc"  Text="Add New Account" PostBackUrl="~/Account.aspx"  runat="server"></asp:Button></p>
        </div>
    </form>
</body>
</html>
