using LoginRegConsole.BaseRegistrationHelper;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Extras;
using LoginRegConsole.Services;
using LoginRegConsole.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Client.Commands
{
	public class UpdateSettingsForUserCommand : UpdateSettingsCommand
	{
		public UpdateSettingsForUserCommand(RegistrationHelper registartionHelperForUser)
			:base(new RegistartionHelperForUser()) 
		{

		}
		public override void Handle()
		{
			base.Handle();
		}

	}
}
