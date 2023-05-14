using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Services;
using LoginRegConsole.Validations.Blog_Validations;
using NeedBlog = LoginRegConsole.Database.Models.Blog;

namespace LoginRegConsole.Validations.Blog
{
	public class GetExsistingApprovedBlog
	{
		public static NeedBlog Handle(NeedBlog blog)
		{
			BlogRepository blogRepository = new BlogRepository();

			do
			{
				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.NAME_REQUEST) + " " + "blog");
				string blogName = Console.ReadLine();
				blog = blogRepository.GetBy(b => b.Code == blogName);

				if (blog == null)
				{
					Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.BLOG_NOT_FOUND));

				}
				else if (blog.BlogStatus != Constants.Enums.BlogStatus.APPROVED)
				{
					Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.FORBIDDEN));
					blog = null;
				}

			} while (blog == null);


			return blog;


		}
	}
}
