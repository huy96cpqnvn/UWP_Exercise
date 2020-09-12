<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="ShoppingMall.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="font-size: 36px">User Registration</div><br />
    Email
    <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 84px" Width="135px"></asp:TextBox>
    
    <br />
    UserName<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 55px"></asp:TextBox>
    <br />
    Password<asp:TextBox ID="TextBox3" runat="server" style="margin-left: 64px"></asp:TextBox>
    <br />
    Confirm Password<br />
    <br />
    <br />
    
</asp:Content>
