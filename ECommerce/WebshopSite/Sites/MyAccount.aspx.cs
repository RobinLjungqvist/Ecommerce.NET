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
    public partial class MyAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["User"] != null)
            {
                var user = (User)Session["User"];
                txtbox_username.Enabled = false;
                txtbox_username.Text = user.UserName;
                txtbox_firstname.Text = user.FirstName;
                txtbox_lastname.Text = user.LastName;
                txtbox_email.Text = user.Email;
                txtbox_streetadress.Text = user.StreetAdress;
                txtbox_city.Text = user.City;
                txtbox_zipcode.Text = user.ZipCode.ToString();
                

            }
            else
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void btn_savechanges_Click(object sender, EventArgs e)
        {
            var bll = new BLLUser();
            var user = (User)Session["User"];
            bll.UpdateUser(user);
        }
    }
}