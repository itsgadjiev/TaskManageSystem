using LoginRegConsole.Client.Commands;
using LoginRegConsole.Constants.Enums;
using LoginRegConsole.Extras;
using LoginRegConsole.Services;

namespace LoginRegConsole.Client
{
	internal class ClientDashboard
	{
		public static void Index()
		{
			RegistartionHelperForUser registartionHelperForUser = new RegistartionHelperForUser();
			UpdateSettingsForUserCommand updateSettingsForUser = new UpdateSettingsForUserCommand(registartionHelperForUser);

			CustomConsole.WarningLine(LocalizationService.GetTranslationByKey(KeysForLanguages.CLIENT_DASHBOARD_INTRO));
			string choice = string.Empty;
			do
			{
				Console.WriteLine(LocalizationService.GetTranslationByKey(KeysForLanguages.CLIENT_DASHBOARD_INDEX));

				Console.Write(LocalizationService.GetTranslationByKey(KeysForLanguages.CHOICE_OPTION));
				choice = Console.ReadLine();
				switch (choice)
				{
					case "1":
						updateSettingsForUser.Handle();
						break;
					case "2":
						CloseAccountCommand.Handle();
						return;
					case "3":
						ViewMessagesCommand.Handle();
						break;
					case "4":
						AddBlog addBlog = new AddBlog();
						addBlog.Handle();
						break;
					case "5":
						AddBlogComment addBlogComment = new AddBlogComment();
						addBlogComment.Handle();
						break;
					case "6":
						LocalizationService.ChangeLanguageOfSystem();
						break;
					default:
						break;
				}

			} while (choice != "0");
		}

	}
}
