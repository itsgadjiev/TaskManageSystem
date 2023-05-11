using LoginRegConsole.Constants.Enums;
using LoginRegConsole.Database.Models;
using LoginRegConsole.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Constants.InputOnLanguages
{
	public class InputsOnSystemLanguages
	{
		public const string CHOICE_OPTION_AZ = "Sizin sechim:";
		public const string SUCCESFULL_ADDING_AZ = "Ugurla elave olundu";
		public const string NOT_FOUND_AZ = "Tapilmadi";
		public const string ADMINDAHSBOARD_INTRO_AZ = "Yeniden xosh gelmisiniz eziz ";
		public const string INTRO_FOR_SYSTEM_AZ = "login/register appina xosh gelmisiniz";

		public const string ADMINDASHBOARD_AZ = "Ne etmek isteyirsiz?\n" +
			   "1-Butun Userleri goster\n" +
			   "2-Useri id-sine gore sil\n" +
			   "3-Useri Admin ele\n" +
			   "4-Admini user ele\n" +
			   "5-Shexsi Melumati deyishdir\n" +
			   "6-Useri email-ne gore sil\n" +
			   "7-Ban user\n" +
			   "8-Disban user\n" +
			   "9-Mesaj gonder\n" +
			   "10-Yeni istifadeci Register ele\n" +
			   "11-Qebul olunmush bloglari goster\n" +
			   "12-Gozlemede olan bloglari goster\n" +
			   "13-Redd edilmish bloglari goster\n" +
			   "14-Blogu İd-sine gore qebul et\n" +
			   "15-Blogu İd-sine gore redd ele\n" +
			   "16-Sistemin Dilini Deyishdir\n" +
			   "0-Logout";


		public const string LANGUAGE_CHANGE_OPTIONS_AZ = "Hansi dile kechmek isteyirsiniz\n" +
					"1-Aze\n" +
					"2-Rus\n" +
					"3-Eng\n" +
					"4-Chin";

		public const string BLOG_NOT_FOUND_AZ = $"Bele blog yoxdur";
		public const string INVALID_LOG_OR_PASS_AZ = $"Login ve ya parol sehvdir";
		public const string INVALID_EMAIL_AZ = "Bele email yoxdur";
		public const string INVALID_PASSWORD_AZ = "Sehv parol";
		public const string ALREADY_BANNED_ACCOUNT_AZ = "Hesab bandadir";
		public const string ADMIN_CANT_BE_BANNED_AZ = "Admini banlaya bilmezsiniz";
		public const string SUCCESFULL_BANNED_USER_AZ = "User ugurla banlandi!";
		public const string BLOG_BODY_INPUT_AZ = "Zehmet olmada megzi daxil edin";
		public const string BLOG_TITLE_INPUT_AZ = "Zehmet olmada blogun bashligini yazin";
		public const string INCORRECT_LENGTH_AZ = "Uzunluq yalnishdir";
		public const string EMAIL_REQUEST_AZ = "Emaili daxil edin";
		public const string EXSISTING_EMAIL_AZ = "bele Email var";
		public const string NAME_REQUEST_AZ = "Ad daxil edin";
		public const string SURNAME_REQUEST_AZ = "Soyadinizi daxil edin";
		public const string PASSWORD_REQUEST_AGAIN_AZ = "Parolunuzu tezden daxil edin";
		public const string PASSWORD_REQUEST_AZ = "Parolunuzu daxil edin";
		public const string ADMIN_CANT_BE_REMOVED_AZ = "Admin siline bilmez";
		public const string ENTER_CORECT_FORMAT_AZ = "Duzgun daxil edin";
		public const string SUCCESFULLY_DELETED_AZ = "Ugurla silindi";
		public const string ID_REQUEST_AZ = "Id ni daxil edin";
		public const string ALREADY_ADMIN_AZ = "Admindir";
		public const string ALREADY_USER_AZ = "Userdir";
		public const string PROMOTED_TO_ADMIN_AZ = "Admin oldu";
		public const string DEPROMOTE_FROM_ADMIN_AZ = "User oldu";
		public const string FORBIDDEN_AZ = "Olmaz!!";
		public const string SUCCESSFULLY_AZ = "Ugurla edildi!!";
		public const string MESSAGE_SENDED_AZ = "Ugurla gonderildi!!";
		public const string CLIENT_DASHBOARD_INTRO_AZ = "Xosh gelmisiniz";
		public const string CLIENT_DASHBOARD_INDEX_AZ = "Ne elemek isteyirsiniz\n" +
					   "1-Shexsi Melumati deyishdir\n" +
					   "2-Hesabi Bagla\n" +
					   "3-Mesajlara bax!\n" +
					   "4-Blog elave et\n" +
					   "5-Bloga comment yaz\n" +
					   "6-Sistemin Dilini Deyishdir\n" +
					   "0-Cixish";

		public const string MAIN_SELECT_OPTIONS_AZ = "Ne elemek isteyirsiniz\n" +
					"1-Login\n" +
					"2-Register\n" +
					"3-Cixish\n" +
					"4-Dili deyish\n" +
					"5-Butun testiq edilmihs Bloglarin commentleri goster";

		public const string CHOICE_OPTION_CHN = "你的选择：";
		public const string SUCCESFULL_ADDING_CHN = "添加成功";
		public const string NOT_FOUND_CHN = "未找到";
		public const string ADMINDAHSBOARD_INTRO_CHN = "欢迎回到管理员仪表板，亲爱的";
		public const string INTRO_FOR_SYSTEM_CHN = "欢迎来到用户登录/注册应用程序";
		public const string ADMINDASHBOARD_CHN = "你想做什么？\n" +
				"1-显示所有用户\n" +
				"2-按Id删除用户\n" +
				"3-提升为管理员\n" +
				"4-取消管理员权限\n" +
				"5-更新设置\n" +
				"6-按电子邮件删除用户\n" +
				"7-封禁用户\n" +
				"8-解禁用户\n" +
				"9-发送消息\n" +
				"10-注册新用户\n" +
				"11-显示已接受的博客\n" +
				"12-显示等待中的博客\n" +
				"13-显示被拒绝的博客\n" +
				"14-按Id接受博客\n" +
				"15-按Id拒绝博客\n" +
				"16-更改系统语言\n" +
				"0-登出";

		public const string LANGUAGE_CHANGE_OPTIONS_CHN = "你想切换到哪种语言\n" +
				"1-阿兹\n" +
				"2-俄语\n" +
				"3-英语\n" +
				"4-中国人";

		public const string BLOG_NOT_FOUND_CHN = $"找不到博客";
		public const string INVALID_LOG_OR_PASS_CHN = $"登录名或密码错误";
		public const string INVALID_EMAIL_CHN = "无效的电子邮件";
		public const string INVALID_PASSWORD_CHN = "无效的密码";
		public const string ALREADY_BANNED_ACCOUNT_CHN = "已被封禁的账户";
		public const string ADMIN_CANT_BE_BANNED_CHN = "您不能封禁管理员";
		public const string SUCCESFULL_BANNED_USER_CHN = "用户已成功被封禁！";
		public const string BLOG_BODY_INPUT_CHN = "请输入正文";
		public const string BLOG_TITLE_INPUT_CHN = "请输入博客标题";
		public const string INCORRECT_LENGTH_CHN = "长度不正确";
		public const string EMAIL_REQUEST_CHN = "请输入电子邮件";
		public const string EXSISTING_EMAIL_CHN = "电子邮件已存在";
		public const string NAME_REQUEST_CHN = "请输入名字";
		public const string SURNAME_REQUEST_CHN = "请输入姓氏";
		public const string PASSWORD_REQUEST_CHN = "请输入密码";
		public const string PASSWORD_REQUEST_AGAIN_CHN = "请再次输入密码";
		public const string ADMIN_CANT_BE_REMOVED_CHN = "管理员无法被删除";
		public const string ENTER_CORECT_FORMAT_CHN = "以正确的格式输入";
		public const string SUCCESFULLY_DELETED_CHN = "已成功删除";
		public const string ID_REQUEST_CHN = "请输入ID";
		public const string ALREADY_ADMIN_CHN = "已经是管理员";
		public const string ALREADY_USER_CHN = "已经是用户";
		public const string PROMOTED_TO_ADMIN_CHN = "现在是管理员";
		public const string DEPROMOTE_FROM_ADMIN_CHN = "现在是用户";
		public const string FORBIDDEN_CHN = "禁止访问!!";
		public const string SUCCESSFULLY_CHN = "操作成功!!";
		public const string MESSAGE_SENDED_CHN = "发送成功!!";
		public const string CLIENT_DASHBOARD_INTRO_CHN = "欢迎回来";
		public const string CLIENT_DASHBOARD_INDEX_CHN = "您想做什么？\n" +
				   "1-更新设置\n" +
				   "2-关闭账户\n" +
				   "3-查看消息\n" +
				   "4-添加博客\n" +
				   "0-退出登录";

		public const string MAIN_SELECT_OPTIONS_CHN = "您想做什么\n" +
				"1-登录\n" +
				"2-注册\n" +
				"3-退出\n" +
				"4-更改语言";


		public const string CHOICE_OPTION_EN = "Your choice:";
		public const string SUCCESFULL_ADDING_EN = "Successfully added";
		public const string NOT_FOUND_EN = "Not found";
		public const string ADMINDAHSBOARD_INTRO_EN = "Welcome back to Admin Dashboard dear ";
		public const string INTRO_FOR_SYSTEM_EN = "Welcome to user login/register app";
		public const string ADMINDASHBOARD_EN = "What you want to do?\n" +
			   "1-Show All Users\n" +
			   "2-Remove User by Id\n" +
			   "3-Promote to Admin\n" +
			   "4-Depromote from Admin\n" +
			   "5-Update settings\n" +
			   "6-Remove user by Email\n" +
			   "7-Ban user\n" +
			   "8-Disban user\n" +
			   "9-Send Message\n" +
			   "10-Register new User\n" +
			   "11-Show Accepted Blogs\n" +
			   "12-Show Waiting Blogs\n" +
			   "13-Show Rejected Blogs\n" +
			   "14-Accept Blog by Id\n" +
			   "15-Reject Blog by Id\n" +
			   "16-Change System Language\n" +
			   "0-Logout";

		public const string LANGUAGE_CHANGE_OPTIONS_EN = "To witch language you want to change\n" +
					"1-Aze\n" +
					"2-Rus\n" +
					"3-Eng\n" +
					"4-Chinese";

		public const string BLOG_NOT_FOUND_EN = $"There is no blog";
		public const string INVALID_LOG_OR_PASS_EN = $"Login or password is wrong";
		public const string INVALID_EMAIL_EN = "Invalid email";
		public const string INVALID_PASSWORD_EN = "Invalid password";
		public const string ALREADY_BANNED_ACCOUNT_EN = "Alredy banned account";
		public const string ADMIN_CANT_BE_BANNED_EN = "You can't ban an admin";
		public const string SUCCESFULL_BANNED_USER_EN = "User has successfully been BANNED!";
		public const string BLOG_BODY_INPUT_EN = "Please enter the Body";
		public const string BLOG_TITLE_INPUT_EN = "Please enter blog title";
		public const string INCORRECT_LENGTH_EN = "Incorrect length";
		public const string EMAIL_REQUEST_EN = "Please enter Email";
		public const string EXSISTING_EMAIL_EN = "Email exsists";
		public const string NAME_REQUEST_EN = "Please enter Name";
		public const string SURNAME_REQUEST_EN = "Please enter Surname";
		public const string PASSWORD_REQUEST_EN = "Please enter the password";
		public const string PASSWORD_REQUEST_AGAIN_EN = "Please enter the again password";
		public const string ADMIN_CANT_BE_REMOVED_EN = "Admin cant be removed";
		public const string ENTER_CORECT_FORMAT_EN = "Enter in correct format";
		public const string SUCCESFULLY_DELETED_EN = "Succesfully deleted";
		public const string ID_REQUEST_EN = "Enter the id";
		public const string ALREADY_ADMIN_EN = "Already admin";
		public const string ALREADY_USER_EN = "Already user";
		public const string PROMOTED_TO_ADMIN_EN = "is now admin";
		public const string DEPROMOTE_FROM_ADMIN_EN = "is now user";
		public const string FORBIDDEN_EN = "FORBIDDEN!!";
		public const string SUCCESSFULLY_EN = "SUCCESSFULLY DONE!!";
		public const string MESSAGE_SENDED_EN = "SUCCESSFULLY sended!!";
		public const string CLIENT_DASHBOARD_INTRO_EN = "Welcome back";
		public const string CLIENT_DASHBOARD_INDEX_EN = "What you want to do?\n" +
					"1-Update settings\n" +
					"2-Close Account\n" +
					"3-View Messages\n" +
					"4-Add Blog\n" +
					"5-Add comment to the Blog\n" +
					"6-Change Language\n" +
					"0-Log out";

		public const string MAIN_SELECT_OPTIONS_EN = "What you want to do\n" +
					"1-Login\n" +
					"2-Register\n" +
					"3-Exit\n" +
					"4-Change Language\n" +
					"5-Show all accepted blogs with comments";


		public const string CHOICE_OPTION_RU = "Ваш выбор:";
		public const string SUCCESFULL_ADDING_RU = "Успешно добавлено";
		public const string NOT_FOUND_RU = "Не найдено";
		public const string ADMINDAHSBOARD_INTRO_RU = "Добро пожаловать вновь уважаемый ";
		public const string INTRO_FOR_SYSTEM_RU = "Добро пожаловать login/register app";
		public const string ADMINDASHBOARD_RU = "Что хотите сделать?\n" +
			   "1-Показать всех участников\n" +
			   "2-Удалить пользователья по ID\n" +
			   "3-Повышить до администратора\n" +
			   "4-Понизить до Member\n" +
			   "5-Редактировать Данные\n" +
			   "6-Удалит по Email\n" +
			   "7-Забанить userа\n" +
			   "8-Дизбанить userа\n" +
			   "9-Отправить сообщение\n" +
			   "10-Зарегистрировать нового Userа\n" +
			   "11-Показать принятые Блоги\n" +
			   "12-Показать блоги на ожидании\n" +
			   "13-Показать отменённые блоги\n" +
			   "14-Принять блог по Id\n" +
			   "15-Отменить Blog по Id\n" +
			   "16-Сметить язык системы\n" +
			   "0-Выйти из системы";

		public const string BLOG_NOT_FOUND_RU = $"Такого блога нету";
		public const string INVALID_EMAIL_RU = "Такого емеила нету";
		public const string INVALID_LOG_OR_PASS_RU = $"Неверный логин или пароль";
		public const string INVALID_PASSWORD_RU = "Неверный пароль";
		public const string NAME_REQUEST_RU = "Пожалуйста, введите имя";
		public const string SURNAME_REQUEST_RU = "Пожалуйста, введите фамилию";
		public const string PASSWORD_REQUEST_RU = "Пожалуйста, введите пароль";
		public const string PASSWORD_REQUEST_AGAIN_RU = "Пожалуйста, введите пароль еще раз";
		public const string ALREADY_BANNED_ACCOUNT_RU = "Забаненный акк";
		public const string ADMIN_CANT_BE_BANNED_RU = "Вы неможете забанить админа";
		public const string SUCCESFULL_BANNED_USER_RU = "Успешно забанен!";
		public const string BLOG_BODY_INPUT_RU = "Пожалуйста введиде текст";
		public const string BLOG_TITLE_INPUT_RU = "Пожалуйста введиде заголовок блога";
		public const string INCORRECT_LENGTH_RU = "Не правильное длина текста";
		public const string EMAIL_REQUEST_RU = "Пожалуйста введите Емаил";
		public const string EXSISTING_EMAIL_RU = "Такой Email существует";
		public const string ADMIN_CANT_BE_REMOVED_RU = "Админ не можеть быть удалён";
		public const string ENTER_CORECT_FORMAT_RU = "Введите правильно";
		public const string SUCCESFULLY_DELETED_RU = "Успешно удалён";
		public const string ID_REQUEST_RU = "Введите ID";
		public const string ALREADY_ADMIN_RU = "так и так Админ";
		public const string ALREADY_USER_RU = "Так и так Усер";
		public const string PROMOTED_TO_ADMIN_RU = "Стал админом";
		public const string DEPROMOTE_FROM_ADMIN_RU = "Стал усером";
		public const string FORBIDDEN_RU = "Нельзя!!";
		public const string SUCCESSFULLY_RU = "Успешно!!";
		public const string MESSAGE_SENDED_RU = "Успешно отправлено!!";

		public const string CLIENT_DASHBOARD_INTRO_RU = "Добро пожаловать";


		public const string CLIENT_DASHBOARD_INDEX_RU = "Что вы хотите сделать?\n" +
			"1-Обновить настройки\n" +
			"2-Закрыть аккаунт\n" +
			"3-Просмотреть сообщения\n" +
			"4-Добавить блог\n" +
			"5-Добавить комент к блогу\n" +
			"6-Сменить язык\n" +
			"0-Выйти";

		public const string LANGUAGE_CHANGE_OPTIONS_RU = "На какой язык хотите перейти\n" +
					"1-Aze\n" +
					"2-Рус\n" +
					"3-Eng\n" +
					"4-Китайский";


		public const string MAIN_SELECT_OPTIONS_RU = "Что хотите сделать\n" +
					"1-Логин\n" +
					"2-Регистрация\n" +
					"3-Выход\n" +
					"4-Сменить язык\n" +
					"5-Показать все принятые блоги с коментами\n";
	}
}
