using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Services;

namespace LoginRegConsole.Admin.Commands.BlogManagament
{

	public class FindBlogById
	{
		private readonly BlogRepository _blogRepository;
		private readonly MessageService _messageService;

		public FindBlogById()
		{
			_blogRepository = new BlogRepository();
			_messageService = new MessageService();
		}

		public Blog Handle(int id)
		{
			foreach (Blog blog in _blogRepository.GetAllBy(b => b.Id == id))
			{
				return blog;
			}
			return null!;
		}
	}
}
