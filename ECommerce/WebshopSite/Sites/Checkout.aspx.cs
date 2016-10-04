using BLL;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebshopSite.Sites
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region fillsidebar
            var bllcategory = new BLLCategory();
            var categories = bllcategory.ReturnAllCategories();
            CategoryContainer.InnerHtml = HtmlGenerator.GetCategorySidebarHtml(categories);
            #endregion
            if(Session["User"] != null)
            {
                var cart = (List<OrderProduct>)Session["Cart"];
                if(cart.Count <= 0)
                {
                    info.InnerHtml = "<h4> No products in cart. </h4>";
                }
                else
                {
                    checkout.Visible = true;
                }
            }
            else
            {
                var login = "<a ID =\"login\" runat =\"server\" href=\"Login.aspx\">login</a>";
                var register = "<a ID =\"register\" runat =\"server\" href=\"Registration.aspx\">register</a>";
                info.InnerHtml += $"<h4>Please {login} or {register} in to place an order.</h4><br />";
            }
        }

        private Order CreateOrder(List<OrderProduct> cart, User user)
        {
            var order = new Order();
            order.CustomerID = user.UserID;
            order.Orderdate = DateTime.Now;
            order.DeliveryAdress = user.StreetAdress;
            order.Zipcode = (int)user.ZipCode;
            order.City = user.City;
            order.Products = cart;
            order.CalculateTotalPrice();

            return order;

        }

        protected void btn_checkout_Click(object sender, EventArgs e)
        {
            var cart = (List<OrderProduct>)Session["Cart"];
            var user = (User)Session["User"];
            if (cart.Count > 0 && (User)Session["User"] != null)
            {
                var order = CreateOrder(cart,user);
                var bllOrder = new BLLOrder();
                bllOrder.AddOrder(order);
                Session["Order"] = order;
                Response.Redirect("receipt.aspx");
            }
        }
    }
}