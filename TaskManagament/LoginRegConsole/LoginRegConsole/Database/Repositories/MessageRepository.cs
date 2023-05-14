using LoginRegConsole.Constants.RepositoryConstants;
using LoginRegConsole.Database.BaseModels;
using LoginRegConsole.Database.Models;

namespace LoginRegConsole.Database.Repositories
{
	public class MessageRepository : BaseRepository<Email>
	{
		public MessageRepository()
			: base(JsonRepositoryNames.APP_MESSAGES)
		{
		}


	}
}
