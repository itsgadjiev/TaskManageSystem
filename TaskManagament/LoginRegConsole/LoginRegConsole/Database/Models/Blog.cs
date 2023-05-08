using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginRegConsole.Constants.Enums;
using LoginRegConsole.Database.BaseModel;

namespace LoginRegConsole.Database.Models
{
    public class Blog : BaseEntity
    {
        public User PostingUser { get; set; }
        protected static int _idCounter { get; set; }
        public string BlogTitle { get; set; }
        public string BlogBody { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime PostTime { get; set; }
        public BlogStatus BlogStatus { get; set; }
        public Blog(User user,string blogTitle, string blogBody)
        {
            PostingUser=user;
            Id = ++_idCounter;
            BlogTitle = blogTitle;
            BlogBody = blogBody;
            CreatedAt = DateTime.Now;
            BlogStatus = BlogStatus.WAITING;

        }
    }
}
