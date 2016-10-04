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
                    name.Text = $"Name: {user.FirstName} {user.LastName}";
                    adress.Text = $"Delivery Adress: {user.StreetAdress}";
                    zipandcity.Text = $"{user.City} {user.ZipCode}";

                    OrderDetails.InnerHtml = HtmlGenerator.OrderSummaryHtml(order);
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
    }
}