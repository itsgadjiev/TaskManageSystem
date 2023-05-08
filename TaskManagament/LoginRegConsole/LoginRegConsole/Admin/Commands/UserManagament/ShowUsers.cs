using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Admin.Commands.UserManagament
{
	public static class ShowUsers
	{
		public static void Handle()
		{
			UserRepository userRepository = new UserRepository();

			int counter = 1;
			foreach (User user in userRepository.GetAll())
			{
				Console.WriteLine($"{counter++} || ID:{user.Id} " +
					$"|| Fullname:{user.ShowFullName()} " +
					$"|| Email:{user.Email} " +
					$"|| Role:{user.Role} " +
					$"|| IsActive:{(user.IsActive ? "Active" : "Banned")}" +
					$"|| Registartion Date:{user.RegistrationDate.ToString("f")}");
			}
			Console.WriteLine();
		}
	}
}
