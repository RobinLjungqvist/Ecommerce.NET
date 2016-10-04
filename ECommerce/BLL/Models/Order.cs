using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Order
    {
        public int? OrderID { get; set; }
        public DateTime Orderdate { get; set; }
        public string DeliveryAdress { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }
        public int? CustomerID { get; set; }
        public decimal TotalPrice { get; set; }
        public List<OrderProduct> Products { get; set; }

        public void CalculateTotalPrice()
        {
            decimal total = 0;
            foreach (var product in Products)
            {
                total += product.Price * product.Quantity;
            }
            var bllUser = new BLLUser();
            User user = null;

            var searchObject = new User();
            searchObject.UserID = CustomerID;
            if(searchObject.UserID != null)
            {
                var userlist = bllUser.SearchUser(searchObject);
                user = userlist.FirstOrDefault();
            }
            if(user != null)
            {
                if(user.CustomerGroup == "VIP")
                {
                    total *= 0.9M;
                }
            }
            TotalPrice = total;
        }

    }
}
