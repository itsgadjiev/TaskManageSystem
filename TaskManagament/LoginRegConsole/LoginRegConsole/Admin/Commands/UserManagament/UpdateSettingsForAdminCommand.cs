using LoginRegConsole.Admin.Commands.Helper;
using LoginRegConsole.Shared.Commands;

namespace LoginRegConsole.Admin.Commands.UserManagament
{
	public class UpdateSettingsForAdminCommand : UpdateSettingsCommand
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
