using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLGeneral
    {
        public List<string> ReturnAllCategories()
        {
            var dal = new DALGeneral();
            var datatable = dal.GetData("Select Category from tblCategory");
            var stringlist = new List<string>();
            foreach (DataRow row in datatable.Rows)
            {
                stringlist.Add($"{row["Category"]}");
            }
            return stringlist;
        }
        public List<string> ReturnAllBrands()
        {
            var dal = new DALGeneral();
            var datatable = dal.GetData("Select Brand from tblBrand");
            var stringlist = new List<string>();
            foreach (DataRow row in datatable.Rows)
            {
                stringlist.Add($"{row["Brand"]}");
            }
            return stringlist;
        }
        public List<string> ReturnAllSizes()
        {
            var dal = new DALGeneral();
            var datatable = dal.GetData("Select Size from tblSize");
            var stringlist = new List<string>();
            foreach (DataRow row in datatable.Rows)
            {
                stringlist.Add($"{row["Size"]}");
            }
            return stringlist;
        }
        public List<string> ReturnAllColors()
        {
            var dal = new DALGeneral();
            var datatable = dal.GetData("Select Color from tblColor");
            var stringlist = new List<string>();
            foreach (DataRow row in datatable.Rows)
            {
                stringlist.Add($"{row["Color"]}");
            }
            return stringlist;
        }
    }
}
