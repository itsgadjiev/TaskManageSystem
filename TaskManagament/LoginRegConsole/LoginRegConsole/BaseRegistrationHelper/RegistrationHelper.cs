using LoginRegConsole.Services;
using LoginRegConsole.Validations.CommonValidations;
using LoginRegConsole.Validations.InputValidations;

namespace LoginRegConsole.BaseRegistrationHelper
{
	public class RegistrationHelper
	{
		public virtual string NameValidation()
		{
			string name = string.Empty;
			while (true)
			{
				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.NAME_REQUEST));
				name = Console.ReadLine();
				if (CommonValidation.IsLengthBeetween(InputLengthValidationsForMessage.MIN_LENGTH_NAME, InputLengthValidationsForMessage.MAX_LENGTH_NAME, name) == true)
				{
					return name;
				}
				Console.WriteLine($"{LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.INCORRECT_LENGTH)} {InputLengthValidationsForMessage.MIN_LENGTH_NAME} & {InputLengthValidationsForMessage.MAX_LENGTH_NAME} ");

			}
		}
		public virtual string SurnameValidation()
		{

			string surname = string.Empty;
			while (true)
			{
				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.SURNAME_REQUEST));
				surname = Console.ReadLine();

				if (CommonValidation.IsLengthBeetween(InputLengthValidationsForMessage.MİN_LENGTH_SURNAME, InputLengthValidationsForMessage.MAX_LENGTH_SURNAME, surname) == true)
				{
					return surname;
				}
				Console.WriteLine($"{LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.INCORRECT_LENGTH)} {InputLengthValidationsForMessage.MİN_LENGTH_SURNAME} & {InputLengthValidationsForMessage.MAX_LENGTH_SURNAME} ");
			}
		}
		public virtual string PasswordValidation()
		{
			string password = string.Empty;
			string passwordCheck = string.Empty;
			while (true)
			{
				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.PASSWORD_REQUEST));
				password = Console.ReadLine();

				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.PASSWORD_REQUEST_AGAIN));
				passwordCheck = Console.ReadLine();

				if (CommonValidation.PasswordValidation(password, passwordCheck) == true)
				{
					return password;
				}
				Console.WriteLine($"{password} != {passwordCheck}");

			}
		}
		public virtual string EmailValidation()
		{
			string eMail = string.Empty;
			while (true)
			{
				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.EMAIL_REQUEST));
				eMail = Console.ReadLine();
				bool check = false;
				if (CommonValidation.EmailValidation(eMail, ref check) == true)
				{
					return eMail;
				}
				else if (check == true)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine($"{eMail} {LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.EXSISTING_EMAIL)}");
					Console.ForegroundColor = ConsoleColor.White;

				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Format: { <(5-30 symbols)>@code.edu.az||yandex.com||gmail.com||code.edu.az||inbox.ru||rambler.ru}");
					Console.ForegroundColor = ConsoleColor.White;

				}
			}
		}
	}
}
