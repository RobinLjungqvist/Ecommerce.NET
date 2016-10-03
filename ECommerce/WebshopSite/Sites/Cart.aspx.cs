using BLL;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;

namespace WebshopSite.Sites
{
    public partial class Cart : System.Web.UI.Page
    {
        void UpdateCart_Click()
        {
            string input = "2";
            var orderProds = (List<OrderProduct>)Session["Cart"];

            for (int i = 0; i < orderProds.Count; i++)
            {
                orderProds[i].Quantity = Convert.ToInt32(input + i);
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            int loopcount = 0;
            string html = "";
            var bllproduct = new BLLProduct();
            var orderProds = (List<OrderProduct>)Session["Cart"];
            List<Product> products = new List<Product>();
            foreach (var item in orderProds)
            {
                Product product = new Product();
                product.productID = item.ProductID;
                var templist = bllproduct.SearchProduct(product);
                foreach (var x in templist)
                {
                    products.Add(x);
                }
            }


            foreach (var item in orderProds)
            {
                html += $"<tbody>" +
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
                                                    $"<input type=\"number\" size=\"4\" class=\"input-text qty text\" id=\"{"input"+loopcount}\" runat=\"server\" title=\"Qty\" value=\"{item.Quantity}\" min=\"0\" step=\"1\">" +
                                                $"</div>" +
                                            $"</td>" +
                                            $"<td class=\"product-subtotal\">" +
                                                $"<span class=\"amount\">{item.Price * item.Quantity}</span>" +
                                            $"</td>" +
                                    $"</tbody>";
                loopcount++;
            }
            CartContainer.InnerHtml = html;
        }
    }
}