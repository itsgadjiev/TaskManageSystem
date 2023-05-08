using LoginRegConsole.Database.Repositories;
using LoginRegConsole.Extras;
using LoginRegConsole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Admin.Commands.BlogManagament
{
    public class ShowWaitingBlogs
    {
        public static void Handle()
        {
            BlogRepository blogRepository = new BlogRepository();
            int counter = 1;
            foreach (var blog in blogRepository.GetAllBy(b => b.BlogStatus == Constants.Enums.BlogStatus.WAITING))
            {
                CustomConsole.WarningLine($"{counter++}|| ID:{blog.Id} || Posted BY:{blog.PostingUser.Name} {blog.PostingUser.Surname} || Title:{blog.BlogTitle} || Body:{blog.BlogBody} || Creation date:{blog.CreatedAt}");
            }

            if (counter == 1)
            {
                CustomConsole.RedLine(LocalizationService.GetTranslationByKey(Constants.Enums.KeysForLanguages.NOT_FOUND));
            }

        }
    }
}
