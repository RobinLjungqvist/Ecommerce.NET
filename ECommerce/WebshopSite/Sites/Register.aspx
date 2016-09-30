<%@ Page Title="Register" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebshopSite.Sites.Register" %>
<asp:Content ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="" type="" media="screen" />
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="RegisterContent" runat="server" role="contentinfo">
        <h1>Registration</h1>
        <p>
            <asp:Label ID="lbl_username" runat="server" AssociatedControlID="txtbox_username" Text="Username:"></asp:Label>
            <asp:TextBox ID="txtbox_username" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_username" runat="server" ControlToValidate="txtbox_username" ErrorMessage="* You must enter a username." ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lbl_password" runat="server" Text="Password:" AssociatedControlID="txtbox_password"></asp:Label>
            <asp:TextBox ID="txtbox_password" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_password" runat="server" ControlToValidate="txtbox_password" ErrorMessage="* You must enter a password." ForeColor="Red"></asp:RequiredFieldValidator>
        <br />

            <asp:Label ID="lbl_pwreenter" runat="server" AssociatedControlID="txtbox_pwreenter" Text="Re-Enter Password: "></asp:Label>
            <asp:TextBox ID="txtbox_pwreenter" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_pwreenter" runat="server" ControlToValidate="txtbox_password" ErrorMessage="* You must re-enter password." ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="compareval_password" runat="server" ControlToCompare="txtbox_password" ControlToValidate="txtbox_pwreenter" ErrorMessage="* Passwords doesn't match." ForeColor="Red"></asp:CompareValidator>
            <br />
            <asp:Label ID="lbl_firstname" runat="server" Text="First name:" AssociatedControlID="txtbox_firstname"></asp:Label>
            <asp:TextBox ID="txtbox_firstname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_firstname" runat="server" ControlToValidate="txtbox_firstname" ErrorMessage="* You must enter a firstname" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lbl_lastname" runat="server" Text="Last name:" AssociatedControlID="txtbox_lastname"></asp:Label>
            <asp:TextBox ID="txtbox_lastname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_lastname" runat="server" ControlToValidate="txtbox_lastname" ErrorMessage="* You must enter a lastname" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lbl_email" runat="server" Text="Email:" AssociatedControlID="txtbox_email"></asp:Label>
            <asp:TextBox ID="txtbox_email" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_email" runat="server" ControlToValidate="txtbox_email" ErrorMessage="* You must enter a email adress." ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="regval_email" runat="server" ControlToValidate="txtbox_email" ErrorMessage="* You must enter a valid E-mail address." ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <asp:Label ID="lbl_streetadress" runat="server" Text="Street Adress" AssociatedControlID="txtbox_streetadress"></asp:Label>
            <asp:TextBox ID="txtbox_streetadress" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_adress" runat="server" ControlToValidate="txtbox_streetadress" ErrorMessage="* You must enter a street adress" ForeColor="Red"></asp:RequiredFieldValidator>
            <br/>
            <asp:Label ID="lbl_zipcode" runat="server" Text="Zipcode:" AssociatedControlID="txtbox_zipcde"></asp:Label>
            <asp:TextBox ID="txtbox_zipcde" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_zipcode" runat="server" ControlToValidate="txtbox_zipcde" ErrorMessage="* You must enter a zipcode" ForeColor="Red"></asp:RequiredFieldValidator>
            <br/>
            <asp:Label ID="lbl_city" runat="server" Text="City:" AssociatedControlID="txtbox_city"></asp:Label>
            <asp:TextBox ID="txtbox_city" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_city" runat="server" ControlToValidate="txtbox_city" ErrorMessage="* You must enter a city" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
        </p>
            <asp:Button ID="btn_register" runat="server" Text="Register" />

    </div>
</asp:Content>
