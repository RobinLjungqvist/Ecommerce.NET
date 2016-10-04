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



            var cart = (List<OrderProduct>)Session["Cart"];
            if (cart.Count < 1)
            {
                orderinfo.InnerHtml = "<h3>No products in the cart.</h3><br />";
            }
            else
            {
                OrderDetails.Visible = true;
                var order = CreateOrder();
                orderproducts.InnerHtml = HtmlGenerator.OrderSummaryHtml(order);
            }


            if (Session["User"] == null)
            {
                var login = "<a ID =\"login\" runat =\"server\" href=\"Login.aspx\">login</a>";
                var register= "<a ID =\"register\" runat =\"server\" href=\"Registration.aspx\">register</a>";
                orderinfo.InnerHtml += $"<h4>Please {login} or {register} in to check out your order.</h4><br />";
            }
            else
            {
                var user = (User)Session["User"];
                name.Text = $"Name: {user.FirstName} {user.LastName}";
                adress.Text = $"Adress: {user.StreetAdress}";
                zipandcity.Text = $"{user.City} {user.ZipCode}";
            }
        }

        private Order CreateOrder()
        {
            var order = new Order();
            var user = (User)Session["User"];
            order.CustomerID = user.UserID;
            order.Orderdate = DateTime.Now;
            order.DeliveryAdress = user.StreetAdress;
            order.Zipcode = (int)user.ZipCode;
            order.City = user.City;
            order.Products = (List<OrderProduct>)Session["Cart"];

            return order;

        }
    }
}