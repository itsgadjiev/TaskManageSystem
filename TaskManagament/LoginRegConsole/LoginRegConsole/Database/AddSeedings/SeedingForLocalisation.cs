using LoginRegConsole.Admin;
using LoginRegConsole.Constants.Enums;
using LoginRegConsole.Constants.InputOnLanguages;
using LoginRegConsole.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegConsole.Database.AddSeedings
{
	public class SeedingForLocalisation
	{
		public static void AddAllCommandsOnAzerbaijani()
		{
			AppDbContext.BaseInputs.AddRange(new[]
			{
					new BaseInput { Key = KeysForLanguages.LANGUAGE_CHANGE_OPTIONS, Value = InputsOnSystemLanguages.LANGUAGE_CHANGE_OPTIONS_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.SUCCESFULL_BANNED_USER, Value = InputsOnSystemLanguages.SUCCESFULL_BANNED_USER_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.ALREADY_BANNED_ACCOUNT, Value = InputsOnSystemLanguages.ALREADY_BANNED_ACCOUNT_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.CLIENT_DASHBOARD_INTRO, Value = InputsOnSystemLanguages.CLIENT_DASHBOARD_INTRO_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.CLIENT_DASHBOARD_INDEX, Value = InputsOnSystemLanguages.CLIENT_DASHBOARD_INDEX_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.PASSWORD_REQUEST_AGAIN, Value = InputsOnSystemLanguages.PASSWORD_REQUEST_AGAIN_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.ADMIN_CANT_BE_REMOVED, Value = InputsOnSystemLanguages.ADMIN_CANT_BE_REMOVED_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.ADMIN_CANT_BE_BANNED, Value = InputsOnSystemLanguages.ADMIN_CANT_BE_BANNED_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.ADMINDAHSBOARD_INTRO, Value = InputsOnSystemLanguages.ADMINDAHSBOARD_INTRO_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.DEPROMOTE_FROM_ADMIN, Value = InputsOnSystemLanguages.DEPROMOTE_FROM_ADMIN_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.ENTER_CORECT_FORMAT, Value = InputsOnSystemLanguages.ENTER_CORECT_FORMAT_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.SUCCESFULLY_DELETED, Value = InputsOnSystemLanguages.SUCCESFULLY_DELETED_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.MAIN_SELECT_OPTIONS, Value = InputsOnSystemLanguages.MAIN_SELECT_OPTIONS_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.INVALID_LOG_OR_PASS, Value = InputsOnSystemLanguages.INVALID_LOG_OR_PASS_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.PROMOTED_TO_ADMIN, Value = InputsOnSystemLanguages.PROMOTED_TO_ADMIN_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.SUCCESFULL_ADDING, Value = InputsOnSystemLanguages.SUCCESFULL_ADDING_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.INTRO_FOR_SYSTEM, Value = InputsOnSystemLanguages.INTRO_FOR_SYSTEM_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.BLOG_TITLE_INPUT, Value = InputsOnSystemLanguages.BLOG_TITLE_INPUT_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.INCORRECT_LENGTH, Value = InputsOnSystemLanguages.INCORRECT_LENGTH_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.INVALID_PASSWORD, Value = InputsOnSystemLanguages.INVALID_PASSWORD_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.PASSWORD_REQUEST, Value = InputsOnSystemLanguages.PASSWORD_REQUEST_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.BLOG_BODY_INPUT, Value = InputsOnSystemLanguages.BLOG_BODY_INPUT_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.SURNAME_REQUEST, Value = InputsOnSystemLanguages.SURNAME_REQUEST_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.EXSISTING_EMAIL, Value = InputsOnSystemLanguages.EXSISTING_EMAIL_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.ADMINDASHBOARD, Value = InputsOnSystemLanguages.ADMINDASHBOARD_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.BLOG_NOT_FOUND, Value = InputsOnSystemLanguages.BLOG_NOT_FOUND_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.MESSAGE_SENDED, Value = InputsOnSystemLanguages.MESSAGE_SENDED_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.INVALID_EMAIL, Value = InputsOnSystemLanguages.INVALID_EMAIL_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.CHOICE_OPTION, Value = InputsOnSystemLanguages.CHOICE_OPTION_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.EMAIL_REQUEST, Value = InputsOnSystemLanguages.EMAIL_REQUEST_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.ALREADY_ADMIN, Value = InputsOnSystemLanguages.ALREADY_ADMIN_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.NAME_REQUEST, Value = InputsOnSystemLanguages.NAME_REQUEST_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.ALREADY_USER, Value = InputsOnSystemLanguages.ALREADY_USER_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.SUCCESSFULLY, Value = InputsOnSystemLanguages.SUCCESSFULLY_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.ID_REQUEST, Value = InputsOnSystemLanguages.ID_REQUEST_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.NOT_FOUND, Value = InputsOnSystemLanguages.NOT_FOUND_AZ, Language = SystemLanguage.AZ },
					new BaseInput { Key = KeysForLanguages.FORBIDDEN, Value = InputsOnSystemLanguages.FORBIDDEN_AZ, Language = SystemLanguage.AZ },

			});
		}
		public static void AddAllCommandsOnChinese()
		{
			AppDbContext.BaseInputs.AddRange(new[]
			{
					new BaseInput { Key = KeysForLanguages.LANGUAGE_CHANGE_OPTIONS, Value = InputsOnSystemLanguages.LANGUAGE_CHANGE_OPTIONS_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.SUCCESFULL_BANNED_USER, Value = InputsOnSystemLanguages.SUCCESFULL_BANNED_USER_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.ALREADY_BANNED_ACCOUNT, Value = InputsOnSystemLanguages.ALREADY_BANNED_ACCOUNT_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.CLIENT_DASHBOARD_INTRO, Value = InputsOnSystemLanguages.CLIENT_DASHBOARD_INTRO_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.CLIENT_DASHBOARD_INDEX, Value = InputsOnSystemLanguages.CLIENT_DASHBOARD_INDEX_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.PASSWORD_REQUEST_AGAIN, Value = InputsOnSystemLanguages.PASSWORD_REQUEST_AGAIN_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.ADMIN_CANT_BE_REMOVED, Value = InputsOnSystemLanguages.ADMIN_CANT_BE_REMOVED_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.ADMIN_CANT_BE_BANNED, Value = InputsOnSystemLanguages.ADMIN_CANT_BE_BANNED_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.ADMINDAHSBOARD_INTRO, Value = InputsOnSystemLanguages.ADMINDAHSBOARD_INTRO_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.DEPROMOTE_FROM_ADMIN, Value = InputsOnSystemLanguages.DEPROMOTE_FROM_ADMIN_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.ENTER_CORECT_FORMAT, Value = InputsOnSystemLanguages.ENTER_CORECT_FORMAT_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.SUCCESFULLY_DELETED, Value = InputsOnSystemLanguages.SUCCESFULLY_DELETED_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.MAIN_SELECT_OPTIONS, Value = InputsOnSystemLanguages.MAIN_SELECT_OPTIONS_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.INVALID_LOG_OR_PASS, Value = InputsOnSystemLanguages.INVALID_LOG_OR_PASS_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.PROMOTED_TO_ADMIN, Value = InputsOnSystemLanguages.PROMOTED_TO_ADMIN_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.SUCCESFULL_ADDING, Value = InputsOnSystemLanguages.SUCCESFULL_ADDING_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.INTRO_FOR_SYSTEM, Value = InputsOnSystemLanguages.INTRO_FOR_SYSTEM_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.BLOG_TITLE_INPUT, Value = InputsOnSystemLanguages.BLOG_TITLE_INPUT_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.INCORRECT_LENGTH, Value = InputsOnSystemLanguages.INCORRECT_LENGTH_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.INVALID_PASSWORD, Value = InputsOnSystemLanguages.INVALID_PASSWORD_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.PASSWORD_REQUEST, Value = InputsOnSystemLanguages.PASSWORD_REQUEST_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.BLOG_BODY_INPUT, Value = InputsOnSystemLanguages.BLOG_BODY_INPUT_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.SURNAME_REQUEST, Value = InputsOnSystemLanguages.SURNAME_REQUEST_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.EXSISTING_EMAIL, Value = InputsOnSystemLanguages.EXSISTING_EMAIL_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.ADMINDASHBOARD, Value = InputsOnSystemLanguages.ADMINDASHBOARD_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.BLOG_NOT_FOUND, Value = InputsOnSystemLanguages.BLOG_NOT_FOUND_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.MESSAGE_SENDED, Value = InputsOnSystemLanguages.MESSAGE_SENDED_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.INVALID_EMAIL, Value = InputsOnSystemLanguages.INVALID_EMAIL_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.CHOICE_OPTION, Value = InputsOnSystemLanguages.CHOICE_OPTION_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.EMAIL_REQUEST, Value = InputsOnSystemLanguages.EMAIL_REQUEST_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.ALREADY_ADMIN, Value = InputsOnSystemLanguages.ALREADY_ADMIN_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.NAME_REQUEST, Value = InputsOnSystemLanguages.NAME_REQUEST_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.ALREADY_USER, Value = InputsOnSystemLanguages.ALREADY_USER_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.SUCCESSFULLY, Value = InputsOnSystemLanguages.SUCCESSFULLY_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.ID_REQUEST, Value = InputsOnSystemLanguages.ID_REQUEST_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.NOT_FOUND, Value = InputsOnSystemLanguages.NOT_FOUND_CHN, Language = SystemLanguage.CHN },
					new BaseInput { Key = KeysForLanguages.FORBIDDEN, Value = InputsOnSystemLanguages.FORBIDDEN_CHN, Language = SystemLanguage.CHN },

			});
		}
		public static void AddAllCommandsOnEnglish()
		{
			AppDbContext.BaseInputs.AddRange(new[]
			{
					new BaseInput { Key = KeysForLanguages.CHOICE_OPTION, Value = InputsOnSystemLanguages.CHOICE_OPTION_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.SUCCESFULL_ADDING, Value = InputsOnSystemLanguages.SUCCESFULL_ADDING_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.NOT_FOUND, Value = InputsOnSystemLanguages.NOT_FOUND_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.ADMINDAHSBOARD_INTRO, Value = InputsOnSystemLanguages.ADMINDAHSBOARD_INTRO_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.INTRO_FOR_SYSTEM, Value =InputsOnSystemLanguages.INTRO_FOR_SYSTEM_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.ADMINDASHBOARD, Value = InputsOnSystemLanguages.ADMINDASHBOARD_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.BLOG_NOT_FOUND, Value = InputsOnSystemLanguages.BLOG_NOT_FOUND_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.INVALID_EMAIL, Value = InputsOnSystemLanguages.INVALID_EMAIL_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.ALREADY_BANNED_ACCOUNT, Value = InputsOnSystemLanguages.ALREADY_BANNED_ACCOUNT_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.ADMIN_CANT_BE_BANNED, Value = InputsOnSystemLanguages.ADMIN_CANT_BE_BANNED_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.SUCCESFULL_BANNED_USER, Value = InputsOnSystemLanguages.SUCCESFULL_BANNED_USER_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.BLOG_BODY_INPUT, Value = InputsOnSystemLanguages.BLOG_BODY_INPUT_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.BLOG_TITLE_INPUT, Value = InputsOnSystemLanguages.BLOG_TITLE_INPUT_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.INCORRECT_LENGTH, Value = InputsOnSystemLanguages.INCORRECT_LENGTH_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.MAIN_SELECT_OPTIONS, Value = InputsOnSystemLanguages.MAIN_SELECT_OPTIONS_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.EMAIL_REQUEST, Value = InputsOnSystemLanguages.EMAIL_REQUEST_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.PASSWORD_REQUEST, Value = InputsOnSystemLanguages.PASSWORD_REQUEST_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.ADMIN_CANT_BE_REMOVED, Value = InputsOnSystemLanguages.ADMIN_CANT_BE_REMOVED_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.ENTER_CORECT_FORMAT, Value = InputsOnSystemLanguages.ENTER_CORECT_FORMAT_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.SUCCESFULLY_DELETED, Value = InputsOnSystemLanguages.SUCCESFULLY_DELETED_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.ID_REQUEST, Value = InputsOnSystemLanguages.ID_REQUEST_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.ALREADY_ADMIN, Value = InputsOnSystemLanguages.ALREADY_ADMIN_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.ALREADY_USER, Value = InputsOnSystemLanguages.ALREADY_USER_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.PROMOTED_TO_ADMIN, Value = InputsOnSystemLanguages.PROMOTED_TO_ADMIN_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.DEPROMOTE_FROM_ADMIN, Value = InputsOnSystemLanguages.DEPROMOTE_FROM_ADMIN_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.FORBIDDEN, Value = InputsOnSystemLanguages.FORBIDDEN_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.SUCCESSFULLY, Value = InputsOnSystemLanguages.SUCCESSFULLY_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.LANGUAGE_CHANGE_OPTIONS, Value = InputsOnSystemLanguages.LANGUAGE_CHANGE_OPTIONS_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.CLIENT_DASHBOARD_INTRO, Value = InputsOnSystemLanguages.CLIENT_DASHBOARD_INTRO_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.CLIENT_DASHBOARD_INDEX, Value = InputsOnSystemLanguages.CLIENT_DASHBOARD_INDEX_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.INVALID_PASSWORD, Value = InputsOnSystemLanguages.INVALID_PASSWORD_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.PASSWORD_REQUEST_AGAIN, Value = InputsOnSystemLanguages.PASSWORD_REQUEST_AGAIN_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.SURNAME_REQUEST, Value = InputsOnSystemLanguages.SURNAME_REQUEST_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.NAME_REQUEST, Value = InputsOnSystemLanguages.NAME_REQUEST_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.EXSISTING_EMAIL, Value = InputsOnSystemLanguages.EXSISTING_EMAIL_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.MESSAGE_SENDED, Value = InputsOnSystemLanguages.MESSAGE_SENDED_EN, Language = SystemLanguage.EN },
					new BaseInput { Key = KeysForLanguages.INVALID_LOG_OR_PASS, Value = InputsOnSystemLanguages.INVALID_LOG_OR_PASS_EN, Language = SystemLanguage.EN },


			});
		}
		public static void AddAllCommandsOnRussian()
		{
			AppDbContext.BaseInputs.AddRange(new[]
			{
					new BaseInput { Key = KeysForLanguages.CHOICE_OPTION, Value = InputsOnSystemLanguages.CHOICE_OPTION_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.SUCCESFULL_ADDING, Value = InputsOnSystemLanguages.SUCCESFULL_ADDING_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.NOT_FOUND, Value = InputsOnSystemLanguages.NOT_FOUND_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.ADMINDAHSBOARD_INTRO, Value = InputsOnSystemLanguages.ADMINDAHSBOARD_INTRO_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.INTRO_FOR_SYSTEM, Value =InputsOnSystemLanguages.INTRO_FOR_SYSTEM_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.ADMINDASHBOARD, Value = InputsOnSystemLanguages.ADMINDASHBOARD_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.BLOG_NOT_FOUND, Value = InputsOnSystemLanguages.BLOG_NOT_FOUND_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.INVALID_EMAIL, Value = InputsOnSystemLanguages.INVALID_EMAIL_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.ALREADY_BANNED_ACCOUNT, Value = InputsOnSystemLanguages.ALREADY_BANNED_ACCOUNT_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.ADMIN_CANT_BE_BANNED, Value = InputsOnSystemLanguages.ADMIN_CANT_BE_BANNED_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.SUCCESFULL_BANNED_USER, Value = InputsOnSystemLanguages.SUCCESFULL_BANNED_USER_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.BLOG_BODY_INPUT, Value = InputsOnSystemLanguages.BLOG_BODY_INPUT_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.BLOG_TITLE_INPUT, Value = InputsOnSystemLanguages.BLOG_TITLE_INPUT_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.INCORRECT_LENGTH, Value = InputsOnSystemLanguages.INCORRECT_LENGTH_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.MAIN_SELECT_OPTIONS, Value = InputsOnSystemLanguages.MAIN_SELECT_OPTIONS_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.EMAIL_REQUEST, Value = InputsOnSystemLanguages.EMAIL_REQUEST_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.PASSWORD_REQUEST, Value = InputsOnSystemLanguages.PASSWORD_REQUEST_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.ADMIN_CANT_BE_REMOVED, Value = InputsOnSystemLanguages.ADMIN_CANT_BE_REMOVED_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.ENTER_CORECT_FORMAT, Value = InputsOnSystemLanguages.ENTER_CORECT_FORMAT_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.SUCCESFULLY_DELETED, Value = InputsOnSystemLanguages.SUCCESFULLY_DELETED_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.ID_REQUEST, Value = InputsOnSystemLanguages.ID_REQUEST_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.ALREADY_ADMIN, Value = InputsOnSystemLanguages.ALREADY_ADMIN_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.ALREADY_USER, Value = InputsOnSystemLanguages.ALREADY_USER_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.PROMOTED_TO_ADMIN, Value = InputsOnSystemLanguages.PROMOTED_TO_ADMIN_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.DEPROMOTE_FROM_ADMIN, Value = InputsOnSystemLanguages.DEPROMOTE_FROM_ADMIN_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.FORBIDDEN, Value = InputsOnSystemLanguages.DEPROMOTE_FROM_ADMIN_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.SUCCESSFULLY, Value = InputsOnSystemLanguages.SUCCESSFULLY_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.LANGUAGE_CHANGE_OPTIONS, Value = InputsOnSystemLanguages.LANGUAGE_CHANGE_OPTIONS_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.CLIENT_DASHBOARD_INTRO, Value = InputsOnSystemLanguages.CLIENT_DASHBOARD_INTRO_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.CLIENT_DASHBOARD_INDEX, Value = InputsOnSystemLanguages.CLIENT_DASHBOARD_INDEX_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.INVALID_PASSWORD, Value = InputsOnSystemLanguages.INVALID_PASSWORD_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.PASSWORD_REQUEST_AGAIN, Value = InputsOnSystemLanguages.PASSWORD_REQUEST_AGAIN_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.NAME_REQUEST, Value = InputsOnSystemLanguages.NAME_REQUEST_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.SURNAME_REQUEST, Value = InputsOnSystemLanguages.SURNAME_REQUEST_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.EXSISTING_EMAIL, Value = InputsOnSystemLanguages.EXSISTING_EMAIL_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.MESSAGE_SENDED, Value = InputsOnSystemLanguages.MESSAGE_SENDED_RU, Language = SystemLanguage.RU },
					new BaseInput { Key = KeysForLanguages.INVALID_LOG_OR_PASS, Value = InputsOnSystemLanguages.INVALID_LOG_OR_PASS_RU, Language = SystemLanguage.RU },

			});
		}


	}
}
