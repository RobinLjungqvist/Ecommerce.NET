﻿<%@ Page Title="My Account" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="MyAccount.aspx.cs" Inherits="WebshopSite.Sites.MyAccount" %>

<asp:Content ID="accountaside" ContentPlaceHolderID="AsideContent" runat="server">
    <div id="MyAccountNav" class="col-md-2">
        <ul>
            <li>Customer Details</li>
            <li>Order History</li>
        </ul>
    </div>
</asp:Content>

<asp:Content ID="AccountContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="main" class="col-md-10">
                <h1 id="header">Customer Details</h1>
        <p>
            <asp:Label ID="lbl_errormsg" runat="server" ForeColor="Red"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lbl_username" runat="server" AssociatedControlID="txtbox_username" Text="Username:" CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_username" runat="server" placeholder="Username"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_username" runat="server" ControlToValidate="txtbox_username" ErrorMessage="* You must enter a username." ForeColor="Red" validationgroup="information"></asp:RequiredFieldValidator>
        <br />
            <asp:Label ID="lbl_firstname" runat="server" Text="First name:" AssociatedControlID="txtbox_firstname" CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_firstname" runat="server" placeholder="John..."></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_firstname" runat="server" ControlToValidate="txtbox_firstname" ErrorMessage="* You must enter a firstname" ForeColor="Red" validationgroup="information"></asp:RequiredFieldValidator>
        <br />
            <asp:Label ID="lbl_lastname" runat="server" Text="Last name:" AssociatedControlID="txtbox_lastname" CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_lastname" runat="server" placeholder="Doe..."></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_lastname" runat="server" ControlToValidate="txtbox_lastname" ErrorMessage="* You must enter a lastname" ForeColor="Red" validationgroup="information"></asp:RequiredFieldValidator>
        <br />
            <asp:Label ID="lbl_email" runat="server" Text="Email:" AssociatedControlID="txtbox_email" CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_email" runat="server" placeholder="name@email.com..."></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_email" runat="server" ControlToValidate="txtbox_email" ErrorMessage="* You must enter a email adress." ForeColor="Red" Display="Dynamic" validationgroup="information"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="regval_email" runat="server" ControlToValidate="txtbox_email" ErrorMessage="* You must enter a valid E-mail address." ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"></asp:RegularExpressionValidator>
        <br />
            <asp:Label ID="lbl_streetadress" runat="server" Text="Street Adress" AssociatedControlID="txtbox_streetadress" CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_streetadress" runat="server" placeholder="High street 43..."></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_adress" runat="server" ControlToValidate="txtbox_streetadress" ErrorMessage="* You must enter a street adress" ForeColor="Red" validationgroup="information"></asp:RequiredFieldValidator>
         <br/>
            <asp:Label ID="lbl_zipcode" runat="server" Text="Zipcode:" AssociatedControlID="txtbox_zipcode" CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_zipcode" runat="server" placeholder="33233"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_zipcode" runat="server" ControlToValidate="txtbox_zipcode" ErrorMessage="* You must enter a zipcode" ForeColor="Red" Display="Dynamic" validationgroup="information"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="regexpval_zip" runat="server" ControlToValidate="txtbox_zipcode" Display="Dynamic" ErrorMessage="* You must enter a zipcode." ForeColor="Red" ValidationExpression="^\d{5,5}"></asp:RegularExpressionValidator>
         <br/>
            <asp:Label ID="lbl_city" runat="server" Text="City:" AssociatedControlID="txtbox_city" CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_city" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_city" runat="server" ControlToValidate="txtbox_city" ErrorMessage="* You must enter a city" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
                    <asp:Button ID="btn_saveChanges" runat="server" Text="Save Changes" validationgroup="information" OnClick="btn_savechanges_Click" />

        <br />
                <p>
                    Change Password<br />
                        <asp:Label ID="lbl_password" runat="server" Text="New password:" AssociatedControlID="txtbox_password" CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_password" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>
            <asp:Label ID="lbl_pwreenter" runat="server" AssociatedControlID="txtbox_pwreenter" Text="Re-Enter Password: " CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_pwreenter" runat="server" TextMode="Password" placeholder="Re-enter password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_password" runat="server" ControlToValidate="txtbox_password" ErrorMessage="* You must enter a new password." ForeColor="Red" Display="Dynamic" ValidationGroup="password"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="reqfield_pwreenter" runat="server" ControlToValidate="txtbox_password" ErrorMessage="* You must re-enter password." ForeColor="Red" Display="Dynamic" ValidationGroup="password" ></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="compareval_password" runat="server" ControlToCompare="txtbox_password" ControlToValidate="txtbox_pwreenter" ErrorMessage="* Passwords doesn't match." ForeColor="Red" Display="Dynamic"></asp:CompareValidator>
        <br />
                    <asp:Button ID="btn_savepwchanges" runat="server" Text="Save Changes" validationgroup="password" OnClick="btn_savepwchanges_Click" />
        </p>

    </div>
</asp:Content>