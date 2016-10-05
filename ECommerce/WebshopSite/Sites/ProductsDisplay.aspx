<%@ Page Title="Products Display" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="ProductsDisplay.aspx.cs" Inherits="WebshopSite.Sites.ProductsDisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="AsideContent" runat="server">



        <div class="col-md-2" id="AsideContainer" runat="server">
           

</div>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="searchbox" class="col-md-10" runat="server">
        <asp:DropDownList ID="ddl_category" CssClass="dropdown" runat="server"> </asp:DropDownList>
        <asp:DropDownList ID="ddl_brand" CssClass="dropdown" runat="server"></asp:DropDownList>
        <asp:DropDownList ID="ddl_color" CssClass="dropdown" runat="server"></asp:DropDownList>
        <asp:DropDownList ID="ddl_size" CssClass="dropdown" runat="server"></asp:DropDownList>
        <asp:Button ID="btn_search"  runat="server" Text="Search" OnClick="btn_search_Click" />
    </div>


        <div class="col-md-10" id="ProductContainer" runat="server">
           

</div>
</asp:Content>
