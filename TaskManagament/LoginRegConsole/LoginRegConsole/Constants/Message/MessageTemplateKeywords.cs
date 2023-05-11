using LoginRegConsole.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LoginRegConsole.Constants
{
    public class MessageTemplateKeywords
    {
        public const string BLOG_STATUS = "{status}";
        public const string USER_NAME_FOR_BLOG = "{user-name}";
        public const string USER_SURNAME_FOR_BLOG = "{user-surname}";
        public const string BLOG_NAME = "{blog-name}";
    }
}
