using LoginRegConsole.Constants;
using LoginRegConsole.Constants.Message;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Reflection;
using System.Reflection.Metadata;


namespace LoginRegConsole.Services
{
	public class MessageService
	{
		private readonly MessageRepository _messageRepository;

		public MessageService()
		{
			_messageRepository = new MessageRepository();
		}

		public string PrepareMessageForBlog(string preparedMessage, Blog blog)
		{
			return preparedMessage
				.Replace(MessageTemplateKeywords.USER_NAME_FOR_BLOG, blog.PostingUser.Name)
				.Replace(MessageTemplateKeywords.USER_SURNAME_FOR_BLOG, blog.PostingUser.Surname)
				.Replace(MessageTemplateKeywords.BLOG_STATUS, blog.BlogStatus.ToString());
		}
		public void SendMessage(User user, string preparedMessage)
		{
			Email sendingMessage = new Email(preparedMessage, user, UserService.ActiveUser);
			_messageRepository.Add(sendingMessage);
		}

		public void SendMessage1(User user, Content content)
		{
			Email sendingMessage = new Email(content, user, UserService.ActiveUser);
			_messageRepository.Add(sendingMessage);
		}


		public void SendRejectionMessageForBlog(Blog blog)
		{
			SendMessage(blog.PostingUser, PrepareMessageForBlog(MessageTemplate.REJECTED, blog));
		}
		public void SendAcceptionMessageForBlog(Blog blog)
		{
			SendMessage(blog.PostingUser, PrepareMessageForBlog(MessageTemplate.APPROVED, blog));
		}
		public void SendProcessingMessageForBlog(Blog blog)
		{
			SendMessage(blog.PostingUser, PrepareMessageForBlog(MessageTemplate.WAITING, blog));
		}


		public static async Task SendMessageDueStatusForBlogIRL(Blog blog)
		{
			MessageService messageService = new MessageService();

			Type type = typeof(MessageTemplate);
			FieldInfo field = type.GetField(blog.BlogStatus.ToString())!;
			string apiKey = Environment.GetEnvironmentVariable(KeyForMessageService.API_KEY);
			var client = new SendGridClient(apiKey);
			var msg = new SendGridMessage()
			{
				From = new EmailAddress(KeyForMessageService.MESSAGE_SENDER_EMAIL, KeyForMessageService.MESSAGE_SENDER_FULLNAME),
				Subject = $"{messageService.PrepareMessageForBlog((string)field.GetValue(null), blog)}",
				PlainTextContent = $"{messageService.PrepareMessageForBlog((string)field.GetValue(null), blog)}",
			};
			msg.AddTo(new EmailAddress($"{blog.PostingUser.Email}", $"{blog.PostingUser.Name}"));

			var response = await client.SendEmailAsync(msg);
			Console.WriteLine(response.StatusCode);

		}
	




	}
}
