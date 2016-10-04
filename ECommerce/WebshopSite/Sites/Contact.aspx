<%@ Page Title="Products Display" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebshopSite.Sites.Contact" %>

<asp:Content ID="contactinformation" ContentPlaceHolderID="AsideContent" runat="server">
    <div id="CategoryContainer" class="col-md-2">
       
    </div>
</asp:Content>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<link href="../Style/Stylesheet.css" rel="stylesheet" />

<div class="wrappercontact col-md-4">
        <table  id="tblcontact"> 
            <tr id="Contactform"><td>Contact Form <br /><br /></td></tr>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Name *"></asp:Label><br />
        </td>
        <td>
            <asp:TextBox ID="txtName" runat="server" ValidationGroup = "contact" OnTextChanged="btnSend_Click"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required field for Name"
             ControlToValidate = "txtName"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Subject *"></asp:Label><br />
        </td>
        <td>
            <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required field for Name"
             ControlToValidate = "txtSubject"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label3" runat="server" Text="Email *"></asp:Label><br />
        </td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Required field for E-mail"
            ControlToValidate = "txtEmail"></asp:RequiredFieldValidator>
            <br />
            <asp:RegularExpressionValidator id="valRegEx" runat="server"
            ControlToValidate="txtEmail"
            ValidationExpression=".*@.*\..*"
            ErrorMessage="Invalid Email address."></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label4" runat="server" Text="Message *"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtBody" runat="server" TextMode = "MultiLine" ></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Required field for Message"
            ControlToValidate = "txtBody"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btnSend" runat="server" Text="Send" OnClick="btnSend_Click" />
       </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMessage" runat="server" Text="Message sent" ForeColor = "Green"></asp:Label>
       </td>
    </tr>
</table> 
</div>

     <div class="wrappercontact col-md-4">
         <div id="tousmsg">
         <asp:Label ID="showmsg" runat="server"  ></asp:Label>
         </div>
    </div>

</asp:Content>