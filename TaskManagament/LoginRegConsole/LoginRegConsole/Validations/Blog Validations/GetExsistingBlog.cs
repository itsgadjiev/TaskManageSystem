using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeedBlog = LoginRegConsole.Database.Models.Blog;
namespace LoginRegConsole.Validations.Blog_Validations
{
	public class GetExsistingBlog
	{
		public static NeedBlog Handle()
		{
			BlogRepository blogRepository = new BlogRepository();

			NeedBlog blog = null;
			Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.ID_REQUEST) + " " + "string");
			string id = Console.ReadLine();
			blog = blogRepository.GetBy(b => b.Id == id);

			return blog;

		}
	}
}
