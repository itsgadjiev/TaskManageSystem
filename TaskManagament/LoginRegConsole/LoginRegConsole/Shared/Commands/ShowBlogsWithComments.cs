using LoginRegConsole.Constants.Enums;
using LoginRegConsole.Constants.Localisation;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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

			Type inputsOnSYSLanguage = typeof(Content);
			PropertyInfo propertyOnSysLanguage = inputsOnSYSLanguage
				.GetProperty(TemplateForLanguageSearch.VALUE_OF_LANGUAGE
							.Replace("{key}", KeysForLanguages.CONTENT.ToString())
							.Replace("{currentLanguage}", LocalizationService.CurrentLanguage.ToString()))!;

			int counter = 1;
			foreach (Blog blog in blogs)
			{
				Type type = typeof(Content);
				PropertyInfo[] propOfCon = type.GetProperties();
				foreach (PropertyInfo prop in propOfCon)
				{
					if (prop.Equals(propertyOnSysLanguage))
					{
						CustomConsole.GreenLine($"Publish Date:{blog.PostTime} || Blog Code:{blog.Code} || Blog Poster FullName:{blog.PostingUser.Name},{blog.PostingUser.Surname}");
						Console.WriteLine($"{prop.GetValue(blog.Title)}");
						Console.WriteLine($"{prop.GetValue(blog.Body)}");

						CustomConsole.RedLine("-=-=-=-=-=-=-=-=-=Comments=-=-=-=-=-=-=-=-=-");
						foreach (BlogComment blogComment in blogComments.Where(bc => bc.BlogId == blog.Id))
						{
							CustomConsole.WarningLine($"{counter++}||{blogComment.PostingDate.ToString("d")} [{blogComment.PostingUser.Name} {blogComment.PostingUser.Surname}] -- {prop.GetValue(blogComment.Content)}");
						}
					}
				}
			}

			if (counter == 1)
			{
				CustomConsole.RedLine(LocalizationService.GetTranslationByKey(KeysForLanguages.NOT_FOUND));
			}
		}
	}
}
