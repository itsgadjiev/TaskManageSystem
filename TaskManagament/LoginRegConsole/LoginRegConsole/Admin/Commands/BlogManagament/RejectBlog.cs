using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Helper;
using LoginRegConsole.Services;

namespace LoginRegConsole.Admin.Commands.BlogManagament
{
    public class RejectBlog
    {
		private readonly MessageService _messageService;

		public RejectBlog()
		{
			_messageService = new MessageService();
		}
		public void Handle()
		{

			FindBlogById findBlogById = new FindBlogById();

			int id = CustomTryParseForOptions.Handle();
			Blog blog = findBlogById.Handle(id);

			if (blog is null)
			{
				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.NOT_FOUND));
				return;
			}
			blog.BlogStatus = Constants.Enums.BlogStatus.REJECTED;
			_messageService.SendMessageForBlogDueStatus(blog);
			CustomConsole.GreenLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.SUCCESSFULLY));


		}
	}
}
