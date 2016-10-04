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
    public partial class receipt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region fillsidebar
            var bllcategory = new BLLCategory();
            var categories = bllcategory.ReturnAllCategories();
            CategoryContainer.InnerHtml = HtmlGenerator.GetCategorySidebarHtml(categories);
            #endregion


            var order = (Order)Session["Order"];
            if (order != null)
            {
                if (Session["User"] != null)
                {
                    var user = (User)Session["User"];
                    txtbox_name.Text =  $"{user.FirstName} {user.LastName}";
                    txtbox_email.Text = $"{user.StreetAdress}";
                    txtbox_adress.Text = $"{user.StreetAdress}";
                    txtbox_city.Text = $"{user.City}";
                    txtbox_zipcode.Text = $"{user.ZipCode}";

                    OrderDetails.InnerHtml = HtmlGenerator.OrderSummaryHtml(order);
                    OrderDetails.Visible = true;
                    Session["Cart"] = new List<OrderProduct>();
                    Session["Order"] = new Order();
                }
                else
                {
                    var login = "<a ID =\"login\" runat =\"server\" href=\"Login.aspx\">login</a>";
                    var register = "<a ID =\"register\" runat =\"server\" href=\"Registration.aspx\">register</a>";
                    orderinfo.InnerHtml += $"<h4>Please {login} or {register} in to place an order.</h4><br />";
                    
                }
            }
            else
            {
                orderinfo.InnerHtml = "<h4>No order to process.</h4><br />";
            }
        }

        protected void btn_keepshopping_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductsDisplay.aspx");
        }
    }
}