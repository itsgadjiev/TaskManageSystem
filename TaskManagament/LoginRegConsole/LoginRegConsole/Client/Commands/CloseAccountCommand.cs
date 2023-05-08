using LoginRegConsole.Constants.Enums;
using LoginRegConsole.Database;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Client.Commands
{
	public class CloseAccountCommand
	{

		public static void Handle()
		{
			UserRepository userRepository = new UserRepository();
			
			Console.WriteLine(LocalizationService.GetTranslationByKey(KeysForLanguages.PASSWORD_REQUEST));
			string pass = Console.ReadLine();

			if (pass == "1")
			{
				return;
			}
			else if (pass == UserService.ActiveUser.Password)
			{
				userRepository.Remove(UserService.ActiveUser);	
				CustomConsole.WarningLine($"{UserService.ActiveUser.ShowFullName()} {LocalizationService.GetTranslationByKey(KeysForLanguages.SUCCESFULLY_DELETED)}");
				return;
			}
			else
			{
				CustomConsole.RedLine(LocalizationService.GetTranslationByKey(KeysForLanguages.INVALID_PASSWORD));
				return;
			}

		}
	}
}
