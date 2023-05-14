using LoginRegConsole.Constants.Enums;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Services;
using System.Reflection;

namespace LoginRegConsole.Shared.Commands
{
	public class ShowBlogsWithComments
	{
		public static void Handle()
		{
			BlogRepository blogRepository = new BlogRepository();
			BlogCommentRepository blogCommentRepository = new BlogCommentRepository();
			List<Blog> blogs = blogRepository.GetAllBy(b => b.BlogStatus == BlogStatus.APPROVED);
			List<BlogComment> blogComments = blogCommentRepository.GetAll();

			PropertyInfo propertyOnSysLanguage = LocalizationService.GetPropertyOfEntryByKey<Content>(KeysForLanguages.CONTENT);
			if (blogs.Count == 0)
			{
				CustomConsole.RedLine(LocalizationService.GetTranslationByKey(KeysForLanguages.NOT_FOUND));
				return;
			}
			int counter = 1;
			foreach (Blog blog in blogs)
			{
				CustomConsole.GreenLine($"Publish Date:{blog.PostTime} || Blog Code:{blog.Code} || Blog Poster FullName:{blog.PostingUser.ShowFullName()}");

				Console.WriteLine($"{propertyOnSysLanguage.GetValue(blog.Title)}");
				Console.WriteLine($"{propertyOnSysLanguage.GetValue(blog.Body)}");
				CustomConsole.RedLine("-=-=-=-=-=-=-=-=-=Comments=-=-=-=-=-=-=-=-=-");

				foreach (BlogComment blogComment in blogComments.Where(bc => bc.BlogId == blog.Id))
				{
					CustomConsole.WarningLine($"{counter++}||{blogComment.PostingDate.ToString("d")} [{blogComment.PostingUser.ShowFullName()}] -- {propertyOnSysLanguage.GetValue(blogComment.Content)}");
				}
				if (counter == 1)
				{
					CustomConsole.RedLine(LocalizationService.GetTranslationByKey(KeysForLanguages.NOT_FOUND));
					return;
				}
				else
				{
					counter = 1;
				}

			}


		}
	}
}
