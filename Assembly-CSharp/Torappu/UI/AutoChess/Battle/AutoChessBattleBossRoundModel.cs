using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using Torappu.Battle.DataCenter;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x02006489 RID: 25737
	[Token(Token = "0x2006489")]
	public class AutoChessBattleBossRoundModel : IHotfixable
	{
		// Token: 0x1700575E RID: 22366
		// (get) Token: 0x0602504C RID: 151628 RVA: 0x000C62B8 File Offset: 0x000C44B8
		// (set) Token: 0x0602504D RID: 151629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700575E")]
		public AutoChessBattleBossRoundModel.AnimStatus animStatus
		{
			[Token(Token = "0x602504C")]
			[Address(RVA = "0x1FDCE30", Offset = "0x1FDBA30", VA = "0x181FDCE30")]
			[CompilerGenerated]
			get
			{
				return AutoChessBattleBossRoundModel.AnimStatus.NONE;
			}
			[Token(Token = "0x602504D")]
			[Address(RVA = "0x1FDD0D0", Offset = "0x1FDBCD0", VA = "0x181FDD0D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700575F RID: 22367
		// (get) Token: 0x0602504E RID: 151630 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602504F RID: 151631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700575F")]
		public string bossEnemyId
		{
			[Token(Token = "0x602504E")]
			[Address(RVA = "0x1FDCE90", Offset = "0x1FDBA90", VA = "0x181FDCE90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602504F")]
			[Address(RVA = "0x1FDD140", Offset = "0x1FDBD40", VA = "0x181FDD140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005760 RID: 22368
		// (get) Token: 0x06025050 RID: 151632 RVA: 0x000C62D0 File Offset: 0x000C44D0
		// (set) Token: 0x06025051 RID: 151633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005760")]
		public bool inBossRound
		{
			[Token(Token = "0x6025050")]
			[Address(RVA = "0x1FDCEF0", Offset = "0x1FDBAF0", VA = "0x181FDCEF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025051")]
			[Address(RVA = "0x1FDD1C0", Offset = "0x1FDBDC0", VA = "0x181FDD1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005761 RID: 22369
		// (get) Token: 0x06025052 RID: 151634 RVA: 0x000C62E8 File Offset: 0x000C44E8
		// (set) Token: 0x06025053 RID: 151635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005761")]
		public bool isHiddenBoss
		{
			[Token(Token = "0x6025052")]
			[Address(RVA = "0x1FDCF50", Offset = "0x1FDBB50", VA = "0x181FDCF50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025053")]
			[Address(RVA = "0x1FDD230", Offset = "0x1FDBE30", VA = "0x181FDD230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005762 RID: 22370
		// (get) Token: 0x06025054 RID: 151636 RVA: 0x000C6300 File Offset: 0x000C4500
		// (set) Token: 0x06025055 RID: 151637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005762")]
		public int playerTotalHp
		{
			[Token(Token = "0x6025054")]
			[Address(RVA = "0x1FDD070", Offset = "0x1FDBC70", VA = "0x181FDD070")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6025055")]
			[Address(RVA = "0x1FDD2A0", Offset = "0x1FDBEA0", VA = "0x181FDD2A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005763 RID: 22371
		// (get) Token: 0x06025056 RID: 151638 RVA: 0x000C6318 File Offset: 0x000C4518
		[Token(Token = "0x17005763")]
		public bool isSingleMode
		{
			[Token(Token = "0x6025056")]
			[Address(RVA = "0x1FDD010", Offset = "0x1FDBC10", VA = "0x181FDD010")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005764 RID: 22372
		// (get) Token: 0x06025057 RID: 151639 RVA: 0x000C6330 File Offset: 0x000C4530
		[Token(Token = "0x17005764")]
		public bool isLocalMode
		{
			[Token(Token = "0x6025057")]
			[Address(RVA = "0x1FDCFB0", Offset = "0x1FDBBB0", VA = "0x181FDCFB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06025058 RID: 151640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025058")]
		[Address(RVA = "0x1FDCBD0", Offset = "0x1FDB7D0", VA = "0x181FDCBD0")]
		public void Update(AutoChessDataCenter dataCenter, AutoChessGameStatus gameStatus)
		{
		}

		// Token: 0x06025059 RID: 151641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025059")]
		[Address(RVA = "0x1FDCDD0", Offset = "0x1FDB9D0", VA = "0x181FDCDD0")]
		public AutoChessBattleBossRoundModel()
		{
		}

		// Token: 0x04033CFC RID: 212220
		[Token(Token = "0x4033CFC")]
		[FieldOffset(Offset = "0x10")]
		private ActAutoChessModeType m_modeType;

		// Token: 0x04033D02 RID: 212226
		[Token(Token = "0x4033D02")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_animStatus;

		// Token: 0x04033D03 RID: 212227
		[Token(Token = "0x4033D03")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_animStatus;

		// Token: 0x04033D04 RID: 212228
		[Token(Token = "0x4033D04")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_bossEnemyId;

		// Token: 0x04033D05 RID: 212229
		[Token(Token = "0x4033D05")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_bossEnemyId;

		// Token: 0x04033D06 RID: 212230
		[Token(Token = "0x4033D06")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_inBossRound;

		// Token: 0x04033D07 RID: 212231
		[Token(Token = "0x4033D07")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_inBossRound;

		// Token: 0x04033D08 RID: 212232
		[Token(Token = "0x4033D08")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isHiddenBoss;

		// Token: 0x04033D09 RID: 212233
		[Token(Token = "0x4033D09")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_isHiddenBoss;

		// Token: 0x04033D0A RID: 212234
		[Token(Token = "0x4033D0A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_playerTotalHp;

		// Token: 0x04033D0B RID: 212235
		[Token(Token = "0x4033D0B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_playerTotalHp;

		// Token: 0x04033D0C RID: 212236
		[Token(Token = "0x4033D0C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_isSingleMode;

		// Token: 0x04033D0D RID: 212237
		[Token(Token = "0x4033D0D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_isLocalMode;

		// Token: 0x04033D0E RID: 212238
		[Token(Token = "0x4033D0E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04033D0F RID: 212239
		[Token(Token = "0x4033D0F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200648A RID: 25738
		[Token(Token = "0x200648A")]
		public enum AnimStatus
		{
			// Token: 0x04033D11 RID: 212241
			[Token(Token = "0x4033D11")]
			NONE,
			// Token: 0x04033D12 RID: 212242
			[Token(Token = "0x4033D12")]
			ENTER,
			// Token: 0x04033D13 RID: 212243
			[Token(Token = "0x4033D13")]
			EXPAND,
			// Token: 0x04033D14 RID: 212244
			[Token(Token = "0x4033D14")]
			EXIT
		}
	}
}
