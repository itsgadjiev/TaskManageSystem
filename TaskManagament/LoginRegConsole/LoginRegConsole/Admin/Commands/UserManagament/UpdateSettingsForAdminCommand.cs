using LoginRegConsole.BaseRegistrationHelper;
using LoginRegConsole.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Admin.Commands.UserManagament
{
	public class UpdateSettingsForAdminCommand:UpdateSettingsCommand
	{
        public UpdateSettingsForAdminCommand() 
			: base(new RegistrationHelperForAdmin())
        {

        }

        public override void Handle()
		{
			base.Handle();
		}

	}
}
