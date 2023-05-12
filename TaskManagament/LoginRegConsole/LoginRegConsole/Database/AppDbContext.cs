using LoginRegConsole.Constants.Roles;
using LoginRegConsole.Database.AddSeedings;
using LoginRegConsole.Database.BaseModels;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using System.Text.Json;

namespace LoginRegConsole.Database
{
	public abstract class AppDbContext
	{
		public static List<BaseInput> BaseInputs { get; set; } = new List<BaseInput>();
		static AppDbContext()
		{
			//UserRepository.AdminCreationSeed();
		}

		public static void UserCreationSeed()
		{
			UserRepository userRepository = new UserRepository();
			string name = "Aga";
			string surname = "Badalov";
			string email = "1";
			string password = "1";

			User user = new User(name, surname, email, password, UserRoles.USER);
			userRepository.Add(user);
		}

	}
}
