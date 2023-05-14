using LoginRegConsole.Constants.Roles;
using LoginRegConsole.Database.Repositories;

namespace LoginRegConsole.Validations.CommonValidations
{
	public class CheckAndCreateAdmin
	{
		public static void Handle()
		{
			UserRepository userRepository = new UserRepository();
			if (userRepository.GetBy(u => u.Email == UserRoles.ADMIN_EMAIL) is null)
			{
				UserRepository.AdminCreationSeed();
			}

		}
	}
}
