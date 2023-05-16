using LoginRegConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Infrostructure
{
	public class CommandRouter
	{
		public static void Route<TCommand>()
			where TCommand : ICommandHandler
		{
			TCommand commandHandler = Activator.CreateInstance<TCommand>();
			commandHandler.Handle();
		}
	}
}
