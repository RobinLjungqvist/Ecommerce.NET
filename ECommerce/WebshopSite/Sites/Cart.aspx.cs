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
            for (int i = 0; i < orderProds.Count; i++)
            {
                int tempcount = 0;
                for (int j = 0; j < orderProds.Count; j++)
                {
                    if (orderProds[i].ProductID == orderProds[j].ProductID)
                    {
                        tempcount++;
                        if (tempcount > 1)
                        {
                            orderProds.RemoveAt(j);
                            j--;
                            orderProds[i].Quantity = tempcount;
                        }
                    }
                  
                }
            }
            NameValueCollection qscoll = HttpUtility.ParseQueryString(Page.ClientQueryString);
            if (!string.IsNullOrEmpty(Request.QueryString["UpdateQuantity"]))
            {
                for (int i = 0; i < orderProds.Count; i++)
                {
                    if (orderProds[i].ProductID == Convert.ToInt32(qscoll.Get("ProductID")))
                    {
                        if (Convert.ToInt32(qscoll.Get("UpdateQuantity")) < 1)
                        {
                            orderProds.RemoveAt(i);
                            i--;
                        }
                        else
                        {
                            orderProds[i].Quantity = Convert.ToInt32(qscoll.Get("UpdateQuantity"));
                        }
                    }
                }

            }
            if (!string.IsNullOrEmpty(Request.QueryString["ProductToRemoveByID"]))
            {
                for (int i = 0; i < orderProds.Count; i++)
                {
                    if (orderProds[i].ProductID == Convert.ToInt32(qscoll.Get("ProductToRemoveByID")))
                    {
                        
                            orderProds.RemoveAt(i);
                            i--;

                    }
                }

            }
            var bllcategory = new BLLCategory();
            var categories = bllcategory.ReturnAllCategories();
            var sidebarhtml = HtmlGenerator.GetCategorySidebarHtml(categories);
            cartnav.InnerHtml = sidebarhtml;
            html = HtmlGenerator.GetOrderProducts(orderProds);

            CartContainer.InnerHtml = html;
        }

        protected void btn_proceedToCheckout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Checkout.aspx");
        }
    }
}