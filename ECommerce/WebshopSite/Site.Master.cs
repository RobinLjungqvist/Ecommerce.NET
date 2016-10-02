using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using BLL.Models;

namespace WebshopSite
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var cart = (List<OrderProduct>)Session["Cart"];
            decimal totalcartsum = 0;
            foreach (var item in cart)
            {
                totalcartsum += item.Price;
            }

            shoppingcart.InnerHtml = $"<a href=\"cart.html\">Cart -<span class=\"cart-amunt\">{totalcartsum}</span><i class=\"fa fa-shopping-cart\"></i> <span class=\"product-count\">{cart.Count}kr</span></a>";
        }
    }
}