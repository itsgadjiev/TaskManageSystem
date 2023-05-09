using System;
using System.Collections.Generic;
using System.Linq;
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
			string blogTitle = _blogTitleValidation.Handle();
			string blogBody = _blogBodyValidation.Handle();

			Blog blog = new Blog(UserService.ActiveUser, blogTitle, blogBody);
			messageService.SendMessageForBlogDueStatus(blog);

			//messageService.SendProcessingMessageForBlog(blog);
			//await MessageService.SendMessageDueStatusForBlogIRL(blog);

			blogRepository.Add(blog);

			

		}
	}
}
