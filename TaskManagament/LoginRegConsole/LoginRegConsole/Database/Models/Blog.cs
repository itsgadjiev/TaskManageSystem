using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LoginRegConsole.Constants.Enums;
using LoginRegConsole.Database.BaseModel;

namespace LoginRegConsole.Database.Models
{
	public class Blog : BaseEntity
	{
		private string _code;
		public string Code
		{
			get { return _code; }
			set
			{
				Random random = new Random();
				int minNumber = 10000;
				int maxNumber = 99999;
				_code = "BL" + random.Next(minNumber, maxNumber).ToString();
			}
		}
		public User PostingUser { get; set; }
		protected static int _idCounter { get; set; }
		public Content Title { get; set; }
		public Content Body { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime PostTime { get; set; }
		public BlogStatus BlogStatus { get; set; }
		public Blog(User user, Content blogTitle, Content blogBody)
		{
			PostingUser = user;
			Id = ++_idCounter;
			Title = blogTitle;
			Body = blogBody;
			CreatedAt = DateTime.Now;
			BlogStatus = BlogStatus.WAITING;
			PostTime = DateTime.Now;
			Code = _code;
		}
		public List<BlogComment>? BlogComments { get; set; }
	}
}
