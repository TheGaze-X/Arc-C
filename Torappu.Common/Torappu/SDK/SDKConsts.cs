using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu.SDK
{
	// Token: 0x020001A2 RID: 418
	[Token(Token = "0x20001A2")]
	public static class SDKConsts
	{
		// Token: 0x0400094B RID: 2379
		[Token(Token = "0x400094B")]
		public const string SUB_CHANNEL_TAPTAP = "308";

		// Token: 0x0400094C RID: 2380
		[Token(Token = "0x400094C")]
		public const string SUB_CHANNEL_TIKTOK_CPS = "909";

		// Token: 0x0400094D RID: 2381
		[Token(Token = "0x400094D")]
		public const string EMULATOR_NAME_MUMU = "MuMu";

		// Token: 0x0400094E RID: 2382
		[Token(Token = "0x400094E")]
		public const int U8_MSG_TYPE_GAME_VERSION_UPGRADE = 1;

		// Token: 0x0400094F RID: 2383
		[Token(Token = "0x400094F")]
		public const int U8_MSG_TYPE_TIKTOK_VERSION_UPGRADE = 12;

		// Token: 0x04000950 RID: 2384
		[Token(Token = "0x4000950")]
		public const int U8_MSG_TYPE_IF_MTP_ENABLED = 2;

		// Token: 0x04000951 RID: 2385
		[Token(Token = "0x4000951")]
		public const int U8_MSG_TYPE_DEVICE_ID = 3;

		// Token: 0x04000952 RID: 2386
		[Token(Token = "0x4000952")]
		public const int U8_MSG_TYPE_TRACKINGIO_DEVICE_ID = 7;

		// Token: 0x04000953 RID: 2387
		[Token(Token = "0x4000953")]
		public const int U8_MSG_TYPE_PLATFORM = 8;

		// Token: 0x04000954 RID: 2388
		[Token(Token = "0x4000954")]
		public const int U8_MSG_TYPE_OVER_GAME_VERSION_UPGRADE = 9;

		// Token: 0x04000955 RID: 2389
		[Token(Token = "0x4000955")]
		public const int U8_MSG_TYPE_INIT_LICENSE = 10;

		// Token: 0x04000956 RID: 2390
		[Token(Token = "0x4000956")]
		public const int U8_MSG_TYPE_ANDROID_SOC_MODEL = 13;

		// Token: 0x04000957 RID: 2391
		[Token(Token = "0x4000957")]
		public const int U8_MSG_TYPE_ANDROID_EMULATOR_VERSION = 200;

		// Token: 0x04000958 RID: 2392
		[Token(Token = "0x4000958")]
		public const int U8_MSG_TYPE_IOS_ON_MAC = 201;

		// Token: 0x04000959 RID: 2393
		[Token(Token = "0x4000959")]
		public const int U8_MSG_TYPE_HGSDK_ACCOUNT = 1000;

		// Token: 0x0400095A RID: 2394
		[Token(Token = "0x400095A")]
		public const int U8_SET_DATA_APPETIZER = 2;

		// Token: 0x0400095B RID: 2395
		[Token(Token = "0x400095B")]
		public const int U8_SET_DATA_GUEST_CAPTCHA = 3;

		// Token: 0x0400095C RID: 2396
		[Token(Token = "0x400095C")]
		public const int U8_SET_DATA_BI_U8_LOGIN = 9;

		// Token: 0x0400095D RID: 2397
		[Token(Token = "0x400095D")]
		public const int U8_SET_DATA_BI_GS_LOGIN = 10;

		// Token: 0x0400095E RID: 2398
		[Token(Token = "0x400095E")]
		public const int U8_SET_DATA_BI_START_GAME = 11;

		// Token: 0x0400095F RID: 2399
		[Token(Token = "0x400095F")]
		public const int U8_SET_DATA_BI_STOP_GAME = 12;

		// Token: 0x04000960 RID: 2400
		[Token(Token = "0x4000960")]
		public const int U8_SET_DATA_BI_INIT = 13;

		// Token: 0x04000961 RID: 2401
		[Token(Token = "0x4000961")]
		public const int U8_SET_DATA_TRACKINGIO_SET = 14;

		// Token: 0x04000962 RID: 2402
		[Token(Token = "0x4000962")]
		public const int U8_SET_DATA_CLIP_BOARD = 15;

		// Token: 0x04000963 RID: 2403
		[Token(Token = "0x4000963")]
		public const int U8_SET_DATA_WEIBO_ROLE = 16;

		// Token: 0x04000964 RID: 2404
		[Token(Token = "0x4000964")]
		public const int U8_SET_DATA_BAIDU_ROLE = 18;

		// Token: 0x04000965 RID: 2405
		[Token(Token = "0x4000965")]
		public const int U8_SET_DATA_BAIDU_PAY = 19;

		// Token: 0x04000966 RID: 2406
		[Token(Token = "0x4000966")]
		public const int U8_SET_DATA_NEWLENS_INIT = 20;

		// Token: 0x04000967 RID: 2407
		[Token(Token = "0x4000967")]
		public const int U8_SET_DATA_NEWLENS_ID = 21;

		// Token: 0x04000968 RID: 2408
		[Token(Token = "0x4000968")]
		public const int U8_SET_DATA_CLOUD_AUTH = 22;

		// Token: 0x04000969 RID: 2409
		[Token(Token = "0x4000969")]
		public const int U8_SET_DATA_INIT_CLOUD_AUTH = 23;

		// Token: 0x0400096A RID: 2410
		[Token(Token = "0x400096A")]
		public const int U8_SET_DATA_TOUTIAO_LOGIN = 24;

		// Token: 0x0400096B RID: 2411
		[Token(Token = "0x400096B")]
		public const int U8_SET_DATA_TOUTIAO_ROLE = 25;

		// Token: 0x0400096C RID: 2412
		[Token(Token = "0x400096C")]
		public const int U8_SET_DATA_TOUTIAO_PAY = 26;

		// Token: 0x0400096D RID: 2413
		[Token(Token = "0x400096D")]
		public const int U8_SET_DATA_TOUTIAO_LOGOUT = 27;

		// Token: 0x0400096E RID: 2414
		[Token(Token = "0x400096E")]
		public const int U8_SET_DATA_UNBIND_GRANT = 28;

		// Token: 0x0400096F RID: 2415
		[Token(Token = "0x400096F")]
		public const int U8_SET_DATA_INIT_LICENSE = 29;

		// Token: 0x04000970 RID: 2416
		[Token(Token = "0x4000970")]
		public const int U8_SET_DATA_INVOKE_LOGIN_LICENSE = 30;

		// Token: 0x04000971 RID: 2417
		[Token(Token = "0x4000971")]
		public const int U8_SET_DATA_INVOKE_DISPLAY_LICENSE = 31;

		// Token: 0x04000972 RID: 2418
		[Token(Token = "0x4000972")]
		public const int U8_SET_DATA_TIKTOK_CPS_CREATE_ROLE = 32;

		// Token: 0x04000973 RID: 2419
		[Token(Token = "0x4000973")]
		public const int U8_SET_DATA_TIKTOK_CPS_ENTER_GAME = 33;

		// Token: 0x04000974 RID: 2420
		[Token(Token = "0x4000974")]
		public const int U8_SET_DATA_TIKTOK_CPS_PAY = 34;

		// Token: 0x04000975 RID: 2421
		[Token(Token = "0x4000975")]
		public const int U8_SET_DATA_SHARE_IMG = 35;

		// Token: 0x04000976 RID: 2422
		[Token(Token = "0x4000976")]
		public const int U8_SET_DATA_SAVE_IMG = 36;

		// Token: 0x04000977 RID: 2423
		[Token(Token = "0x4000977")]
		public const int U8_SET_DATA_SUBSCRIBE_MSG = 39;

		// Token: 0x04000978 RID: 2424
		[Token(Token = "0x4000978")]
		public const int U8_SET_DATA_UNSUBSCRIBE_MSG = 40;

		// Token: 0x04000979 RID: 2425
		[Token(Token = "0x4000979")]
		public const int U8_SET_DATA_INIT_HGSDK = 1000;

		// Token: 0x0400097A RID: 2426
		[Token(Token = "0x400097A")]
		public const int U8_SET_DATA_HGSDK_MIGRATE = 1001;

		// Token: 0x0400097B RID: 2427
		[Token(Token = "0x400097B")]
		public const int U8_SET_DATA_HGSDK_SCAN_LOGIN = 1004;

		// Token: 0x0400097C RID: 2428
		[Token(Token = "0x400097C")]
		public const int U8_SET_DATA_HGSDK_GAME_CENTER = 1005;

		// Token: 0x0400097D RID: 2429
		[Token(Token = "0x400097D")]
		public const int U8_SET_DATA_SDK_ENV = 2000;

		// Token: 0x0400097E RID: 2430
		[Token(Token = "0x400097E")]
		public const int U8_SET_DATA_SDK_LANG = 2001;

		// Token: 0x0400097F RID: 2431
		[Token(Token = "0x400097F")]
		public const int U8_SET_DATA_YOSTAR_SDK_INIT = 1000;

		// Token: 0x04000980 RID: 2432
		[Token(Token = "0x4000980")]
		public const int U8_SET_DATA_YOSTAR_SDK_CUSTOMER_CENTER = 6;

		// Token: 0x04000981 RID: 2433
		[Token(Token = "0x4000981")]
		public const int U8_SET_DATA_YOSTAR_SDK_TRACE = 7;

		// Token: 0x04000982 RID: 2434
		[Token(Token = "0x4000982")]
		public const int U8_SET_DATA_YOSTAR_SDK_SWITCH_ACCOUNT = 3003;

		// Token: 0x04000983 RID: 2435
		[Token(Token = "0x4000983")]
		public const int U8_GET_DATA_YOSTAR_SDK_CHECK_CACHED_USER = 3001;

		// Token: 0x04000984 RID: 2436
		[Token(Token = "0x4000984")]
		public const int U8_MSG_TYPE_CRASHSIGHT_UPLOAD_URL = 100;

		// Token: 0x04000985 RID: 2437
		[Token(Token = "0x4000985")]
		public const int U8_MSG_TYPE_CRASHSIGHT_APP_ID = 101;

		// Token: 0x020001A3 RID: 419
		[Token(Token = "0x20001A3")]
		public struct U8BaiduPayLogParam
		{
			// Token: 0x060009F4 RID: 2548 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60009F4")]
			[Address(RVA = "0x555E400", Offset = "0x555D000", VA = "0x18555E400", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04000986 RID: 2438
			[Token(Token = "0x4000986")]
			[FieldOffset(Offset = "0x0")]
			public long hbAmount;
		}

		// Token: 0x020001A4 RID: 420
		[Token(Token = "0x20001A4")]
		public struct U8CloudAuthParam
		{
			// Token: 0x060009F5 RID: 2549 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60009F5")]
			[Address(RVA = "0x555E480", Offset = "0x555D080", VA = "0x18555E480", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04000987 RID: 2439
			[Token(Token = "0x4000987")]
			[FieldOffset(Offset = "0x0")]
			public string token;
		}

		// Token: 0x020001A5 RID: 421
		[Token(Token = "0x20001A5")]
		public struct U8ShareParam
		{
			// Token: 0x060009F6 RID: 2550 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x555E650", Offset = "0x555D250", VA = "0x18555E650", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04000988 RID: 2440
			[Token(Token = "0x4000988")]
			[FieldOffset(Offset = "0x0")]
			public string imgPath;

			// Token: 0x04000989 RID: 2441
			[Token(Token = "0x4000989")]
			[FieldOffset(Offset = "0x8")]
			public string extraData;

			// Token: 0x020001A6 RID: 422
			[Token(Token = "0x20001A6")]
			public struct ExtraInfo
			{
				// Token: 0x0400098A RID: 2442
				[Token(Token = "0x400098A")]
				[FieldOffset(Offset = "0x0")]
				[JsonProperty("share_type")]
				public string shareConditionId;
			}
		}

		// Token: 0x020001A7 RID: 423
		[Token(Token = "0x20001A7")]
		public struct U8SaveImgParam
		{
			// Token: 0x060009F7 RID: 2551 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x555E5C0", Offset = "0x555D1C0", VA = "0x18555E5C0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0400098B RID: 2443
			[Token(Token = "0x400098B")]
			[FieldOffset(Offset = "0x0")]
			public SDKConsts.U8SaveImgParam.ShareChannel shareChannel;

			// Token: 0x0400098C RID: 2444
			[Token(Token = "0x400098C")]
			[FieldOffset(Offset = "0x8")]
			public string imgPath;

			// Token: 0x0400098D RID: 2445
			[Token(Token = "0x400098D")]
			[FieldOffset(Offset = "0x10")]
			public string title;

			// Token: 0x0400098E RID: 2446
			[Token(Token = "0x400098E")]
			[FieldOffset(Offset = "0x18")]
			public string desc;

			// Token: 0x0400098F RID: 2447
			[Token(Token = "0x400098F")]
			[FieldOffset(Offset = "0x20")]
			public string extraData;

			// Token: 0x04000990 RID: 2448
			[Token(Token = "0x4000990")]
			[FieldOffset(Offset = "0x28")]
			public string relativePath;

			// Token: 0x04000991 RID: 2449
			[Token(Token = "0x4000991")]
			[FieldOffset(Offset = "0x30")]
			public SDKConsts.U8SaveImgParam.FolderType folderType;

			// Token: 0x020001A8 RID: 424
			[Token(Token = "0x20001A8")]
			public enum ShareChannel
			{
				// Token: 0x04000993 RID: 2451
				[Token(Token = "0x4000993")]
				PC
			}

			// Token: 0x020001A9 RID: 425
			[Token(Token = "0x20001A9")]
			public enum FolderType
			{
				// Token: 0x04000995 RID: 2453
				[Token(Token = "0x4000995")]
				USER_PIC,
				// Token: 0x04000996 RID: 2454
				[Token(Token = "0x4000996")]
				INSTALL_DIR
			}

			// Token: 0x020001AA RID: 426
			[Token(Token = "0x20001AA")]
			public struct ExtraInfo
			{
				// Token: 0x04000997 RID: 2455
				[Token(Token = "0x4000997")]
				[FieldOffset(Offset = "0x0")]
				[JsonProperty("share_type")]
				public string shareConditionId;
			}
		}

		// Token: 0x020001AB RID: 427
		[Token(Token = "0x20001AB")]
		public struct U8UnbindGrantParam
		{
			// Token: 0x060009F8 RID: 2552 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x555E6D0", Offset = "0x555D2D0", VA = "0x18555E6D0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04000998 RID: 2456
			[Token(Token = "0x4000998")]
			[FieldOffset(Offset = "0x0")]
			public SDKConsts.U8UnbindGrantParam.RoleInfo roleInfo;

			// Token: 0x020001AC RID: 428
			[Token(Token = "0x20001AC")]
			public struct RoleInfo
			{
				// Token: 0x04000999 RID: 2457
				[Token(Token = "0x4000999")]
				[FieldOffset(Offset = "0x0")]
				public string roleName;

				// Token: 0x0400099A RID: 2458
				[Token(Token = "0x400099A")]
				[FieldOffset(Offset = "0x8")]
				public string serverName;

				// Token: 0x0400099B RID: 2459
				[Token(Token = "0x400099B")]
				[FieldOffset(Offset = "0x10")]
				public string level;

				// Token: 0x0400099C RID: 2460
				[Token(Token = "0x400099C")]
				[FieldOffset(Offset = "0x18")]
				public DateTime time;
			}
		}

		// Token: 0x020001AD RID: 429
		[Token(Token = "0x20001AD")]
		public struct U8MigrateHGSDKParam
		{
			// Token: 0x060009F9 RID: 2553 RVA: 0x0000767C File Offset: 0x0000587C
			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x555E500", Offset = "0x555D100", VA = "0x18555E500")]
			public bool IsValid()
			{
				return default(bool);
			}

			// Token: 0x060009FA RID: 2554 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x555E540", Offset = "0x555D140", VA = "0x18555E540", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0400099D RID: 2461
			[Token(Token = "0x400099D")]
			[FieldOffset(Offset = "0x0")]
			public string phoneNum;

			// Token: 0x0400099E RID: 2462
			[Token(Token = "0x400099E")]
			[FieldOffset(Offset = "0x8")]
			public string token;
		}
	}
}
