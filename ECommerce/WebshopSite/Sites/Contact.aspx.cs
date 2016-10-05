using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebshopSite.Sites
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
            var bllcategory = new BLLCategory();
            var categories = bllcategory.ReturnAllCategories();
            CategoryContainer.InnerHtml = HtmlGenerator.GetCategorySidebarHtml(categories);
            
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = true;

            showmsg.Text = $"<h3>Hi {txtName.Text}! </h3>We are doing our best to answer your inquiry as soon as possible, but within 48 hours. <hr/>" + $"<p> <b>Subject:</b> {txtSubject.Text} </p> <p> <b>E-mail:</b> {txtEmail.Text}</p> <p><b>Message:</b> {txtBody.Text}</p>";
             
             
        }
    }
}