using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Services;
using LoginRegConsole.Validation.Blog;
using System.Reflection;

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

		public void Handle()
		{
			BlogRepository blogRepository = new BlogRepository();
			MessageService messageService = new MessageService();
			string blogTitle = string.Empty;
			string blogBody = string.Empty;

			Content contentForTitle = new Content();
			Type typeForTitle = typeof(Content);
			PropertyInfo[] propertiesOfTitle = typeForTitle.GetProperties();



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
