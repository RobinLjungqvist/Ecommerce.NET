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
    public partial class ProductsDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var productToDisplay = new Product();
            var bll = new BLLProduct();
            productToDisplay.category = "Tröja";

           

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
                                         $"<h2><a href = \"\" > {item.name}</a></h2>" +
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
            ProductContainer.InnerHtml = html;

            //var productToCart = productList[index];
        }
    }
}