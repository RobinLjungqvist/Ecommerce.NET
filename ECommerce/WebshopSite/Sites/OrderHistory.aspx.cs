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
            sb.Append("<div class=\"\">" +
                      "<table style=\"width:70%\" class=\"shop_table cart\">");
              

            foreach (var order in orders)
            {
                var htmlOrder =
                      "<tr class=\"orderhead\"> " +
                      "<td>OrderID</td>" +
                      "<td>Order Date</td>" +
                      "<td>Total Price</td>" +
                      "<td>Show Products</td>" +
                      "</tr>" +
                "<tr >" +
                   $"<td> {order.OrderID}</td><td> {order.Orderdate}</td><td> {Convert.ToDecimal(order.TotalPrice)} kr</td><td> <a hred=\"\" onclick=\"ShowProducts('{order.OrderID}'); return false\">Show</button> </td>" +
                    "</tr>";



                sb.Append(htmlOrder);
                sb.Append("<tr id=\"prodhead\" class=\"prodhead\" style=\"display:none\"><td>Product ID</td><td>Product name</td><td>Quantity ID</td><td>Unit Price</td></tr>");
                foreach (var product in order.Products)
                {
                    var htmlProduct =
                        $"<tr id=\"prodid{order.OrderID}\" class=\"productrow\" style=\"display:none\">" +
                       $"<td>{product.ProductID}</td><td><a href=\"SingleProductDisplay.aspx?ProductID={product.ProductID}\">{product.ProductName}</a></td><td> {product.Quantity}</td><td> {Convert.ToDecimal(product.Price)} kr </td>" +
                        "</tr>";
                    sb.Append(htmlProduct);
                }
            }
            sb.Append("</table></div>");
            return sb.ToString();
        }
        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session.Remove("User");
            Response.Redirect("~/Sites/Home.aspx");
        }
    }
}