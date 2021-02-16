<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsTraining.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Client search page</title>
</head>
<body style="width:800px; height:600px; margin:0px auto 0px auto;">
    <form id="clientSearch" runat="server" style="text-align: center">
        <div style="height:50px">
        </div>
        <div>
            <h1>Client Search Page</h1>
        </div>
        <div style="height:50px"></div>

        <div>
        <asp:RequiredFieldValidator runat="server" id="reqClientId" controltovalidate="clientSrch" ForeColor="red" errormessage="Please enter a Client Id!" />
        <p>Client ID:  <asp:TextBox Id="clientSrch" runat="server"></asp:TextBox> </p>
        
        
        <asp:RequiredFieldValidator runat="server" id="reqCountry" controltovalidate="countryList" ForeColor="red" errormessage="Please choose from the list!" />
        <p style="text-align:left; margin-left:290px" >Language:        
        <asp:DropDownList id="countryList" runat="server">
                  <asp:ListItem Value="">  </asp:ListItem>
                  <asp:ListItem Value="ENG"> ENG </asp:ListItem>
                  <asp:ListItem Value="CZ"> CZ </asp:ListItem>
        </asp:DropDownList>
        </p>
            <br /><br />
        <p><asp:Button Id="searchBtn" Text="Search"  OnClick="SearchBtn_Click"  runat="server"></asp:Button></p>
        </div>
    </form>
</body>
</html>
