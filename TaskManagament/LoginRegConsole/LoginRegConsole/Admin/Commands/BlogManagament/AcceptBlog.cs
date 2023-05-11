using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using LoginRegConsole.Database;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Helper;
using LoginRegConsole.Services;

namespace LoginRegConsole.Admin.Commands.BlogManagament
{
	public class AcceptBlog
	{
		private readonly MessageService _messageService;

		public AcceptBlog()
		{
			_messageService = new MessageService();
		}
		public void Handle()
		{
			BlogRepository blogRepository = new BlogRepository();

			int id = CustomTryParseForOptions.Handle();
			Blog blog = blogRepository.GetBy(b=>b.Id==id);

			if (blog is null)
			{
				CustomConsole.RedLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.NOT_FOUND));
				return;
			}
			blog.BlogStatus = Constants.Enums.BlogStatus.APPROVED;
			blog.PostTime = DateTime.Now;
			_messageService.SendMessageForBlogDueStatus(blog);
			CustomConsole.GreenLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.SUCCESSFULLY));

		}
	}
}
