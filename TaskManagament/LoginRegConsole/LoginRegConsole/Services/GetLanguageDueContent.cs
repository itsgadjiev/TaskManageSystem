using System.Reflection;

namespace LoginRegConsole.Services
{
	public class GetLanguageDueContent
	{
		public static string Handle(PropertyInfo propertyOfContent)
		{
			try
			{
				string languageName = propertyOfContent.Name.Substring(propertyOfContent.Name.Length - 2, 2);
				if (languageName != "EN" && languageName != "RU" && languageName != "AZ")
				{
					throw new Exception("System language not found");
				}
				return languageName;
			}
			catch
			{
				throw new Exception("System language not found");
			}
		}
	}
}
