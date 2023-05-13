using LoginRegConsole.Constants.Roles;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Admin.Commands.UserManagament
{
    public class PromoteToAdmin
    {

        public static void Handle()
        {
            UserRepository userRepository = new UserRepository();
			User user = userRepository.FindUserByEmail();
            if (user == null) 
            {

                CustomConsole.RedLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.NOT_FOUND));
            }
            else if(user.IsAdmin())
            {
                CustomConsole.WarningLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.ALREADY_ADMIN));
            }
            else
            {
                user.Role = UserRoles.ADMIN;
				userRepository.SaveChanges();

				CustomConsole.GreenLine($"{user.ShowFullName()} {LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.PROMOTED_TO_ADMIN)}");
            }
        }

    }
}
