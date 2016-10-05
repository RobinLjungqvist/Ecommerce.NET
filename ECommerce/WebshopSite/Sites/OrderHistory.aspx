<%@ Page Title="Order History" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="OrderHistory.aspx.cs" Inherits="WebshopSite.Sites.OrderHistory" %>

<asp:Content ID="orderhistoryaside" ContentPlaceHolderID="AsideContent" runat="server">
    <div id="CategoryContainer" class="col-md-2">
        <ul>
            <h2 id="categoryheader">Navigation</h2>
            <li><a href="MyAccount.aspx">Details</a></li>
            <li><a href="OrderHistory.aspx">Order History</a></li>
            <li><asp:LinkButton ID="btn_logout" runat="server" OnClick="btn_logout_Click">Logout</asp:LinkButton></li>
        </ul>
    </div>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1 id="header">Orders</h1>
        <script type="text/javascript">
            function ShowProducts(id) {
                elements = document.getElementsByClassName('hiddentable');
                for (var i = 0; i < elements.length; i++) {
                    elements[i].style.display = 'none';
                }

                orderrowcolor = document.getElementsByClassName('corderrow');
                for (var i = 0; i < orderrowcolor.length; i++) {
                    orderrowcolor[i].style.backgroundColor = '#d2dee2';
                }


                element2 = document.getElementById('prodheadid' + id);
                element2.style.display = 'table-row';

                showelements = document.getElementsByClassName('show' + id);
                for (var i = 0; i < showelements.length; i++) {
                    showelements[i].style.display = 'table-row';
                }
                orderrow = document.getElementById('orderrow' + id);
                orderrow.style.backgroundColor = '#00ebbd';
            }
            
        </script>
    <div id="orderhistorycontent" class="col-md-10" runat="server">

    </div>
</asp:Content>
