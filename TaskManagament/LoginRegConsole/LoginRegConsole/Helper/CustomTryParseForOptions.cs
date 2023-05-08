using LoginRegConsole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Helper
{
	public static class CustomTryParseForOptions
	{
		public static int Handle()
		{
			int id = 0;
			while (true)
			{
				Console.WriteLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.ID_REQUEST));
				bool parsedInt = int.TryParse(Console.ReadLine(), out id);
				if (parsedInt)
				{
					return id;
				}
			}

		}
	}
}
