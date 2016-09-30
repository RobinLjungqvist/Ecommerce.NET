using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLZipcode
    {
        public List<int> getZipcodes()
        {
            var dal = new DALGeneral();
            var zipcodes = new List<int>();
            var sql = "Select Zipcode FROM tblZipcode";
            var dt = dal.GetData(sql);

            foreach(DataRow row in dt.Rows)
            {
                var zipcode = Convert.ToInt32(row["Zipcode"]);

                zipcodes.Add(zipcode);
            }
            return zipcodes;
        }
        public void AddNewZipcode(int zipcode)
        {
            var dal = new DALGeneral();
            var zipcodes = new List<int>();
            var sql = "INSERT INTO tblZipcode (Zipcode) " + 
                     $"VALUES Zipcode={zipcode}";
            var dt = dal.CrudData(sql);
        }
    }
}
