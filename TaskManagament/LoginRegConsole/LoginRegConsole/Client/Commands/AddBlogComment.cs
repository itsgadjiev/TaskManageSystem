using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Interfaces;
using LoginRegConsole.Services;
using LoginRegConsole.Validations.Blog;
using LoginRegConsole.Validations.Blog_Comment;
using System.Reflection;
using System.Windows.Input;

namespace LoginRegConsole.Client.Commands
{
	public class AddBlogComment : ICommandHandler
	{
		public void Handle()
		{
			MessageService messageService = new MessageService();
			BlogCommentRepository blogCommentRepository = new BlogCommentRepository();
			Content content = new Content();
			PropertyInfo[] properties = LocalizationService.GetPropertiesOfEntry(content);

			string messageBody = string.Empty;
			Blog blog = GetExsistingApprovedBlog.Handle(); 
			if (blog is null)
			{
				return;
			}
			if (blog.BlogStatus != Constants.Enums.BlogStatus.APPROVED)
			{
				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.FORBIDDEN));
				return;
			}

			foreach (var property in properties)
			{
				GetCorrectBlogCommentBody.Handle(property, content);
			}

			BlogComment blogComment = new BlogComment(blog, UserService.ActiveUser, content);
			
			messageService.SendMessageToPosterForBlogComment(blogComment);
			blogCommentRepository.Add(blogComment);
			CustomConsole.GreenLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.SUCCESSFULLY));

		}
	}
}
