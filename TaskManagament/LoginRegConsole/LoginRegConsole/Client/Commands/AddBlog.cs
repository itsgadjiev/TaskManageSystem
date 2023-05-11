using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LoginRegConsole.Database;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Helper;
using LoginRegConsole.Services;
using LoginRegConsole.Validation.Blog;
using LoginRegConsole.Validations.CommonValidations;
using SendGrid.Helpers.Mail;

namespace LoginRegConsole.Client.Commands
{
	public class AddBlog
	{
		private readonly BlogBodyValidation _blogBodyValidation;
		private readonly BlogTitleValidation _blogTitleValidation;

		public AddBlog()
		{
			_blogTitleValidation = new BlogTitleValidation();
			_blogBodyValidation = new BlogBodyValidation();
		}

		public async void Handle()
		{
			BlogRepository blogRepository = new BlogRepository();
			MessageService messageService = new MessageService();
			
			Content contentForTitle = new Content();
			Type typeForTitle = typeof(Content);
			PropertyInfo[] propertiesOfTitle = typeForTitle.GetProperties();

			string blogTitle = string.Empty;
			string blogBody = string.Empty;

			foreach (PropertyInfo propertyInfoForTitle in propertiesOfTitle)
			{
				blogTitle = _blogTitleValidation.Handle(propertyInfoForTitle);
				propertyInfoForTitle.SetValue(contentForTitle, blogTitle);
			}

			Content contentForBody = new Content();
			Type typeForBody = typeof(Content);
			PropertyInfo[] propertiesOfBody = typeForBody.GetProperties();


			foreach (PropertyInfo propertyInfoForBody in propertiesOfBody)
			{
				blogTitle = _blogBodyValidation.Handle(propertyInfoForBody);
				propertyInfoForBody.SetValue(contentForBody, blogTitle);
			}

			Blog blog = new Blog(UserService.ActiveUser, contentForTitle, contentForBody);
			messageService.SendMessageForBlogDueStatus(blog);
			blog.ShowBlogInfo();
			blogRepository.Add(blog);



		}
	}
}
