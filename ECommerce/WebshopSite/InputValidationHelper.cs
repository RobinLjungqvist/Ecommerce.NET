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
            var Result = "* ";
            if (!UserNameIsValid(user.UserName))
            {
                Result += "The Username is taken.\n ";
            }
            if (!EmailIsValid(user.Email))
            {
                if(Result.Length > 0)
                {
                    Result += "and";
                }
                { }
                Result += "The E-mail is already bound to an account.";
            }
            if (Result == string.Empty)
            {
                ZipcodeIsValid(user.ZipCode);
                CityIsValid(user.City);
                user.StreetAdress = FirstLetterToUpperCase(user.StreetAdress);
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
            tempUser.UserName = username;
            foreach(var user in bll.SearchUser(tempUser))
            {
                if(user.UserName.ToLower() == username.ToLower())
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
                if (user.Email.ToLower() == email.ToLower())
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
                if (existingCity.ToLower() == city.ToLower())
                {
                    return;
                }
            }
            city = FirstLetterToUpperCase(city);
            bll.AddNewCity(city);
        }
        public static string FirstLetterToUpperCase(string input)
        {
            var array = input.ToArray();
            var formattedInput = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                if (i > 0)
                {
                    formattedInput += array[i];
                }
                else
                {
                    formattedInput += array[i].ToString().ToUpper();
                }
            }
            return formattedInput;
        }
    }
}