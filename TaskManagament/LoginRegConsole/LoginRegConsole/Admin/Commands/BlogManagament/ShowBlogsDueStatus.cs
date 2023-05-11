using LoginRegConsole.Constants.Enums;
using LoginRegConsole.Constants.Localisation;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Admin.Commands.BlogManagament
{
	public class ShowBlogsDueStatus
	{
		public static void Handle(BlogStatus blogStatus)
		{
			BlogRepository blogRepository = new BlogRepository();
			Type inputsOnSYSLanguage = typeof(Content);
			PropertyInfo property = inputsOnSYSLanguage
				.GetProperty(TemplateForLanguageSearch.VALUE_OF_LANGUAGE
							.Replace("{key}", KeysForLanguages.CONTENT.ToString())
							.Replace("{currentLanguage}", LocalizationService.CurrentLanguage.ToString()))!;

			int counter = 1;
			foreach (var blog in blogRepository.GetAllBy(b => b.BlogStatus == blogStatus))
			{
				Type type = typeof(Content);
				PropertyInfo[] propOfCon = type.GetProperties();
				foreach (PropertyInfo prop in propOfCon)
				{
					if (prop.Equals(property))
					{
						CustomConsole.WarningLine($"{counter++}|| Blog Name:{blog.Name} || ID:{blog.Id} || Posted BY:{blog.PostingUser.Name} {blog.PostingUser.Surname} || Title:{prop.GetValue(blog.Title)} || Body:{prop.GetValue(blog.Body)} || Creation date:{blog.CreatedAt}");
					}
				}
			}

			if (counter == 1)
			{
				CustomConsole.RedLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.NOT_FOUND));
			}

		}
	}
}
