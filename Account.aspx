<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="WebFormsTraining.Account" %>
<%@ Register Assembly="CustomControls"  Namespace="CustomControls"  TagPrefix="ccs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="MyJavaScript.js" type="text/javascript">    
</script>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:right">
            <p>USER:  <asp:TextBox Id="User" ReadOnly="true" BorderStyle="None" runat="server"></asp:TextBox> </p>
        </div>
        <div style="width:50%; margin:0 auto; text-align:center;">
            <h1>Account Detail Page</h1>
        </div>
        <div id="details" style="text-align:center; margin:auto;">
             <p>
                <ccs:CustomLabelControl1 ID="accountNumber" runat="server" CustomId="AccNumb"></ccs:CustomLabelControl1>
                <asp:TextBox Id="AccNumber" runat="server"></asp:TextBox>
             </p>
             <p>
                 <ccs:CustomLabelControl1 ID="accountType" runat="server" CustomId="AccTyp"></ccs:CustomLabelControl1>  
                 <asp:TextBox Id="AccType" runat="server"></asp:TextBox> 
             </p>
             <p>
                 <ccs:CustomLabelControl1 ID="accountLanguage" runat="server" CustomId="AccLang"></ccs:CustomLabelControl1>
                 <asp:TextBox Id="AccLanguage" runat="server"></asp:TextBox> 
             </p>
             <p>
                 <ccs:CustomLabelControl1 ID="accountBalance" runat="server" CustomId="AccBal"></ccs:CustomLabelControl1>
                 <asp:TextBox Id="AccBalance" runat="server"></asp:TextBox>
             </p>
             <p>
                 <ccs:CustomLabelControl1 ID="cId" runat="server" CustomId="ClientN"></ccs:CustomLabelControl1>
                 <asp:TextBox Id="ClientId" runat="server"></asp:TextBox>
             </p>
        </div>
         <div style="text-align:center; margin:auto">
             <p><asp:Button Id="createAcc"  Text="Create New Account" OnClientClick="return isAccountValid();" OnClick="CreateAcc_Click"   runat="server"></asp:Button></p>
        </div>
        <div></div>
        <div></div>
        <div style="text-align:center">
            <p><asp:Label Id="errorLabel" runat="server"></asp:Label></p>
        </div>
    </form>
</body>
</html>
