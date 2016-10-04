<%@ Page Title="Receipt" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="receipt.aspx.cs" Inherits="WebshopSite.Sites.receipt" %>

<asp:Content ID="contactinformation" ContentPlaceHolderID="AsideContent" runat="server">
    <div id="CategoryContainer" class="col-md-2" runat="server">
       
    </div>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<link href="../Style/Stylesheet.css" rel="stylesheet" />

    <div id="CheckoutContent" class="col-md-10" runat="server">
        <h2><%: Title %></h2>
        <div id="orderinfo" runat="server">
            <h4>Customer details</h4>
             <asp:Label id="name" runat="server"></asp:Label><br />
                <asp:Label id="adress" runat="server"></asp:Label><br />
                 <asp:Label id="zipandcity" runat="server"></asp:Label><br />
            <h4>Products</h4>

            <div id="orderproducts" runat="server"></div>
        </div>

        <div id="OrderDetails" runat="server" visible="false">
             <div class="formcol">
               

                 
             </div>
        </div>

    </div>
</asp:Content>
