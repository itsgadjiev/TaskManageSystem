using LoginRegConsole.Services;
using LoginRegConsole.Validations.CommonValidations;
using LoginRegConsole.Validations.InputValidations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Validation.Blog
{
    public class BlogTitleValidation
	{
		public string Handle()
		{
			while (true)
			{
				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.BLOG_TITLE_INPUT));
				string blogTitle = Console.ReadLine();

				if (CommonValidation.IsLengthBeetween(InputLengthValidationsForBlog.MIN_LENGTH_BLOG_TITLE, InputLengthValidationsForBlog.MAX_LENGTH_BLOG_TITLE, blogTitle))
				{
					return blogTitle;
				}
				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.INCORRECT_LENGTH));
			}
		}
	}
}
