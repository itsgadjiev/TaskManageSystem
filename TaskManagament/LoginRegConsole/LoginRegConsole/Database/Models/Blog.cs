using LoginRegConsole.Constants.Enums;
using LoginRegConsole.Database.BaseModel;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Services;
using System.Reflection.Metadata;

namespace LoginRegConsole.Database.Models
{

    public class Blog : BaseEntity
	{
        public string Code { get; set; }
		public User PostingUser { get; set; }
		public Content Title { get; set; }
		public Content Body { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime PostTime { get; set; }
		public BlogStatus BlogStatus { get; set; }
		public Blog(User user, Content blogTitle, Content blogBody,string code)
		{
			PostingUser = user;
			Id = Guid.NewGuid().ToString();
			Title = blogTitle;
			Body = blogBody;
			CreatedAt = DateTime.Now;
			BlogStatus = BlogStatus.WAITING;
			Code = code;
		}
		public void ShowBlogInfo()
		{
            Console.WriteLine($"Code:{Code} CreatedAt:{CreatedAt}");
        }

		public string GetStatusOfBlog()
		{
			return BlogStatus.ToString();
		}
	}
}
