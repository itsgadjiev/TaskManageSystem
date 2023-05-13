using LoginRegConsole.Constants;
using LoginRegConsole.Constants.Enums;
using LoginRegConsole.Constants.Message;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Reflection;


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

		//private Content PrepareContentForBlogCommentEmail(Blog blog)
		//{
		//	Content content = new Content();
		//	PropertyInfo[] propsOfContent = LocalizationService.GetPropertiesOfEntry(content);

		//	foreach (PropertyInfo propertyInfo in propsOfContent)
		//	{
		//		PropertyInfo prop = LocalizationService.GetPropertyOfEntryByString<MessageTemplate>("BLOG_COMMENT_SENDED_" + LocalizationService.CurrentLanguage);
		//		if (propertyInfo.Name == "CONTENT_AZ")
		//		{
		//			propertyInfo.SetValue(content, PrepareMessageForBlog(MessageTemplate.BLOG_COMMENT_SENDED_AZ, blog));
		//			continue;
		//		}
		//		else if (propertyInfo.Name == "CONTENT_RU")
		//		{
		//			propertyInfo.SetValue(content, PrepareMessageForBlog(MessageTemplate.BLOG_COMMENT_SENDED_RU, blog));
		//			continue;
		//		}
		//		else if (propertyInfo.Name == "CONTENT_EN")
		//		{
		//			propertyInfo.SetValue(content, PrepareMessageForBlog(MessageTemplate.BLOG_COMMENT_SENDED_EN, blog));
		//			continue;
		//		}
		//	}

		//	return content;

		//}

		private Content PrepareContentForBlogCommentEmail(Blog blog)
		{
			Content content = new Content();
			PropertyInfo[] propsOfContent = LocalizationService.GetPropertiesOfEntry(content);
			MessageTemplate messageTemplate = new MessageTemplate();	
			foreach (PropertyInfo propertyInfo in propsOfContent)
			{
				FieldInfo prop = LocalizationService.GetFieldOfEntryByString<MessageTemplate>("BLOG_COMMENT_SENDED_" + LocalizationService.CurrentLanguage);

				propertyInfo.SetValue(content, PrepareMessageForBlog((string)prop.GetValue(messageTemplate), blog));
				continue;

			}

			return content;

		}

		public void SendMessageToPosterForBlogComment(BlogComment blogComment)
		{
			SendMessage(blogComment.Blog.PostingUser, PrepareContentForBlogCommentEmail(blogComment.Blog));
		}

		private Content PrepareContentForBlogEmail(Blog blog)
		{
			Content content = new Content();
			Type type = typeof(Content);
			PropertyInfo[] propsOfContent = type.GetProperties();

			if (blog.BlogStatus == BlogStatus.APPROVED)
			{
				foreach (PropertyInfo propertyInfo in propsOfContent)
				{
					if (propertyInfo.Name == "CONTENT_AZ")
					{
						propertyInfo.SetValue(content, PrepareMessageForBlog(MessageTemplate.APPROVED_BLOG_AZ, blog));
						continue;
					}
					else if (propertyInfo.Name == "CONTENT_RU")
					{
						propertyInfo.SetValue(content, PrepareMessageForBlog(MessageTemplate.APPROVED_BLOG_RU, blog));
						continue;
					}
					else if (propertyInfo.Name == "CONTENT_EN")
					{
						propertyInfo.SetValue(content, PrepareMessageForBlog(MessageTemplate.APPROVED_BLOG_EN, blog));
						continue;
					}
				}
			}
			else if (blog.BlogStatus == BlogStatus.REJECTED)
			{
				foreach (PropertyInfo propertyInfo in propsOfContent)
				{
					if (propertyInfo.Name == "CONTENT_AZ")
					{
						propertyInfo.SetValue(content, PrepareMessageForBlog(MessageTemplate.REJECTED_BLOG_AZ, blog));
						continue;
					}
					else if (propertyInfo.Name == "CONTENT_RU")
					{
						propertyInfo.SetValue(content, PrepareMessageForBlog(MessageTemplate.REJECTED_BLOG_RU, blog));
						continue;
					}
					else if (propertyInfo.Name == "CONTENT_EN")
					{
						propertyInfo.SetValue(content, PrepareMessageForBlog(MessageTemplate.REJECTED_BLOG_EN, blog));
						continue;
					}
				}
			}
			else if (blog.BlogStatus == BlogStatus.WAITING)
			{
				foreach (PropertyInfo propertyInfo in propsOfContent)
				{
					if (propertyInfo.Name == "CONTENT_AZ")
					{
						propertyInfo.SetValue(content, PrepareMessageForBlog(MessageTemplate.WAITING_BLOG_AZ, blog));
						continue;
					}
					else if (propertyInfo.Name == "CONTENT_RU")
					{
						propertyInfo.SetValue(content, PrepareMessageForBlog(MessageTemplate.WAITING_BLOG_RU, blog));
						continue;
					}
					else if (propertyInfo.Name == "CONTENT_EN")
					{
						propertyInfo.SetValue(content, PrepareMessageForBlog(MessageTemplate.WAITING_BLOG_EN, blog));
						continue;
					}
				}
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

			Type type = typeof(MessageTemplate);
			FieldInfo field = type.GetField(blog.BlogStatus.ToString())!;
			string apiKey = Environment.GetEnvironmentVariable(KeyForMessageService.API_KEY);
			var client = new SendGridClient(apiKey);
			var msg = new SendGridMessage()
			{
				From = new EmailAddress(KeyForMessageService.MESSAGE_SENDER_EMAIL, KeyForMessageService.MESSAGE_SENDER_FULLNAME),
				Subject = $"Blog status",
				PlainTextContent = $"{messageService.PrepareMessageForBlog((string)field.GetValue(null), blog)}",
			};
			msg.AddTo(new EmailAddress($"{blog.PostingUser.Email}", $"{blog.PostingUser.Name}"));

			var response = await client.SendEmailAsync(msg);
			Console.WriteLine(response.StatusCode);

		}

	}
}
