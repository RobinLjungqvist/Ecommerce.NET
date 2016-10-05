<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebshopSite.About" %>
<asp:Content ID="aboutinformation" ContentPlaceHolderID="AsideContent" runat="server">
    <div id="CategoryContainer" class="col-md-2" runat="server">
       
    </div>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <p>This is a school project in a .NET framework course.</p>

</asp:Content>
