<%@ Page Title="Login" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebshopSite.Sites.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="LoginContent" runat="server">

        <asp:Label ID="lbl_username" runat="server" Text="Username:"></asp:Label>
        <asp:TextBox ID="txtbox_username" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="reqfieldval_username" runat="server" ControlToValidate="txtbox_username" ErrorMessage="* You must enter a username." ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lbl_password" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtbox_password" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="reqfieldval_password" runat="server" ErrorMessage="* You must enter a password." ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="btn_login" runat="server" Text="Login" />
        <asp:Label ID="lbl_loginerror" runat="server" ForeColor="Red" Text="Incorrect username or password." Visible="False"></asp:Label>

    </div>

</asp:Content>
