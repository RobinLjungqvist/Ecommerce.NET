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
        protected void Page_Load(object sender, EventArgs e)
        {
            var productToDisplay = new Product();
            var bll = new BLLProduct();
            NameValueCollection qscoll = HttpUtility.ParseQueryString(Page.ClientQueryString);
            productToDisplay.productID = Convert.ToInt32(qscoll.Get("ProductID"));

            var productList = bll.SearchProduct(productToDisplay);
 
            productToDisplay = productList.FirstOrDefault();

            
             
            lbl_productname.Text = $"<label>{productToDisplay.name}</label>";
            lbl_despcription.Text = $"<label>Description: {productToDisplay.description}</label>";
            lbl_unitinstock.Text = $"<label>Unit In Stock: {productToDisplay.unitsInStock}</label";


            foreach (var item in productList)
            {
                if (item.productID == productToDisplay.productID)
                {
                    ddl_color.Items.Add(item.Color); 
                }
                if (ddl_color.SelectedValue == item.Color)
                {
                    ddl_size.Items.Add(item.size);

                }
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
