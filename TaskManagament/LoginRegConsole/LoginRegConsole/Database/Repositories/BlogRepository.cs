using LoginRegConsole.Constants.RepositoryConstants;
using LoginRegConsole.Database.BaseModels;
using LoginRegConsole.Database.Models;

namespace LoginRegConsole.Database.Repositories
{
	public class BlogRepository : BaseRepository<Blog>
	{
		public BlogRepository()
			: base(JsonRepositoryNames.APP_BLOGS)
		{ }
	}
}
