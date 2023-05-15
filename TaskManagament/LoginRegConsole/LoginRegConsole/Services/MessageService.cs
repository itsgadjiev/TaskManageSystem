using LoginRegConsole.Constants;
using LoginRegConsole.Constants.Enums;
using LoginRegConsole.Constants.Message;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata;
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
				field = type.GetField("BLOG_COMMENT_SENDED_" + propertyInfo.Name.Substring(propertyInfo.Name.Length - 2, 2))!;
				propertyInfo.SetValue(content, PrepareMessageForBlogComment((string)field.GetValue(messageTemplate), blogComment));
			}

			return content;

		}
		public void SendMessageToPosterForBlogComment(BlogComment blogComment)
		{
			SendMessage(blogComment.Blog.PostingUser, PrepareContentForBlogCommentEmail(blogComment));
		}

		#region PrepareContentForBlogEmailDueStatus
		private Content PrepareContentForBlogEmail(Blog blog)
		{
			MessageTemplate messageTemplate = new MessageTemplate();
			Content content = new Content();
			PropertyInfo[] propsOfContent = LocalizationService.GetPropertiesOfEntry(content);
			Type type = messageTemplate.GetType();
			FieldInfo field = default;

			foreach (PropertyInfo propertyInfo in propsOfContent)
			{
				string language = propertyInfo.Name.Substring(propertyInfo.Name.Length - 2, 2);
				field = type.GetField(blog.BlogStatus.ToString() + "_BLOG_" + propertyInfo.Name.Substring(propertyInfo.Name.Length - 2, 2))!;
				propertyInfo.SetValue(content, PrepareMessageForBlog((string)field.GetValue(messageTemplate), blog));

			}
			return content;
		}
			#endregion

			#region SeperateMethods
			//private Content PrepareContentForAcceptedBlogEmail(Blog blog)
			//{
			//	Content content = new Content();
			//	PropertyInfo[] propsOfContent = LocalizationService.GetPropertiesOfEntry(content);

			//	foreach (PropertyInfo propertyInfo in propsOfContent)
			//	{
			//		if (propertyInfo.Name == "CONTENT_AZ")
			//		{
			//			propertyInfo.SetValue(content, PrepareMessageForBlog(MessageTemplate.APPROVED_BLOG_AZ, blog));
			//			continue;
			//		}
			//		else if (propertyInfo.Name == "CONTENT_RU")
			//		{
			//			propertyInfo.SetValue(content, PrepareMessageForBlog(MessageTemplate.APPROVED_BLOG_RU, blog));
			//			continue;
			//		}
			//		else if (propertyInfo.Name == "CONTENT_EN")
			//		{
			//			propertyInfo.SetValue(content, PrepareMessageForBlog(MessageTemplate.APPROVED_BLOG_EN, blog));
			//			continue;
			//		}
			//	}

			//	return content;
			//}
			//private Content PrepareContentForRejetedBlogEmail(Blog blog)
			//{
			//	Content content = new Content();
			//	PropertyInfo[] propsOfContent = LocalizationService.GetPropertiesOfEntry(content);

			//	foreach (PropertyInfo propertyInfo in propsOfContent)
			//	{
			//		if (propertyInfo.Name == "CONTENT_AZ")
			//		{
			//			propertyInfo.SetValue(content, PrepareMessageForBlog(MessageTemplate.REJECTED_BLOG_AZ, blog));
			//			continue;
			//		}
			//		else if (propertyInfo.Name == "CONTENT_RU")
			//		{
			//			propertyInfo.SetValue(content, PrepareMessageForBlog(MessageTemplate.REJECTED_BLOG_RU, blog));
			//			continue;
			//		}
			//		else if (propertyInfo.Name == "CONTENT_EN")
			//		{
			//			propertyInfo.SetValue(content, PrepareMessageForBlog(MessageTemplate.REJECTED_BLOG_EN, blog));
			//			continue;
			//		}
			//	}

			//	return content;
			//}
			//private Content PrepareContentForWaitingBlogEmail(Blog blog)
			//{
			//	Content content = new Content();
			//	PropertyInfo[] propsOfContent = LocalizationService.GetPropertiesOfEntry(content);

			//	foreach (PropertyInfo propertyInfo in propsOfContent)
			//	{
			//		if (propertyInfo.Name == "CONTENT_AZ")
			//		{
			//			propertyInfo.SetValue(content, PrepareMessageForBlog(MessageTemplate.WAITING_BLOG_AZ, blog));
			//			continue;
			//		}
			//		else if (propertyInfo.Name == "CONTENT_RU")
			//		{
			//			propertyInfo.SetValue(content, PrepareMessageForBlog(MessageTemplate.WAITING_BLOG_RU, blog));
			//			continue;
			//		}
			//		else if (propertyInfo.Name == "CONTENT_EN")
			//		{
			//			propertyInfo.SetValue(content, PrepareMessageForBlog(MessageTemplate.WAITING_BLOG_EN, blog));
			//			continue;
			//		}
			//	}

			//	return content;
			//}
			#endregion

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
