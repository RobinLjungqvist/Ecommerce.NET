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
            if (string.IsNullOrEmpty(Request.QueryString["Search"]))
            {
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

                

                var html = HtmlGenerator.GetProductsHtml(productList, category);
                ProductContainer.InnerHtml = html;
            }
            else
            {
                var searchResult = (List<Product>)Session["SearchResult"];
                if(searchResult != null)
                { 
                var searchHtml = HtmlGenerator.GetProductsHtmlbySearch(searchResult);
                    ProductContainer.InnerHtml = searchHtml;
                }
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

            #region dropboxes

            FillDropDownLists();


            #endregion


#region DynamicHtmlGenerationForSidebar

            var bllCategory = new BLLCategory();
            var prodlist = bllCategory.ReturnAllCategories();
            AsideContainer.InnerHtml = HtmlGenerator.GetCategorySidebarHtml(prodlist);
#endregion

        }

        private void FillDropDownLists()
        {
            if (!ddl_color.Items.Contains(new ListItem("--Color--")))
                ddl_color.Items.Add("--Color--");
            if (!ddl_size.Items.Contains(new ListItem("--Size--")))
                ddl_size.Items.Add("--Size--");
            if (!ddl_brand.Items.Contains(new ListItem("--Brand--")))
                ddl_brand.Items.Add("--Brand--");
            if (!ddl_category.Items.Contains(new ListItem("--Category--")))
                ddl_category.Items.Add("--Category--");
            var bll = new BLLGeneral();

            bll.ReturnAllCategories().ForEach(x => ddl_category.Items.Add(new ListItem($"{x}")));
            bll.ReturnAllBrands().ForEach(x => ddl_brand.Items.Add(new ListItem($"{x}")));
            bll.ReturnAllColors().ForEach(x => ddl_color.Items.Add(new ListItem($"{x}")));
            bll.ReturnAllSizes().ForEach(x => ddl_size.Items.Add(new ListItem($"{x}")));



        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            SetSearchObject();
            Response.Redirect("ProductsDisplay.aspx?Search=True");
        }

        private void SetSearchObject()
        {
            var searchObject = new Product();
            if(ddl_brand.SelectedValue != "--Brand--")
            {
                searchObject.brand = ddl_brand.SelectedValue;
            }
            if (ddl_size.SelectedValue != "--Size--")
            {
                searchObject.size = ddl_size.SelectedValue;
            }
            if (ddl_color.SelectedValue != "--Color--")
            {
                searchObject.Color = ddl_color.SelectedValue;
            }
            if (ddl_category.SelectedValue != "--Category--")
            {
                searchObject.category = ddl_category.SelectedValue;
            }
            var bll = new BLLProduct();
            var searchResult = bll.SearchProduct(searchObject);
            Session["SearchResult"] = searchResult;


        }
    }
}