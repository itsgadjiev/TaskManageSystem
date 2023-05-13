using LoginRegConsole.Constants.Roles;
using LoginRegConsole.Database.BaseModels;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Extras;
using LoginRegConsole.Services;

namespace LoginRegConsole.Database.Repositories
{
	public class UserRepository : BaseRepository<User>
	{
		public UserRepository()
			: base("User.json")
		{

			//AdminCreationSeed();
		}


		public static void AdminCreationSeed()
		{
			BaseRepository<User> baseRepository = new BaseRepository<User>("User.json");
			string name = "Super";
			string surname = "Admin";
			string email = "admin@gmail.com";
			string password = "123321";

			User user = new User(name, surname, email, password, UserRoles.ADMIN);
			baseRepository.Add(user);

		}
		public User FindUserByEmail()
		{
			Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.EMAIL_REQUEST));

			string email = Console.ReadLine();
			foreach (User user in GetAll())
			{
				if (user.Email == email)
				{
					return user;
				}
			}
			return null;
		}
		public void RemoveUserByEmail()
		{
			UserRepository userRepository = new UserRepository();
			User user = FindUserByEmail();
			user = userRepository.GetBy(x => x.Email == user.Email);
			if (user == null)
			{
				CustomConsole.RedLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.INVALID_EMAIL));

			}
			else if (user.IsAdmin())
			{
				CustomConsole.RedLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.ADMIN_CANT_BE_REMOVED));
			}
			else
			{
				userRepository.Remove(user);
				CustomConsole.GreenLine($"{user.ShowFullName()} {LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.SUCCESFULLY_DELETED)}");
			}

		}
		public void RemoveUserById()
		{
			UserRepository userRepository = new UserRepository();
			while (true)
			{
				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.ID_REQUEST) + " " + "string");
				string id = Console.ReadLine();
				User user = null;
				user = userRepository.GetBy(x => x.Id == id);

				if (user is not null)
				{
					if (user.Role != UserRoles.ADMIN)
					{
						userRepository.Remove(user);
						CustomConsole.GreenLine($"{user.ShowFullName()} {LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.SUCCESFULLY_DELETED)}");
						return;
					}
					CustomConsole.RedLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.ADMIN_CANT_BE_REMOVED));
					return;
				}
				CustomConsole.RedLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.NOT_FOUND));
				return;
			}

		}
	}

}

