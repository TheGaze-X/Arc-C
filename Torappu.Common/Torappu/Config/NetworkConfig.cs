using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Torappu.Network;
using XLua;

namespace Torappu.Config
{
	// Token: 0x0200024E RID: 590
	[Token(Token = "0x200024E")]
	public class NetworkConfig : SingletonDynGameConfig<NetworkConfig, NetworkConfig.InternalConfig>
	{
		// Token: 0x06000D62 RID: 3426 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D62")]
		[Address(RVA = "0x5584270", Offset = "0x5582E70", VA = "0x185584270")]
		protected NetworkConfig()
		{
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D63")]
		[Address(RVA = "0x5583CA0", Offset = "0x55828A0", VA = "0x185583CA0", Slot = "10")]
		public override string ConfigName()
		{
			return null;
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x000087EC File Offset: 0x000069EC
		[Token(Token = "0x6000D64")]
		[Address(RVA = "0x5583D10", Offset = "0x5582910", VA = "0x185583D10", Slot = "11")]
		public override bool DistinctChannel()
		{
			return default(bool);
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00008804 File Offset: 0x00006A04
		[Token(Token = "0x6000D65")]
		[Address(RVA = "0x5583D70", Offset = "0x5582970", VA = "0x185583D70", Slot = "12")]
		public override bool DistinctPlatform()
		{
			return default(bool);
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D66")]
		[Address(RVA = "0x5583C30", Offset = "0x5582830", VA = "0x185583C30", Slot = "13")]
		protected override void BeforeReset()
		{
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700015C")]
		public string gameServerUrl
		{
			[Token(Token = "0x6000D67")]
			[Address(RVA = "0x55844B0", Offset = "0x55830B0", VA = "0x1855844B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700015D")]
		public string sdkServerUrl
		{
			[Token(Token = "0x6000D68")]
			[Address(RVA = "0x5584830", Offset = "0x5583430", VA = "0x185584830")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700015E")]
		public string u8ServerUrl
		{
			[Token(Token = "0x6000D69")]
			[Address(RVA = "0x5584930", Offset = "0x5583530", VA = "0x185584930")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700015F")]
		public string hotUpdateUrl
		{
			[Token(Token = "0x6000D6A")]
			[Address(RVA = "0x5584530", Offset = "0x5583130", VA = "0x185584530")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000160")]
		public string htUdtVerUrl
		{
			[Token(Token = "0x6000D6B")]
			[Address(RVA = "0x55845B0", Offset = "0x55831B0", VA = "0x1855845B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000161")]
		public string announceUrl
		{
			[Token(Token = "0x6000D6C")]
			[Address(RVA = "0x5584330", Offset = "0x5582F30", VA = "0x185584330")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000162")]
		public string preAnnounceUrl
		{
			[Token(Token = "0x6000D6D")]
			[Address(RVA = "0x55847B0", Offset = "0x55833B0", VA = "0x1855847B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000163")]
		public string serviceLicenseUrl
		{
			[Token(Token = "0x6000D6E")]
			[Address(RVA = "0x55848B0", Offset = "0x55834B0", VA = "0x1855848B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000164")]
		public string officialUrl
		{
			[Token(Token = "0x6000D6F")]
			[Address(RVA = "0x5584630", Offset = "0x5583230", VA = "0x185584630")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000165")]
		public string packageDownloadUrlAndroid
		{
			[Token(Token = "0x6000D70")]
			[Address(RVA = "0x55846B0", Offset = "0x55832B0", VA = "0x1855846B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000166")]
		public string packageDownloadUrlIOS
		{
			[Token(Token = "0x6000D71")]
			[Address(RVA = "0x5584730", Offset = "0x5583330", VA = "0x185584730")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x0000881C File Offset: 0x00006A1C
		[Token(Token = "0x17000167")]
		public bool devsdk
		{
			[Token(Token = "0x6000D72")]
			[Address(RVA = "0x5584430", Offset = "0x5583030", VA = "0x185584430")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x00008834 File Offset: 0x00006A34
		[Token(Token = "0x17000168")]
		public int configVer
		{
			[Token(Token = "0x6000D73")]
			[Address(RVA = "0x55843B0", Offset = "0x5582FB0", VA = "0x1855843B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x0000884C File Offset: 0x00006A4C
		[Token(Token = "0x6000D74")]
		[Address(RVA = "0x5583DD0", Offset = "0x55829D0", VA = "0x185583DD0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x00008864 File Offset: 0x00006A64
		[Token(Token = "0x6000D75")]
		[Address(RVA = "0x5583E60", Offset = "0x5582A60", VA = "0x185583E60")]
		public bool SetResponse(string json)
		{
			return default(bool);
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0000887C File Offset: 0x00006A7C
		[Token(Token = "0x6000D76")]
		[Address(RVA = "0x5583F90", Offset = "0x5582B90", VA = "0x185583F90")]
		public Networker.Configuration ToNetworkerConfiguration()
		{
			return default(Networker.Configuration);
		}

		// Token: 0x04000D7E RID: 3454
		[Token(Token = "0x4000D7E")]
		public const string NAME = "network_config";

		// Token: 0x04000D7F RID: 3455
		[Token(Token = "0x4000D7F")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x04000D80 RID: 3456
		[Token(Token = "0x4000D80")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate19 __Hotfix0_ConfigName;

		// Token: 0x04000D81 RID: 3457
		[Token(Token = "0x4000D81")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate21 __Hotfix0_DistinctChannel;

		// Token: 0x04000D82 RID: 3458
		[Token(Token = "0x4000D82")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate21 __Hotfix0_DistinctPlatform;

		// Token: 0x04000D83 RID: 3459
		[Token(Token = "0x4000D83")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate1 __Hotfix0_BeforeReset;

		// Token: 0x04000D84 RID: 3460
		[Token(Token = "0x4000D84")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate19 __Hotfix0_get_gameServerUrl;

		// Token: 0x04000D85 RID: 3461
		[Token(Token = "0x4000D85")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate19 __Hotfix0_get_sdkServerUrl;

		// Token: 0x04000D86 RID: 3462
		[Token(Token = "0x4000D86")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate19 __Hotfix0_get_u8ServerUrl;

		// Token: 0x04000D87 RID: 3463
		[Token(Token = "0x4000D87")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate19 __Hotfix0_get_hotUpdateUrl;

		// Token: 0x04000D88 RID: 3464
		[Token(Token = "0x4000D88")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate19 __Hotfix0_get_htUdtVerUrl;

		// Token: 0x04000D89 RID: 3465
		[Token(Token = "0x4000D89")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate19 __Hotfix0_get_announceUrl;

		// Token: 0x04000D8A RID: 3466
		[Token(Token = "0x4000D8A")]
		[FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate19 __Hotfix0_get_preAnnounceUrl;

		// Token: 0x04000D8B RID: 3467
		[Token(Token = "0x4000D8B")]
		[FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate19 __Hotfix0_get_serviceLicenseUrl;

		// Token: 0x04000D8C RID: 3468
		[Token(Token = "0x4000D8C")]
		[FieldOffset(Offset = "0x68")]
		private static __XLua_Gen_Delegate19 __Hotfix0_get_officialUrl;

		// Token: 0x04000D8D RID: 3469
		[Token(Token = "0x4000D8D")]
		[FieldOffset(Offset = "0x70")]
		private static __XLua_Gen_Delegate19 __Hotfix0_get_packageDownloadUrlAndroid;

		// Token: 0x04000D8E RID: 3470
		[Token(Token = "0x4000D8E")]
		[FieldOffset(Offset = "0x78")]
		private static __XLua_Gen_Delegate19 __Hotfix0_get_packageDownloadUrlIOS;

		// Token: 0x04000D8F RID: 3471
		[Token(Token = "0x4000D8F")]
		[FieldOffset(Offset = "0x80")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_devsdk;

		// Token: 0x04000D90 RID: 3472
		[Token(Token = "0x4000D90")]
		[FieldOffset(Offset = "0x88")]
		private static __XLua_Gen_Delegate25 __Hotfix0_get_configVer;

		// Token: 0x04000D91 RID: 3473
		[Token(Token = "0x4000D91")]
		[FieldOffset(Offset = "0x90")]
		private static __XLua_Gen_Delegate21 __Hotfix0_IsEmpty;

		// Token: 0x04000D92 RID: 3474
		[Token(Token = "0x4000D92")]
		[FieldOffset(Offset = "0x98")]
		private static __XLua_Gen_Delegate154 __Hotfix0_SetResponse;

		// Token: 0x04000D93 RID: 3475
		[Token(Token = "0x4000D93")]
		[FieldOffset(Offset = "0xA0")]
		private static __XLua_Gen_Delegate249 __Hotfix0_ToNetworkerConfiguration;

		// Token: 0x0200024F RID: 591
		[Token(Token = "0x200024F")]
		public class InternalConfig
		{
			// Token: 0x06000D77 RID: 3447 RVA: 0x00008894 File Offset: 0x00006A94
			[Token(Token = "0x6000D77")]
			[Address(RVA = "0x19233C0", Offset = "0x1921FC0", VA = "0x1819233C0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x06000D78 RID: 3448 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000D78")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public InternalConfig()
			{
			}

			// Token: 0x04000D94 RID: 3476
			[Token(Token = "0x4000D94")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty("gs")]
			public string gameServerUrl;

			// Token: 0x04000D95 RID: 3477
			[Token(Token = "0x4000D95")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty("as")]
			public string sdkServerUrl;

			// Token: 0x04000D96 RID: 3478
			[Token(Token = "0x4000D96")]
			[FieldOffset(Offset = "0x20")]
			[JsonProperty("u8")]
			public string u8ServerUrl;

			// Token: 0x04000D97 RID: 3479
			[Token(Token = "0x4000D97")]
			[FieldOffset(Offset = "0x28")]
			[JsonProperty("hu")]
			public string hotUpdateUrl;

			// Token: 0x04000D98 RID: 3480
			[Token(Token = "0x4000D98")]
			[FieldOffset(Offset = "0x30")]
			[JsonProperty("hv")]
			public string htUdtVerUrl;

			// Token: 0x04000D99 RID: 3481
			[Token(Token = "0x4000D99")]
			[FieldOffset(Offset = "0x38")]
			[JsonProperty("an")]
			public string announceUrl;

			// Token: 0x04000D9A RID: 3482
			[Token(Token = "0x4000D9A")]
			[FieldOffset(Offset = "0x40")]
			[JsonProperty("prean")]
			public string preAnnounceUrl;

			// Token: 0x04000D9B RID: 3483
			[Token(Token = "0x4000D9B")]
			[FieldOffset(Offset = "0x48")]
			[JsonProperty("sl")]
			public string serviceLicenseUrl;

			// Token: 0x04000D9C RID: 3484
			[Token(Token = "0x4000D9C")]
			[FieldOffset(Offset = "0x50")]
			[JsonProperty("of")]
			public string officialUrl;

			// Token: 0x04000D9D RID: 3485
			[Token(Token = "0x4000D9D")]
			[FieldOffset(Offset = "0x58")]
			[JsonProperty("pkgAd")]
			public string packageDownloadUrlAndroid;

			// Token: 0x04000D9E RID: 3486
			[Token(Token = "0x4000D9E")]
			[FieldOffset(Offset = "0x60")]
			[JsonProperty("pkgIOS")]
			public string packageDownloadUrlIOS;

			// Token: 0x04000D9F RID: 3487
			[Token(Token = "0x4000D9F")]
			[FieldOffset(Offset = "0x68")]
			public bool devsdk;

			// Token: 0x04000DA0 RID: 3488
			[Token(Token = "0x4000DA0")]
			[FieldOffset(Offset = "0x6C")]
			public int configVer;
		}
	}
}
