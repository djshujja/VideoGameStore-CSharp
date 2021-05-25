<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="VideoGameStore.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="Email" Text="Email" runat="server"></asp:TextBox>
            <asp:TextBox ID="Password" Text="Password" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="HandleLogin" Text="Login" />
        </div>
    </form>
</body>
</html>
