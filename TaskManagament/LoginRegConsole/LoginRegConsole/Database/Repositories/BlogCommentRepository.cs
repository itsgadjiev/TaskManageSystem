using LoginRegConsole.Database.BaseModels;
using LoginRegConsole.Database.Models;


namespace LoginRegConsole.Database.Repositories
{
	public class BlogCommentRepository : BaseRepository<BlogComment>
	{
		public BlogCommentRepository() 
			: base("BlogComments.json")
		{
			
		}
	}
}
