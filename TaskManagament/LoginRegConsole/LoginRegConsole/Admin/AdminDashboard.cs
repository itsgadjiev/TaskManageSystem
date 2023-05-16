using LoginRegConsole.Admin.Commands.BlogManagament;
using LoginRegConsole.Admin.Commands.MessageSending;
using LoginRegConsole.Admin.Commands.UserManagament;
using LoginRegConsole.BaseRegistrationHelper;
using LoginRegConsole.Constants.Enums;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Identity;
using LoginRegConsole.Infrostructure;
using LoginRegConsole.Services;

namespace LoginRegConsole.Admin
{
	public class AdminDashboard
	{
		private readonly RegistrationHelper _registrationHelper;

		public AdminDashboard()
		{
			_registrationHelper = new RegistrationHelper();
		}
		public static void Index()
		{
			RegistrationHelper registrationHelper = new RegistrationHelper();
			RegisterCommand registerCommand = new RegisterCommand(registrationHelper);
			CustomConsole.GreenLine(LocalizationService.GetTranslationByKey(KeysForLanguages.ADMINDAHSBOARD_INTRO));

			UpdateSettingsForAdminCommand updateSettingsForAdminCommand = new UpdateSettingsForAdminCommand();
			string choice = string.Empty;
			UserRepository userRepository = new UserRepository();
			do
			{
				Console.WriteLine(LocalizationService.GetTranslationByKey(KeysForLanguages.ADMINDASHBOARD));

				choice = Console.ReadLine();
				switch (choice)
				{
					case "1":
						CommandRouter.Route<ShowUsers>();
						break;
					case "2":
						userRepository.RemoveUserById();
						break;
					case "3":
						CommandRouter.Route<PromoteToAdmin>();
						break;
					case "4":
						CommandRouter.Route<DepromoteFromAdminCommand>();
						break;
					case "5":
						updateSettingsForAdminCommand.Handle();
						break;
					case "6":
						userRepository.RemoveUserByEmail();
						break;
					case "7":
						CommandRouter.Route<BanUserCommand>();
						break;
					case "8":
						CommandRouter.Route<DisBanUserCommand>();
						break;
					case "9":
						CommandRouter.Route<SendEmailCommand>();
						break;
					case "10":
						registerCommand.Register();
						break;
					case "11":
						ShowBlogsDueStatus.Handle(BlogStatus.APPROVED);
						break;
					case "12":
						ShowBlogsDueStatus.Handle(BlogStatus.WAITING);
						break;
					case "13":
						ShowBlogsDueStatus.Handle(BlogStatus.REJECTED);
						break;
					case "14":
						CommandRouter.Route<AcceptBlog>();
						break;
					case "15":
						CommandRouter.Route<RejectBlog>();
						break;
					case "16":
						LocalizationService.ChangeLanguageOfSystem();
						break;
					default:
						break; ;
				}
			} while (choice != "0");
		}
	}
}
