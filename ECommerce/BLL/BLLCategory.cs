using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLCategory
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
    }
}
