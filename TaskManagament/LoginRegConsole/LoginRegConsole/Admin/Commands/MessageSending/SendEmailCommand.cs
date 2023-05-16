using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Interfaces;
using LoginRegConsole.Services;
using LoginRegConsole.Validations.Comment;
using System.Reflection;

namespace LoginRegConsole.Admin.Commands.MessageSending
{
	public class SendEmailCommand : ICommandHandler
	{
		public void Handle()
		{
			UserRepository userRep = new UserRepository();
			MessageRepository messageRepository = new MessageRepository();
			string messageBody = string.Empty;
			User receivingUser = null;
			Content content = new Content();
			PropertyInfo[] properties = LocalizationService.GetPropertiesOfEntry(content);

			do
			{
				receivingUser = userRep.FindUserByEmail();

			} while (receivingUser == null);


			foreach (var property in properties)
			{
				GetCorrectCommentBody.Handle(property, content);

			}

			Email message = new Email(content, UserService.ActiveUser, receivingUser);
			messageRepository.Add(message);
			CustomConsole.GreenLine($"{LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.MESSAGE_SENDED)} : {UserService.ActiveUser.Email} ==> {receivingUser.Email}");

		}
	}
}
