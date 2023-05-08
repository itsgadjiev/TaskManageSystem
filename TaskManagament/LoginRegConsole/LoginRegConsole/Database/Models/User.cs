using LoginRegConsole.Database.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Database.Models
{
	public class User : BaseEntity
	{

        protected static int _idCounter { get; set; }
        public string Name { get; set; }
		public string Surname { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Role { get; set; }
		public bool IsActive { get; set; }
		public DateTime RegistrationDate { get; set; } = DateTime.Now;

		public User(string name, string surname, string email, string password, string role)
		{
			Id = ++_idCounter;
			Name = name;
			Surname = surname;
			Email = email;
			Password = password;
			Role = role;
			IsActive = true;
			RegistrationDate = RegistrationDate;
		}

        public User()
        {
            
        }
        public string ShowFullName()
		{
			return $"{Name} {Surname}";
		}
		public bool IsAdmin()
		{
			if (Role == "admin")
			{
				return true;
			}
			return false;
		}
	}
}
