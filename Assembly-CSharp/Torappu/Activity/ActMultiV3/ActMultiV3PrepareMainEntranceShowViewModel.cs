using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Multiplayer.Servers;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F8B RID: 28555
	[Token(Token = "0x2006F8B")]
	public class ActMultiV3PrepareMainEntranceShowViewModel : IHotfixable
	{
		// Token: 0x17005F85 RID: 24453
		// (get) Token: 0x06028868 RID: 165992 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028869 RID: 165993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F85")]
		public string actId
		{
			[Token(Token = "0x6028868")]
			[Address(RVA = "0x23DCE00", Offset = "0x23DBA00", VA = "0x1823DCE00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028869")]
			[Address(RVA = "0x23DD5E0", Offset = "0x23DC1E0", VA = "0x1823DD5E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005F86 RID: 24454
		// (get) Token: 0x0602886A RID: 165994 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602886B RID: 165995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F86")]
		public TeamProtocol.STPlayerStatus selfStatus
		{
			[Token(Token = "0x602886A")]
			[Address(RVA = "0x23DD520", Offset = "0x23DC120", VA = "0x1823DD520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602886B")]
			[Address(RVA = "0x23DDC40", Offset = "0x23DC840", VA = "0x1823DDC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005F87 RID: 24455
		// (get) Token: 0x0602886C RID: 165996 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602886D RID: 165997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F87")]
		public TeamProtocol.STPlayerStatus partnerStatus
		{
			[Token(Token = "0x602886C")]
			[Address(RVA = "0x23DD320", Offset = "0x23DBF20", VA = "0x1823DD320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602886D")]
			[Address(RVA = "0x23DD9C0", Offset = "0x23DC5C0", VA = "0x1823DD9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005F88 RID: 24456
		// (get) Token: 0x0602886E RID: 165998 RVA: 0x000D1FD0 File Offset: 0x000D01D0
		[Token(Token = "0x17005F88")]
		public bool isSelfReady
		{
			[Token(Token = "0x602886E")]
			[Address(RVA = "0x23DD080", Offset = "0x23DBC80", VA = "0x1823DD080")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005F89 RID: 24457
		// (get) Token: 0x0602886F RID: 165999 RVA: 0x000D1FE8 File Offset: 0x000D01E8
		[Token(Token = "0x17005F89")]
		public bool isPartnerReady
		{
			[Token(Token = "0x602886F")]
			[Address(RVA = "0x23DCF20", Offset = "0x23DBB20", VA = "0x1823DCF20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005F8A RID: 24458
		// (get) Token: 0x06028870 RID: 166000 RVA: 0x000D2000 File Offset: 0x000D0200
		// (set) Token: 0x06028871 RID: 166001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F8A")]
		public bool isFlipMode
		{
			[Token(Token = "0x6028870")]
			[Address(RVA = "0x23DCEC0", Offset = "0x23DBAC0", VA = "0x1823DCEC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028871")]
			[Address(RVA = "0x23DD6D0", Offset = "0x23DC2D0", VA = "0x1823DD6D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005F8B RID: 24459
		// (get) Token: 0x06028872 RID: 166002 RVA: 0x000D2018 File Offset: 0x000D0218
		// (set) Token: 0x06028873 RID: 166003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F8B")]
		public int enterSeqNum
		{
			[Token(Token = "0x6028872")]
			[Address(RVA = "0x23DCE60", Offset = "0x23DBA60", VA = "0x1823DCE60")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028873")]
			[Address(RVA = "0x23DD660", Offset = "0x23DC260", VA = "0x1823DD660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005F8C RID: 24460
		// (get) Token: 0x06028874 RID: 166004 RVA: 0x000D2030 File Offset: 0x000D0230
		// (set) Token: 0x06028875 RID: 166005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F8C")]
		public float playerShowTime
		{
			[Token(Token = "0x6028874")]
			[Address(RVA = "0x23DD380", Offset = "0x23DBF80", VA = "0x1823DD380")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6028875")]
			[Address(RVA = "0x23DDA40", Offset = "0x23DC640", VA = "0x1823DDA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005F8D RID: 24461
		// (get) Token: 0x06028876 RID: 166006 RVA: 0x000D2048 File Offset: 0x000D0248
		// (set) Token: 0x06028877 RID: 166007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F8D")]
		public CharUISkinStruct selfAssitSkin
		{
			[Token(Token = "0x6028876")]
			[Address(RVA = "0x23DD3E0", Offset = "0x23DBFE0", VA = "0x1823DD3E0")]
			[CompilerGenerated]
			get
			{
				return default(CharUISkinStruct);
			}
			[Token(Token = "0x6028877")]
			[Address(RVA = "0x23DDAB0", Offset = "0x23DC6B0", VA = "0x1823DDAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005F8E RID: 24462
		// (get) Token: 0x06028878 RID: 166008 RVA: 0x000D2060 File Offset: 0x000D0260
		// (set) Token: 0x06028879 RID: 166009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F8E")]
		public CharUISkinStruct partnerAssitSkin
		{
			[Token(Token = "0x6028878")]
			[Address(RVA = "0x23DD1E0", Offset = "0x23DBDE0", VA = "0x1823DD1E0")]
			[CompilerGenerated]
			get
			{
				return default(CharUISkinStruct);
			}
			[Token(Token = "0x6028879")]
			[Address(RVA = "0x23DD820", Offset = "0x23DC420", VA = "0x1823DD820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005F8F RID: 24463
		// (get) Token: 0x0602887A RID: 166010 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602887B RID: 166011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F8F")]
		public ActMultiV3StageDetailViewModel stageDetailViewModel
		{
			[Token(Token = "0x602887A")]
			[Address(RVA = "0x23DD580", Offset = "0x23DC180", VA = "0x1823DD580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602887B")]
			[Address(RVA = "0x23DDCC0", Offset = "0x23DC8C0", VA = "0x1823DDCC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005F90 RID: 24464
		// (get) Token: 0x0602887C RID: 166012 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602887D RID: 166013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F90")]
		public string selfEffectIconId
		{
			[Token(Token = "0x602887C")]
			[Address(RVA = "0x23DD460", Offset = "0x23DC060", VA = "0x1823DD460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602887D")]
			[Address(RVA = "0x23DDB40", Offset = "0x23DC740", VA = "0x1823DDB40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005F91 RID: 24465
		// (get) Token: 0x0602887E RID: 166014 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602887F RID: 166015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F91")]
		public string selfEffectName
		{
			[Token(Token = "0x602887E")]
			[Address(RVA = "0x23DD4C0", Offset = "0x23DC0C0", VA = "0x1823DD4C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602887F")]
			[Address(RVA = "0x23DDBC0", Offset = "0x23DC7C0", VA = "0x1823DDBC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005F92 RID: 24466
		// (get) Token: 0x06028880 RID: 166016 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028881 RID: 166017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F92")]
		public string partnerEffectIconId
		{
			[Token(Token = "0x6028880")]
			[Address(RVA = "0x23DD260", Offset = "0x23DBE60", VA = "0x1823DD260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028881")]
			[Address(RVA = "0x23DD8C0", Offset = "0x23DC4C0", VA = "0x1823DD8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005F93 RID: 24467
		// (get) Token: 0x06028882 RID: 166018 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028883 RID: 166019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F93")]
		public string partnerEffectName
		{
			[Token(Token = "0x6028882")]
			[Address(RVA = "0x23DD2C0", Offset = "0x23DBEC0", VA = "0x1823DD2C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028883")]
			[Address(RVA = "0x23DD940", Offset = "0x23DC540", VA = "0x1823DD940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005F94 RID: 24468
		// (get) Token: 0x06028884 RID: 166020 RVA: 0x000D2078 File Offset: 0x000D0278
		// (set) Token: 0x06028885 RID: 166021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F94")]
		public bool isShow
		{
			[Token(Token = "0x6028884")]
			[Address(RVA = "0x23DD180", Offset = "0x23DBD80", VA = "0x1823DD180")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028885")]
			[Address(RVA = "0x23DD7B0", Offset = "0x23DC3B0", VA = "0x1823DD7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005F95 RID: 24469
		// (get) Token: 0x06028886 RID: 166022 RVA: 0x000D2090 File Offset: 0x000D0290
		// (set) Token: 0x06028887 RID: 166023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F95")]
		public bool isPlayerDataReady
		{
			[Token(Token = "0x6028886")]
			[Address(RVA = "0x23DD020", Offset = "0x23DBC20", VA = "0x1823DD020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028887")]
			[Address(RVA = "0x23DD740", Offset = "0x23DC340", VA = "0x1823DD740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06028888 RID: 166024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028888")]
		[Address(RVA = "0x23DC210", Offset = "0x23DAE10", VA = "0x1823DC210")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x06028889 RID: 166025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028889")]
		[Address(RVA = "0x23DC5A0", Offset = "0x23DB1A0", VA = "0x1823DC5A0")]
		public void UpdatePlayerShowData()
		{
		}

		// Token: 0x0602888A RID: 166026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602888A")]
		[Address(RVA = "0x23DC4A0", Offset = "0x23DB0A0", VA = "0x1823DC4A0")]
		public void NotifyEnter()
		{
		}

		// Token: 0x0602888B RID: 166027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602888B")]
		[Address(RVA = "0x23DCDA0", Offset = "0x23DB9A0", VA = "0x1823DCDA0")]
		public ActMultiV3PrepareMainEntranceShowViewModel()
		{
		}

		// Token: 0x04039B43 RID: 236355
		[Token(Token = "0x4039B43")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x04039B44 RID: 236356
		[Token(Token = "0x4039B44")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x04039B45 RID: 236357
		[Token(Token = "0x4039B45")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selfStatus;

		// Token: 0x04039B46 RID: 236358
		[Token(Token = "0x4039B46")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_selfStatus;

		// Token: 0x04039B47 RID: 236359
		[Token(Token = "0x4039B47")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_partnerStatus;

		// Token: 0x04039B48 RID: 236360
		[Token(Token = "0x4039B48")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_partnerStatus;

		// Token: 0x04039B49 RID: 236361
		[Token(Token = "0x4039B49")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isSelfReady;

		// Token: 0x04039B4A RID: 236362
		[Token(Token = "0x4039B4A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isPartnerReady;

		// Token: 0x04039B4B RID: 236363
		[Token(Token = "0x4039B4B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isFlipMode;

		// Token: 0x04039B4C RID: 236364
		[Token(Token = "0x4039B4C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_isFlipMode;

		// Token: 0x04039B4D RID: 236365
		[Token(Token = "0x4039B4D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_enterSeqNum;

		// Token: 0x04039B4E RID: 236366
		[Token(Token = "0x4039B4E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_enterSeqNum;

		// Token: 0x04039B4F RID: 236367
		[Token(Token = "0x4039B4F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_playerShowTime;

		// Token: 0x04039B50 RID: 236368
		[Token(Token = "0x4039B50")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_playerShowTime;

		// Token: 0x04039B51 RID: 236369
		[Token(Token = "0x4039B51")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_selfAssitSkin;

		// Token: 0x04039B52 RID: 236370
		[Token(Token = "0x4039B52")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_selfAssitSkin;

		// Token: 0x04039B53 RID: 236371
		[Token(Token = "0x4039B53")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_partnerAssitSkin;

		// Token: 0x04039B54 RID: 236372
		[Token(Token = "0x4039B54")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_partnerAssitSkin;

		// Token: 0x04039B55 RID: 236373
		[Token(Token = "0x4039B55")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_stageDetailViewModel;

		// Token: 0x04039B56 RID: 236374
		[Token(Token = "0x4039B56")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_stageDetailViewModel;

		// Token: 0x04039B57 RID: 236375
		[Token(Token = "0x4039B57")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_selfEffectIconId;

		// Token: 0x04039B58 RID: 236376
		[Token(Token = "0x4039B58")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_selfEffectIconId;

		// Token: 0x04039B59 RID: 236377
		[Token(Token = "0x4039B59")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_selfEffectName;

		// Token: 0x04039B5A RID: 236378
		[Token(Token = "0x4039B5A")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_set_selfEffectName;

		// Token: 0x04039B5B RID: 236379
		[Token(Token = "0x4039B5B")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_partnerEffectIconId;

		// Token: 0x04039B5C RID: 236380
		[Token(Token = "0x4039B5C")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_set_partnerEffectIconId;

		// Token: 0x04039B5D RID: 236381
		[Token(Token = "0x4039B5D")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_partnerEffectName;

		// Token: 0x04039B5E RID: 236382
		[Token(Token = "0x4039B5E")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_set_partnerEffectName;

		// Token: 0x04039B5F RID: 236383
		[Token(Token = "0x4039B5F")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04039B60 RID: 236384
		[Token(Token = "0x4039B60")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_set_isShow;

		// Token: 0x04039B61 RID: 236385
		[Token(Token = "0x4039B61")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_isPlayerDataReady;

		// Token: 0x04039B62 RID: 236386
		[Token(Token = "0x4039B62")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_set_isPlayerDataReady;

		// Token: 0x04039B63 RID: 236387
		[Token(Token = "0x4039B63")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039B64 RID: 236388
		[Token(Token = "0x4039B64")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_UpdatePlayerShowData;

		// Token: 0x04039B65 RID: 236389
		[Token(Token = "0x4039B65")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_NotifyEnter;

		// Token: 0x04039B66 RID: 236390
		[Token(Token = "0x4039B66")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
