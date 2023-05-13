using LoginRegConsole.Constants.Enums;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Services;

namespace LoginRegConsole.Client.Commands
{
	public class CloseAccountCommand
	{
		public static void Handle()
		{
			UserRepository userRepository = new UserRepository();
			User user = userRepository.GetBy(x => x.Email == UserService.ActiveUser.Email);

			Console.WriteLine(LocalizationService.GetTranslationByKey(KeysForLanguages.PASSWORD_REQUEST));
			string pass = Console.ReadLine();
			if (pass == "1")
			{
				return;
			}
			else if (pass == user.Password)
			{
				userRepository.Remove(user);
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
