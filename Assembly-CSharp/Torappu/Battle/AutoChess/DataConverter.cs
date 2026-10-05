using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.AutoChess.Server;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002741 RID: 10049
	[Token(Token = "0x2002741")]
	public class DataConverter : IHotfixable
	{
		// Token: 0x0601053D RID: 66877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601053D")]
		protected static void ResizeUseNew<T>(List<T> list, int size) where T : new()
		{
		}

		// Token: 0x0601053E RID: 66878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601053E")]
		protected static void CopyListData<T1, T2>(List<T1> from, List<T2> to, Action<T1, T2> copy) where T1 : new() where T2 : new()
		{
		}

		// Token: 0x0601053F RID: 66879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601053F")]
		[Address(RVA = "0x806C80", Offset = "0x805880", VA = "0x180806C80")]
		public static void Refresh(AutoChessBattleSceneStatus from, SceneStateData to)
		{
		}

		// Token: 0x06010540 RID: 66880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010540")]
		[Address(RVA = "0x804630", Offset = "0x803230", VA = "0x180804630")]
		public static void Refresh(AutoChessBattleSpecialEffect from, BattleSpecialEffect to)
		{
		}

		// Token: 0x06010541 RID: 66881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010541")]
		[Address(RVA = "0x804AF0", Offset = "0x8036F0", VA = "0x180804AF0")]
		public static void Refresh(AutoChessBattlePreparationStatus from, SceneStateData to)
		{
		}

		// Token: 0x06010542 RID: 66882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010542")]
		[Address(RVA = "0x804C80", Offset = "0x803880", VA = "0x180804C80")]
		public static void Refresh(AutoChessBattleAllStateSyncData from, SceneGameData to)
		{
		}

		// Token: 0x06010543 RID: 66883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010543")]
		[Address(RVA = "0x807820", Offset = "0x806420", VA = "0x180807820")]
		public static void Refresh(AutoChessBattleAllStateSyncData from, ScenePlayerStaticData to)
		{
		}

		// Token: 0x06010544 RID: 66884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010544")]
		[Address(RVA = "0x804F20", Offset = "0x803B20", VA = "0x180804F20")]
		private static void Refresh(AutoChessBattlePlayerStaticInfo from, StaticScenePlayerData to)
		{
		}

		// Token: 0x06010545 RID: 66885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010545")]
		[Address(RVA = "0x806030", Offset = "0x804C30", VA = "0x180806030")]
		public static void Refresh(AutoChessBattleSquadSlot from, SquadSlot to)
		{
		}

		// Token: 0x06010546 RID: 66886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010546")]
		[Address(RVA = "0x806AE0", Offset = "0x8056E0", VA = "0x180806AE0")]
		public static void Refresh(AutoChessBattlePlayerCardInfo from, PlayerCard to)
		{
		}

		// Token: 0x06010547 RID: 66887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010547")]
		[Address(RVA = "0x807590", Offset = "0x806190", VA = "0x180807590")]
		public static void Refresh(List<AutoChessBattlePlayerRuntimeInfo> from, ScenePlayerRunTimeData to)
		{
		}

		// Token: 0x06010548 RID: 66888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010548")]
		[Address(RVA = "0x804930", Offset = "0x803530", VA = "0x180804930")]
		public static void Refresh(AutoChessBattlePlayerRuntimeInfo from, RunTimeScenePlayerData to)
		{
		}

		// Token: 0x06010549 RID: 66889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010549")]
		[Address(RVA = "0x804E30", Offset = "0x803A30", VA = "0x180804E30")]
		public static void Refresh(List<AutoChessBattleRoundEnemyInfo> from, SceneRoundEnemyData to)
		{
		}

		// Token: 0x0601054A RID: 66890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601054A")]
		[Address(RVA = "0x804890", Offset = "0x803490", VA = "0x180804890")]
		private static void Refresh(AutoChessBattleRoundEnemyInfo from, SceneRoundEnemyData.RoundEnemy to)
		{
		}

		// Token: 0x0601054B RID: 66891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601054B")]
		[Address(RVA = "0x806BF0", Offset = "0x8057F0", VA = "0x180806BF0")]
		public static void Refresh(AutoChessBattleChessPosUnitInfo from, ChessPositionInfo to)
		{
		}

		// Token: 0x0601054C RID: 66892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601054C")]
		[Address(RVA = "0x804D90", Offset = "0x803990", VA = "0x180804D90")]
		public static void Refresh(AutoChessBattleChessBondInfo from, GarrisonBond to)
		{
		}

		// Token: 0x0601054D RID: 66893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601054D")]
		[Address(RVA = "0x805360", Offset = "0x803F60", VA = "0x180805360")]
		public static void Refresh(AutoChessBattlePreparationStatus from, ScenePlayerRunTimeData to)
		{
		}

		// Token: 0x0601054E RID: 66894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601054E")]
		[Address(RVA = "0x8045A0", Offset = "0x8031A0", VA = "0x1808045A0")]
		public static void Refresh(AutoChessBattleEffectEnemyInfo from, BattleEffectEnemyInfo to)
		{
		}

		// Token: 0x0601054F RID: 66895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601054F")]
		[Address(RVA = "0x805150", Offset = "0x803D50", VA = "0x180805150")]
		public static void Refresh(AutoChessBattlePreparationRoundAnalytics from, PreparationRoundAnalytics to)
		{
		}

		// Token: 0x06010550 RID: 66896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010550")]
		[Address(RVA = "0x806140", Offset = "0x804D40", VA = "0x180806140")]
		public static void Refresh(AutoChessBattlePlayerDeploymentInfo from, ScenePlayerRunTimeData to)
		{
		}

		// Token: 0x06010551 RID: 66897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010551")]
		[Address(RVA = "0x8057F0", Offset = "0x8043F0", VA = "0x1808057F0")]
		public static void Refresh(AutoChessBattleBoardStatus from, ScenePlayerRunTimeData to)
		{
		}

		// Token: 0x06010552 RID: 66898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010552")]
		[Address(RVA = "0x804790", Offset = "0x803390", VA = "0x180804790")]
		public static void Refresh(AutoChessBattleCharChess from, CharChess to)
		{
		}

		// Token: 0x06010553 RID: 66899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010553")]
		[Address(RVA = "0x8074F0", Offset = "0x8060F0", VA = "0x1808074F0")]
		public static void Refresh(AutoChessBattleEquipOrTrapChess from, EquipChess to)
		{
		}

		// Token: 0x06010554 RID: 66900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010554")]
		[Address(RVA = "0x8042E0", Offset = "0x802EE0", VA = "0x1808042E0")]
		public static void Refresh(AutoChessBattlePreparationStatus from, PrepareStateData to)
		{
		}

		// Token: 0x06010555 RID: 66901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010555")]
		[Address(RVA = "0x8068E0", Offset = "0x8054E0", VA = "0x1808068E0")]
		public static void Refresh(AutoChessBattleBossRoundInfo from, PrepareStateData to)
		{
		}

		// Token: 0x06010556 RID: 66902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010556")]
		[Address(RVA = "0x807AB0", Offset = "0x8066B0", VA = "0x180807AB0")]
		public static void Refresh(AutoChessBattleStoreInfo from, ShopData to)
		{
		}

		// Token: 0x06010557 RID: 66903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010557")]
		[Address(RVA = "0x8049D0", Offset = "0x8035D0", VA = "0x1808049D0")]
		public static void Refresh(AutoChessBattleStoreGoodInfo from, ChessGoods to)
		{
		}

		// Token: 0x06010558 RID: 66904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010558")]
		[Address(RVA = "0x8067E0", Offset = "0x8053E0", VA = "0x1808067E0")]
		public static void Refresh(AutoChessBattleSelfChoiceInfo from, SelfChooseStateData to)
		{
		}

		// Token: 0x06010559 RID: 66905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010559")]
		[Address(RVA = "0x804700", Offset = "0x803300", VA = "0x180804700")]
		public static void Refresh(AutoChessBattleSpPrepareSlot from, ChooseStateSlot to)
		{
		}

		// Token: 0x0601055A RID: 66906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601055A")]
		[Address(RVA = "0x806940", Offset = "0x805540", VA = "0x180806940")]
		public static void Refresh(AutoChessBattleSpPreparationInfo from, NChooseOneStateData to)
		{
		}

		// Token: 0x0601055B RID: 66907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601055B")]
		[Address(RVA = "0x807310", Offset = "0x805F10", VA = "0x180807310")]
		public static void Refresh(AutoAutoChessBattleSpPreparationUpdateInfo from, NChooseOneStateData to)
		{
		}

		// Token: 0x0601055C RID: 66908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601055C")]
		[Address(RVA = "0x804A70", Offset = "0x803670", VA = "0x180804A70")]
		public static void Refresh(AutoChessBattleSpPreparePlayer from, NChooseOneStateData.PlayerChoice to)
		{
		}

		// Token: 0x0601055D RID: 66909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601055D")]
		[Address(RVA = "0x806530", Offset = "0x805130", VA = "0x180806530")]
		public static void Refresh(AutoChessBattleSelfBattleInfo from, SelfBattleData to)
		{
		}

		// Token: 0x0601055E RID: 66910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601055E")]
		[Address(RVA = "0x806EF0", Offset = "0x805AF0", VA = "0x180806EF0")]
		public static void Refresh(AutoChessBattleHelpBattleInfo from, HelpBattleData to)
		{
		}

		// Token: 0x0601055F RID: 66911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601055F")]
		[Address(RVA = "0x807BF0", Offset = "0x8067F0", VA = "0x180807BF0")]
		public static void Refresh(AutoChessBattleEscapedEnemyInfo from, EscapedEnemyInfo to)
		{
		}

		// Token: 0x06010560 RID: 66912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010560")]
		[Address(RVA = "0x807440", Offset = "0x806040", VA = "0x180807440")]
		public static void Refresh(AutoChessBattleCharBattleStatus from, HelpBattleData.BattleChessStatus to)
		{
		}

		// Token: 0x06010561 RID: 66913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010561")]
		[Address(RVA = "0x804B70", Offset = "0x803770", VA = "0x180804B70")]
		public static void Refresh(AutoChessBattleSettleInfo from, SettleData to)
		{
		}

		// Token: 0x06010562 RID: 66914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010562")]
		[Address(RVA = "0x806490", Offset = "0x805090", VA = "0x180806490")]
		public static void Refresh(AutoChessBattleSettleBossSettleRecordInfo from, SettleData.BossSettleRecord to)
		{
		}

		// Token: 0x06010563 RID: 66915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010563")]
		[Address(RVA = "0x805D60", Offset = "0x804960", VA = "0x180805D60")]
		public static void Refresh(AutoChessBattleBossBattleInfo from, BossBattleData to)
		{
		}

		// Token: 0x06010564 RID: 66916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010564")]
		[Address(RVA = "0x805BA0", Offset = "0x8047A0", VA = "0x180805BA0")]
		public static void Refresh(AutoChessBattleBossRoundInfo from, BossRoundInfo to)
		{
		}

		// Token: 0x06010565 RID: 66917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010565")]
		[Address(RVA = "0x803B60", Offset = "0x802760", VA = "0x180803B60")]
		private static string GetBondIdByIdentifier(int identifier)
		{
			return null;
		}

		// Token: 0x06010566 RID: 66918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010566")]
		[Address(RVA = "0x803DE0", Offset = "0x8029E0", VA = "0x180803DE0")]
		private static string GetChessIdByIdentifier(int identifier)
		{
			return null;
		}

		// Token: 0x06010567 RID: 66919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010567")]
		[Address(RVA = "0x807C90", Offset = "0x806890", VA = "0x180807C90")]
		public DataConverter()
		{
		}

		// Token: 0x0401241A RID: 74778
		[Token(Token = "0x401241A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ResizeUseNew;

		// Token: 0x0401241B RID: 74779
		[Token(Token = "0x401241B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CopyListData;

		// Token: 0x0401241C RID: 74780
		[Token(Token = "0x401241C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x0401241D RID: 74781
		[Token(Token = "0x401241D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix1_Refresh;

		// Token: 0x0401241E RID: 74782
		[Token(Token = "0x401241E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix2_Refresh;

		// Token: 0x0401241F RID: 74783
		[Token(Token = "0x401241F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix3_Refresh;

		// Token: 0x04012420 RID: 74784
		[Token(Token = "0x4012420")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix4_Refresh;

		// Token: 0x04012421 RID: 74785
		[Token(Token = "0x4012421")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix5_Refresh;

		// Token: 0x04012422 RID: 74786
		[Token(Token = "0x4012422")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix6_Refresh;

		// Token: 0x04012423 RID: 74787
		[Token(Token = "0x4012423")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix7_Refresh;

		// Token: 0x04012424 RID: 74788
		[Token(Token = "0x4012424")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix8_Refresh;

		// Token: 0x04012425 RID: 74789
		[Token(Token = "0x4012425")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix9_Refresh;

		// Token: 0x04012426 RID: 74790
		[Token(Token = "0x4012426")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix10_Refresh;

		// Token: 0x04012427 RID: 74791
		[Token(Token = "0x4012427")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix11_Refresh;

		// Token: 0x04012428 RID: 74792
		[Token(Token = "0x4012428")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix12_Refresh;

		// Token: 0x04012429 RID: 74793
		[Token(Token = "0x4012429")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix13_Refresh;

		// Token: 0x0401242A RID: 74794
		[Token(Token = "0x401242A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix14_Refresh;

		// Token: 0x0401242B RID: 74795
		[Token(Token = "0x401242B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix15_Refresh;

		// Token: 0x0401242C RID: 74796
		[Token(Token = "0x401242C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix16_Refresh;

		// Token: 0x0401242D RID: 74797
		[Token(Token = "0x401242D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix17_Refresh;

		// Token: 0x0401242E RID: 74798
		[Token(Token = "0x401242E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix18_Refresh;

		// Token: 0x0401242F RID: 74799
		[Token(Token = "0x401242F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix19_Refresh;

		// Token: 0x04012430 RID: 74800
		[Token(Token = "0x4012430")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix20_Refresh;

		// Token: 0x04012431 RID: 74801
		[Token(Token = "0x4012431")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix21_Refresh;

		// Token: 0x04012432 RID: 74802
		[Token(Token = "0x4012432")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix22_Refresh;

		// Token: 0x04012433 RID: 74803
		[Token(Token = "0x4012433")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix23_Refresh;

		// Token: 0x04012434 RID: 74804
		[Token(Token = "0x4012434")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix24_Refresh;

		// Token: 0x04012435 RID: 74805
		[Token(Token = "0x4012435")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix25_Refresh;

		// Token: 0x04012436 RID: 74806
		[Token(Token = "0x4012436")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix26_Refresh;

		// Token: 0x04012437 RID: 74807
		[Token(Token = "0x4012437")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix27_Refresh;

		// Token: 0x04012438 RID: 74808
		[Token(Token = "0x4012438")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix28_Refresh;

		// Token: 0x04012439 RID: 74809
		[Token(Token = "0x4012439")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix29_Refresh;

		// Token: 0x0401243A RID: 74810
		[Token(Token = "0x401243A")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix30_Refresh;

		// Token: 0x0401243B RID: 74811
		[Token(Token = "0x401243B")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix31_Refresh;

		// Token: 0x0401243C RID: 74812
		[Token(Token = "0x401243C")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix32_Refresh;

		// Token: 0x0401243D RID: 74813
		[Token(Token = "0x401243D")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix33_Refresh;

		// Token: 0x0401243E RID: 74814
		[Token(Token = "0x401243E")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix34_Refresh;

		// Token: 0x0401243F RID: 74815
		[Token(Token = "0x401243F")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix35_Refresh;

		// Token: 0x04012440 RID: 74816
		[Token(Token = "0x4012440")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix36_Refresh;

		// Token: 0x04012441 RID: 74817
		[Token(Token = "0x4012441")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix37_Refresh;

		// Token: 0x04012442 RID: 74818
		[Token(Token = "0x4012442")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_GetBondIdByIdentifier;

		// Token: 0x04012443 RID: 74819
		[Token(Token = "0x4012443")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_GetChessIdByIdentifier;

		// Token: 0x04012444 RID: 74820
		[Token(Token = "0x4012444")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
