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
        protected void Page_Init(object sender, EventArgs e)
        {

            
        }
        protected void Page_Load(object sender, EventArgs e)
        {       

                var cart = (List<OrderProduct>)Session["Cart"];
                decimal totalcartsum = 0;
                foreach (var item in cart)
                {
                    totalcartsum += item.Price;
                }

                shoppingcart.InnerHtml = $"<a href=\"Cart.aspx\">Cart <span class=\"cart-amunt\">{totalcartsum}kr</span><i class=\"fa fa-shopping-cart\"></i> <span class=\"product-count\">{cart.Count}</span></a>";
            
            if(Session["User"] == null)
            {
                topnavlogin.Visible = true;
            }
            else
            {
                topnavlogout.Visible = true;
            }

        }

        protected void topnavlogout_Click(object sender, EventArgs e)
        {
            Session["User"] = null;
            Response.Redirect("Home.aspx");
        }
    }
}