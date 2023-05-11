using LoginRegConsole.Constants.Roles;
using LoginRegConsole.Database.AddSeedings;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;

namespace LoginRegConsole.Database
{
	public abstract class AppDbContext
	{
		public static List<User> AppUsers { get; set; } = new List<User>();
		public static List<Email> Messages { get; set; } = new List<Email>();
		public static List<Blog> Blogs { get; set; } = new List<Blog>();
		public static List<BlogComment> BlogComments { get; set; } = new List<BlogComment>();
		public static List<BaseInput> BaseInputs { get; set; } = new List<BaseInput>();
		static AppDbContext()
		{

			SeedingForLocalisation.AddAllCommandsOnAzerbaijani();
			SeedingForLocalisation.AddAllCommandsOnEnglish();
			SeedingForLocalisation.AddAllCommandsOnRussian();
			SeedingForLocalisation.AddAllCommandsOnChinese();

			AdminCreationSeed();
			UserCreationSeed();
		}
		
		public static void AdminCreationSeed()
		{
			UserRepository userRepository = new UserRepository();
			string name = "Super";
			string surname = "Admin";
			string email = "admin@gmail.com";
			string password = "123321";

			User user = new User(name, surname, email, password, UserRoles.ADMIN);
			userRepository.Add(user);
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
