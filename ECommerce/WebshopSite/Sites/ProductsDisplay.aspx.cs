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

    public partial class ProductsDisplay : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            var productToDisplay = new Product();
            var bll = new BLLProduct();
            var productList = new List<Product>();
            int addToCartID = 0;
            string category = "";
            NameValueCollection qscoll = HttpUtility.ParseQueryString(Page.ClientQueryString);

            #region URLChecksAndHandling
            if (string.IsNullOrEmpty(Request.QueryString["Category"]))
            {
                productList = bll.GetNewestProducts();
                category = "nyheter";

            }
            else if (qscoll.Get("Category").ToLower() == "nyheter" || qscoll == null)
            {
                productList = bll.GetNewestProducts();
                category = qscoll.Get("Category");
            }
            else
            {
                productToDisplay.category = qscoll.Get("Category");
                productList = bll.SearchProduct(productToDisplay);
                category = qscoll.Get("Category");
            }

            if (!string.IsNullOrEmpty(Request.QueryString["AddToCart"]))
            {
                addToCartID = Convert.ToInt32(qscoll.Get("AddToCart"));
            }
            if (!string.IsNullOrEmpty(Request.QueryString["AddToCart"]))
            {
                var cart = (List<OrderProduct>)Session["Cart"];
                var anotherprod = new OrderProduct();
                anotherprod.ProductID = addToCartID;
                var anotherprodagian = new Product();
                anotherprodagian.productID = anotherprod.ProductID;
                var anotherprodlist = bll.SearchProduct(anotherprodagian);
                foreach (var item in anotherprodlist)
                {

                    anotherprod.Price = Convert.ToInt32(item.ppu);
                    anotherprod.ProductName = item.name;
                    anotherprod.Quantity++;
                    cart.Add(anotherprod);
                }
            }
            #endregion

            #region DynamicHtmlGeneration

            var html = HtmlGenerator.GetProductsHtml(productList, category);
            ProductContainer.InnerHtml = html;

            var bllCategory = new BLLCategory();
            var prodlist = bllCategory.ReturnAllCategories();
            AsideContainer.InnerHtml = HtmlGenerator.GetCategorySidebarHtml(prodlist);
#endregion
        }
    }
}