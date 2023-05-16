using LoginRegConsole.Constants;
using LoginRegConsole.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Services
{
	public class RetunFieldNameOfMessageTempalateBlogEmail
	{
		public static string Handle(Blog blog,PropertyInfo propertyOfContent)
		{
			return blog.GetStatusOfBlog() + MessageTemplateKeywords._BLOG_ + GetLanguageDueContent.Handle(propertyOfContent);
		}
	}
}
