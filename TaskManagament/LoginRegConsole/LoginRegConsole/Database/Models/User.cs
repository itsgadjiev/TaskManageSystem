using LoginRegConsole.Database.BaseModel;

namespace LoginRegConsole.Database.Models
{
	public class User : BaseEntity
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Role { get; set; }
		public bool IsActive { get; set; }
		public DateTime RegistrationDate { get; set; } = DateTime.Now;

		public User(string name, string surname, string email, string password, string role)
		{
			Id = Guid.NewGuid().ToString();
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
