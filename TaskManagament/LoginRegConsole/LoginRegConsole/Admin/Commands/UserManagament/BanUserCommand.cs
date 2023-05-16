using LoginRegConsole.Database;
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
	public class BanUserCommand: ICommandHandler
	{
		public  void Handle()
		{
			UserRepository userRepository = new UserRepository();
			User user = userRepository.FindUserByEmail();
			if (user == null)
			{
				CustomConsole.RedLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.INVALID_EMAIL));
			}
			else if (user.IsActive == false)
			{
				CustomConsole.RedLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.ALREADY_BANNED_ACCOUNT));
			}
			else if (user.IsAdmin() == true)
			{
				CustomConsole.RedLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.ADMIN_CANT_BE_BANNED));
			}
			else 
			{
				user.IsActive = false;
				userRepository.SaveChanges();
				CustomConsole.GreenLine($"{user.ShowFullName()} {LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.SUCCESFULL_BANNED_USER)}");
			}
		}

	}
}
