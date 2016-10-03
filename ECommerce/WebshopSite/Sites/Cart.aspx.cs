using BLL;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;

namespace WebshopSite.Sites
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string html = "";
            var bllproduct = new BLLProduct();
            var orderProds = (List<OrderProduct>)Session["Cart"];
            List<Product> products = new List<Product>();
            foreach (var item in orderProds)
            {
                Product product = new Product();
                product.productID = item.ProductID;
                var templist = bllproduct.SearchProduct(product);
                foreach (var x in templist)
                {
                    products.Add(x);
                }
            }

            var bllcategory = new BLLCategory();
            var categories = bllcategory.ReturnAllCategories();
            var sidebarhtml = HtmlGenerator.GetCategorySidebarHtml(categories);
            cartnav.InnerHtml = sidebarhtml;
            html = HtmlGenerator.GetOrderProducts(orderProds);

            CartContainer.InnerHtml = html;
        }
    }
}