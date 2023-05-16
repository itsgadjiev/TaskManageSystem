using LoginRegConsole.Constants;
using LoginRegConsole.Constants.Message;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Reflection;
using Content = LoginRegConsole.Database.Models.Content;

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
				.Replace(MessageTemplateKeywords.BLOG_CODE, blog.Code)
				.Replace(MessageTemplateKeywords.USER_NAME_FOR_BLOG, blog.PostingUser.Name)
				.Replace(MessageTemplateKeywords.USER_SURNAME_FOR_BLOG, blog.PostingUser.Surname)
				.Replace(MessageTemplateKeywords.BLOG_STATUS, blog.BlogStatus.ToString());
		}
		public string PrepareMessageForBlogComment(string preparedMessage, BlogComment blogComment)
		{

			return preparedMessage
				.Replace(MessageTemplateKeywords.BLOG_CODE, blogComment.Blog.Code)
				.Replace(MessageTemplateKeywords.USER_NAME_FOR_BLOG, blogComment.PostingUser.Name)
				.Replace(MessageTemplateKeywords.USER_SURNAME_FOR_BLOG, blogComment.PostingUser.Surname)
				.Replace(MessageTemplateKeywords.BLOG_STATUS, blogComment.Blog.BlogStatus.ToString());
		}
		private Content PrepareContentForBlogCommentEmail(BlogComment blogComment)
		{
			MessageTemplate messageTemplate = new MessageTemplate();

			Content content = new Content();
			PropertyInfo[] propsOfContent = LocalizationService.GetPropertiesOfEntry(content);
			Type type = messageTemplate.GetType();
			FieldInfo field = default;
			foreach (PropertyInfo propertyInfo in propsOfContent)
			{
				field = type.GetField(RetunFieldNameOfMessageTempalateBlogCommentEmail.Handle(propertyInfo))!;
				propertyInfo.SetValue(content, PrepareMessageForBlogComment((string)field.GetValue(messageTemplate), blogComment));
			}

			return content;

		}
		public void SendMessageToPosterForBlogComment(BlogComment blogComment)
		{
			SendMessage(blogComment.Blog.PostingUser, PrepareContentForBlogCommentEmail(blogComment));
		}
		private Content PrepareContentForBlogEmail(Blog blog)
		{
			MessageTemplate messageTemplate = new MessageTemplate();
			Content content = new Content();
			PropertyInfo[] propsOfContent = LocalizationService.GetPropertiesOfEntry(content);
			Type type = messageTemplate.GetType();
			FieldInfo field = default;

			foreach (PropertyInfo propertyInfoOfContent in propsOfContent)
			{
				field = type.GetField(RetunFieldNameOfMessageTempalateBlogEmail.Handle(blog, propertyInfoOfContent))!;
				propertyInfoOfContent.SetValue(content, PrepareMessageForBlog((string)field.GetValue(messageTemplate), blog));
			}
			return content;
		}
		public void SendMessage(User user, Content content)
		{
			Email sendingMessage = new Email(content, UserService.ActiveUser, user);
			_messageRepository.Add(sendingMessage);
		}
		public void SendMessageForBlogDueStatus(Blog blog)
		{
			SendMessage(blog.PostingUser, PrepareContentForBlogEmail(blog));
		}
		public static async Task SendMessageDueStatusForBlogIRL(Blog blog)
		{
			MessageService messageService = new MessageService();
			MessageTemplate messageTemplate = new MessageTemplate();
			Type type = messageTemplate.GetType();
			FieldInfo field = type.GetField(blog.BlogStatus.ToString() + "_BLOG_" + "EN")!;
			string apiKey = Environment.GetEnvironmentVariable(KeyForMessageService.API_KEY);
			var client = new SendGridClient(apiKey);
			var msg = new SendGridMessage()
			{
				From = new EmailAddress(KeyForMessageService.MESSAGE_SENDER_EMAIL, KeyForMessageService.MESSAGE_SENDER_FULLNAME),
				Subject = $"Blog status",
				PlainTextContent = $"{messageService.PrepareMessageForBlog((string)field.GetValue(messageTemplate), blog)}",
			};
			msg.AddTo(new EmailAddress($"{blog.PostingUser.Email}", $"{blog.PostingUser.Name}"));

			var response = await client.SendEmailAsync(msg);

		}

	}
}
