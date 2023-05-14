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
			PostingUser = postingUser;
			Content = content;
			PostingDate= DateTime.Now;	
		}

		public Blog Blog { get; set; }
		public string? BlogId { get; set; }
		public DateTime PostingDate { get; set; } = DateTime.Now;
		public User PostingUser { get; set; }
		public Content Content { get; set; }
	}
}
