<%@ Page Title="Products Display" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="WebshopSite.Sites.Cart" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<link href="../Style/Stylesheet.css" rel="stylesheet" />

    <div class="col-md-10 col-md-offset-2">
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
                                   <div class="col-md-10 col-md-offset-2" id="CartContainer" runat="server">
                                         <tr>
                                            <td class="actions" colspan="6">
                                                <div class="coupon">
                                                    <label for="coupon_code">Coupon:</label>
                                                    <input type="text" placeholder="Coupon code" value="" id="coupon_code" class="input-text" name="coupon_code">
                                                    <input type="submit" value="Apply Coupon" name="apply_coupon" class="button">
                                                </div>
                                                <input type="submit" value="Update Cart" name="update_cart" class="button">
                                                <input type="submit" value="Proceed to Checkout" name="proceed" class="checkout-button button alt wc-forward">
                                            </td>
                                        </tr>
                                </table>
</div>
</asp:Content>
