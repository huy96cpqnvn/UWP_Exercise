<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HelloWebForm.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Login Page</div>
        <p>
            Username<asp:TextBox ID="TextBox1" runat="server" style="margin-left: 14px" Width="183px"></asp:TextBox>
        </p>
        <p>
            Password<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 16px" Width="183px"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
