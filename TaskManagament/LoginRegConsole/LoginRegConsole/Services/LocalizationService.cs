using LoginRegConsole.Constants.Enums;
using LoginRegConsole.Constants.InputOnLanguages;
using LoginRegConsole.Constants.Localisation;
using LoginRegConsole.Helper;
using System.Reflection;

namespace LoginRegConsole.Services
{
	public class LocalizationService
	{
		public static SystemLanguage CurrentLanguage = SystemLanguage.AZ;
		public static string? GetTranslationByKey(KeysForLanguages key)
		{
			Type inputsOnSYSLanguage = typeof(InputsOnSystemLanguages);

			FieldInfo field = inputsOnSYSLanguage
				.GetField(TemplateForLanguageSearch.VALUE_OF_LANGUAGE
							.Replace("{key}", key.ToString())
							.Replace("{currentLanguage}", CurrentLanguage.ToString()))!;

			return (string)field.GetValue(null);

		}

		public static PropertyInfo GetPropertyOfEntryByKey<TDomain>(KeysForLanguages key)
		{
			Type inputsOnSYSLanguage = typeof(TDomain);
			PropertyInfo property = inputsOnSYSLanguage
				.GetProperty(TemplateForLanguageSearch.VALUE_OF_LANGUAGE
							.Replace("{key}", key.ToString())
							.Replace("{currentLanguage}", CurrentLanguage.ToString()))!;

			return property;
		}
		public static FieldInfo GetFieldOfEntryByString<TDomain>(string key)
		{
			Type inputsOnSYSLanguage = typeof(TDomain);
			FieldInfo field = inputsOnSYSLanguage
				.GetField(TemplateForLanguageSearch.VALUE_OF_LANGUAGE
							.Replace("{key}", key)
							.Replace("{currentLanguage}", CurrentLanguage.ToString()))!;

			return field;
		}
		public static PropertyInfo[] GetPropertiesOfEntry<TDomain>(TDomain entry)
		{
			Type inputsOnSYSLanguage = typeof(TDomain);
			PropertyInfo[] property = inputsOnSYSLanguage.GetProperties()!;

			return property;
		}
		public static void ChangeLanguageOfSystem()
		{
			while (true)
			{
				Console.WriteLine(GetTranslationByKey(KeysForLanguages.LANGUAGE_CHANGE_OPTIONS));

				string option = CustomTryParseForOptions.Handle().ToString();
				switch (option)
				{
					case "1":
						CurrentLanguage = SystemLanguage.AZ;
						return;
					case "2":
						CurrentLanguage = SystemLanguage.RU;
						return;
					case "3":
						CurrentLanguage = SystemLanguage.EN;
						return;
					case "4":
						CurrentLanguage = SystemLanguage.CHN;
						return;
					default:
						break;
				}
			}
		}


	}
}



