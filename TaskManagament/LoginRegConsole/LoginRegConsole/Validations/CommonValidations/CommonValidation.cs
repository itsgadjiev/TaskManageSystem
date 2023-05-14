using LoginRegConsole.Database.Models;
using LoginRegConsole.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using LoginRegConsole.Services;
using LoginRegConsole.Database.Repositories;

namespace LoginRegConsole.Validations.CommonValidations
{
    public class CommonValidation
    {
       
        public static bool IsLengthBeetween(int min, int max, string input)
        {
            if (input.Length > max || input.Length < min) return false;
            return true;
        }
        public static bool EmailValidation(string eMail, ref bool exsistingMail)
        {
            UserRepository userRepository = new UserRepository();
			string emailPattern = @"^[\w.]{5,30}@(code\.edu\.az|yandex\.com|gmail\.com|mail\.ru|rambler\.ru|inbox\.ru)$";
			bool isValidEmail = Regex.IsMatch(eMail, emailPattern);
            if (isValidEmail is false)
            {
                return false;
            }
            else
            {
                foreach (User user in userRepository.GetAll())
                {
                    if (user.Email.ToLower() == eMail.ToLower())
                    {
                        exsistingMail = true;
                        return false;
                    }
                }
                return true;
            }

        }
        public static bool PasswordValidation(string password, string passwordCheck)
        {
            if (password != passwordCheck) { return false; }
            return true;
        }

    }
}
