<%@ Page Title="Products Display" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="WebshopSite.Sites.Cart" %>
<asp:Content ID="cartnavcontent" ContentPlaceHolderID="AsideContent" runat="server">
    <div id="cartnav" runat="server"></div>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<link href="../Style/Stylesheet.css" rel="stylesheet" />

    <div class="col-md-8">
                    <div class="product-content-right">
                        <div class="woocommerce">
                                <table class="shop_table cart">
                                    <thead>
                                        <tr>
                                            <th class="product-remove">&nbsp;</th>
                                            <th class="product-thumbnail">&nbsp;</th>
                                            <th class="product-name">Product</th>
                                            <th class="product-price">Price</th>
                                            <th class="product-quantity">Quantity</th>
                                            <th class="product-subtotal">Total</th>
                                        </tr>
                                    </thead>
                                   <tbody id="CartContainer" runat="server"></tbody>
                                         <tr>
                                            <td class="actions" colspan="6">
                                                <input type="submit" value="Update Cart" name="update_cart" class="button" style="float:left;">
                                                <input type="submit" value="Proceed to Checkout" name="proceed" class="checkout-button button alt wc-forward" style="float:right;"/>
                                            </td>
                                        </tr>
                                </table>
                            </div>
                        </div>
        </div>
    

</asp:Content>
