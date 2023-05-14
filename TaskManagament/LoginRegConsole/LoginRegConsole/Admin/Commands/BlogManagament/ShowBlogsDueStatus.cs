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

namespace LoginRegConsole.Admin.Commands.BlogManagament
{
    public class ShowBlogsDueStatus
	{
		public static void Handle(BlogStatus blogStatus)
		{
			BlogRepository blogRepository = new BlogRepository();
			PropertyInfo propertyOnSysLanguage = LocalizationService.GetPropertyOfEntryByKey<Content>(KeysForLanguages.CONTENT);
			
			int counter = 1;
			foreach (var blog in blogRepository.GetAllBy(b => b.BlogStatus == blogStatus))
			{
				CustomConsole.WarningLine($"{counter++}|| Blog Name:{blog.Code} || ID:{blog.Id} || Posted BY:{blog.PostingUser.Name} {blog.PostingUser.Surname} || Title:{propertyOnSysLanguage.GetValue(blog.Title)} || Body:{propertyOnSysLanguage.GetValue(blog.Body)} || Creation date:{blog.CreatedAt}");
			}

			if (counter == 1)
			{
				CustomConsole.RedLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.NOT_FOUND));
			}

		}
	}
}
