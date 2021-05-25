<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationFrom.aspx.cs" Inherits="VideoGameStore.RegistrationFrom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
        <asp:TextBox ID="Name" Text="Name" runat="server"></asp:TextBox>
        <asp:TextBox ID="Email" Text="Email" runat="server"></asp:TextBox>
        <asp:TextBox ID="Password" Text="Password" runat="server"></asp:TextBox>
        <asp:Button ID="Submit" runat="server" OnClick="HandleRegister" Text="Register" />
    </form>
</body>
</html>
