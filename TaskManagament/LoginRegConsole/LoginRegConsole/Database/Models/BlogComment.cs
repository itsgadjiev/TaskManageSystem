using LoginRegConsole.Database.BaseModel;

namespace LoginRegConsole.Database.Models
{
	public class BlogComment : BaseEntity
	{
		private static int _idCounter;
		public BlogComment(Blog blog, User postingUser, Content content)
		{
			Id = ++_idCounter;
			Blog = blog;
			BlogId = blog.Id;
			PostingDate = DateTime.Now;
			PostingUser = postingUser;
			Content = content;
		}

		public Blog Blog { get; set; }
		public int? BlogId { get; set; }
		public DateTime PostingDate { get; set; }
		public User PostingUser { get; set; }
		public Content Content { get; set; }
	}
}
