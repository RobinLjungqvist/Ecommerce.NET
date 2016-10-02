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
            if(string.IsNullOrEmpty(Request.QueryString["Category"]))
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
            string html = "";

                foreach (var item in productList)
                {
                    html += $"<div class=\"col-md-3 col-sm-6 productdisplay\">" +
                                                $"<div class=\"single-shop-product\">" +
                                                $"<div class=\"product-upper\">" +
                                                $"<img src = \"../Images/testimage.png\" alt=\"image\">" +
                                                $"</div>" +
                                                $"<h2><a href = \"SingleProductDisplay.aspx?ProductID={item.productID}\" > {item.name}</a></h2>" +
                                                $"<div class=\"product-carousel-price\">" +
                                                $"<ins>{Convert.ToInt32(item.ppu)}kr</ins>" +
                                                $"</div>" +

                                                $"<div class=\"product-option-shop\">" +
                                                $"<a class=\"add_to_cart_button\" data-quantity=\"1\" data-product_sku=\"\" data-product_id=\"70\" rel=\"nofollow\" href=\"ProductsDisplay.aspx?Category={category}&AddToCart={item.productID}\">Add to cart</a>" +
                                                $"</div>" +
                                                $"</div>" +
                                                $"</div>" +
                                                $"";
                if (!string.IsNullOrEmpty(Request.QueryString["AddToCart"]))
                {
                    var cart = (Dictionary<int,int>)Session["Cart"];
                    cart.Add(addToCartID,Convert.ToInt32(item.ppu));
                }

            }

            var bllCategory = new BLLCategory();

            var prodlist = bllCategory.ReturnAllCategories();
            string html2   = $"<div class=\"col-md-2 offset-1\" id=\"CategoryContainer\" runat=\"server\">" +
                             $"<div class=\"aside - nav\">" +
                             $"<h2 id=\"categoryheader\">Categories</h2>" +
                             $"<ul>";
            foreach (var item in prodlist)
            {
                html2 += $"<li><a href=\"/Sites/ProductsDisplay.aspx?Category={item}\">{item.ToUpper()}</a></li>";
            }
            html2 += "</ul>" +
                                   "</div>" +
                                   "</div>";
            ProductContainer.InnerHtml = html;
            AsideContainer.InnerHtml = html2;
        }
    }
}