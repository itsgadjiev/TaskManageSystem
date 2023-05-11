using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Constants.Message
{
    public class MessageTemplate
    {
        public const string APPROVED_BLOG_EN = $"Your Blog {MessageTemplateKeywords.BLOG_NAME} has been approved dear {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string REJECTED_BLOG_EN = $"Your Blog {MessageTemplateKeywords.BLOG_NAME} has been rejected dear {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string WAITING_BLOG_EN = $"Your Blog {MessageTemplateKeywords.BLOG_NAME} is on verification dear {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string APPROVED_BLOG_AZ = $"Sizin blog {MessageTemplateKeywords.BLOG_NAME} testiqlendi {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string REJECTED_BLOG_AZ = $"Sizin blog {MessageTemplateKeywords.BLOG_NAME} redd edildi {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string WAITING_BLOG_AZ = $"Sizin blog {MessageTemplateKeywords.BLOG_NAME} verifikasiyadadir {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string APPROVED_BLOG_RU = $"Ваш блог {MessageTemplateKeywords.BLOG_NAME} принят Дорогой {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string REJECTED_BLOG_RU = $"Ваш блог {MessageTemplateKeywords.BLOG_NAME} отклонён Дорогой {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string WAITING_BLOG_RU = $"Ваш блог {MessageTemplateKeywords.BLOG_NAME} на верификации Дорогой {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		

	}
}
