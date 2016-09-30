<%@ Page Title="Products Display" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="ProductsDisplay.aspx.cs" Inherits="WebshopSite.Sites.ProductsDisplay" %>
<asp:Content ID="AsideContent" ContentPlaceHolderID="AsidePlaceHolder" runat="server">
<link href="../Style/Stylesheet.css" rel="stylesheet" />
 <div class="row">
        <div class="col-md-3" id="ost" runat="server">
        
        </div>
</div>
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<link href="../Style/Stylesheet.css" rel="stylesheet" />

 <div class="row">
        <div class="col-md-8" id="ProductContainer" runat="server">
           
        </div>
</div>
</asp:Content>