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
            if

            return 
        }

        private static void ZipcodeIsValid(int zipcode)
        {
            var bll = new BLLZipcode();
            
            foreach(var zip in bll.getZipcodes())
            {
                if(zipcode == zip)
                {
                    return;
                }
            }
            bll.AddNewZipcode(zipcode);
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
    }
}