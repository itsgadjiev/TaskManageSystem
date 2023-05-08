using LoginRegConsole.Constants.Roles;
using LoginRegConsole.Database.BaseModels;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Extras;
using LoginRegConsole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Database.Repositories
{
	public class UserRepository:BaseRepository<User>
	{
		public UserRepository() 
			: base(AppDbContext.AppUsers)
		{ }
		
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
			User user = FindUserByEmail();
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
				AppDbContext.AppUsers.Remove(user);
				CustomConsole.GreenLine($"{user.ShowFullName()} {LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.SUCCESFULLY_DELETED)}");
			}

		}
		public void RemoveUserById()
		{
			while (true)
			{
				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.ID_REQUEST));
				try
				{
					int id = int.Parse(Console.ReadLine());
					foreach (var item in GetAll())
					{
						if (item.Id == id)
						{
							if (item.Role != UserRoles.ADMIN)
							{
								AppDbContext.AppUsers.Remove(item);
								CustomConsole.GreenLine($"{item.ShowFullName()} {LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.SUCCESFULLY_DELETED)}");
								return;
							}
							CustomConsole.RedLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.ADMIN_CANT_BE_REMOVED));
							return;
						}
					}
					CustomConsole.GreenLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.NOT_FOUND));
					return;
				}
				catch
				{
					CustomConsole.RedLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.ENTER_CORECT_FORMAT));
					break;
				}
			}
		}
		
	}
}
