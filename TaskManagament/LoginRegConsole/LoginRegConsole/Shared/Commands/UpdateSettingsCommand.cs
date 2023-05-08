using LoginRegConsole.BaseRegistrationHelper;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Extras;
using LoginRegConsole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			UserService.ActiveUser.Name = RegistrationHelper.NameValidation();
			UserService.ActiveUser.Surname = RegistrationHelper.SurnameValidation();
			UserService.ActiveUser.Password = RegistrationHelper.PasswordValidation();

            CustomConsole.GreenLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.SUCCESSFULLY));
        }
    }
}
