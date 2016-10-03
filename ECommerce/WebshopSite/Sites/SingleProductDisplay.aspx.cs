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
    public partial class SingleProductDisplay : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var bllcategory = new BLLCategory();
            var categories = bllcategory.ReturnAllCategories();
            var html = HtmlGenerator.GetCategorySidebarHtml(categories);
            AsideContainer.InnerHtml = html;


            var productToDisplay = new Product();
            var bll = new BLLProduct();
            NameValueCollection qscoll = HttpUtility.ParseQueryString(Page.ClientQueryString);
            productToDisplay.productID = Convert.ToInt32(qscoll.Get("ProductID"));
            if (string.IsNullOrEmpty(Request.QueryString["ProductID"]))
            {
                Response.Redirect("ProductsDisplay.aspx");
            }
            var productList = bll.SearchProduct(productToDisplay);




 
            productToDisplay = productList.FirstOrDefault();
            Session["SingleProduct"] = productToDisplay;
            lbl_color.Text = $"Color: {productToDisplay.Color}";
            lbl_size.Text = $"Size: { productToDisplay.size}";
            lbl_productname.Text = $"{productToDisplay.name}";
            description.InnerText = $"{productToDisplay.description}";
            lbl_unitinstock.Text = $"Unit In Stock: {productToDisplay.unitsInStock}";

            var searchObject = new Product();
            searchObject.name = productToDisplay.name;
            searchObject.Color = productToDisplay.Color;

            var similarProducts = bll.SearchProduct(searchObject);

            if(!ddl_color.Items.Contains(new ListItem("--Color--")))
                ddl_color.Items.Add("--Color--");
            if (!ddl_size.Items.Contains(new ListItem("--Size--")))
                ddl_size.Items.Add("--Size--");

            foreach (var product in similarProducts)
            {
                if (!ddl_size.Items.Contains(new ListItem(product.size)))
                    ddl_size.Items.Add(product.size);
            }

            searchObject.Color = null;
            similarProducts = bll.SearchProduct(searchObject);
            foreach (var product in similarProducts)
            {
                if (!ddl_color.Items.Contains(new ListItem(product.Color)))
                    ddl_color.Items.Add(product.Color);
            }



        }

        protected void btn_buy_Click(object sender, EventArgs e)
        {
            var product = (Product)Session["SingleProduct"];
            var orderProduct = new OrderProduct();
            orderProduct.ProductID = product.productID;
            orderProduct.ProductName = product.name;
            orderProduct.Price = (int)product.ppu;
            orderProduct.Quantity = 1;
            var cart = (List<OrderProduct>)Session["Cart"];
            cart.Add(orderProduct);
            Response.Redirect(Request.Url.ToString());
            
        }


        protected void Choices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_color.SelectedValue != "--Color--")
            {
                var bll = new BLLProduct();
                var searchObject = new Product();
                searchObject.name = lbl_productname.Text;
                searchObject.Color = ddl_color.SelectedValue;
                var prodlist = bll.SearchProduct(searchObject);
                var prod = prodlist.FirstOrDefault();
                string url = $"SingleProductDisplay?ProductID={prod.productID}";
                Response.Redirect(url);
            }

        }

        protected void ddl_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_size.SelectedValue != "--Size--")
            {
                var bll = new BLLProduct();
                var searchObject = new Product();
                searchObject.name = lbl_productname.Text;
                searchObject.size = ddl_size.SelectedValue;
                var prodlist = bll.SearchProduct(searchObject);
                var prod = prodlist.FirstOrDefault();
                string url = $"SingleProductDisplay?ProductID={prod.productID}";
                Response.Redirect(url);
            }
        }
    }
}
