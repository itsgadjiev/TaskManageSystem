using LoginRegConsole.Database.BaseModel;

namespace LoginRegConsole.Database.Models
{
	public class Email : BaseEntity
	{
		public Content Content { get; set; }
		public DateTime SendTime { get; set; }
		public User SendingUser { get; set; }
		public User ReceivingUser { get; set; }

		public Email(Content content, User sendingUser, User receivingUser)
		{
			Id = Guid.NewGuid().ToString();
			Content = content;
			SendTime = DateTime.Now;
			SendingUser = sendingUser;
			ReceivingUser = receivingUser;
		}

	}
}
