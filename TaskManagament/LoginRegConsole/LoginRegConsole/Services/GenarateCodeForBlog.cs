namespace LoginRegConsole.Services
{
	public class GenarateCodeForBlog
	{
		public static string Handle()
		{
			Random random = new Random();
			int minNumber = 10000;
			int maxNumber = 99999;
			string code = string.Empty;
			return code = "BL" + random.Next(minNumber, maxNumber).ToString();
		}
	}
}
