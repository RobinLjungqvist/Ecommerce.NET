<%@ Page Title="Login" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebshopSite.Sites.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="AsideContent" runat="server">
    <div id="MyAccountNav" class="col-md-2">
        <ul>
            <li>filler</li>
            
        </ul>
    </div>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="LoginContent" class="col-md-10" runat="server">

        <asp:Label ID="lbl_username" runat="server" Text="Username:"></asp:Label>
        <asp:TextBox ID="txtbox_username" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="reqfieldval_username" runat="server" ControlToValidate="txtbox_username" ErrorMessage="* You must enter a username." ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lbl_password" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtbox_password" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="reqfieldval_password" runat="server" ErrorMessage="* You must enter a password." ForeColor="Red" ControlToValidate="txtbox_password"></asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="btn_login" runat="server" Text="Login" OnClick="btn_login_Click" />
        <asp:Label ID="lbl_loginerror" runat="server" ForeColor="Red" Text="Incorrect username or password." Visible="False"></asp:Label>

        <br />
        <asp:LinkButton ID="btn_register" runat="server" CausesValidation="False" OnClick="btn_register_Click">Register?</asp:LinkButton>

    </div>

</asp:Content>
