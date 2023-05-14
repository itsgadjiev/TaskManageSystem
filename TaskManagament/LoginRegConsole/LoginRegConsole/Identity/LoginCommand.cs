using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Services;

namespace LoginRegConsole.Identity
{
	public class LoginCommand
	{
		public static User Login()
		{
			//UserRepository.AdminCreationSeed();
			UserRepository userRepository = new UserRepository();
			Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.EMAIL_REQUEST));
			string email = Console.ReadLine();
			Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.PASSWORD_REQUEST));
			string pass = Console.ReadLine();

			foreach (User userInDb in userRepository.GetAll())
			{
				if (userInDb.Email == email && userInDb.Password == pass)
				{
                    CustomConsole.WarningLine(userInDb.ShowFullName()+ " ");
                    return userInDb;
				}
			}
			return null;
		}
	}
}
