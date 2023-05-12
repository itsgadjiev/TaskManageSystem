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
		private const string AppUsersFile = "AppUsers.json";
		private const string MessagesFile = "Messages.json";
		private const string BlogsFile = "Blogs.json";
		private const string BlogCommentsFile = "BlogComments.json";
		private const string BaseInputsFile = "BaseInputs.json";

		public static List<User> AppUsers { get; set; } = new List<User>();
		public static List<Email> Messages { get; set; } = new List<Email>();
		public static List<Blog> Blogs { get; set; } = new List<Blog>();
		public static List<BlogComment> BlogComments { get; set; } = new List<BlogComment>();
		public static List<BaseInput> BaseInputs { get; set; } = new List<BaseInput>();
		static AppDbContext()
		{
			//UserRepository.AdminCreationSeed();
			//AddSeedings();
			//UserCreationSeed();
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
