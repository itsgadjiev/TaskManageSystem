using System.Text;

namespace LoginRegConsole.Services
{
	public class ChangeEncodingTypeOfProject
	{
		public static void Handle()
		{
			Console.OutputEncoding = Encoding.UTF8;
			Console.InputEncoding = Encoding.UTF8;
		}
	}
}
