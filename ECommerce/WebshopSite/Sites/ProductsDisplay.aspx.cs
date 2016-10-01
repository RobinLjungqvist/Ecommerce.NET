﻿using BLL;
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
            //NameValueCollection qscoll = HttpUtility.ParseQueryString(Page.ClientQueryString);
            //productToDisplay.category = qscoll.Get("Category");
            productToDisplay.name = "Robins Jeans";




            var productList = bll.SearchProduct(productToDisplay);

            productToDisplay = productList.FirstOrDefault();
            string html = "";


            foreach (var item in productList)
            {
             html +=   $"<div class=\"col-md-3 col-sm-6 productdisplay\">" +
                                         $"<div class=\"single-shop-product\">" +
                                         $"<div class=\"product-upper\">" +
                                         $"<img src = \"../Images/testimage.png\" alt=\"image\">" +
                                         $"</div>" +
                                         $"<h2><a href = \"SingleProductDisplay.aspx?ProductID={item.productID}\" > {item.name}</a></h2>" +
                                         $"<div class=\"product-carousel-price\">" +
                                         $"<ins>{Convert.ToInt32(item.ppu)}kr</ins>" +
                                         $"</div>" +

                                         $"<div class=\"product-option-shop\">" +
                                         $"<a class=\"add_to_cart_button\" data-quantity=\"1\" data-product_sku=\"\" data-product_id=\"70\" rel=\"nofollow\" href=\"/canvas/shop/?add-to-cart=70\">Add to cart</a>" +
                                         $"</div>" +
                                         $"</div>" +
                                         $"</div>" +
                                         $"";
            }
            var bllCategory = new BLLCategory();

            var prodlist = bllCategory.ReturnAllCategories();
            string html2   = $"<div class=\"aside\">" +
                             $"<div class=\"col-md-2 offset-1\" id=\"CategoryContainer\" runat=\"server\">" +
                             $"<div class=\"aside - nav\">" +
                             $"<ul>";
            foreach (var item in prodlist)
            {
                html2 += $"<li><a href=\"/Sites/ProductsDisplay.aspx?Category={item.ToUpper()}\">{item}</a></li>";
            }
            html2 += "</ul>" +
                                   "</div>" +
                                   "</div>" +
                                   "</div>";
            ProductContainer.InnerHtml = html;
            AsideContainer.InnerHtml = html2;
        }
    }
}