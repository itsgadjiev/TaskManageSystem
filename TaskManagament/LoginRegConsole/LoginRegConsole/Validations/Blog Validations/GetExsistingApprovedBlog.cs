using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Services;
using LoginRegConsole.Validations.Blog_Validations;
using NeedBlog = LoginRegConsole.Database.Models.Blog;

namespace LoginRegConsole.Validations.Blog
{
	public class GetExsistingApprovedBlog
	{
		public static NeedBlog? Handle()
		{
			BlogRepository blogRepository = new BlogRepository();

			Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.NAME_REQUEST) + " " + "blog");
			string blogName = Console.ReadLine();
			NeedBlog blog = blogRepository.GetBy(b => b.Code == blogName);

			if (blog == null)
			{
				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.BLOG_NOT_FOUND));

			}
			
			return blog;


		}
	}
}
