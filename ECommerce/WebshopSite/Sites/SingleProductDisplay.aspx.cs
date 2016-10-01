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
    public partial class SingleProductDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var productToDisplay = new Product();
            var bll = new BLLProduct();
            productToDisplay.productID = 7; // Eller det vi skickar till sidan.
    
            var productList = bll.SearchProduct(productToDisplay);
 
            productToDisplay = productList.FirstOrDefault();

            
             
            lbl_productname.Text = $"<label>{productToDisplay.name}</label>";
            lbl_despcription.Text = $"<label>Description: {productToDisplay.description}</label>";
            lbl_unitinstock.Text =  $"<label>Unit In Stock: {productToDisplay.unitsInStock}</label";
            
            
            foreach (var item in productList)
            {
                ddl_size.Items.Add(item.size);
                ddl_color.Items.Add(item.Color); 
            }
             



            //var productToCart = productList[index];
        }

        protected void btn_buy_Click(object sender, EventArgs e)
        {

        }

        protected void ddl_color_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
