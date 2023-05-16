using LoginRegConsole.BaseRegistrationHelper;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Services;

namespace LoginRegConsole.Shared.Commands
{
	public class UpdateSettingsCommand
	{
		public UpdateSettingsCommand(RegistrationHelper registrationHelper)
		{
			RegistrationHelper = registrationHelper;
		}

		public RegistrationHelper RegistrationHelper { get; }

		public virtual void Handle()
		{
			UserRepository userRepository = new UserRepository();
			User user = userRepository.GetBy(x => x.Email == UserService.ActiveUser.Email);

			user.Name = RegistrationHelper.NameValidation();
			user.Surname = RegistrationHelper.SurnameValidation();
			user.Password = RegistrationHelper.PasswordValidation();

			userRepository.SaveChanges();
			CustomConsole.GreenLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.SUCCESSFULLY));
		}
		public virtual void HandleBYReflection()
		{
			UserRepository userRepository = new UserRepository();

			string name = RegistrationHelper.NameValidation();
			string lastName = RegistrationHelper.SurnameValidation();
			string password = RegistrationHelper.PasswordValidation();

			userRepository.UpdateSettings(userRepository.GetBy(u => u.Email == UserService.ActiveUser.Email), name, lastName, password);
			UserService.ActiveUser.Name= name;
			UserService.ActiveUser.Surname = lastName;
			UserService.ActiveUser.Password = password;

			CustomConsole.GreenLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.SUCCESSFULLY));
			Console.WriteLine(UserService.ActiveUser.ShowFullName());
		}
	}
}
