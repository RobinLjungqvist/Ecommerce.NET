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
            List<int> productIDs = (List<int>)Session["Cart"];
            List<Product> products = new List<Product>();
            foreach (var item in productIDs)
            {
                Product product = new Product();
                product.productID = item;
                var templist = bllproduct.SearchProduct(product);
                foreach (var x in templist)
                {
                    products.Add(x);
                }
            }


            foreach (var item in products)
            {
                html += $"<div class\"row\">" +
                                            $"<div class=\"col-md-10 col-md-offset-2 productdisplay\">" +
                                            $"<div class=\"single-shop-product\">" +
                                            $"<div class=\"product-upper\">" +
                                            $"<img src = \"../Images/testimage.png\" alt=\"image\">" +
                                            $"</div>" +
                                            $"<h2><a href = \"SingleProductDisplay.aspx?ProductID={item.productID}\" > {item.name}</a></h2>" +
                                            $"<div class=\"product-carousel-price\">" +
                                            $"<ins>{Convert.ToInt32(item.ppu)}kr</ins>" +
                                            $"</div>" +

                                            $"<div class=\"product-option-shop\">" +
                                            $"<a class=\"add_to_cart_button\" data-quantity=\"1\" data-product_sku=\"\" data-product_id=\"70\" rel=\"nofollow\" href=\"ProductsDisplay.aspx?Category={item.category}&AddToCart={item.productID}\">Add to cart</a>" +
                                            $"</div>" +
                                            $"</div>" +
                                            $"</div>" +
                                            $"</div>" +
                                            $"";
            }
        }
    }
}