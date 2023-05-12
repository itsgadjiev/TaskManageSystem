﻿using LoginRegConsole.BaseRegistrationHelper;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Database.Repositories;
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
            UserRepository userRepository= new UserRepository();
            User user=userRepository.GetBy(x=>x.Email== UserService.ActiveUser.Email);
			user.Name = RegistrationHelper.NameValidation();
			user.Surname = RegistrationHelper.SurnameValidation();
			user.Password = RegistrationHelper.PasswordValidation();
			userRepository.SaveChanges();
			CustomConsole.GreenLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.SUCCESSFULLY));
        }
    }
}
