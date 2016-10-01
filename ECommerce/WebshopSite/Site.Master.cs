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
        protected void Page_Load(object sender, EventArgs e)
        {
            var categorybll = new BLLCategory();
            var categorylist = categorybll.ReturnAllCategories();
            string html = "";

            html += $"<div class=\"aside - nav\">" +
                   "<ul>";
            foreach (var item in categorylist)
            {
                html += $"<li><a href = \"\">{item.ToUpper()} </a ></li>";
            }
            html += "</ul>";
            CategoryContainer.InnerHtml = html;
        }
    }
}