using BLL;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebshopSite
{
    public static class InputValidationHelper
    {
        public static string UserIsValid(User user)
        {
            var Result = string.Empty;
            if (!UserNameIsValid(user.UserName))
            {
                Result += "The Username is taken. ";
            }
            if (!EmailIsValid(user.Email))
            {
                Result += "The E-mail is already bound to an account.";
            }
            if (Result == string.Empty)
            {
                ZipcodeIsValid(user.ZipCode);
                CityIsValid(user.City);
            }

            return Result;
        }

        private static void ZipcodeIsValid(int? zipcode)
        {
            var bll = new BLLZipcode();
            int newZipcode = Convert.ToInt32(zipcode);
            
            foreach(var zip in bll.getZipcodes())
            {
                if(zipcode == zip)
                {
                    return;
                }
            }
            bll.AddNewZipcode(newZipcode);
        }
        private static bool UserNameIsValid(string username)
        {
            bool IsValid = true;
            var bll = new BLLUser();
            var tempUser = new User();
            tempUser.UserName = username.ToLower();
            foreach(var user in bll.SearchUser(tempUser))
            {
                if(user.UserName.ToLower() == username)
                {
                    IsValid = false;
                }
            }


            return IsValid;
        }
        private static bool EmailIsValid(string email)
        {
            bool IsValid = true;
            var bll = new BLLUser();
            var tempUser = new User();
            tempUser.Email = email.ToLower();
            foreach (var user in bll.SearchUser(tempUser))
            {
                if (user.Email.ToLower() == email)
                {
                    IsValid = false;
                }
            }


            return IsValid;
        }
        private static void CityIsValid(string city)
        {
            var bll = new BLLCity();

            foreach (var existingCity in bll.GetCities())
            {
                if (existingCity == city)
                {
                    return;
                }
            }
            bll.AddNewCity(city);
        }
    }
}