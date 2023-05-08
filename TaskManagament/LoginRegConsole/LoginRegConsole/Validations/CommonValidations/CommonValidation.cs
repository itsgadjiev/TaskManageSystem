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
        private static UserRepository userRepository = new UserRepository();
        public static bool IsLengthBeetween(int min, int max, string input)
        {
            if (input.Length > max || input.Length < min) return false;
            return true;
        }
        public static bool EmailValidation(string eMail, ref bool exsistingMail)
        {
            string emailPattern = @"^[a-zA-Z0-9]{10,30}@code\.edu\.az$";
            bool isValidEmail = !Regex.IsMatch(eMail, emailPattern);
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
