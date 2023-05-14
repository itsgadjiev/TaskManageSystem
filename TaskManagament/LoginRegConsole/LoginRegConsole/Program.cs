using LoginRegConsole.BaseRegistrationHelper;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Helper;
using LoginRegConsole.Identity;
using LoginRegConsole.Services;
using LoginRegConsole.Shared.Commands;
using LoginRegConsole.Validations.CommonValidations;
using System.Text;

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
			Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.INTRO_FOR_SYSTEM));
			ChangeEncodingTypeOfProject.Handle();

			string choice = string.Empty;
			do
			{
				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.MAIN_SELECT_OPTIONS));
				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.CHOICE_OPTION));

				choice = Console.ReadLine()!;
				switch (choice)
				{
					case "1":
						CheckAndCreateAdmin.Handle();
						UserService.ActiveUser = LoginCommand.Login();
						UserConditionChecker.Handle();
						break;
					case "2":
						registerCommand.Register();
						break;
					case "4":
						LocalizationService.ChangeLanguageOfSystem();
						break;
					case "5":
						ShowBlogsWithComments.Handle();
						break;
					default:
						break;
				}
			} while (choice != "3");

		}
	}





}








