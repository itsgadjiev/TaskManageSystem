using LoginRegConsole.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Services
{
	public class RetunFieldNameOfMessageTempalateBlogCommentEmail
	{
		public static string Handle(PropertyInfo propertyInfo)
		{
			return MessageTemplateKeywords.BLOG_COMMENT_SENDED_ + GetLanguageDueContent.Handle(propertyInfo);
		}
	}
}
