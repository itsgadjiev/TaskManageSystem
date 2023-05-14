using LoginRegConsole.Constants.Roles;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;

namespace LoginRegConsole.Database
{
	public abstract class AppDbContext
	{
		public static List<BaseInput> BaseInputs { get; set; } = new List<BaseInput>();
		
		static AppDbContext() { }


	}
}
