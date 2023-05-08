using LoginRegConsole.Database.Models;
using LoginRegConsole.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginRegConsole.Extras;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.BaseRegistrationHelper;
using LoginRegConsole.Client;
using LoginRegConsole.Constants.Roles;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;

namespace LoginRegConsole.Identity
{
	public class RegisterCommand
	{
		public RegisterCommand(RegistrationHelper registrationHelper)
		{
			RegistrationHelper = registrationHelper;
		}

		public RegistrationHelper RegistrationHelper { get; }

		public void Register()
		{
			UserRepository userRepository = new UserRepository();

			string name = RegistrationHelper.NameValidation();
			string surname = RegistrationHelper.SurnameValidation();
			string password = RegistrationHelper.PasswordValidation();
			string eMail = RegistrationHelper.EmailValidation();

			User user = new User(name, surname, eMail, password, UserRoles.USER);
			//string path = "C:\\Users\\Jake\\Desktop\\Person.xml";
			//Stream stream = new FileStream(path, FileMode.Append);

			//XmlSerializer xmlSerializer = new XmlSerializer(typeof(User));
			//xmlSerializer.Serialize(stream, user);
			
			//stream.Close();

			//XmlDocument doc = new XmlDocument();
			//doc.Load("C:\\Users\\Jake\\Desktop\\Person.xml");

			//XmlElement root = doc.DocumentElement;

			//foreach (XmlNode node in root.ChildNodes) 
			//{
			//	XmlNode xmlNode = node.SelectSingleNode("Name");
   //         }


			CustomConsole.GreenLine($"{user.Name} {user.Surname} Successfully registered at {user.RegistrationDate.ToString("f")}");
			userRepository.Add(user);

		}

	}
}
