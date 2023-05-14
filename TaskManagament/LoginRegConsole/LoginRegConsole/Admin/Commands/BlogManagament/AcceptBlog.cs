using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Services;
using LoginRegConsole.Validations.Blog_Validations;

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
			Blog blog = GetExsistingBlog.Handle();
			if (blog is null)
			{
				CustomConsole.RedLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.NOT_FOUND));
				return;
			}
			Blog neededBlog = blogRepository.GetBy(b => b.Id == blog.Id);


			neededBlog.BlogStatus = Constants.Enums.BlogStatus.APPROVED;
			neededBlog.PostTime = DateTime.Now;
			_messageService.SendMessageForBlogDueStatus(neededBlog);
			MessageService.SendMessageDueStatusForBlogIRL(neededBlog);
			blogRepository.SaveChanges();
			CustomConsole.GreenLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.SUCCESSFULLY));

		}
	}
}
