<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="HelloWebForm.ContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            margin-left: 70px;
            margin-top: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Contact Us<br />
            <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
            <br />
            Catgory<asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="margin-left: 85px; margin-top: 11px">
            <asp:ListItem Selected="True" Text="--Select--" Value="--Select--"></asp:ListItem>
                <asp:ListItem Text="News" Value="News"></asp:ListItem>
                <asp:ListItem Text="Report" Value="Report"></asp:ListItem>
                <asp:ListItem Text="System" Value="System"></asp:ListItem>
                <asp:ListItem Text="Reminder" Value="Reminder"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Description<textarea id="TextArea1" cols="20" name="S1" rows="2"></textarea><br />
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
