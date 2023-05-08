using LoginRegConsole.Constants.Enums;
using LoginRegConsole.Constants.Localisation;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Services;
using System.Reflection;

namespace LoginRegConsole.Client.Commands
{
	public class ViewMessagesCommand
	{
		public static void Handle()
		{
			MessageRepository messageRepository = new MessageRepository();
			Type inputsOnSYSLanguage = typeof(Content);
			PropertyInfo property = inputsOnSYSLanguage
				.GetProperty(TemplateForLanguageSearch.VALUE_OF_LANGUAGE
							.Replace("{key}", KeysForLanguages.CONTENT.ToString())
							.Replace("{currentLanguage}", LocalizationService.CurrentLanguage.ToString()))!;

			int counter = 1;
			foreach (Email message in messageRepository.GetAllBy(m => m.ReceivingUser.Email == UserService.ActiveUser.Email))
			{
				Type type = typeof(Content);
				PropertyInfo[] propOfCon = type.GetProperties();
				foreach (PropertyInfo prop in propOfCon)
				{
					if (prop.Equals(property))
					{
						CustomConsole.WarningLine($"{counter++}.{message.SendingUser.ShowFullName()} || FROM:{message.SendingUser.Email} || SENDING DATE {$"{message.SendTime.ToString("f")}"} || {prop.GetValue(message.Content)}");
					}
				}
			}

			if (counter == 1)
			{
				CustomConsole.RedLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.NOT_FOUND));
			}


		}
	}
}
