﻿<%@ Page Title="Register" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebshopSite.Sites.Registration" %>
<asp:Content ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Style/registration.css" media="screen" />
</asp:Content>
<asp:Content ID="AsideQFL" ContentPlaceHolderID="AsideContent" runat="server">
    <div id="MyAccountNav" class="col-md-2" runat="server">

    </div>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="RegisterContent" runat="server" role="contentinfo" class="col-md-6">
        <h1 id="header">Registration</h1>
        <p>
            <asp:Label ID="lbl_errormsg" runat="server" ForeColor="Red"></asp:Label>
        </p>
        <div class="formcol">
            <asp:Label ID="lbl_username" runat="server" AssociatedControlID="txtbox_username" Text="Username:" CssClass="reg_lbl"></asp:Label>  
            <asp:TextBox ID="txtbox_username" runat="server" placeholder="Username" CssClass="text_box"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_username" runat="server" ControlToValidate="txtbox_username" ErrorMessage="* You must enter a username." ForeColor="Red" CssClass="validation"></asp:RequiredFieldValidator>
        </div>
        <div class="formcol">
            <asp:Label ID="lbl_password" runat="server" Text="Password:" AssociatedControlID="txtbox_password" CssClass="reg_lbl "></asp:Label>
            <asp:TextBox ID="txtbox_password" runat="server" TextMode="Password" placeholder="Password" CssClass="text_box"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_password" runat="server" ControlToValidate="txtbox_password" ErrorMessage="* You must enter a password." ForeColor="Red" CssClass="validation"></asp:RequiredFieldValidator>
        </div>
        <div class="formcol">
            <asp:Label ID="lbl_pwreenter" runat="server" AssociatedControlID="txtbox_pwreenter" Text="Password: " CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_pwreenter" runat="server" TextMode="Password" placeholder="Re-enter password" CssClass="text_box"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_pwreenter" runat="server" ControlToValidate="txtbox_password" ErrorMessage="* You must re-enter password." ForeColor="Red" Display="Dynamic" CssClass="validation"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="compareval_password" runat="server" ControlToCompare="txtbox_password" ControlToValidate="txtbox_pwreenter" ErrorMessage="* Passwords doesn't match." ForeColor="Red" Display="Dynamic" CssClass="validation"></asp:CompareValidator>
        </div>
        <div class="formcol">
            <asp:Label ID="lbl_firstname" runat="server" Text="First name:" AssociatedControlID="txtbox_firstname" CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_firstname" runat="server" placeholder="John..." CssClass="text_box"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_firstname" runat="server" ControlToValidate="txtbox_firstname" ErrorMessage="* You must enter a firstname" ForeColor="Red" CssClass="validation"></asp:RequiredFieldValidator>
        </div>
        <div class="formcol">
            <asp:Label ID="lbl_lastname" runat="server" Text="Last name:" AssociatedControlID="txtbox_lastname" CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_lastname" runat="server" placeholder="Doe..." CssClass="text_box" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_lastname" runat="server" ControlToValidate="txtbox_lastname" ErrorMessage="* You must enter a lastname" ForeColor="Red" CssClass="validation"></asp:RequiredFieldValidator>
        </div>
        <div class="formcol">
            <asp:Label ID="lbl_email" runat="server" Text="Email:" AssociatedControlID="txtbox_email" CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_email" runat="server" placeholder="name@email.com..." CssClass="text_box"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_email" runat="server" ControlToValidate="txtbox_email" ErrorMessage="* You must enter a email adress." ForeColor="Red" Display="Dynamic" CssClass="validation"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="regval_email" runat="server" ControlToValidate="txtbox_email" ErrorMessage="* You must enter a valid E-mail address." ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic" CssClass="validation"></asp:RegularExpressionValidator>
        </div>
        <div class="formcol">
            <asp:Label ID="lbl_streetadress" runat="server" Text="Street Adress:" AssociatedControlID="txtbox_streetadress" CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_streetadress" runat="server" placeholder="High street 43..." CssClass="text_box"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_adress" runat="server" ControlToValidate="txtbox_streetadress" ErrorMessage="* You must enter a street adress" ForeColor="Red" CssClass="validation"></asp:RequiredFieldValidator>
         </div>
        <div class="formcol">
            <asp:Label ID="lbl_zipcode" runat="server" Text="Zipcode:" AssociatedControlID="txtbox_zipcode" CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_zipcode" runat="server" placeholder="33233" CssClass="text_box"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_zipcode" runat="server" ControlToValidate="txtbox_zipcode" ErrorMessage="* You must enter a zipcode" ForeColor="Red" Display="Dynamic" CssClass="validation"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="regexpval_zip" runat="server" ControlToValidate="txtbox_zipcode" Display="Dynamic" ErrorMessage="* You must enter a zipcode." ForeColor="Red" ValidationExpression="^\d{5,5}" CssClass="validation"></asp:RegularExpressionValidator>
         </div>
        <div class="formcol">
            <asp:Label ID="lbl_city" runat="server" Text="City:" AssociatedControlID="txtbox_city" CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_city" runat="server" CssClass="text_box" placeholder="New York..."></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_city" runat="server" ControlToValidate="txtbox_city" ErrorMessage="* You must enter a city" ForeColor="Red" CssClass="validation"></asp:RequiredFieldValidator>
         </div>

        <div class="formcol">
            <asp:Button ID="btn_register" CssClass="formbtn" runat="server" Text="Register" OnClick="btn_register_Click"/>
    </div>
        </div>
</asp:Content>