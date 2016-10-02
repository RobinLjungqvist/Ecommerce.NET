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
            var cart = (Dictionary<int, int>)Session["Cart"];
            int totalcartsum = 0;
            foreach (var item in cart)
            {
                totalcartsum += item.Value;
            }

            shoppingcart.InnerHtml = $"<a href=\"cart.html\">Cart -<span class=\"cart-amunt\">{totalcartsum}</span><i class=\"fa fa-shopping-cart\"></i> <span class=\"product-count\">{cart.Count}</span></a>";
        }
    }
}