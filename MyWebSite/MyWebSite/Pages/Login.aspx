<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MyWebSite.Pages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Please Enter your Login details<br />
        <br />
        Username<asp:TextBox ID="tbxUsername" runat="server"></asp:TextBox>
        <br />
        <br />
        Password<asp:TextBox ID="tbxPassword" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
    
    </div>
    </form>
</body>
</html>
