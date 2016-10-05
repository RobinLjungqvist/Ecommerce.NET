using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
namespace WebshopSite
{
    public static class HtmlGenerator
    {
        public static string GetOrderHtml(List<Order> orders)
        {
            var sb = new StringBuilder();
            sb.Append("<div class=\"\">" +
                      "<table style=\"width:70%\" class=\"shop_table cart\">" +
                      "<tr class=\"orderhead\"> " +
                      "<td>OrderID</td>" +
                      "<td>Order Date</td>" +
                      "<td>Total Price</td>" +
                      "<td>Show Products</td>" +
                      "</tr>");


            foreach (var order in orders)
            {
                var htmlOrder =
                $"<tr id=\"orderrow{order.OrderID}\" class=\"corderrow\">" +
                   $"<td> {order.OrderID}</td><td> {order.Orderdate}</td><td> {Convert.ToDecimal(order.TotalPrice)} kr</td><td> <a href=\"javascript:void(0);\" onclick=\"ShowProducts('{order.OrderID}'); return false\">Show</button> </td>" +
                    "</tr>";



                sb.Append(htmlOrder);

                foreach (var product in order.Products)
                {
                    var htmlProduct =
                        $"<tr id=\"prodheadid{order.OrderID}\" class=\"prodhead hiddentable\" style=\"display:none\"><td>Product ID</td><td>Product name</td><td>Quantity</td><td>Unit Price</td></tr>" +
                        $"<tr id=\"prodid{order.OrderID}\" class=\"productrow hiddentable show{order.OrderID}\" style=\"display:none\">" +
                       $"<td>{product.ProductID}</td><td><a href=\"SingleProductDisplay.aspx?ProductID={product.ProductID}\">{product.ProductName}</a></td><td> {product.Quantity}</td><td> {Convert.ToDecimal(product.Price)} kr </td>" +
                        "</tr>";
                    sb.Append(htmlProduct);
                }
            }
            sb.Append("</table></div>");
            return sb.ToString();
        }

        public static string OrderSummaryHtml(Order order)
        {
            var html = "<div class=\"woocommerce\"><table class=\"shop_table cart col-md-6\">" +
            "<tr>" +
                "<th class=\"product - name\">" +
                    "Product name"+
                "</th>"+
                "<th class=\"product-quantity\" >" +
                    "Quantity"+
                "</th>" +
                "<th class=\"product-price\">" +
                    "Price per Unit" +
                "</th>" +
            "</tr>";

            var products = order.Products;
            if (products != null) {
                foreach (var product in products)
                {
                    html += $"<tr class=\"cart_item\">" +
                       $"<td class=\"product-name\">{product.ProductName}</td> " +
                       $"<td class=\"product-quantity\">{product.Quantity}</td> " +
                       $"<td class=\"product-price\">{product.Price}</td> " +
                        "</tr>";
                }
            }

            html += "</table></div>";
            return html;
        }

        public static string GetCategorySidebarHtml(List<string> prodlist)
        {
            string html = $"<div class=\"col-md-2 offset-1\" id=\"CategoryContainer\" runat=\"server\">" +
                             $"<div class=\"aside - nav\">" +
                             $"<ul>" +
                             $"<h2 id=\"categoryheader\">Categories</h2>";
            foreach (var item in prodlist)
            {
                html += $"<li><a href=\"/Sites/ProductsDisplay.aspx?Category={item}\">{item.ToUpper()}</a></li>";
            }
            html += "</ul>" +
                                   "</div>" +
                                   "</div>";
            return html;

        }

        public static string GetProductsHtml(List<Product> prodlist, string category)
        {
            string html = "";

            foreach (var item in prodlist)
            {
                html += $"<div class=\"col-md-3 col-sm-6 productdisplay\">" +
                                            $"<div class=\"single-shop-product\">" +
                                            $"<div class=\"product-upper\">" +
                                            $"<img src = \"../Images/testimage.png\" alt=\"image\">" +
                                            $"</div>" +
                                            $"<h2><a href = \"SingleProductDisplay.aspx?ProductID={item.productID}\" > {item.name}</a></h2>" +
                                            $"<div class=\"product-carousel-price\">" +
                                            $"<ins>{Convert.ToInt32(item.ppu)}kr</ins>" +
                                            $"</div>" +

                                            $"<div class=\"product-option-shop\">" +
                                            $"<a class=\"add_to_cart_button\" data-quantity=\"1\" data-product_sku=\"\" data-product_id=\"70\" rel=\"nofollow\" href=\"ProductsDisplay.aspx?Category={category}&AddToCart={item.productID}\">Add to cart</a>" +
                                            $"</div>" +
                                            $"</div>" +
                                            $"</div>" +
                                            $"";

            }
            return html;
        }
        public static string GetOrderProducts(List<OrderProduct> orderProds)
        {
            string html = "";
            foreach (var item in orderProds)
            {
                html +=
                                        $"<tr class=\"cart_item\">" +
                                           $" <td class=\"product-remove\">" +
                                                $"<a title=\"Remove this item\" class=\"remove\" href=\"#\">×</a>" +
                                            $"</td>" +
                                            $"<td class=\"product-thumbnail\">" +
                                               $"<a href=\"single-product.html\"><img width=\"145\" height=\"145\" alt=\"poster_1_up\" class=\"shop_thumbnail\" src=\"../Images/testimage.png\" ></a>" +
                                            $"</td>" +
                                            $"<td class=\"product-name\">" +
                                                $"<a href=\"single-product.html\">{item.ProductName}</a>" +
                                            $"</td>" +
                                            $"<td class=\"product-price\">" +
                                                $"<span class=\"amount\">{item.Price}</span>" +
                                            $"</td>" +
                                            $"<td class=\"product-quantity\">" +
                                                $"<div class=\"quantity buttons_added\">" +
                                                    $"<input type=\"number\" size=\"4\" class=\"input-text qty text\" title=\"Qty\" value=\"{item.Quantity}\" min=\"0\" step=\"1\">" +
                                                $"</div>" +
                                            $"</td>" +
                                            $"<td class=\"product-subtotal\">" +
                                                $"<span class=\"amount\">{item.Price * item.Quantity}</span>";
            }
            return html;
        }
        public static string GetProductsHtmlbySearch(List<Product> productList)
        {
            var html = string.Empty;

            foreach (var item in productList)
            {
                html += $"<div class=\"col-md-3 col-sm-6 productdisplay\">" +
                                            $"<div class=\"single-shop-product\">" +
                                            $"<div class=\"product-upper\">" +
                                            $"<img src = \"../Images/testimage.png\" alt=\"image\">" +
                                            $"</div>" +
                                            $"<h2><a href = \"SingleProductDisplay.aspx?ProductID={item.productID}\" > {item.name}</a></h2>" +
                                            $"<div class=\"product-carousel-price\">" +
                                            $"<ins>{Convert.ToInt32(item.ppu)}kr</ins>" +
                                            $"</div>" +

                                            $"<div class=\"product-option-shop\">" +
                                            $"<a class=\"add_to_cart_button\" data-quantity=\"1\" data-product_sku=\"\" data-product_id=\"70\" rel=\"nofollow\" href=\"ProductsDisplay.aspx?Search=True&AddToCart={item.productID}\">Add to cart</a>" +
                                            $"</div>" +
                                            $"</div>" +
                                            $"</div>" +
                                            $"";

            }

            return html;
        }
    }
}