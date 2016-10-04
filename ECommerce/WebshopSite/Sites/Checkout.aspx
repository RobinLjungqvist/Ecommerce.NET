<%@ Page Title="Checkout" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="WebshopSite.Sites.Checkout" %>
<asp:Content ID="contactinformation" ContentPlaceHolderID="AsideContent" runat="server">
    <div id="CategoryContainer" class="col-md-2" runat="server">
       
    </div>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div id="CheckoutContent" class="col-md-10" runat="server">
        <h2><%: Title %></h2>
        <div id="info" runat="server"></div>
        <div id="checkout" visible="true">
            <h4>Enter Credit Card information</h4>
            <div class="formcol">
                <asp:label ID="lbl_ccn" runat="server" CssClass="reg_lbl" AssociatedControlID="txtbox_ccn">Credit Card Nr:</asp:label>
                <asp:TextBox ID="txtbox_ccn" runat="server" CssClass="text_box"></asp:TextBox><asp:RequiredFieldValidator ID="reqfieldval" ControlToValidate="txtbox_ccn" Display="Dynamic" ErrorMessage="* You must Enter a credit card number." ForeColor="Red" runat="server" CssClass="validation" ></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="regexpval_zip" runat="server" ControlToValidate="txtbox_ccn" Display="Dynamic" ErrorMessage="* You must enter a valid 12 digit credit card number." ForeColor="Red" ValidationExpression="^\d{12,12}" CssClass="validation"></asp:RegularExpressionValidator>
            </div>
            <div class="formcol">
                <asp:label ID="lbl_sc" runat="server" CssClass="reg_lbl" AssociatedControlID="txtbox_ccv">CCV:</asp:label>
                <asp:TextBox ID="txtbox_ccv" runat="server" CssClass="text_box"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtbox_ccn" Display="Dynamic" ErrorMessage="* You must Enter a credit card number." ForeColor="Red" runat="server" CssClass="validation" ></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="regex_ccv" runat="server" ControlToValidate="txtbox_ccv" Display="Dynamic" ErrorMessage="* You must enter 3 digit CCV number from the back of your card." ForeColor="Red" ValidationExpression="^\d{3,3}" CssClass="validation"></asp:RegularExpressionValidator>
            </div>
            <div class="formcol">
            <asp:Button ID="btn_checkout" CssClass="formbtn" runat="server" Text="Submit" OnClick="btn_checkout_Click"/>

            </div>
        </div>
        
    </div>
</asp:Content>
