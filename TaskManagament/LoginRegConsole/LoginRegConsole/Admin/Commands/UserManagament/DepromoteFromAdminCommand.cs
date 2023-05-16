using LoginRegConsole.Constants.Roles;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Interfaces;
using LoginRegConsole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Admin.Commands.UserManagament
{
	public class DepromoteFromAdminCommand: ICommandHandler
	{
		public  void Handle()
		{
			UserRepository userRepository = new UserRepository();
			User user = userRepository.FindUserByEmail();
			if (user == null)
			{
				CustomConsole.RedLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.INVALID_EMAIL));
			}
			else if (user == UserService.ActiveUser)
			{
				CustomConsole.WarningLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.FORBIDDEN));
			}
			else if (user.IsAdmin())
			{
				user.Role = UserRoles.USER;
				userRepository.SaveChanges();
				CustomConsole.GreenLine($"{user.ShowFullName()} {LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.DEPROMOTE_FROM_ADMIN)}");
			}
			else 
			{
				CustomConsole.WarningLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.ALREADY_USER));
			}
			
		}
	}
}
