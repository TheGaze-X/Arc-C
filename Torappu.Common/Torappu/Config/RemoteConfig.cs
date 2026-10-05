using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Config
{
	// Token: 0x02000250 RID: 592
	[Token(Token = "0x2000250")]
	public class RemoteConfig : SingletonDynGameConfig<RemoteConfig, RemoteConfig.InternalConfig>
	{
		// Token: 0x06000D79 RID: 3449 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D79")]
		[Address(RVA = "0x5584F80", Offset = "0x5583B80", VA = "0x185584F80")]
		protected RemoteConfig()
		{
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D7A")]
		[Address(RVA = "0x5584D20", Offset = "0x5583920", VA = "0x185584D20", Slot = "10")]
		public override string ConfigName()
		{
			return null;
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x000088AC File Offset: 0x00006AAC
		[Token(Token = "0x6000D7B")]
		[Address(RVA = "0x5584D90", Offset = "0x5583990", VA = "0x185584D90", Slot = "11")]
		public override bool DistinctChannel()
		{
			return default(bool);
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x000088C4 File Offset: 0x00006AC4
		[Token(Token = "0x6000D7C")]
		[Address(RVA = "0x5584DF0", Offset = "0x55839F0", VA = "0x185584DF0", Slot = "12")]
		public override bool DistinctPlatform()
		{
			return default(bool);
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x000088DC File Offset: 0x00006ADC
		[Token(Token = "0x17000169")]
		public bool isAuditMode
		{
			[Token(Token = "0x6000D7D")]
			[Address(RVA = "0x5586540", Offset = "0x5585140", VA = "0x185586540")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x000088F4 File Offset: 0x00006AF4
		[Token(Token = "0x1700016A")]
		public bool enableDBCheck
		{
			[Token(Token = "0x6000D7E")]
			[Address(RVA = "0x5585A40", Offset = "0x5584640", VA = "0x185585A40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x0000890C File Offset: 0x00006B0C
		[Token(Token = "0x1700016B")]
		public bool enableLuaPlayerData
		{
			[Token(Token = "0x6000D7F")]
			[Address(RVA = "0x5585F40", Offset = "0x5584B40", VA = "0x185585F40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x00008924 File Offset: 0x00006B24
		[Token(Token = "0x1700016C")]
		public bool enableGameBI
		{
			[Token(Token = "0x6000D80")]
			[Address(RVA = "0x5585C40", Offset = "0x5584840", VA = "0x185585C40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x0000893C File Offset: 0x00006B3C
		[Token(Token = "0x1700016D")]
		public bool enableHGSDKPollingConfirm
		{
			[Token(Token = "0x6000D81")]
			[Address(RVA = "0x5585CC0", Offset = "0x55848C0", VA = "0x185585CC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700016E")]
		public string inlandAgeTips
		{
			[Token(Token = "0x6000D82")]
			[Address(RVA = "0x55864C0", Offset = "0x55850C0", VA = "0x1855864C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x00008954 File Offset: 0x00006B54
		[Token(Token = "0x1700016F")]
		public bool enableFastPlayerDelta
		{
			[Token(Token = "0x6000D83")]
			[Address(RVA = "0x5585BC0", Offset = "0x55847C0", VA = "0x185585BC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x0000896C File Offset: 0x00006B6C
		[Token(Token = "0x17000170")]
		public bool haltIfHotUpdateUnzipError
		{
			[Token(Token = "0x6000D84")]
			[Address(RVA = "0x5586340", Offset = "0x5584F40", VA = "0x185586340")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x00008984 File Offset: 0x00006B84
		[Token(Token = "0x17000171")]
		public bool enableHotUpdateLargePack
		{
			[Token(Token = "0x6000D85")]
			[Address(RVA = "0x5585DC0", Offset = "0x55849C0", VA = "0x185585DC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x0000899C File Offset: 0x00006B9C
		[Token(Token = "0x17000172")]
		public bool enableIAPProdCheck
		{
			[Token(Token = "0x6000D86")]
			[Address(RVA = "0x5585E40", Offset = "0x5584A40", VA = "0x185585E40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x000089B4 File Offset: 0x00006BB4
		[Token(Token = "0x17000173")]
		public bool disableGuest
		{
			[Token(Token = "0x6000D87")]
			[Address(RVA = "0x5585440", Offset = "0x5584040", VA = "0x185585440")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x000089CC File Offset: 0x00006BCC
		[Token(Token = "0x17000174")]
		public bool enableNetCheck
		{
			[Token(Token = "0x6000D88")]
			[Address(RVA = "0x5586040", Offset = "0x5584C40", VA = "0x185586040")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000D89 RID: 3465 RVA: 0x000089E4 File Offset: 0x00006BE4
		[Token(Token = "0x17000175")]
		public bool announceUseWeb
		{
			[Token(Token = "0x6000D89")]
			[Address(RVA = "0x55850C0", Offset = "0x5583CC0", VA = "0x1855850C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x000089FC File Offset: 0x00006BFC
		[Token(Token = "0x17000176")]
		public bool disableBuffTemplateDB
		{
			[Token(Token = "0x6000D8A")]
			[Address(RVA = "0x5585340", Offset = "0x5583F40", VA = "0x185585340")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000D8B RID: 3467 RVA: 0x00008A14 File Offset: 0x00006C14
		[Token(Token = "0x17000177")]
		public int HGDownload
		{
			[Token(Token = "0x6000D8B")]
			[Address(RVA = "0x5585040", Offset = "0x5583C40", VA = "0x185585040")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x00008A2C File Offset: 0x00006C2C
		[Token(Token = "0x17000178")]
		public bool enableAsyncResCheck
		{
			[Token(Token = "0x6000D8C")]
			[Address(RVA = "0x5585740", Offset = "0x5584340", VA = "0x185585740")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x00008A44 File Offset: 0x00006C44
		[Token(Token = "0x17000179")]
		public int effectPreloadStripBound
		{
			[Token(Token = "0x6000D8D")]
			[Address(RVA = "0x5585540", Offset = "0x5584140", VA = "0x185585540")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x00008A5C File Offset: 0x00006C5C
		[Token(Token = "0x1700017A")]
		public bool disableGatherEffect
		{
			[Token(Token = "0x6000D8E")]
			[Address(RVA = "0x55853C0", Offset = "0x5583FC0", VA = "0x1855853C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x00008A74 File Offset: 0x00006C74
		[Token(Token = "0x1700017B")]
		public bool enableBattleAnimationLazyLoad
		{
			[Token(Token = "0x6000D8F")]
			[Address(RVA = "0x55857C0", Offset = "0x55843C0", VA = "0x1855857C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x00008A8C File Offset: 0x00006C8C
		[Token(Token = "0x1700017C")]
		public bool enableBattleDeckHiddenReason
		{
			[Token(Token = "0x6000D90")]
			[Address(RVA = "0x5585840", Offset = "0x5584440", VA = "0x185585840")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x00008AA4 File Offset: 0x00006CA4
		[Token(Token = "0x1700017D")]
		public bool enableNativeLicense
		{
			[Token(Token = "0x6000D91")]
			[Address(RVA = "0x5585FC0", Offset = "0x5584BC0", VA = "0x185585FC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x00008ABC File Offset: 0x00006CBC
		[Token(Token = "0x1700017E")]
		public bool enableHGString
		{
			[Token(Token = "0x6000D92")]
			[Address(RVA = "0x5585D40", Offset = "0x5584940", VA = "0x185585D40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x00008AD4 File Offset: 0x00006CD4
		[Token(Token = "0x1700017F")]
		public bool enableFastBattleFinish
		{
			[Token(Token = "0x6000D93")]
			[Address(RVA = "0x5585B40", Offset = "0x5584740", VA = "0x185585B40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x00008AEC File Offset: 0x00006CEC
		[Token(Token = "0x17000180")]
		public int fastAddPages
		{
			[Token(Token = "0x6000D94")]
			[Address(RVA = "0x5586240", Offset = "0x5584E40", VA = "0x185586240")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x00008B04 File Offset: 0x00006D04
		[Token(Token = "0x17000181")]
		public int fastBattleFinish
		{
			[Token(Token = "0x6000D95")]
			[Address(RVA = "0x55862C0", Offset = "0x5584EC0", VA = "0x1855862C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x00008B1C File Offset: 0x00006D1C
		[Token(Token = "0x17000182")]
		public bool enableCrossAppShare
		{
			[Token(Token = "0x6000D96")]
			[Address(RVA = "0x55859C0", Offset = "0x55845C0", VA = "0x1855859C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x00008B34 File Offset: 0x00006D34
		[Token(Token = "0x17000183")]
		public bool enablePoolRelease
		{
			[Token(Token = "0x6000D97")]
			[Address(RVA = "0x5586140", Offset = "0x5584D40", VA = "0x185586140")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x00008B4C File Offset: 0x00006D4C
		[Token(Token = "0x17000184")]
		public int margueeType
		{
			[Token(Token = "0x6000D98")]
			[Address(RVA = "0x5586640", Offset = "0x5585240", VA = "0x185586640")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x00008B64 File Offset: 0x00006D64
		[Token(Token = "0x17000185")]
		public bool renderInvisibleSpine
		{
			[Token(Token = "0x6000D99")]
			[Address(RVA = "0x5586740", Offset = "0x5585340", VA = "0x185586740")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000D9A RID: 3482 RVA: 0x00008B7C File Offset: 0x00006D7C
		[Token(Token = "0x17000186")]
		public bool renderMultiPlayerInvisibleSpine
		{
			[Token(Token = "0x6000D9A")]
			[Address(RVA = "0x55867C0", Offset = "0x55853C0", VA = "0x1855867C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x00008B94 File Offset: 0x00006D94
		[Token(Token = "0x17000187")]
		public bool spineTickInAdditionalFrame
		{
			[Token(Token = "0x6000D9B")]
			[Address(RVA = "0x5586940", Offset = "0x5585540", VA = "0x185586940")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x00008BAC File Offset: 0x00006DAC
		[Token(Token = "0x17000188")]
		public int visibilityColliderBallRadius
		{
			[Token(Token = "0x6000D9C")]
			[Address(RVA = "0x5586A40", Offset = "0x5585640", VA = "0x185586A40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x00008BC4 File Offset: 0x00006DC4
		[Token(Token = "0x17000189")]
		public bool dontLoadSkinBeforeGameLoaded
		{
			[Token(Token = "0x6000D9D")]
			[Address(RVA = "0x55854C0", Offset = "0x55840C0", VA = "0x1855854C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x00008BDC File Offset: 0x00006DDC
		[Token(Token = "0x1700018A")]
		public bool disableAdaptiveDynIllust
		{
			[Token(Token = "0x6000D9E")]
			[Address(RVA = "0x55852C0", Offset = "0x5583EC0", VA = "0x1855852C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x00008BF4 File Offset: 0x00006DF4
		[Token(Token = "0x1700018B")]
		public bool showRecordNumber
		{
			[Token(Token = "0x6000D9F")]
			[Address(RVA = "0x5586840", Offset = "0x5585440", VA = "0x185586840")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700018C")]
		public string recordNumber
		{
			[Token(Token = "0x6000DA0")]
			[Address(RVA = "0x55866C0", Offset = "0x55852C0", VA = "0x1855866C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700018D")]
		public string beianUrl
		{
			[Token(Token = "0x6000DA1")]
			[Address(RVA = "0x5585240", Offset = "0x5583E40", VA = "0x185585240")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x00008C0C File Offset: 0x00006E0C
		[Token(Token = "0x1700018E")]
		public bool enableBattlePostprocessAA
		{
			[Token(Token = "0x6000DA2")]
			[Address(RVA = "0x55858C0", Offset = "0x55844C0", VA = "0x1855858C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x00008C24 File Offset: 0x00006E24
		[Token(Token = "0x1700018F")]
		public bool enableACEService
		{
			[Token(Token = "0x6000DA3")]
			[Address(RVA = "0x5585640", Offset = "0x5584240", VA = "0x185585640")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x00008C3C File Offset: 0x00006E3C
		[Token(Token = "0x17000190")]
		public bool enableACEData4
		{
			[Token(Token = "0x6000DA4")]
			[Address(RVA = "0x55855C0", Offset = "0x55841C0", VA = "0x1855855C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x00008C54 File Offset: 0x00006E54
		[Token(Token = "0x17000191")]
		public bool enableRoguelikeSeedMode
		{
			[Token(Token = "0x6000DA5")]
			[Address(RVA = "0x55861C0", Offset = "0x5584DC0", VA = "0x1855861C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x00008C6C File Offset: 0x00006E6C
		[Token(Token = "0x17000192")]
		public bool enableAVGReaderMode
		{
			[Token(Token = "0x6000DA6")]
			[Address(RVA = "0x55856C0", Offset = "0x55842C0", VA = "0x1855856C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x00008C84 File Offset: 0x00006E84
		[Token(Token = "0x17000193")]
		public bool enableParticleEffectManager
		{
			[Token(Token = "0x6000DA7")]
			[Address(RVA = "0x55860C0", Offset = "0x5584CC0", VA = "0x1855860C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x00008C9C File Offset: 0x00006E9C
		[Token(Token = "0x17000194")]
		public bool enableDynamicTree
		{
			[Token(Token = "0x6000DA8")]
			[Address(RVA = "0x5585AC0", Offset = "0x55846C0", VA = "0x185585AC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x00008CB4 File Offset: 0x00006EB4
		[Token(Token = "0x17000195")]
		public bool slowDownHudTick
		{
			[Token(Token = "0x6000DA9")]
			[Address(RVA = "0x55868C0", Offset = "0x55854C0", VA = "0x1855868C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x00008CCC File Offset: 0x00006ECC
		[Token(Token = "0x17000196")]
		public int useMutliFormRate
		{
			[Token(Token = "0x6000DAA")]
			[Address(RVA = "0x55869C0", Offset = "0x55855C0", VA = "0x1855869C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x00008CE4 File Offset: 0x00006EE4
		[Token(Token = "0x17000197")]
		public bool enableCameraDownScale
		{
			[Token(Token = "0x6000DAB")]
			[Address(RVA = "0x5585940", Offset = "0x5584540", VA = "0x185585940")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000DAC RID: 3500 RVA: 0x00008CFC File Offset: 0x00006EFC
		[Token(Token = "0x17000198")]
		public int battleCameraDownScaleRate
		{
			[Token(Token = "0x6000DAC")]
			[Address(RVA = "0x55851C0", Offset = "0x5583DC0", VA = "0x1855851C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000DAD RID: 3501 RVA: 0x00008D14 File Offset: 0x00006F14
		[Token(Token = "0x17000199")]
		public int bakeMuzzleEnableRate
		{
			[Token(Token = "0x6000DAD")]
			[Address(RVA = "0x5585140", Offset = "0x5583D40", VA = "0x185585140")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000DAE RID: 3502 RVA: 0x00008D2C File Offset: 0x00006F2C
		[Token(Token = "0x1700019A")]
		public int il2cppLazyLoad
		{
			[Token(Token = "0x6000DAE")]
			[Address(RVA = "0x55863C0", Offset = "0x5584FC0", VA = "0x1855863C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x00008D44 File Offset: 0x00006F44
		[Token(Token = "0x1700019B")]
		public int il2cppMmap
		{
			[Token(Token = "0x6000DAF")]
			[Address(RVA = "0x5586440", Offset = "0x5585040", VA = "0x185586440")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000DB0 RID: 3504 RVA: 0x00008D5C File Offset: 0x00006F5C
		[Token(Token = "0x1700019C")]
		public bool loginDevInfo
		{
			[Token(Token = "0x6000DB0")]
			[Address(RVA = "0x55865C0", Offset = "0x55851C0", VA = "0x1855865C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x00008D74 File Offset: 0x00006F74
		[Token(Token = "0x1700019D")]
		public bool enableLegacyCertValidate
		{
			[Token(Token = "0x6000DB1")]
			[Address(RVA = "0x5585EC0", Offset = "0x5584AC0", VA = "0x185585EC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00008D8C File Offset: 0x00006F8C
		[Token(Token = "0x6000DB2")]
		[Address(RVA = "0x5584E50", Offset = "0x5583A50", VA = "0x185584E50")]
		public bool SetResponse(string json)
		{
			return default(bool);
		}

		// Token: 0x04000DA1 RID: 3489
		[Token(Token = "0x4000DA1")]
		public const string NAME = "remote_config";

		// Token: 0x04000DA2 RID: 3490
		[Token(Token = "0x4000DA2")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x04000DA3 RID: 3491
		[Token(Token = "0x4000DA3")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate19 __Hotfix0_ConfigName;

		// Token: 0x04000DA4 RID: 3492
		[Token(Token = "0x4000DA4")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate21 __Hotfix0_DistinctChannel;

		// Token: 0x04000DA5 RID: 3493
		[Token(Token = "0x4000DA5")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate21 __Hotfix0_DistinctPlatform;

		// Token: 0x04000DA6 RID: 3494
		[Token(Token = "0x4000DA6")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_isAuditMode;

		// Token: 0x04000DA7 RID: 3495
		[Token(Token = "0x4000DA7")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableDBCheck;

		// Token: 0x04000DA8 RID: 3496
		[Token(Token = "0x4000DA8")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableLuaPlayerData;

		// Token: 0x04000DA9 RID: 3497
		[Token(Token = "0x4000DA9")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableGameBI;

		// Token: 0x04000DAA RID: 3498
		[Token(Token = "0x4000DAA")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableHGSDKPollingConfirm;

		// Token: 0x04000DAB RID: 3499
		[Token(Token = "0x4000DAB")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate19 __Hotfix0_get_inlandAgeTips;

		// Token: 0x04000DAC RID: 3500
		[Token(Token = "0x4000DAC")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableFastPlayerDelta;

		// Token: 0x04000DAD RID: 3501
		[Token(Token = "0x4000DAD")]
		[FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_haltIfHotUpdateUnzipError;

		// Token: 0x04000DAE RID: 3502
		[Token(Token = "0x4000DAE")]
		[FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableHotUpdateLargePack;

		// Token: 0x04000DAF RID: 3503
		[Token(Token = "0x4000DAF")]
		[FieldOffset(Offset = "0x68")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableIAPProdCheck;

		// Token: 0x04000DB0 RID: 3504
		[Token(Token = "0x4000DB0")]
		[FieldOffset(Offset = "0x70")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_disableGuest;

		// Token: 0x04000DB1 RID: 3505
		[Token(Token = "0x4000DB1")]
		[FieldOffset(Offset = "0x78")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableNetCheck;

		// Token: 0x04000DB2 RID: 3506
		[Token(Token = "0x4000DB2")]
		[FieldOffset(Offset = "0x80")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_announceUseWeb;

		// Token: 0x04000DB3 RID: 3507
		[Token(Token = "0x4000DB3")]
		[FieldOffset(Offset = "0x88")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_disableBuffTemplateDB;

		// Token: 0x04000DB4 RID: 3508
		[Token(Token = "0x4000DB4")]
		[FieldOffset(Offset = "0x90")]
		private static __XLua_Gen_Delegate25 __Hotfix0_get_HGDownload;

		// Token: 0x04000DB5 RID: 3509
		[Token(Token = "0x4000DB5")]
		[FieldOffset(Offset = "0x98")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableAsyncResCheck;

		// Token: 0x04000DB6 RID: 3510
		[Token(Token = "0x4000DB6")]
		[FieldOffset(Offset = "0xA0")]
		private static __XLua_Gen_Delegate25 __Hotfix0_get_effectPreloadStripBound;

		// Token: 0x04000DB7 RID: 3511
		[Token(Token = "0x4000DB7")]
		[FieldOffset(Offset = "0xA8")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_disableGatherEffect;

		// Token: 0x04000DB8 RID: 3512
		[Token(Token = "0x4000DB8")]
		[FieldOffset(Offset = "0xB0")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableBattleAnimationLazyLoad;

		// Token: 0x04000DB9 RID: 3513
		[Token(Token = "0x4000DB9")]
		[FieldOffset(Offset = "0xB8")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableBattleDeckHiddenReason;

		// Token: 0x04000DBA RID: 3514
		[Token(Token = "0x4000DBA")]
		[FieldOffset(Offset = "0xC0")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableNativeLicense;

		// Token: 0x04000DBB RID: 3515
		[Token(Token = "0x4000DBB")]
		[FieldOffset(Offset = "0xC8")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableHGString;

		// Token: 0x04000DBC RID: 3516
		[Token(Token = "0x4000DBC")]
		[FieldOffset(Offset = "0xD0")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableFastBattleFinish;

		// Token: 0x04000DBD RID: 3517
		[Token(Token = "0x4000DBD")]
		[FieldOffset(Offset = "0xD8")]
		private static __XLua_Gen_Delegate25 __Hotfix0_get_fastAddPages;

		// Token: 0x04000DBE RID: 3518
		[Token(Token = "0x4000DBE")]
		[FieldOffset(Offset = "0xE0")]
		private static __XLua_Gen_Delegate25 __Hotfix0_get_fastBattleFinish;

		// Token: 0x04000DBF RID: 3519
		[Token(Token = "0x4000DBF")]
		[FieldOffset(Offset = "0xE8")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableCrossAppShare;

		// Token: 0x04000DC0 RID: 3520
		[Token(Token = "0x4000DC0")]
		[FieldOffset(Offset = "0xF0")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enablePoolRelease;

		// Token: 0x04000DC1 RID: 3521
		[Token(Token = "0x4000DC1")]
		[FieldOffset(Offset = "0xF8")]
		private static __XLua_Gen_Delegate25 __Hotfix0_get_margueeType;

		// Token: 0x04000DC2 RID: 3522
		[Token(Token = "0x4000DC2")]
		[FieldOffset(Offset = "0x100")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_renderInvisibleSpine;

		// Token: 0x04000DC3 RID: 3523
		[Token(Token = "0x4000DC3")]
		[FieldOffset(Offset = "0x108")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_renderMultiPlayerInvisibleSpine;

		// Token: 0x04000DC4 RID: 3524
		[Token(Token = "0x4000DC4")]
		[FieldOffset(Offset = "0x110")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_spineTickInAdditionalFrame;

		// Token: 0x04000DC5 RID: 3525
		[Token(Token = "0x4000DC5")]
		[FieldOffset(Offset = "0x118")]
		private static __XLua_Gen_Delegate25 __Hotfix0_get_visibilityColliderBallRadius;

		// Token: 0x04000DC6 RID: 3526
		[Token(Token = "0x4000DC6")]
		[FieldOffset(Offset = "0x120")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_dontLoadSkinBeforeGameLoaded;

		// Token: 0x04000DC7 RID: 3527
		[Token(Token = "0x4000DC7")]
		[FieldOffset(Offset = "0x128")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_disableAdaptiveDynIllust;

		// Token: 0x04000DC8 RID: 3528
		[Token(Token = "0x4000DC8")]
		[FieldOffset(Offset = "0x130")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_showRecordNumber;

		// Token: 0x04000DC9 RID: 3529
		[Token(Token = "0x4000DC9")]
		[FieldOffset(Offset = "0x138")]
		private static __XLua_Gen_Delegate19 __Hotfix0_get_recordNumber;

		// Token: 0x04000DCA RID: 3530
		[Token(Token = "0x4000DCA")]
		[FieldOffset(Offset = "0x140")]
		private static __XLua_Gen_Delegate19 __Hotfix0_get_beianUrl;

		// Token: 0x04000DCB RID: 3531
		[Token(Token = "0x4000DCB")]
		[FieldOffset(Offset = "0x148")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableBattlePostprocessAA;

		// Token: 0x04000DCC RID: 3532
		[Token(Token = "0x4000DCC")]
		[FieldOffset(Offset = "0x150")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableACEService;

		// Token: 0x04000DCD RID: 3533
		[Token(Token = "0x4000DCD")]
		[FieldOffset(Offset = "0x158")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableACEData4;

		// Token: 0x04000DCE RID: 3534
		[Token(Token = "0x4000DCE")]
		[FieldOffset(Offset = "0x160")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableRoguelikeSeedMode;

		// Token: 0x04000DCF RID: 3535
		[Token(Token = "0x4000DCF")]
		[FieldOffset(Offset = "0x168")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableAVGReaderMode;

		// Token: 0x04000DD0 RID: 3536
		[Token(Token = "0x4000DD0")]
		[FieldOffset(Offset = "0x170")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableParticleEffectManager;

		// Token: 0x04000DD1 RID: 3537
		[Token(Token = "0x4000DD1")]
		[FieldOffset(Offset = "0x178")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableDynamicTree;

		// Token: 0x04000DD2 RID: 3538
		[Token(Token = "0x4000DD2")]
		[FieldOffset(Offset = "0x180")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_slowDownHudTick;

		// Token: 0x04000DD3 RID: 3539
		[Token(Token = "0x4000DD3")]
		[FieldOffset(Offset = "0x188")]
		private static __XLua_Gen_Delegate25 __Hotfix0_get_useMutliFormRate;

		// Token: 0x04000DD4 RID: 3540
		[Token(Token = "0x4000DD4")]
		[FieldOffset(Offset = "0x190")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableCameraDownScale;

		// Token: 0x04000DD5 RID: 3541
		[Token(Token = "0x4000DD5")]
		[FieldOffset(Offset = "0x198")]
		private static __XLua_Gen_Delegate25 __Hotfix0_get_battleCameraDownScaleRate;

		// Token: 0x04000DD6 RID: 3542
		[Token(Token = "0x4000DD6")]
		[FieldOffset(Offset = "0x1A0")]
		private static __XLua_Gen_Delegate25 __Hotfix0_get_bakeMuzzleEnableRate;

		// Token: 0x04000DD7 RID: 3543
		[Token(Token = "0x4000DD7")]
		[FieldOffset(Offset = "0x1A8")]
		private static __XLua_Gen_Delegate25 __Hotfix0_get_il2cppLazyLoad;

		// Token: 0x04000DD8 RID: 3544
		[Token(Token = "0x4000DD8")]
		[FieldOffset(Offset = "0x1B0")]
		private static __XLua_Gen_Delegate25 __Hotfix0_get_il2cppMmap;

		// Token: 0x04000DD9 RID: 3545
		[Token(Token = "0x4000DD9")]
		[FieldOffset(Offset = "0x1B8")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_loginDevInfo;

		// Token: 0x04000DDA RID: 3546
		[Token(Token = "0x4000DDA")]
		[FieldOffset(Offset = "0x1C0")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_enableLegacyCertValidate;

		// Token: 0x04000DDB RID: 3547
		[Token(Token = "0x4000DDB")]
		[FieldOffset(Offset = "0x1C8")]
		private static __XLua_Gen_Delegate154 __Hotfix0_SetResponse;

		// Token: 0x02000251 RID: 593
		[Token(Token = "0x2000251")]
		public class InternalConfig
		{
			// Token: 0x06000DB3 RID: 3507 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000DB3")]
			[Address(RVA = "0x5583890", Offset = "0x5582490", VA = "0x185583890")]
			public InternalConfig()
			{
			}

			// Token: 0x04000DDC RID: 3548
			[Token(Token = "0x4000DDC")]
			[FieldOffset(Offset = "0x10")]
			public bool isAuditMode;

			// Token: 0x04000DDD RID: 3549
			[Token(Token = "0x4000DDD")]
			[FieldOffset(Offset = "0x11")]
			public bool enableDBCheck;

			// Token: 0x04000DDE RID: 3550
			[Token(Token = "0x4000DDE")]
			[FieldOffset(Offset = "0x12")]
			public bool enableLuaPlayerData;

			// Token: 0x04000DDF RID: 3551
			[Token(Token = "0x4000DDF")]
			[FieldOffset(Offset = "0x13")]
			public bool enableGameBI;

			// Token: 0x04000DE0 RID: 3552
			[Token(Token = "0x4000DE0")]
			[FieldOffset(Offset = "0x14")]
			public bool enableHGSDKPollingConfirm;

			// Token: 0x04000DE1 RID: 3553
			[Token(Token = "0x4000DE1")]
			[FieldOffset(Offset = "0x18")]
			public string inlandAgeTips;

			// Token: 0x04000DE2 RID: 3554
			[Token(Token = "0x4000DE2")]
			[FieldOffset(Offset = "0x20")]
			public bool playerDeltaV2;

			// Token: 0x04000DE3 RID: 3555
			[Token(Token = "0x4000DE3")]
			[FieldOffset(Offset = "0x21")]
			public bool haltIfHotUpdateUnzipError;

			// Token: 0x04000DE4 RID: 3556
			[Token(Token = "0x4000DE4")]
			[FieldOffset(Offset = "0x22")]
			public bool enableHotUpdateLargePack;

			// Token: 0x04000DE5 RID: 3557
			[Token(Token = "0x4000DE5")]
			[FieldOffset(Offset = "0x23")]
			public bool enableIAPProdCheck;

			// Token: 0x04000DE6 RID: 3558
			[Token(Token = "0x4000DE6")]
			[FieldOffset(Offset = "0x24")]
			public bool disableGuest;

			// Token: 0x04000DE7 RID: 3559
			[Token(Token = "0x4000DE7")]
			[FieldOffset(Offset = "0x25")]
			public bool enableNetCheck;

			// Token: 0x04000DE8 RID: 3560
			[Token(Token = "0x4000DE8")]
			[FieldOffset(Offset = "0x26")]
			public bool announceUseWeb;

			// Token: 0x04000DE9 RID: 3561
			[Token(Token = "0x4000DE9")]
			[FieldOffset(Offset = "0x27")]
			public bool disableBsonBuffTemplate;

			// Token: 0x04000DEA RID: 3562
			[Token(Token = "0x4000DEA")]
			[FieldOffset(Offset = "0x28")]
			public int HGDownload_1;

			// Token: 0x04000DEB RID: 3563
			[Token(Token = "0x4000DEB")]
			[FieldOffset(Offset = "0x2C")]
			public int HGDownload_2;

			// Token: 0x04000DEC RID: 3564
			[Token(Token = "0x4000DEC")]
			[FieldOffset(Offset = "0x30")]
			public bool enableAsyncResCheck;

			// Token: 0x04000DED RID: 3565
			[Token(Token = "0x4000DED")]
			[FieldOffset(Offset = "0x34")]
			public int effectPreloadStripBound;

			// Token: 0x04000DEE RID: 3566
			[Token(Token = "0x4000DEE")]
			[FieldOffset(Offset = "0x38")]
			public bool disableGatherEffect;

			// Token: 0x04000DEF RID: 3567
			[Token(Token = "0x4000DEF")]
			[FieldOffset(Offset = "0x39")]
			public bool enableBattleAnimationLazyLoad;

			// Token: 0x04000DF0 RID: 3568
			[Token(Token = "0x4000DF0")]
			[FieldOffset(Offset = "0x3A")]
			public bool enableNativeLicense;

			// Token: 0x04000DF1 RID: 3569
			[Token(Token = "0x4000DF1")]
			[FieldOffset(Offset = "0x3B")]
			public bool enableBattleDeckHiddenReason;

			// Token: 0x04000DF2 RID: 3570
			[Token(Token = "0x4000DF2")]
			[FieldOffset(Offset = "0x3C")]
			public bool enableHGString;

			// Token: 0x04000DF3 RID: 3571
			[Token(Token = "0x4000DF3")]
			[FieldOffset(Offset = "0x3D")]
			public bool enableFastBattleFinish;

			// Token: 0x04000DF4 RID: 3572
			[Token(Token = "0x4000DF4")]
			[FieldOffset(Offset = "0x3E")]
			public bool enableCrossAppShare;

			// Token: 0x04000DF5 RID: 3573
			[Token(Token = "0x4000DF5")]
			[FieldOffset(Offset = "0x3F")]
			public bool enablePoolRelease;

			// Token: 0x04000DF6 RID: 3574
			[Token(Token = "0x4000DF6")]
			[FieldOffset(Offset = "0x40")]
			public int marqueeType;

			// Token: 0x04000DF7 RID: 3575
			[Token(Token = "0x4000DF7")]
			[FieldOffset(Offset = "0x44")]
			public bool renderInvisibleSpine;

			// Token: 0x04000DF8 RID: 3576
			[Token(Token = "0x4000DF8")]
			[FieldOffset(Offset = "0x45")]
			public bool renderMultiPlayerInvisibleSpine;

			// Token: 0x04000DF9 RID: 3577
			[Token(Token = "0x4000DF9")]
			[FieldOffset(Offset = "0x46")]
			public bool spineTickInAdditionalFrame;

			// Token: 0x04000DFA RID: 3578
			[Token(Token = "0x4000DFA")]
			[FieldOffset(Offset = "0x48")]
			public int visibilityColliderBallRadius;

			// Token: 0x04000DFB RID: 3579
			[Token(Token = "0x4000DFB")]
			[FieldOffset(Offset = "0x4C")]
			public bool dontLoadSkinBeforeGameLoaded;

			// Token: 0x04000DFC RID: 3580
			[Token(Token = "0x4000DFC")]
			[FieldOffset(Offset = "0x4D")]
			public bool disableAdaptiveDynIllust;

			// Token: 0x04000DFD RID: 3581
			[Token(Token = "0x4000DFD")]
			[FieldOffset(Offset = "0x4E")]
			public bool showRecordNumber;

			// Token: 0x04000DFE RID: 3582
			[Token(Token = "0x4000DFE")]
			[FieldOffset(Offset = "0x50")]
			public string recordNumber;

			// Token: 0x04000DFF RID: 3583
			[Token(Token = "0x4000DFF")]
			[FieldOffset(Offset = "0x58")]
			public string beianUrl;

			// Token: 0x04000E00 RID: 3584
			[Token(Token = "0x4000E00")]
			[FieldOffset(Offset = "0x60")]
			public int fapv3;

			// Token: 0x04000E01 RID: 3585
			[Token(Token = "0x4000E01")]
			[FieldOffset(Offset = "0x64")]
			public int fastBattleFinish;

			// Token: 0x04000E02 RID: 3586
			[Token(Token = "0x4000E02")]
			[FieldOffset(Offset = "0x68")]
			public bool enableBattlePostprocessAA;

			// Token: 0x04000E03 RID: 3587
			[Token(Token = "0x4000E03")]
			[FieldOffset(Offset = "0x69")]
			public bool enableACEService;

			// Token: 0x04000E04 RID: 3588
			[Token(Token = "0x4000E04")]
			[FieldOffset(Offset = "0x6A")]
			public bool enableACEData4;

			// Token: 0x04000E05 RID: 3589
			[Token(Token = "0x4000E05")]
			[FieldOffset(Offset = "0x6B")]
			public bool enableRoguelikeSeedMode;

			// Token: 0x04000E06 RID: 3590
			[Token(Token = "0x4000E06")]
			[FieldOffset(Offset = "0x6C")]
			public bool enableParticleEffectManager;

			// Token: 0x04000E07 RID: 3591
			[Token(Token = "0x4000E07")]
			[FieldOffset(Offset = "0x6D")]
			public bool enableDynamicTree;

			// Token: 0x04000E08 RID: 3592
			[Token(Token = "0x4000E08")]
			[FieldOffset(Offset = "0x6E")]
			public bool enableCameraDownScale;

			// Token: 0x04000E09 RID: 3593
			[Token(Token = "0x4000E09")]
			[FieldOffset(Offset = "0x70")]
			public int battleCameraDownScaleRate;

			// Token: 0x04000E0A RID: 3594
			[Token(Token = "0x4000E0A")]
			[FieldOffset(Offset = "0x74")]
			public int bakeMuzzleEnableRate;

			// Token: 0x04000E0B RID: 3595
			[Token(Token = "0x4000E0B")]
			[FieldOffset(Offset = "0x78")]
			public bool slowDownHudTick;

			// Token: 0x04000E0C RID: 3596
			[Token(Token = "0x4000E0C")]
			[FieldOffset(Offset = "0x79")]
			public bool useClipboardParams;

			// Token: 0x04000E0D RID: 3597
			[Token(Token = "0x4000E0D")]
			[FieldOffset(Offset = "0x7A")]
			public bool enableAVGReaderMode;

			// Token: 0x04000E0E RID: 3598
			[Token(Token = "0x4000E0E")]
			[FieldOffset(Offset = "0x7C")]
			public int il2cppLazyLoad;

			// Token: 0x04000E0F RID: 3599
			[Token(Token = "0x4000E0F")]
			[FieldOffset(Offset = "0x80")]
			public int il2cppMmap;

			// Token: 0x04000E10 RID: 3600
			[Token(Token = "0x4000E10")]
			[FieldOffset(Offset = "0x84")]
			public int useMultiFormRate;

			// Token: 0x04000E11 RID: 3601
			[Token(Token = "0x4000E11")]
			[FieldOffset(Offset = "0x88")]
			public bool loginDevInfo;

			// Token: 0x04000E12 RID: 3602
			[Token(Token = "0x4000E12")]
			[FieldOffset(Offset = "0x89")]
			public bool enableLegacyCertValidate;
		}
	}
}
