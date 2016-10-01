<%@ Page Title="Products Display" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebshopSite.Sites.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<link href="../Style/Stylesheet.css" rel="stylesheet" />

 <div class="row">
        <div class="col-md-8" id="ProductContainer" runat="server">
             <div class="half left cf">
    <input type="text" id="input-name" placeholder="Name">
    <input type="email" id="input-email" placeholder="Email address">
    <input type="text" id="input-subject" placeholder="Subject">
  </div>
  <div class="half right cf">
    <textarea name="message" type="text" id="input-message" placeholder="Message"></textarea>
  </div>  
  <input type="submit" value="Submit" id="input-submit">
        </div>
</div>
</asp:Content>