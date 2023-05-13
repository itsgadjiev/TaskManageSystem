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
			PropertyInfo property = LocalizationService.GetPropertyOfEntryByKey<Content>(KeysForLanguages.CONTENT);

			int counter = 1;
			foreach (Email message in messageRepository.GetAllBy(m => m.ReceivingUser.Email == UserService.ActiveUser.Email))
			{
				CustomConsole.WarningLine($"{counter++}.{message.SendingUser.ShowFullName()} || FROM:{message.SendingUser.Email} || SENDING DATE: {$"{message.SendTime.ToString("f")}"} || {property.GetValue(message.Content)}");
			}

			if (counter == 1)
			{
				CustomConsole.RedLine(LocalizationService.GetTranslationByKey(KeysForLanguages.NOT_FOUND));
			}


		}
	}
}
