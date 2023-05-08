using LoginRegConsole.Database.BaseModels;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Extras;
using LoginRegConsole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Database.Repositories
{
	public class MessageRepository : BaseRepository<Email>
	{
		public MessageRepository() 
			: base(AppDbContext.Messages)
		{
		}

		
	}
}
