using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Constants.Message
{
    public class MessageTemplate
    {
        public const string APPROVED_BLOG_EN = $"Your Blog has been approved dear {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string REJECTED_BLOG_EN = $"Your Blog has been rejected dear {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string WAITING_BLOG_EN = $"Your Blog is on verification dear {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string APPROVED_BLOG_AZ = $"Sizin blog testiqlendi {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string REJECTED_BLOG_AZ = $"Sizin blog redd edildi {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string WAITING_BLOG_AZ = $"Sizin blog verifikasiyadadir {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string APPROVED_BLOG_RU = $"Ваш блог принят Дорогой {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string REJECTED_BLOG_RU = $"Ваш блог отклонён Дорогой {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string WAITING_BLOG_RU = $"Ваш блог на верификации Дорогой {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		
		public const string SUCCESSFULLY_REGISTERED = $"Your account has successfully been registered ,Welcome!";
		public const string True = $"Your account were disbanned!";
		public const string False = $"Your account has successfully been banned!";
		public const string admin = $"You promoted to admin!";
		public const string user = $"You depromoted to user!";

	}
}
