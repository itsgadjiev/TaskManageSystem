using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Services;
using LoginRegConsole.Validations.Blog;
using LoginRegConsole.Validations.Blog_Comment;
using System.Reflection;

namespace LoginRegConsole.Client.Commands
{
	public class AddBlogComment
	{
		public void Handle()
		{
			MessageService messageService = new MessageService();
			BlogCommentRepository blogCommentRepository = new BlogCommentRepository();
			Content content = new Content();
			PropertyInfo[] properties = LocalizationService.GetPropertiesOfEntry(content);

			string messageBody = string.Empty;
			Blog blog = null;
			blog = GetExsistingBlog.Handle(blog);

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
