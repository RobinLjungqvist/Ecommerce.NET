<%@ Page Title="Order History" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="OrderHistory.aspx.cs" Inherits="WebshopSite.Sites.OrderHistory" %>
<asp:Content ID="orderhistoryaside" ContentPlaceHolderID="AsideContent" runat="server">
    <div id="MyAccountNav" class="col-md-2">
        <ul>
            <li><a href="~/Sites/MyAccount.aspx">Details</a></li>
            <li><a href="~/Sites/OrderHistory.aspx">Order History</a></li>
            <li><asp:LinkButton ID="btn_logout" runat="server" OnClick="btn_logout_Click">Logout</asp:LinkButton></li>
        </ul>
    </div>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
</asp:Content>
