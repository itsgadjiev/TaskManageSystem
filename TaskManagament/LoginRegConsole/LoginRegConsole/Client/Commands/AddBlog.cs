using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Interfaces;
using LoginRegConsole.Services;
using LoginRegConsole.Validation.Blog;
using System.Reflection;
using System.Windows.Input;

namespace LoginRegConsole.Client.Commands
{
    public class AddBlog : ICommandHandler
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
			Content contentForBody = new Content();
			Content contentForTitle = new Content();
			PropertyInfo[] propertiesOfBody = LocalizationService.GetPropertiesOfEntry(contentForBody);
			PropertyInfo[] propertiesOfTitle = LocalizationService.GetPropertiesOfEntry(contentForTitle);
			GenarateCodeForBlog genarateCodeForBlog = new GenarateCodeForBlog(blogRepository);
			string blogTitle = string.Empty;
			string blogBody = string.Empty;

			foreach (PropertyInfo propertyInfoForTitle in propertiesOfTitle)
			{
				blogTitle = _blogTitleValidation.Handle(propertyInfoForTitle);
				propertyInfoForTitle.SetValue(contentForTitle, blogTitle);
			}

			foreach (PropertyInfo propertyInfoForBody in propertiesOfBody)
			{
				blogTitle = _blogBodyValidation.Handle(propertyInfoForBody);
				propertyInfoForBody.SetValue(contentForBody, blogTitle);
			}

			string code = genarateCodeForBlog.Handle();
			Blog blog = new Blog(UserService.ActiveUser, contentForTitle, contentForBody, code);
			blogRepository.Add(blog);
			messageService.SendMessageForBlogDueStatus(blog);
			MessageService.SendMessageDueStatusForBlogIRL(blog);
			CustomConsole.GreenLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.SUCCESSFULLY));
			blog.ShowBlogInfo();
		}
	}
}
