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
    public class DisBanUserCommand
    {
        public static void Handle()
        {
			UserRepository userRepository = new UserRepository();
			User user = userRepository.FindUserByEmail();
            if (user == null)
            {
                CustomConsole.RedLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.INVALID_EMAIL));
            }
            else if (user.IsActive == true)
            {
                CustomConsole.RedLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.FORBIDDEN));
            }
            else if (user.IsAdmin() == false)
            {
                user.IsActive = true;
                CustomConsole.GreenLine($"{user.ShowFullName()} {LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.SUCCESSFULLY)}");
            }
        }
    }
}
