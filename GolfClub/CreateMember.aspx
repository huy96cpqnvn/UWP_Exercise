﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateMember.aspx.cs" Inherits="GolfClub.CreateMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <br />
        <br />
        Name:<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        Gender:
        <asp:DropDownList ID="drpGender" runat="server" Height="66px">
        <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:DropDownList>
        <br />
        Membership Fee:
        <asp:TextBox ID="txtfees" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <br />
    </form>
</body>
</html>
