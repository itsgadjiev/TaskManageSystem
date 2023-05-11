using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Services;
using LoginRegConsole.Validations.CommonValidations;
using System.Reflection;

namespace LoginRegConsole.Client.Commands
{
	public class AddBlogComment
	{
		public void Handle()
		{
			BlogRepository BlogRepository = new BlogRepository();
			BlogCommentRepository blogCommentRepository = new BlogCommentRepository();
			Content content = new Content();
			Type type = typeof(Content);
			PropertyInfo[] properties = type.GetProperties();
			string messageBody = string.Empty;
			Blog blog = null;

			do
			{
				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.NAME_REQUEST) + "blog");
				string blogName = Console.ReadLine();
				blog = BlogRepository.GetBy(x => x.Name == blogName);

			} while (blog == null);


			foreach (var property in properties)
			{
				do
				{
					Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.BLOG_BODY_INPUT) + " " + property.Name.Substring(property.Name.Length - 2, 2));
					messageBody = Console.ReadLine();
					property.SetValue(content, messageBody);
				} while (!CommonValidation.IsLengthBeetween(5, 50, messageBody));

			}

			BlogComment blogComment = new BlogComment(blog, UserService.ActiveUser, content);
			blogCommentRepository.Add(blogComment);

		}
	}
}
