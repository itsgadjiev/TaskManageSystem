using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Services;
using LoginRegConsole.Validations.CommonValidations;
using System.Reflection;

namespace LoginRegConsole.Admin.Commands.MessageSending
{
	public class SendEmailCommand
	{
		public static void Handle()
		{
			UserRepository userRep = new UserRepository();
			MessageRepository messageRepository = new MessageRepository();
			Content content = new Content();
			PropertyInfo[] properties = LocalizationService.GetPropertiesOfEntry(content);
			string messageBody = string.Empty;
			User receivingUser = null;
			//Type type = typeof(Content);
			//PropertyInfo[] properties = type.GetProperties();

			do
			{
				receivingUser = userRep.FindUserByEmail();

			} while (receivingUser == null);

			foreach (var property in properties)
			{
				do
				{
					Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.BLOG_BODY_INPUT) + " " + property.Name.Substring(property.Name.Length - 2, 2));
					messageBody = Console.ReadLine();
					property.SetValue(content, messageBody);
				} while (!CommonValidation.IsLengthBeetween(5, 50, messageBody));

			}

			Email message = new Email(content, UserService.ActiveUser, receivingUser);
			messageRepository.Add(message);
			CustomConsole.GreenLine($"{LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.MESSAGE_SENDED)} : {UserService.ActiveUser.Email} ==> {receivingUser.Email}");

		}
	}
}
