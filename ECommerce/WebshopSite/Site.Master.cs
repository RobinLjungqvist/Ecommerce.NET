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
                decimal totalCartsum = 0;
                int itemCount = 0;
                foreach (var item in cart)
                {
                    itemCount += item.Quantity;
                    totalCartsum += (item.Price * item.Quantity);
                }

            shoppingcart.InnerHtml = $"<a href=\"Cart.aspx\">Cart <span class=\"cart-amunt\">{totalCartsum}kr</span><i class=\"fa fa-shopping-cart\"></i> <span class=\"product-count\">{itemCount}</span></a>";
            
        }
    }
}