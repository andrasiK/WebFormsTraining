<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Client.aspx.cs" Inherits="WebFormsTraining.client" %>

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
            <p>USER:  <asp:TextBox Id="User" BorderStyle="None" runat="server"></asp:TextBox> </p>
        </div>
        <div style="text-align:center">
            <h1>Client Details Page</h1>
        </div>
        <div style="height:50px">

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">


            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:bankingAppDbConnectionString %>" SelectCommand="SELECT DISTINCT * FROM [Account]" ProviderName="System.Data.SqlClient">
            </asp:SqlDataSource>

        </div>
        <div style="text-align:center">
            <p><asp:Label Id="clientDetailsLabel" runat="server"></asp:Label></p>
        </div>
    </form>
</body>
</html>
