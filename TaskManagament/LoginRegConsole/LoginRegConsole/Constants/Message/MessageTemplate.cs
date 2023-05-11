using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Constants.Message
{
    public class MessageTemplate
    {
        public const string APPROVED_BLOG_EN = $"Your Blog {MessageTemplateKeywords.BLOG_CODE} has been approved dear {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string REJECTED_BLOG_EN = $"Your Blog {MessageTemplateKeywords.BLOG_CODE} has been rejected dear {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string WAITING_BLOG_EN = $"Your Blog {MessageTemplateKeywords.BLOG_CODE} is on verification dear {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string APPROVED_BLOG_AZ = $"Sizin blog {MessageTemplateKeywords.BLOG_CODE} testiqlendi {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string REJECTED_BLOG_AZ = $"Sizin blog {MessageTemplateKeywords.BLOG_CODE} redd edildi {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string WAITING_BLOG_AZ = $"Sizin blog {MessageTemplateKeywords.BLOG_CODE} verifikasiyadadir {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string APPROVED_BLOG_RU = $"Ваш блог {MessageTemplateKeywords.BLOG_CODE} принят Дорогой {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string REJECTED_BLOG_RU = $"Ваш блог {MessageTemplateKeywords.BLOG_CODE} отклонён Дорогой {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string WAITING_BLOG_RU = $"Ваш блог {MessageTemplateKeywords.BLOG_CODE} на верификации Дорогой {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} || status:{MessageTemplateKeywords.BLOG_STATUS}";
		public const string BLOG_COMMENT_SENDED_AZ = $"{MessageTemplateKeywords.BLOG_CODE} kodlu blogunuza {MessageTemplateKeywords.USER_NAME_FOR_BLOG} {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} tərəfindən comment əlavə olundu ";
		public const string BLOG_COMMENT_SENDED_RU = $"На ваш блог под кодом {MessageTemplateKeywords.BLOG_CODE} был добавлен комент от {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} ";
		public const string BLOG_COMMENT_SENDED_EN = $" {MessageTemplateKeywords.USER_NAME_FOR_BLOG} , {MessageTemplateKeywords.USER_SURNAME_FOR_BLOG} commented your blog under code {MessageTemplateKeywords.BLOG_CODE} ";
		

	}
}
