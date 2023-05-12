using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginRegConsole.Constants.Enums;
using LoginRegConsole.Database.BaseModel;
using LoginRegConsole.Database.BaseModels;
using LoginRegConsole.Database.Models;

namespace LoginRegConsole.Database.Repositories
{
	public class BlogRepository : BaseRepository<Blog>
	{
		public BlogRepository() 
			: base("AppBlogs.json")
		{
		}
	}
}
