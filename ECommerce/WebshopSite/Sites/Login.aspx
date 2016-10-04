<%@ Page Title="Login" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebshopSite.Sites.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="AsideContent" runat="server">
    <div id="LoginNav" class="col-md-2" runat="server">

    </div>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="LoginContent" class="col-md-3" runat="server">
        <h2 class="header">Login</h2>
        <div class="formcol">
        <asp:Label ID="lbl_loginerror" runat="server" ForeColor="Red" Text="Incorrect username or password." Visible="False"></asp:Label>
         </div>
        <div class="formcol">
        <asp:Label ID="lbl_username" runat="server" Text="Username:" CssClass="reg_lbl"></asp:Label>
        <asp:TextBox ID="txtbox_username" runat="server" CssClass="text_box"></asp:TextBox>
        <asp:RequiredFieldValidator ID="reqfieldval_username" runat="server" ControlToValidate="txtbox_username" ErrorMessage="* You must enter a username." ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="formcol">

        <asp:Label ID="lbl_password" runat="server" Text="Password:" CssClass="reg_lbl"></asp:Label>
        <asp:TextBox ID="txtbox_password" runat="server" TextMode="Password" CssClass="text_box"></asp:TextBox>
        <asp:RequiredFieldValidator ID="reqfieldval_password" runat="server" ErrorMessage="* You must enter a password." ForeColor="Red" ControlToValidate="txtbox_password"></asp:RequiredFieldValidator>
        </div>
        <div class="formcol">
        
        

        </div>
        <div class="formcol">
        <asp:LinkButton ID="btn_register" runat="server" CausesValidation="False" OnClick="btn_register_Click">Register?</asp:LinkButton>
        <asp:Button ID="btn_login" runat="server" Text="Login" OnClick="btn_login_Click" CssClass="formbtn"  />
        </div>

    </div>

</asp:Content>
