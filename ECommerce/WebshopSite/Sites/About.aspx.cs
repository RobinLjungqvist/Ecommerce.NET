using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebshopSite
{
    public partial class About : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            var bll = new BLLCategory();
            var categories = bll.ReturnAllCategories();
            CategoryContainer.InnerHtml = HtmlGenerator.GetCategorySidebarHtml(categories);
        }

    }
}