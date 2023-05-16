using LoginRegConsole.Services;
using LoginRegConsole.Validations.CommonValidations;
using LoginRegConsole.Validations.InputValidations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Validation.Blog
{
    public class BlogBodyValidation
	{
		public string Handle(PropertyInfo propertyInfo)
		{
			while (true)
			{
				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.BLOG_BODY_INPUT) + " " + GetLanguageDueContent.Handle(propertyInfo));
				string blogBody = Console.ReadLine();

				if (CommonValidation.IsLengthBeetween(InputLengthValidationsForBlog.MIN_LENGTH_BLOG_BODY, InputLengthValidationsForBlog.MAX_LENGTH_BLOG_BODY, blogBody))
				{
					return blogBody;
				}
				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.INCORRECT_LENGTH));
			}
		}
	}
}
