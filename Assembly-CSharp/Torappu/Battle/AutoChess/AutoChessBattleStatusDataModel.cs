using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.DataCenter;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002778 RID: 10104
	[Token(Token = "0x2002778")]
	public class AutoChessBattleStatusDataModel : AutoChessDataCenter.AutoChessDataModelBase
	{
		// Token: 0x170023FB RID: 9211
		// (get) Token: 0x060107D7 RID: 67543 RVA: 0x00064848 File Offset: 0x00062A48
		// (set) Token: 0x060107D8 RID: 67544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170023FB")]
		public bool battleFinished
		{
			[Token(Token = "0x60107D7")]
			[Address(RVA = "0x84A8C0", Offset = "0x8494C0", VA = "0x18084A8C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60107D8")]
			[Address(RVA = "0x84AB90", Offset = "0x849790", VA = "0x18084AB90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170023FC RID: 9212
		// (get) Token: 0x060107D9 RID: 67545 RVA: 0x00064860 File Offset: 0x00062A60
		[Token(Token = "0x170023FC")]
		public int enemyCntInTotal
		{
			[Token(Token = "0x60107D9")]
			[Address(RVA = "0x84AA10", Offset = "0x849610", VA = "0x18084AA10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170023FD RID: 9213
		// (get) Token: 0x060107DA RID: 67546 RVA: 0x00064878 File Offset: 0x00062A78
		[Token(Token = "0x170023FD")]
		public int enemyEscapedDisplay
		{
			[Token(Token = "0x60107DA")]
			[Address(RVA = "0x84AA90", Offset = "0x849690", VA = "0x18084AA90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170023FE RID: 9214
		// (get) Token: 0x060107DB RID: 67547 RVA: 0x00064890 File Offset: 0x00062A90
		[Token(Token = "0x170023FE")]
		public int curEnemyCnt
		{
			[Token(Token = "0x60107DB")]
			[Address(RVA = "0x84A990", Offset = "0x849590", VA = "0x18084A990")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170023FF RID: 9215
		// (get) Token: 0x060107DC RID: 67548 RVA: 0x000648A8 File Offset: 0x00062AA8
		[Token(Token = "0x170023FF")]
		public int lostHpDisplay
		{
			[Token(Token = "0x60107DC")]
			[Address(RVA = "0x84AB10", Offset = "0x849710", VA = "0x18084AB10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17002400 RID: 9216
		// (get) Token: 0x060107DD RID: 67549 RVA: 0x000648C0 File Offset: 0x00062AC0
		[Token(Token = "0x17002400")]
		public float bossHpRatio
		{
			[Token(Token = "0x60107DD")]
			[Address(RVA = "0x84A920", Offset = "0x849520", VA = "0x18084A920")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060107DE RID: 67550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107DE")]
		[Address(RVA = "0x84A330", Offset = "0x848F30", VA = "0x18084A330")]
		public void ResetStatus()
		{
		}

		// Token: 0x060107DF RID: 67551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107DF")]
		[Address(RVA = "0x8493C0", Offset = "0x847FC0", VA = "0x1808493C0")]
		public void OnBattleFinish()
		{
		}

		// Token: 0x060107E0 RID: 67552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107E0")]
		[Address(RVA = "0x849470", Offset = "0x848070", VA = "0x180849470")]
		public void OnBattleStart(LevelData levelData)
		{
		}

		// Token: 0x060107E1 RID: 67553 RVA: 0x000648D8 File Offset: 0x00062AD8
		[Token(Token = "0x60107E1")]
		[Address(RVA = "0x84A3A0", Offset = "0x848FA0", VA = "0x18084A3A0")]
		private int _GetBossRoundHpReduceTime()
		{
			return 0;
		}

		// Token: 0x060107E2 RID: 67554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107E2")]
		[Address(RVA = "0x849EE0", Offset = "0x848AE0", VA = "0x180849EE0")]
		public void OnSelfBattleEnemyKilled(Enemy enemy)
		{
		}

		// Token: 0x060107E3 RID: 67555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107E3")]
		[Address(RVA = "0x84A100", Offset = "0x848D00", VA = "0x18084A100")]
		public void OnSelfBattleEnemyReachExit(Enemy enemy)
		{
		}

		// Token: 0x060107E4 RID: 67556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107E4")]
		[Address(RVA = "0x849A60", Offset = "0x848660", VA = "0x180849A60")]
		public void OnHelpBattleEnemyKilled(Enemy enemy)
		{
		}

		// Token: 0x060107E5 RID: 67557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107E5")]
		[Address(RVA = "0x849D50", Offset = "0x848950", VA = "0x180849D50")]
		public void OnHelpBattleEnemyReachExit(Enemy enemy)
		{
		}

		// Token: 0x060107E6 RID: 67558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107E6")]
		[Address(RVA = "0x8496B0", Offset = "0x8482B0", VA = "0x1808496B0")]
		public void OnBossStateChanged(Enemy boss, int bossHp)
		{
		}

		// Token: 0x060107E7 RID: 67559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107E7")]
		[Address(RVA = "0x8499B0", Offset = "0x8485B0", VA = "0x1808499B0")]
		public void OnBossTeamStateChanged(int teamHp, int battleProgress)
		{
		}

		// Token: 0x060107E8 RID: 67560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107E8")]
		[Address(RVA = "0x84A5B0", Offset = "0x8491B0", VA = "0x18084A5B0")]
		public AutoChessBattleStatusDataModel()
		{
		}

		// Token: 0x040127BC RID: 75708
		[Token(Token = "0x40127BC")]
		[FieldOffset(Offset = "0x18")]
		public DateTime battleStartTime;

		// Token: 0x040127BD RID: 75709
		[Token(Token = "0x40127BD")]
		[FieldOffset(Offset = "0x20")]
		public DateTime battleNormalEndTime;

		// Token: 0x040127BE RID: 75710
		[Token(Token = "0x40127BE")]
		[FieldOffset(Offset = "0x28")]
		private AutoChessBattleStatusDataModel.IRoundStatus m_roundStatus;

		// Token: 0x040127BF RID: 75711
		[Token(Token = "0x40127BF")]
		[FieldOffset(Offset = "0x30")]
		public AutoChessBattleStatusDataModel.SelfBattleRoundStatus selfBattleStatus;

		// Token: 0x040127C0 RID: 75712
		[Token(Token = "0x40127C0")]
		[FieldOffset(Offset = "0x38")]
		public AutoChessBattleStatusDataModel.HelpBattleRoundStatus helpBattleStatus;

		// Token: 0x040127C1 RID: 75713
		[Token(Token = "0x40127C1")]
		[FieldOffset(Offset = "0x40")]
		public AutoChessBattleStatusDataModel.BossBattleRoundStatus bossBattleStatus;

		// Token: 0x040127C3 RID: 75715
		[Token(Token = "0x40127C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_battleFinished;

		// Token: 0x040127C4 RID: 75716
		[Token(Token = "0x40127C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_battleFinished;

		// Token: 0x040127C5 RID: 75717
		[Token(Token = "0x40127C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enemyCntInTotal;

		// Token: 0x040127C6 RID: 75718
		[Token(Token = "0x40127C6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enemyEscapedDisplay;

		// Token: 0x040127C7 RID: 75719
		[Token(Token = "0x40127C7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_curEnemyCnt;

		// Token: 0x040127C8 RID: 75720
		[Token(Token = "0x40127C8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_lostHpDisplay;

		// Token: 0x040127C9 RID: 75721
		[Token(Token = "0x40127C9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_bossHpRatio;

		// Token: 0x040127CA RID: 75722
		[Token(Token = "0x40127CA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ResetStatus;

		// Token: 0x040127CB RID: 75723
		[Token(Token = "0x40127CB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBattleFinish;

		// Token: 0x040127CC RID: 75724
		[Token(Token = "0x40127CC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnBattleStart;

		// Token: 0x040127CD RID: 75725
		[Token(Token = "0x40127CD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetBossRoundHpReduceTime;

		// Token: 0x040127CE RID: 75726
		[Token(Token = "0x40127CE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnSelfBattleEnemyKilled;

		// Token: 0x040127CF RID: 75727
		[Token(Token = "0x40127CF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnSelfBattleEnemyReachExit;

		// Token: 0x040127D0 RID: 75728
		[Token(Token = "0x40127D0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnHelpBattleEnemyKilled;

		// Token: 0x040127D1 RID: 75729
		[Token(Token = "0x40127D1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnHelpBattleEnemyReachExit;

		// Token: 0x040127D2 RID: 75730
		[Token(Token = "0x40127D2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnBossStateChanged;

		// Token: 0x040127D3 RID: 75731
		[Token(Token = "0x40127D3")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnBossTeamStateChanged;

		// Token: 0x040127D4 RID: 75732
		[Token(Token = "0x40127D4")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002779 RID: 10105
		[Token(Token = "0x2002779")]
		private interface IRoundStatus
		{
			// Token: 0x17002401 RID: 9217
			// (get) Token: 0x060107E9 RID: 67561
			[Token(Token = "0x17002401")]
			int enemyCntInTotal { [Token(Token = "0x60107E9")] get; }

			// Token: 0x17002402 RID: 9218
			// (get) Token: 0x060107EA RID: 67562
			[Token(Token = "0x17002402")]
			int enemyEscapedDisplay { [Token(Token = "0x60107EA")] get; }

			// Token: 0x17002403 RID: 9219
			// (get) Token: 0x060107EB RID: 67563
			[Token(Token = "0x17002403")]
			int curEnemyCnt { [Token(Token = "0x60107EB")] get; }

			// Token: 0x17002404 RID: 9220
			// (get) Token: 0x060107EC RID: 67564
			[Token(Token = "0x17002404")]
			int lostHpDisplay { [Token(Token = "0x60107EC")] get; }

			// Token: 0x060107ED RID: 67565
			[Token(Token = "0x60107ED")]
			void Reset();
		}

		// Token: 0x0200277A RID: 10106
		[Token(Token = "0x200277A")]
		public class SelfBattleRoundStatus : IHotfixable, AutoChessBattleStatusDataModel.IRoundStatus
		{
			// Token: 0x17002405 RID: 9221
			// (get) Token: 0x060107EE RID: 67566 RVA: 0x000648F0 File Offset: 0x00062AF0
			// (set) Token: 0x060107EF RID: 67567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002405")]
			public int enemyCntInTotal
			{
				[Token(Token = "0x60107EE")]
				[Address(RVA = "0x8575F0", Offset = "0x8561F0", VA = "0x1808575F0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60107EF")]
				[Address(RVA = "0x857710", Offset = "0x856310", VA = "0x180857710")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17002406 RID: 9222
			// (get) Token: 0x060107F0 RID: 67568 RVA: 0x00064908 File Offset: 0x00062B08
			[Token(Token = "0x17002406")]
			public int curEnemyCnt
			{
				[Token(Token = "0x60107F0")]
				[Address(RVA = "0x857530", Offset = "0x856130", VA = "0x180857530", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002407 RID: 9223
			// (get) Token: 0x060107F1 RID: 67569 RVA: 0x00064920 File Offset: 0x00062B20
			[Token(Token = "0x17002407")]
			public int enemyEscapedDisplay
			{
				[Token(Token = "0x60107F1")]
				[Address(RVA = "0x857650", Offset = "0x856250", VA = "0x180857650", Slot = "5")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002408 RID: 9224
			// (get) Token: 0x060107F2 RID: 67570 RVA: 0x00064938 File Offset: 0x00062B38
			[Token(Token = "0x17002408")]
			public int lostHpDisplay
			{
				[Token(Token = "0x60107F2")]
				[Address(RVA = "0x8576B0", Offset = "0x8562B0", VA = "0x1808576B0", Slot = "7")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060107F3 RID: 67571 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60107F3")]
			[Address(RVA = "0x8572B0", Offset = "0x855EB0", VA = "0x1808572B0", Slot = "8")]
			public void Reset()
			{
			}

			// Token: 0x060107F4 RID: 67572 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60107F4")]
			[Address(RVA = "0x8573F0", Offset = "0x855FF0", VA = "0x1808573F0")]
			public SelfBattleRoundStatus()
			{
			}

			// Token: 0x040127D6 RID: 75734
			[Token(Token = "0x40127D6")]
			[FieldOffset(Offset = "0x18")]
			public List<int> enemyEscapedInstIds;

			// Token: 0x040127D7 RID: 75735
			[Token(Token = "0x40127D7")]
			[FieldOffset(Offset = "0x20")]
			public List<int> enemyEscapedTokenInstIds;

			// Token: 0x040127D8 RID: 75736
			[Token(Token = "0x40127D8")]
			[FieldOffset(Offset = "0x28")]
			public List<BattleEnemyKilledInfo> enemyKilledInfos;

			// Token: 0x040127D9 RID: 75737
			[Token(Token = "0x40127D9")]
			[FieldOffset(Offset = "0x30")]
			public int enemyKilledCnt;

			// Token: 0x040127DA RID: 75738
			[Token(Token = "0x40127DA")]
			[FieldOffset(Offset = "0x34")]
			public int enemyEscapedCnt;

			// Token: 0x040127DB RID: 75739
			[Token(Token = "0x40127DB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_enemyCntInTotal;

			// Token: 0x040127DC RID: 75740
			[Token(Token = "0x40127DC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_enemyCntInTotal;

			// Token: 0x040127DD RID: 75741
			[Token(Token = "0x40127DD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_curEnemyCnt;

			// Token: 0x040127DE RID: 75742
			[Token(Token = "0x40127DE")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_enemyEscapedDisplay;

			// Token: 0x040127DF RID: 75743
			[Token(Token = "0x40127DF")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_lostHpDisplay;

			// Token: 0x040127E0 RID: 75744
			[Token(Token = "0x40127E0")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x040127E1 RID: 75745
			[Token(Token = "0x40127E1")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200277B RID: 10107
		[Token(Token = "0x200277B")]
		public class HelpBattleRoundStatus : IHotfixable, AutoChessBattleStatusDataModel.IRoundStatus
		{
			// Token: 0x17002409 RID: 9225
			// (get) Token: 0x060107F5 RID: 67573 RVA: 0x00064950 File Offset: 0x00062B50
			// (set) Token: 0x060107F6 RID: 67574 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002409")]
			public int enemyCntInTotal
			{
				[Token(Token = "0x60107F5")]
				[Address(RVA = "0x8567A0", Offset = "0x8553A0", VA = "0x1808567A0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60107F6")]
				[Address(RVA = "0x8568C0", Offset = "0x8554C0", VA = "0x1808568C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700240A RID: 9226
			// (get) Token: 0x060107F7 RID: 67575 RVA: 0x00064968 File Offset: 0x00062B68
			[Token(Token = "0x1700240A")]
			public int curEnemyCnt
			{
				[Token(Token = "0x60107F7")]
				[Address(RVA = "0x8566E0", Offset = "0x8552E0", VA = "0x1808566E0", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700240B RID: 9227
			// (get) Token: 0x060107F8 RID: 67576 RVA: 0x00064980 File Offset: 0x00062B80
			[Token(Token = "0x1700240B")]
			public int enemyEscapedDisplay
			{
				[Token(Token = "0x60107F8")]
				[Address(RVA = "0x856800", Offset = "0x855400", VA = "0x180856800", Slot = "5")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700240C RID: 9228
			// (get) Token: 0x060107F9 RID: 67577 RVA: 0x00064998 File Offset: 0x00062B98
			[Token(Token = "0x1700240C")]
			public int lostHpDisplay
			{
				[Token(Token = "0x60107F9")]
				[Address(RVA = "0x856860", Offset = "0x855460", VA = "0x180856860", Slot = "7")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060107FA RID: 67578 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60107FA")]
			[Address(RVA = "0x856420", Offset = "0x855020", VA = "0x180856420", Slot = "8")]
			public void Reset()
			{
			}

			// Token: 0x060107FB RID: 67579 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60107FB")]
			[Address(RVA = "0x856630", Offset = "0x855230", VA = "0x180856630")]
			public HelpBattleRoundStatus()
			{
			}

			// Token: 0x040127E3 RID: 75747
			[Token(Token = "0x40127E3")]
			[FieldOffset(Offset = "0x14")]
			public int selfEnemyEscapedRemaining;

			// Token: 0x040127E4 RID: 75748
			[Token(Token = "0x40127E4")]
			[FieldOffset(Offset = "0x18")]
			public int selfEnemyEscapedCntInHelpBattleState;

			// Token: 0x040127E5 RID: 75749
			[Token(Token = "0x40127E5")]
			[FieldOffset(Offset = "0x20")]
			public List<HelpBattleEnemyKilledInfo> killInfos;

			// Token: 0x040127E6 RID: 75750
			[Token(Token = "0x40127E6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_enemyCntInTotal;

			// Token: 0x040127E7 RID: 75751
			[Token(Token = "0x40127E7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_enemyCntInTotal;

			// Token: 0x040127E8 RID: 75752
			[Token(Token = "0x40127E8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_curEnemyCnt;

			// Token: 0x040127E9 RID: 75753
			[Token(Token = "0x40127E9")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_enemyEscapedDisplay;

			// Token: 0x040127EA RID: 75754
			[Token(Token = "0x40127EA")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_lostHpDisplay;

			// Token: 0x040127EB RID: 75755
			[Token(Token = "0x40127EB")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x040127EC RID: 75756
			[Token(Token = "0x40127EC")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200277C RID: 10108
		[Token(Token = "0x200277C")]
		public class BossBattleRoundStatus : IHotfixable, AutoChessBattleStatusDataModel.IRoundStatus
		{
			// Token: 0x1700240D RID: 9229
			// (get) Token: 0x060107FC RID: 67580 RVA: 0x000649B0 File Offset: 0x00062BB0
			// (set) Token: 0x060107FD RID: 67581 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700240D")]
			public int enemyCntInTotal
			{
				[Token(Token = "0x60107FC")]
				[Address(RVA = "0x8504D0", Offset = "0x84F0D0", VA = "0x1808504D0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60107FD")]
				[Address(RVA = "0x8505F0", Offset = "0x84F1F0", VA = "0x1808505F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700240E RID: 9230
			// (get) Token: 0x060107FE RID: 67582 RVA: 0x000649C8 File Offset: 0x00062BC8
			[Token(Token = "0x1700240E")]
			public int curEnemyCnt
			{
				[Token(Token = "0x60107FE")]
				[Address(RVA = "0x850470", Offset = "0x84F070", VA = "0x180850470", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700240F RID: 9231
			// (get) Token: 0x060107FF RID: 67583 RVA: 0x000649E0 File Offset: 0x00062BE0
			[Token(Token = "0x1700240F")]
			public int enemyEscapedDisplay
			{
				[Token(Token = "0x60107FF")]
				[Address(RVA = "0x850530", Offset = "0x84F130", VA = "0x180850530", Slot = "5")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002410 RID: 9232
			// (get) Token: 0x06010800 RID: 67584 RVA: 0x000649F8 File Offset: 0x00062BF8
			[Token(Token = "0x17002410")]
			public int lostHpDisplay
			{
				[Token(Token = "0x6010800")]
				[Address(RVA = "0x850590", Offset = "0x84F190", VA = "0x180850590", Slot = "7")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06010801 RID: 67585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010801")]
			[Address(RVA = "0x850270", Offset = "0x84EE70", VA = "0x180850270", Slot = "8")]
			public void Reset()
			{
			}

			// Token: 0x06010802 RID: 67586 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010802")]
			[Address(RVA = "0x850410", Offset = "0x84F010", VA = "0x180850410")]
			public BossBattleRoundStatus()
			{
			}

			// Token: 0x040127EE RID: 75758
			[Token(Token = "0x40127EE")]
			[FieldOffset(Offset = "0x14")]
			public int battleProcess;

			// Token: 0x040127EF RID: 75759
			[Token(Token = "0x40127EF")]
			[FieldOffset(Offset = "0x18")]
			public int battleTeamHp;

			// Token: 0x040127F0 RID: 75760
			[Token(Token = "0x40127F0")]
			[FieldOffset(Offset = "0x1C")]
			public float bossHpRatio;

			// Token: 0x040127F1 RID: 75761
			[Token(Token = "0x40127F1")]
			[FieldOffset(Offset = "0x20")]
			public int playerTotalHp;

			// Token: 0x040127F2 RID: 75762
			[Token(Token = "0x40127F2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_enemyCntInTotal;

			// Token: 0x040127F3 RID: 75763
			[Token(Token = "0x40127F3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_enemyCntInTotal;

			// Token: 0x040127F4 RID: 75764
			[Token(Token = "0x40127F4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_curEnemyCnt;

			// Token: 0x040127F5 RID: 75765
			[Token(Token = "0x40127F5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_enemyEscapedDisplay;

			// Token: 0x040127F6 RID: 75766
			[Token(Token = "0x40127F6")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_lostHpDisplay;

			// Token: 0x040127F7 RID: 75767
			[Token(Token = "0x40127F7")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x040127F8 RID: 75768
			[Token(Token = "0x40127F8")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
