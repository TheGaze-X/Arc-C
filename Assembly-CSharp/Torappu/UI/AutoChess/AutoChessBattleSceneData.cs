using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using Torappu.UI.AutoChess.Server;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062AB RID: 25259
	[Token(Token = "0x20062AB")]
	public class AutoChessBattleSceneData : IHotfixable
	{
		// Token: 0x06024685 RID: 149125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024685")]
		[Address(RVA = "0x1F38270", Offset = "0x1F36E70", VA = "0x181F38270")]
		public void FillAllStateSync(AutoChessBattleAllStateSyncData allStateSyncData)
		{
		}

		// Token: 0x06024686 RID: 149126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024686")]
		[Address(RVA = "0x1F38A20", Offset = "0x1F37620", VA = "0x181F38A20")]
		public void FillWithSceneStatus(AutoChessBattleSceneStatus sceneDetail)
		{
		}

		// Token: 0x06024687 RID: 149127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024687")]
		[Address(RVA = "0x1F38770", Offset = "0x1F37370", VA = "0x181F38770")]
		public void FillWithPreparationStatus(AutoChessBattlePreparationStatus preparationStatus)
		{
		}

		// Token: 0x06024688 RID: 149128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024688")]
		[Address(RVA = "0x1F386F0", Offset = "0x1F372F0", VA = "0x181F386F0")]
		public void FillWithPlayerStatus(List<AutoChessBattlePlayerRuntimeInfo> playerStatus)
		{
		}

		// Token: 0x06024689 RID: 149129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024689")]
		[Address(RVA = "0x1F385E0", Offset = "0x1F371E0", VA = "0x181F385E0")]
		public void FillWithBoardStatus(AutoChessBattleBoardStatus boardStatus)
		{
		}

		// Token: 0x0602468A RID: 149130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602468A")]
		[Address(RVA = "0x1F384C0", Offset = "0x1F370C0", VA = "0x181F384C0")]
		public void FillSpPreparationUpdateInfo(AutoAutoChessBattleSpPreparationUpdateInfo spPrepUpdateInfo)
		{
		}

		// Token: 0x0602468B RID: 149131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602468B")]
		[Address(RVA = "0x1F39230", Offset = "0x1F37E30", VA = "0x181F39230")]
		public AutoChessBattleSceneData()
		{
		}

		// Token: 0x04032AA3 RID: 207523
		[Token(Token = "0x4032AA3")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessBattleSceneData.AutoChessSceneGameData sceneGameData;

		// Token: 0x04032AA4 RID: 207524
		[Token(Token = "0x4032AA4")]
		[FieldOffset(Offset = "0x18")]
		public AutoChessBattleSceneData.AutoChessScenePlayerStaticData playerStaticData;

		// Token: 0x04032AA5 RID: 207525
		[Token(Token = "0x4032AA5")]
		[FieldOffset(Offset = "0x20")]
		public AutoChessBattleSceneData.AutoChessBattleSceneRoundEnemyData roundEnemyData;

		// Token: 0x04032AA6 RID: 207526
		[Token(Token = "0x4032AA6")]
		[FieldOffset(Offset = "0x28")]
		public AutoChessBattleSceneData.AutoChessBattleSceneStateData sceneStateData;

		// Token: 0x04032AA7 RID: 207527
		[Token(Token = "0x4032AA7")]
		[FieldOffset(Offset = "0x30")]
		public AutoChessBattleSceneData.AutoChessBattleScenePlayerRunTimeData playerRunTimeData;

		// Token: 0x04032AA8 RID: 207528
		[Token(Token = "0x4032AA8")]
		[FieldOffset(Offset = "0x38")]
		public AutoChessBattleSceneData.AutoChessBattleScenePrepareStateData prepareStateData;

		// Token: 0x04032AA9 RID: 207529
		[Token(Token = "0x4032AA9")]
		[FieldOffset(Offset = "0x40")]
		public AutoChessBattleSceneData.AutoChessBattleSceneSpPrepareStateData spPrepareStateData;

		// Token: 0x04032AAA RID: 207530
		[Token(Token = "0x4032AAA")]
		[FieldOffset(Offset = "0x48")]
		public AutoChessBattleSceneData.AutoChessBattleSceneSelfBattleData selfBattleData;

		// Token: 0x04032AAB RID: 207531
		[Token(Token = "0x4032AAB")]
		[FieldOffset(Offset = "0x50")]
		public AutoChessBattleSceneData.AutoChessBattleSceneHelpBattleData helpBattleData;

		// Token: 0x04032AAC RID: 207532
		[Token(Token = "0x4032AAC")]
		[FieldOffset(Offset = "0x58")]
		public AutoChessBattleSceneData.AutoChessBattleSceneBossBattleData bossBattleData;

		// Token: 0x04032AAD RID: 207533
		[Token(Token = "0x4032AAD")]
		[FieldOffset(Offset = "0x60")]
		public AutoChessBattleSceneData.AutoChessBattleSceneSettleData settleData;

		// Token: 0x04032AAE RID: 207534
		[Token(Token = "0x4032AAE")]
		[FieldOffset(Offset = "0x68")]
		public AutoChessBattleSceneData.AutoChessBattleBossRoundInfoData bossRoundInfo;

		// Token: 0x04032AAF RID: 207535
		[Token(Token = "0x4032AAF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FillAllStateSync;

		// Token: 0x04032AB0 RID: 207536
		[Token(Token = "0x4032AB0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FillWithSceneStatus;

		// Token: 0x04032AB1 RID: 207537
		[Token(Token = "0x4032AB1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_FillWithPreparationStatus;

		// Token: 0x04032AB2 RID: 207538
		[Token(Token = "0x4032AB2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_FillWithPlayerStatus;

		// Token: 0x04032AB3 RID: 207539
		[Token(Token = "0x4032AB3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_FillWithBoardStatus;

		// Token: 0x04032AB4 RID: 207540
		[Token(Token = "0x4032AB4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_FillSpPreparationUpdateInfo;

		// Token: 0x04032AB5 RID: 207541
		[Token(Token = "0x4032AB5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020062AC RID: 25260
		[Token(Token = "0x20062AC")]
		public class AutoChessSceneGameData : AutoChessBattleSceneModuleDataBase
		{
			// Token: 0x0602468C RID: 149132 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602468C")]
			[Address(RVA = "0x1F4EA20", Offset = "0x1F4D620", VA = "0x181F4EA20")]
			public void Fill(AutoChessBattleAllStateSyncData from)
			{
			}

			// Token: 0x0602468D RID: 149133 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602468D")]
			[Address(RVA = "0x1F4EB10", Offset = "0x1F4D710", VA = "0x181F4EB10")]
			public AutoChessSceneGameData()
			{
			}

			// Token: 0x04032AB6 RID: 207542
			[Token(Token = "0x4032AB6")]
			[FieldOffset(Offset = "0x18")]
			public SceneGameData data;

			// Token: 0x04032AB7 RID: 207543
			[Token(Token = "0x4032AB7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Fill;

			// Token: 0x04032AB8 RID: 207544
			[Token(Token = "0x4032AB8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020062AD RID: 25261
		[Token(Token = "0x20062AD")]
		public class AutoChessScenePlayerStaticData : AutoChessBattleSceneModuleDataBase
		{
			// Token: 0x0602468E RID: 149134 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602468E")]
			[Address(RVA = "0x1F4EC00", Offset = "0x1F4D800", VA = "0x181F4EC00")]
			public void Fill(AutoChessBattleAllStateSyncData from)
			{
			}

			// Token: 0x0602468F RID: 149135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602468F")]
			[Address(RVA = "0x1F4ECF0", Offset = "0x1F4D8F0", VA = "0x181F4ECF0")]
			public AutoChessScenePlayerStaticData()
			{
			}

			// Token: 0x04032AB9 RID: 207545
			[Token(Token = "0x4032AB9")]
			[FieldOffset(Offset = "0x18")]
			public ScenePlayerStaticData data;

			// Token: 0x04032ABA RID: 207546
			[Token(Token = "0x4032ABA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Fill;

			// Token: 0x04032ABB RID: 207547
			[Token(Token = "0x4032ABB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020062AE RID: 25262
		[Token(Token = "0x20062AE")]
		public class AutoChessBattleSceneRoundEnemyData : AutoChessBattleSceneModuleDataBase
		{
			// Token: 0x06024690 RID: 149136 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024690")]
			[Address(RVA = "0x1F3A7F0", Offset = "0x1F393F0", VA = "0x181F3A7F0")]
			public void Fill(List<AutoChessBattleRoundEnemyInfo> roundEnemyInfos)
			{
			}

			// Token: 0x06024691 RID: 149137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024691")]
			[Address(RVA = "0x1F3A8B0", Offset = "0x1F394B0", VA = "0x181F3A8B0")]
			public AutoChessBattleSceneRoundEnemyData()
			{
			}

			// Token: 0x04032ABC RID: 207548
			[Token(Token = "0x4032ABC")]
			[FieldOffset(Offset = "0x18")]
			public SceneRoundEnemyData data;

			// Token: 0x04032ABD RID: 207549
			[Token(Token = "0x4032ABD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Fill;

			// Token: 0x04032ABE RID: 207550
			[Token(Token = "0x4032ABE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020062AF RID: 25263
		[Token(Token = "0x20062AF")]
		public class AutoChessBattleSceneStateData : AutoChessBattleSceneModuleDataBase
		{
			// Token: 0x06024692 RID: 149138 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024692")]
			[Address(RVA = "0x1F3B150", Offset = "0x1F39D50", VA = "0x181F3B150")]
			public void Fill(AutoChessBattleSceneStatus from)
			{
			}

			// Token: 0x06024693 RID: 149139 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024693")]
			[Address(RVA = "0x1F3AF90", Offset = "0x1F39B90", VA = "0x181F3AF90")]
			public void Fill(AutoChessBattlePreparationStatus from)
			{
			}

			// Token: 0x06024694 RID: 149140 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024694")]
			[Address(RVA = "0x1F3B050", Offset = "0x1F39C50", VA = "0x181F3B050")]
			public void Fill(AutoChessGameStateType state, int deadObIndex)
			{
			}

			// Token: 0x06024695 RID: 149141 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024695")]
			[Address(RVA = "0x1F3B210", Offset = "0x1F39E10", VA = "0x181F3B210")]
			public AutoChessBattleSceneStateData()
			{
			}

			// Token: 0x04032ABF RID: 207551
			[Token(Token = "0x4032ABF")]
			[FieldOffset(Offset = "0x18")]
			public SceneStateData data;

			// Token: 0x04032AC0 RID: 207552
			[Token(Token = "0x4032AC0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Fill;

			// Token: 0x04032AC1 RID: 207553
			[Token(Token = "0x4032AC1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix1_Fill;

			// Token: 0x04032AC2 RID: 207554
			[Token(Token = "0x4032AC2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix2_Fill;

			// Token: 0x04032AC3 RID: 207555
			[Token(Token = "0x4032AC3")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020062B0 RID: 25264
		[Token(Token = "0x20062B0")]
		public class AutoChessBattleScenePlayerRunTimeData : AutoChessBattleSceneModuleDataBase
		{
			// Token: 0x06024696 RID: 149142 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024696")]
			[Address(RVA = "0x1F3A280", Offset = "0x1F38E80", VA = "0x181F3A280")]
			public void Fill(List<AutoChessBattlePlayerRuntimeInfo> playerRuntimeInfos)
			{
			}

			// Token: 0x06024697 RID: 149143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024697")]
			[Address(RVA = "0x1F3A1C0", Offset = "0x1F38DC0", VA = "0x181F3A1C0")]
			public void Fill(AutoChessBattlePreparationStatus preparationStatus)
			{
			}

			// Token: 0x06024698 RID: 149144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024698")]
			[Address(RVA = "0x1F3A340", Offset = "0x1F38F40", VA = "0x181F3A340")]
			public void Fill(AutoChessBattleBoardStatus boardStatus)
			{
			}

			// Token: 0x06024699 RID: 149145 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024699")]
			[Address(RVA = "0x1F3A100", Offset = "0x1F38D00", VA = "0x181F3A100")]
			public void Fill(AutoChessBattlePlayerDeploymentInfo deploymentInfo)
			{
			}

			// Token: 0x0602469A RID: 149146 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602469A")]
			[Address(RVA = "0x1F3A400", Offset = "0x1F39000", VA = "0x181F3A400")]
			public AutoChessBattleScenePlayerRunTimeData()
			{
			}

			// Token: 0x04032AC4 RID: 207556
			[Token(Token = "0x4032AC4")]
			[FieldOffset(Offset = "0x18")]
			public ScenePlayerRunTimeData data;

			// Token: 0x04032AC5 RID: 207557
			[Token(Token = "0x4032AC5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Fill;

			// Token: 0x04032AC6 RID: 207558
			[Token(Token = "0x4032AC6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix1_Fill;

			// Token: 0x04032AC7 RID: 207559
			[Token(Token = "0x4032AC7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix2_Fill;

			// Token: 0x04032AC8 RID: 207560
			[Token(Token = "0x4032AC8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix3_Fill;

			// Token: 0x04032AC9 RID: 207561
			[Token(Token = "0x4032AC9")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020062B1 RID: 25265
		[Token(Token = "0x20062B1")]
		public class AutoChessBattleScenePrepareStateData : AutoChessBattleSceneModuleDataBase
		{
			// Token: 0x0602469B RID: 149147 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602469B")]
			[Address(RVA = "0x1F3A4F0", Offset = "0x1F390F0", VA = "0x181F3A4F0")]
			public void Fill(AutoChessBattlePreparationStatus preparationStatus)
			{
			}

			// Token: 0x0602469C RID: 149148 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602469C")]
			[Address(RVA = "0x1F3A5B0", Offset = "0x1F391B0", VA = "0x181F3A5B0")]
			public void UpdateFrozen(bool frozen)
			{
			}

			// Token: 0x0602469D RID: 149149 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602469D")]
			[Address(RVA = "0x1F3A700", Offset = "0x1F39300", VA = "0x181F3A700")]
			public AutoChessBattleScenePrepareStateData()
			{
			}

			// Token: 0x04032ACA RID: 207562
			[Token(Token = "0x4032ACA")]
			[FieldOffset(Offset = "0x18")]
			public PrepareStateData data;

			// Token: 0x04032ACB RID: 207563
			[Token(Token = "0x4032ACB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Fill;

			// Token: 0x04032ACC RID: 207564
			[Token(Token = "0x4032ACC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateFrozen;

			// Token: 0x04032ACD RID: 207565
			[Token(Token = "0x4032ACD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020062B2 RID: 25266
		[Token(Token = "0x20062B2")]
		public class AutoChessBattleSceneSpPrepareStateData : AutoChessBattleSceneModuleDataBase
		{
			// Token: 0x0602469E RID: 149150 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602469E")]
			[Address(RVA = "0x1F3AD00", Offset = "0x1F39900", VA = "0x181F3AD00")]
			public void Fill(AutoChessBattleSpPreparationInfo spPreparationInfo)
			{
			}

			// Token: 0x0602469F RID: 149151 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602469F")]
			[Address(RVA = "0x1F3ADD0", Offset = "0x1F399D0", VA = "0x181F3ADD0")]
			public void Fill(AutoAutoChessBattleSpPreparationUpdateInfo updateInfo)
			{
			}

			// Token: 0x060246A0 RID: 149152 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60246A0")]
			[Address(RVA = "0x1F3AEA0", Offset = "0x1F39AA0", VA = "0x181F3AEA0")]
			public AutoChessBattleSceneSpPrepareStateData()
			{
			}

			// Token: 0x04032ACE RID: 207566
			[Token(Token = "0x4032ACE")]
			[FieldOffset(Offset = "0x18")]
			public SpPrepareStateData data;

			// Token: 0x04032ACF RID: 207567
			[Token(Token = "0x4032ACF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Fill;

			// Token: 0x04032AD0 RID: 207568
			[Token(Token = "0x4032AD0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix1_Fill;

			// Token: 0x04032AD1 RID: 207569
			[Token(Token = "0x4032AD1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020062B3 RID: 25267
		[Token(Token = "0x20062B3")]
		public class AutoChessBattleSceneSelfBattleData : AutoChessBattleSceneModuleDataBase
		{
			// Token: 0x060246A1 RID: 149153 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60246A1")]
			[Address(RVA = "0x1F3A9A0", Offset = "0x1F395A0", VA = "0x181F3A9A0")]
			public void Fill(AutoChessBattleSelfBattleInfo selfBattleInfo)
			{
			}

			// Token: 0x060246A2 RID: 149154 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60246A2")]
			[Address(RVA = "0x1F3AA60", Offset = "0x1F39660", VA = "0x181F3AA60")]
			public AutoChessBattleSceneSelfBattleData()
			{
			}

			// Token: 0x04032AD2 RID: 207570
			[Token(Token = "0x4032AD2")]
			[FieldOffset(Offset = "0x18")]
			public SelfBattleData data;

			// Token: 0x04032AD3 RID: 207571
			[Token(Token = "0x4032AD3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Fill;

			// Token: 0x04032AD4 RID: 207572
			[Token(Token = "0x4032AD4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020062B4 RID: 25268
		[Token(Token = "0x20062B4")]
		public class AutoChessBattleSceneHelpBattleData : AutoChessBattleSceneModuleDataBase
		{
			// Token: 0x060246A3 RID: 149155 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60246A3")]
			[Address(RVA = "0x1F39E30", Offset = "0x1F38A30", VA = "0x181F39E30")]
			public void Fill(AutoChessBattleHelpBattleInfo helpBattleInfo)
			{
			}

			// Token: 0x060246A4 RID: 149156 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60246A4")]
			[Address(RVA = "0x1F39EF0", Offset = "0x1F38AF0", VA = "0x181F39EF0")]
			public AutoChessBattleSceneHelpBattleData()
			{
			}

			// Token: 0x04032AD5 RID: 207573
			[Token(Token = "0x4032AD5")]
			[FieldOffset(Offset = "0x18")]
			public HelpBattleData data;

			// Token: 0x04032AD6 RID: 207574
			[Token(Token = "0x4032AD6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Fill;

			// Token: 0x04032AD7 RID: 207575
			[Token(Token = "0x4032AD7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020062B5 RID: 25269
		[Token(Token = "0x20062B5")]
		public class AutoChessBattleSceneSettleData : AutoChessBattleSceneModuleDataBase
		{
			// Token: 0x060246A5 RID: 149157 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60246A5")]
			[Address(RVA = "0x1F3AB50", Offset = "0x1F39750", VA = "0x181F3AB50")]
			public void Fill(AutoChessBattleSettleInfo settleInfo)
			{
			}

			// Token: 0x060246A6 RID: 149158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60246A6")]
			[Address(RVA = "0x1F3AC10", Offset = "0x1F39810", VA = "0x181F3AC10")]
			public AutoChessBattleSceneSettleData()
			{
			}

			// Token: 0x04032AD8 RID: 207576
			[Token(Token = "0x4032AD8")]
			[FieldOffset(Offset = "0x18")]
			public SettleData data;

			// Token: 0x04032AD9 RID: 207577
			[Token(Token = "0x4032AD9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Fill;

			// Token: 0x04032ADA RID: 207578
			[Token(Token = "0x4032ADA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020062B6 RID: 25270
		[Token(Token = "0x20062B6")]
		public class AutoChessBattleSceneBossBattleData : AutoChessBattleSceneModuleDataBase
		{
			// Token: 0x060246A7 RID: 149159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60246A7")]
			[Address(RVA = "0x1F380C0", Offset = "0x1F36CC0", VA = "0x181F380C0")]
			public void Fill(AutoChessBattleBossBattleInfo bossBattleInfo)
			{
			}

			// Token: 0x060246A8 RID: 149160 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60246A8")]
			[Address(RVA = "0x1F38180", Offset = "0x1F36D80", VA = "0x181F38180")]
			public AutoChessBattleSceneBossBattleData()
			{
			}

			// Token: 0x04032ADB RID: 207579
			[Token(Token = "0x4032ADB")]
			[FieldOffset(Offset = "0x18")]
			public BossBattleData data;

			// Token: 0x04032ADC RID: 207580
			[Token(Token = "0x4032ADC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Fill;

			// Token: 0x04032ADD RID: 207581
			[Token(Token = "0x4032ADD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020062B7 RID: 25271
		[Token(Token = "0x20062B7")]
		public class AutoChessBattleBossRoundInfoData : AutoChessBattleSceneModuleDataBase
		{
			// Token: 0x060246A9 RID: 149161 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60246A9")]
			[Address(RVA = "0x1F37B10", Offset = "0x1F36710", VA = "0x181F37B10")]
			public void Fill(AutoChessBattleBossRoundInfo bossRoundInfo)
			{
			}

			// Token: 0x060246AA RID: 149162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60246AA")]
			[Address(RVA = "0x1F37BD0", Offset = "0x1F367D0", VA = "0x181F37BD0")]
			public AutoChessBattleBossRoundInfoData()
			{
			}

			// Token: 0x04032ADE RID: 207582
			[Token(Token = "0x4032ADE")]
			[FieldOffset(Offset = "0x18")]
			public BossRoundInfo data;

			// Token: 0x04032ADF RID: 207583
			[Token(Token = "0x4032ADF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Fill;

			// Token: 0x04032AE0 RID: 207584
			[Token(Token = "0x4032AE0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
