using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	public class ResultCode
	{
		// Token: 0x060001F3 RID: 499 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ResultCode()
		{
		}

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		public const int Unknown = -1;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		public const int SUCCESS = 0;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		public const int DEVICE_BANNED = 100100;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		public const int VALID_FAIL = 100110;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		public const int IP_LIMIT = 100120;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		public const int UID_BANNED = 100130;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		public const int Game_User_In_Cool_Day = 100131;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		public const int Yostar_Pass_User_In_Cool_Day = 100141;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		public const int USER_CLOSE_LOGIN_UI = 100132;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		public const int USER_AGE_LIMIT = 100133;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		public const int TRANS_CODE_NOT_MATCH = 100150;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		public const int ALREADY_SET_BIRTH = 100160;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		public const int BIRTH_IS_FUTURE = 100161;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		public const int THIRD_NOT_BIND = 100180;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		public const int THIRD_VALID_FAIL = 100190;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		public const int THIRD_ALREADY_BOUND = 100200;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		public const int USER_LINKED_OTHER_THIRD_ACCOUNT = 100201;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		public const int THIRD_BOUND_NOT_MATCH = 100210;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		public const int THIRD_BOUND_NOT_EXIST_OR_UNLINKED = 100211;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		public const int THIRD_PLATFORM_CANCEL = 100220;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		public const int FB_AUTH_FAILED = 100221;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		public const int TW_AUTH_FAILED = 100222;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		public const int STEAM_AUTH_FAILED = 101223;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		public const int ERROR_GOOGLE_FAILE = 100223;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		public const int GOOGLE_SIGN_IN_CANCELLED = 100225;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		public const int UID_DELETED = 100228;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		public const int NO_REPEATABLE_DELETE = 100229;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		public const int INIT_FAIL = 100230;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		public const int COMPLETELY_DELETED = 100231;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		public const int NOT_DELETED = 100232;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		public const int GAME_DELETED_NOT_LOGIN = 100233;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		public const int YOSTAR_PASS_DELETED_NOT_LOGIN = 101234;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		public const int YOSTAR_PASS_AND_GAME_DELETED_NOT_LOGIN = 101235;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		public const int DELETED_FUNCTION_NOT_OPEN = 100235;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		public const int LOGIN_METHOD_NOT_ENABLED = 100236;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		public const int APPLE_INFO_INCORRECT = 100240;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		public const int THIRD_AUTH_FAILED = 100241;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		public const int APPLE_AUTH_FAILED = 100242;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		public const int APPLE_AUTH_INVALID_RESPONSE = 100243;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		public const int APPLE_AUTH_NOT_HANDLED = 100244;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		public const int APPLE_AUTH_UNKNOWN = 100245;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		public const int APPLE_AUTH_NOT_USE = 100246;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		public const int HAS_SEND_LIMIT = 100302;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		public const int VERIFY_FAILED = 100303;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		public const int ACCOUNT_BANNED = 100305;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		public const int TRANSE_CODE_SEND_LIMIT = 100308;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		public const int GEE_TEST_FAILED = 100310;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		public const int GEE_TEST_IN_SERVICE_VERY_FAILED = 100311;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		public const int CLIENT_PARAMETER_ERROR = 100400;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		public const int REQUEST_UNAUTH_FAILED = 100401;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		public const int TOKEN_AUTH_FAILED = 100403;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		public const int NET_ERROR = 100404;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		public const int SERVER_ERROR = 100500;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		public const int SERVER_NOT_IN_WHITELIST = 100502;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		public const int PARAM_IS_EMPTY = 100600;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		public const int PARAM_PID_INVALID = 100601;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		public const int CBT_LOGIN_RESTRICTED = 100700;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		public const int NEED_CHECK_CAPTCHA = 100710;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		public const int GRAPHIC_VERIFICATION_FAILED = 100711;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		public const int SURVEY_FETCH_ERROR = 100801;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		public const int SURVEY_SURVEY_NOT_FOUND = 100802;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		public const int NOT_SUPPORTED_THIS_FUNCTION = 101600;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		public const int SET_BIRTH_FAILED = 101601;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		public const int NOT_MIGRATE_URL = 110404;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		public const int SDK_2_SERVICE_UNAVAILABLE = 110110;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		public const int NOT_MATCH = 110130;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		public const int ERROR_QUNHUN_MIGRATE = 110200;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		public const int ERROR_QUNHUN_MIGRATE_GUEST = 110210;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		public const int PAY_NOT_BIRTH = 200100;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		public const int PAY_UPPER_LIMIT = 200110;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		public const int PAY_GOODS_NOT_EXIST_IN_SERVER = 200120;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		public const int PAY_GOODS_NOT_EXIST_IN_APP_STORE = 200350;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		public const int PAY_CHANNEL_NOT_EXIST = 200130;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		public const int PAY_SERVER_TAG_NOT_EXIST = 200140;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		public const int PAY_CURRENCY_NOT_SUPPORT = 200141;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		public const int PAY_RECEIPT_FAILED = 200150;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		public const int PAY_RECEIPT_ORDER_DO_NOT_MATCH = 200151;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		public const int ORDER_PAYED_BUT_RENEW_CONFIRM = 200152;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		public const int ORDER_CREATE_FAILED_IN_GMO = 200153;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		public const int ORDER_CREATE_CANCEL_IN_GMO = 200154;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		public const int PAY_ILLEGAL_PURCHASE = 200160;

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		public const int PAY_PURCHASE_FAILED = 200170;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		public const int PAY_CLIENT_POLLING = 200180;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		public const int PAY_ORDER_NOT_EXIST = 200190;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		public const int PAY_CONFIRM_ORDER_REQUEST_FREQUENT = 200429;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		public const int PAY_ORDER_STATUS_TIMEOUT = 200200;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		public const int PAY_PRODUCTID_NOT_EXIST = 200210;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		public const int PAY_APPSTORE_PAY_FAILED = 200220;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		public const int PAY_APPSTORE_PAY_CANCEL = 200230;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		public const int PAY_THIS_DEVICE_NOT_SUPPORT_PAY = 200232;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		public const int PAY_APPSTORE_PAY_REPEAT = 200370;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		public const int PAY_APPSTORE_PAY_NOT_CONFIRMED = 200380;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		public const int PAY_APPSTORE_PAY_UNFINISHED = 200390;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		public const int PAY_USER_CANCEL = 200340;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		public const int SHARE_FAIL = 300100;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		public const int SHARE_FUNC_NOT_TURN_ON = 300101;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		public const int SHARE_APP_NOT_IN_DEVICE = 300102;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		public const int SHARE_CANCEL = 300103;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		public const int PROJECT_NOT_EXIST = 300200;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		public const int PROJECT_UPDATE_MAINTENANCE = 300201;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		public const int PROJECT_OFFLINE = 300202;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		public const int CHANNEL_NOT_EXIST = 300203;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		public const int THIS_GAME_VERSION_DISABLED = 300204;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		public const int PASS_NICKNAME_FORMAT_ERROR = 400131;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		public const int EMAIL_NOT_EXIST_ON_BIND_EMAIL = 400132;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		public const int NOT_SUPPORTED_UNBIND = 400133;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		public const int BIND_NOT_EXIST_OR_UNBIND = 400134;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		public const int PASS_NICKNAME_IS_ILLEGAL = 400135;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		public const int PASS_NICKNAME_REVIEWING = 400136;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		public const int TEXT_MODERATION_FAILED = 400141;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		public const int THIRD_ACCOUNT_BINDED_BY_OTHER_PASS = 400200;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		public const int PASS_BINDED_BY_OTHER_THIRD_ACCOUNT = 400201;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		public const int REPEAT_LINK = 400202;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		public const int THIRD_UNBOUND_FAIL = 400213;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		public const int PASS_NOT_EXIST = 400214;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		public const int PASS_BIND_BY_OTHER_NOT_SUPPORT_BIND = 400215;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		public const int PASS_ACCOUNT_MIGRATION_FAILED = 400400;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		public const int STEAM_USER_AUTHORIZE_FAILED = 101401;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		public const int STEAM_PAY_TIMEOUT = 201235;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		public const int STEAM_PAY_GET_PARAM_ERROR = 201145;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		public const int STEAM_PAY_AUTHORIZE_FAILED = 201236;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		public const int ERROR_PAY_NOT_TURNED_ON = 201182;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		public const int ERROR_MANUAL_NETCHECK_NOTENABLE = 101602;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		public const int ERROR_AIHELP_NOT_ENABLE = 101603;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		public const int ERROR_WINDOW_CLOSE = 101604;
	}
}
