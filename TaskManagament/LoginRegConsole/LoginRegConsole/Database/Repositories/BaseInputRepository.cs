using LoginRegConsole.Constants.RepositoryConstants;
using LoginRegConsole.Database.BaseModels;
using LoginRegConsole.Database.Models;

namespace LoginRegConsole.Database.Repositories
{
	public class BaseInputRepository : BaseRepository<BaseInput>
	{
		public BaseInputRepository()
			: base(JsonRepositoryNames.APP_BASE_INPUTS) { }


	}
}
