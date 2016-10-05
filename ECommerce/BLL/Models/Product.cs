using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL.Models
{
    public class Product
    {
        public int? productID { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string size { get; set; }
        public string Color { get; set; }

        public string brand { get; set; }
        public string description { get; set; }
        public decimal? ppu { get; set; }
        public int? unitsInStock { get; set; }
        public string picture { get; set; }

        public bool HasAssignedValues()
        {
            bool assignedValues = false;
            if (category != null)
                assignedValues = true;
            if (brand != null)
                assignedValues = true;
            if (size != null)
                assignedValues = true;
            if (Color != null)
                assignedValues = true;

            return assignedValues;
        }

    }
    
}