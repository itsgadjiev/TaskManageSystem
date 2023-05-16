using LoginRegConsole.Database.Repositories;

namespace LoginRegConsole.Services
{
	public class GenarateCodeForBlog
	{
		private readonly BlogRepository _blogRepository;
		private readonly Random _random;
		private const int MinNumber = 10000;
		private const int MaxNumber = 99999;

		public GenarateCodeForBlog(BlogRepository blogRepository)
		{
			_blogRepository = blogRepository;
			_random = new Random();
		}

		public string Handle()
		{
			string code = "BL" + _random.Next(MinNumber, MaxNumber).ToString();

			while (_blogRepository.GetAll().Any(blog => blog.Code == code))
			{
				code = "BL" + _random.Next(MinNumber, MaxNumber).ToString();
			}

			return code;
		}
	}
}
