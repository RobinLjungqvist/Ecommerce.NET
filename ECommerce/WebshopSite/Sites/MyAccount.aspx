<%@ Page Title="My Account" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="MyAccount.aspx.cs" Inherits="WebshopSite.Sites.MyAccount" %>

<asp:Content ID="accountaside" ContentPlaceHolderID="AsideContent" runat="server">
    <div id="CategoryContainer" class="col-md-2">
        <ul>
            <h2 id=categoryheader>Navigation</h2>
            <li><a href="MyAccount.aspx">Details</a></li>
            <li><a href="OrderHistory.aspx">Order History</a></li>
            <li><asp:LinkButton ID="btn_logout" runat="server" OnClick="btn_logout_Click">Logout</asp:LinkButton></li>
        </ul>
    </div>
</asp:Content>

<asp:Content ID="AccountContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="main" class="col-md-10">
                <h1 id="header">Customer Details</h1>
        <div class="formcol">
            <asp:Label ID="lbl_errormsg" runat="server" ForeColor="Red"></asp:Label>
        </div>
        <div class="formcol">
            <asp:Label ID="lbl_username" runat="server" AssociatedControlID="txtbox_username" Text="Username:" CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_username" runat="server" placeholder="Username" CssClass="text_box"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_username" runat="server" ControlToValidate="txtbox_username" ErrorMessage="* You must enter a username." ForeColor="Red" validationgroup="information"></asp:RequiredFieldValidator>
        </div>
        <div class="formcol">

            <asp:Label ID="lbl_firstname" runat="server" Text="First name:" AssociatedControlID="txtbox_firstname" CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_firstname" runat="server" placeholder="John..." CssClass="text_box"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_firstname" runat="server" ControlToValidate="txtbox_firstname" ErrorMessage="* You must enter a firstname" ForeColor="Red" validationgroup="information"></asp:RequiredFieldValidator>
        </div>
        <div class="formcol">
            <asp:Label ID="lbl_lastname" runat="server" Text="Last name:" AssociatedControlID="txtbox_lastname" CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_lastname" runat="server" placeholder="Doe..." CssClass="text_box"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_lastname" runat="server" ControlToValidate="txtbox_lastname" ErrorMessage="* You must enter a lastname" ForeColor="Red" validationgroup="information"></asp:RequiredFieldValidator>
        </div>
        <div class="formcol">
            <asp:Label ID="lbl_email" runat="server" Text="Email:" AssociatedControlID="txtbox_email" CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_email" runat="server" placeholder="name@email.com..." CssClass="text_box"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_email" runat="server" ControlToValidate="txtbox_email" ErrorMessage="* You must enter a email adress." ForeColor="Red" Display="Dynamic" validationgroup="information"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="regval_email" runat="server" ControlToValidate="txtbox_email" ErrorMessage="* You must enter a valid E-mail address." ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"></asp:RegularExpressionValidator>
       </div>
        <div class="formcol">
            <asp:Label ID="lbl_streetadress" runat="server" Text="Street Adress: " AssociatedControlID="txtbox_streetadress" CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_streetadress" runat="server" placeholder="High street 43..." CssClass="text_box"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_adress" runat="server" ControlToValidate="txtbox_streetadress" ErrorMessage="* You must enter a street adress" ForeColor="Red" validationgroup="information"></asp:RequiredFieldValidator>
         </div>
        <div class="formcol">
            <asp:Label ID="lbl_zipcode" runat="server" Text="Zipcode:" AssociatedControlID="txtbox_zipcode" CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_zipcode" runat="server" placeholder="33233" CssClass="text_box"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_zipcode" runat="server" ControlToValidate="txtbox_zipcode" ErrorMessage="* You must enter a zipcode" ForeColor="Red" Display="Dynamic" validationgroup="information"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="regexpval_zip" runat="server" ControlToValidate="txtbox_zipcode" Display="Dynamic" ErrorMessage="* You must enter a zipcode." ForeColor="Red" ValidationExpression="^\d{5,5}"></asp:RegularExpressionValidator>
         </div>
        <div class="formcol">
            <asp:Label ID="lbl_city" runat="server" Text="City:" AssociatedControlID="txtbox_city" CssClass="reg_lbl"></asp:Label>
            <asp:TextBox ID="txtbox_city" runat="server" CssClass="text_box"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqfield_city" runat="server" ControlToValidate="txtbox_city" ErrorMessage="* You must enter a city" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="formcol">
                    <asp:Button ID="btn_saveChanges" CssClass="formbtn" runat="server" Text="Save Changes" validationgroup="information" OnClick="btn_savechanges_Click" />
        <asp:Label ID="lbl_infoUpdateResult" runat="server"></asp:Label>
            </div>
        <br />
                <div>
        <div class="formcol">

                   <h2> Change Password</h2>
                        <asp:Label ID="lbl_password" runat="server" Text="New password:" AssociatedControlID="txtbox_password" CssClass="reg_lbl"></asp:Label>
                        <asp:TextBox ID="txtbox_password" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>
                        <asp:Label ID="lbl_pwreenter" runat="server" AssociatedControlID="txtbox_pwreenter" Text="Re-Enter: " CssClass="reg_lbl"></asp:Label>
                        <asp:TextBox ID="txtbox_pwreenter" runat="server" TextMode="Password" placeholder="Re-enter password" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqfield_password" runat="server" ControlToValidate="txtbox_password" ErrorMessage="* You must enter a new password." ForeColor="Red" Display="Dynamic" ValidationGroup="password"></asp:RequiredFieldValidator>
                        <asp:RequiredFieldValidator ID="reqfield_pwreenter" runat="server" ControlToValidate="txtbox_password" ErrorMessage="* You must re-enter password." ForeColor="Red" Display="Dynamic" ValidationGroup="password" ></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="compareval_password" runat="server" ControlToCompare="txtbox_password" ControlToValidate="txtbox_pwreenter" ErrorMessage="* Passwords doesn't match." ForeColor="Red" Display="Dynamic"></asp:CompareValidator>
        </div>
        <div class="formcol">
                    <asp:Button ID="btn_savepwchanges" runat="server" Text="Save Changes" validationgroup="password" OnClick="btn_savepwchanges_Click" />
                    <asp:Label id="lbl_pwupdateresult" runat="server"></asp:Label>
        </div>

    </div>
</asp:Content>