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
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var bllcategory = new BLLCategory();
            var categories = bllcategory.ReturnAllCategories();
            MyAccountNav.InnerHtml = HtmlGenerator.GetCategorySidebarHtml(categories);
        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            var user = new User();
            var bll = new BLLUser();

            user.UserName = txtbox_username.Text;
            user.Password = txtbox_password.Text;
            user.FirstName = txtbox_firstname.Text;
            user.LastName = txtbox_lastname.Text;
            user.StreetAdress = txtbox_streetadress.Text;
            user.City = txtbox_city.Text;
            user.Email = txtbox_email.Text;
            user.IsAdmin = false;
            user.CustomerGroup = "Normal";
            user.ZipCode = Convert.ToInt32(txtbox_zipcode.Text);
            var result = InputValidationHelper.UserIsValid(user);
            if (result == string.Empty)
            {
                bll.AddUser(user);
                Response.Redirect("~/Sites/Login.aspx");
            }
            else
            {
                lbl_errormsg.Text = result;
            }



        }
        
    }
}