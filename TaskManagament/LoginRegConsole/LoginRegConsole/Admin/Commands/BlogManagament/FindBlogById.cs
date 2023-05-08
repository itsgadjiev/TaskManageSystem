using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
