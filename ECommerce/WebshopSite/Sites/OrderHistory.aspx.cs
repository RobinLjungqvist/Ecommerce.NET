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
            var order = new Order();
            var user = (User)Session["User"];
            order.CustomerID = user.UserID;
            var orders = bll.SearchOrder(order);
            var html = HtmlGenerator.GetOrderHtml(orders);
            orderhistorycontent.InnerHtml = html;
            

        }
        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session.Remove("User");
            Response.Redirect("~/Sites/Home.aspx");
        }
    }
}