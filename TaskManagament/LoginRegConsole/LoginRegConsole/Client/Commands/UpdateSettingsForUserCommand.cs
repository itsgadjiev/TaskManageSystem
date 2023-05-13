using LoginRegConsole.BaseRegistrationHelper;
using LoginRegConsole.Shared.Commands;

namespace LoginRegConsole.Client.Commands
{
	public class UpdateSettingsForUserCommand : UpdateSettingsCommand
	{
		public UpdateSettingsForUserCommand(RegistrationHelper registartionHelperForUser)
			: base(new RegistartionHelperForUser())
		{

		}
		public override void Handle()
		{
			base.Handle();
		}

	}
}
