using LoginRegConsole.Constants.Enums;
using LoginRegConsole.Database.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Database.Models
{
	public class BaseInput : BaseEntity
	{
		public KeysForLanguages Key { get; set; }
		public string Value { get; set; }
		public SystemLanguage Language { get; set; }

		public BaseInput()
		{
			Id = Guid.NewGuid().ToString();
		}
	}
}
