using LoginRegConsole.Admin.Commands.UserManagament;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Database;
using LoginRegConsole.Extras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginRegConsole.Helper;
using LoginRegConsole.Services;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Validations.CommonValidations;
using System.Reflection;
using SendGrid.Helpers.Mail;

namespace LoginRegConsole.Admin.Commands.MessageSending
{
	public class SendEmailCommand
	{
		public static void Handle()
		{
			UserRepository userRep = new UserRepository();
			MessageRepository messageRepository = new MessageRepository();
			string messageBody = string.Empty;
			User receivingUser = null;
			Content content = new Content();
			Type type = typeof(Content);
			PropertyInfo[] properties = type.GetProperties();

			do
			{
				receivingUser = userRep.FindUserByEmail();

			} while (receivingUser == null);

			foreach (var property in properties)
			{
				do
				{
                    Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.BLOG_BODY_INPUT)+ " " + property.Name.Substring(property.Name.Length-2,2));
					messageBody = Console.ReadLine();
					property.SetValue(content, messageBody);
				} while (!CommonValidation.IsLengthBeetween(5,50, messageBody));

			}

			Email message = new Email(content, UserService.ActiveUser, receivingUser);
			messageRepository.Add(message);
			CustomConsole.GreenLine($"{LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.MESSAGE_SENDED)} : {UserService.ActiveUser.Email} ==> {receivingUser.Email}");

		}
	}
}
