using LoginRegConsole.Admin.Commands.BlogManagament;
using LoginRegConsole.Admin.Commands.MessageSending;
using LoginRegConsole.Admin.Commands.UserManagament;
using LoginRegConsole.BaseRegistrationHelper;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Identity;
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
			CustomConsole.GreenLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.ADMINDAHSBOARD_INTRO));

			UpdateSettingsForAdminCommand updateSettingsForAdminCommand = new UpdateSettingsForAdminCommand();
			string choice = string.Empty;
			UserRepository userRepository = new UserRepository();
			do
			{
				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.ADMINDASHBOARD));

				choice = Console.ReadLine();
				switch (choice)
				{
					case "1":
						ShowUsers.Handle();
						break;
					case "2":
						userRepository.RemoveUserById();
						break;
					case "3":
						PromoteToAdmin.Handle();
						break;
					case "4":
						DepromoteFromAdminCommand.Handle();
						break;
					case "5":
						updateSettingsForAdminCommand.Handle();
						break;
					case "6":
						userRepository.RemoveUserByEmail();
						break;
					case "7":
						BanUserCommand.Handle();
						break;
					case "8":
						DisBanUserCommand.Handle();
						break;
					case "9":
						SendEmailCommand.Handle();
						break;
					case "10":
						registerCommand.Register();
						break;
					case "11":
						ShowAcceptedBlogs.Handle();
						break;
					case "12":
						ShowWaitingBlogs.Handle();
						break;
					case "13":
						ShowRejectedBlogs.Handle();
						break;
					case "14":
						AcceptBlog acceptBlog = new AcceptBlog();
						acceptBlog.Handle();
						break;
					case "15":
						RejectBlog rejectBlog = new RejectBlog();
						rejectBlog.Handle();
						break;
					case "16":
						LocalizationService.ChangeLanguageOfSystem();
						break;
					default:
						break;
				}
			} while (choice != "0");
		}
	}
}
