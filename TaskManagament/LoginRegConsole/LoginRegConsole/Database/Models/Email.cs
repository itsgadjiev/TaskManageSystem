using LoginRegConsole.Database.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Database.Models
{
	public class Email : BaseEntity
	{
		protected static int _idCounter { get; set; }
		public Content Content { get; set; }
        public string Mypprop { get; set; }
        public DateTime SendTime { get; set; }
		public User SendingUser { get; set; }
		public User ReceivingUser { get; set; }

		public Email(Content content, User sendingUser, User receivingUser)
		{
			Id = ++_idCounter;
			Content = content;
			SendTime = DateTime.Now;
			SendingUser = sendingUser;
			ReceivingUser = receivingUser;
		}

		public Email(string content, User sendingUser, User receivingUser)
		{
			Id = ++_idCounter;
			Mypprop = content;
			SendTime = DateTime.Now;
			SendingUser = sendingUser;
			ReceivingUser = receivingUser;
		}
	}
}
