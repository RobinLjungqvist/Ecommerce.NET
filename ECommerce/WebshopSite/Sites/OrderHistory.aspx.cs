using BLL;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebshopSite.Sites
{
    public partial class OrderHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var bll = new BLLOrder();
            // customer id 9
            var order = new Order();
            order.CustomerID = 9;
            var orders = bll.SearchOrder(order);
            var html = GetOrderHtml(orders);
            orderhistorycontent.InnerHtml = html;

        }

        private string GetOrderHtml(List<Order> orders)
        {
            var sb = new StringBuilder();
            sb.Append("<div class=\"ordercontainer\">");

            sb.Append("</div>");

            foreach (var order in orders)
            {
                var htmlOrder =
                    "<div class=\"order\">" +
                   $"Order: {order.OrderID}, {order.Orderdate}, {order.TotalPrice} " +
                    "</div>";
                sb.Append(htmlOrder);
                foreach (var product in order.Products)
                {
                    var htmlProduct =
                        "<div class=\"product\">" +
                       $"Prod ID {product.ProductID}, <a href=\"SingleProductDisplay.aspx?ProductID={product.ProductID}\">{product.ProductName}</a> Quantity: {product.Quantity}, Product price {product.Price}" +
                        "</div>";
                    sb.Append(htmlProduct);
                }
            }
            sb.Append("</div>");
            return sb.ToString();
        }
        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session.Remove("User");
            Response.Redirect("~/Sites/Home.aspx");
        }
    }
}