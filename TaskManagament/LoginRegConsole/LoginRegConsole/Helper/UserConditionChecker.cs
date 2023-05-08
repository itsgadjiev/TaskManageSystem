using LoginRegConsole.Admin;
using LoginRegConsole.Client;
using LoginRegConsole.Constants.Roles;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Extras;
using LoginRegConsole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Helper
{
    public class UserConditionChecker
    {
        public static void Handle()
        {
            if (UserService.ActiveUser == null)
            {
                CustomConsole.RedLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.INVALID_LOG_OR_PASS));
            }
            else if (UserService.ActiveUser.IsActive == false)
            {
                CustomConsole.RedLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.FORBIDDEN));
            }
            else if (UserService.ActiveUser.Role == UserRoles.ADMIN)
            {
                AdminDashboard.Index();
            }
            else if (UserService.ActiveUser.Role == UserRoles.USER)
            {
                ClientDashboard.Index();
            }
        }
    }
}
