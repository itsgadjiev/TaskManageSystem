using LoginRegConsole.Database.BaseModels;
using LoginRegConsole.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Database.Repositories
{
	public class BlogCommentRepository : BaseRepository<BlogComment>
	{
		public BlogCommentRepository() 
			: base(AppDbContext.BlogComments)
		{
		}
	}
}
