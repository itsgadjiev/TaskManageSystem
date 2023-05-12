using LoginRegConsole.Constants.Enums;
using LoginRegConsole.Constants.InputOnLanguages;
using LoginRegConsole.Constants.Localisation;
using LoginRegConsole.Database.BaseModels;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Services;
using System.Reflection;

namespace LoginRegConsole.Database.Repositories
{
	public class BaseInputRepository : BaseRepository<BaseInput>
	{
		public BaseInputRepository()
			: base("BaseInputs.json") { }

		
	}
}
