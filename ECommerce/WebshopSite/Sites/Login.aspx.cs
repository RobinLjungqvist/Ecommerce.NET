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
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (Session["User"] != null)
            {
                var username = txtbox_username.Text;
                var password = txtbox_password.Text;
                var bll = new BLLUser();
                var user = new User();
                var users = new List<User>();

                user.UserName = username;
                user.Password = password;

                users = bll.SearchUser(user);

                if (users.Count == 1)
                {
                    Session["User"] = users[0];
                }
                else
                {
                    txtbox_username.Text = string.Empty;
                    txtbox_password.Text = string.Empty;
                    lbl_loginerror.Visible = true;
                }

            }
            else
            {
                //Response.Redirect("~/MyAccount.aspx");
            }
        }
	}
}