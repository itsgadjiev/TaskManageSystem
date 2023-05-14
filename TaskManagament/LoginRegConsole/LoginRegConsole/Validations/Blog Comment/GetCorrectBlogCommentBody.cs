using LoginRegConsole.Services;
using LoginRegConsole.Validations.CommonValidations;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Validations.Blog_Comment
{
	public class GetCorrectBlogCommentBody
	{
		public static void Handle<TDomain>(PropertyInfo property, TDomain entry) 
		{
			string messageBody=string.Empty;
			do
			{
				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.BLOG_BODY_INPUT) + " " + property.Name.Substring(property.Name.Length - 2, 2));
				messageBody = Console.ReadLine();
				property.SetValue(entry, messageBody);
			} while (!CommonValidation.IsLengthBeetween(5, 50, messageBody));
			
		}
	}
}
