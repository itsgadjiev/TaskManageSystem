﻿using LoginRegConsole.Constants.Roles;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;

namespace LoginRegConsole.Database
{
	public abstract class AppDbContext
	{
		public static List<BaseInput> BaseInputs { get; set; } = new List<BaseInput>();
		public static List<BlogComment> BlogComments { get; set; } = new List<BlogComment>();
		static AppDbContext()
		{
			UserRepository.AdminCreationSeed();
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
