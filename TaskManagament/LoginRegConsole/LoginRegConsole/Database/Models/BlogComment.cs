using LoginRegConsole.Database.BaseModel;

namespace LoginRegConsole.Database.Models
{
	public class BlogComment : BaseEntity
	{
		
		public BlogComment(Blog blog, User postingUser, Content content)
		{
			Id = Guid.NewGuid().ToString();
			Blog = blog;
			BlogId = blog.Id;
			PostingDate = DateTime.Now;
			PostingUser = postingUser;
			Content = content;
		}

		public Blog Blog { get; set; }
		public string? BlogId { get; set; }
		public DateTime PostingDate { get; set; }
		public User PostingUser { get; set; }
		public Content Content { get; set; }
	}
}
