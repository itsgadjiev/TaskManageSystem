using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Helper;
using LoginRegConsole.Services;
using LoginRegConsole.Validations.Blog_Validations;

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
			BlogRepository blogRepository = new BlogRepository();
			Blog blog = GetExsistingBlog.Handle();
			if (blog is null)
			{
				CustomConsole.RedLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.NOT_FOUND));
				return;
			}
			Blog neededBlog = blogRepository.GetBy(b => b.Id == blog.Id);
			blogRepository.Update(neededBlog, b => b.BlogStatus = Constants.Enums.BlogStatus.REJECTED);
			_messageService.SendMessageForBlogDueStatus(neededBlog);
			MessageService.SendMessageDueStatusForBlogIRL(neededBlog);
			CustomConsole.GreenLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.SUCCESSFULLY));

		}
	}
}
