using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCity
    {
        public List<string> GetCities()
        {
            var dal = new DALGeneral();
            var cities = new List<string>();
            var sql = "Select City FROM tblCity";
            var dt = dal.GetData(sql);

            foreach (DataRow row in dt.Rows)
            {
                var city = $"{row["City"]}";

                cities.Add(city);
            }
            return cities;
        }
        public void AddNewCity(string city)
        {
            var dal = new DALGeneral();
            var zipcodes = new List<int>();
            var sql = "INSERT INTO tblCity (City) " +
                     $"VALUES ({city})";
            var dt = dal.CrudData(sql);
        }
    }
}
