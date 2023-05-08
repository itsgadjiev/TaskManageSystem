using LoginRegConsole.Admin;
using LoginRegConsole.BaseRegistrationHelper;
using LoginRegConsole.Client;
using LoginRegConsole.Database;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Extras;
using LoginRegConsole.Helper;
using LoginRegConsole.Identity;
using LoginRegConsole.Services;
using System.Data;
using System.Text;
using System.Xml.Linq;

namespace LoginRegConsole
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Handle();
		}
		public static void Handle()
		{
			RegistrationHelper registrationHelper = new RegistrationHelper();
			RegisterCommand registerCommand = new RegisterCommand(registrationHelper);
			string choice = string.Empty;
			Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.INTRO_FOR_SYSTEM));
			Console.OutputEncoding = Encoding.UTF8;
			Console.InputEncoding = Encoding.UTF8;

			do
			{
				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.MAIN_SELECT_OPTIONS));
				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.CHOICE_OPTION));

				choice = Console.ReadLine()!;
				switch (choice)
				{
					case "1":
						UserService.ActiveUser = LoginCommand.Login();
						UserConditionChecker.Handle();
						break;

					case "2":
						registerCommand.Register();
						break;
					case "4":
						LocalizationService.ChangeLanguageOfSystem();
						break;
					default:
						break;
				}
			} while (choice != "3");

		}
	}





}








