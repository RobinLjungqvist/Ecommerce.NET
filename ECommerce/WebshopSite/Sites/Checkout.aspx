<%@ Page Title="Checkout" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="WebshopSite.Sites.Checkout" %>
<asp:Content ID="contactinformation" ContentPlaceHolderID="AsideContent" runat="server">
    <div id="CategoryContainer" class="col-md-2" runat="server">
       
    </div>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="CheckoutContent" class="col-md-10" runat="server">
        <h2><%: Title %></h2>
        <div id="orderinfo" runat="server">
            <h2>Customer details</h2>
             <asp:Label id="name" runat="server"></asp:Label><br />
                <asp:Label id="adress" runat="server"></asp:Label><br />
                 <asp:Label id="zipandcity" runat="server"></asp:Label><br />
            <div id="orderproducts" runat="server"></div>
        </div>

        <div id="OrderDetails" runat="server" visible="false">
             <div class="formcol">
               

                 
             </div>
        </div>

    </div>
</asp:Content>
