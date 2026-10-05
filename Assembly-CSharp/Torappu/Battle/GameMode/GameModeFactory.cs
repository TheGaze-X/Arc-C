using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using Torappu.Activity.Act20side.Battle.UI;
using Torappu.Activity.GameCity.Battle.UI;
using Torappu.Battle.AutoChess;
using Torappu.Battle.Cooperate;
using Torappu.Battle.DataCenter;
using Torappu.Battle.Douququ;
using Torappu.Battle.Effects;
using Torappu.Battle.EnemyDuel;
using Torappu.Battle.FunLive;
using Torappu.Battle.GameCity;
using Torappu.Battle.HalfIdle;
using Torappu.Battle.Legion;
using Torappu.Battle.Racing;
using Torappu.Battle.Roguelike;
using Torappu.Battle.Runes;
using Torappu.Battle.Sandbox;
using Torappu.Battle.Strife;
using Torappu.Battle.UI;
using Torappu.Battle.UI.Cooperate;
using Torappu.Multiplayer;
using Torappu.ObjectPool;
using Torappu.Rendering;
using Torappu.UI.EnemyDuel.Service;
using UnityEngine;
using XLua;

namespace Torappu.Battle.GameMode
{
	// Token: 0x0200278D RID: 10125
	[Token(Token = "0x200278D")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class GameModeFactory
	{
		// Token: 0x06010853 RID: 67667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010853")]
		[Address(RVA = "0x8537C0", Offset = "0x8523C0", VA = "0x1808537C0")]
		public static IGameMode Create(ref GameModeMeta meta)
		{
			return null;
		}

		// Token: 0x06010854 RID: 67668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010854")]
		[Address(RVA = "0x853ED0", Offset = "0x852AD0", VA = "0x180853ED0")]
		public static Dictionary<ResourceCollector.PreloadType, object> GatherPreloadAssets()
		{
			return null;
		}

		// Token: 0x06010855 RID: 67669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010855")]
		[Address(RVA = "0x8553F0", Offset = "0x853FF0", VA = "0x1808553F0")]
		public static GameObject LoadUIPlugin()
		{
			return null;
		}

		// Token: 0x06010856 RID: 67670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010856")]
		[Address(RVA = "0x854C50", Offset = "0x853850", VA = "0x180854C50")]
		public static GameObject LoadCameraPlugin()
		{
			return null;
		}

		// Token: 0x06010857 RID: 67671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010857")]
		[Address(RVA = "0x854270", Offset = "0x852E70", VA = "0x180854270")]
		public static List<TipData> GetLoadingTips()
		{
			return null;
		}

		// Token: 0x06010858 RID: 67672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010858")]
		[Address(RVA = "0x8561B0", Offset = "0x854DB0", VA = "0x1808561B0")]
		private static List<TipData> _GetSandboxLoadingTips(string topicId)
		{
			return null;
		}

		// Token: 0x06010859 RID: 67673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010859")]
		[Address(RVA = "0x855C90", Offset = "0x854890", VA = "0x180855C90")]
		private static List<TipData> _GetActMultiV3LoadingTips(string actId)
		{
			return null;
		}

		// Token: 0x0601085A RID: 67674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601085A")]
		[Address(RVA = "0x855ED0", Offset = "0x854AD0", VA = "0x180855ED0")]
		private static List<TipData> _GetEnemyDuelLoadingTips(string actId, string subModeId)
		{
			return null;
		}

		// Token: 0x0601085B RID: 67675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601085B")]
		[Address(RVA = "0x856290", Offset = "0x854E90", VA = "0x180856290")]
		private static GameObject _LoadAutoChessActUIPlugin()
		{
			return null;
		}

		// Token: 0x040128A0 RID: 75936
		[Token(Token = "0x40128A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x040128A1 RID: 75937
		[Token(Token = "0x40128A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherPreloadAssets;

		// Token: 0x040128A2 RID: 75938
		[Token(Token = "0x40128A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadUIPlugin;

		// Token: 0x040128A3 RID: 75939
		[Token(Token = "0x40128A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadCameraPlugin;

		// Token: 0x040128A4 RID: 75940
		[Token(Token = "0x40128A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetLoadingTips;

		// Token: 0x040128A5 RID: 75941
		[Token(Token = "0x40128A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetSandboxLoadingTips;

		// Token: 0x040128A6 RID: 75942
		[Token(Token = "0x40128A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetActMultiV3LoadingTips;

		// Token: 0x040128A7 RID: 75943
		[Token(Token = "0x40128A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetEnemyDuelLoadingTips;

		// Token: 0x040128A8 RID: 75944
		[Token(Token = "0x40128A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadAutoChessActUIPlugin;

		// Token: 0x0200278E RID: 10126
		[Token(Token = "0x200278E")]
		public class Act20SideGameMode : GameModeFactory.DefaultGameMode
		{
			// Token: 0x17002420 RID: 9248
			// (get) Token: 0x0601085C RID: 67676 RVA: 0x00064C38 File Offset: 0x00062E38
			[Token(Token = "0x17002420")]
			public override GameModeMeta.GameModeType gameModeType
			{
				[Token(Token = "0x601085C")]
				[Address(RVA = "0x83ECC0", Offset = "0x83D8C0", VA = "0x18083ECC0", Slot = "119")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x17002421 RID: 9249
			// (get) Token: 0x0601085D RID: 67677 RVA: 0x00064C50 File Offset: 0x00062E50
			[Token(Token = "0x17002421")]
			public FP maxPlayTime
			{
				[Token(Token = "0x601085D")]
				[Address(RVA = "0x83ED20", Offset = "0x83D920", VA = "0x18083ED20")]
				get
				{
					return default(FP);
				}
			}

			// Token: 0x17002422 RID: 9250
			// (get) Token: 0x0601085E RID: 67678 RVA: 0x00064C68 File Offset: 0x00062E68
			[Token(Token = "0x17002422")]
			public int score
			{
				[Token(Token = "0x601085E")]
				[Address(RVA = "0x83ED80", Offset = "0x83D980", VA = "0x18083ED80")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601085F RID: 67679 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601085F")]
			[Address(RVA = "0x83E690", Offset = "0x83D290", VA = "0x18083E690")]
			public void IncreaseScore(int value)
			{
			}

			// Token: 0x06010860 RID: 67680 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010860")]
			[Address(RVA = "0x83E580", Offset = "0x83D180", VA = "0x18083E580")]
			public void AssignUIPlugin(Act20SideUIPlugin uiPlugin)
			{
			}

			// Token: 0x06010861 RID: 67681 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010861")]
			[Address(RVA = "0x83E750", Offset = "0x83D350", VA = "0x18083E750", Slot = "122")]
			public override void Init(ref GameModeMeta meta, ref int randomSeed, BattlePlayerData playerData, LevelData levelData)
			{
			}

			// Token: 0x06010862 RID: 67682 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010862")]
			[Address(RVA = "0x83E860", Offset = "0x83D460", VA = "0x18083E860", Slot = "126")]
			public override void Tick(Action doDefaultTick)
			{
			}

			// Token: 0x06010863 RID: 67683 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010863")]
			[Address(RVA = "0x83EAB0", Offset = "0x83D6B0", VA = "0x18083EAB0")]
			private void _CheckGameFinish()
			{
			}

			// Token: 0x06010864 RID: 67684 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010864")]
			[Address(RVA = "0x83E600", Offset = "0x83D200", VA = "0x18083E600", Slot = "155")]
			public override Scheduler.SchedulerPreprocessor GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x06010865 RID: 67685 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010865")]
			[Address(RVA = "0x83EC50", Offset = "0x83D850", VA = "0x18083EC50")]
			public Act20SideGameMode(ref GameModeMeta meta)
			{
			}

			// Token: 0x06010866 RID: 67686 RVA: 0x00064C80 File Offset: 0x00062E80
			[Token(Token = "0x6010866")]
			[Address(RVA = "0x83EAA0", Offset = "0x83D6A0", VA = "0x18083EAA0")]
			private GameModeMeta.GameModeType <>xLuaBaseProxy_get_gameModeType()
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}

			// Token: 0x06010867 RID: 67687 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010867")]
			[Address(RVA = "0x83EA80", Offset = "0x83D680", VA = "0x18083EA80")]
			private void <>xLuaBaseProxy_Init(ref GameModeMeta P0, ref int P1, BattlePlayerData P2, LevelData P3)
			{
			}

			// Token: 0x06010868 RID: 67688 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010868")]
			[Address(RVA = "0x83EA90", Offset = "0x83D690", VA = "0x18083EA90")]
			private void <>xLuaBaseProxy_Tick(Action P0)
			{
			}

			// Token: 0x06010869 RID: 67689 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010869")]
			[Address(RVA = "0x83EA70", Offset = "0x83D670", VA = "0x18083EA70")]
			private Scheduler.SchedulerPreprocessor <>xLuaBaseProxy_GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x040128A9 RID: 75945
			[Token(Token = "0x40128A9")]
			public const string BATTLE_UI_PLUGIN_PATH = "UI/[UC]Cars/Battle/act20side_battle_ui_plugin.prefab";

			// Token: 0x040128AA RID: 75946
			[Token(Token = "0x40128AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Act20SideUIPlugin m_uiPlugin;

			// Token: 0x040128AB RID: 75947
			[Token(Token = "0x40128AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private FP m_maxPlayTime;

			// Token: 0x040128AC RID: 75948
			[Token(Token = "0x40128AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int m_score;

			// Token: 0x040128AD RID: 75949
			[Token(Token = "0x40128AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_gameModeType;

			// Token: 0x040128AE RID: 75950
			[Token(Token = "0x40128AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_maxPlayTime;

			// Token: 0x040128AF RID: 75951
			[Token(Token = "0x40128AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_score;

			// Token: 0x040128B0 RID: 75952
			[Token(Token = "0x40128B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_IncreaseScore;

			// Token: 0x040128B1 RID: 75953
			[Token(Token = "0x40128B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AssignUIPlugin;

			// Token: 0x040128B2 RID: 75954
			[Token(Token = "0x40128B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x040128B3 RID: 75955
			[Token(Token = "0x40128B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_Tick;

			// Token: 0x040128B4 RID: 75956
			[Token(Token = "0x40128B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__CheckGameFinish;

			// Token: 0x040128B5 RID: 75957
			[Token(Token = "0x40128B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_GetSchedulerPreprocessor;

			// Token: 0x040128B6 RID: 75958
			[Token(Token = "0x40128B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200278F RID: 10127
		[Token(Token = "0x200278F")]
		public class Act27SideGameMode : GameModeFactory.DefaultGameMode
		{
			// Token: 0x17002423 RID: 9251
			// (get) Token: 0x0601086A RID: 67690 RVA: 0x00064C98 File Offset: 0x00062E98
			[Token(Token = "0x17002423")]
			public int totalTargetTilesCnt
			{
				[Token(Token = "0x601086A")]
				[Address(RVA = "0x83F800", Offset = "0x83E400", VA = "0x18083F800")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002424 RID: 9252
			// (get) Token: 0x0601086B RID: 67691 RVA: 0x00064CB0 File Offset: 0x00062EB0
			[Token(Token = "0x17002424")]
			public int finishedTilesCnt
			{
				[Token(Token = "0x601086B")]
				[Address(RVA = "0x83F720", Offset = "0x83E320", VA = "0x18083F720")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601086C RID: 67692 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601086C")]
			[Address(RVA = "0x83F690", Offset = "0x83E290", VA = "0x18083F690")]
			public Act27SideGameMode(ref GameModeMeta meta)
			{
			}

			// Token: 0x17002425 RID: 9253
			// (get) Token: 0x0601086D RID: 67693 RVA: 0x00064CC8 File Offset: 0x00062EC8
			[Token(Token = "0x17002425")]
			public override GameModeMeta.GameModeType gameModeType
			{
				[Token(Token = "0x601086D")]
				[Address(RVA = "0x83F790", Offset = "0x83E390", VA = "0x18083F790", Slot = "119")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x0601086E RID: 67694 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601086E")]
			[Address(RVA = "0x83EEE0", Offset = "0x83DAE0", VA = "0x18083EEE0", Slot = "122")]
			public override void Init(ref GameModeMeta meta, ref int randomSeed, BattlePlayerData playerData, LevelData levelData)
			{
			}

			// Token: 0x0601086F RID: 67695 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601086F")]
			[Address(RVA = "0x83F230", Offset = "0x83DE30", VA = "0x18083F230", Slot = "126")]
			public override void Tick(Action doDefaultTick)
			{
			}

			// Token: 0x06010870 RID: 67696 RVA: 0x00064CE0 File Offset: 0x00062EE0
			[Token(Token = "0x6010870")]
			[Address(RVA = "0x83EDE0", Offset = "0x83D9E0", VA = "0x18083EDE0", Slot = "173")]
			public override bool HookBattleFinishAudio(BattleController.GameResult result)
			{
				return default(bool);
			}

			// Token: 0x06010871 RID: 67697 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010871")]
			[Address(RVA = "0x83F130", Offset = "0x83DD30", VA = "0x18083F130")]
			public void OnFinishedTileCntChanged(Act27SideBattleManager.MechanismSideType prevSideType, Act27SideBattleManager.MechanismSideType targetSideType)
			{
			}

			// Token: 0x06010872 RID: 67698 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010872")]
			[Address(RVA = "0x83F470", Offset = "0x83E070", VA = "0x18083F470")]
			private void _CheckGameFinish()
			{
			}

			// Token: 0x06010874 RID: 67700 RVA: 0x00064CF8 File Offset: 0x00062EF8
			[Token(Token = "0x6010874")]
			[Address(RVA = "0x83EAA0", Offset = "0x83D6A0", VA = "0x18083EAA0")]
			private GameModeMeta.GameModeType <>xLuaBaseProxy_get_gameModeType()
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}

			// Token: 0x06010875 RID: 67701 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010875")]
			[Address(RVA = "0x83EA80", Offset = "0x83D680", VA = "0x18083EA80")]
			private void <>xLuaBaseProxy_Init(ref GameModeMeta P0, ref int P1, BattlePlayerData P2, LevelData P3)
			{
			}

			// Token: 0x06010876 RID: 67702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010876")]
			[Address(RVA = "0x83EA90", Offset = "0x83D690", VA = "0x18083EA90")]
			private void <>xLuaBaseProxy_Tick(Action P0)
			{
			}

			// Token: 0x06010877 RID: 67703 RVA: 0x00064D10 File Offset: 0x00062F10
			[Token(Token = "0x6010877")]
			[Address(RVA = "0x83F460", Offset = "0x83E060", VA = "0x18083F460")]
			private bool <>xLuaBaseProxy_HookBattleFinishAudio(BattleController.GameResult P0)
			{
				return default(bool);
			}

			// Token: 0x040128B7 RID: 75959
			[Token(Token = "0x40128B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly string ACT27SIDE_TILE_KEY;

			// Token: 0x040128B8 RID: 75960
			[Token(Token = "0x40128B8")]
			public const string BATTLE_UI_PLUGIN_PATH = "UI/[UC]Grocery/Battle/act27side_battle_ui_plugin.prefab";

			// Token: 0x040128B9 RID: 75961
			[Token(Token = "0x40128B9")]
			private const string ACT27SIDE_BATTLE_WIN_SIGNAL = "act27side_win";

			// Token: 0x040128BA RID: 75962
			[Token(Token = "0x40128BA")]
			private const string ACT27SIDE_BATTLE_LOSE_SIGNAL = "act27side_lose";

			// Token: 0x040128BB RID: 75963
			[Token(Token = "0x40128BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_totalTargetTilesCnt;

			// Token: 0x040128BC RID: 75964
			[Token(Token = "0x40128BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int m_finishedTilesCnt;

			// Token: 0x040128BD RID: 75965
			[Token(Token = "0x40128BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private FP m_maxPlayTime;

			// Token: 0x040128BE RID: 75966
			[Token(Token = "0x40128BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_totalTargetTilesCnt;

			// Token: 0x040128BF RID: 75967
			[Token(Token = "0x40128BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_finishedTilesCnt;

			// Token: 0x040128C0 RID: 75968
			[Token(Token = "0x40128C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040128C1 RID: 75969
			[Token(Token = "0x40128C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_gameModeType;

			// Token: 0x040128C2 RID: 75970
			[Token(Token = "0x40128C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x040128C3 RID: 75971
			[Token(Token = "0x40128C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_Tick;

			// Token: 0x040128C4 RID: 75972
			[Token(Token = "0x40128C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_HookBattleFinishAudio;

			// Token: 0x040128C5 RID: 75973
			[Token(Token = "0x40128C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OnFinishedTileCntChanged;

			// Token: 0x040128C6 RID: 75974
			[Token(Token = "0x40128C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__CheckGameFinish;
		}

		// Token: 0x02002790 RID: 10128
		[Token(Token = "0x2002790")]
		public class Act6FunGameMode : GameModeFactory.DefaultGameMode
		{
			// Token: 0x17002426 RID: 9254
			// (get) Token: 0x06010878 RID: 67704 RVA: 0x00064D28 File Offset: 0x00062F28
			[Token(Token = "0x17002426")]
			public int coinCnt
			{
				[Token(Token = "0x6010878")]
				[Address(RVA = "0x842B50", Offset = "0x841750", VA = "0x180842B50")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002427 RID: 9255
			// (get) Token: 0x06010879 RID: 67705 RVA: 0x00064D40 File Offset: 0x00062F40
			[Token(Token = "0x17002427")]
			public bool isCoinFever
			{
				[Token(Token = "0x6010879")]
				[Address(RVA = "0x842C30", Offset = "0x841830", VA = "0x180842C30")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601087A RID: 67706 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601087A")]
			[Address(RVA = "0x83F870", Offset = "0x83E470", VA = "0x18083F870")]
			public void GainCoin()
			{
			}

			// Token: 0x0601087B RID: 67707 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601087B")]
			[Address(RVA = "0x840450", Offset = "0x83F050", VA = "0x180840450", Slot = "136")]
			public override void PreprocessLevelData(LevelData levelData)
			{
			}

			// Token: 0x0601087C RID: 67708 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601087C")]
			[Address(RVA = "0x83FE90", Offset = "0x83EA90", VA = "0x18083FE90", Slot = "122")]
			public override void Init(ref GameModeMeta meta, ref int randomSeed, BattlePlayerData playerData, LevelData levelData)
			{
			}

			// Token: 0x0601087D RID: 67709 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601087D")]
			[Address(RVA = "0x83FD90", Offset = "0x83E990", VA = "0x18083FD90", Slot = "168")]
			public override string HookTileAppendInfoKey(string originTileKey)
			{
				return null;
			}

			// Token: 0x0601087E RID: 67710 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601087E")]
			[Address(RVA = "0x840620", Offset = "0x83F220", VA = "0x180840620", Slot = "124")]
			public override void StartGame(Action doDefaultStart)
			{
			}

			// Token: 0x0601087F RID: 67711 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601087F")]
			[Address(RVA = "0x840210", Offset = "0x83EE10", VA = "0x180840210", Slot = "161")]
			public override void OnUnitRegistered(Unit unit)
			{
			}

			// Token: 0x06010880 RID: 67712 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010880")]
			[Address(RVA = "0x83FFD0", Offset = "0x83EBD0", VA = "0x18083FFD0", Slot = "164")]
			public override void OnEnemyFinished(Enemy enemy, Entity.FinishReason reason)
			{
			}

			// Token: 0x06010881 RID: 67713 RVA: 0x00064D58 File Offset: 0x00062F58
			[Token(Token = "0x6010881")]
			[Address(RVA = "0x83F940", Offset = "0x83E540", VA = "0x18083F940", Slot = "151")]
			public override bool GameNotFinishCondition()
			{
				return default(bool);
			}

			// Token: 0x06010882 RID: 67714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010882")]
			[Address(RVA = "0x840190", Offset = "0x83ED90", VA = "0x180840190", Slot = "191")]
			public override void OnPlayerLifeToZero(PlayerSide side)
			{
			}

			// Token: 0x06010883 RID: 67715 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010883")]
			[Address(RVA = "0x8408D0", Offset = "0x83F4D0", VA = "0x1808408D0", Slot = "126")]
			public override void Tick(Action doDefaultTick)
			{
			}

			// Token: 0x06010884 RID: 67716 RVA: 0x00064D70 File Offset: 0x00062F70
			[Token(Token = "0x6010884")]
			[Address(RVA = "0x83FAB0", Offset = "0x83E6B0", VA = "0x18083FAB0", Slot = "175")]
			public override bool HookEnemyReachedExitAudio(Enemy enemy)
			{
				return default(bool);
			}

			// Token: 0x06010885 RID: 67717 RVA: 0x00064D88 File Offset: 0x00062F88
			[Token(Token = "0x6010885")]
			[Address(RVA = "0x83FB70", Offset = "0x83E770", VA = "0x18083FB70", Slot = "174")]
			public override bool HookPlayAudioSignal(string ev, Unit unit, bool ignorePredefined)
			{
				return default(bool);
			}

			// Token: 0x06010886 RID: 67718 RVA: 0x00064DA0 File Offset: 0x00062FA0
			[Token(Token = "0x6010886")]
			[Address(RVA = "0x83F9B0", Offset = "0x83E5B0", VA = "0x18083F9B0", Slot = "173")]
			public override bool HookBattleFinishAudio(BattleController.GameResult result)
			{
				return default(bool);
			}

			// Token: 0x06010887 RID: 67719 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010887")]
			[Address(RVA = "0x841A00", Offset = "0x840600", VA = "0x180841A00")]
			private void _ProcessActions()
			{
			}

			// Token: 0x06010888 RID: 67720 RVA: 0x00064DB8 File Offset: 0x00062FB8
			[Token(Token = "0x6010888")]
			[Address(RVA = "0x841F40", Offset = "0x840B40", VA = "0x180841F40")]
			private bool _TryExecuteOperation(Act6FunPuzzleConfig.CharacterAction characterAction, ref int indexInReadyList)
			{
				return default(bool);
			}

			// Token: 0x06010889 RID: 67721 RVA: 0x00064DD0 File Offset: 0x00062FD0
			[Token(Token = "0x6010889")]
			[Address(RVA = "0x842890", Offset = "0x841490", VA = "0x180842890")]
			private bool _WithdrawInternal(Character character)
			{
				return default(bool);
			}

			// Token: 0x0601088A RID: 67722 RVA: 0x00064DE8 File Offset: 0x00062FE8
			[Token(Token = "0x601088A")]
			[Address(RVA = "0x841CD0", Offset = "0x8408D0", VA = "0x180841CD0")]
			private bool _TrigSkillInternal(Character character)
			{
				return default(bool);
			}

			// Token: 0x0601088B RID: 67723 RVA: 0x00064E00 File Offset: 0x00063000
			[Token(Token = "0x601088B")]
			[Address(RVA = "0x842640", Offset = "0x841240", VA = "0x180842640")]
			private bool _TryTriggerActions(GridPosition pos)
			{
				return default(bool);
			}

			// Token: 0x0601088C RID: 67724 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601088C")]
			[Address(RVA = "0x840AC0", Offset = "0x83F6C0", VA = "0x180840AC0")]
			private void _AddCharacterActions(List<Act6FunPuzzleConfig.CharacterAction> actions)
			{
			}

			// Token: 0x0601088D RID: 67725 RVA: 0x00064E18 File Offset: 0x00063018
			[Token(Token = "0x601088D")]
			[Address(RVA = "0x842560", Offset = "0x841160", VA = "0x180842560")]
			private bool _TrySummonEnemyBranch(string branchId)
			{
				return default(bool);
			}

			// Token: 0x0601088E RID: 67726 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601088E")]
			[Address(RVA = "0x840E50", Offset = "0x83FA50", VA = "0x180840E50")]
			private Act6FunPuzzleConfig.LevelPuzzlePack _GetLevelCharacterActionPack(string levelId, ref List<Act6FunPuzzleConfig.LevelPuzzlePack> characterActionPacks)
			{
				return null;
			}

			// Token: 0x0601088F RID: 67727 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601088F")]
			[Address(RVA = "0x841830", Offset = "0x840430", VA = "0x180841830")]
			private void _ParseCameraFOV()
			{
			}

			// Token: 0x06010890 RID: 67728 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010890")]
			[Address(RVA = "0x840FE0", Offset = "0x83FBE0", VA = "0x180840FE0")]
			private void _LoadPuzzleConfig()
			{
			}

			// Token: 0x06010891 RID: 67729 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010891")]
			[Address(RVA = "0x840C50", Offset = "0x83F850", VA = "0x180840C50")]
			private void _GetFeverCoinCnt()
			{
			}

			// Token: 0x06010892 RID: 67730 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010892")]
			[Address(RVA = "0x841540", Offset = "0x840140", VA = "0x180841540")]
			private void _LogEnemyReachExit(Enemy enemy)
			{
			}

			// Token: 0x17002428 RID: 9256
			// (get) Token: 0x06010893 RID: 67731 RVA: 0x00064E30 File Offset: 0x00063030
			[Token(Token = "0x17002428")]
			public override GameModeMeta.GameModeType gameModeType
			{
				[Token(Token = "0x6010893")]
				[Address(RVA = "0x842BC0", Offset = "0x8417C0", VA = "0x180842BC0", Slot = "119")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x06010894 RID: 67732 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010894")]
			[Address(RVA = "0x842AC0", Offset = "0x8416C0", VA = "0x180842AC0")]
			public Act6FunGameMode(ref GameModeMeta meta)
			{
			}

			// Token: 0x06010896 RID: 67734 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010896")]
			[Address(RVA = "0x840AA0", Offset = "0x83F6A0", VA = "0x180840AA0")]
			private void <>xLuaBaseProxy_PreprocessLevelData(LevelData P0)
			{
			}

			// Token: 0x06010897 RID: 67735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010897")]
			[Address(RVA = "0x83EA80", Offset = "0x83D680", VA = "0x18083EA80")]
			private void <>xLuaBaseProxy_Init(ref GameModeMeta P0, ref int P1, BattlePlayerData P2, LevelData P3)
			{
			}

			// Token: 0x06010898 RID: 67736 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010898")]
			[Address(RVA = "0x840A60", Offset = "0x83F660", VA = "0x180840A60")]
			private string <>xLuaBaseProxy_HookTileAppendInfoKey(string P0)
			{
				return null;
			}

			// Token: 0x06010899 RID: 67737 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010899")]
			[Address(RVA = "0x840AB0", Offset = "0x83F6B0", VA = "0x180840AB0")]
			private void <>xLuaBaseProxy_StartGame(Action P0)
			{
			}

			// Token: 0x0601089A RID: 67738 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601089A")]
			[Address(RVA = "0x840A90", Offset = "0x83F690", VA = "0x180840A90")]
			private void <>xLuaBaseProxy_OnUnitRegistered(Unit P0)
			{
			}

			// Token: 0x0601089B RID: 67739 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601089B")]
			[Address(RVA = "0x840A70", Offset = "0x83F670", VA = "0x180840A70")]
			private void <>xLuaBaseProxy_OnEnemyFinished(Enemy P0, Entity.FinishReason P1)
			{
			}

			// Token: 0x0601089C RID: 67740 RVA: 0x00064E48 File Offset: 0x00063048
			[Token(Token = "0x601089C")]
			[Address(RVA = "0x840A30", Offset = "0x83F630", VA = "0x180840A30")]
			private bool <>xLuaBaseProxy_GameNotFinishCondition()
			{
				return default(bool);
			}

			// Token: 0x0601089D RID: 67741 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601089D")]
			[Address(RVA = "0x840A80", Offset = "0x83F680", VA = "0x180840A80")]
			private void <>xLuaBaseProxy_OnPlayerLifeToZero(PlayerSide P0)
			{
			}

			// Token: 0x0601089E RID: 67742 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601089E")]
			[Address(RVA = "0x83EA90", Offset = "0x83D690", VA = "0x18083EA90")]
			private void <>xLuaBaseProxy_Tick(Action P0)
			{
			}

			// Token: 0x0601089F RID: 67743 RVA: 0x00064E60 File Offset: 0x00063060
			[Token(Token = "0x601089F")]
			[Address(RVA = "0x840A40", Offset = "0x83F640", VA = "0x180840A40")]
			private bool <>xLuaBaseProxy_HookEnemyReachedExitAudio(Enemy P0)
			{
				return default(bool);
			}

			// Token: 0x060108A0 RID: 67744 RVA: 0x00064E78 File Offset: 0x00063078
			[Token(Token = "0x60108A0")]
			[Address(RVA = "0x840A50", Offset = "0x83F650", VA = "0x180840A50")]
			private bool <>xLuaBaseProxy_HookPlayAudioSignal(string P0, Unit P1, bool P2)
			{
				return default(bool);
			}

			// Token: 0x060108A1 RID: 67745 RVA: 0x00064E90 File Offset: 0x00063090
			[Token(Token = "0x60108A1")]
			[Address(RVA = "0x83F460", Offset = "0x83E060", VA = "0x18083F460")]
			private bool <>xLuaBaseProxy_HookBattleFinishAudio(BattleController.GameResult P0)
			{
				return default(bool);
			}

			// Token: 0x060108A2 RID: 67746 RVA: 0x00064EA8 File Offset: 0x000630A8
			[Token(Token = "0x60108A2")]
			[Address(RVA = "0x83EAA0", Offset = "0x83D6A0", VA = "0x18083EAA0")]
			private GameModeMeta.GameModeType <>xLuaBaseProxy_get_gameModeType()
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}

			// Token: 0x040128C7 RID: 75975
			[Token(Token = "0x40128C7")]
			public const string ACT6FUN_UI_PLUGIN_PATH = "UI/Activity/ActFun/Actfun6/Battle/act6fun_battle_ui_plugin.prefab";

			// Token: 0x040128C8 RID: 75976
			[Token(Token = "0x40128C8")]
			public const string ACT6FUN_CAMERA_PLUGIN_PATH = "UI/Activity/ActFun/Actfun6/Battle/act6fun_battle_camera_plugin.prefab";

			// Token: 0x040128C9 RID: 75977
			[Token(Token = "0x40128C9")]
			public const string ACT6FUN_PUZZLE_CONFIG_PATH = "Config/[UC]Act6funBattleConfigs";

			// Token: 0x040128CA RID: 75978
			[Token(Token = "0x40128CA")]
			private const string ACT6FUN_MAIN_ENEMY_WAVE_NAME = "act6fun_main_enemy_wave";

			// Token: 0x040128CB RID: 75979
			[Token(Token = "0x40128CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static Dictionary<string, string> HOOKED_TILE_APPEND_INFO;

			// Token: 0x040128CC RID: 75980
			[Token(Token = "0x40128CC")]
			private const int ENEMY_GAIN_COIN_CNT = 1;

			// Token: 0x040128CD RID: 75981
			[Token(Token = "0x40128CD")]
			private const float MIN_CAMERA_ASPECT = 1.34f;

			// Token: 0x040128CE RID: 75982
			[Token(Token = "0x40128CE")]
			private const float MAX_CAMERA_ASPECT = 2.22f;

			// Token: 0x040128CF RID: 75983
			[Token(Token = "0x40128CF")]
			private const float MIN_CAMERA_FOV = 35f;

			// Token: 0x040128D0 RID: 75984
			[Token(Token = "0x40128D0")]
			private const float MAX_CAMERA_FOV = 50f;

			// Token: 0x040128D1 RID: 75985
			[Token(Token = "0x40128D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private ObjectPtr<ControllableEnemy> m_mainEnemy;

			// Token: 0x040128D2 RID: 75986
			[Token(Token = "0x40128D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private bool m_isMainEnemyFinished;

			// Token: 0x040128D3 RID: 75987
			[Token(Token = "0x40128D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Act6FunPuzzleConfig.LevelPuzzlePack m_puzzlePack;

			// Token: 0x040128D4 RID: 75988
			[Token(Token = "0x40128D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<Act6FunPuzzleConfig.CharacterAction> m_pendingCharacterActions;

			// Token: 0x040128D5 RID: 75989
			[Token(Token = "0x40128D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private List<Act6FunPuzzleConfig.CharacterAction> m_readyCharacterActions;

			// Token: 0x040128D6 RID: 75990
			[Token(Token = "0x40128D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private GridPosition m_lastMainEnemyGridPos;

			// Token: 0x040128D7 RID: 75991
			[Token(Token = "0x40128D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private int m_coinCnt;

			// Token: 0x040128D8 RID: 75992
			[Token(Token = "0x40128D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private int m_feverCoinCnt;

			// Token: 0x040128D9 RID: 75993
			[Token(Token = "0x40128D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool m_isCoinFever;

			// Token: 0x040128DA RID: 75994
			[Token(Token = "0x40128DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_coinCnt;

			// Token: 0x040128DB RID: 75995
			[Token(Token = "0x40128DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_isCoinFever;

			// Token: 0x040128DC RID: 75996
			[Token(Token = "0x40128DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GainCoin;

			// Token: 0x040128DD RID: 75997
			[Token(Token = "0x40128DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_PreprocessLevelData;

			// Token: 0x040128DE RID: 75998
			[Token(Token = "0x40128DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x040128DF RID: 75999
			[Token(Token = "0x40128DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_HookTileAppendInfoKey;

			// Token: 0x040128E0 RID: 76000
			[Token(Token = "0x40128E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_StartGame;

			// Token: 0x040128E1 RID: 76001
			[Token(Token = "0x40128E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OnUnitRegistered;

			// Token: 0x040128E2 RID: 76002
			[Token(Token = "0x40128E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OnEnemyFinished;

			// Token: 0x040128E3 RID: 76003
			[Token(Token = "0x40128E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_GameNotFinishCondition;

			// Token: 0x040128E4 RID: 76004
			[Token(Token = "0x40128E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_OnPlayerLifeToZero;

			// Token: 0x040128E5 RID: 76005
			[Token(Token = "0x40128E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_Tick;

			// Token: 0x040128E6 RID: 76006
			[Token(Token = "0x40128E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_HookEnemyReachedExitAudio;

			// Token: 0x040128E7 RID: 76007
			[Token(Token = "0x40128E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_HookPlayAudioSignal;

			// Token: 0x040128E8 RID: 76008
			[Token(Token = "0x40128E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_HookBattleFinishAudio;

			// Token: 0x040128E9 RID: 76009
			[Token(Token = "0x40128E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0__ProcessActions;

			// Token: 0x040128EA RID: 76010
			[Token(Token = "0x40128EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0__TryExecuteOperation;

			// Token: 0x040128EB RID: 76011
			[Token(Token = "0x40128EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0__WithdrawInternal;

			// Token: 0x040128EC RID: 76012
			[Token(Token = "0x40128EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0__TrigSkillInternal;

			// Token: 0x040128ED RID: 76013
			[Token(Token = "0x40128ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0__TryTriggerActions;

			// Token: 0x040128EE RID: 76014
			[Token(Token = "0x40128EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0__AddCharacterActions;

			// Token: 0x040128EF RID: 76015
			[Token(Token = "0x40128EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0__TrySummonEnemyBranch;

			// Token: 0x040128F0 RID: 76016
			[Token(Token = "0x40128F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0__GetLevelCharacterActionPack;

			// Token: 0x040128F1 RID: 76017
			[Token(Token = "0x40128F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0__ParseCameraFOV;

			// Token: 0x040128F2 RID: 76018
			[Token(Token = "0x40128F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0__LoadPuzzleConfig;

			// Token: 0x040128F3 RID: 76019
			[Token(Token = "0x40128F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0__GetFeverCoinCnt;

			// Token: 0x040128F4 RID: 76020
			[Token(Token = "0x40128F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0__LogEnemyReachExit;

			// Token: 0x040128F5 RID: 76021
			[Token(Token = "0x40128F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0_get_gameModeType;

			// Token: 0x040128F6 RID: 76022
			[Token(Token = "0x40128F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002791 RID: 10129
		[Token(Token = "0x2002791")]
		public class Act7FunGameMode : GameModeFactory.DefaultGameMode
		{
			// Token: 0x17002429 RID: 9257
			// (get) Token: 0x060108A3 RID: 67747 RVA: 0x00064EC0 File Offset: 0x000630C0
			// (set) Token: 0x060108A4 RID: 67748 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002429")]
			public int maxTrapCnt
			{
				[Token(Token = "0x60108A3")]
				[Address(RVA = "0x858E60", Offset = "0x857A60", VA = "0x180858E60")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60108A4")]
				[Address(RVA = "0x858FF0", Offset = "0x857BF0", VA = "0x180858FF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700242A RID: 9258
			// (get) Token: 0x060108A5 RID: 67749 RVA: 0x00064ED8 File Offset: 0x000630D8
			// (set) Token: 0x060108A6 RID: 67750 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700242A")]
			public int passTrapCnt
			{
				[Token(Token = "0x60108A5")]
				[Address(RVA = "0x858EC0", Offset = "0x857AC0", VA = "0x180858EC0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60108A6")]
				[Address(RVA = "0x859060", Offset = "0x857C60", VA = "0x180859060")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700242B RID: 9259
			// (get) Token: 0x060108A7 RID: 67751 RVA: 0x00064EF0 File Offset: 0x000630F0
			// (set) Token: 0x060108A8 RID: 67752 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700242B")]
			public int curTrapCnt
			{
				[Token(Token = "0x60108A7")]
				[Address(RVA = "0x858DA0", Offset = "0x8579A0", VA = "0x180858DA0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60108A8")]
				[Address(RVA = "0x858F80", Offset = "0x857B80", VA = "0x180858F80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700242C RID: 9260
			// (get) Token: 0x060108A9 RID: 67753 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060108AA RID: 67754 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700242C")]
			public Act7FunStageAdditionData stageAdditionData
			{
				[Token(Token = "0x60108A9")]
				[Address(RVA = "0x858F20", Offset = "0x857B20", VA = "0x180858F20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60108AA")]
				[Address(RVA = "0x8590D0", Offset = "0x857CD0", VA = "0x1808590D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700242D RID: 9261
			// (get) Token: 0x060108AB RID: 67755 RVA: 0x00064F08 File Offset: 0x00063108
			[Token(Token = "0x1700242D")]
			public override GameModeMeta.GameModeType gameModeType
			{
				[Token(Token = "0x60108AB")]
				[Address(RVA = "0x858E00", Offset = "0x857A00", VA = "0x180858E00", Slot = "119")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x060108AC RID: 67756 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108AC")]
			[Address(RVA = "0x858CD0", Offset = "0x8578D0", VA = "0x180858CD0")]
			public Act7FunGameMode(ref GameModeMeta meta)
			{
			}

			// Token: 0x060108AD RID: 67757 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108AD")]
			[Address(RVA = "0x857F70", Offset = "0x856B70", VA = "0x180857F70", Slot = "122")]
			public override void Init(ref GameModeMeta meta, ref int randomSeed, BattlePlayerData playerData, LevelData levelData)
			{
			}

			// Token: 0x060108AE RID: 67758 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108AE")]
			[Address(RVA = "0x858AE0", Offset = "0x8576E0", VA = "0x180858AE0", Slot = "126")]
			public override void Tick(Action doDefaultTick)
			{
			}

			// Token: 0x060108AF RID: 67759 RVA: 0x00064F20 File Offset: 0x00063120
			[Token(Token = "0x60108AF")]
			[Address(RVA = "0x857F00", Offset = "0x856B00", VA = "0x180857F00", Slot = "129")]
			public override bool HookPlayerOp_Withdraw(Character character)
			{
				return default(bool);
			}

			// Token: 0x060108B0 RID: 67760 RVA: 0x00064F38 File Offset: 0x00063138
			[Token(Token = "0x60108B0")]
			[Address(RVA = "0x857E90", Offset = "0x856A90", VA = "0x180857E90", Slot = "131")]
			public override bool HookPlayerOp_TrigSkill(Character character)
			{
				return default(bool);
			}

			// Token: 0x060108B1 RID: 67761 RVA: 0x00064F50 File Offset: 0x00063150
			[Token(Token = "0x60108B1")]
			[Address(RVA = "0x857DF0", Offset = "0x8569F0", VA = "0x180857DF0", Slot = "130")]
			public override bool HookPlayerOp_Spawn(uint uniqueId, SharedConsts.Direction direction, Tile tile)
			{
				return default(bool);
			}

			// Token: 0x060108B2 RID: 67762 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108B2")]
			[Address(RVA = "0x858820", Offset = "0x857420", VA = "0x180858820", Slot = "136")]
			public override void PreprocessLevelData(LevelData levelData)
			{
			}

			// Token: 0x060108B3 RID: 67763 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108B3")]
			[Address(RVA = "0x8583A0", Offset = "0x856FA0", VA = "0x1808583A0", Slot = "160")]
			public override void OnApplyingGlobalModifier(ref Modifier modifier)
			{
			}

			// Token: 0x060108B4 RID: 67764 RVA: 0x00064F68 File Offset: 0x00063168
			[Token(Token = "0x60108B4")]
			[Address(RVA = "0x858740", Offset = "0x857340", VA = "0x180858740", Slot = "189")]
			public override bool OnEntityApplyModifier(Entity entity, ref Modifier modifier)
			{
				return default(bool);
			}

			// Token: 0x060108B5 RID: 67765 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108B5")]
			[Address(RVA = "0x8586C0", Offset = "0x8572C0", VA = "0x1808586C0", Slot = "192")]
			public override void OnEnemyReachExit(Enemy enemy, Tile cacheTile)
			{
			}

			// Token: 0x060108B6 RID: 67766 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108B6")]
			[Address(RVA = "0x8585F0", Offset = "0x8571F0", VA = "0x1808585F0", Slot = "163")]
			public override void OnCharacterFinished(Character character, Entity.FinishReason reason)
			{
			}

			// Token: 0x060108B7 RID: 67767 RVA: 0x00064F80 File Offset: 0x00063180
			[Token(Token = "0x60108B7")]
			[Address(RVA = "0x857950", Offset = "0x856550", VA = "0x180857950", Slot = "151")]
			public override bool GameNotFinishCondition()
			{
				return default(bool);
			}

			// Token: 0x060108B8 RID: 67768 RVA: 0x00064F98 File Offset: 0x00063198
			[Token(Token = "0x60108B8")]
			[Address(RVA = "0x857C50", Offset = "0x856850", VA = "0x180857C50", Slot = "184")]
			public override PlayerBattleRank GetBattleCompleteRank()
			{
				return (PlayerBattleRank)0;
			}

			// Token: 0x060108B9 RID: 67769 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60108B9")]
			[Address(RVA = "0x857B50", Offset = "0x856750", VA = "0x180857B50", Slot = "183")]
			public override object GetActMeta()
			{
				return null;
			}

			// Token: 0x060108BA RID: 67770 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108BA")]
			[Address(RVA = "0x858970", Offset = "0x857570", VA = "0x180858970", Slot = "145")]
			public override void SortDeck(Deck.Card[] cards)
			{
			}

			// Token: 0x060108BB RID: 67771 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108BB")]
			[Address(RVA = "0x857840", Offset = "0x856440", VA = "0x180857840")]
			public void AddTrapCnt()
			{
			}

			// Token: 0x060108BC RID: 67772 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108BC")]
			[Address(RVA = "0x8577A0", Offset = "0x8563A0", VA = "0x1808577A0")]
			public void AddEasterEggId(string id)
			{
			}

			// Token: 0x060108BD RID: 67773 RVA: 0x00064FB0 File Offset: 0x000631B0
			[Token(Token = "0x60108BD")]
			[Address(RVA = "0x83EAA0", Offset = "0x83D6A0", VA = "0x18083EAA0")]
			private GameModeMeta.GameModeType <>xLuaBaseProxy_get_gameModeType()
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}

			// Token: 0x060108BE RID: 67774 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108BE")]
			[Address(RVA = "0x83EA80", Offset = "0x83D680", VA = "0x18083EA80")]
			private void <>xLuaBaseProxy_Init(ref GameModeMeta P0, ref int P1, BattlePlayerData P2, LevelData P3)
			{
			}

			// Token: 0x060108BF RID: 67775 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108BF")]
			[Address(RVA = "0x83EA90", Offset = "0x83D690", VA = "0x18083EA90")]
			private void <>xLuaBaseProxy_Tick(Action P0)
			{
			}

			// Token: 0x060108C0 RID: 67776 RVA: 0x00064FC8 File Offset: 0x000631C8
			[Token(Token = "0x60108C0")]
			[Address(RVA = "0x858C70", Offset = "0x857870", VA = "0x180858C70")]
			private bool <>xLuaBaseProxy_HookPlayerOp_Withdraw(Character P0)
			{
				return default(bool);
			}

			// Token: 0x060108C1 RID: 67777 RVA: 0x00064FE0 File Offset: 0x000631E0
			[Token(Token = "0x60108C1")]
			[Address(RVA = "0x858C60", Offset = "0x857860", VA = "0x180858C60")]
			private bool <>xLuaBaseProxy_HookPlayerOp_TrigSkill(Character P0)
			{
				return default(bool);
			}

			// Token: 0x060108C2 RID: 67778 RVA: 0x00064FF8 File Offset: 0x000631F8
			[Token(Token = "0x60108C2")]
			[Address(RVA = "0x858C50", Offset = "0x857850", VA = "0x180858C50")]
			private bool <>xLuaBaseProxy_HookPlayerOp_Spawn(uint P0, SharedConsts.Direction P1, Tile P2)
			{
				return default(bool);
			}

			// Token: 0x060108C3 RID: 67779 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108C3")]
			[Address(RVA = "0x840AA0", Offset = "0x83F6A0", VA = "0x180840AA0")]
			private void <>xLuaBaseProxy_PreprocessLevelData(LevelData P0)
			{
			}

			// Token: 0x060108C4 RID: 67780 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108C4")]
			[Address(RVA = "0x858C80", Offset = "0x857880", VA = "0x180858C80")]
			private void <>xLuaBaseProxy_OnApplyingGlobalModifier(ref Modifier P0)
			{
			}

			// Token: 0x060108C5 RID: 67781 RVA: 0x00065010 File Offset: 0x00063210
			[Token(Token = "0x60108C5")]
			[Address(RVA = "0x858CB0", Offset = "0x8578B0", VA = "0x180858CB0")]
			private bool <>xLuaBaseProxy_OnEntityApplyModifier(Entity P0, ref Modifier P1)
			{
				return default(bool);
			}

			// Token: 0x060108C6 RID: 67782 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108C6")]
			[Address(RVA = "0x858CA0", Offset = "0x8578A0", VA = "0x180858CA0")]
			private void <>xLuaBaseProxy_OnEnemyReachExit(Enemy P0, Tile P1)
			{
			}

			// Token: 0x060108C7 RID: 67783 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108C7")]
			[Address(RVA = "0x858C90", Offset = "0x857890", VA = "0x180858C90")]
			private void <>xLuaBaseProxy_OnCharacterFinished(Character P0, Entity.FinishReason P1)
			{
			}

			// Token: 0x060108C8 RID: 67784 RVA: 0x00065028 File Offset: 0x00063228
			[Token(Token = "0x60108C8")]
			[Address(RVA = "0x840A30", Offset = "0x83F630", VA = "0x180840A30")]
			private bool <>xLuaBaseProxy_GameNotFinishCondition()
			{
				return default(bool);
			}

			// Token: 0x060108C9 RID: 67785 RVA: 0x00065040 File Offset: 0x00063240
			[Token(Token = "0x60108C9")]
			[Address(RVA = "0x858C40", Offset = "0x857840", VA = "0x180858C40")]
			private PlayerBattleRank <>xLuaBaseProxy_GetBattleCompleteRank()
			{
				return (PlayerBattleRank)0;
			}

			// Token: 0x060108CA RID: 67786 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60108CA")]
			[Address(RVA = "0x858C30", Offset = "0x857830", VA = "0x180858C30")]
			private object <>xLuaBaseProxy_GetActMeta()
			{
				return null;
			}

			// Token: 0x060108CB RID: 67787 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108CB")]
			[Address(RVA = "0x858CC0", Offset = "0x8578C0", VA = "0x180858CC0")]
			private void <>xLuaBaseProxy_SortDeck(Deck.Card[] P0)
			{
			}

			// Token: 0x040128F7 RID: 76023
			[Token(Token = "0x40128F7")]
			public const string ACT7FUN_TARGET_TRAP_ID = "trap_308_izcamp";

			// Token: 0x040128F8 RID: 76024
			[Token(Token = "0x40128F8")]
			public const string ACT7FUN_ID_SPECIAL_BUFF = "act7fun_special_card_buff";

			// Token: 0x040128F9 RID: 76025
			[Token(Token = "0x40128F9")]
			public const string ACT7FUN_BATTLE_UI_PLUGIN_PATH = "UI/Activity/Actfun/ActFun7/Battle/act7fun_battle_ui_plugin.prefab";

			// Token: 0x040128FA RID: 76026
			[Token(Token = "0x40128FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_enemyUseCnt;

			// Token: 0x040128FB RID: 76027
			[Token(Token = "0x40128FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int m_characterKill;

			// Token: 0x040128FC RID: 76028
			[Token(Token = "0x40128FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<string> easterEggIds;

			// Token: 0x04012901 RID: 76033
			[Token(Token = "0x4012901")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_maxTrapCnt;

			// Token: 0x04012902 RID: 76034
			[Token(Token = "0x4012902")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_maxTrapCnt;

			// Token: 0x04012903 RID: 76035
			[Token(Token = "0x4012903")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_passTrapCnt;

			// Token: 0x04012904 RID: 76036
			[Token(Token = "0x4012904")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_passTrapCnt;

			// Token: 0x04012905 RID: 76037
			[Token(Token = "0x4012905")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_curTrapCnt;

			// Token: 0x04012906 RID: 76038
			[Token(Token = "0x4012906")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_curTrapCnt;

			// Token: 0x04012907 RID: 76039
			[Token(Token = "0x4012907")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_stageAdditionData;

			// Token: 0x04012908 RID: 76040
			[Token(Token = "0x4012908")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_set_stageAdditionData;

			// Token: 0x04012909 RID: 76041
			[Token(Token = "0x4012909")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_gameModeType;

			// Token: 0x0401290A RID: 76042
			[Token(Token = "0x401290A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401290B RID: 76043
			[Token(Token = "0x401290B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0401290C RID: 76044
			[Token(Token = "0x401290C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_Tick;

			// Token: 0x0401290D RID: 76045
			[Token(Token = "0x401290D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_HookPlayerOp_Withdraw;

			// Token: 0x0401290E RID: 76046
			[Token(Token = "0x401290E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_HookPlayerOp_TrigSkill;

			// Token: 0x0401290F RID: 76047
			[Token(Token = "0x401290F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_HookPlayerOp_Spawn;

			// Token: 0x04012910 RID: 76048
			[Token(Token = "0x4012910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_PreprocessLevelData;

			// Token: 0x04012911 RID: 76049
			[Token(Token = "0x4012911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_OnApplyingGlobalModifier;

			// Token: 0x04012912 RID: 76050
			[Token(Token = "0x4012912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_OnEntityApplyModifier;

			// Token: 0x04012913 RID: 76051
			[Token(Token = "0x4012913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_OnEnemyReachExit;

			// Token: 0x04012914 RID: 76052
			[Token(Token = "0x4012914")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_OnCharacterFinished;

			// Token: 0x04012915 RID: 76053
			[Token(Token = "0x4012915")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_GameNotFinishCondition;

			// Token: 0x04012916 RID: 76054
			[Token(Token = "0x4012916")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_GetBattleCompleteRank;

			// Token: 0x04012917 RID: 76055
			[Token(Token = "0x4012917")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_GetActMeta;

			// Token: 0x04012918 RID: 76056
			[Token(Token = "0x4012918")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_SortDeck;

			// Token: 0x04012919 RID: 76057
			[Token(Token = "0x4012919")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_AddTrapCnt;

			// Token: 0x0401291A RID: 76058
			[Token(Token = "0x401291A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_AddEasterEggId;
		}

		// Token: 0x02002793 RID: 10131
		[Token(Token = "0x2002793")]
		public class AutoChessGameMode : GameModeFactory.DefaultGameMode
		{
			// Token: 0x060108CF RID: 67791 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108CF")]
			[Address(RVA = "0x85BF50", Offset = "0x85AB50", VA = "0x18085BF50")]
			public AutoChessGameMode(ref GameModeMeta meta)
			{
			}

			// Token: 0x1700242E RID: 9262
			// (get) Token: 0x060108D0 RID: 67792 RVA: 0x00065070 File Offset: 0x00063270
			[Token(Token = "0x1700242E")]
			public override GameModeMeta.GameModeType gameModeType
			{
				[Token(Token = "0x60108D0")]
				[Address(RVA = "0x85C210", Offset = "0x85AE10", VA = "0x18085C210", Slot = "119")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x1700242F RID: 9263
			// (get) Token: 0x060108D1 RID: 67793 RVA: 0x00065088 File Offset: 0x00063288
			[Token(Token = "0x1700242F")]
			public override bool allowPoolManagerUnload
			{
				[Token(Token = "0x60108D1")]
				[Address(RVA = "0x85C050", Offset = "0x85AC50", VA = "0x18085C050", Slot = "121")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002430 RID: 9264
			// (get) Token: 0x060108D2 RID: 67794 RVA: 0x000650A0 File Offset: 0x000632A0
			[Token(Token = "0x17002430")]
			public override bool isLargeMap
			{
				[Token(Token = "0x60108D2")]
				[Address(RVA = "0x85C2F0", Offset = "0x85AEF0", VA = "0x18085C2F0", Slot = "105")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002431 RID: 9265
			// (get) Token: 0x060108D3 RID: 67795 RVA: 0x000650B8 File Offset: 0x000632B8
			[Token(Token = "0x17002431")]
			public override bool isLowMemoryGameMode
			{
				[Token(Token = "0x60108D3")]
				[Address(RVA = "0x85C360", Offset = "0x85AF60", VA = "0x18085C360", Slot = "110")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002432 RID: 9266
			// (get) Token: 0x060108D4 RID: 67796 RVA: 0x000650D0 File Offset: 0x000632D0
			[Token(Token = "0x17002432")]
			public override BattleOutlineConfig outlineConfig
			{
				[Token(Token = "0x60108D4")]
				[Address(RVA = "0x85C440", Offset = "0x85B040", VA = "0x18085C440", Slot = "111")]
				get
				{
					return default(BattleOutlineConfig);
				}
			}

			// Token: 0x17002433 RID: 9267
			// (get) Token: 0x060108D5 RID: 67797 RVA: 0x000650E8 File Offset: 0x000632E8
			[Token(Token = "0x17002433")]
			public override bool hasExtraBuildCondition
			{
				[Token(Token = "0x60108D5")]
				[Address(RVA = "0x85C280", Offset = "0x85AE80", VA = "0x18085C280", Slot = "106")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002434 RID: 9268
			// (get) Token: 0x060108D6 RID: 67798 RVA: 0x00065100 File Offset: 0x00063300
			[Token(Token = "0x17002434")]
			public override bool useLevelBgm
			{
				[Token(Token = "0x60108D6")]
				[Address(RVA = "0x85C4F0", Offset = "0x85B0F0", VA = "0x18085C4F0", Slot = "109")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002435 RID: 9269
			// (get) Token: 0x060108D7 RID: 67799 RVA: 0x00065118 File Offset: 0x00063318
			[Token(Token = "0x17002435")]
			public override bool doDefaultSchedule
			{
				[Token(Token = "0x60108D7")]
				[Address(RVA = "0x85C0C0", Offset = "0x85ACC0", VA = "0x18085C0C0", Slot = "108")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002436 RID: 9270
			// (get) Token: 0x060108D8 RID: 67800 RVA: 0x00065130 File Offset: 0x00063330
			[Token(Token = "0x17002436")]
			public override bool isSupportSlowMotion
			{
				[Token(Token = "0x60108D8")]
				[Address(RVA = "0x85C3D0", Offset = "0x85AFD0", VA = "0x18085C3D0", Slot = "107")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002437 RID: 9271
			// (get) Token: 0x060108D9 RID: 67801 RVA: 0x00065148 File Offset: 0x00063348
			[Token(Token = "0x17002437")]
			public override bool allowManualTick
			{
				[Token(Token = "0x60108D9")]
				[Address(RVA = "0x85BFE0", Offset = "0x85ABE0", VA = "0x18085BFE0", Slot = "103")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002438 RID: 9272
			// (get) Token: 0x060108DA RID: 67802 RVA: 0x00065160 File Offset: 0x00063360
			[Token(Token = "0x17002438")]
			public override bool enablePause
			{
				[Token(Token = "0x60108DA")]
				[Address(RVA = "0x85C1A0", Offset = "0x85ADA0", VA = "0x18085C1A0", Slot = "118")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002439 RID: 9273
			// (get) Token: 0x060108DB RID: 67803 RVA: 0x00065178 File Offset: 0x00063378
			[Token(Token = "0x17002439")]
			public override bool enableParticleEffectManager
			{
				[Token(Token = "0x60108DB")]
				[Address(RVA = "0x85C130", Offset = "0x85AD30", VA = "0x18085C130", Slot = "112")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060108DC RID: 67804 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108DC")]
			[Address(RVA = "0x859750", Offset = "0x858350", VA = "0x180859750", Slot = "182")]
			public override void FinishGame(Action<BattleController.GameResult, bool> gameFinishCallback, BattleController.GameResult result, bool silent = false)
			{
			}

			// Token: 0x060108DD RID: 67805 RVA: 0x00065190 File Offset: 0x00063390
			[Token(Token = "0x60108DD")]
			[Address(RVA = "0x859AA0", Offset = "0x8586A0", VA = "0x180859AA0", Slot = "128")]
			public override float GetCompleteProgress()
			{
				return 0f;
			}

			// Token: 0x060108DE RID: 67806 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108DE")]
			[Address(RVA = "0x85A7D0", Offset = "0x8593D0", VA = "0x18085A7D0", Slot = "126")]
			public override void Tick(Action doDefaultTick)
			{
			}

			// Token: 0x060108DF RID: 67807 RVA: 0x000651A8 File Offset: 0x000633A8
			[Token(Token = "0x60108DF")]
			[Address(RVA = "0x859150", Offset = "0x857D50", VA = "0x180859150", Slot = "152")]
			public override bool CheckBuildable(BuildCondition buildCondition, Tile tile, SharedConsts.Direction direction, bool spawnManually, bool overflowOccupiedCnt, BattleCharacterData sourceData, PlayerSide operationSide = PlayerSide.DEFAULT)
			{
				return default(bool);
			}

			// Token: 0x060108E0 RID: 67808 RVA: 0x000651C0 File Offset: 0x000633C0
			[Token(Token = "0x60108E0")]
			[Address(RVA = "0x85B000", Offset = "0x859C00", VA = "0x18085B000")]
			private bool _CheckBuildableInPrepare(BuildCondition buildCondition, Tile tile, SharedConsts.Direction direction, bool spawnManually, bool overflowOccupiedCnt, BattleCharacterData sourceData)
			{
				return default(bool);
			}

			// Token: 0x060108E1 RID: 67809 RVA: 0x000651D8 File Offset: 0x000633D8
			[Token(Token = "0x60108E1")]
			[Address(RVA = "0x85ACE0", Offset = "0x8598E0", VA = "0x18085ACE0")]
			private bool _CheckBuildableInBattle(BuildCondition buildCondition, Tile tile, SharedConsts.Direction direction, bool spawnManually, bool overflowOccupiedCnt, BattleCharacterData sourceData)
			{
				return default(bool);
			}

			// Token: 0x060108E2 RID: 67810 RVA: 0x000651F0 File Offset: 0x000633F0
			[Token(Token = "0x60108E2")]
			[Address(RVA = "0x859D80", Offset = "0x858980", VA = "0x180859D80", Slot = "154")]
			public override bool IsSkillClickable()
			{
				return default(bool);
			}

			// Token: 0x060108E3 RID: 67811 RVA: 0x00065208 File Offset: 0x00063408
			[Token(Token = "0x60108E3")]
			[Address(RVA = "0x859B40", Offset = "0x858740", VA = "0x180859B40", Slot = "175")]
			public override bool HookEnemyReachedExitAudio(Enemy enemy)
			{
				return default(bool);
			}

			// Token: 0x060108E4 RID: 67812 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108E4")]
			[Address(RVA = "0x85A0E0", Offset = "0x858CE0", VA = "0x18085A0E0", Slot = "123")]
			public override void OnPostInit()
			{
			}

			// Token: 0x060108E5 RID: 67813 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108E5")]
			[Address(RVA = "0x85A680", Offset = "0x859280", VA = "0x18085A680", Slot = "124")]
			public override void StartGame(Action doDefaultStart)
			{
			}

			// Token: 0x060108E6 RID: 67814 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108E6")]
			[Address(RVA = "0x85B350", Offset = "0x859F50", VA = "0x18085B350")]
			private void _RegisterBattleTasks()
			{
			}

			// Token: 0x060108E7 RID: 67815 RVA: 0x00065220 File Offset: 0x00063420
			[Token(Token = "0x60108E7")]
			[Address(RVA = "0x859830", Offset = "0x858430", VA = "0x180859830", Slot = "151")]
			public override bool GameNotFinishCondition()
			{
				return default(bool);
			}

			// Token: 0x060108E8 RID: 67816 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60108E8")]
			[Address(RVA = "0x8598D0", Offset = "0x8584D0", VA = "0x1808598D0", Slot = "183")]
			public override object GetActMeta()
			{
				return null;
			}

			// Token: 0x060108E9 RID: 67817 RVA: 0x00065238 File Offset: 0x00063438
			[Token(Token = "0x60108E9")]
			[Address(RVA = "0x8599F0", Offset = "0x8585F0", VA = "0x1808599F0", Slot = "184")]
			public override PlayerBattleRank GetBattleCompleteRank()
			{
				return (PlayerBattleRank)0;
			}

			// Token: 0x060108EA RID: 67818 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108EA")]
			[Address(RVA = "0x85A5C0", Offset = "0x8591C0", VA = "0x18085A5C0", Slot = "136")]
			public override void PreprocessLevelData(LevelData levelData)
			{
			}

			// Token: 0x060108EB RID: 67819 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108EB")]
			[Address(RVA = "0x85A500", Offset = "0x859100", VA = "0x18085A500", Slot = "147")]
			public override void PreprocessEnemy(LevelData.EnemyData data)
			{
			}

			// Token: 0x060108EC RID: 67820 RVA: 0x00065250 File Offset: 0x00063450
			[Token(Token = "0x60108EC")]
			[Address(RVA = "0x8595F0", Offset = "0x8581F0", VA = "0x1808595F0", Slot = "176")]
			public override bool EnableGlobalBuffExtraData(GlobalBuff buff, LevelData.GlobalBuffData data)
			{
				return default(bool);
			}

			// Token: 0x060108ED RID: 67821 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108ED")]
			[Address(RVA = "0x859500", Offset = "0x858100", VA = "0x180859500", Slot = "190")]
			public override void DestroyEntity(Entity entity, Entity.FinishReason reason)
			{
			}

			// Token: 0x060108EE RID: 67822 RVA: 0x00065268 File Offset: 0x00063468
			[Token(Token = "0x60108EE")]
			[Address(RVA = "0x859F90", Offset = "0x858B90", VA = "0x180859F90", Slot = "189")]
			public override bool OnEntityApplyModifier(Entity entity, ref Modifier modifier)
			{
				return default(bool);
			}

			// Token: 0x060108EF RID: 67823 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108EF")]
			[Address(RVA = "0x859DF0", Offset = "0x8589F0", VA = "0x180859DF0", Slot = "164")]
			public override void OnEnemyFinished(Enemy enemy, Entity.FinishReason reason)
			{
			}

			// Token: 0x060108F0 RID: 67824 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108F0")]
			[Address(RVA = "0x859EC0", Offset = "0x858AC0", VA = "0x180859EC0", Slot = "192")]
			public override void OnEnemyReachExit(Enemy enemy, Tile cacheTile)
			{
			}

			// Token: 0x060108F1 RID: 67825 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108F1")]
			[Address(RVA = "0x85A3A0", Offset = "0x858FA0", VA = "0x18085A3A0", Slot = "161")]
			public override void OnUnitRegistered(Unit unit)
			{
			}

			// Token: 0x060108F2 RID: 67826 RVA: 0x00065280 File Offset: 0x00063480
			[Token(Token = "0x60108F2")]
			[Address(RVA = "0x859CD0", Offset = "0x8588D0", VA = "0x180859CD0", Slot = "159")]
			public override SpeedLevel HookSpeedLevel(SpeedLevel originSpeedLevel)
			{
				return SpeedLevel.SLOW_MOTION;
			}

			// Token: 0x060108F3 RID: 67827 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60108F3")]
			[Address(RVA = "0x85A060", Offset = "0x858C60", VA = "0x18085A060", Slot = "191")]
			public override void OnPlayerLifeToZero(PlayerSide side)
			{
			}

			// Token: 0x060108F4 RID: 67828 RVA: 0x00065298 File Offset: 0x00063498
			[Token(Token = "0x60108F4")]
			[Address(RVA = "0x85A9B0", Offset = "0x8595B0", VA = "0x18085A9B0", Slot = "194")]
			public override bool TrySetTileHighlightType(Tile tile, bool isBuildable, BattleCharacterData sourceData)
			{
				return default(bool);
			}

			// Token: 0x060108F5 RID: 67829 RVA: 0x000652B0 File Offset: 0x000634B0
			[Token(Token = "0x60108F5")]
			[Address(RVA = "0x85A890", Offset = "0x859490", VA = "0x18085A890", Slot = "195")]
			public override bool TryGetCustomTileHighlightColor(out Color customColor, out Color emissionColor)
			{
				return default(bool);
			}

			// Token: 0x060108F6 RID: 67830 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60108F6")]
			[Address(RVA = "0x859690", Offset = "0x858290", VA = "0x180859690", Slot = "198")]
			public override HashSet<GridPosition> FetchValidMapGrids()
			{
				return null;
			}

			// Token: 0x060108F7 RID: 67831 RVA: 0x000652C8 File Offset: 0x000634C8
			[Token(Token = "0x60108F7")]
			[Address(RVA = "0x859420", Offset = "0x858020", VA = "0x180859420", Slot = "180")]
			public override bool CheckRenderInvisible(Entity entity, BattleRenderInvisibleMask mask)
			{
				return default(bool);
			}

			// Token: 0x060108F9 RID: 67833 RVA: 0x000652E0 File Offset: 0x000634E0
			[Token(Token = "0x60108F9")]
			[Address(RVA = "0x83EAA0", Offset = "0x83D6A0", VA = "0x18083EAA0")]
			private GameModeMeta.GameModeType <>xLuaBaseProxy_get_gameModeType()
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}

			// Token: 0x060108FA RID: 67834 RVA: 0x000652F8 File Offset: 0x000634F8
			[Token(Token = "0x60108FA")]
			[Address(RVA = "0x85AC20", Offset = "0x859820", VA = "0x18085AC20")]
			private bool <>xLuaBaseProxy_get_allowPoolManagerUnload()
			{
				return default(bool);
			}

			// Token: 0x060108FB RID: 67835 RVA: 0x00065310 File Offset: 0x00063510
			[Token(Token = "0x60108FB")]
			[Address(RVA = "0x85AC70", Offset = "0x859870", VA = "0x18085AC70")]
			private bool <>xLuaBaseProxy_get_isLargeMap()
			{
				return default(bool);
			}

			// Token: 0x060108FC RID: 67836 RVA: 0x00065328 File Offset: 0x00063528
			[Token(Token = "0x60108FC")]
			[Address(RVA = "0x85AC80", Offset = "0x859880", VA = "0x18085AC80")]
			private bool <>xLuaBaseProxy_get_isLowMemoryGameMode()
			{
				return default(bool);
			}

			// Token: 0x060108FD RID: 67837 RVA: 0x00065340 File Offset: 0x00063540
			[Token(Token = "0x60108FD")]
			[Address(RVA = "0x85ACA0", Offset = "0x8598A0", VA = "0x18085ACA0")]
			private BattleOutlineConfig <>xLuaBaseProxy_get_outlineConfig()
			{
				return default(BattleOutlineConfig);
			}

			// Token: 0x060108FE RID: 67838 RVA: 0x00065358 File Offset: 0x00063558
			[Token(Token = "0x60108FE")]
			[Address(RVA = "0x85AC60", Offset = "0x859860", VA = "0x18085AC60")]
			private bool <>xLuaBaseProxy_get_hasExtraBuildCondition()
			{
				return default(bool);
			}

			// Token: 0x060108FF RID: 67839 RVA: 0x00065370 File Offset: 0x00063570
			[Token(Token = "0x60108FF")]
			[Address(RVA = "0x85ACD0", Offset = "0x8598D0", VA = "0x18085ACD0")]
			private bool <>xLuaBaseProxy_get_useLevelBgm()
			{
				return default(bool);
			}

			// Token: 0x06010900 RID: 67840 RVA: 0x00065388 File Offset: 0x00063588
			[Token(Token = "0x6010900")]
			[Address(RVA = "0x85AC30", Offset = "0x859830", VA = "0x18085AC30")]
			private bool <>xLuaBaseProxy_get_doDefaultSchedule()
			{
				return default(bool);
			}

			// Token: 0x06010901 RID: 67841 RVA: 0x000653A0 File Offset: 0x000635A0
			[Token(Token = "0x6010901")]
			[Address(RVA = "0x85AC90", Offset = "0x859890", VA = "0x18085AC90")]
			private bool <>xLuaBaseProxy_get_isSupportSlowMotion()
			{
				return default(bool);
			}

			// Token: 0x06010902 RID: 67842 RVA: 0x000653B8 File Offset: 0x000635B8
			[Token(Token = "0x6010902")]
			[Address(RVA = "0x85AC10", Offset = "0x859810", VA = "0x18085AC10")]
			private bool <>xLuaBaseProxy_get_allowManualTick()
			{
				return default(bool);
			}

			// Token: 0x06010903 RID: 67843 RVA: 0x000653D0 File Offset: 0x000635D0
			[Token(Token = "0x6010903")]
			[Address(RVA = "0x85AC50", Offset = "0x859850", VA = "0x18085AC50")]
			private bool <>xLuaBaseProxy_get_enablePause()
			{
				return default(bool);
			}

			// Token: 0x06010904 RID: 67844 RVA: 0x000653E8 File Offset: 0x000635E8
			[Token(Token = "0x6010904")]
			[Address(RVA = "0x85AC40", Offset = "0x859840", VA = "0x18085AC40")]
			private bool <>xLuaBaseProxy_get_enableParticleEffectManager()
			{
				return default(bool);
			}

			// Token: 0x06010905 RID: 67845 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010905")]
			[Address(RVA = "0x85AB90", Offset = "0x859790", VA = "0x18085AB90")]
			private void <>xLuaBaseProxy_FinishGame(Action<BattleController.GameResult, bool> P0, BattleController.GameResult P1, bool P2)
			{
			}

			// Token: 0x06010906 RID: 67846 RVA: 0x00065400 File Offset: 0x00063600
			[Token(Token = "0x6010906")]
			[Address(RVA = "0x85ABA0", Offset = "0x8597A0", VA = "0x18085ABA0")]
			private float <>xLuaBaseProxy_GetCompleteProgress()
			{
				return 0f;
			}

			// Token: 0x06010907 RID: 67847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010907")]
			[Address(RVA = "0x83EA90", Offset = "0x83D690", VA = "0x18083EA90")]
			private void <>xLuaBaseProxy_Tick(Action P0)
			{
			}

			// Token: 0x06010908 RID: 67848 RVA: 0x00065418 File Offset: 0x00063618
			[Token(Token = "0x6010908")]
			[Address(RVA = "0x85AAD0", Offset = "0x8596D0", VA = "0x18085AAD0")]
			private bool <>xLuaBaseProxy_CheckBuildable(BuildCondition P0, Tile P1, SharedConsts.Direction P2, bool P3, bool P4, BattleCharacterData P5, PlayerSide P6)
			{
				return default(bool);
			}

			// Token: 0x06010909 RID: 67849 RVA: 0x00065430 File Offset: 0x00063630
			[Token(Token = "0x6010909")]
			[Address(RVA = "0x85ABC0", Offset = "0x8597C0", VA = "0x18085ABC0")]
			private bool <>xLuaBaseProxy_IsSkillClickable()
			{
				return default(bool);
			}

			// Token: 0x0601090A RID: 67850 RVA: 0x00065448 File Offset: 0x00063648
			[Token(Token = "0x601090A")]
			[Address(RVA = "0x840A40", Offset = "0x83F640", VA = "0x180840A40")]
			private bool <>xLuaBaseProxy_HookEnemyReachedExitAudio(Enemy P0)
			{
				return default(bool);
			}

			// Token: 0x0601090B RID: 67851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601090B")]
			[Address(RVA = "0x85ABD0", Offset = "0x8597D0", VA = "0x18085ABD0")]
			private void <>xLuaBaseProxy_OnPostInit()
			{
			}

			// Token: 0x0601090C RID: 67852 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601090C")]
			[Address(RVA = "0x840AB0", Offset = "0x83F6B0", VA = "0x180840AB0")]
			private void <>xLuaBaseProxy_StartGame(Action P0)
			{
			}

			// Token: 0x0601090D RID: 67853 RVA: 0x00065460 File Offset: 0x00063660
			[Token(Token = "0x601090D")]
			[Address(RVA = "0x840A30", Offset = "0x83F630", VA = "0x180840A30")]
			private bool <>xLuaBaseProxy_GameNotFinishCondition()
			{
				return default(bool);
			}

			// Token: 0x0601090E RID: 67854 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601090E")]
			[Address(RVA = "0x858C30", Offset = "0x857830", VA = "0x180858C30")]
			private object <>xLuaBaseProxy_GetActMeta()
			{
				return null;
			}

			// Token: 0x0601090F RID: 67855 RVA: 0x00065478 File Offset: 0x00063678
			[Token(Token = "0x601090F")]
			[Address(RVA = "0x858C40", Offset = "0x857840", VA = "0x180858C40")]
			private PlayerBattleRank <>xLuaBaseProxy_GetBattleCompleteRank()
			{
				return (PlayerBattleRank)0;
			}

			// Token: 0x06010910 RID: 67856 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010910")]
			[Address(RVA = "0x840AA0", Offset = "0x83F6A0", VA = "0x180840AA0")]
			private void <>xLuaBaseProxy_PreprocessLevelData(LevelData P0)
			{
			}

			// Token: 0x06010911 RID: 67857 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010911")]
			[Address(RVA = "0x85ABE0", Offset = "0x8597E0", VA = "0x18085ABE0")]
			private void <>xLuaBaseProxy_PreprocessEnemy(LevelData.EnemyData P0)
			{
			}

			// Token: 0x06010912 RID: 67858 RVA: 0x00065490 File Offset: 0x00063690
			[Token(Token = "0x6010912")]
			[Address(RVA = "0x85AB70", Offset = "0x859770", VA = "0x18085AB70")]
			private bool <>xLuaBaseProxy_EnableGlobalBuffExtraData(GlobalBuff P0, LevelData.GlobalBuffData P1)
			{
				return default(bool);
			}

			// Token: 0x06010913 RID: 67859 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010913")]
			[Address(RVA = "0x85AB60", Offset = "0x859760", VA = "0x18085AB60")]
			private void <>xLuaBaseProxy_DestroyEntity(Entity P0, Entity.FinishReason P1)
			{
			}

			// Token: 0x06010914 RID: 67860 RVA: 0x000654A8 File Offset: 0x000636A8
			[Token(Token = "0x6010914")]
			[Address(RVA = "0x858CB0", Offset = "0x8578B0", VA = "0x180858CB0")]
			private bool <>xLuaBaseProxy_OnEntityApplyModifier(Entity P0, ref Modifier P1)
			{
				return default(bool);
			}

			// Token: 0x06010915 RID: 67861 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010915")]
			[Address(RVA = "0x840A70", Offset = "0x83F670", VA = "0x180840A70")]
			private void <>xLuaBaseProxy_OnEnemyFinished(Enemy P0, Entity.FinishReason P1)
			{
			}

			// Token: 0x06010916 RID: 67862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010916")]
			[Address(RVA = "0x858CA0", Offset = "0x8578A0", VA = "0x180858CA0")]
			private void <>xLuaBaseProxy_OnEnemyReachExit(Enemy P0, Tile P1)
			{
			}

			// Token: 0x06010917 RID: 67863 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010917")]
			[Address(RVA = "0x840A90", Offset = "0x83F690", VA = "0x180840A90")]
			private void <>xLuaBaseProxy_OnUnitRegistered(Unit P0)
			{
			}

			// Token: 0x06010918 RID: 67864 RVA: 0x000654C0 File Offset: 0x000636C0
			[Token(Token = "0x6010918")]
			[Address(RVA = "0x85ABB0", Offset = "0x8597B0", VA = "0x18085ABB0")]
			private SpeedLevel <>xLuaBaseProxy_HookSpeedLevel(SpeedLevel P0)
			{
				return SpeedLevel.SLOW_MOTION;
			}

			// Token: 0x06010919 RID: 67865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010919")]
			[Address(RVA = "0x840A80", Offset = "0x83F680", VA = "0x180840A80")]
			private void <>xLuaBaseProxy_OnPlayerLifeToZero(PlayerSide P0)
			{
			}

			// Token: 0x0601091A RID: 67866 RVA: 0x000654D8 File Offset: 0x000636D8
			[Token(Token = "0x601091A")]
			[Address(RVA = "0x85AC00", Offset = "0x859800", VA = "0x18085AC00")]
			private bool <>xLuaBaseProxy_TrySetTileHighlightType(Tile P0, bool P1, BattleCharacterData P2)
			{
				return default(bool);
			}

			// Token: 0x0601091B RID: 67867 RVA: 0x000654F0 File Offset: 0x000636F0
			[Token(Token = "0x601091B")]
			[Address(RVA = "0x85ABF0", Offset = "0x8597F0", VA = "0x18085ABF0")]
			private bool <>xLuaBaseProxy_TryGetCustomTileHighlightColor(out Color P0, out Color P1)
			{
				return default(bool);
			}

			// Token: 0x0601091C RID: 67868 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601091C")]
			[Address(RVA = "0x85AB80", Offset = "0x859780", VA = "0x18085AB80")]
			private HashSet<GridPosition> <>xLuaBaseProxy_FetchValidMapGrids()
			{
				return null;
			}

			// Token: 0x0601091D RID: 67869 RVA: 0x00065508 File Offset: 0x00063708
			[Token(Token = "0x601091D")]
			[Address(RVA = "0x85AB50", Offset = "0x859750", VA = "0x18085AB50")]
			private bool <>xLuaBaseProxy_CheckRenderInvisible(Entity P0, BattleRenderInvisibleMask P1)
			{
				return default(bool);
			}

			// Token: 0x0401291D RID: 76061
			[Token(Token = "0x401291D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly BattleOutlineConfig OUTLINE_CONFIG;

			// Token: 0x0401291E RID: 76062
			[Token(Token = "0x401291E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static string AUTOCHESS_VALID_HANDTILE_CUSTOM_HIGHLIGHT;

			// Token: 0x0401291F RID: 76063
			[Token(Token = "0x401291F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static string AUTOCHESS_VALID_HANDTILE_CUSTOM_EMISSION;

			// Token: 0x04012920 RID: 76064
			[Token(Token = "0x4012920")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04012921 RID: 76065
			[Token(Token = "0x4012921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_gameModeType;

			// Token: 0x04012922 RID: 76066
			[Token(Token = "0x4012922")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_allowPoolManagerUnload;

			// Token: 0x04012923 RID: 76067
			[Token(Token = "0x4012923")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_isLargeMap;

			// Token: 0x04012924 RID: 76068
			[Token(Token = "0x4012924")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_isLowMemoryGameMode;

			// Token: 0x04012925 RID: 76069
			[Token(Token = "0x4012925")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_outlineConfig;

			// Token: 0x04012926 RID: 76070
			[Token(Token = "0x4012926")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_hasExtraBuildCondition;

			// Token: 0x04012927 RID: 76071
			[Token(Token = "0x4012927")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_useLevelBgm;

			// Token: 0x04012928 RID: 76072
			[Token(Token = "0x4012928")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_doDefaultSchedule;

			// Token: 0x04012929 RID: 76073
			[Token(Token = "0x4012929")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_isSupportSlowMotion;

			// Token: 0x0401292A RID: 76074
			[Token(Token = "0x401292A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_get_allowManualTick;

			// Token: 0x0401292B RID: 76075
			[Token(Token = "0x401292B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_get_enablePause;

			// Token: 0x0401292C RID: 76076
			[Token(Token = "0x401292C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_get_enableParticleEffectManager;

			// Token: 0x0401292D RID: 76077
			[Token(Token = "0x401292D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_FinishGame;

			// Token: 0x0401292E RID: 76078
			[Token(Token = "0x401292E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_GetCompleteProgress;

			// Token: 0x0401292F RID: 76079
			[Token(Token = "0x401292F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_Tick;

			// Token: 0x04012930 RID: 76080
			[Token(Token = "0x4012930")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_CheckBuildable;

			// Token: 0x04012931 RID: 76081
			[Token(Token = "0x4012931")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0__CheckBuildableInPrepare;

			// Token: 0x04012932 RID: 76082
			[Token(Token = "0x4012932")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0__CheckBuildableInBattle;

			// Token: 0x04012933 RID: 76083
			[Token(Token = "0x4012933")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_IsSkillClickable;

			// Token: 0x04012934 RID: 76084
			[Token(Token = "0x4012934")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_HookEnemyReachedExitAudio;

			// Token: 0x04012935 RID: 76085
			[Token(Token = "0x4012935")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0_OnPostInit;

			// Token: 0x04012936 RID: 76086
			[Token(Token = "0x4012936")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0_StartGame;

			// Token: 0x04012937 RID: 76087
			[Token(Token = "0x4012937")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0__RegisterBattleTasks;

			// Token: 0x04012938 RID: 76088
			[Token(Token = "0x4012938")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0_GameNotFinishCondition;

			// Token: 0x04012939 RID: 76089
			[Token(Token = "0x4012939")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private static DelegateBridge __Hotfix0_GetActMeta;

			// Token: 0x0401293A RID: 76090
			[Token(Token = "0x401293A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private static DelegateBridge __Hotfix0_GetBattleCompleteRank;

			// Token: 0x0401293B RID: 76091
			[Token(Token = "0x401293B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			private static DelegateBridge __Hotfix0_PreprocessLevelData;

			// Token: 0x0401293C RID: 76092
			[Token(Token = "0x401293C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private static DelegateBridge __Hotfix0_PreprocessEnemy;

			// Token: 0x0401293D RID: 76093
			[Token(Token = "0x401293D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private static DelegateBridge __Hotfix0_EnableGlobalBuffExtraData;

			// Token: 0x0401293E RID: 76094
			[Token(Token = "0x401293E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private static DelegateBridge __Hotfix0_DestroyEntity;

			// Token: 0x0401293F RID: 76095
			[Token(Token = "0x401293F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private static DelegateBridge __Hotfix0_OnEntityApplyModifier;

			// Token: 0x04012940 RID: 76096
			[Token(Token = "0x4012940")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private static DelegateBridge __Hotfix0_OnEnemyFinished;

			// Token: 0x04012941 RID: 76097
			[Token(Token = "0x4012941")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private static DelegateBridge __Hotfix0_OnEnemyReachExit;

			// Token: 0x04012942 RID: 76098
			[Token(Token = "0x4012942")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private static DelegateBridge __Hotfix0_OnUnitRegistered;

			// Token: 0x04012943 RID: 76099
			[Token(Token = "0x4012943")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private static DelegateBridge __Hotfix0_HookSpeedLevel;

			// Token: 0x04012944 RID: 76100
			[Token(Token = "0x4012944")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			private static DelegateBridge __Hotfix0_OnPlayerLifeToZero;

			// Token: 0x04012945 RID: 76101
			[Token(Token = "0x4012945")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			private static DelegateBridge __Hotfix0_TrySetTileHighlightType;

			// Token: 0x04012946 RID: 76102
			[Token(Token = "0x4012946")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			private static DelegateBridge __Hotfix0_TryGetCustomTileHighlightColor;

			// Token: 0x04012947 RID: 76103
			[Token(Token = "0x4012947")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			private static DelegateBridge __Hotfix0_FetchValidMapGrids;

			// Token: 0x04012948 RID: 76104
			[Token(Token = "0x4012948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private static DelegateBridge __Hotfix0_CheckRenderInvisible;

			// Token: 0x02002794 RID: 10132
			[Token(Token = "0x2002794")]
			public class BattlePendingTaskBase : AutoChessTaskManager.IPendingTask, IHotfixable
			{
				// Token: 0x0601091E RID: 67870 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601091E")]
				[Address(RVA = "0x85C810", Offset = "0x85B410", VA = "0x18085C810", Slot = "8")]
				public virtual void OnTaskStart()
				{
				}

				// Token: 0x0601091F RID: 67871 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601091F")]
				[Address(RVA = "0x85CAC0", Offset = "0x85B6C0", VA = "0x18085CAC0", Slot = "9")]
				public virtual void OnTaskFinish(bool isInterrupt)
				{
				}

				// Token: 0x1700243A RID: 9274
				// (get) Token: 0x06010920 RID: 67872 RVA: 0x00065520 File Offset: 0x00063720
				[Token(Token = "0x1700243A")]
				public virtual bool taskFinished
				{
					[Token(Token = "0x6010920")]
					[Address(RVA = "0x85CBE0", Offset = "0x85B7E0", VA = "0x18085CBE0", Slot = "10")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x1700243B RID: 9275
				// (get) Token: 0x06010921 RID: 67873 RVA: 0x00065538 File Offset: 0x00063738
				[Token(Token = "0x1700243B")]
				public virtual float maxTaskTime
				{
					[Token(Token = "0x6010921")]
					[Address(RVA = "0x85CB80", Offset = "0x85B780", VA = "0x18085CB80", Slot = "11")]
					get
					{
						return 0f;
					}
				}

				// Token: 0x06010922 RID: 67874 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010922")]
				[Address(RVA = "0x85CB20", Offset = "0x85B720", VA = "0x18085CB20")]
				public BattlePendingTaskBase()
				{
				}

				// Token: 0x04012949 RID: 76105
				[Token(Token = "0x4012949")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnTaskStart;

				// Token: 0x0401294A RID: 76106
				[Token(Token = "0x401294A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_OnTaskFinish;

				// Token: 0x0401294B RID: 76107
				[Token(Token = "0x401294B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_get_taskFinished;

				// Token: 0x0401294C RID: 76108
				[Token(Token = "0x401294C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_get_maxTaskTime;

				// Token: 0x0401294D RID: 76109
				[Token(Token = "0x401294D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x02002795 RID: 10133
			[Token(Token = "0x2002795")]
			public abstract class GameTaskWithCoroutine : GameModeFactory.AutoChessGameMode.BattlePendingTaskBase
			{
				// Token: 0x1700243C RID: 9276
				// (get) Token: 0x06010923 RID: 67875 RVA: 0x00065550 File Offset: 0x00063750
				[Token(Token = "0x1700243C")]
				public override bool taskFinished
				{
					[Token(Token = "0x6010923")]
					[Address(RVA = "0x86DFB0", Offset = "0x86CBB0", VA = "0x18086DFB0", Slot = "10")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x1700243D RID: 9277
				// (get) Token: 0x06010924 RID: 67876 RVA: 0x00065568 File Offset: 0x00063768
				[Token(Token = "0x1700243D")]
				public override float maxTaskTime
				{
					[Token(Token = "0x6010924")]
					[Address(RVA = "0x86E5A0", Offset = "0x86D1A0", VA = "0x18086E5A0", Slot = "11")]
					get
					{
						return 0f;
					}
				}

				// Token: 0x06010925 RID: 67877
				[Token(Token = "0x6010925")]
				protected abstract IEnumerator CoroutineTask();

				// Token: 0x06010926 RID: 67878 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010926")]
				[Address(RVA = "0x86E440", Offset = "0x86D040", VA = "0x18086E440", Slot = "8")]
				public override void OnTaskStart()
				{
				}

				// Token: 0x06010927 RID: 67879 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010927")]
				[Address(RVA = "0x86E390", Offset = "0x86CF90", VA = "0x18086E390", Slot = "9")]
				public override void OnTaskFinish(bool isInterrupt)
				{
				}

				// Token: 0x06010928 RID: 67880 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010928")]
				[Address(RVA = "0x86E500", Offset = "0x86D100", VA = "0x18086E500")]
				protected GameTaskWithCoroutine()
				{
				}

				// Token: 0x06010929 RID: 67881 RVA: 0x00065580 File Offset: 0x00063780
				[Token(Token = "0x6010929")]
				[Address(RVA = "0x85CBE0", Offset = "0x85B7E0", VA = "0x18085CBE0")]
				private bool <>xLuaBaseProxy_get_taskFinished()
				{
					return default(bool);
				}

				// Token: 0x0601092A RID: 67882 RVA: 0x00065598 File Offset: 0x00063798
				[Token(Token = "0x601092A")]
				[Address(RVA = "0x85CB80", Offset = "0x85B780", VA = "0x18085CB80")]
				private float <>xLuaBaseProxy_get_maxTaskTime()
				{
					return 0f;
				}

				// Token: 0x0601092B RID: 67883 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601092B")]
				[Address(RVA = "0x85C810", Offset = "0x85B410", VA = "0x18085C810")]
				private void <>xLuaBaseProxy_OnTaskStart()
				{
				}

				// Token: 0x0601092C RID: 67884 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601092C")]
				[Address(RVA = "0x85CAC0", Offset = "0x85B6C0", VA = "0x18085CAC0")]
				private void <>xLuaBaseProxy_OnTaskFinish(bool P0)
				{
				}

				// Token: 0x0401294E RID: 76110
				[Token(Token = "0x401294E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				protected IEnumerator m_coroutine;

				// Token: 0x0401294F RID: 76111
				[Token(Token = "0x401294F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				protected bool m_coroutineFinished;

				// Token: 0x04012950 RID: 76112
				[Token(Token = "0x4012950")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_taskFinished;

				// Token: 0x04012951 RID: 76113
				[Token(Token = "0x4012951")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_get_maxTaskTime;

				// Token: 0x04012952 RID: 76114
				[Token(Token = "0x4012952")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_OnTaskStart;

				// Token: 0x04012953 RID: 76115
				[Token(Token = "0x4012953")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_OnTaskFinish;

				// Token: 0x04012954 RID: 76116
				[Token(Token = "0x4012954")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x02002796 RID: 10134
			[Token(Token = "0x2002796")]
			public class PreloadDataInLoading : GameModeFactory.AutoChessGameMode.GameTaskWithCoroutine
			{
				// Token: 0x0601092D RID: 67885 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601092D")]
				[Address(RVA = "0x870900", Offset = "0x86F500", VA = "0x180870900", Slot = "8")]
				public override void OnTaskStart()
				{
				}

				// Token: 0x0601092E RID: 67886 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x601092E")]
				[Address(RVA = "0x870850", Offset = "0x86F450", VA = "0x180870850", Slot = "12")]
				protected override IEnumerator CoroutineTask()
				{
					return null;
				}

				// Token: 0x0601092F RID: 67887 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601092F")]
				[Address(RVA = "0x870990", Offset = "0x86F590", VA = "0x180870990")]
				public PreloadDataInLoading()
				{
				}

				// Token: 0x06010930 RID: 67888 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010930")]
				[Address(RVA = "0x86DFA0", Offset = "0x86CBA0", VA = "0x18086DFA0")]
				private void <>xLuaBaseProxy_OnTaskStart()
				{
				}

				// Token: 0x04012955 RID: 76117
				[Token(Token = "0x4012955")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private List<PoolManager.ObjectConfig> m_chessPoolConfigs;

				// Token: 0x04012956 RID: 76118
				[Token(Token = "0x4012956")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnTaskStart;

				// Token: 0x04012957 RID: 76119
				[Token(Token = "0x4012957")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_CoroutineTask;

				// Token: 0x04012958 RID: 76120
				[Token(Token = "0x4012958")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x02002798 RID: 10136
			[Token(Token = "0x2002798")]
			public class PreloadDataInPrepare : GameModeFactory.AutoChessGameMode.GameTaskWithCoroutine
			{
				// Token: 0x06010938 RID: 67896 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010938")]
				[Address(RVA = "0x870A40", Offset = "0x86F640", VA = "0x180870A40", Slot = "12")]
				protected override IEnumerator CoroutineTask()
				{
					return null;
				}

				// Token: 0x06010939 RID: 67897 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010939")]
				[Address(RVA = "0x870AF0", Offset = "0x86F6F0", VA = "0x180870AF0")]
				private IEnumerator _UnLoadAssets()
				{
					return null;
				}

				// Token: 0x0601093A RID: 67898 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601093A")]
				[Address(RVA = "0x870B80", Offset = "0x86F780", VA = "0x180870B80")]
				public PreloadDataInPrepare()
				{
				}

				// Token: 0x0401295D RID: 76125
				[Token(Token = "0x401295D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_CoroutineTask;

				// Token: 0x0401295E RID: 76126
				[Token(Token = "0x401295E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0__UnLoadAssets;

				// Token: 0x0401295F RID: 76127
				[Token(Token = "0x401295F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x0200279B RID: 10139
			[Token(Token = "0x200279B")]
			public class GameStartInPrepare : GameModeFactory.AutoChessGameMode.GameTaskWithCoroutine
			{
				// Token: 0x17002444 RID: 9284
				// (get) Token: 0x06010947 RID: 67911 RVA: 0x000655F8 File Offset: 0x000637F8
				[Token(Token = "0x17002444")]
				public override bool taskFinished
				{
					[Token(Token = "0x6010947")]
					[Address(RVA = "0x86E2D0", Offset = "0x86CED0", VA = "0x18086E2D0", Slot = "10")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x06010948 RID: 67912 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010948")]
				[Address(RVA = "0x86DF10", Offset = "0x86CB10", VA = "0x18086DF10", Slot = "8")]
				public override void OnTaskStart()
				{
				}

				// Token: 0x06010949 RID: 67913 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010949")]
				[Address(RVA = "0x86DE60", Offset = "0x86CA60", VA = "0x18086DE60", Slot = "12")]
				protected override IEnumerator CoroutineTask()
				{
					return null;
				}

				// Token: 0x0601094A RID: 67914 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601094A")]
				[Address(RVA = "0x86E010", Offset = "0x86CC10", VA = "0x18086E010")]
				private void _CreateDummys()
				{
				}

				// Token: 0x0601094B RID: 67915 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601094B")]
				[Address(RVA = "0x86E270", Offset = "0x86CE70", VA = "0x18086E270")]
				public GameStartInPrepare()
				{
				}

				// Token: 0x0601094C RID: 67916 RVA: 0x00065610 File Offset: 0x00063810
				[Token(Token = "0x601094C")]
				[Address(RVA = "0x86DFB0", Offset = "0x86CBB0", VA = "0x18086DFB0")]
				private bool <>xLuaBaseProxy_get_taskFinished()
				{
					return default(bool);
				}

				// Token: 0x0601094D RID: 67917 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601094D")]
				[Address(RVA = "0x86DFA0", Offset = "0x86CBA0", VA = "0x18086DFA0")]
				private void <>xLuaBaseProxy_OnTaskStart()
				{
				}

				// Token: 0x04012965 RID: 76133
				[Token(Token = "0x4012965")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private AutoChessDummyManager m_dummyManager;

				// Token: 0x04012966 RID: 76134
				[Token(Token = "0x4012966")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_taskFinished;

				// Token: 0x04012967 RID: 76135
				[Token(Token = "0x4012967")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_OnTaskStart;

				// Token: 0x04012968 RID: 76136
				[Token(Token = "0x4012968")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_CoroutineTask;

				// Token: 0x04012969 RID: 76137
				[Token(Token = "0x4012969")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0__CreateDummys;

				// Token: 0x0401296A RID: 76138
				[Token(Token = "0x401296A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x0200279D RID: 10141
			[Token(Token = "0x200279D")]
			public class GameFinishInPrepare : GameModeFactory.AutoChessGameMode.GameTaskWithCoroutine
			{
				// Token: 0x06010954 RID: 67924 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010954")]
				[Address(RVA = "0x86DBF0", Offset = "0x86C7F0", VA = "0x18086DBF0", Slot = "12")]
				protected override IEnumerator CoroutineTask()
				{
					return null;
				}

				// Token: 0x06010955 RID: 67925 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010955")]
				[Address(RVA = "0x86DCA0", Offset = "0x86C8A0", VA = "0x18086DCA0")]
				public GameFinishInPrepare()
				{
				}

				// Token: 0x0401296E RID: 76142
				[Token(Token = "0x401296E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_CoroutineTask;

				// Token: 0x0401296F RID: 76143
				[Token(Token = "0x401296F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x0200279F RID: 10143
			[Token(Token = "0x200279F")]
			public class MainGameInPrepare : GameModeFactory.AutoChessGameMode.BattlePendingTaskBase
			{
				// Token: 0x17002449 RID: 9289
				// (get) Token: 0x0601095C RID: 67932 RVA: 0x00065658 File Offset: 0x00063858
				[Token(Token = "0x17002449")]
				public override bool taskFinished
				{
					[Token(Token = "0x601095C")]
					[Address(RVA = "0x870230", Offset = "0x86EE30", VA = "0x180870230", Slot = "10")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x1700244A RID: 9290
				// (get) Token: 0x0601095D RID: 67933 RVA: 0x00065670 File Offset: 0x00063870
				[Token(Token = "0x1700244A")]
				public override float maxTaskTime
				{
					[Token(Token = "0x601095D")]
					[Address(RVA = "0x8701D0", Offset = "0x86EDD0", VA = "0x1808701D0", Slot = "11")]
					get
					{
						return 0f;
					}
				}

				// Token: 0x0601095E RID: 67934 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601095E")]
				[Address(RVA = "0x86F790", Offset = "0x86E390", VA = "0x18086F790", Slot = "8")]
				public override void OnTaskStart()
				{
				}

				// Token: 0x0601095F RID: 67935 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601095F")]
				[Address(RVA = "0x86F6D0", Offset = "0x86E2D0", VA = "0x18086F6D0", Slot = "9")]
				public override void OnTaskFinish(bool isInterrupt)
				{
				}

				// Token: 0x06010960 RID: 67936 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010960")]
				[Address(RVA = "0x86F960", Offset = "0x86E560", VA = "0x18086F960")]
				private void _HandleDataChanged(object arg)
				{
				}

				// Token: 0x06010961 RID: 67937 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010961")]
				[Address(RVA = "0x86FA10", Offset = "0x86E610", VA = "0x18086FA10")]
				private void _Refresh()
				{
				}

				// Token: 0x06010962 RID: 67938 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010962")]
				[Address(RVA = "0x86FB90", Offset = "0x86E790", VA = "0x18086FB90")]
				private void _UpdateDummyOnTile(ChessMapInfo chessMapInfo, IEnumerable<GridPosition> tilePositions)
				{
				}

				// Token: 0x06010963 RID: 67939 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010963")]
				[Address(RVA = "0x86FAE0", Offset = "0x86E6E0", VA = "0x18086FAE0")]
				private void _RemoveDummyOnTile(Character character, Tile tile)
				{
				}

				// Token: 0x06010964 RID: 67940 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010964")]
				[Address(RVA = "0x86F8C0", Offset = "0x86E4C0", VA = "0x18086F8C0")]
				public void _CreateDummyOnTile(ChessInst chessInst, Tile tile)
				{
				}

				// Token: 0x06010965 RID: 67941 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010965")]
				[Address(RVA = "0x8700E0", Offset = "0x86ECE0", VA = "0x1808700E0")]
				public MainGameInPrepare()
				{
				}

				// Token: 0x06010966 RID: 67942 RVA: 0x00065688 File Offset: 0x00063888
				[Token(Token = "0x6010966")]
				[Address(RVA = "0x85CBE0", Offset = "0x85B7E0", VA = "0x18085CBE0")]
				private bool <>xLuaBaseProxy_get_taskFinished()
				{
					return default(bool);
				}

				// Token: 0x06010967 RID: 67943 RVA: 0x000656A0 File Offset: 0x000638A0
				[Token(Token = "0x6010967")]
				[Address(RVA = "0x85CB80", Offset = "0x85B780", VA = "0x18085CB80")]
				private float <>xLuaBaseProxy_get_maxTaskTime()
				{
					return 0f;
				}

				// Token: 0x06010968 RID: 67944 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010968")]
				[Address(RVA = "0x85C810", Offset = "0x85B410", VA = "0x18085C810")]
				private void <>xLuaBaseProxy_OnTaskStart()
				{
				}

				// Token: 0x06010969 RID: 67945 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010969")]
				[Address(RVA = "0x85CAC0", Offset = "0x85B6C0", VA = "0x18085CAC0")]
				private void <>xLuaBaseProxy_OnTaskFinish(bool P0)
				{
				}

				// Token: 0x04012973 RID: 76147
				[Token(Token = "0x4012973")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private AutoChessDataCenter.DataChecker m_dummyInfoChecker;

				// Token: 0x04012974 RID: 76148
				[Token(Token = "0x4012974")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private AutoChessDummyManager m_dummyManager;

				// Token: 0x04012975 RID: 76149
				[Token(Token = "0x4012975")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_taskFinished;

				// Token: 0x04012976 RID: 76150
				[Token(Token = "0x4012976")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_get_maxTaskTime;

				// Token: 0x04012977 RID: 76151
				[Token(Token = "0x4012977")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_OnTaskStart;

				// Token: 0x04012978 RID: 76152
				[Token(Token = "0x4012978")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_OnTaskFinish;

				// Token: 0x04012979 RID: 76153
				[Token(Token = "0x4012979")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0__HandleDataChanged;

				// Token: 0x0401297A RID: 76154
				[Token(Token = "0x401297A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0__Refresh;

				// Token: 0x0401297B RID: 76155
				[Token(Token = "0x401297B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0__UpdateDummyOnTile;

				// Token: 0x0401297C RID: 76156
				[Token(Token = "0x401297C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0__RemoveDummyOnTile;

				// Token: 0x0401297D RID: 76157
				[Token(Token = "0x401297D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0__CreateDummyOnTile;

				// Token: 0x0401297E RID: 76158
				[Token(Token = "0x401297E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020027A0 RID: 10144
			[Token(Token = "0x20027A0")]
			public class WaitingInGame : GameModeFactory.AutoChessGameMode.BattlePendingTaskBase
			{
				// Token: 0x1700244B RID: 9291
				// (get) Token: 0x0601096A RID: 67946 RVA: 0x000656B8 File Offset: 0x000638B8
				[Token(Token = "0x1700244B")]
				public override bool taskFinished
				{
					[Token(Token = "0x601096A")]
					[Address(RVA = "0x873310", Offset = "0x871F10", VA = "0x180873310", Slot = "10")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x1700244C RID: 9292
				// (get) Token: 0x0601096B RID: 67947 RVA: 0x000656D0 File Offset: 0x000638D0
				[Token(Token = "0x1700244C")]
				public override float maxTaskTime
				{
					[Token(Token = "0x601096B")]
					[Address(RVA = "0x8732B0", Offset = "0x871EB0", VA = "0x1808732B0", Slot = "11")]
					get
					{
						return 0f;
					}
				}

				// Token: 0x0601096C RID: 67948 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601096C")]
				[Address(RVA = "0x8731A0", Offset = "0x871DA0", VA = "0x1808731A0", Slot = "8")]
				public override void OnTaskStart()
				{
				}

				// Token: 0x0601096D RID: 67949 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601096D")]
				[Address(RVA = "0x873210", Offset = "0x871E10", VA = "0x180873210")]
				public WaitingInGame()
				{
				}

				// Token: 0x0601096E RID: 67950 RVA: 0x000656E8 File Offset: 0x000638E8
				[Token(Token = "0x601096E")]
				[Address(RVA = "0x85CBE0", Offset = "0x85B7E0", VA = "0x18085CBE0")]
				private bool <>xLuaBaseProxy_get_taskFinished()
				{
					return default(bool);
				}

				// Token: 0x0601096F RID: 67951 RVA: 0x00065700 File Offset: 0x00063900
				[Token(Token = "0x601096F")]
				[Address(RVA = "0x85CB80", Offset = "0x85B780", VA = "0x18085CB80")]
				private float <>xLuaBaseProxy_get_maxTaskTime()
				{
					return 0f;
				}

				// Token: 0x06010970 RID: 67952 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010970")]
				[Address(RVA = "0x85C810", Offset = "0x85B410", VA = "0x18085C810")]
				private void <>xLuaBaseProxy_OnTaskStart()
				{
				}

				// Token: 0x0401297F RID: 76159
				[Token(Token = "0x401297F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_taskFinished;

				// Token: 0x04012980 RID: 76160
				[Token(Token = "0x4012980")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_get_maxTaskTime;

				// Token: 0x04012981 RID: 76161
				[Token(Token = "0x4012981")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_OnTaskStart;

				// Token: 0x04012982 RID: 76162
				[Token(Token = "0x4012982")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020027A1 RID: 10145
			[Token(Token = "0x20027A1")]
			public class PreloadDataInBattle : GameModeFactory.AutoChessGameMode.GameTaskWithCoroutine
			{
				// Token: 0x1700244D RID: 9293
				// (get) Token: 0x06010971 RID: 67953 RVA: 0x00065718 File Offset: 0x00063918
				[Token(Token = "0x1700244D")]
				private bool needUnloadResource
				{
					[Token(Token = "0x6010971")]
					[Address(RVA = "0x8707C0", Offset = "0x86F3C0", VA = "0x1808707C0")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x1700244E RID: 9294
				// (get) Token: 0x06010972 RID: 67954 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x1700244E")]
				private BattleAudioLoader audioLoader
				{
					[Token(Token = "0x6010972")]
					[Address(RVA = "0x870650", Offset = "0x86F250", VA = "0x180870650")]
					get
					{
						return null;
					}
				}

				// Token: 0x06010973 RID: 67955 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010973")]
				[Address(RVA = "0x870460", Offset = "0x86F060", VA = "0x180870460", Slot = "8")]
				public override void OnTaskStart()
				{
				}

				// Token: 0x06010974 RID: 67956 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010974")]
				[Address(RVA = "0x8703B0", Offset = "0x86EFB0", VA = "0x1808703B0", Slot = "12")]
				protected override IEnumerator CoroutineTask()
				{
					return null;
				}

				// Token: 0x06010975 RID: 67957 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010975")]
				[Address(RVA = "0x8704F0", Offset = "0x86F0F0", VA = "0x1808704F0")]
				protected IEnumerator _LoadForBattle()
				{
					return null;
				}

				// Token: 0x06010976 RID: 67958 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010976")]
				[Address(RVA = "0x8705A0", Offset = "0x86F1A0", VA = "0x1808705A0")]
				public PreloadDataInBattle()
				{
				}

				// Token: 0x06010977 RID: 67959 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010977")]
				[Address(RVA = "0x86DFA0", Offset = "0x86CBA0", VA = "0x18086DFA0")]
				private void <>xLuaBaseProxy_OnTaskStart()
				{
				}

				// Token: 0x04012983 RID: 76163
				[Token(Token = "0x4012983")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private BattleAudioLoader m_audioLoader;

				// Token: 0x04012984 RID: 76164
				[Token(Token = "0x4012984")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private List<PoolManager.ObjectConfig> m_configsForBattle;

				// Token: 0x04012985 RID: 76165
				[Token(Token = "0x4012985")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_needUnloadResource;

				// Token: 0x04012986 RID: 76166
				[Token(Token = "0x4012986")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_get_audioLoader;

				// Token: 0x04012987 RID: 76167
				[Token(Token = "0x4012987")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_OnTaskStart;

				// Token: 0x04012988 RID: 76168
				[Token(Token = "0x4012988")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_CoroutineTask;

				// Token: 0x04012989 RID: 76169
				[Token(Token = "0x4012989")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0__LoadForBattle;

				// Token: 0x0401298A RID: 76170
				[Token(Token = "0x401298A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020027A4 RID: 10148
			[Token(Token = "0x20027A4")]
			public class MainGameInBattle : GameModeFactory.AutoChessGameMode.BattlePendingTaskBase
			{
				// Token: 0x17002453 RID: 9299
				// (get) Token: 0x06010984 RID: 67972 RVA: 0x00065760 File Offset: 0x00063960
				[Token(Token = "0x17002453")]
				public override bool taskFinished
				{
					[Token(Token = "0x6010984")]
					[Address(RVA = "0x86ED90", Offset = "0x86D990", VA = "0x18086ED90", Slot = "10")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17002454 RID: 9300
				// (get) Token: 0x06010985 RID: 67973 RVA: 0x00065778 File Offset: 0x00063978
				[Token(Token = "0x17002454")]
				public override float maxTaskTime
				{
					[Token(Token = "0x6010985")]
					[Address(RVA = "0x86ED30", Offset = "0x86D930", VA = "0x18086ED30", Slot = "11")]
					get
					{
						return 0f;
					}
				}

				// Token: 0x06010986 RID: 67974 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010986")]
				[Address(RVA = "0x86E730", Offset = "0x86D330", VA = "0x18086E730", Slot = "8")]
				public override void OnTaskStart()
				{
				}

				// Token: 0x06010987 RID: 67975 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010987")]
				[Address(RVA = "0x86EB90", Offset = "0x86D790", VA = "0x18086EB90")]
				private IEnumerator _StartBattle()
				{
					return null;
				}

				// Token: 0x06010988 RID: 67976 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010988")]
				[Address(RVA = "0x86E8A0", Offset = "0x86D4A0", VA = "0x18086E8A0", Slot = "12")]
				protected virtual IEnumerator StartMainBattle()
				{
					return null;
				}

				// Token: 0x06010989 RID: 67977 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010989")]
				[Address(RVA = "0x86EB00", Offset = "0x86D700", VA = "0x18086EB00")]
				private IEnumerator _Prebuilt()
				{
					return null;
				}

				// Token: 0x0601098A RID: 67978 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601098A")]
				[Address(RVA = "0x86E950", Offset = "0x86D550", VA = "0x18086E950")]
				private void _OnAutoChessModeChanged()
				{
				}

				// Token: 0x0601098B RID: 67979 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601098B")]
				[Address(RVA = "0x86E600", Offset = "0x86D200", VA = "0x18086E600", Slot = "9")]
				public override void OnTaskFinish(bool isInterrupt)
				{
				}

				// Token: 0x0601098C RID: 67980 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601098C")]
				[Address(RVA = "0x86EC40", Offset = "0x86D840", VA = "0x18086EC40")]
				public MainGameInBattle()
				{
				}

				// Token: 0x0601098D RID: 67981 RVA: 0x00065790 File Offset: 0x00063990
				[Token(Token = "0x601098D")]
				[Address(RVA = "0x85CBE0", Offset = "0x85B7E0", VA = "0x18085CBE0")]
				private bool <>xLuaBaseProxy_get_taskFinished()
				{
					return default(bool);
				}

				// Token: 0x0601098E RID: 67982 RVA: 0x000657A8 File Offset: 0x000639A8
				[Token(Token = "0x601098E")]
				[Address(RVA = "0x85CB80", Offset = "0x85B780", VA = "0x18085CB80")]
				private float <>xLuaBaseProxy_get_maxTaskTime()
				{
					return 0f;
				}

				// Token: 0x0601098F RID: 67983 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601098F")]
				[Address(RVA = "0x85C810", Offset = "0x85B410", VA = "0x18085C810")]
				private void <>xLuaBaseProxy_OnTaskStart()
				{
				}

				// Token: 0x06010990 RID: 67984 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010990")]
				[Address(RVA = "0x85CAC0", Offset = "0x85B6C0", VA = "0x18085CAC0")]
				private void <>xLuaBaseProxy_OnTaskFinish(bool P0)
				{
				}

				// Token: 0x04012992 RID: 76178
				[Token(Token = "0x4012992")]
				private const float PREBUILT_INTERVAL = 0.2f;

				// Token: 0x04012993 RID: 76179
				[Token(Token = "0x4012993")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private AutoChessBattleTrigger m_autoTrigger;

				// Token: 0x04012994 RID: 76180
				[Token(Token = "0x4012994")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_taskFinished;

				// Token: 0x04012995 RID: 76181
				[Token(Token = "0x4012995")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_get_maxTaskTime;

				// Token: 0x04012996 RID: 76182
				[Token(Token = "0x4012996")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_OnTaskStart;

				// Token: 0x04012997 RID: 76183
				[Token(Token = "0x4012997")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0__StartBattle;

				// Token: 0x04012998 RID: 76184
				[Token(Token = "0x4012998")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_StartMainBattle;

				// Token: 0x04012999 RID: 76185
				[Token(Token = "0x4012999")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0__Prebuilt;

				// Token: 0x0401299A RID: 76186
				[Token(Token = "0x401299A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0__OnAutoChessModeChanged;

				// Token: 0x0401299B RID: 76187
				[Token(Token = "0x401299B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_OnTaskFinish;

				// Token: 0x0401299C RID: 76188
				[Token(Token = "0x401299C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020027A8 RID: 10152
			[Token(Token = "0x20027A8")]
			public class GameFinishInBattle : GameModeFactory.AutoChessGameMode.GameTaskWithCoroutine
			{
				// Token: 0x060109A4 RID: 68004 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60109A4")]
				[Address(RVA = "0x86DAE0", Offset = "0x86C6E0", VA = "0x18086DAE0", Slot = "12")]
				protected override IEnumerator CoroutineTask()
				{
					return null;
				}

				// Token: 0x060109A5 RID: 68005 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60109A5")]
				[Address(RVA = "0x86DB90", Offset = "0x86C790", VA = "0x18086DB90")]
				public GameFinishInBattle()
				{
				}

				// Token: 0x040129A8 RID: 76200
				[Token(Token = "0x40129A8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_CoroutineTask;

				// Token: 0x040129A9 RID: 76201
				[Token(Token = "0x40129A9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020027AA RID: 10154
			[Token(Token = "0x20027AA")]
			public class MainGameInHelpBattle : GameModeFactory.AutoChessGameMode.MainGameInBattle
			{
				// Token: 0x060109AC RID: 68012 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60109AC")]
				[Address(RVA = "0x86EFE0", Offset = "0x86DBE0", VA = "0x18086EFE0", Slot = "12")]
				protected override IEnumerator StartMainBattle()
				{
					return null;
				}

				// Token: 0x060109AD RID: 68013 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60109AD")]
				[Address(RVA = "0x86F3C0", Offset = "0x86DFC0", VA = "0x18086F3C0")]
				private void _ApplyChessStatus()
				{
				}

				// Token: 0x060109AE RID: 68014 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60109AE")]
				[Address(RVA = "0x86F090", Offset = "0x86DC90", VA = "0x18086F090")]
				private void _ApplyChessStatus(Character character, int instId, HelpBattleData helpBattleData)
				{
				}

				// Token: 0x060109AF RID: 68015 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60109AF")]
				[Address(RVA = "0x86F670", Offset = "0x86E270", VA = "0x18086F670")]
				public MainGameInHelpBattle()
				{
				}

				// Token: 0x060109B1 RID: 68017 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60109B1")]
				[Address(RVA = "0x86EEA0", Offset = "0x86DAA0", VA = "0x18086EEA0")]
				private IEnumerator <>xLuaBaseProxy_StartMainBattle()
				{
					return null;
				}

				// Token: 0x040129AE RID: 76206
				[Token(Token = "0x40129AE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_StartMainBattle;

				// Token: 0x040129AF RID: 76207
				[Token(Token = "0x40129AF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0__ApplyChessStatus;

				// Token: 0x040129B0 RID: 76208
				[Token(Token = "0x40129B0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix1__ApplyChessStatus;

				// Token: 0x040129B1 RID: 76209
				[Token(Token = "0x40129B1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020027AC RID: 10156
			[Token(Token = "0x20027AC")]
			public class MainGameInBossBattle : GameModeFactory.AutoChessGameMode.MainGameInBattle
			{
				// Token: 0x060109B8 RID: 68024 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60109B8")]
				[Address(RVA = "0x86EDF0", Offset = "0x86D9F0", VA = "0x18086EDF0", Slot = "12")]
				protected override IEnumerator StartMainBattle()
				{
					return null;
				}

				// Token: 0x060109B9 RID: 68025 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60109B9")]
				[Address(RVA = "0x86EEB0", Offset = "0x86DAB0", VA = "0x18086EEB0")]
				private void _OnBossBattleStart()
				{
				}

				// Token: 0x060109BA RID: 68026 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60109BA")]
				[Address(RVA = "0x86EF80", Offset = "0x86DB80", VA = "0x18086EF80")]
				public MainGameInBossBattle()
				{
				}

				// Token: 0x060109BC RID: 68028 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60109BC")]
				[Address(RVA = "0x86EEA0", Offset = "0x86DAA0", VA = "0x18086EEA0")]
				private IEnumerator <>xLuaBaseProxy_StartMainBattle()
				{
					return null;
				}

				// Token: 0x040129B5 RID: 76213
				[Token(Token = "0x40129B5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_StartMainBattle;

				// Token: 0x040129B6 RID: 76214
				[Token(Token = "0x40129B6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0__OnBossBattleStart;

				// Token: 0x040129B7 RID: 76215
				[Token(Token = "0x40129B7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020027AE RID: 10158
			[Token(Token = "0x20027AE")]
			public class AutoMoveCameraInHelpBattle : GameModeFactory.AutoChessGameMode.BattlePendingTaskBase
			{
				// Token: 0x060109C3 RID: 68035 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60109C3")]
				[Address(RVA = "0x85C5F0", Offset = "0x85B1F0", VA = "0x18085C5F0", Slot = "8")]
				public override void OnTaskStart()
				{
				}

				// Token: 0x060109C4 RID: 68036 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60109C4")]
				[Address(RVA = "0x85C870", Offset = "0x85B470", VA = "0x18085C870")]
				private void _RegisterTileListener()
				{
				}

				// Token: 0x060109C5 RID: 68037 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60109C5")]
				[Address(RVA = "0x85C560", Offset = "0x85B160", VA = "0x18085C560")]
				public void OnEnemyEnterLeftMap()
				{
				}

				// Token: 0x060109C6 RID: 68038 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60109C6")]
				[Address(RVA = "0x85CA20", Offset = "0x85B620", VA = "0x18085CA20")]
				public AutoMoveCameraInHelpBattle()
				{
				}

				// Token: 0x060109C7 RID: 68039 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60109C7")]
				[Address(RVA = "0x85C810", Offset = "0x85B410", VA = "0x18085C810")]
				private void <>xLuaBaseProxy_OnTaskStart()
				{
				}

				// Token: 0x040129BB RID: 76219
				[Token(Token = "0x40129BB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private bool m_enemyHasEnterLeftMap;

				// Token: 0x040129BC RID: 76220
				[Token(Token = "0x40129BC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnTaskStart;

				// Token: 0x040129BD RID: 76221
				[Token(Token = "0x40129BD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0__RegisterTileListener;

				// Token: 0x040129BE RID: 76222
				[Token(Token = "0x40129BE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_OnEnemyEnterLeftMap;

				// Token: 0x040129BF RID: 76223
				[Token(Token = "0x40129BF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge _c__Hotfix0_ctor;

				// Token: 0x020027AF RID: 10159
				[Token(Token = "0x20027AF")]
				private class EnemyEnterLeftMapListener : IHotfixable, ITileListener
				{
					// Token: 0x060109C8 RID: 68040 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60109C8")]
					[Address(RVA = "0x86DA60", Offset = "0x86C660", VA = "0x18086DA60")]
					public EnemyEnterLeftMapListener(GameModeFactory.AutoChessGameMode.AutoMoveCameraInHelpBattle manager)
					{
					}

					// Token: 0x060109C9 RID: 68041 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60109C9")]
					[Address(RVA = "0x86DA00", Offset = "0x86C600", VA = "0x18086DA00", Slot = "4")]
					public void OnLocatedCharacterUpdate(Character character)
					{
					}

					// Token: 0x060109CA RID: 68042 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60109CA")]
					[Address(RVA = "0x86D830", Offset = "0x86C430", VA = "0x18086D830", Slot = "5")]
					public void OnEntityEnter(Entity entity)
					{
					}

					// Token: 0x060109CB RID: 68043 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60109CB")]
					[Address(RVA = "0x86D9A0", Offset = "0x86C5A0", VA = "0x18086D9A0", Slot = "6")]
					public void OnEntityLeave(Entity entity)
					{
					}

					// Token: 0x040129C0 RID: 76224
					[Token(Token = "0x40129C0")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					private GameModeFactory.AutoChessGameMode.AutoMoveCameraInHelpBattle m_manager;

					// Token: 0x040129C1 RID: 76225
					[Token(Token = "0x40129C1")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
					private static DelegateBridge _c__Hotfix0_ctor;

					// Token: 0x040129C2 RID: 76226
					[Token(Token = "0x40129C2")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
					private static DelegateBridge __Hotfix0_OnLocatedCharacterUpdate;

					// Token: 0x040129C3 RID: 76227
					[Token(Token = "0x40129C3")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					private static DelegateBridge __Hotfix0_OnEntityEnter;

					// Token: 0x040129C4 RID: 76228
					[Token(Token = "0x40129C4")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
					private static DelegateBridge __Hotfix0_OnEntityLeave;
				}
			}

			// Token: 0x020027B0 RID: 10160
			[Token(Token = "0x20027B0")]
			public class PreloadDataInBattleWaiting : GameModeFactory.AutoChessGameMode.BattlePendingTaskBase
			{
				// Token: 0x060109CC RID: 68044 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60109CC")]
				[Address(RVA = "0x870290", Offset = "0x86EE90", VA = "0x180870290", Slot = "8")]
				public override void OnTaskStart()
				{
				}

				// Token: 0x060109CD RID: 68045 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60109CD")]
				[Address(RVA = "0x870310", Offset = "0x86EF10", VA = "0x180870310")]
				public PreloadDataInBattleWaiting()
				{
				}

				// Token: 0x060109CE RID: 68046 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60109CE")]
				[Address(RVA = "0x85C810", Offset = "0x85B410", VA = "0x18085C810")]
				private void <>xLuaBaseProxy_OnTaskStart()
				{
				}

				// Token: 0x040129C5 RID: 76229
				[Token(Token = "0x40129C5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnTaskStart;

				// Token: 0x040129C6 RID: 76230
				[Token(Token = "0x40129C6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020027B1 RID: 10161
			[Token(Token = "0x20027B1")]
			public class GameSettle : GameModeFactory.AutoChessGameMode.BattlePendingTaskBase
			{
				// Token: 0x060109CF RID: 68047 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60109CF")]
				[Address(RVA = "0x86DD00", Offset = "0x86C900", VA = "0x18086DD00", Slot = "8")]
				public override void OnTaskStart()
				{
				}

				// Token: 0x060109D0 RID: 68048 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60109D0")]
				[Address(RVA = "0x86DDC0", Offset = "0x86C9C0", VA = "0x18086DDC0")]
				public GameSettle()
				{
				}

				// Token: 0x060109D1 RID: 68049 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60109D1")]
				[Address(RVA = "0x85C810", Offset = "0x85B410", VA = "0x18085C810")]
				private void <>xLuaBaseProxy_OnTaskStart()
				{
				}

				// Token: 0x040129C7 RID: 76231
				[Token(Token = "0x40129C7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnTaskStart;

				// Token: 0x040129C8 RID: 76232
				[Token(Token = "0x40129C8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}
		}

		// Token: 0x020027B2 RID: 10162
		[Token(Token = "0x20027B2")]
		public class BossRushGameMode : GameModeFactory.DefaultGameMode
		{
			// Token: 0x17002461 RID: 9313
			// (get) Token: 0x060109D2 RID: 68050 RVA: 0x00065850 File Offset: 0x00063A50
			[Token(Token = "0x17002461")]
			public int maxBossWaveCnt
			{
				[Token(Token = "0x60109D2")]
				[Address(RVA = "0x85F200", Offset = "0x85DE00", VA = "0x18085F200")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002462 RID: 9314
			// (get) Token: 0x060109D3 RID: 68051 RVA: 0x00065868 File Offset: 0x00063A68
			[Token(Token = "0x17002462")]
			public int currBossWaveKillCnt
			{
				[Token(Token = "0x60109D3")]
				[Address(RVA = "0x85EEA0", Offset = "0x85DAA0", VA = "0x18085EEA0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002463 RID: 9315
			// (get) Token: 0x060109D4 RID: 68052 RVA: 0x00065880 File Offset: 0x00063A80
			[Token(Token = "0x17002463")]
			public int currBossWaveTotalCnt
			{
				[Token(Token = "0x60109D4")]
				[Address(RVA = "0x85EF40", Offset = "0x85DB40", VA = "0x18085EF40")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002464 RID: 9316
			// (get) Token: 0x060109D5 RID: 68053 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17002464")]
			public List<LevelData.WaveData> waveDatas
			{
				[Token(Token = "0x60109D5")]
				[Address(RVA = "0x85F270", Offset = "0x85DE70", VA = "0x18085F270")]
				get
				{
					return null;
				}
			}

			// Token: 0x17002465 RID: 9317
			// (get) Token: 0x060109D6 RID: 68054 RVA: 0x00065898 File Offset: 0x00063A98
			[Token(Token = "0x17002465")]
			public int battleAreaBegin
			{
				[Token(Token = "0x60109D6")]
				[Address(RVA = "0x85EDE0", Offset = "0x85D9E0", VA = "0x18085EDE0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002466 RID: 9318
			// (get) Token: 0x060109D7 RID: 68055 RVA: 0x000658B0 File Offset: 0x00063AB0
			[Token(Token = "0x17002466")]
			public int battleAreaEnd
			{
				[Token(Token = "0x60109D7")]
				[Address(RVA = "0x85EE40", Offset = "0x85DA40", VA = "0x18085EE40")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002467 RID: 9319
			// (get) Token: 0x060109D8 RID: 68056 RVA: 0x000658C8 File Offset: 0x00063AC8
			[Token(Token = "0x17002467")]
			public bool isInBossWave
			{
				[Token(Token = "0x60109D8")]
				[Address(RVA = "0x85F140", Offset = "0x85DD40", VA = "0x18085F140")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002468 RID: 9320
			// (get) Token: 0x060109D9 RID: 68057 RVA: 0x000658E0 File Offset: 0x00063AE0
			[Token(Token = "0x17002468")]
			public bool isInBonusWave
			{
				[Token(Token = "0x60109D9")]
				[Address(RVA = "0x85F0E0", Offset = "0x85DCE0", VA = "0x18085F0E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002469 RID: 9321
			// (get) Token: 0x060109DA RID: 68058 RVA: 0x000658F8 File Offset: 0x00063AF8
			[Token(Token = "0x17002469")]
			public override bool hasExtraBuildCondition
			{
				[Token(Token = "0x60109DA")]
				[Address(RVA = "0x85F020", Offset = "0x85DC20", VA = "0x18085F020", Slot = "106")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700246A RID: 9322
			// (get) Token: 0x060109DB RID: 68059 RVA: 0x00065910 File Offset: 0x00063B10
			[Token(Token = "0x1700246A")]
			public override bool isLargeMap
			{
				[Token(Token = "0x60109DB")]
				[Address(RVA = "0x85F1A0", Offset = "0x85DDA0", VA = "0x18085F1A0", Slot = "105")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700246B RID: 9323
			// (get) Token: 0x060109DC RID: 68060 RVA: 0x00065928 File Offset: 0x00063B28
			[Token(Token = "0x1700246B")]
			public override GameModeMeta.GameModeType gameModeType
			{
				[Token(Token = "0x60109DC")]
				[Address(RVA = "0x85EFC0", Offset = "0x85DBC0", VA = "0x18085EFC0", Slot = "119")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x060109DD RID: 68061 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60109DD")]
			[Address(RVA = "0x85EC50", Offset = "0x85D850", VA = "0x18085EC50")]
			public BossRushGameMode(ref GameModeMeta meta)
			{
			}

			// Token: 0x1700246C RID: 9324
			// (get) Token: 0x060109DE RID: 68062 RVA: 0x00065940 File Offset: 0x00063B40
			// (set) Token: 0x060109DF RID: 68063 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700246C")]
			public bool hasFinishedDangerArea
			{
				[Token(Token = "0x60109DE")]
				[Address(RVA = "0x85F080", Offset = "0x85DC80", VA = "0x18085F080")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60109DF")]
				[Address(RVA = "0x85F3B0", Offset = "0x85DFB0", VA = "0x18085F3B0")]
				set
				{
				}
			}

			// Token: 0x060109E0 RID: 68064 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60109E0")]
			[Address(RVA = "0x85D4C0", Offset = "0x85C0C0", VA = "0x18085D4C0", Slot = "122")]
			public override void Init(ref GameModeMeta meta, ref int randomSeed, BattlePlayerData playerData, LevelData levelData)
			{
			}

			// Token: 0x060109E1 RID: 68065 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60109E1")]
			[Address(RVA = "0x85D1F0", Offset = "0x85BDF0", VA = "0x18085D1F0", Slot = "155")]
			public override Scheduler.SchedulerPreprocessor GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x060109E2 RID: 68066 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60109E2")]
			[Address(RVA = "0x85EBA0", Offset = "0x85D7A0", VA = "0x18085EBA0")]
			private void _OnInitNextBossWave()
			{
			}

			// Token: 0x060109E3 RID: 68067 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60109E3")]
			[Address(RVA = "0x85D250", Offset = "0x85BE50", VA = "0x18085D250")]
			public void InitBossRushController(Entity entity)
			{
			}

			// Token: 0x060109E4 RID: 68068 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60109E4")]
			[Address(RVA = "0x85D420", Offset = "0x85C020", VA = "0x18085D420")]
			public void InitBossRushRecodr(Entity entity)
			{
			}

			// Token: 0x060109E5 RID: 68069 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60109E5")]
			[Address(RVA = "0x85D640", Offset = "0x85C240", VA = "0x18085D640")]
			public void ModifyBattleAreaData(Blackboard blackboard)
			{
			}

			// Token: 0x060109E6 RID: 68070 RVA: 0x00065958 File Offset: 0x00063B58
			[Token(Token = "0x60109E6")]
			[Address(RVA = "0x85D0B0", Offset = "0x85BCB0", VA = "0x18085D0B0")]
			public Vector3 GetDangerAreaEffectPosition(Vector3 trapLocalPosition)
			{
				return default(Vector3);
			}

			// Token: 0x060109E7 RID: 68071 RVA: 0x00065970 File Offset: 0x00063B70
			[Token(Token = "0x60109E7")]
			[Address(RVA = "0x85CE30", Offset = "0x85BA30", VA = "0x18085CE30")]
			public Vector3 GetBattleAreaBeginEffectPosition(Vector3 trapLocalPosition)
			{
				return default(Vector3);
			}

			// Token: 0x060109E8 RID: 68072 RVA: 0x00065988 File Offset: 0x00063B88
			[Token(Token = "0x60109E8")]
			[Address(RVA = "0x85CF70", Offset = "0x85BB70", VA = "0x18085CF70")]
			public Vector3 GetBattleAreaEndEffectPosition(Vector3 trapLocalPosition)
			{
				return default(Vector3);
			}

			// Token: 0x060109E9 RID: 68073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60109E9")]
			[Address(RVA = "0x85DD60", Offset = "0x85C960", VA = "0x18085DD60", Slot = "148")]
			public override void OnWaveWillStart(LevelData.WaveData waveData)
			{
			}

			// Token: 0x060109EA RID: 68074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60109EA")]
			[Address(RVA = "0x85DA70", Offset = "0x85C670", VA = "0x18085DA70", Slot = "149")]
			public override void OnWaveWillFinish(LevelData.WaveData waveData)
			{
			}

			// Token: 0x060109EB RID: 68075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60109EB")]
			[Address(RVA = "0x85D8B0", Offset = "0x85C4B0", VA = "0x18085D8B0")]
			public void OnBossWaveWillStart(object args)
			{
			}

			// Token: 0x060109EC RID: 68076 RVA: 0x000659A0 File Offset: 0x00063BA0
			[Token(Token = "0x60109EC")]
			[Address(RVA = "0x85CC40", Offset = "0x85B840", VA = "0x18085CC40", Slot = "152")]
			public override bool CheckBuildable(BuildCondition buildCondition, Tile tile, SharedConsts.Direction direction, bool spawnManually, bool overflowOccupiedCnt, BattleCharacterData sourceData, PlayerSide operationSide = PlayerSide.DEFAULT)
			{
				return default(bool);
			}

			// Token: 0x060109ED RID: 68077 RVA: 0x000659B8 File Offset: 0x00063BB8
			[Token(Token = "0x60109ED")]
			[Address(RVA = "0x85E680", Offset = "0x85D280", VA = "0x18085E680", Slot = "177")]
			public override bool TryHookCheckWaveNotFinish(bool schedulerResult, out bool result)
			{
				return default(bool);
			}

			// Token: 0x060109EE RID: 68078 RVA: 0x000659D0 File Offset: 0x00063BD0
			[Token(Token = "0x60109EE")]
			[Address(RVA = "0x85EA20", Offset = "0x85D620", VA = "0x18085EA20")]
			private bool _CheckCanMoveToBonusWave()
			{
				return default(bool);
			}

			// Token: 0x060109EF RID: 68079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60109EF")]
			[Address(RVA = "0x85DA10", Offset = "0x85C610", VA = "0x18085DA10", Slot = "178")]
			public override void OnSpawnSummonedEnemy()
			{
			}

			// Token: 0x060109F0 RID: 68080 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60109F0")]
			[Address(RVA = "0x85D9B0", Offset = "0x85C5B0", VA = "0x18085D9B0", Slot = "179")]
			public override void OnSpawnSummonedEnemyFinished()
			{
			}

			// Token: 0x060109F1 RID: 68081 RVA: 0x000659E8 File Offset: 0x00063BE8
			[Token(Token = "0x60109F1")]
			[Address(RVA = "0x85D740", Offset = "0x85C340", VA = "0x18085D740")]
			public bool NextWaveIsBonusWave()
			{
				return default(bool);
			}

			// Token: 0x060109F2 RID: 68082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60109F2")]
			[Address(RVA = "0x85E470", Offset = "0x85D070", VA = "0x18085E470")]
			public void TrackRecycleEnemyAtWave(Enemy enemy, int waveDelta)
			{
			}

			// Token: 0x1700246D RID: 9325
			// (get) Token: 0x060109F3 RID: 68083 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700246D")]
			public override Scheduler.DefaultWaveHandler waveHandler
			{
				[Token(Token = "0x60109F3")]
				[Address(RVA = "0x85F2E0", Offset = "0x85DEE0", VA = "0x18085F2E0", Slot = "120")]
				get
				{
					return null;
				}
			}

			// Token: 0x060109F4 RID: 68084 RVA: 0x00065A00 File Offset: 0x00063C00
			[Token(Token = "0x60109F4")]
			[Address(RVA = "0x85AC60", Offset = "0x859860", VA = "0x18085AC60")]
			private bool <>xLuaBaseProxy_get_hasExtraBuildCondition()
			{
				return default(bool);
			}

			// Token: 0x060109F5 RID: 68085 RVA: 0x00065A18 File Offset: 0x00063C18
			[Token(Token = "0x60109F5")]
			[Address(RVA = "0x85AC70", Offset = "0x859870", VA = "0x18085AC70")]
			private bool <>xLuaBaseProxy_get_isLargeMap()
			{
				return default(bool);
			}

			// Token: 0x060109F6 RID: 68086 RVA: 0x00065A30 File Offset: 0x00063C30
			[Token(Token = "0x60109F6")]
			[Address(RVA = "0x83EAA0", Offset = "0x83D6A0", VA = "0x18083EAA0")]
			private GameModeMeta.GameModeType <>xLuaBaseProxy_get_gameModeType()
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}

			// Token: 0x060109F7 RID: 68087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60109F7")]
			[Address(RVA = "0x83EA80", Offset = "0x83D680", VA = "0x18083EA80")]
			private void <>xLuaBaseProxy_Init(ref GameModeMeta P0, ref int P1, BattlePlayerData P2, LevelData P3)
			{
			}

			// Token: 0x060109F8 RID: 68088 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60109F8")]
			[Address(RVA = "0x83EA70", Offset = "0x83D670", VA = "0x18083EA70")]
			private Scheduler.SchedulerPreprocessor <>xLuaBaseProxy_GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x060109F9 RID: 68089 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60109F9")]
			[Address(RVA = "0x85E9F0", Offset = "0x85D5F0", VA = "0x18085E9F0")]
			private void <>xLuaBaseProxy_OnWaveWillStart(LevelData.WaveData P0)
			{
			}

			// Token: 0x060109FA RID: 68090 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60109FA")]
			[Address(RVA = "0x85E9E0", Offset = "0x85D5E0", VA = "0x18085E9E0")]
			private void <>xLuaBaseProxy_OnWaveWillFinish(LevelData.WaveData P0)
			{
			}

			// Token: 0x060109FB RID: 68091 RVA: 0x00065A48 File Offset: 0x00063C48
			[Token(Token = "0x60109FB")]
			[Address(RVA = "0x85AAD0", Offset = "0x8596D0", VA = "0x18085AAD0")]
			private bool <>xLuaBaseProxy_CheckBuildable(BuildCondition P0, Tile P1, SharedConsts.Direction P2, bool P3, bool P4, BattleCharacterData P5, PlayerSide P6)
			{
				return default(bool);
			}

			// Token: 0x060109FC RID: 68092 RVA: 0x00065A60 File Offset: 0x00063C60
			[Token(Token = "0x60109FC")]
			[Address(RVA = "0x85EA00", Offset = "0x85D600", VA = "0x18085EA00")]
			private bool <>xLuaBaseProxy_TryHookCheckWaveNotFinish(bool P0, out bool P1)
			{
				return default(bool);
			}

			// Token: 0x060109FD RID: 68093 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60109FD")]
			[Address(RVA = "0x85E9D0", Offset = "0x85D5D0", VA = "0x18085E9D0")]
			private void <>xLuaBaseProxy_OnSpawnSummonedEnemy()
			{
			}

			// Token: 0x060109FE RID: 68094 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60109FE")]
			[Address(RVA = "0x85E9C0", Offset = "0x85D5C0", VA = "0x18085E9C0")]
			private void <>xLuaBaseProxy_OnSpawnSummonedEnemyFinished()
			{
			}

			// Token: 0x060109FF RID: 68095 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60109FF")]
			[Address(RVA = "0x85EA10", Offset = "0x85D610", VA = "0x18085EA10")]
			private Scheduler.DefaultWaveHandler <>xLuaBaseProxy_get_waveHandler()
			{
				return null;
			}

			// Token: 0x040129C9 RID: 76233
			[Token(Token = "0x40129C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public readonly List<int> enemyCntStats;

			// Token: 0x040129CA RID: 76234
			[Token(Token = "0x40129CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<int> bossWaveCount;

			// Token: 0x040129CB RID: 76235
			[Token(Token = "0x40129CB")]
			public const string BOSSRUSH_BOSSWAVE_TAG = "bosswave";

			// Token: 0x040129CC RID: 76236
			[Token(Token = "0x40129CC")]
			public const string BOSSRUSH_BONUSWAVE_TAG = "bonuswave";

			// Token: 0x040129CD RID: 76237
			[Token(Token = "0x40129CD")]
			public const string BOSSRUSH_UI_PLUGIN_PATH = "UI/BossRush/Battle/act1bossrush_battle_ui_plugin.prefab";

			// Token: 0x040129CE RID: 76238
			[Token(Token = "0x40129CE")]
			public const string BOSSRUSH_CAMERA_PLUGIN_PATH = "UI/BossRush/Battle/act1bossrush_battle_camera_plugin.prefab";

			// Token: 0x040129CF RID: 76239
			[Token(Token = "0x40129CF")]
			private const string BOSS_WAVE_FINISHED_LOG = "SIMPLE,trap_091_brctrl,bossrush_finished_wave";

			// Token: 0x040129D0 RID: 76240
			[Token(Token = "0x40129D0")]
			private const string WITHDRAW_ABILITY_KEY = "Withdraw";

			// Token: 0x040129D1 RID: 76241
			[Token(Token = "0x40129D1")]
			private const string DANGER_AREA_ABILITY_KEY = "danger_area";

			// Token: 0x040129D2 RID: 76242
			[Token(Token = "0x40129D2")]
			private const string MOVE_CAMERA_ABILITY_KEY = "MoveCamera";

			// Token: 0x040129D3 RID: 76243
			[Token(Token = "0x40129D3")]
			private const string DISABLE_RECODR_ABILITY_KEY = "Disable";

			// Token: 0x040129D4 RID: 76244
			[Token(Token = "0x40129D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int currBossWaveCnt;

			// Token: 0x040129D5 RID: 76245
			[Token(Token = "0x40129D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int prevBossWavesEnemiesCnt;

			// Token: 0x040129D6 RID: 76246
			[Token(Token = "0x40129D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int m_battleAreaBegin;

			// Token: 0x040129D7 RID: 76247
			[Token(Token = "0x40129D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int m_battleAreaEnd;

			// Token: 0x040129D8 RID: 76248
			[Token(Token = "0x40129D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int m_dangerAreaEnd;

			// Token: 0x040129D9 RID: 76249
			[Token(Token = "0x40129D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Dictionary<int, List<ObjectPtr<Enemy>>> m_cachedRecycleEnemies;

			// Token: 0x040129DA RID: 76250
			[Token(Token = "0x40129DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private int m_currentWaveIndex;

			// Token: 0x040129DB RID: 76251
			[Token(Token = "0x40129DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private int m_activatedControllerCount;

			// Token: 0x040129DC RID: 76252
			[Token(Token = "0x40129DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private BossRushSchedulerPreprocessor m_schedulerPreprocessor;

			// Token: 0x040129DD RID: 76253
			[Token(Token = "0x40129DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private ObjectPtr<Entity> m_bossRushCtroller;

			// Token: 0x040129DE RID: 76254
			[Token(Token = "0x40129DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private ObjectPtr<Entity> m_bossRushRecodr;

			// Token: 0x040129DF RID: 76255
			[Token(Token = "0x40129DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private int m_willSummonedEnemiesCount;

			// Token: 0x040129E0 RID: 76256
			[Token(Token = "0x40129E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private bool m_isInBossWave;

			// Token: 0x040129E1 RID: 76257
			[Token(Token = "0x40129E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
			private bool m_isInBonusWave;

			// Token: 0x040129E2 RID: 76258
			[Token(Token = "0x40129E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
			private bool m_hasFinishedDangerArea;

			// Token: 0x040129E3 RID: 76259
			[Token(Token = "0x40129E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_maxBossWaveCnt;

			// Token: 0x040129E4 RID: 76260
			[Token(Token = "0x40129E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_currBossWaveKillCnt;

			// Token: 0x040129E5 RID: 76261
			[Token(Token = "0x40129E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_currBossWaveTotalCnt;

			// Token: 0x040129E6 RID: 76262
			[Token(Token = "0x40129E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_waveDatas;

			// Token: 0x040129E7 RID: 76263
			[Token(Token = "0x40129E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_battleAreaBegin;

			// Token: 0x040129E8 RID: 76264
			[Token(Token = "0x40129E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_battleAreaEnd;

			// Token: 0x040129E9 RID: 76265
			[Token(Token = "0x40129E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_isInBossWave;

			// Token: 0x040129EA RID: 76266
			[Token(Token = "0x40129EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_isInBonusWave;

			// Token: 0x040129EB RID: 76267
			[Token(Token = "0x40129EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_hasExtraBuildCondition;

			// Token: 0x040129EC RID: 76268
			[Token(Token = "0x40129EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_isLargeMap;

			// Token: 0x040129ED RID: 76269
			[Token(Token = "0x40129ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_gameModeType;

			// Token: 0x040129EE RID: 76270
			[Token(Token = "0x40129EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040129EF RID: 76271
			[Token(Token = "0x40129EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_hasFinishedDangerArea;

			// Token: 0x040129F0 RID: 76272
			[Token(Token = "0x40129F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_set_hasFinishedDangerArea;

			// Token: 0x040129F1 RID: 76273
			[Token(Token = "0x40129F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x040129F2 RID: 76274
			[Token(Token = "0x40129F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_GetSchedulerPreprocessor;

			// Token: 0x040129F3 RID: 76275
			[Token(Token = "0x40129F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0__OnInitNextBossWave;

			// Token: 0x040129F4 RID: 76276
			[Token(Token = "0x40129F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_InitBossRushController;

			// Token: 0x040129F5 RID: 76277
			[Token(Token = "0x40129F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_InitBossRushRecodr;

			// Token: 0x040129F6 RID: 76278
			[Token(Token = "0x40129F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_ModifyBattleAreaData;

			// Token: 0x040129F7 RID: 76279
			[Token(Token = "0x40129F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_GetDangerAreaEffectPosition;

			// Token: 0x040129F8 RID: 76280
			[Token(Token = "0x40129F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_GetBattleAreaBeginEffectPosition;

			// Token: 0x040129F9 RID: 76281
			[Token(Token = "0x40129F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_GetBattleAreaEndEffectPosition;

			// Token: 0x040129FA RID: 76282
			[Token(Token = "0x40129FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_OnWaveWillStart;

			// Token: 0x040129FB RID: 76283
			[Token(Token = "0x40129FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_OnWaveWillFinish;

			// Token: 0x040129FC RID: 76284
			[Token(Token = "0x40129FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_OnBossWaveWillStart;

			// Token: 0x040129FD RID: 76285
			[Token(Token = "0x40129FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0_CheckBuildable;

			// Token: 0x040129FE RID: 76286
			[Token(Token = "0x40129FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0_TryHookCheckWaveNotFinish;

			// Token: 0x040129FF RID: 76287
			[Token(Token = "0x40129FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0__CheckCanMoveToBonusWave;

			// Token: 0x04012A00 RID: 76288
			[Token(Token = "0x4012A00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0_OnSpawnSummonedEnemy;

			// Token: 0x04012A01 RID: 76289
			[Token(Token = "0x4012A01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private static DelegateBridge __Hotfix0_OnSpawnSummonedEnemyFinished;

			// Token: 0x04012A02 RID: 76290
			[Token(Token = "0x4012A02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private static DelegateBridge __Hotfix0_NextWaveIsBonusWave;

			// Token: 0x04012A03 RID: 76291
			[Token(Token = "0x4012A03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			private static DelegateBridge __Hotfix0_TrackRecycleEnemyAtWave;

			// Token: 0x04012A04 RID: 76292
			[Token(Token = "0x4012A04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private static DelegateBridge __Hotfix0_get_waveHandler;

			// Token: 0x020027B3 RID: 10163
			[Token(Token = "0x20027B3")]
			public class BossrushGameModeWaveHandler : Scheduler.DefaultWaveHandler
			{
				// Token: 0x1700246E RID: 9326
				// (get) Token: 0x06010A00 RID: 68096 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x1700246E")]
				protected GameModeFactory.BossRushGameMode gameMode
				{
					[Token(Token = "0x6010A00")]
					[Address(RVA = "0x85F480", Offset = "0x85E080", VA = "0x18085F480")]
					get
					{
						return null;
					}
				}

				// Token: 0x1700246F RID: 9327
				// (get) Token: 0x06010A01 RID: 68097 RVA: 0x00065A78 File Offset: 0x00063C78
				[Token(Token = "0x1700246F")]
				public override bool skipCurWave
				{
					[Token(Token = "0x6010A01")]
					[Address(RVA = "0x85F5A0", Offset = "0x85E1A0", VA = "0x18085F5A0", Slot = "4")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x06010A02 RID: 68098 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010A02")]
				[Address(RVA = "0x85F420", Offset = "0x85E020", VA = "0x18085F420")]
				public BossrushGameModeWaveHandler()
				{
				}

				// Token: 0x06010A03 RID: 68099 RVA: 0x00065A90 File Offset: 0x00063C90
				[Token(Token = "0x6010A03")]
				[Address(RVA = "0x6475E0", Offset = "0x6461E0", VA = "0x1806475E0")]
				private bool <>xLuaBaseProxy_get_skipCurWave()
				{
					return default(bool);
				}

				// Token: 0x04012A05 RID: 76293
				[Token(Token = "0x4012A05")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private GameModeFactory.BossRushGameMode m_gameMode;

				// Token: 0x04012A06 RID: 76294
				[Token(Token = "0x4012A06")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_gameMode;

				// Token: 0x04012A07 RID: 76295
				[Token(Token = "0x4012A07")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_get_skipCurWave;

				// Token: 0x04012A08 RID: 76296
				[Token(Token = "0x4012A08")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}
		}

		// Token: 0x020027B4 RID: 10164
		[Token(Token = "0x20027B4")]
		public class CooperateGameMode : GameModeFactory.DefaultGameMode, IMultiplayerGameMode, IGameMode, IHotfixable
		{
			// Token: 0x06010A04 RID: 68100 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A04")]
			[Address(RVA = "0x865140", Offset = "0x863D40", VA = "0x180865140")]
			public void OnFootballManualTick(FP deltaTime)
			{
			}

			// Token: 0x06010A05 RID: 68101 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A05")]
			[Address(RVA = "0x862F30", Offset = "0x861B30", VA = "0x180862F30")]
			public void InitFootball(Vector2 position, FootballEnemy enemy)
			{
			}

			// Token: 0x06010A06 RID: 68102 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A06")]
			[Address(RVA = "0x863980", Offset = "0x862580", VA = "0x180863980")]
			public void LandFootball(Vector2 position, bool force = false)
			{
			}

			// Token: 0x06010A07 RID: 68103 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A07")]
			[Address(RVA = "0x864190", Offset = "0x862D90", VA = "0x180864190")]
			public void OnAllyHoldFootball(FP holdingFootballRemainTime, Tile tile, PlayerSide playerSide)
			{
			}

			// Token: 0x06010A08 RID: 68104 RVA: 0x00065AA8 File Offset: 0x00063CA8
			[Token(Token = "0x6010A08")]
			[Address(RVA = "0x861ED0", Offset = "0x860AD0", VA = "0x180861ED0")]
			public int GetGoal(SideTypeIndex side)
			{
				return 0;
			}

			// Token: 0x06010A09 RID: 68105 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A09")]
			[Address(RVA = "0x8656A0", Offset = "0x8642A0", VA = "0x1808656A0")]
			public void OnScoreAGoal(SideTypeIndex sideTypeIndex, int value)
			{
			}

			// Token: 0x06010A0A RID: 68106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A0A")]
			[Address(RVA = "0x865760", Offset = "0x864360", VA = "0x180865760")]
			public void OnScoreFinished()
			{
			}

			// Token: 0x17002470 RID: 9328
			// (get) Token: 0x06010A0B RID: 68107 RVA: 0x00065AC0 File Offset: 0x00063CC0
			[Token(Token = "0x17002470")]
			public bool isPrepared
			{
				[Token(Token = "0x6010A0B")]
				[Address(RVA = "0x86CDA0", Offset = "0x86B9A0", VA = "0x18086CDA0", Slot = "208")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002471 RID: 9329
			// (get) Token: 0x06010A0C RID: 68108 RVA: 0x00065AD8 File Offset: 0x00063CD8
			[Token(Token = "0x17002471")]
			public bool isRunning
			{
				[Token(Token = "0x6010A0C")]
				[Address(RVA = "0x86CEA0", Offset = "0x86BAA0", VA = "0x18086CEA0", Slot = "209")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002472 RID: 9330
			// (get) Token: 0x06010A0D RID: 68109 RVA: 0x00065AF0 File Offset: 0x00063CF0
			[Token(Token = "0x17002472")]
			public bool isUnstable
			{
				[Token(Token = "0x6010A0D")]
				[Address(RVA = "0x86D020", Offset = "0x86BC20", VA = "0x18086D020")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002473 RID: 9331
			// (get) Token: 0x06010A0E RID: 68110 RVA: 0x00065B08 File Offset: 0x00063D08
			[Token(Token = "0x17002473")]
			public bool isPlaying
			{
				[Token(Token = "0x6010A0E")]
				[Address(RVA = "0x86CD20", Offset = "0x86B920", VA = "0x18086CD20")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06010A0F RID: 68111 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A0F")]
			[Address(RVA = "0x867140", Offset = "0x865D40", VA = "0x180867140", Slot = "203")]
			public void SetReady()
			{
			}

			// Token: 0x06010A10 RID: 68112 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A10")]
			[Address(RVA = "0x8670C0", Offset = "0x865CC0", VA = "0x1808670C0", Slot = "202")]
			public void SetPrepared()
			{
			}

			// Token: 0x06010A11 RID: 68113 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A11")]
			[Address(RVA = "0x867040", Offset = "0x865C40", VA = "0x180867040", Slot = "204")]
			public void SetPlaying()
			{
			}

			// Token: 0x06010A12 RID: 68114 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A12")]
			[Address(RVA = "0x8671C0", Offset = "0x865DC0", VA = "0x1808671C0", Slot = "205")]
			public void SetUnstable()
			{
			}

			// Token: 0x06010A13 RID: 68115 RVA: 0x00065B20 File Offset: 0x00063D20
			[Token(Token = "0x6010A13")]
			[Address(RVA = "0x863FD0", Offset = "0x862BD0", VA = "0x180863FD0", Slot = "206")]
			public bool NextFrame(bool additional)
			{
				return default(bool);
			}

			// Token: 0x06010A14 RID: 68116 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A14")]
			[Address(RVA = "0x86ADE0", Offset = "0x8699E0", VA = "0x18086ADE0")]
			private void _NextFrameInPause()
			{
			}

			// Token: 0x06010A15 RID: 68117 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A15")]
			[Address(RVA = "0x85F7C0", Offset = "0x85E3C0", VA = "0x18085F7C0", Slot = "207")]
			public void ApplyOprt(PlayerOprtData oprt)
			{
			}

			// Token: 0x06010A16 RID: 68118 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A16")]
			[Address(RVA = "0x86B020", Offset = "0x869C20", VA = "0x18086B020")]
			private void _OnRevMapMarkResponse(object arg)
			{
			}

			// Token: 0x06010A17 RID: 68119 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A17")]
			[Address(RVA = "0x868100", Offset = "0x866D00", VA = "0x180868100")]
			private void _ApplyOprt_Character(PlayerOprtData oprt)
			{
			}

			// Token: 0x06010A18 RID: 68120 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A18")]
			[Address(RVA = "0x8684B0", Offset = "0x8670B0", VA = "0x1808684B0")]
			private void _ApplyOprt_DummyDragMate(GameMarkData oprt)
			{
			}

			// Token: 0x06010A19 RID: 68121 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A19")]
			[Address(RVA = "0x869EC0", Offset = "0x868AC0", VA = "0x180869EC0")]
			private void _FinishDummyWhenDisable()
			{
			}

			// Token: 0x06010A1A RID: 68122 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A1A")]
			[Address(RVA = "0x8682D0", Offset = "0x866ED0", VA = "0x1808682D0")]
			private void _ApplyOprt_Cost(PlayerOprtData oprt)
			{
			}

			// Token: 0x06010A1B RID: 68123 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A1B")]
			[Address(RVA = "0x867D80", Offset = "0x866980", VA = "0x180867D80")]
			private void _ApplyCostOprt_Receive(PlayerSide side, int status)
			{
			}

			// Token: 0x06010A1C RID: 68124 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A1C")]
			[Address(RVA = "0x867AF0", Offset = "0x8666F0", VA = "0x180867AF0")]
			private void _ApplyCostOprt_Accept(PlayerSide side, int status)
			{
			}

			// Token: 0x06010A1D RID: 68125 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A1D")]
			[Address(RVA = "0x867FF0", Offset = "0x866BF0", VA = "0x180867FF0")]
			private void _ApplyCostOprt_Refuse(PlayerSide side, int status)
			{
			}

			// Token: 0x06010A1E RID: 68126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A1E")]
			[Address(RVA = "0x868E40", Offset = "0x867A40", VA = "0x180868E40")]
			private void _ApplyOprt_Pause(PlayerOprtData oprt)
			{
			}

			// Token: 0x06010A1F RID: 68127 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A1F")]
			[Address(RVA = "0x869300", Offset = "0x867F00", VA = "0x180869300")]
			private void _ApplyPauseOprt_Receive(PlayerSide side)
			{
			}

			// Token: 0x06010A20 RID: 68128 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A20")]
			[Address(RVA = "0x869210", Offset = "0x867E10", VA = "0x180869210")]
			private void _ApplyPauseOprt_Accept(PlayerSide side)
			{
			}

			// Token: 0x06010A21 RID: 68129 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A21")]
			[Address(RVA = "0x8694D0", Offset = "0x8680D0", VA = "0x1808694D0")]
			private void _ApplyPauseOprt_Refuse(PlayerSide side)
			{
			}

			// Token: 0x06010A22 RID: 68130 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A22")]
			[Address(RVA = "0x8695B0", Offset = "0x8681B0", VA = "0x1808695B0")]
			private void _ApplyPauseOprt_Resume(PlayerSide side)
			{
			}

			// Token: 0x06010A23 RID: 68131 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A23")]
			[Address(RVA = "0x868BB0", Offset = "0x8677B0", VA = "0x180868BB0")]
			private void _ApplyOprt_Online(PlayerOprtData oprt)
			{
			}

			// Token: 0x06010A24 RID: 68132 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A24")]
			[Address(RVA = "0x869170", Offset = "0x867D70", VA = "0x180869170")]
			private void _ApplyOprt_SpeedUp(PlayerOprtData oprt)
			{
			}

			// Token: 0x06010A25 RID: 68133 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A25")]
			[Address(RVA = "0x86B810", Offset = "0x86A410", VA = "0x18086B810")]
			private void _SetPlaySpeed(PlayerSide side)
			{
			}

			// Token: 0x06010A26 RID: 68134 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A26")]
			[Address(RVA = "0x869080", Offset = "0x867C80", VA = "0x180869080")]
			private void _ApplyOprt_SkipResting(PlayerSide side)
			{
			}

			// Token: 0x06010A27 RID: 68135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A27")]
			[Address(RVA = "0x866FA0", Offset = "0x865BA0", VA = "0x180866FA0")]
			public void SendSpeedUpRequest()
			{
			}

			// Token: 0x06010A28 RID: 68136 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A28")]
			[Address(RVA = "0x866EF0", Offset = "0x865AF0", VA = "0x180866EF0")]
			public void SendPauseResponseRequest(int param)
			{
			}

			// Token: 0x06010A29 RID: 68137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A29")]
			[Address(RVA = "0x866D20", Offset = "0x865920", VA = "0x180866D20")]
			public void SendCooperatePauseRequest()
			{
			}

			// Token: 0x06010A2A RID: 68138 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A2A")]
			[Address(RVA = "0x866DE0", Offset = "0x8659E0", VA = "0x180866DE0")]
			public void SendCooperateRequest(PlayerOperator opt, int status)
			{
			}

			// Token: 0x06010A2B RID: 68139 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A2B")]
			[Address(RVA = "0x86B4F0", Offset = "0x86A0F0", VA = "0x18086B4F0")]
			private void _SendDragDummyOprt(BattleCharacterData.Signiture sig, GridPosition grid, SharedConsts.Direction dir = SharedConsts.Direction.UP)
			{
			}

			// Token: 0x06010A2C RID: 68140 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A2C")]
			[Address(RVA = "0x86B600", Offset = "0x86A200", VA = "0x18086B600")]
			private void _SendOprtCharacter(CharacterAction oprt, BattleCharacterData.Signiture sig, GridPosition grid, SharedConsts.Direction dir = SharedConsts.Direction.UP)
			{
			}

			// Token: 0x06010A2D RID: 68141 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A2D")]
			[Address(RVA = "0x860CA0", Offset = "0x85F8A0", VA = "0x180860CA0")]
			public void DoCostRequestLocal()
			{
			}

			// Token: 0x06010A2E RID: 68142 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A2E")]
			[Address(RVA = "0x86A430", Offset = "0x869030", VA = "0x18086A430")]
			private void _HardSetPlayerSpeed(PlayerSide side, bool speedOn)
			{
			}

			// Token: 0x06010A2F RID: 68143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A2F")]
			[Address(RVA = "0x86B160", Offset = "0x869D60", VA = "0x18086B160")]
			private void _RefreshSpeed(InternalSpeedType speedType = InternalSpeedType.ENUM)
			{
			}

			// Token: 0x06010A30 RID: 68144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A30")]
			[Address(RVA = "0x86B750", Offset = "0x86A350", VA = "0x18086B750")]
			private void _SetPauseAndSpeedStateWhenPlayerDie(PlayerSide side)
			{
			}

			// Token: 0x17002474 RID: 9332
			// (get) Token: 0x06010A31 RID: 68145 RVA: 0x00065B38 File Offset: 0x00063D38
			[Token(Token = "0x17002474")]
			private bool m_isQuit
			{
				[Token(Token = "0x6010A31")]
				[Address(RVA = "0x86D0A0", Offset = "0x86BCA0", VA = "0x18086D0A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002475 RID: 9333
			// (get) Token: 0x06010A32 RID: 68146 RVA: 0x00065B50 File Offset: 0x00063D50
			[Token(Token = "0x17002475")]
			private bool m_mateIsQuit
			{
				[Token(Token = "0x6010A32")]
				[Address(RVA = "0x86D130", Offset = "0x86BD30", VA = "0x18086D130")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002476 RID: 9334
			// (get) Token: 0x06010A33 RID: 68147 RVA: 0x00065B68 File Offset: 0x00063D68
			[Token(Token = "0x17002476")]
			public GameModeFactory.CooperateGameMode.SubGameModeType subGameModeType
			{
				[Token(Token = "0x6010A33")]
				[Address(RVA = "0x86D4F0", Offset = "0x86C0F0", VA = "0x18086D4F0")]
				get
				{
					return GameModeFactory.CooperateGameMode.SubGameModeType.NORMAL;
				}
			}

			// Token: 0x17002477 RID: 9335
			// (get) Token: 0x06010A34 RID: 68148 RVA: 0x00065B80 File Offset: 0x00063D80
			[Token(Token = "0x17002477")]
			public bool isResting
			{
				[Token(Token = "0x6010A34")]
				[Address(RVA = "0x86CE20", Offset = "0x86BA20", VA = "0x18086CE20")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002478 RID: 9336
			// (get) Token: 0x06010A35 RID: 68149 RVA: 0x00065B98 File Offset: 0x00063D98
			[Token(Token = "0x17002478")]
			public bool isSpeedUp
			{
				[Token(Token = "0x6010A35")]
				[Address(RVA = "0x86CF30", Offset = "0x86BB30", VA = "0x18086CF30")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002479 RID: 9337
			// (get) Token: 0x06010A36 RID: 68150 RVA: 0x00065BB0 File Offset: 0x00063DB0
			[Token(Token = "0x17002479")]
			public InternalState state
			{
				[Token(Token = "0x6010A36")]
				[Address(RVA = "0x86D470", Offset = "0x86C070", VA = "0x18086D470")]
				get
				{
					return InternalState.NONE;
				}
			}

			// Token: 0x1700247A RID: 9338
			// (get) Token: 0x06010A37 RID: 68151 RVA: 0x00065BC8 File Offset: 0x00063DC8
			[Token(Token = "0x1700247A")]
			public bool isFail
			{
				[Token(Token = "0x6010A37")]
				[Address(RVA = "0x86CA50", Offset = "0x86B650", VA = "0x18086CA50")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700247B RID: 9339
			// (get) Token: 0x06010A38 RID: 68152 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700247B")]
			public CooperateGuideOutPut guideOutPut
			{
				[Token(Token = "0x6010A38")]
				[Address(RVA = "0x86C930", Offset = "0x86B530", VA = "0x18086C930")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700247C RID: 9340
			// (get) Token: 0x06010A39 RID: 68153 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700247C")]
			public GameModeFactory.CooperateGameMode.CooperateNormalModeManager normalMgr
			{
				[Token(Token = "0x6010A39")]
				[Address(RVA = "0x86D1C0", Offset = "0x86BDC0", VA = "0x18086D1C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700247D RID: 9341
			// (get) Token: 0x06010A3A RID: 68154 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700247D")]
			public GameModeFactory.CooperateGameMode.CooperateDefenceModeManager defenceMgr
			{
				[Token(Token = "0x6010A3A")]
				[Address(RVA = "0x86C750", Offset = "0x86B350", VA = "0x18086C750")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700247E RID: 9342
			// (get) Token: 0x06010A3B RID: 68155 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700247E")]
			public GameModeFactory.CooperateGameMode.CooperateFootballModeManager footballMgr
			{
				[Token(Token = "0x6010A3B")]
				[Address(RVA = "0x86C840", Offset = "0x86B440", VA = "0x18086C840")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700247F RID: 9343
			// (get) Token: 0x06010A3C RID: 68156 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700247F")]
			public GameModeFactory.CooperateGameMode.CooperateSailBoatModeManager sailBoatMgr
			{
				[Token(Token = "0x6010A3C")]
				[Address(RVA = "0x86D3F0", Offset = "0x86BFF0", VA = "0x18086D3F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17002480 RID: 9344
			// (get) Token: 0x06010A3D RID: 68157 RVA: 0x00065BE0 File Offset: 0x00063DE0
			// (set) Token: 0x06010A3E RID: 68158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002480")]
			public bool playerInPauseRequest
			{
				[Token(Token = "0x6010A3D")]
				[Address(RVA = "0x86D370", Offset = "0x86BF70", VA = "0x18086D370")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6010A3E")]
				[Address(RVA = "0x86D760", Offset = "0x86C360", VA = "0x18086D760")]
				set
				{
				}
			}

			// Token: 0x17002481 RID: 9345
			// (get) Token: 0x06010A3F RID: 68159 RVA: 0x00065BF8 File Offset: 0x00063DF8
			[Token(Token = "0x17002481")]
			public bool isInPause
			{
				[Token(Token = "0x6010A3F")]
				[Address(RVA = "0x86CB60", Offset = "0x86B760", VA = "0x18086CB60")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002482 RID: 9346
			// (get) Token: 0x06010A40 RID: 68160 RVA: 0x00065C10 File Offset: 0x00063E10
			// (set) Token: 0x06010A41 RID: 68161 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002482")]
			public bool playerInCostRequest
			{
				[Token(Token = "0x6010A40")]
				[Address(RVA = "0x86D2F0", Offset = "0x86BEF0", VA = "0x18086D2F0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6010A41")]
				[Address(RVA = "0x86D6D0", Offset = "0x86C2D0", VA = "0x18086D6D0")]
				set
				{
				}
			}

			// Token: 0x17002483 RID: 9347
			// (get) Token: 0x06010A43 RID: 68163 RVA: 0x00065C28 File Offset: 0x00063E28
			// (set) Token: 0x06010A42 RID: 68162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002483")]
			public bool isGiveUp
			{
				[Token(Token = "0x6010A43")]
				[Address(RVA = "0x86CAE0", Offset = "0x86B6E0", VA = "0x18086CAE0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6010A42")]
				[Address(RVA = "0x86D640", Offset = "0x86C240", VA = "0x18086D640")]
				set
				{
				}
			}

			// Token: 0x17002484 RID: 9348
			// (get) Token: 0x06010A44 RID: 68164 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17002484")]
			public CooperatePreProcessor coopProcessor
			{
				[Token(Token = "0x6010A44")]
				[Address(RVA = "0x86C680", Offset = "0x86B280", VA = "0x18086C680")]
				get
				{
					return null;
				}
			}

			// Token: 0x06010A45 RID: 68165 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010A45")]
			[Address(RVA = "0x8611D0", Offset = "0x85FDD0", VA = "0x1808611D0")]
			public CooperateGuideOutPut FetchMultiGuideOutPut()
			{
				return null;
			}

			// Token: 0x06010A46 RID: 68166 RVA: 0x00065C40 File Offset: 0x00063E40
			[Token(Token = "0x6010A46")]
			[Address(RVA = "0x861F70", Offset = "0x860B70", VA = "0x180861F70")]
			public int GetHpForGameCheck()
			{
				return 0;
			}

			// Token: 0x06010A47 RID: 68167 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010A47")]
			[Address(RVA = "0x8644B0", Offset = "0x8630B0", VA = "0x1808644B0")]
			public IEnumerator OnBeforeWaveStart()
			{
				return null;
			}

			// Token: 0x06010A48 RID: 68168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A48")]
			[Address(RVA = "0x863A40", Offset = "0x862640", VA = "0x180863A40")]
			public void MakePlayerCharacterRevive(PlayerSide side)
			{
			}

			// Token: 0x06010A49 RID: 68169 RVA: 0x00065C58 File Offset: 0x00063E58
			[Token(Token = "0x6010A49")]
			[Address(RVA = "0x864390", Offset = "0x862F90", VA = "0x180864390")]
			public bool OnBeforeEnemyReachExit(Enemy enemy)
			{
				return default(bool);
			}

			// Token: 0x06010A4A RID: 68170 RVA: 0x00065C70 File Offset: 0x00063E70
			[Token(Token = "0x6010A4A")]
			[Address(RVA = "0x866AA0", Offset = "0x8656A0", VA = "0x180866AA0")]
			public bool ReplaceActionKey(string key)
			{
				return default(bool);
			}

			// Token: 0x06010A4B RID: 68171 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A4B")]
			[Address(RVA = "0x866930", Offset = "0x865530", VA = "0x180866930")]
			public void RecordDefenceBossStatus(FP hp, FP maxHp)
			{
			}

			// Token: 0x06010A4C RID: 68172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A4C")]
			[Address(RVA = "0x8604B0", Offset = "0x85F0B0", VA = "0x1808604B0")]
			public void ClearUnitsOnStageEnd()
			{
			}

			// Token: 0x06010A4D RID: 68173 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A4D")]
			[Address(RVA = "0x8637F0", Offset = "0x8623F0", VA = "0x1808637F0")]
			public void KillUnit(Unit unit)
			{
			}

			// Token: 0x06010A4E RID: 68174 RVA: 0x00065C88 File Offset: 0x00063E88
			[Token(Token = "0x6010A4E")]
			[Address(RVA = "0x861DF0", Offset = "0x8609F0", VA = "0x180861DF0")]
			public FP GetDefenceBossDamageTaking()
			{
				return default(FP);
			}

			// Token: 0x06010A4F RID: 68175 RVA: 0x00065CA0 File Offset: 0x00063EA0
			[Token(Token = "0x6010A4F")]
			[Address(RVA = "0x8635B0", Offset = "0x8621B0", VA = "0x1808635B0")]
			public bool IsFootballMode()
			{
				return default(bool);
			}

			// Token: 0x06010A50 RID: 68176 RVA: 0x00065CB8 File Offset: 0x00063EB8
			[Token(Token = "0x6010A50")]
			[Address(RVA = "0x863470", Offset = "0x862070", VA = "0x180863470")]
			public bool IsDefenceMode()
			{
				return default(bool);
			}

			// Token: 0x06010A51 RID: 68177 RVA: 0x00065CD0 File Offset: 0x00063ED0
			[Token(Token = "0x6010A51")]
			[Address(RVA = "0x8636D0", Offset = "0x8622D0", VA = "0x1808636D0")]
			public bool IsNormalMode()
			{
				return default(bool);
			}

			// Token: 0x06010A52 RID: 68178 RVA: 0x00065CE8 File Offset: 0x00063EE8
			[Token(Token = "0x6010A52")]
			[Address(RVA = "0x863760", Offset = "0x862360", VA = "0x180863760")]
			public bool IsSailBoatMode()
			{
				return default(bool);
			}

			// Token: 0x06010A53 RID: 68179 RVA: 0x00065D00 File Offset: 0x00063F00
			[Token(Token = "0x6010A53")]
			[Address(RVA = "0x863500", Offset = "0x862100", VA = "0x180863500")]
			public bool IsEnemyInWhiteListWhenClearByMode(string id)
			{
				return default(bool);
			}

			// Token: 0x06010A54 RID: 68180 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A54")]
			[Address(RVA = "0x86BD30", Offset = "0x86A930", VA = "0x18086BD30")]
			public CooperateGameMode(ref GameModeMeta meta)
			{
			}

			// Token: 0x17002485 RID: 9349
			// (get) Token: 0x06010A55 RID: 68181 RVA: 0x00065D18 File Offset: 0x00063F18
			[Token(Token = "0x17002485")]
			public override bool allowManualTick
			{
				[Token(Token = "0x6010A55")]
				[Address(RVA = "0x86C5A0", Offset = "0x86B1A0", VA = "0x18086C5A0", Slot = "103")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002486 RID: 9350
			// (get) Token: 0x06010A56 RID: 68182 RVA: 0x00065D30 File Offset: 0x00063F30
			[Token(Token = "0x17002486")]
			public override bool isOnline
			{
				[Token(Token = "0x6010A56")]
				[Address(RVA = "0x86CCB0", Offset = "0x86B8B0", VA = "0x18086CCB0", Slot = "104")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002487 RID: 9351
			// (get) Token: 0x06010A57 RID: 68183 RVA: 0x00065D48 File Offset: 0x00063F48
			[Token(Token = "0x17002487")]
			public override bool isLargeMap
			{
				[Token(Token = "0x6010A57")]
				[Address(RVA = "0x86CC40", Offset = "0x86B840", VA = "0x18086CC40", Slot = "105")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002488 RID: 9352
			// (get) Token: 0x06010A58 RID: 68184 RVA: 0x00065D60 File Offset: 0x00063F60
			[Token(Token = "0x17002488")]
			public override bool enableHudSlowTicker
			{
				[Token(Token = "0x6010A58")]
				[Address(RVA = "0x86C7D0", Offset = "0x86B3D0", VA = "0x18086C7D0", Slot = "117")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002489 RID: 9353
			// (get) Token: 0x06010A59 RID: 68185 RVA: 0x00065D78 File Offset: 0x00063F78
			[Token(Token = "0x17002489")]
			public override bool allowPoolManagerUnload
			{
				[Token(Token = "0x6010A59")]
				[Address(RVA = "0x86C610", Offset = "0x86B210", VA = "0x18086C610", Slot = "121")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700248A RID: 9354
			// (get) Token: 0x06010A5A RID: 68186 RVA: 0x00065D90 File Offset: 0x00063F90
			[Token(Token = "0x1700248A")]
			public override bool hasExtraBuildCondition
			{
				[Token(Token = "0x6010A5A")]
				[Address(RVA = "0x86C9B0", Offset = "0x86B5B0", VA = "0x18086C9B0", Slot = "106")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700248B RID: 9355
			// (get) Token: 0x06010A5B RID: 68187 RVA: 0x00065DA8 File Offset: 0x00063FA8
			[Token(Token = "0x1700248B")]
			public override bool isSupportSlowMotion
			{
				[Token(Token = "0x6010A5B")]
				[Address(RVA = "0x86CFB0", Offset = "0x86BBB0", VA = "0x18086CFB0", Slot = "107")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700248C RID: 9356
			// (get) Token: 0x06010A5C RID: 68188 RVA: 0x00065DC0 File Offset: 0x00063FC0
			[Token(Token = "0x1700248C")]
			public override BattleOutlineConfig outlineConfig
			{
				[Token(Token = "0x6010A5C")]
				[Address(RVA = "0x86D240", Offset = "0x86BE40", VA = "0x18086D240", Slot = "111")]
				get
				{
					return default(BattleOutlineConfig);
				}
			}

			// Token: 0x1700248D RID: 9357
			// (get) Token: 0x06010A5D RID: 68189 RVA: 0x00065DD8 File Offset: 0x00063FD8
			[Token(Token = "0x1700248D")]
			public override GameModeMeta.GameModeType gameModeType
			{
				[Token(Token = "0x6010A5D")]
				[Address(RVA = "0x86C8C0", Offset = "0x86B4C0", VA = "0x18086C8C0", Slot = "119")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x1700248E RID: 9358
			// (get) Token: 0x06010A5E RID: 68190 RVA: 0x00065DF0 File Offset: 0x00063FF0
			[Token(Token = "0x1700248E")]
			public override bool HookGetNextWave
			{
				[Token(Token = "0x6010A5E")]
				[Address(RVA = "0x86C4F0", Offset = "0x86B0F0", VA = "0x18086C4F0", Slot = "132")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06010A5F RID: 68191 RVA: 0x00065E08 File Offset: 0x00064008
			[Token(Token = "0x6010A5F")]
			[Address(RVA = "0x862DE0", Offset = "0x8619E0", VA = "0x180862DE0", Slot = "187")]
			public override bool Hook_OnDummyDragging()
			{
				return default(bool);
			}

			// Token: 0x06010A60 RID: 68192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A60")]
			[Address(RVA = "0x862FF0", Offset = "0x861BF0", VA = "0x180862FF0", Slot = "122")]
			public override void Init(ref GameModeMeta meta, ref int randomSeed, BattlePlayerData playerData, LevelData levelData)
			{
			}

			// Token: 0x06010A61 RID: 68193 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A61")]
			[Address(RVA = "0x86B290", Offset = "0x869E90", VA = "0x18086B290")]
			private void _RegisterEventListener()
			{
			}

			// Token: 0x06010A62 RID: 68194 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A62")]
			[Address(RVA = "0x86B980", Offset = "0x86A580", VA = "0x18086B980")]
			private void _UnRegisterEventListener()
			{
			}

			// Token: 0x06010A63 RID: 68195 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010A63")]
			[Address(RVA = "0x869DE0", Offset = "0x8689E0", VA = "0x180869DE0")]
			private GameModeFactory.CooperateGameMode.CooperateSubMode _CreateSubModeManager()
			{
				return null;
			}

			// Token: 0x06010A64 RID: 68196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A64")]
			[Address(RVA = "0x86A080", Offset = "0x868C80", VA = "0x18086A080")]
			private void _GetEnemyWhitelist()
			{
			}

			// Token: 0x06010A65 RID: 68197 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010A65")]
			[Address(RVA = "0x862660", Offset = "0x861260", VA = "0x180862660", Slot = "155")]
			public override Scheduler.SchedulerPreprocessor GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x06010A66 RID: 68198 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A66")]
			[Address(RVA = "0x867240", Offset = "0x865E40", VA = "0x180867240", Slot = "124")]
			public override void StartGame(Action doDefaultStart)
			{
			}

			// Token: 0x06010A67 RID: 68199 RVA: 0x00065E20 File Offset: 0x00064020
			[Token(Token = "0x6010A67")]
			[Address(RVA = "0x862AC0", Offset = "0x8616C0", VA = "0x180862AC0", Slot = "129")]
			public override bool HookPlayerOp_Withdraw(Character character)
			{
				return default(bool);
			}

			// Token: 0x06010A68 RID: 68200 RVA: 0x00065E38 File Offset: 0x00064038
			[Token(Token = "0x6010A68")]
			[Address(RVA = "0x862730", Offset = "0x861330", VA = "0x180862730", Slot = "130")]
			public override bool HookPlayerOp_Spawn(uint uniqueId, SharedConsts.Direction direction, Tile tile)
			{
				return default(bool);
			}

			// Token: 0x06010A69 RID: 68201 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A69")]
			[Address(RVA = "0x8657E0", Offset = "0x8643E0", VA = "0x1808657E0", Slot = "161")]
			public override void OnUnitRegistered(Unit unit)
			{
			}

			// Token: 0x06010A6A RID: 68202 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A6A")]
			[Address(RVA = "0x865B30", Offset = "0x864730", VA = "0x180865B30", Slot = "162")]
			public override void OnUnitUnregistered(Unit unit)
			{
			}

			// Token: 0x06010A6B RID: 68203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A6B")]
			[Address(RVA = "0x864A60", Offset = "0x863660", VA = "0x180864A60", Slot = "186")]
			public override void OnDummyTouchedToTile(Character character, Tile tile, Vector3 dummyPos)
			{
			}

			// Token: 0x06010A6C RID: 68204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A6C")]
			[Address(RVA = "0x8648B0", Offset = "0x8634B0", VA = "0x1808648B0", Slot = "188")]
			public override void OnDummySetBodyAndFaceDirection(Character character, SharedConsts.Direction direction)
			{
			}

			// Token: 0x06010A6D RID: 68205 RVA: 0x00065E50 File Offset: 0x00064050
			[Token(Token = "0x6010A6D")]
			[Address(RVA = "0x862920", Offset = "0x861520", VA = "0x180862920", Slot = "131")]
			public override bool HookPlayerOp_TrigSkill(Character character)
			{
				return default(bool);
			}

			// Token: 0x06010A6E RID: 68206 RVA: 0x00065E68 File Offset: 0x00064068
			[Token(Token = "0x6010A6E")]
			[Address(RVA = "0x862C60", Offset = "0x861860", VA = "0x180862C60", Slot = "159")]
			public override SpeedLevel HookSpeedLevel(SpeedLevel originSpeedLevel)
			{
				return SpeedLevel.SLOW_MOTION;
			}

			// Token: 0x06010A6F RID: 68207 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A6F")]
			[Address(RVA = "0x864620", Offset = "0x863220", VA = "0x180864620", Slot = "171")]
			public override void OnCardSpawned(Deck.Card card, bool spawnManually)
			{
			}

			// Token: 0x06010A70 RID: 68208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A70")]
			[Address(RVA = "0x864570", Offset = "0x863170", VA = "0x180864570", Slot = "172")]
			public override void OnCardListChanged(Deck.Card card)
			{
			}

			// Token: 0x06010A71 RID: 68209 RVA: 0x00065E80 File Offset: 0x00064080
			[Token(Token = "0x6010A71")]
			[Address(RVA = "0x85FF10", Offset = "0x85EB10", VA = "0x18085FF10", Slot = "169")]
			public override bool CheckCardReadyToSpawn(Deck.Card card)
			{
				return default(bool);
			}

			// Token: 0x06010A72 RID: 68210 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A72")]
			[Address(RVA = "0x865CC0", Offset = "0x8648C0", VA = "0x180865CC0", Slot = "148")]
			public override void OnWaveWillStart(LevelData.WaveData waveData)
			{
			}

			// Token: 0x06010A73 RID: 68211 RVA: 0x00065E98 File Offset: 0x00064098
			[Token(Token = "0x6010A73")]
			[Address(RVA = "0x85FD40", Offset = "0x85E940", VA = "0x18085FD40", Slot = "152")]
			public override bool CheckBuildable(BuildCondition buildCondition, Tile tile, SharedConsts.Direction direction, bool spawnManually, bool overflowOccupiedCnt, BattleCharacterData sourceData, PlayerSide operationSide = PlayerSide.DEFAULT)
			{
				return default(bool);
			}

			// Token: 0x06010A74 RID: 68212 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A74")]
			[Address(RVA = "0x865E40", Offset = "0x864A40", VA = "0x180865E40", Slot = "141")]
			public override void PreprocessPlayerData(List<BattlePlayerData> dataList)
			{
			}

			// Token: 0x06010A75 RID: 68213 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A75")]
			[Address(RVA = "0x865D80", Offset = "0x864980", VA = "0x180865D80", Slot = "147")]
			public override void PreprocessEnemy(LevelData.EnemyData data)
			{
			}

			// Token: 0x06010A76 RID: 68214 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A76")]
			[Address(RVA = "0x8665D0", Offset = "0x8651D0", VA = "0x1808665D0", Slot = "137")]
			public override void PreprocessRuneInput(IRuneDataHolder runeInput)
			{
			}

			// Token: 0x06010A77 RID: 68215 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A77")]
			[Address(RVA = "0x8651E0", Offset = "0x863DE0", VA = "0x1808651E0", Slot = "191")]
			public override void OnPlayerLifeToZero(PlayerSide side)
			{
			}

			// Token: 0x06010A78 RID: 68216 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A78")]
			[Address(RVA = "0x8614C0", Offset = "0x8600C0", VA = "0x1808614C0", Slot = "182")]
			public override void FinishGame(Action<BattleController.GameResult, bool> gameOverCallback, BattleController.GameResult result, bool silent = false)
			{
			}

			// Token: 0x06010A79 RID: 68217 RVA: 0x00065EB0 File Offset: 0x000640B0
			[Token(Token = "0x6010A79")]
			[Address(RVA = "0x8674B0", Offset = "0x8660B0", VA = "0x1808674B0", Slot = "177")]
			public override bool TryHookCheckWaveNotFinish(bool schedulerResult, out bool result)
			{
				return default(bool);
			}

			// Token: 0x06010A7A RID: 68218 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010A7A")]
			[Address(RVA = "0x8622C0", Offset = "0x860EC0", VA = "0x1808622C0", Slot = "167")]
			public override string GetModeTileEffect(Tile tile)
			{
				return null;
			}

			// Token: 0x06010A7B RID: 68219 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A7B")]
			[Address(RVA = "0x865C00", Offset = "0x864800", VA = "0x180865C00", Slot = "149")]
			public override void OnWaveWillFinish(LevelData.WaveData waveData)
			{
			}

			// Token: 0x06010A7C RID: 68220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A7C")]
			[Address(RVA = "0x864260", Offset = "0x862E60", VA = "0x180864260", Slot = "160")]
			public override void OnApplyingGlobalModifier(ref Modifier modifier)
			{
			}

			// Token: 0x06010A7D RID: 68221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A7D")]
			[Address(RVA = "0x864DD0", Offset = "0x8639D0", VA = "0x180864DD0", Slot = "192")]
			public override void OnEnemyReachExit(Enemy enemy, Tile cacheTile)
			{
			}

			// Token: 0x06010A7E RID: 68222 RVA: 0x00065EC8 File Offset: 0x000640C8
			[Token(Token = "0x6010A7E")]
			[Address(RVA = "0x8675D0", Offset = "0x8661D0", VA = "0x1808675D0", Slot = "193")]
			public override bool TryShowTileInfoToast(Tile tile, out int id)
			{
				return default(bool);
			}

			// Token: 0x06010A7F RID: 68223 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010A7F")]
			[Address(RVA = "0x8616E0", Offset = "0x8602E0", VA = "0x1808616E0", Slot = "157")]
			public override List<LevelData.GlobalBuffData> GatherGlobalBuffs()
			{
				return null;
			}

			// Token: 0x06010A80 RID: 68224 RVA: 0x00065EE0 File Offset: 0x000640E0
			[Token(Token = "0x6010A80")]
			[Address(RVA = "0x8673F0", Offset = "0x865FF0", VA = "0x1808673F0", Slot = "185")]
			public override bool TryGetNextWaveIndexInGameMode(out int index)
			{
				return default(bool);
			}

			// Token: 0x06010A81 RID: 68225 RVA: 0x00065EF8 File Offset: 0x000640F8
			[Token(Token = "0x6010A81")]
			[Address(RVA = "0x860300", Offset = "0x85EF00", VA = "0x180860300", Slot = "180")]
			public override bool CheckRenderInvisible(Entity entity, BattleRenderInvisibleMask mask)
			{
				return default(bool);
			}

			// Token: 0x06010A82 RID: 68226 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A82")]
			[Address(RVA = "0x86AE60", Offset = "0x869A60", VA = "0x18086AE60")]
			private void _OnCharacterUseSkill(object param)
			{
			}

			// Token: 0x06010A83 RID: 68227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A83")]
			[Address(RVA = "0x86A910", Offset = "0x869510", VA = "0x18086A910")]
			private void _MakePlayerCharacterDying(PlayerSide side)
			{
			}

			// Token: 0x06010A84 RID: 68228 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A84")]
			[Address(RVA = "0x869660", Offset = "0x868260", VA = "0x180869660")]
			private void _CollectModifier(object obj)
			{
			}

			// Token: 0x06010A85 RID: 68229 RVA: 0x00065F10 File Offset: 0x00064110
			[Token(Token = "0x6010A85")]
			[Address(RVA = "0x863640", Offset = "0x862240", VA = "0x180863640", Slot = "199")]
			public override bool IsMultiplayerLocal()
			{
				return default(bool);
			}

			// Token: 0x06010A86 RID: 68230 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A86")]
			[Address(RVA = "0x865470", Offset = "0x864070", VA = "0x180865470", Slot = "123")]
			public override void OnPostInit()
			{
			}

			// Token: 0x06010A87 RID: 68231 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A87")]
			[Address(RVA = "0x8672F0", Offset = "0x865EF0", VA = "0x1808672F0", Slot = "126")]
			public override void Tick(Action doDefaultTick)
			{
			}

			// Token: 0x06010A88 RID: 68232 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A88")]
			[Address(RVA = "0x862E80", Offset = "0x861A80", VA = "0x180862E80")]
			public void IgnorePauseRequest()
			{
			}

			// Token: 0x06010A89 RID: 68233 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A89")]
			[Address(RVA = "0x866C80", Offset = "0x865880", VA = "0x180866C80")]
			public void ResumePause()
			{
			}

			// Token: 0x06010A8A RID: 68234 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010A8A")]
			[Address(RVA = "0x861910", Offset = "0x860510", VA = "0x180861910")]
			public static Dictionary<ResourceCollector.PreloadType, object> GatherPreloadAssets()
			{
				return null;
			}

			// Token: 0x06010A8B RID: 68235 RVA: 0x00065F28 File Offset: 0x00064128
			[Token(Token = "0x6010A8B")]
			[Address(RVA = "0x862460", Offset = "0x861060", VA = "0x180862460")]
			public FP GetPlayerReviveTimePeriod()
			{
				return default(FP);
			}

			// Token: 0x06010A8C RID: 68236 RVA: 0x00065F40 File Offset: 0x00064140
			[Token(Token = "0x6010A8C")]
			[Address(RVA = "0x862560", Offset = "0x861160", VA = "0x180862560")]
			public FP GetPlayerReviveTimeRemainingTime()
			{
				return default(FP);
			}

			// Token: 0x06010A8D RID: 68237 RVA: 0x00065F58 File Offset: 0x00064158
			[Token(Token = "0x6010A8D")]
			[Address(RVA = "0x862020", Offset = "0x860C20", VA = "0x180862020")]
			public GameModeFactory.CooperateGameMode.CooperateIdentityInfo GetIdentityInfo()
			{
				return default(GameModeFactory.CooperateGameMode.CooperateIdentityInfo);
			}

			// Token: 0x06010A8E RID: 68238 RVA: 0x00065F70 File Offset: 0x00064170
			[Token(Token = "0x6010A8E")]
			[Address(RVA = "0x86A220", Offset = "0x868E20", VA = "0x18086A220")]
			private int _GetPlayerDeployCharCnt(ProfessionCategory profession = ProfessionCategory.NONE)
			{
				return 0;
			}

			// Token: 0x06010A8F RID: 68239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A8F")]
			[Address(RVA = "0x86A600", Offset = "0x869200", VA = "0x18086A600")]
			private void _LogPlayerDataOnFinishGame()
			{
			}

			// Token: 0x1700248F RID: 9359
			// (get) Token: 0x06010A90 RID: 68240 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700248F")]
			public override Scheduler.DefaultWaveHandler waveHandler
			{
				[Token(Token = "0x6010A90")]
				[Address(RVA = "0x86D570", Offset = "0x86C170", VA = "0x18086D570", Slot = "120")]
				get
				{
					return null;
				}
			}

			// Token: 0x06010A91 RID: 68241 RVA: 0x00065F88 File Offset: 0x00064188
			[Token(Token = "0x6010A91")]
			[Address(RVA = "0x861D60", Offset = "0x860960", VA = "0x180861D60")]
			public int GetCurLevel(PlayerSide side)
			{
				return 0;
			}

			// Token: 0x06010A92 RID: 68242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A92")]
			[Address(RVA = "0x867A70", Offset = "0x866670", VA = "0x180867A70")]
			public void UpgradePlayerBuffLevel(int count)
			{
			}

			// Token: 0x06010A93 RID: 68243 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A93")]
			[Address(RVA = "0x8647F0", Offset = "0x8633F0", VA = "0x1808647F0", Slot = "197")]
			public override void OnDestroy()
			{
			}

			// Token: 0x06010A94 RID: 68244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A94")]
			[Address(RVA = "0x86BBE0", Offset = "0x86A7E0", VA = "0x18086BBE0")]
			protected void _UnloadPool()
			{
			}

			// Token: 0x06010A95 RID: 68245 RVA: 0x00065FA0 File Offset: 0x000641A0
			[Token(Token = "0x6010A95")]
			[Address(RVA = "0x860190", Offset = "0x85ED90", VA = "0x180860190")]
			public bool CheckLastWave()
			{
				return default(bool);
			}

			// Token: 0x06010A96 RID: 68246 RVA: 0x00065FB8 File Offset: 0x000641B8
			[Token(Token = "0x6010A96")]
			[Address(RVA = "0x8669F0", Offset = "0x8655F0", VA = "0x1808669F0")]
			public bool RegistStageBuff(ObjectPtr<Buff> buff)
			{
				return default(bool);
			}

			// Token: 0x06010A97 RID: 68247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A97")]
			[Address(RVA = "0x860E90", Offset = "0x85FA90", VA = "0x180860E90")]
			public void DoPlayerResting()
			{
			}

			// Token: 0x06010A98 RID: 68248 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A98")]
			[Address(RVA = "0x865540", Offset = "0x864140", VA = "0x180865540")]
			public void OnRestingFinished()
			{
			}

			// Token: 0x06010A99 RID: 68249 RVA: 0x00065FD0 File Offset: 0x000641D0
			[Token(Token = "0x6010A99")]
			[Address(RVA = "0x861430", Offset = "0x860030", VA = "0x180861430")]
			public float FindMaxDistance()
			{
				return 0f;
			}

			// Token: 0x06010A9A RID: 68250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A9A")]
			[Address(RVA = "0x85F6E0", Offset = "0x85E2E0", VA = "0x18085F6E0")]
			public void AddSharedEnemyKey(string enemyKey)
			{
			}

			// Token: 0x06010A9B RID: 68251 RVA: 0x00065FE8 File Offset: 0x000641E8
			[Token(Token = "0x6010A9B")]
			[Address(RVA = "0x8600F0", Offset = "0x85ECF0", VA = "0x1808600F0")]
			public bool CheckContainsEnemy(string enemyId)
			{
				return default(bool);
			}

			// Token: 0x06010A9C RID: 68252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010A9C")]
			[Address(RVA = "0x866BE0", Offset = "0x8657E0", VA = "0x180866BE0")]
			public void ResetTargetEnemies(string enemyId)
			{
			}

			// Token: 0x06010A9D RID: 68253 RVA: 0x00066000 File Offset: 0x00064200
			[Token(Token = "0x6010A9D")]
			[Address(RVA = "0x860250", Offset = "0x85EE50", VA = "0x180860250")]
			public bool CheckPlayerDead(PlayerSide side)
			{
				return default(bool);
			}

			// Token: 0x06010A9F RID: 68255 RVA: 0x00066018 File Offset: 0x00064218
			[Token(Token = "0x6010A9F")]
			[Address(RVA = "0x85AC10", Offset = "0x859810", VA = "0x18085AC10")]
			private bool <>xLuaBaseProxy_get_allowManualTick()
			{
				return default(bool);
			}

			// Token: 0x06010AA0 RID: 68256 RVA: 0x00066030 File Offset: 0x00064230
			[Token(Token = "0x6010AA0")]
			[Address(RVA = "0x867A60", Offset = "0x866660", VA = "0x180867A60")]
			private bool <>xLuaBaseProxy_get_isOnline()
			{
				return default(bool);
			}

			// Token: 0x06010AA1 RID: 68257 RVA: 0x00066048 File Offset: 0x00064248
			[Token(Token = "0x6010AA1")]
			[Address(RVA = "0x85AC70", Offset = "0x859870", VA = "0x18085AC70")]
			private bool <>xLuaBaseProxy_get_isLargeMap()
			{
				return default(bool);
			}

			// Token: 0x06010AA2 RID: 68258 RVA: 0x00066060 File Offset: 0x00064260
			[Token(Token = "0x6010AA2")]
			[Address(RVA = "0x867A50", Offset = "0x866650", VA = "0x180867A50")]
			private bool <>xLuaBaseProxy_get_enableHudSlowTicker()
			{
				return default(bool);
			}

			// Token: 0x06010AA3 RID: 68259 RVA: 0x00066078 File Offset: 0x00064278
			[Token(Token = "0x6010AA3")]
			[Address(RVA = "0x85AC20", Offset = "0x859820", VA = "0x18085AC20")]
			private bool <>xLuaBaseProxy_get_allowPoolManagerUnload()
			{
				return default(bool);
			}

			// Token: 0x06010AA4 RID: 68260 RVA: 0x00066090 File Offset: 0x00064290
			[Token(Token = "0x6010AA4")]
			[Address(RVA = "0x85AC60", Offset = "0x859860", VA = "0x18085AC60")]
			private bool <>xLuaBaseProxy_get_hasExtraBuildCondition()
			{
				return default(bool);
			}

			// Token: 0x06010AA5 RID: 68261 RVA: 0x000660A8 File Offset: 0x000642A8
			[Token(Token = "0x6010AA5")]
			[Address(RVA = "0x85AC90", Offset = "0x859890", VA = "0x18085AC90")]
			private bool <>xLuaBaseProxy_get_isSupportSlowMotion()
			{
				return default(bool);
			}

			// Token: 0x06010AA6 RID: 68262 RVA: 0x000660C0 File Offset: 0x000642C0
			[Token(Token = "0x6010AA6")]
			[Address(RVA = "0x85ACA0", Offset = "0x8598A0", VA = "0x18085ACA0")]
			private BattleOutlineConfig <>xLuaBaseProxy_get_outlineConfig()
			{
				return default(BattleOutlineConfig);
			}

			// Token: 0x06010AA7 RID: 68263 RVA: 0x000660D8 File Offset: 0x000642D8
			[Token(Token = "0x6010AA7")]
			[Address(RVA = "0x83EAA0", Offset = "0x83D6A0", VA = "0x18083EAA0")]
			private GameModeMeta.GameModeType <>xLuaBaseProxy_get_gameModeType()
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}

			// Token: 0x06010AA8 RID: 68264 RVA: 0x000660F0 File Offset: 0x000642F0
			[Token(Token = "0x6010AA8")]
			[Address(RVA = "0x867A40", Offset = "0x866640", VA = "0x180867A40")]
			private bool <>xLuaBaseProxy_get_HookGetNextWave()
			{
				return default(bool);
			}

			// Token: 0x06010AA9 RID: 68265 RVA: 0x00066108 File Offset: 0x00064308
			[Token(Token = "0x6010AA9")]
			[Address(RVA = "0x867960", Offset = "0x866560", VA = "0x180867960")]
			private bool <>xLuaBaseProxy_Hook_OnDummyDragging()
			{
				return default(bool);
			}

			// Token: 0x06010AAA RID: 68266 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010AAA")]
			[Address(RVA = "0x83EA80", Offset = "0x83D680", VA = "0x18083EA80")]
			private void <>xLuaBaseProxy_Init(ref GameModeMeta P0, ref int P1, BattlePlayerData P2, LevelData P3)
			{
			}

			// Token: 0x06010AAB RID: 68267 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010AAB")]
			[Address(RVA = "0x83EA70", Offset = "0x83D670", VA = "0x18083EA70")]
			private Scheduler.SchedulerPreprocessor <>xLuaBaseProxy_GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x06010AAC RID: 68268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010AAC")]
			[Address(RVA = "0x840AB0", Offset = "0x83F6B0", VA = "0x180840AB0")]
			private void <>xLuaBaseProxy_StartGame(Action P0)
			{
			}

			// Token: 0x06010AAD RID: 68269 RVA: 0x00066120 File Offset: 0x00064320
			[Token(Token = "0x6010AAD")]
			[Address(RVA = "0x858C70", Offset = "0x857870", VA = "0x180858C70")]
			private bool <>xLuaBaseProxy_HookPlayerOp_Withdraw(Character P0)
			{
				return default(bool);
			}

			// Token: 0x06010AAE RID: 68270 RVA: 0x00066138 File Offset: 0x00064338
			[Token(Token = "0x6010AAE")]
			[Address(RVA = "0x858C50", Offset = "0x857850", VA = "0x180858C50")]
			private bool <>xLuaBaseProxy_HookPlayerOp_Spawn(uint P0, SharedConsts.Direction P1, Tile P2)
			{
				return default(bool);
			}

			// Token: 0x06010AAF RID: 68271 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010AAF")]
			[Address(RVA = "0x840A90", Offset = "0x83F690", VA = "0x180840A90")]
			private void <>xLuaBaseProxy_OnUnitRegistered(Unit P0)
			{
			}

			// Token: 0x06010AB0 RID: 68272 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010AB0")]
			[Address(RVA = "0x8679F0", Offset = "0x8665F0", VA = "0x1808679F0")]
			private void <>xLuaBaseProxy_OnUnitUnregistered(Unit P0)
			{
			}

			// Token: 0x06010AB1 RID: 68273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010AB1")]
			[Address(RVA = "0x8679C0", Offset = "0x8665C0", VA = "0x1808679C0")]
			private void <>xLuaBaseProxy_OnDummyTouchedToTile(Character P0, Tile P1, Vector3 P2)
			{
			}

			// Token: 0x06010AB2 RID: 68274 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010AB2")]
			[Address(RVA = "0x8679B0", Offset = "0x8665B0", VA = "0x1808679B0")]
			private void <>xLuaBaseProxy_OnDummySetBodyAndFaceDirection(Character P0, SharedConsts.Direction P1)
			{
			}

			// Token: 0x06010AB3 RID: 68275 RVA: 0x00066150 File Offset: 0x00064350
			[Token(Token = "0x6010AB3")]
			[Address(RVA = "0x858C60", Offset = "0x857860", VA = "0x180858C60")]
			private bool <>xLuaBaseProxy_HookPlayerOp_TrigSkill(Character P0)
			{
				return default(bool);
			}

			// Token: 0x06010AB4 RID: 68276 RVA: 0x00066168 File Offset: 0x00064368
			[Token(Token = "0x6010AB4")]
			[Address(RVA = "0x85ABB0", Offset = "0x8597B0", VA = "0x18085ABB0")]
			private SpeedLevel <>xLuaBaseProxy_HookSpeedLevel(SpeedLevel P0)
			{
				return SpeedLevel.SLOW_MOTION;
			}

			// Token: 0x06010AB5 RID: 68277 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010AB5")]
			[Address(RVA = "0x867990", Offset = "0x866590", VA = "0x180867990")]
			private void <>xLuaBaseProxy_OnCardSpawned(Deck.Card P0, bool P1)
			{
			}

			// Token: 0x06010AB6 RID: 68278 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010AB6")]
			[Address(RVA = "0x867980", Offset = "0x866580", VA = "0x180867980")]
			private void <>xLuaBaseProxy_OnCardListChanged(Deck.Card P0)
			{
			}

			// Token: 0x06010AB7 RID: 68279 RVA: 0x00066180 File Offset: 0x00064380
			[Token(Token = "0x6010AB7")]
			[Address(RVA = "0x867930", Offset = "0x866530", VA = "0x180867930")]
			private bool <>xLuaBaseProxy_CheckCardReadyToSpawn(Deck.Card P0)
			{
				return default(bool);
			}

			// Token: 0x06010AB8 RID: 68280 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010AB8")]
			[Address(RVA = "0x85E9F0", Offset = "0x85D5F0", VA = "0x18085E9F0")]
			private void <>xLuaBaseProxy_OnWaveWillStart(LevelData.WaveData P0)
			{
			}

			// Token: 0x06010AB9 RID: 68281 RVA: 0x00066198 File Offset: 0x00064398
			[Token(Token = "0x6010AB9")]
			[Address(RVA = "0x85AAD0", Offset = "0x8596D0", VA = "0x18085AAD0")]
			private bool <>xLuaBaseProxy_CheckBuildable(BuildCondition P0, Tile P1, SharedConsts.Direction P2, bool P3, bool P4, BattleCharacterData P5, PlayerSide P6)
			{
				return default(bool);
			}

			// Token: 0x06010ABA RID: 68282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010ABA")]
			[Address(RVA = "0x867A00", Offset = "0x866600", VA = "0x180867A00")]
			private void <>xLuaBaseProxy_PreprocessPlayerData(List<BattlePlayerData> P0)
			{
			}

			// Token: 0x06010ABB RID: 68283 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010ABB")]
			[Address(RVA = "0x85ABE0", Offset = "0x8597E0", VA = "0x18085ABE0")]
			private void <>xLuaBaseProxy_PreprocessEnemy(LevelData.EnemyData P0)
			{
			}

			// Token: 0x06010ABC RID: 68284 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010ABC")]
			[Address(RVA = "0x867A10", Offset = "0x866610", VA = "0x180867A10")]
			private void <>xLuaBaseProxy_PreprocessRuneInput(IRuneDataHolder P0)
			{
			}

			// Token: 0x06010ABD RID: 68285 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010ABD")]
			[Address(RVA = "0x840A80", Offset = "0x83F680", VA = "0x180840A80")]
			private void <>xLuaBaseProxy_OnPlayerLifeToZero(PlayerSide P0)
			{
			}

			// Token: 0x06010ABE RID: 68286 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010ABE")]
			[Address(RVA = "0x85AB90", Offset = "0x859790", VA = "0x18085AB90")]
			private void <>xLuaBaseProxy_FinishGame(Action<BattleController.GameResult, bool> P0, BattleController.GameResult P1, bool P2)
			{
			}

			// Token: 0x06010ABF RID: 68287 RVA: 0x000661B0 File Offset: 0x000643B0
			[Token(Token = "0x6010ABF")]
			[Address(RVA = "0x85EA00", Offset = "0x85D600", VA = "0x18085EA00")]
			private bool <>xLuaBaseProxy_TryHookCheckWaveNotFinish(bool P0, out bool P1)
			{
				return default(bool);
			}

			// Token: 0x06010AC0 RID: 68288 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010AC0")]
			[Address(RVA = "0x867950", Offset = "0x866550", VA = "0x180867950")]
			private string <>xLuaBaseProxy_GetModeTileEffect(Tile P0)
			{
				return null;
			}

			// Token: 0x06010AC1 RID: 68289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010AC1")]
			[Address(RVA = "0x85E9E0", Offset = "0x85D5E0", VA = "0x18085E9E0")]
			private void <>xLuaBaseProxy_OnWaveWillFinish(LevelData.WaveData P0)
			{
			}

			// Token: 0x06010AC2 RID: 68290 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010AC2")]
			[Address(RVA = "0x858C80", Offset = "0x857880", VA = "0x180858C80")]
			private void <>xLuaBaseProxy_OnApplyingGlobalModifier(ref Modifier P0)
			{
			}

			// Token: 0x06010AC3 RID: 68291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010AC3")]
			[Address(RVA = "0x858CA0", Offset = "0x8578A0", VA = "0x180858CA0")]
			private void <>xLuaBaseProxy_OnEnemyReachExit(Enemy P0, Tile P1)
			{
			}

			// Token: 0x06010AC4 RID: 68292 RVA: 0x000661C8 File Offset: 0x000643C8
			[Token(Token = "0x6010AC4")]
			[Address(RVA = "0x867A30", Offset = "0x866630", VA = "0x180867A30")]
			private bool <>xLuaBaseProxy_TryShowTileInfoToast(Tile P0, out int P1)
			{
				return default(bool);
			}

			// Token: 0x06010AC5 RID: 68293 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010AC5")]
			[Address(RVA = "0x867940", Offset = "0x866540", VA = "0x180867940")]
			private List<LevelData.GlobalBuffData> <>xLuaBaseProxy_GatherGlobalBuffs()
			{
				return null;
			}

			// Token: 0x06010AC6 RID: 68294 RVA: 0x000661E0 File Offset: 0x000643E0
			[Token(Token = "0x6010AC6")]
			[Address(RVA = "0x867A20", Offset = "0x866620", VA = "0x180867A20")]
			private bool <>xLuaBaseProxy_TryGetNextWaveIndexInGameMode(out int P0)
			{
				return default(bool);
			}

			// Token: 0x06010AC7 RID: 68295 RVA: 0x000661F8 File Offset: 0x000643F8
			[Token(Token = "0x6010AC7")]
			[Address(RVA = "0x85AB50", Offset = "0x859750", VA = "0x18085AB50")]
			private bool <>xLuaBaseProxy_CheckRenderInvisible(Entity P0, BattleRenderInvisibleMask P1)
			{
				return default(bool);
			}

			// Token: 0x06010AC8 RID: 68296 RVA: 0x00066210 File Offset: 0x00064410
			[Token(Token = "0x6010AC8")]
			[Address(RVA = "0x867970", Offset = "0x866570", VA = "0x180867970")]
			private bool <>xLuaBaseProxy_IsMultiplayerLocal()
			{
				return default(bool);
			}

			// Token: 0x06010AC9 RID: 68297 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010AC9")]
			[Address(RVA = "0x85ABD0", Offset = "0x8597D0", VA = "0x18085ABD0")]
			private void <>xLuaBaseProxy_OnPostInit()
			{
			}

			// Token: 0x06010ACA RID: 68298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010ACA")]
			[Address(RVA = "0x83EA90", Offset = "0x83D690", VA = "0x18083EA90")]
			private void <>xLuaBaseProxy_Tick(Action P0)
			{
			}

			// Token: 0x06010ACB RID: 68299 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010ACB")]
			[Address(RVA = "0x85EA10", Offset = "0x85D610", VA = "0x18085EA10")]
			private Scheduler.DefaultWaveHandler <>xLuaBaseProxy_get_waveHandler()
			{
				return null;
			}

			// Token: 0x06010ACC RID: 68300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010ACC")]
			[Address(RVA = "0x8679A0", Offset = "0x8665A0", VA = "0x1808679A0")]
			private void <>xLuaBaseProxy_OnDestroy()
			{
			}

			// Token: 0x04012A09 RID: 76297
			[Token(Token = "0x4012A09")]
			private const string FORTRESS_FIXER_KEY = "fortress_fixer";

			// Token: 0x04012A0A RID: 76298
			[Token(Token = "0x4012A0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly BattleOutlineConfig MULTIV2_CONFIG;

			// Token: 0x04012A0B RID: 76299
			[Token(Token = "0x4012A0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool blockWaveFinished;

			// Token: 0x04012A0C RID: 76300
			[Token(Token = "0x4012A0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int restingTime;

			// Token: 0x04012A0D RID: 76301
			[Token(Token = "0x4012A0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool skipRestStage;

			// Token: 0x04012A0E RID: 76302
			[Token(Token = "0x4012A0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public readonly List<string> sideSharedEnemyKeys;

			// Token: 0x04012A0F RID: 76303
			[Token(Token = "0x4012A0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private GameModeFactory.CooperateGameMode.CooperateSubMode m_curSubModeManager;

			// Token: 0x04012A10 RID: 76304
			[Token(Token = "0x4012A10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private readonly GameModeFactory.CooperateGameMode.CooperateNormalModeManager m_normalManager;

			// Token: 0x04012A11 RID: 76305
			[Token(Token = "0x4012A11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private readonly GameModeFactory.CooperateGameMode.CooperateFootballModeManager m_footballManager;

			// Token: 0x04012A12 RID: 76306
			[Token(Token = "0x4012A12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private readonly GameModeFactory.CooperateGameMode.CooperateDefenceModeManager m_defenceManager;

			// Token: 0x04012A13 RID: 76307
			[Token(Token = "0x4012A13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private readonly GameModeFactory.CooperateGameMode.CooperateSailBoatModeManager m_sailBoatManager;

			// Token: 0x04012A14 RID: 76308
			[Token(Token = "0x4012A14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private readonly BattleController.FrameData m_frameData;

			// Token: 0x04012A15 RID: 76309
			[Token(Token = "0x4012A15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private uint m_lastUpdatedDummyMoveFrame;

			// Token: 0x04012A16 RID: 76310
			[Token(Token = "0x4012A16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Character m_cachedDummy;

			// Token: 0x04012A17 RID: 76311
			[Token(Token = "0x4012A17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private GridPosition m_cachedDummyGrid;

			// Token: 0x04012A18 RID: 76312
			[Token(Token = "0x4012A18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private SharedConsts.Direction m_cachedDummyDirection;

			// Token: 0x04012A19 RID: 76313
			[Token(Token = "0x4012A19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Effect m_cachedDummyEffect;

			// Token: 0x04012A1A RID: 76314
			[Token(Token = "0x4012A1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private InternalState m_state;

			// Token: 0x04012A1B RID: 76315
			[Token(Token = "0x4012A1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private InternalSpeedType m_speed;

			// Token: 0x04012A1C RID: 76316
			[Token(Token = "0x4012A1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private InternalSpeedType m_cachedSpeed;

			// Token: 0x04012A1D RID: 76317
			[Token(Token = "0x4012A1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private GameModeFactory.CooperateGameMode.SubGameModeType m_subGameModeType;

			// Token: 0x04012A1E RID: 76318
			[Token(Token = "0x4012A1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private CooperatePreProcessor m_processor;

			// Token: 0x04012A1F RID: 76319
			[Token(Token = "0x4012A1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private bool m_isResting;

			// Token: 0x04012A20 RID: 76320
			[Token(Token = "0x4012A20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private int m_playerSkipRestingMask;

			// Token: 0x04012A21 RID: 76321
			[Token(Token = "0x4012A21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private CooperateUIPlugin m_cooperateUIPlugin;

			// Token: 0x04012A22 RID: 76322
			[Token(Token = "0x4012A22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private Scheduler.DefaultWaveHandler m_waveHandler;

			// Token: 0x04012A23 RID: 76323
			[Token(Token = "0x4012A23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private bool m_playerInCostRequest;

			// Token: 0x04012A24 RID: 76324
			[Token(Token = "0x4012A24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
			private bool m_playerInPauseRequest;

			// Token: 0x04012A25 RID: 76325
			[Token(Token = "0x4012A25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC2")]
			private bool m_speedUp;

			// Token: 0x04012A26 RID: 76326
			[Token(Token = "0x4012A26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC3")]
			private bool m_mateSpeedUp;

			// Token: 0x04012A27 RID: 76327
			[Token(Token = "0x4012A27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private bool m_isGiveUp;

			// Token: 0x04012A28 RID: 76328
			[Token(Token = "0x4012A28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private CooperateGuideOutPut m_guideOutPut;

			// Token: 0x04012A29 RID: 76329
			[Token(Token = "0x4012A29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private OnLineType m_onLineType;

			// Token: 0x04012A2A RID: 76330
			[Token(Token = "0x4012A2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			private OnLineType m_mateOnLineType;

			// Token: 0x04012A2B RID: 76331
			[Token(Token = "0x4012A2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private bool m_isSpeedChange;

			// Token: 0x04012A2C RID: 76332
			[Token(Token = "0x4012A2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private readonly ListDict<PlayerSide, FP> m_playerDamageMelee;

			// Token: 0x04012A2D RID: 76333
			[Token(Token = "0x4012A2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private readonly ListDict<PlayerSide, FP> m_playerDamageRange;

			// Token: 0x04012A2E RID: 76334
			[Token(Token = "0x4012A2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private readonly ListDict<PlayerSide, FP> m_playerTakeDamage;

			// Token: 0x04012A2F RID: 76335
			[Token(Token = "0x4012A2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private readonly ListDict<PlayerSide, FP> m_playerHeal;

			// Token: 0x04012A30 RID: 76336
			[Token(Token = "0x4012A30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			private readonly ListDict<PlayerSide, int> m_playerDieTime;

			// Token: 0x04012A31 RID: 76337
			[Token(Token = "0x4012A31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private readonly ListDict<PlayerSide, int> m_playerSkill;

			// Token: 0x04012A32 RID: 76338
			[Token(Token = "0x4012A32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private readonly ListDict<PlayerSide, int> m_lifePointReduce;

			// Token: 0x04012A33 RID: 76339
			[Token(Token = "0x4012A33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private readonly Dictionary<ProfessionCategory, int> m_characterDeploy;

			// Token: 0x04012A34 RID: 76340
			[Token(Token = "0x4012A34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private int m_giveCost;

			// Token: 0x04012A35 RID: 76341
			[Token(Token = "0x4012A35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			private int m_receiveCost;

			// Token: 0x04012A36 RID: 76342
			[Token(Token = "0x4012A36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private CooperateCommonGlobalBuff m_commonGBuff;

			// Token: 0x04012A37 RID: 76343
			[Token(Token = "0x4012A37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private readonly ListDict<PlayerSide, bool> m_playerDead;

			// Token: 0x04012A38 RID: 76344
			[Token(Token = "0x4012A38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private readonly List<LevelData.GlobalBuffData> m_globalBuffs;

			// Token: 0x04012A39 RID: 76345
			[Token(Token = "0x4012A39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private readonly List<string> m_whitelistEnemies;

			// Token: 0x04012A3A RID: 76346
			[Token(Token = "0x4012A3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnFootballManualTick;

			// Token: 0x04012A3B RID: 76347
			[Token(Token = "0x4012A3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_InitFootball;

			// Token: 0x04012A3C RID: 76348
			[Token(Token = "0x4012A3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_LandFootball;

			// Token: 0x04012A3D RID: 76349
			[Token(Token = "0x4012A3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnAllyHoldFootball;

			// Token: 0x04012A3E RID: 76350
			[Token(Token = "0x4012A3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_GetGoal;

			// Token: 0x04012A3F RID: 76351
			[Token(Token = "0x4012A3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OnScoreAGoal;

			// Token: 0x04012A40 RID: 76352
			[Token(Token = "0x4012A40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OnScoreFinished;

			// Token: 0x04012A41 RID: 76353
			[Token(Token = "0x4012A41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_isPrepared;

			// Token: 0x04012A42 RID: 76354
			[Token(Token = "0x4012A42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_isRunning;

			// Token: 0x04012A43 RID: 76355
			[Token(Token = "0x4012A43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_isUnstable;

			// Token: 0x04012A44 RID: 76356
			[Token(Token = "0x4012A44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_isPlaying;

			// Token: 0x04012A45 RID: 76357
			[Token(Token = "0x4012A45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_SetReady;

			// Token: 0x04012A46 RID: 76358
			[Token(Token = "0x4012A46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_SetPrepared;

			// Token: 0x04012A47 RID: 76359
			[Token(Token = "0x4012A47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_SetPlaying;

			// Token: 0x04012A48 RID: 76360
			[Token(Token = "0x4012A48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_SetUnstable;

			// Token: 0x04012A49 RID: 76361
			[Token(Token = "0x4012A49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_NextFrame;

			// Token: 0x04012A4A RID: 76362
			[Token(Token = "0x4012A4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0__NextFrameInPause;

			// Token: 0x04012A4B RID: 76363
			[Token(Token = "0x4012A4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_ApplyOprt;

			// Token: 0x04012A4C RID: 76364
			[Token(Token = "0x4012A4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0__OnRevMapMarkResponse;

			// Token: 0x04012A4D RID: 76365
			[Token(Token = "0x4012A4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0__ApplyOprt_Character;

			// Token: 0x04012A4E RID: 76366
			[Token(Token = "0x4012A4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0__ApplyOprt_DummyDragMate;

			// Token: 0x04012A4F RID: 76367
			[Token(Token = "0x4012A4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0__FinishDummyWhenDisable;

			// Token: 0x04012A50 RID: 76368
			[Token(Token = "0x4012A50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0__ApplyOprt_Cost;

			// Token: 0x04012A51 RID: 76369
			[Token(Token = "0x4012A51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0__ApplyCostOprt_Receive;

			// Token: 0x04012A52 RID: 76370
			[Token(Token = "0x4012A52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0__ApplyCostOprt_Accept;

			// Token: 0x04012A53 RID: 76371
			[Token(Token = "0x4012A53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0__ApplyCostOprt_Refuse;

			// Token: 0x04012A54 RID: 76372
			[Token(Token = "0x4012A54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0__ApplyOprt_Pause;

			// Token: 0x04012A55 RID: 76373
			[Token(Token = "0x4012A55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private static DelegateBridge __Hotfix0__ApplyPauseOprt_Receive;

			// Token: 0x04012A56 RID: 76374
			[Token(Token = "0x4012A56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private static DelegateBridge __Hotfix0__ApplyPauseOprt_Accept;

			// Token: 0x04012A57 RID: 76375
			[Token(Token = "0x4012A57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			private static DelegateBridge __Hotfix0__ApplyPauseOprt_Refuse;

			// Token: 0x04012A58 RID: 76376
			[Token(Token = "0x4012A58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private static DelegateBridge __Hotfix0__ApplyPauseOprt_Resume;

			// Token: 0x04012A59 RID: 76377
			[Token(Token = "0x4012A59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private static DelegateBridge __Hotfix0__ApplyOprt_Online;

			// Token: 0x04012A5A RID: 76378
			[Token(Token = "0x4012A5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private static DelegateBridge __Hotfix0__ApplyOprt_SpeedUp;

			// Token: 0x04012A5B RID: 76379
			[Token(Token = "0x4012A5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private static DelegateBridge __Hotfix0__SetPlaySpeed;

			// Token: 0x04012A5C RID: 76380
			[Token(Token = "0x4012A5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private static DelegateBridge __Hotfix0__ApplyOprt_SkipResting;

			// Token: 0x04012A5D RID: 76381
			[Token(Token = "0x4012A5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private static DelegateBridge __Hotfix0_SendSpeedUpRequest;

			// Token: 0x04012A5E RID: 76382
			[Token(Token = "0x4012A5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private static DelegateBridge __Hotfix0_SendPauseResponseRequest;

			// Token: 0x04012A5F RID: 76383
			[Token(Token = "0x4012A5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private static DelegateBridge __Hotfix0_SendCooperatePauseRequest;

			// Token: 0x04012A60 RID: 76384
			[Token(Token = "0x4012A60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			private static DelegateBridge __Hotfix0_SendCooperateRequest;

			// Token: 0x04012A61 RID: 76385
			[Token(Token = "0x4012A61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			private static DelegateBridge __Hotfix0__SendDragDummyOprt;

			// Token: 0x04012A62 RID: 76386
			[Token(Token = "0x4012A62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			private static DelegateBridge __Hotfix0__SendOprtCharacter;

			// Token: 0x04012A63 RID: 76387
			[Token(Token = "0x4012A63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			private static DelegateBridge __Hotfix0_DoCostRequestLocal;

			// Token: 0x04012A64 RID: 76388
			[Token(Token = "0x4012A64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private static DelegateBridge __Hotfix0__HardSetPlayerSpeed;

			// Token: 0x04012A65 RID: 76389
			[Token(Token = "0x4012A65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			private static DelegateBridge __Hotfix0__RefreshSpeed;

			// Token: 0x04012A66 RID: 76390
			[Token(Token = "0x4012A66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private static DelegateBridge __Hotfix0__SetPauseAndSpeedStateWhenPlayerDie;

			// Token: 0x04012A67 RID: 76391
			[Token(Token = "0x4012A67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
			private static DelegateBridge __Hotfix0_get_m_isQuit;

			// Token: 0x04012A68 RID: 76392
			[Token(Token = "0x4012A68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private static DelegateBridge __Hotfix0_get_m_mateIsQuit;

			// Token: 0x04012A69 RID: 76393
			[Token(Token = "0x4012A69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
			private static DelegateBridge __Hotfix0_get_subGameModeType;

			// Token: 0x04012A6A RID: 76394
			[Token(Token = "0x4012A6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private static DelegateBridge __Hotfix0_get_isResting;

			// Token: 0x04012A6B RID: 76395
			[Token(Token = "0x4012A6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
			private static DelegateBridge __Hotfix0_get_isSpeedUp;

			// Token: 0x04012A6C RID: 76396
			[Token(Token = "0x4012A6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private static DelegateBridge __Hotfix0_get_state;

			// Token: 0x04012A6D RID: 76397
			[Token(Token = "0x4012A6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
			private static DelegateBridge __Hotfix0_get_isFail;

			// Token: 0x04012A6E RID: 76398
			[Token(Token = "0x4012A6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private static DelegateBridge __Hotfix0_get_guideOutPut;

			// Token: 0x04012A6F RID: 76399
			[Token(Token = "0x4012A6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
			private static DelegateBridge __Hotfix0_get_normalMgr;

			// Token: 0x04012A70 RID: 76400
			[Token(Token = "0x4012A70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private static DelegateBridge __Hotfix0_get_defenceMgr;

			// Token: 0x04012A71 RID: 76401
			[Token(Token = "0x4012A71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
			private static DelegateBridge __Hotfix0_get_footballMgr;

			// Token: 0x04012A72 RID: 76402
			[Token(Token = "0x4012A72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private static DelegateBridge __Hotfix0_get_sailBoatMgr;

			// Token: 0x04012A73 RID: 76403
			[Token(Token = "0x4012A73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private static DelegateBridge __Hotfix0_get_playerInPauseRequest;

			// Token: 0x04012A74 RID: 76404
			[Token(Token = "0x4012A74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private static DelegateBridge __Hotfix0_set_playerInPauseRequest;

			// Token: 0x04012A75 RID: 76405
			[Token(Token = "0x4012A75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private static DelegateBridge __Hotfix0_get_isInPause;

			// Token: 0x04012A76 RID: 76406
			[Token(Token = "0x4012A76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private static DelegateBridge __Hotfix0_get_playerInCostRequest;

			// Token: 0x04012A77 RID: 76407
			[Token(Token = "0x4012A77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private static DelegateBridge __Hotfix0_set_playerInCostRequest;

			// Token: 0x04012A78 RID: 76408
			[Token(Token = "0x4012A78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private static DelegateBridge __Hotfix0_set_isGiveUp;

			// Token: 0x04012A79 RID: 76409
			[Token(Token = "0x4012A79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private static DelegateBridge __Hotfix0_get_isGiveUp;

			// Token: 0x04012A7A RID: 76410
			[Token(Token = "0x4012A7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private static DelegateBridge __Hotfix0_get_coopProcessor;

			// Token: 0x04012A7B RID: 76411
			[Token(Token = "0x4012A7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
			private static DelegateBridge __Hotfix0_FetchMultiGuideOutPut;

			// Token: 0x04012A7C RID: 76412
			[Token(Token = "0x4012A7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
			private static DelegateBridge __Hotfix0_GetHpForGameCheck;

			// Token: 0x04012A7D RID: 76413
			[Token(Token = "0x4012A7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
			private static DelegateBridge __Hotfix0_OnBeforeWaveStart;

			// Token: 0x04012A7E RID: 76414
			[Token(Token = "0x4012A7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
			private static DelegateBridge __Hotfix0_MakePlayerCharacterRevive;

			// Token: 0x04012A7F RID: 76415
			[Token(Token = "0x4012A7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
			private static DelegateBridge __Hotfix0_OnBeforeEnemyReachExit;

			// Token: 0x04012A80 RID: 76416
			[Token(Token = "0x4012A80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
			private static DelegateBridge __Hotfix0_ReplaceActionKey;

			// Token: 0x04012A81 RID: 76417
			[Token(Token = "0x4012A81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
			private static DelegateBridge __Hotfix0_RecordDefenceBossStatus;

			// Token: 0x04012A82 RID: 76418
			[Token(Token = "0x4012A82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
			private static DelegateBridge __Hotfix0_ClearUnitsOnStageEnd;

			// Token: 0x04012A83 RID: 76419
			[Token(Token = "0x4012A83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
			private static DelegateBridge __Hotfix0_KillUnit;

			// Token: 0x04012A84 RID: 76420
			[Token(Token = "0x4012A84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
			private static DelegateBridge __Hotfix0_GetDefenceBossDamageTaking;

			// Token: 0x04012A85 RID: 76421
			[Token(Token = "0x4012A85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
			private static DelegateBridge __Hotfix0_IsFootballMode;

			// Token: 0x04012A86 RID: 76422
			[Token(Token = "0x4012A86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
			private static DelegateBridge __Hotfix0_IsDefenceMode;

			// Token: 0x04012A87 RID: 76423
			[Token(Token = "0x4012A87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
			private static DelegateBridge __Hotfix0_IsNormalMode;

			// Token: 0x04012A88 RID: 76424
			[Token(Token = "0x4012A88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
			private static DelegateBridge __Hotfix0_IsSailBoatMode;

			// Token: 0x04012A89 RID: 76425
			[Token(Token = "0x4012A89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
			private static DelegateBridge __Hotfix0_IsEnemyInWhiteListWhenClearByMode;

			// Token: 0x04012A8A RID: 76426
			[Token(Token = "0x4012A8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04012A8B RID: 76427
			[Token(Token = "0x4012A8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
			private static DelegateBridge __Hotfix0_get_allowManualTick;

			// Token: 0x04012A8C RID: 76428
			[Token(Token = "0x4012A8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
			private static DelegateBridge __Hotfix0_get_isOnline;

			// Token: 0x04012A8D RID: 76429
			[Token(Token = "0x4012A8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
			private static DelegateBridge __Hotfix0_get_isLargeMap;

			// Token: 0x04012A8E RID: 76430
			[Token(Token = "0x4012A8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
			private static DelegateBridge __Hotfix0_get_enableHudSlowTicker;

			// Token: 0x04012A8F RID: 76431
			[Token(Token = "0x4012A8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
			private static DelegateBridge __Hotfix0_get_allowPoolManagerUnload;

			// Token: 0x04012A90 RID: 76432
			[Token(Token = "0x4012A90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
			private static DelegateBridge __Hotfix0_get_hasExtraBuildCondition;

			// Token: 0x04012A91 RID: 76433
			[Token(Token = "0x4012A91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
			private static DelegateBridge __Hotfix0_get_isSupportSlowMotion;

			// Token: 0x04012A92 RID: 76434
			[Token(Token = "0x4012A92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
			private static DelegateBridge __Hotfix0_get_outlineConfig;

			// Token: 0x04012A93 RID: 76435
			[Token(Token = "0x4012A93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
			private static DelegateBridge __Hotfix0_get_gameModeType;

			// Token: 0x04012A94 RID: 76436
			[Token(Token = "0x4012A94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
			private static DelegateBridge __Hotfix0_get_HookGetNextWave;

			// Token: 0x04012A95 RID: 76437
			[Token(Token = "0x4012A95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
			private static DelegateBridge __Hotfix0_Hook_OnDummyDragging;

			// Token: 0x04012A96 RID: 76438
			[Token(Token = "0x4012A96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x04012A97 RID: 76439
			[Token(Token = "0x4012A97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
			private static DelegateBridge __Hotfix0__RegisterEventListener;

			// Token: 0x04012A98 RID: 76440
			[Token(Token = "0x4012A98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
			private static DelegateBridge __Hotfix0__UnRegisterEventListener;

			// Token: 0x04012A99 RID: 76441
			[Token(Token = "0x4012A99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
			private static DelegateBridge __Hotfix0__CreateSubModeManager;

			// Token: 0x04012A9A RID: 76442
			[Token(Token = "0x4012A9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
			private static DelegateBridge __Hotfix0__GetEnemyWhitelist;

			// Token: 0x04012A9B RID: 76443
			[Token(Token = "0x4012A9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
			private static DelegateBridge __Hotfix0_GetSchedulerPreprocessor;

			// Token: 0x04012A9C RID: 76444
			[Token(Token = "0x4012A9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
			private static DelegateBridge __Hotfix0_StartGame;

			// Token: 0x04012A9D RID: 76445
			[Token(Token = "0x4012A9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
			private static DelegateBridge __Hotfix0_HookPlayerOp_Withdraw;

			// Token: 0x04012A9E RID: 76446
			[Token(Token = "0x4012A9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
			private static DelegateBridge __Hotfix0_HookPlayerOp_Spawn;

			// Token: 0x04012A9F RID: 76447
			[Token(Token = "0x4012A9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
			private static DelegateBridge __Hotfix0_OnUnitRegistered;

			// Token: 0x04012AA0 RID: 76448
			[Token(Token = "0x4012AA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
			private static DelegateBridge __Hotfix0_OnUnitUnregistered;

			// Token: 0x04012AA1 RID: 76449
			[Token(Token = "0x4012AA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
			private static DelegateBridge __Hotfix0_OnDummyTouchedToTile;

			// Token: 0x04012AA2 RID: 76450
			[Token(Token = "0x4012AA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
			private static DelegateBridge __Hotfix0_OnDummySetBodyAndFaceDirection;

			// Token: 0x04012AA3 RID: 76451
			[Token(Token = "0x4012AA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
			private static DelegateBridge __Hotfix0_HookPlayerOp_TrigSkill;

			// Token: 0x04012AA4 RID: 76452
			[Token(Token = "0x4012AA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
			private static DelegateBridge __Hotfix0_HookSpeedLevel;

			// Token: 0x04012AA5 RID: 76453
			[Token(Token = "0x4012AA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
			private static DelegateBridge __Hotfix0_OnCardSpawned;

			// Token: 0x04012AA6 RID: 76454
			[Token(Token = "0x4012AA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
			private static DelegateBridge __Hotfix0_OnCardListChanged;

			// Token: 0x04012AA7 RID: 76455
			[Token(Token = "0x4012AA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
			private static DelegateBridge __Hotfix0_CheckCardReadyToSpawn;

			// Token: 0x04012AA8 RID: 76456
			[Token(Token = "0x4012AA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
			private static DelegateBridge __Hotfix0_OnWaveWillStart;

			// Token: 0x04012AA9 RID: 76457
			[Token(Token = "0x4012AA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
			private static DelegateBridge __Hotfix0_CheckBuildable;

			// Token: 0x04012AAA RID: 76458
			[Token(Token = "0x4012AAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
			private static DelegateBridge __Hotfix0_PreprocessPlayerData;

			// Token: 0x04012AAB RID: 76459
			[Token(Token = "0x4012AAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
			private static DelegateBridge __Hotfix0_PreprocessEnemy;

			// Token: 0x04012AAC RID: 76460
			[Token(Token = "0x4012AAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
			private static DelegateBridge __Hotfix0_PreprocessRuneInput;

			// Token: 0x04012AAD RID: 76461
			[Token(Token = "0x4012AAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
			private static DelegateBridge __Hotfix0_OnPlayerLifeToZero;

			// Token: 0x04012AAE RID: 76462
			[Token(Token = "0x4012AAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
			private static DelegateBridge __Hotfix0_FinishGame;

			// Token: 0x04012AAF RID: 76463
			[Token(Token = "0x4012AAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
			private static DelegateBridge __Hotfix0_TryHookCheckWaveNotFinish;

			// Token: 0x04012AB0 RID: 76464
			[Token(Token = "0x4012AB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
			private static DelegateBridge __Hotfix0_GetModeTileEffect;

			// Token: 0x04012AB1 RID: 76465
			[Token(Token = "0x4012AB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
			private static DelegateBridge __Hotfix0_OnWaveWillFinish;

			// Token: 0x04012AB2 RID: 76466
			[Token(Token = "0x4012AB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
			private static DelegateBridge __Hotfix0_OnApplyingGlobalModifier;

			// Token: 0x04012AB3 RID: 76467
			[Token(Token = "0x4012AB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
			private static DelegateBridge __Hotfix0_OnEnemyReachExit;

			// Token: 0x04012AB4 RID: 76468
			[Token(Token = "0x4012AB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
			private static DelegateBridge __Hotfix0_TryShowTileInfoToast;

			// Token: 0x04012AB5 RID: 76469
			[Token(Token = "0x4012AB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
			private static DelegateBridge __Hotfix0_GatherGlobalBuffs;

			// Token: 0x04012AB6 RID: 76470
			[Token(Token = "0x4012AB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
			private static DelegateBridge __Hotfix0_TryGetNextWaveIndexInGameMode;

			// Token: 0x04012AB7 RID: 76471
			[Token(Token = "0x4012AB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
			private static DelegateBridge __Hotfix0_CheckRenderInvisible;

			// Token: 0x04012AB8 RID: 76472
			[Token(Token = "0x4012AB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
			private static DelegateBridge __Hotfix0__OnCharacterUseSkill;

			// Token: 0x04012AB9 RID: 76473
			[Token(Token = "0x4012AB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
			private static DelegateBridge __Hotfix0__MakePlayerCharacterDying;

			// Token: 0x04012ABA RID: 76474
			[Token(Token = "0x4012ABA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
			private static DelegateBridge __Hotfix0__CollectModifier;

			// Token: 0x04012ABB RID: 76475
			[Token(Token = "0x4012ABB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
			private static DelegateBridge __Hotfix0_IsMultiplayerLocal;

			// Token: 0x04012ABC RID: 76476
			[Token(Token = "0x4012ABC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
			private static DelegateBridge __Hotfix0_OnPostInit;

			// Token: 0x04012ABD RID: 76477
			[Token(Token = "0x4012ABD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
			private static DelegateBridge __Hotfix0_Tick;

			// Token: 0x04012ABE RID: 76478
			[Token(Token = "0x4012ABE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
			private static DelegateBridge __Hotfix0_IgnorePauseRequest;

			// Token: 0x04012ABF RID: 76479
			[Token(Token = "0x4012ABF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
			private static DelegateBridge __Hotfix0_ResumePause;

			// Token: 0x04012AC0 RID: 76480
			[Token(Token = "0x4012AC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
			private static DelegateBridge __Hotfix0_GatherPreloadAssets;

			// Token: 0x04012AC1 RID: 76481
			[Token(Token = "0x4012AC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
			private static DelegateBridge __Hotfix0_GetPlayerReviveTimePeriod;

			// Token: 0x04012AC2 RID: 76482
			[Token(Token = "0x4012AC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
			private static DelegateBridge __Hotfix0_GetPlayerReviveTimeRemainingTime;

			// Token: 0x04012AC3 RID: 76483
			[Token(Token = "0x4012AC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
			private static DelegateBridge __Hotfix0_GetIdentityInfo;

			// Token: 0x04012AC4 RID: 76484
			[Token(Token = "0x4012AC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x468")]
			private static DelegateBridge __Hotfix0__GetPlayerDeployCharCnt;

			// Token: 0x04012AC5 RID: 76485
			[Token(Token = "0x4012AC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
			private static DelegateBridge __Hotfix0__LogPlayerDataOnFinishGame;

			// Token: 0x04012AC6 RID: 76486
			[Token(Token = "0x4012AC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x478")]
			private static DelegateBridge __Hotfix0_get_waveHandler;

			// Token: 0x04012AC7 RID: 76487
			[Token(Token = "0x4012AC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
			private static DelegateBridge __Hotfix0_GetCurLevel;

			// Token: 0x04012AC8 RID: 76488
			[Token(Token = "0x4012AC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
			private static DelegateBridge __Hotfix0_UpgradePlayerBuffLevel;

			// Token: 0x04012AC9 RID: 76489
			[Token(Token = "0x4012AC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
			private static DelegateBridge __Hotfix0_OnDestroy;

			// Token: 0x04012ACA RID: 76490
			[Token(Token = "0x4012ACA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
			private static DelegateBridge __Hotfix0__UnloadPool;

			// Token: 0x04012ACB RID: 76491
			[Token(Token = "0x4012ACB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
			private static DelegateBridge __Hotfix0_CheckLastWave;

			// Token: 0x04012ACC RID: 76492
			[Token(Token = "0x4012ACC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
			private static DelegateBridge __Hotfix0_RegistStageBuff;

			// Token: 0x04012ACD RID: 76493
			[Token(Token = "0x4012ACD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
			private static DelegateBridge __Hotfix0_DoPlayerResting;

			// Token: 0x04012ACE RID: 76494
			[Token(Token = "0x4012ACE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
			private static DelegateBridge __Hotfix0_OnRestingFinished;

			// Token: 0x04012ACF RID: 76495
			[Token(Token = "0x4012ACF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
			private static DelegateBridge __Hotfix0_FindMaxDistance;

			// Token: 0x04012AD0 RID: 76496
			[Token(Token = "0x4012AD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
			private static DelegateBridge __Hotfix0_AddSharedEnemyKey;

			// Token: 0x04012AD1 RID: 76497
			[Token(Token = "0x4012AD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
			private static DelegateBridge __Hotfix0_CheckContainsEnemy;

			// Token: 0x04012AD2 RID: 76498
			[Token(Token = "0x4012AD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D8")]
			private static DelegateBridge __Hotfix0_ResetTargetEnemies;

			// Token: 0x04012AD3 RID: 76499
			[Token(Token = "0x4012AD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4E0")]
			private static DelegateBridge __Hotfix0_CheckPlayerDead;

			// Token: 0x020027B5 RID: 10165
			[Token(Token = "0x20027B5")]
			public class CooperateFootballModeManager : GameModeFactory.CooperateGameMode.CooperateSubMode
			{
				// Token: 0x17002490 RID: 9360
				// (get) Token: 0x06010ACD RID: 68301 RVA: 0x00066228 File Offset: 0x00064428
				[Token(Token = "0x17002490")]
				public bool hasScored
				{
					[Token(Token = "0x6010ACD")]
					[Address(RVA = "0x87D580", Offset = "0x87C180", VA = "0x18087D580")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17002491 RID: 9361
				// (get) Token: 0x06010ACE RID: 68302 RVA: 0x00066240 File Offset: 0x00064440
				[Token(Token = "0x17002491")]
				public FP footballMaxPlayTime
				{
					[Token(Token = "0x6010ACE")]
					[Address(RVA = "0x87D4C0", Offset = "0x87C0C0", VA = "0x18087D4C0")]
					get
					{
						return default(FP);
					}
				}

				// Token: 0x17002492 RID: 9362
				// (get) Token: 0x06010ACF RID: 68303 RVA: 0x00066258 File Offset: 0x00064458
				[Token(Token = "0x17002492")]
				public FP footballRemainTime
				{
					[Token(Token = "0x6010ACF")]
					[Address(RVA = "0x87D520", Offset = "0x87C120", VA = "0x18087D520")]
					get
					{
						return default(FP);
					}
				}

				// Token: 0x17002493 RID: 9363
				// (get) Token: 0x06010AD0 RID: 68304 RVA: 0x00066270 File Offset: 0x00064470
				[Token(Token = "0x17002493")]
				public SideTypeIndex cachedScoreSideTypeIndex
				{
					[Token(Token = "0x6010AD0")]
					[Address(RVA = "0x87D460", Offset = "0x87C060", VA = "0x18087D460")]
					get
					{
						return SideTypeIndex.ALLY;
					}
				}

				// Token: 0x06010AD1 RID: 68305 RVA: 0x00066288 File Offset: 0x00064488
				[Token(Token = "0x6010AD1")]
				[Address(RVA = "0x87B4C0", Offset = "0x87A0C0", VA = "0x18087B4C0", Slot = "5")]
				public override bool HookGetNextWave()
				{
					return default(bool);
				}

				// Token: 0x06010AD2 RID: 68306 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010AD2")]
				[Address(RVA = "0x87B5F0", Offset = "0x87A1F0", VA = "0x18087B5F0", Slot = "4")]
				public override void Init(GameModeFactory.CooperateGameMode gameMode, LevelData levelData, ActMultiV3Data actData)
				{
				}

				// Token: 0x06010AD3 RID: 68307 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010AD3")]
				[Address(RVA = "0x87B530", Offset = "0x87A130", VA = "0x18087B530")]
				public void InitFootball(Vector2 position, FootballEnemy enemy)
				{
				}

				// Token: 0x06010AD4 RID: 68308 RVA: 0x000662A0 File Offset: 0x000644A0
				[Token(Token = "0x6010AD4")]
				[Address(RVA = "0x87CA40", Offset = "0x87B640", VA = "0x18087CA40", Slot = "6")]
				public override bool TryGetNextWaveIndexInGameMode(out int index)
				{
					return default(bool);
				}

				// Token: 0x06010AD5 RID: 68309 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010AD5")]
				[Address(RVA = "0x87C890", Offset = "0x87B490", VA = "0x18087C890", Slot = "8")]
				public override void OnWaveWillStart(LevelData.WaveData waveData)
				{
				}

				// Token: 0x06010AD6 RID: 68310 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010AD6")]
				[Address(RVA = "0x87C810", Offset = "0x87B410", VA = "0x18087C810", Slot = "9")]
				public override void OnWaveWillFinish(LevelData.WaveData waveData)
				{
				}

				// Token: 0x06010AD7 RID: 68311 RVA: 0x000662B8 File Offset: 0x000644B8
				[Token(Token = "0x6010AD7")]
				[Address(RVA = "0x87C2E0", Offset = "0x87AEE0", VA = "0x18087C2E0", Slot = "12")]
				public override int OnGetHpForGameCheck()
				{
					return 0;
				}

				// Token: 0x06010AD8 RID: 68312 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010AD8")]
				[Address(RVA = "0x87BF80", Offset = "0x87AB80", VA = "0x18087BF80")]
				public void OnFootballManualTick(FP deltaTime)
				{
				}

				// Token: 0x06010AD9 RID: 68313 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010AD9")]
				[Address(RVA = "0x87B740", Offset = "0x87A340", VA = "0x18087B740")]
				public void LandFootball(Vector2 position, bool force = false)
				{
				}

				// Token: 0x06010ADA RID: 68314 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010ADA")]
				[Address(RVA = "0x87BA80", Offset = "0x87A680", VA = "0x18087BA80")]
				public void OnAllyHoldFootball(FP holdingFootballRemainTime, Tile tile, PlayerSide playerSide)
				{
				}

				// Token: 0x06010ADB RID: 68315 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010ADB")]
				[Address(RVA = "0x87C360", Offset = "0x87AF60", VA = "0x18087C360")]
				public void OnScoreAGoal(SideTypeIndex sideTypeIndex, int value)
				{
				}

				// Token: 0x06010ADC RID: 68316 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010ADC")]
				[Address(RVA = "0x87C4B0", Offset = "0x87B0B0", VA = "0x18087C4B0")]
				public void OnScoreFinished()
				{
				}

				// Token: 0x06010ADD RID: 68317 RVA: 0x000662D0 File Offset: 0x000644D0
				[Token(Token = "0x6010ADD")]
				[Address(RVA = "0x87B430", Offset = "0x87A030", VA = "0x18087B430")]
				public int GetGoal(SideTypeIndex side)
				{
					return 0;
				}

				// Token: 0x06010ADE RID: 68318 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010ADE")]
				[Address(RVA = "0x87BED0", Offset = "0x87AAD0", VA = "0x18087BED0", Slot = "18")]
				public override IEnumerator OnBeforeWaveStart()
				{
					return null;
				}

				// Token: 0x06010ADF RID: 68319 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010ADF")]
				[Address(RVA = "0x87CD30", Offset = "0x87B930", VA = "0x18087CD30")]
				private void _DoLandFootball()
				{
				}

				// Token: 0x06010AE0 RID: 68320 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010AE0")]
				[Address(RVA = "0x87CEE0", Offset = "0x87BAE0", VA = "0x18087CEE0")]
				private void _InitLandFootballPosition(GridPosition holdFootballGridPos)
				{
				}

				// Token: 0x06010AE1 RID: 68321 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010AE1")]
				[Address(RVA = "0x87D0A0", Offset = "0x87BCA0", VA = "0x18087D0A0")]
				private void _ProcessDeckOnScoreFinished(Deck deck)
				{
				}

				// Token: 0x06010AE2 RID: 68322 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010AE2")]
				[Address(RVA = "0x87D230", Offset = "0x87BE30", VA = "0x18087D230")]
				public CooperateFootballModeManager()
				{
				}

				// Token: 0x06010AE3 RID: 68323 RVA: 0x000662E8 File Offset: 0x000644E8
				[Token(Token = "0x6010AE3")]
				[Address(RVA = "0x87A940", Offset = "0x879540", VA = "0x18087A940")]
				private bool <>xLuaBaseProxy_HookGetNextWave()
				{
					return default(bool);
				}

				// Token: 0x06010AE4 RID: 68324 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010AE4")]
				[Address(RVA = "0x87A9A0", Offset = "0x8795A0", VA = "0x18087A9A0")]
				private void <>xLuaBaseProxy_Init(GameModeFactory.CooperateGameMode P0, LevelData P1, ActMultiV3Data P2)
				{
				}

				// Token: 0x06010AE5 RID: 68325 RVA: 0x00066300 File Offset: 0x00064500
				[Token(Token = "0x6010AE5")]
				[Address(RVA = "0x87CCC0", Offset = "0x87B8C0", VA = "0x18087CCC0")]
				private bool <>xLuaBaseProxy_TryGetNextWaveIndexInGameMode(out int P0)
				{
					return default(bool);
				}

				// Token: 0x06010AE6 RID: 68326 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010AE6")]
				[Address(RVA = "0x87AA80", Offset = "0x879680", VA = "0x18087AA80")]
				private void <>xLuaBaseProxy_OnWaveWillStart(LevelData.WaveData P0)
				{
				}

				// Token: 0x06010AE7 RID: 68327 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010AE7")]
				[Address(RVA = "0x87AA20", Offset = "0x879620", VA = "0x18087AA20")]
				private void <>xLuaBaseProxy_OnWaveWillFinish(LevelData.WaveData P0)
				{
				}

				// Token: 0x06010AE8 RID: 68328 RVA: 0x00066318 File Offset: 0x00064518
				[Token(Token = "0x6010AE8")]
				[Address(RVA = "0x87A9C0", Offset = "0x8795C0", VA = "0x18087A9C0")]
				private int <>xLuaBaseProxy_OnGetHpForGameCheck()
				{
					return 0;
				}

				// Token: 0x06010AE9 RID: 68329 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010AE9")]
				[Address(RVA = "0x87A9B0", Offset = "0x8795B0", VA = "0x18087A9B0")]
				private IEnumerator <>xLuaBaseProxy_OnBeforeWaveStart()
				{
					return null;
				}

				// Token: 0x04012AD4 RID: 76500
				[Token(Token = "0x4012AD4")]
				private const int LAND_FOOTBALL_PREDELAY = 2;

				// Token: 0x04012AD5 RID: 76501
				[Token(Token = "0x4012AD5")]
				private const int FOOTBALL_RESPAWN_COST_MULTI_CNT = 0;

				// Token: 0x04012AD6 RID: 76502
				[Token(Token = "0x4012AD6")]
				private const int FOOTBALL_RESPAWN_COST_MULTIPLIER = 1;

				// Token: 0x04012AD7 RID: 76503
				[Token(Token = "0x4012AD7")]
				private const int FOOTBALL_RESPAWN_COST_MAX_MULTIPLIER = 1;

				// Token: 0x04012AD8 RID: 76504
				[Token(Token = "0x4012AD8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private GameModeFactory.CooperateGameMode m_mode;

				// Token: 0x04012AD9 RID: 76505
				[Token(Token = "0x4012AD9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private SideTypeIndex m_cachedScoreSideTypeIndex;

				// Token: 0x04012ADA RID: 76506
				[Token(Token = "0x4012ADA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private ObjectPtr<FootballEnemy> m_football;

				// Token: 0x04012ADB RID: 76507
				[Token(Token = "0x4012ADB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private FP m_footballMaxPlayTime;

				// Token: 0x04012ADC RID: 76508
				[Token(Token = "0x4012ADC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private FP m_footballRemainTime;

				// Token: 0x04012ADD RID: 76509
				[Token(Token = "0x4012ADD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private FP m_holdingFootballRemainTime;

				// Token: 0x04012ADE RID: 76510
				[Token(Token = "0x4012ADE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private PlayerSide m_holdFootballPlayerSide;

				// Token: 0x04012ADF RID: 76511
				[Token(Token = "0x4012ADF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private PeriodicTimer m_landingFootballTimer;

				// Token: 0x04012AE0 RID: 76512
				[Token(Token = "0x4012AE0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private Deck.Card m_landBallCard;

				// Token: 0x04012AE1 RID: 76513
				[Token(Token = "0x4012AE1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				private Vector2 m_targetLandPosition;

				// Token: 0x04012AE2 RID: 76514
				[Token(Token = "0x4012AE2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private Vector2 m_defaultLandPosition;

				// Token: 0x04012AE3 RID: 76515
				[Token(Token = "0x4012AE3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private bool m_isHoldingFootball;

				// Token: 0x04012AE4 RID: 76516
				[Token(Token = "0x4012AE4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
				private bool m_isLandingFootball;

				// Token: 0x04012AE5 RID: 76517
				[Token(Token = "0x4012AE5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
				private bool m_hasScored;

				// Token: 0x04012AE6 RID: 76518
				[Token(Token = "0x4012AE6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
				private int m_curWave;

				// Token: 0x04012AE7 RID: 76519
				[Token(Token = "0x4012AE7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				private Effect m_cachedLandBallEffect;

				// Token: 0x04012AE8 RID: 76520
				[Token(Token = "0x4012AE8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				private readonly GridPosition m_landBallOffset;

				// Token: 0x04012AE9 RID: 76521
				[Token(Token = "0x4012AE9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				private readonly Blackboard m_enemyScoreBlackboard;

				// Token: 0x04012AEA RID: 76522
				[Token(Token = "0x4012AEA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
				public readonly int[] scoreStatus;

				// Token: 0x04012AEB RID: 76523
				[Token(Token = "0x4012AEB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_hasScored;

				// Token: 0x04012AEC RID: 76524
				[Token(Token = "0x4012AEC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_get_footballMaxPlayTime;

				// Token: 0x04012AED RID: 76525
				[Token(Token = "0x4012AED")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_get_footballRemainTime;

				// Token: 0x04012AEE RID: 76526
				[Token(Token = "0x4012AEE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_get_cachedScoreSideTypeIndex;

				// Token: 0x04012AEF RID: 76527
				[Token(Token = "0x4012AEF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_HookGetNextWave;

				// Token: 0x04012AF0 RID: 76528
				[Token(Token = "0x4012AF0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_Init;

				// Token: 0x04012AF1 RID: 76529
				[Token(Token = "0x4012AF1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_InitFootball;

				// Token: 0x04012AF2 RID: 76530
				[Token(Token = "0x4012AF2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_TryGetNextWaveIndexInGameMode;

				// Token: 0x04012AF3 RID: 76531
				[Token(Token = "0x4012AF3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0_OnWaveWillStart;

				// Token: 0x04012AF4 RID: 76532
				[Token(Token = "0x4012AF4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge __Hotfix0_OnWaveWillFinish;

				// Token: 0x04012AF5 RID: 76533
				[Token(Token = "0x4012AF5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0_OnGetHpForGameCheck;

				// Token: 0x04012AF6 RID: 76534
				[Token(Token = "0x4012AF6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge __Hotfix0_OnFootballManualTick;

				// Token: 0x04012AF7 RID: 76535
				[Token(Token = "0x4012AF7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				private static DelegateBridge __Hotfix0_LandFootball;

				// Token: 0x04012AF8 RID: 76536
				[Token(Token = "0x4012AF8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private static DelegateBridge __Hotfix0_OnAllyHoldFootball;

				// Token: 0x04012AF9 RID: 76537
				[Token(Token = "0x4012AF9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private static DelegateBridge __Hotfix0_OnScoreAGoal;

				// Token: 0x04012AFA RID: 76538
				[Token(Token = "0x4012AFA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				private static DelegateBridge __Hotfix0_OnScoreFinished;

				// Token: 0x04012AFB RID: 76539
				[Token(Token = "0x4012AFB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				private static DelegateBridge __Hotfix0_GetGoal;

				// Token: 0x04012AFC RID: 76540
				[Token(Token = "0x4012AFC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				private static DelegateBridge __Hotfix0_OnBeforeWaveStart;

				// Token: 0x04012AFD RID: 76541
				[Token(Token = "0x4012AFD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
				private static DelegateBridge __Hotfix0__DoLandFootball;

				// Token: 0x04012AFE RID: 76542
				[Token(Token = "0x4012AFE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
				private static DelegateBridge __Hotfix0__InitLandFootballPosition;

				// Token: 0x04012AFF RID: 76543
				[Token(Token = "0x4012AFF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
				private static DelegateBridge __Hotfix0__ProcessDeckOnScoreFinished;

				// Token: 0x04012B00 RID: 76544
				[Token(Token = "0x4012B00")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020027B8 RID: 10168
			[Token(Token = "0x20027B8")]
			public enum SubGameModeType
			{
				// Token: 0x04012B08 RID: 76552
				[Token(Token = "0x4012B08")]
				NORMAL,
				// Token: 0x04012B09 RID: 76553
				[Token(Token = "0x4012B09")]
				FOOTBALL,
				// Token: 0x04012B0A RID: 76554
				[Token(Token = "0x4012B0A")]
				DEFENCE,
				// Token: 0x04012B0B RID: 76555
				[Token(Token = "0x4012B0B")]
				GUIDE_NORMAL,
				// Token: 0x04012B0C RID: 76556
				[Token(Token = "0x4012B0C")]
				GUIDE_FOOTBALL,
				// Token: 0x04012B0D RID: 76557
				[Token(Token = "0x4012B0D")]
				GUIDE_FORTRESS,
				// Token: 0x04012B0E RID: 76558
				[Token(Token = "0x4012B0E")]
				SAIL_BOAT,
				// Token: 0x04012B0F RID: 76559
				[Token(Token = "0x4012B0F")]
				GUIDE_SAIL_BOAT,
				// Token: 0x04012B10 RID: 76560
				[Token(Token = "0x4012B10")]
				ENUM
			}

			// Token: 0x020027B9 RID: 10169
			[Token(Token = "0x20027B9")]
			public struct CooperateIdentityInfo
			{
				// Token: 0x04012B11 RID: 76561
				[Token(Token = "0x4012B11")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public bool inversed;

				// Token: 0x04012B12 RID: 76562
				[Token(Token = "0x4012B12")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string selfIdentityId;

				// Token: 0x04012B13 RID: 76563
				[Token(Token = "0x4012B13")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string oppositeIdentityId;

				// Token: 0x04012B14 RID: 76564
				[Token(Token = "0x4012B14")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public GameModeFactory.CooperateGameMode.SubGameModeType gameModeType;
			}

			// Token: 0x020027BA RID: 10170
			[Token(Token = "0x20027BA")]
			public abstract class CooperateSubMode : IHotfixable
			{
				// Token: 0x06010AF4 RID: 68340 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010AF4")]
				[Address(RVA = "0x883570", Offset = "0x882170", VA = "0x180883570", Slot = "4")]
				public virtual void Init(GameModeFactory.CooperateGameMode gameMode, LevelData levelData, ActMultiV3Data actData)
				{
				}

				// Token: 0x06010AF5 RID: 68341 RVA: 0x00066360 File Offset: 0x00064560
				[Token(Token = "0x6010AF5")]
				[Address(RVA = "0x87A940", Offset = "0x879540", VA = "0x18087A940", Slot = "5")]
				public virtual bool HookGetNextWave()
				{
					return default(bool);
				}

				// Token: 0x06010AF6 RID: 68342 RVA: 0x00066378 File Offset: 0x00064578
				[Token(Token = "0x6010AF6")]
				[Address(RVA = "0x87CCC0", Offset = "0x87B8C0", VA = "0x18087CCC0", Slot = "6")]
				public virtual bool TryGetNextWaveIndexInGameMode(out int index)
				{
					return default(bool);
				}

				// Token: 0x06010AF7 RID: 68343 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010AF7")]
				[Address(RVA = "0x87EE40", Offset = "0x87DA40", VA = "0x18087EE40", Slot = "7")]
				public virtual void OnFinishGame()
				{
				}

				// Token: 0x06010AF8 RID: 68344 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010AF8")]
				[Address(RVA = "0x87AA80", Offset = "0x879680", VA = "0x18087AA80", Slot = "8")]
				public virtual void OnWaveWillStart(LevelData.WaveData waveData)
				{
				}

				// Token: 0x06010AF9 RID: 68345 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010AF9")]
				[Address(RVA = "0x87AA20", Offset = "0x879620", VA = "0x18087AA20", Slot = "9")]
				public virtual void OnWaveWillFinish(LevelData.WaveData waveData)
				{
				}

				// Token: 0x06010AFA RID: 68346 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010AFA")]
				[Address(RVA = "0x881FA0", Offset = "0x880BA0", VA = "0x180881FA0", Slot = "10")]
				public virtual void OnUnitRegistered(Unit unit)
				{
				}

				// Token: 0x06010AFB RID: 68347 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010AFB")]
				[Address(RVA = "0x882000", Offset = "0x880C00", VA = "0x180882000", Slot = "11")]
				public virtual void OnUnitUnregistered(Unit unit)
				{
				}

				// Token: 0x06010AFC RID: 68348 RVA: 0x00066390 File Offset: 0x00064590
				[Token(Token = "0x6010AFC")]
				[Address(RVA = "0x87A9C0", Offset = "0x8795C0", VA = "0x18087A9C0", Slot = "12")]
				public virtual int OnGetHpForGameCheck()
				{
					return 0;
				}

				// Token: 0x06010AFD RID: 68349 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010AFD")]
				[Address(RVA = "0x87AAE0", Offset = "0x8796E0", VA = "0x18087AAE0", Slot = "13")]
				public virtual void RegisterEventListener()
				{
				}

				// Token: 0x06010AFE RID: 68350 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010AFE")]
				[Address(RVA = "0x87AB40", Offset = "0x879740", VA = "0x18087AB40", Slot = "14")]
				public virtual void UnRegisterEventListener()
				{
				}

				// Token: 0x06010AFF RID: 68351 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010AFF")]
				[Address(RVA = "0x881EE0", Offset = "0x880AE0", VA = "0x180881EE0", Slot = "15")]
				public virtual void OnLateManualFrameTick()
				{
				}

				// Token: 0x06010B00 RID: 68352 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B00")]
				[Address(RVA = "0x881F40", Offset = "0x880B40", VA = "0x180881F40", Slot = "16")]
				public virtual void OnModeDestroy()
				{
				}

				// Token: 0x06010B01 RID: 68353 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B01")]
				[Address(RVA = "0x882060", Offset = "0x880C60", VA = "0x180882060", Slot = "17")]
				public virtual void PreprocessEnemy(LevelData.EnemyData data)
				{
				}

				// Token: 0x06010B02 RID: 68354 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010B02")]
				[Address(RVA = "0x883600", Offset = "0x882200", VA = "0x180883600", Slot = "18")]
				public virtual IEnumerator OnBeforeWaveStart()
				{
					return null;
				}

				// Token: 0x06010B03 RID: 68355 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B03")]
				[Address(RVA = "0x883690", Offset = "0x882290", VA = "0x180883690")]
				protected CooperateSubMode()
				{
				}

				// Token: 0x04012B15 RID: 76565
				[Token(Token = "0x4012B15")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_Init;

				// Token: 0x04012B16 RID: 76566
				[Token(Token = "0x4012B16")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_HookGetNextWave;

				// Token: 0x04012B17 RID: 76567
				[Token(Token = "0x4012B17")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_TryGetNextWaveIndexInGameMode;

				// Token: 0x04012B18 RID: 76568
				[Token(Token = "0x4012B18")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_OnFinishGame;

				// Token: 0x04012B19 RID: 76569
				[Token(Token = "0x4012B19")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_OnWaveWillStart;

				// Token: 0x04012B1A RID: 76570
				[Token(Token = "0x4012B1A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_OnWaveWillFinish;

				// Token: 0x04012B1B RID: 76571
				[Token(Token = "0x4012B1B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_OnUnitRegistered;

				// Token: 0x04012B1C RID: 76572
				[Token(Token = "0x4012B1C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_OnUnitUnregistered;

				// Token: 0x04012B1D RID: 76573
				[Token(Token = "0x4012B1D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0_OnGetHpForGameCheck;

				// Token: 0x04012B1E RID: 76574
				[Token(Token = "0x4012B1E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge __Hotfix0_RegisterEventListener;

				// Token: 0x04012B1F RID: 76575
				[Token(Token = "0x4012B1F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0_UnRegisterEventListener;

				// Token: 0x04012B20 RID: 76576
				[Token(Token = "0x4012B20")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge __Hotfix0_OnLateManualFrameTick;

				// Token: 0x04012B21 RID: 76577
				[Token(Token = "0x4012B21")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				private static DelegateBridge __Hotfix0_OnModeDestroy;

				// Token: 0x04012B22 RID: 76578
				[Token(Token = "0x4012B22")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private static DelegateBridge __Hotfix0_PreprocessEnemy;

				// Token: 0x04012B23 RID: 76579
				[Token(Token = "0x4012B23")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private static DelegateBridge __Hotfix0_OnBeforeWaveStart;

				// Token: 0x04012B24 RID: 76580
				[Token(Token = "0x4012B24")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020027BC RID: 10172
			[Token(Token = "0x20027BC")]
			public class CooperateNormalModeManager : GameModeFactory.CooperateGameMode.CooperateSubMode
			{
				// Token: 0x17002498 RID: 9368
				// (get) Token: 0x06010B0A RID: 68362 RVA: 0x000663C0 File Offset: 0x000645C0
				[Token(Token = "0x17002498")]
				public bool isLastWave
				{
					[Token(Token = "0x6010B0A")]
					[Address(RVA = "0x87F5E0", Offset = "0x87E1E0", VA = "0x18087F5E0")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17002499 RID: 9369
				// (get) Token: 0x06010B0B RID: 68363 RVA: 0x000663D8 File Offset: 0x000645D8
				[Token(Token = "0x17002499")]
				public int curStage
				{
					[Token(Token = "0x6010B0B")]
					[Address(RVA = "0x87F360", Offset = "0x87DF60", VA = "0x18087F360")]
					get
					{
						return 0;
					}
				}

				// Token: 0x1700249A RID: 9370
				// (get) Token: 0x06010B0C RID: 68364 RVA: 0x000663F0 File Offset: 0x000645F0
				[Token(Token = "0x1700249A")]
				public int curScore
				{
					[Token(Token = "0x6010B0C")]
					[Address(RVA = "0x87F300", Offset = "0x87DF00", VA = "0x18087F300")]
					get
					{
						return 0;
					}
				}

				// Token: 0x1700249B RID: 9371
				// (get) Token: 0x06010B0D RID: 68365 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x1700249B")]
				public List<int> hpReduce
				{
					[Token(Token = "0x6010B0D")]
					[Address(RVA = "0x87F420", Offset = "0x87E020", VA = "0x18087F420")]
					get
					{
						return null;
					}
				}

				// Token: 0x1700249C RID: 9372
				// (get) Token: 0x06010B0E RID: 68366 RVA: 0x00066408 File Offset: 0x00064608
				[Token(Token = "0x1700249C")]
				public bool isMeFailStage
				{
					[Token(Token = "0x6010B0E")]
					[Address(RVA = "0x87F670", Offset = "0x87E270", VA = "0x18087F670")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x1700249D RID: 9373
				// (get) Token: 0x06010B0F RID: 68367 RVA: 0x00066420 File Offset: 0x00064620
				[Token(Token = "0x1700249D")]
				public int dieTime
				{
					[Token(Token = "0x6010B0F")]
					[Address(RVA = "0x87F3C0", Offset = "0x87DFC0", VA = "0x18087F3C0")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06010B10 RID: 68368 RVA: 0x00066438 File Offset: 0x00064638
				[Token(Token = "0x6010B10")]
				[Address(RVA = "0x87DA60", Offset = "0x87C660", VA = "0x18087DA60", Slot = "5")]
				public override bool HookGetNextWave()
				{
					return default(bool);
				}

				// Token: 0x06010B11 RID: 68369 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B11")]
				[Address(RVA = "0x87DAC0", Offset = "0x87C6C0", VA = "0x18087DAC0", Slot = "4")]
				public override void Init(GameModeFactory.CooperateGameMode gameMode, LevelData levelData, ActMultiV3Data actData)
				{
				}

				// Token: 0x06010B12 RID: 68370 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B12")]
				[Address(RVA = "0x87E9B0", Offset = "0x87D5B0", VA = "0x18087E9B0", Slot = "8")]
				public override void OnWaveWillStart(LevelData.WaveData waveData)
				{
				}

				// Token: 0x06010B13 RID: 68371 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B13")]
				[Address(RVA = "0x87E6E0", Offset = "0x87D2E0", VA = "0x18087E6E0", Slot = "9")]
				public override void OnWaveWillFinish(LevelData.WaveData waveData)
				{
				}

				// Token: 0x06010B14 RID: 68372 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B14")]
				[Address(RVA = "0x87DBE0", Offset = "0x87C7E0", VA = "0x18087DBE0")]
				public void OnApplyingGlobalModifier(ref Modifier modifier)
				{
				}

				// Token: 0x06010B15 RID: 68373 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B15")]
				[Address(RVA = "0x87E020", Offset = "0x87CC20", VA = "0x18087E020")]
				public void OnEnemyReachExit(Enemy enemy, Tile cacheTile)
				{
				}

				// Token: 0x06010B16 RID: 68374 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B16")]
				[Address(RVA = "0x87E450", Offset = "0x87D050", VA = "0x18087E450")]
				public void OnPlayerLifeToZero(PlayerSide side)
				{
				}

				// Token: 0x06010B17 RID: 68375 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B17")]
				[Address(RVA = "0x87E630", Offset = "0x87D230", VA = "0x18087E630")]
				public void OnRestingFinished()
				{
				}

				// Token: 0x06010B18 RID: 68376 RVA: 0x00066450 File Offset: 0x00064650
				[Token(Token = "0x6010B18")]
				[Address(RVA = "0x87E510", Offset = "0x87D110", VA = "0x18087E510")]
				public bool OnRegistStageBuff(ObjectPtr<Buff> buff)
				{
					return default(bool);
				}

				// Token: 0x06010B19 RID: 68377 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B19")]
				[Address(RVA = "0x87E2F0", Offset = "0x87CEF0", VA = "0x18087E2F0", Slot = "7")]
				public override void OnFinishGame()
				{
				}

				// Token: 0x06010B1A RID: 68378 RVA: 0x00066468 File Offset: 0x00064668
				[Token(Token = "0x6010B1A")]
				[Address(RVA = "0x87E3A0", Offset = "0x87CFA0", VA = "0x18087E3A0", Slot = "12")]
				public override int OnGetHpForGameCheck()
				{
					return 0;
				}

				// Token: 0x06010B1B RID: 68379 RVA: 0x00066480 File Offset: 0x00064680
				[Token(Token = "0x6010B1B")]
				[Address(RVA = "0x87D9C0", Offset = "0x87C5C0", VA = "0x18087D9C0")]
				public float FindMaxDistance()
				{
					return 0f;
				}

				// Token: 0x06010B1C RID: 68380 RVA: 0x00066498 File Offset: 0x00064698
				[Token(Token = "0x6010B1C")]
				[Address(RVA = "0x87D920", Offset = "0x87C520", VA = "0x18087D920")]
				public bool CheckContainsEnemy(string enemyId)
				{
					return default(bool);
				}

				// Token: 0x06010B1D RID: 68381 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B1D")]
				[Address(RVA = "0x87EC70", Offset = "0x87D870", VA = "0x18087EC70")]
				public void ResetTargetEnemies(string enemyId)
				{
				}

				// Token: 0x06010B1E RID: 68382 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B1E")]
				[Address(RVA = "0x87DB70", Offset = "0x87C770", VA = "0x18087DB70")]
				public void ModifyStateType(CoopStageType type)
				{
				}

				// Token: 0x06010B1F RID: 68383 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B1F")]
				[Address(RVA = "0x87EEA0", Offset = "0x87DAA0", VA = "0x18087EEA0")]
				public void UpdateScoreManually(int score)
				{
				}

				// Token: 0x06010B20 RID: 68384 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B20")]
				[Address(RVA = "0x87F050", Offset = "0x87DC50", VA = "0x18087F050")]
				private void _ResetStage()
				{
				}

				// Token: 0x06010B21 RID: 68385 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B21")]
				[Address(RVA = "0x87EF50", Offset = "0x87DB50", VA = "0x18087EF50")]
				private void _OnMakePlayerCharacterRevive(PlayerSide side)
				{
				}

				// Token: 0x06010B22 RID: 68386 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B22")]
				[Address(RVA = "0x87DD50", Offset = "0x87C950", VA = "0x18087DD50")]
				public void OnDoPlayerResting()
				{
				}

				// Token: 0x06010B23 RID: 68387 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B23")]
				[Address(RVA = "0x87F0F0", Offset = "0x87DCF0", VA = "0x18087F0F0")]
				public CooperateNormalModeManager()
				{
				}

				// Token: 0x06010B25 RID: 68389 RVA: 0x000664B0 File Offset: 0x000646B0
				[Token(Token = "0x6010B25")]
				[Address(RVA = "0x87A940", Offset = "0x879540", VA = "0x18087A940")]
				private bool <>xLuaBaseProxy_HookGetNextWave()
				{
					return default(bool);
				}

				// Token: 0x06010B26 RID: 68390 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B26")]
				[Address(RVA = "0x87A9A0", Offset = "0x8795A0", VA = "0x18087A9A0")]
				private void <>xLuaBaseProxy_Init(GameModeFactory.CooperateGameMode P0, LevelData P1, ActMultiV3Data P2)
				{
				}

				// Token: 0x06010B27 RID: 68391 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B27")]
				[Address(RVA = "0x87AA80", Offset = "0x879680", VA = "0x18087AA80")]
				private void <>xLuaBaseProxy_OnWaveWillStart(LevelData.WaveData P0)
				{
				}

				// Token: 0x06010B28 RID: 68392 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B28")]
				[Address(RVA = "0x87AA20", Offset = "0x879620", VA = "0x18087AA20")]
				private void <>xLuaBaseProxy_OnWaveWillFinish(LevelData.WaveData P0)
				{
				}

				// Token: 0x06010B29 RID: 68393 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B29")]
				[Address(RVA = "0x87EE40", Offset = "0x87DA40", VA = "0x18087EE40")]
				private void <>xLuaBaseProxy_OnFinishGame()
				{
				}

				// Token: 0x06010B2A RID: 68394 RVA: 0x000664C8 File Offset: 0x000646C8
				[Token(Token = "0x6010B2A")]
				[Address(RVA = "0x87A9C0", Offset = "0x8795C0", VA = "0x18087A9C0")]
				private int <>xLuaBaseProxy_OnGetHpForGameCheck()
				{
					return 0;
				}

				// Token: 0x04012B27 RID: 76583
				[Token(Token = "0x4012B27")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private GameModeFactory.CooperateGameMode m_mode;

				// Token: 0x04012B28 RID: 76584
				[Token(Token = "0x4012B28")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private int m_curWave;

				// Token: 0x04012B29 RID: 76585
				[Token(Token = "0x4012B29")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private int m_curStage;

				// Token: 0x04012B2A RID: 76586
				[Token(Token = "0x4012B2A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private int m_curScore;

				// Token: 0x04012B2B RID: 76587
				[Token(Token = "0x4012B2B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private CoopStageType m_curStageType;

				// Token: 0x04012B2C RID: 76588
				[Token(Token = "0x4012B2C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private ObjectPtr<Buff> m_stageBuff;

				// Token: 0x04012B2D RID: 76589
				[Token(Token = "0x4012B2D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private List<string> m_targetEnemies;

				// Token: 0x04012B2E RID: 76590
				[Token(Token = "0x4012B2E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private int m_dieTime;

				// Token: 0x04012B2F RID: 76591
				[Token(Token = "0x4012B2F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
				private int m_hpReduceMeStage;

				// Token: 0x04012B30 RID: 76592
				[Token(Token = "0x4012B30")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private int m_hpReduceMateStage;

				// Token: 0x04012B31 RID: 76593
				[Token(Token = "0x4012B31")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
				private int m_hpReduceSharedStage;

				// Token: 0x04012B32 RID: 76594
				[Token(Token = "0x4012B32")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private bool m_isMeFailStage;

				// Token: 0x04012B33 RID: 76595
				[Token(Token = "0x4012B33")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private readonly Blackboard m_restingBlackboard;

				// Token: 0x04012B34 RID: 76596
				[Token(Token = "0x4012B34")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_isLastWave;

				// Token: 0x04012B35 RID: 76597
				[Token(Token = "0x4012B35")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_get_curStage;

				// Token: 0x04012B36 RID: 76598
				[Token(Token = "0x4012B36")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_get_curScore;

				// Token: 0x04012B37 RID: 76599
				[Token(Token = "0x4012B37")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_get_hpReduce;

				// Token: 0x04012B38 RID: 76600
				[Token(Token = "0x4012B38")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_get_isMeFailStage;

				// Token: 0x04012B39 RID: 76601
				[Token(Token = "0x4012B39")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_get_dieTime;

				// Token: 0x04012B3A RID: 76602
				[Token(Token = "0x4012B3A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_HookGetNextWave;

				// Token: 0x04012B3B RID: 76603
				[Token(Token = "0x4012B3B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_Init;

				// Token: 0x04012B3C RID: 76604
				[Token(Token = "0x4012B3C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0_OnWaveWillStart;

				// Token: 0x04012B3D RID: 76605
				[Token(Token = "0x4012B3D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge __Hotfix0_OnWaveWillFinish;

				// Token: 0x04012B3E RID: 76606
				[Token(Token = "0x4012B3E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0_OnApplyingGlobalModifier;

				// Token: 0x04012B3F RID: 76607
				[Token(Token = "0x4012B3F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge __Hotfix0_OnEnemyReachExit;

				// Token: 0x04012B40 RID: 76608
				[Token(Token = "0x4012B40")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				private static DelegateBridge __Hotfix0_OnPlayerLifeToZero;

				// Token: 0x04012B41 RID: 76609
				[Token(Token = "0x4012B41")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private static DelegateBridge __Hotfix0_OnRestingFinished;

				// Token: 0x04012B42 RID: 76610
				[Token(Token = "0x4012B42")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private static DelegateBridge __Hotfix0_OnRegistStageBuff;

				// Token: 0x04012B43 RID: 76611
				[Token(Token = "0x4012B43")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				private static DelegateBridge __Hotfix0_OnFinishGame;

				// Token: 0x04012B44 RID: 76612
				[Token(Token = "0x4012B44")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				private static DelegateBridge __Hotfix0_OnGetHpForGameCheck;

				// Token: 0x04012B45 RID: 76613
				[Token(Token = "0x4012B45")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				private static DelegateBridge __Hotfix0_FindMaxDistance;

				// Token: 0x04012B46 RID: 76614
				[Token(Token = "0x4012B46")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
				private static DelegateBridge __Hotfix0_CheckContainsEnemy;

				// Token: 0x04012B47 RID: 76615
				[Token(Token = "0x4012B47")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
				private static DelegateBridge __Hotfix0_ResetTargetEnemies;

				// Token: 0x04012B48 RID: 76616
				[Token(Token = "0x4012B48")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
				private static DelegateBridge __Hotfix0_ModifyStateType;

				// Token: 0x04012B49 RID: 76617
				[Token(Token = "0x4012B49")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
				private static DelegateBridge __Hotfix0_UpdateScoreManually;

				// Token: 0x04012B4A RID: 76618
				[Token(Token = "0x4012B4A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
				private static DelegateBridge __Hotfix0__ResetStage;

				// Token: 0x04012B4B RID: 76619
				[Token(Token = "0x4012B4B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
				private static DelegateBridge __Hotfix0__OnMakePlayerCharacterRevive;

				// Token: 0x04012B4C RID: 76620
				[Token(Token = "0x4012B4C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
				private static DelegateBridge __Hotfix0_OnDoPlayerResting;

				// Token: 0x04012B4D RID: 76621
				[Token(Token = "0x4012B4D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020027BD RID: 10173
			[Token(Token = "0x20027BD")]
			public class CooperateDefenceModeManager : GameModeFactory.CooperateGameMode.CooperateSubMode
			{
				// Token: 0x1700249E RID: 9374
				// (get) Token: 0x06010B2B RID: 68395 RVA: 0x000664E0 File Offset: 0x000646E0
				[Token(Token = "0x1700249E")]
				public bool isLastWave
				{
					[Token(Token = "0x6010B2B")]
					[Address(RVA = "0x87B280", Offset = "0x879E80", VA = "0x18087B280")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x1700249F RID: 9375
				// (get) Token: 0x06010B2C RID: 68396 RVA: 0x000664F8 File Offset: 0x000646F8
				[Token(Token = "0x1700249F")]
				public int curWave
				{
					[Token(Token = "0x6010B2C")]
					[Address(RVA = "0x87B1C0", Offset = "0x879DC0", VA = "0x18087B1C0")]
					get
					{
						return 0;
					}
				}

				// Token: 0x170024A0 RID: 9376
				// (get) Token: 0x06010B2D RID: 68397 RVA: 0x00066510 File Offset: 0x00064710
				[Token(Token = "0x170024A0")]
				public int fortressFinishWave
				{
					[Token(Token = "0x6010B2D")]
					[Address(RVA = "0x87B220", Offset = "0x879E20", VA = "0x18087B220")]
					get
					{
						return 0;
					}
				}

				// Token: 0x170024A1 RID: 9377
				// (get) Token: 0x06010B2E RID: 68398 RVA: 0x00066528 File Offset: 0x00064728
				[Token(Token = "0x170024A1")]
				public FP bossCurHp
				{
					[Token(Token = "0x6010B2E")]
					[Address(RVA = "0x87B100", Offset = "0x879D00", VA = "0x18087B100")]
					get
					{
						return default(FP);
					}
				}

				// Token: 0x170024A2 RID: 9378
				// (get) Token: 0x06010B2F RID: 68399 RVA: 0x00066540 File Offset: 0x00064740
				[Token(Token = "0x170024A2")]
				public FP bossMaxHp
				{
					[Token(Token = "0x6010B2F")]
					[Address(RVA = "0x87B160", Offset = "0x879D60", VA = "0x18087B160")]
					get
					{
						return default(FP);
					}
				}

				// Token: 0x06010B30 RID: 68400 RVA: 0x00066558 File Offset: 0x00064758
				[Token(Token = "0x6010B30")]
				[Address(RVA = "0x879F70", Offset = "0x878B70", VA = "0x180879F70", Slot = "5")]
				public override bool HookGetNextWave()
				{
					return default(bool);
				}

				// Token: 0x06010B31 RID: 68401 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B31")]
				[Address(RVA = "0x879FD0", Offset = "0x878BD0", VA = "0x180879FD0", Slot = "4")]
				public override void Init(GameModeFactory.CooperateGameMode gameMode, LevelData levelData, ActMultiV3Data actData)
				{
				}

				// Token: 0x06010B32 RID: 68402 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B32")]
				[Address(RVA = "0x87A6C0", Offset = "0x8792C0", VA = "0x18087A6C0", Slot = "8")]
				public override void OnWaveWillStart(LevelData.WaveData waveData)
				{
				}

				// Token: 0x06010B33 RID: 68403 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B33")]
				[Address(RVA = "0x87A640", Offset = "0x879240", VA = "0x18087A640", Slot = "9")]
				public override void OnWaveWillFinish(LevelData.WaveData waveData)
				{
				}

				// Token: 0x06010B34 RID: 68404 RVA: 0x00066570 File Offset: 0x00064770
				[Token(Token = "0x6010B34")]
				[Address(RVA = "0x87A3B0", Offset = "0x878FB0", VA = "0x18087A3B0", Slot = "12")]
				public override int OnGetHpForGameCheck()
				{
					return 0;
				}

				// Token: 0x06010B35 RID: 68405 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B35")]
				[Address(RVA = "0x87A840", Offset = "0x879440", VA = "0x18087A840", Slot = "13")]
				public override void RegisterEventListener()
				{
				}

				// Token: 0x06010B36 RID: 68406 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B36")]
				[Address(RVA = "0x87ABA0", Offset = "0x8797A0", VA = "0x18087ABA0", Slot = "14")]
				public override void UnRegisterEventListener()
				{
				}

				// Token: 0x06010B37 RID: 68407 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B37")]
				[Address(RVA = "0x87A300", Offset = "0x878F00", VA = "0x18087A300")]
				public void OnCardListChanged(Deck.Card card)
				{
				}

				// Token: 0x06010B38 RID: 68408 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B38")]
				[Address(RVA = "0x87A4C0", Offset = "0x8790C0", VA = "0x18087A4C0")]
				public void OnTryHookCheckWaveNotFinish(bool schedulerResult)
				{
				}

				// Token: 0x06010B39 RID: 68409 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B39")]
				[Address(RVA = "0x87A460", Offset = "0x879060", VA = "0x18087A460")]
				public void OnRestingFinished()
				{
				}

				// Token: 0x06010B3A RID: 68410 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010B3A")]
				[Address(RVA = "0x87A250", Offset = "0x878E50", VA = "0x18087A250", Slot = "18")]
				public override IEnumerator OnBeforeWaveStart()
				{
					return null;
				}

				// Token: 0x06010B3B RID: 68411 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B3B")]
				[Address(RVA = "0x87A7B0", Offset = "0x8793B0", VA = "0x18087A7B0")]
				public void RecordBossStatus(FP hp, FP maxHp)
				{
				}

				// Token: 0x06010B3C RID: 68412 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B3C")]
				[Address(RVA = "0x87ACA0", Offset = "0x8798A0", VA = "0x18087ACA0")]
				private void _OnUnitBorn(object arg)
				{
				}

				// Token: 0x06010B3D RID: 68413 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B3D")]
				[Address(RVA = "0x87AFC0", Offset = "0x879BC0", VA = "0x18087AFC0")]
				public CooperateDefenceModeManager()
				{
				}

				// Token: 0x06010B3E RID: 68414 RVA: 0x00066588 File Offset: 0x00064788
				[Token(Token = "0x6010B3E")]
				[Address(RVA = "0x87A940", Offset = "0x879540", VA = "0x18087A940")]
				private bool <>xLuaBaseProxy_HookGetNextWave()
				{
					return default(bool);
				}

				// Token: 0x06010B3F RID: 68415 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B3F")]
				[Address(RVA = "0x87A9A0", Offset = "0x8795A0", VA = "0x18087A9A0")]
				private void <>xLuaBaseProxy_Init(GameModeFactory.CooperateGameMode P0, LevelData P1, ActMultiV3Data P2)
				{
				}

				// Token: 0x06010B40 RID: 68416 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B40")]
				[Address(RVA = "0x87AA80", Offset = "0x879680", VA = "0x18087AA80")]
				private void <>xLuaBaseProxy_OnWaveWillStart(LevelData.WaveData P0)
				{
				}

				// Token: 0x06010B41 RID: 68417 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B41")]
				[Address(RVA = "0x87AA20", Offset = "0x879620", VA = "0x18087AA20")]
				private void <>xLuaBaseProxy_OnWaveWillFinish(LevelData.WaveData P0)
				{
				}

				// Token: 0x06010B42 RID: 68418 RVA: 0x000665A0 File Offset: 0x000647A0
				[Token(Token = "0x6010B42")]
				[Address(RVA = "0x87A9C0", Offset = "0x8795C0", VA = "0x18087A9C0")]
				private int <>xLuaBaseProxy_OnGetHpForGameCheck()
				{
					return 0;
				}

				// Token: 0x06010B43 RID: 68419 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B43")]
				[Address(RVA = "0x87AAE0", Offset = "0x8796E0", VA = "0x18087AAE0")]
				private void <>xLuaBaseProxy_RegisterEventListener()
				{
				}

				// Token: 0x06010B44 RID: 68420 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B44")]
				[Address(RVA = "0x87AB40", Offset = "0x879740", VA = "0x18087AB40")]
				private void <>xLuaBaseProxy_UnRegisterEventListener()
				{
				}

				// Token: 0x06010B45 RID: 68421 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010B45")]
				[Address(RVA = "0x87A9B0", Offset = "0x8795B0", VA = "0x18087A9B0")]
				private IEnumerator <>xLuaBaseProxy_OnBeforeWaveStart()
				{
					return null;
				}

				// Token: 0x04012B4E RID: 76622
				[Token(Token = "0x4012B4E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private GameModeFactory.CooperateGameMode m_mode;

				// Token: 0x04012B4F RID: 76623
				[Token(Token = "0x4012B4F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private bool m_rechallengeCurWave;

				// Token: 0x04012B50 RID: 76624
				[Token(Token = "0x4012B50")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private int m_waveIndexInDefenceMode;

				// Token: 0x04012B51 RID: 76625
				[Token(Token = "0x4012B51")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private int m_waveFinishIndex;

				// Token: 0x04012B52 RID: 76626
				[Token(Token = "0x4012B52")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private GameModeFactory.CooperateGameMode.CooperateDefenceModeManager.CooperateFortressFixerBuildableChecker m_tileBuildableChecker;

				// Token: 0x04012B53 RID: 76627
				[Token(Token = "0x4012B53")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private List<GridPosition> m_pinnedTiles;

				// Token: 0x04012B54 RID: 76628
				[Token(Token = "0x4012B54")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private int m_mapWidth;

				// Token: 0x04012B55 RID: 76629
				[Token(Token = "0x4012B55")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
				private int m_mapHeight;

				// Token: 0x04012B56 RID: 76630
				[Token(Token = "0x4012B56")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private FP m_bossCurHp;

				// Token: 0x04012B57 RID: 76631
				[Token(Token = "0x4012B57")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private FP m_bossMaxHp;

				// Token: 0x04012B58 RID: 76632
				[Token(Token = "0x4012B58")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private bool m_waveFinishEventOn;

				// Token: 0x04012B59 RID: 76633
				[Token(Token = "0x4012B59")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_isLastWave;

				// Token: 0x04012B5A RID: 76634
				[Token(Token = "0x4012B5A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_get_curWave;

				// Token: 0x04012B5B RID: 76635
				[Token(Token = "0x4012B5B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_get_fortressFinishWave;

				// Token: 0x04012B5C RID: 76636
				[Token(Token = "0x4012B5C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_get_bossCurHp;

				// Token: 0x04012B5D RID: 76637
				[Token(Token = "0x4012B5D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_get_bossMaxHp;

				// Token: 0x04012B5E RID: 76638
				[Token(Token = "0x4012B5E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_HookGetNextWave;

				// Token: 0x04012B5F RID: 76639
				[Token(Token = "0x4012B5F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_Init;

				// Token: 0x04012B60 RID: 76640
				[Token(Token = "0x4012B60")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_OnWaveWillStart;

				// Token: 0x04012B61 RID: 76641
				[Token(Token = "0x4012B61")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0_OnWaveWillFinish;

				// Token: 0x04012B62 RID: 76642
				[Token(Token = "0x4012B62")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge __Hotfix0_OnGetHpForGameCheck;

				// Token: 0x04012B63 RID: 76643
				[Token(Token = "0x4012B63")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0_RegisterEventListener;

				// Token: 0x04012B64 RID: 76644
				[Token(Token = "0x4012B64")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge __Hotfix0_UnRegisterEventListener;

				// Token: 0x04012B65 RID: 76645
				[Token(Token = "0x4012B65")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				private static DelegateBridge __Hotfix0_OnCardListChanged;

				// Token: 0x04012B66 RID: 76646
				[Token(Token = "0x4012B66")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private static DelegateBridge __Hotfix0_OnTryHookCheckWaveNotFinish;

				// Token: 0x04012B67 RID: 76647
				[Token(Token = "0x4012B67")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private static DelegateBridge __Hotfix0_OnRestingFinished;

				// Token: 0x04012B68 RID: 76648
				[Token(Token = "0x4012B68")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				private static DelegateBridge __Hotfix0_OnBeforeWaveStart;

				// Token: 0x04012B69 RID: 76649
				[Token(Token = "0x4012B69")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				private static DelegateBridge __Hotfix0_RecordBossStatus;

				// Token: 0x04012B6A RID: 76650
				[Token(Token = "0x4012B6A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				private static DelegateBridge __Hotfix0__OnUnitBorn;

				// Token: 0x04012B6B RID: 76651
				[Token(Token = "0x4012B6B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
				private static DelegateBridge _c__Hotfix0_ctor;

				// Token: 0x020027BE RID: 10174
				[Token(Token = "0x20027BE")]
				public class CooperateFortressFixerBuildableChecker : ITileBuildableChecker, IHotfixable
				{
					// Token: 0x06010B46 RID: 68422 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6010B46")]
					[Address(RVA = "0x87D750", Offset = "0x87C350", VA = "0x18087D750")]
					public void OnInit()
					{
					}

					// Token: 0x06010B47 RID: 68423 RVA: 0x000665B8 File Offset: 0x000647B8
					[Token(Token = "0x6010B47")]
					[Address(RVA = "0x87D5E0", Offset = "0x87C1E0", VA = "0x18087D5E0", Slot = "4")]
					public bool IsCharacterBuildableOnTile(Tile tile, BattleCharacterData sourceData)
					{
						return default(bool);
					}

					// Token: 0x06010B48 RID: 68424 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6010B48")]
					[Address(RVA = "0x87D8C0", Offset = "0x87C4C0", VA = "0x18087D8C0")]
					public CooperateFortressFixerBuildableChecker()
					{
					}

					// Token: 0x04012B6C RID: 76652
					[Token(Token = "0x4012B6C")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					private GameModeFactory.CooperateGameMode m_mode;

					// Token: 0x04012B6D RID: 76653
					[Token(Token = "0x4012B6D")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
					private static DelegateBridge __Hotfix0_OnInit;

					// Token: 0x04012B6E RID: 76654
					[Token(Token = "0x4012B6E")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
					private static DelegateBridge __Hotfix0_IsCharacterBuildableOnTile;

					// Token: 0x04012B6F RID: 76655
					[Token(Token = "0x4012B6F")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					private static DelegateBridge _c__Hotfix0_ctor;
				}
			}

			// Token: 0x020027C1 RID: 10177
			[Token(Token = "0x20027C1")]
			public class CooperateSailBoatModeManager : GameModeFactory.CooperateGameMode.CooperateSubMode
			{
				// Token: 0x170024A5 RID: 9381
				// (get) Token: 0x06010B52 RID: 68434 RVA: 0x00066600 File Offset: 0x00064800
				[Token(Token = "0x170024A5")]
				public int score
				{
					[Token(Token = "0x6010B52")]
					[Address(RVA = "0x883500", Offset = "0x882100", VA = "0x180883500")]
					get
					{
						return 0;
					}
				}

				// Token: 0x170024A6 RID: 9382
				// (get) Token: 0x06010B53 RID: 68435 RVA: 0x00066618 File Offset: 0x00064818
				[Token(Token = "0x170024A6")]
				public int originTotalTime
				{
					[Token(Token = "0x6010B53")]
					[Address(RVA = "0x883490", Offset = "0x882090", VA = "0x180883490")]
					get
					{
						return 0;
					}
				}

				// Token: 0x170024A7 RID: 9383
				// (get) Token: 0x06010B54 RID: 68436 RVA: 0x00066630 File Offset: 0x00064830
				[Token(Token = "0x170024A7")]
				public int extraTime
				{
					[Token(Token = "0x6010B54")]
					[Address(RVA = "0x883420", Offset = "0x882020", VA = "0x180883420")]
					get
					{
						return 0;
					}
				}

				// Token: 0x170024A8 RID: 9384
				// (get) Token: 0x06010B55 RID: 68437 RVA: 0x00066648 File Offset: 0x00064848
				[Token(Token = "0x170024A8")]
				public float boatMaxForce
				{
					[Token(Token = "0x6010B55")]
					[Address(RVA = "0x883350", Offset = "0x881F50", VA = "0x180883350")]
					get
					{
						return 0f;
					}
				}

				// Token: 0x06010B56 RID: 68438 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B56")]
				[Address(RVA = "0x880370", Offset = "0x87EF70", VA = "0x180880370", Slot = "4")]
				public override void Init(GameModeFactory.CooperateGameMode gameMode, LevelData levelData, ActMultiV3Data actData)
				{
				}

				// Token: 0x06010B57 RID: 68439 RVA: 0x00066660 File Offset: 0x00064860
				[Token(Token = "0x6010B57")]
				[Address(RVA = "0x880300", Offset = "0x87EF00", VA = "0x180880300", Slot = "5")]
				public override bool HookGetNextWave()
				{
					return default(bool);
				}

				// Token: 0x06010B58 RID: 68440 RVA: 0x00066678 File Offset: 0x00064878
				[Token(Token = "0x6010B58")]
				[Address(RVA = "0x881E50", Offset = "0x880A50", VA = "0x180881E50", Slot = "6")]
				public override bool TryGetNextWaveIndexInGameMode(out int index)
				{
					return default(bool);
				}

				// Token: 0x06010B59 RID: 68441 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B59")]
				[Address(RVA = "0x881C90", Offset = "0x880890", VA = "0x180881C90", Slot = "17")]
				public override void PreprocessEnemy(LevelData.EnemyData data)
				{
				}

				// Token: 0x06010B5A RID: 68442 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B5A")]
				[Address(RVA = "0x880920", Offset = "0x87F520", VA = "0x180880920", Slot = "7")]
				public override void OnFinishGame()
				{
				}

				// Token: 0x06010B5B RID: 68443 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B5B")]
				[Address(RVA = "0x881880", Offset = "0x880480", VA = "0x180881880", Slot = "8")]
				public override void OnWaveWillStart(LevelData.WaveData waveData)
				{
				}

				// Token: 0x06010B5C RID: 68444 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B5C")]
				[Address(RVA = "0x881800", Offset = "0x880400", VA = "0x180881800", Slot = "9")]
				public override void OnWaveWillFinish(LevelData.WaveData waveData)
				{
				}

				// Token: 0x06010B5D RID: 68445 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010B5D")]
				[Address(RVA = "0x880860", Offset = "0x87F460", VA = "0x180880860", Slot = "18")]
				public override IEnumerator OnBeforeWaveStart()
				{
					return null;
				}

				// Token: 0x06010B5E RID: 68446 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B5E")]
				[Address(RVA = "0x8812E0", Offset = "0x87FEE0", VA = "0x1808812E0", Slot = "10")]
				public override void OnUnitRegistered(Unit unit)
				{
				}

				// Token: 0x06010B5F RID: 68447 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B5F")]
				[Address(RVA = "0x881570", Offset = "0x880170", VA = "0x180881570", Slot = "11")]
				public override void OnUnitUnregistered(Unit unit)
				{
				}

				// Token: 0x06010B60 RID: 68448 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B60")]
				[Address(RVA = "0x8809A0", Offset = "0x87F5A0", VA = "0x1808809A0", Slot = "15")]
				public override void OnLateManualFrameTick()
				{
				}

				// Token: 0x06010B61 RID: 68449 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B61")]
				[Address(RVA = "0x880000", Offset = "0x87EC00", VA = "0x180880000")]
				public void DoRealStart()
				{
				}

				// Token: 0x06010B62 RID: 68450 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B62")]
				[Address(RVA = "0x87F770", Offset = "0x87E370", VA = "0x18087F770")]
				public void ApplyDamageByDir(SharedConsts.Direction dir, FP damage)
				{
				}

				// Token: 0x06010B63 RID: 68451 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B63")]
				[Address(RVA = "0x87FA90", Offset = "0x87E690", VA = "0x18087FA90")]
				public void ApplyForce(Vector2 mapPos, int force)
				{
				}

				// Token: 0x06010B64 RID: 68452 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B64")]
				[Address(RVA = "0x87F950", Offset = "0x87E550", VA = "0x18087F950")]
				public void ApplyForceDirectly(Vector2 direct, int force)
				{
				}

				// Token: 0x06010B65 RID: 68453 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B65")]
				[Address(RVA = "0x880610", Offset = "0x87F210", VA = "0x180880610")]
				public void InverseVelocity(bool inverseX, bool inverseY, FP velocity)
				{
				}

				// Token: 0x06010B66 RID: 68454 RVA: 0x00066690 File Offset: 0x00064890
				[Token(Token = "0x6010B66")]
				[Address(RVA = "0x8801E0", Offset = "0x87EDE0", VA = "0x1808801E0")]
				public Vector2 GetVelocity()
				{
					return default(Vector2);
				}

				// Token: 0x06010B67 RID: 68455 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B67")]
				[Address(RVA = "0x87F6D0", Offset = "0x87E2D0", VA = "0x18087F6D0")]
				public void AddScore(int score)
				{
				}

				// Token: 0x06010B68 RID: 68456 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B68")]
				[Address(RVA = "0x8820C0", Offset = "0x880CC0", VA = "0x1808820C0")]
				public void UpdateWaterFlowForce(int waterForce, int level)
				{
				}

				// Token: 0x06010B69 RID: 68457 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B69")]
				[Address(RVA = "0x87FED0", Offset = "0x87EAD0", VA = "0x18087FED0")]
				public void AssignWaterFlowForceInterval(float waterForceInterval)
				{
				}

				// Token: 0x06010B6A RID: 68458 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B6A")]
				[Address(RVA = "0x87FD70", Offset = "0x87E970", VA = "0x18087FD70")]
				public void AssignScoreGoals(List<int> goals)
				{
				}

				// Token: 0x06010B6B RID: 68459 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B6B")]
				[Address(RVA = "0x87FE40", Offset = "0x87EA40", VA = "0x18087FE40")]
				public void AssignScoreThroughBlock(int score)
				{
				}

				// Token: 0x06010B6C RID: 68460 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B6C")]
				[Address(RVA = "0x87FCC0", Offset = "0x87E8C0", VA = "0x18087FCC0")]
				public void AssignGameTime(int totalTime, int extraTime)
				{
				}

				// Token: 0x06010B6D RID: 68461 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010B6D")]
				[Address(RVA = "0x880160", Offset = "0x87ED60", VA = "0x180880160")]
				public List<int> GetScoreGoals()
				{
					return null;
				}

				// Token: 0x06010B6E RID: 68462 RVA: 0x000666A8 File Offset: 0x000648A8
				[Token(Token = "0x6010B6E")]
				[Address(RVA = "0x880080", Offset = "0x87EC80", VA = "0x180880080")]
				public BoatDirection GetBoatExit()
				{
					return BoatDirection.NONE;
				}

				// Token: 0x06010B6F RID: 68463 RVA: 0x000666C0 File Offset: 0x000648C0
				[Token(Token = "0x6010B6F")]
				[Address(RVA = "0x8800F0", Offset = "0x87ECF0", VA = "0x1808800F0")]
				public BoatDirection GetBoatPreviousExit()
				{
					return BoatDirection.NONE;
				}

				// Token: 0x06010B70 RID: 68464 RVA: 0x000666D8 File Offset: 0x000648D8
				[Token(Token = "0x6010B70")]
				[Address(RVA = "0x882AC0", Offset = "0x8816C0", VA = "0x180882AC0")]
				private bool _CheckExitCurMap(Vector2 boatPos)
				{
					return default(bool);
				}

				// Token: 0x06010B71 RID: 68465 RVA: 0x000666F0 File Offset: 0x000648F0
				[Token(Token = "0x6010B71")]
				[Address(RVA = "0x882360", Offset = "0x880F60", VA = "0x180882360")]
				private Vector2 _CalcuBoatCurPos(BoatDirection previousExit)
				{
					return default(Vector2);
				}

				// Token: 0x06010B72 RID: 68466 RVA: 0x00066708 File Offset: 0x00064908
				[Token(Token = "0x6010B72")]
				[Address(RVA = "0x882950", Offset = "0x881550", VA = "0x180882950")]
				private BoatTouchMask _CheckBoatTouchBound(Vector2 boatPos)
				{
					return BoatTouchMask.NONE;
				}

				// Token: 0x06010B73 RID: 68467 RVA: 0x00066720 File Offset: 0x00064920
				[Token(Token = "0x6010B73")]
				[Address(RVA = "0x8825A0", Offset = "0x8811A0", VA = "0x1808825A0")]
				private BoatEdgeDistance _CalcuBoatEdgeDistance(Vector2 boatPos)
				{
					return default(BoatEdgeDistance);
				}

				// Token: 0x06010B74 RID: 68468 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B74")]
				[Address(RVA = "0x882F80", Offset = "0x881B80", VA = "0x180882F80")]
				private void _TriggerSailBoatUIEvent()
				{
				}

				// Token: 0x06010B75 RID: 68469 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B75")]
				[Address(RVA = "0x883060", Offset = "0x881C60", VA = "0x180883060")]
				private void _UpdateBoatInTransitionRegion(bool isInTransitionRegion)
				{
				}

				// Token: 0x06010B76 RID: 68470 RVA: 0x00066738 File Offset: 0x00064938
				[Token(Token = "0x6010B76")]
				[Address(RVA = "0x8826D0", Offset = "0x8812D0", VA = "0x1808826D0")]
				private GameModeFactory.CooperateGameMode.CooperateSailBoatModeManager.BoatSize _CalcuBoatSize(Vector2 centerPos)
				{
					return default(GameModeFactory.CooperateGameMode.CooperateSailBoatModeManager.BoatSize);
				}

				// Token: 0x06010B77 RID: 68471 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B77")]
				[Address(RVA = "0x882DA0", Offset = "0x8819A0", VA = "0x180882DA0")]
				private void _LogDataOnBlockStart()
				{
				}

				// Token: 0x06010B78 RID: 68472 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B78")]
				[Address(RVA = "0x882E70", Offset = "0x881A70", VA = "0x180882E70")]
				private void _LogWaterForceData(int level)
				{
				}

				// Token: 0x06010B79 RID: 68473 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B79")]
				[Address(RVA = "0x8811A0", Offset = "0x87FDA0", VA = "0x1808811A0", Slot = "16")]
				public override void OnModeDestroy()
				{
				}

				// Token: 0x06010B7A RID: 68474 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B7A")]
				[Address(RVA = "0x8831F0", Offset = "0x881DF0", VA = "0x1808831F0")]
				public CooperateSailBoatModeManager()
				{
				}

				// Token: 0x06010B7C RID: 68476 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B7C")]
				[Address(RVA = "0x87A9A0", Offset = "0x8795A0", VA = "0x18087A9A0")]
				private void <>xLuaBaseProxy_Init(GameModeFactory.CooperateGameMode P0, LevelData P1, ActMultiV3Data P2)
				{
				}

				// Token: 0x06010B7D RID: 68477 RVA: 0x00066750 File Offset: 0x00064950
				[Token(Token = "0x6010B7D")]
				[Address(RVA = "0x87A940", Offset = "0x879540", VA = "0x18087A940")]
				private bool <>xLuaBaseProxy_HookGetNextWave()
				{
					return default(bool);
				}

				// Token: 0x06010B7E RID: 68478 RVA: 0x00066768 File Offset: 0x00064968
				[Token(Token = "0x6010B7E")]
				[Address(RVA = "0x87CCC0", Offset = "0x87B8C0", VA = "0x18087CCC0")]
				private bool <>xLuaBaseProxy_TryGetNextWaveIndexInGameMode(out int P0)
				{
					return default(bool);
				}

				// Token: 0x06010B7F RID: 68479 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B7F")]
				[Address(RVA = "0x882060", Offset = "0x880C60", VA = "0x180882060")]
				private void <>xLuaBaseProxy_PreprocessEnemy(LevelData.EnemyData P0)
				{
				}

				// Token: 0x06010B80 RID: 68480 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B80")]
				[Address(RVA = "0x87EE40", Offset = "0x87DA40", VA = "0x18087EE40")]
				private void <>xLuaBaseProxy_OnFinishGame()
				{
				}

				// Token: 0x06010B81 RID: 68481 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B81")]
				[Address(RVA = "0x87AA80", Offset = "0x879680", VA = "0x18087AA80")]
				private void <>xLuaBaseProxy_OnWaveWillStart(LevelData.WaveData P0)
				{
				}

				// Token: 0x06010B82 RID: 68482 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B82")]
				[Address(RVA = "0x87AA20", Offset = "0x879620", VA = "0x18087AA20")]
				private void <>xLuaBaseProxy_OnWaveWillFinish(LevelData.WaveData P0)
				{
				}

				// Token: 0x06010B83 RID: 68483 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010B83")]
				[Address(RVA = "0x87A9B0", Offset = "0x8795B0", VA = "0x18087A9B0")]
				private IEnumerator <>xLuaBaseProxy_OnBeforeWaveStart()
				{
					return null;
				}

				// Token: 0x06010B84 RID: 68484 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B84")]
				[Address(RVA = "0x881FA0", Offset = "0x880BA0", VA = "0x180881FA0")]
				private void <>xLuaBaseProxy_OnUnitRegistered(Unit P0)
				{
				}

				// Token: 0x06010B85 RID: 68485 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B85")]
				[Address(RVA = "0x882000", Offset = "0x880C00", VA = "0x180882000")]
				private void <>xLuaBaseProxy_OnUnitUnregistered(Unit P0)
				{
				}

				// Token: 0x06010B86 RID: 68486 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B86")]
				[Address(RVA = "0x881EE0", Offset = "0x880AE0", VA = "0x180881EE0")]
				private void <>xLuaBaseProxy_OnLateManualFrameTick()
				{
				}

				// Token: 0x06010B87 RID: 68487 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B87")]
				[Address(RVA = "0x881F40", Offset = "0x880B40", VA = "0x180881F40")]
				private void <>xLuaBaseProxy_OnModeDestroy()
				{
				}

				// Token: 0x04012B75 RID: 76661
				[Token(Token = "0x4012B75")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private GameModeFactory.CooperateGameMode m_mode;

				// Token: 0x04012B76 RID: 76662
				[Token(Token = "0x4012B76")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private GameModeFactory.CooperateGameMode.BoatMoveController m_boatMoveCtrl;

				// Token: 0x04012B77 RID: 76663
				[Token(Token = "0x4012B77")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private SideTypeIndex m_cachedScoreSideTypeIndex;

				// Token: 0x04012B78 RID: 76664
				[Token(Token = "0x4012B78")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private int m_curWave;

				// Token: 0x04012B79 RID: 76665
				[Token(Token = "0x4012B79")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private int m_totalWave;

				// Token: 0x04012B7A RID: 76666
				[Token(Token = "0x4012B7A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private bool m_skipCurWave;

				// Token: 0x04012B7B RID: 76667
				[Token(Token = "0x4012B7B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private GameModeFactory.CooperateGameMode.CooperateSailBoatModeManager.BoatSize m_sizeOfBoat;

				// Token: 0x04012B7C RID: 76668
				[Token(Token = "0x4012B7C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private BoatDirection m_boatExit;

				// Token: 0x04012B7D RID: 76669
				[Token(Token = "0x4012B7D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
				private BoatDirection m_previousExit;

				// Token: 0x04012B7E RID: 76670
				[Token(Token = "0x4012B7E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private bool m_isInTransitionRegion;

				// Token: 0x04012B7F RID: 76671
				[Token(Token = "0x4012B7F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
				private int m_score;

				// Token: 0x04012B80 RID: 76672
				[Token(Token = "0x4012B80")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				private bool m_scoreChanged;

				// Token: 0x04012B81 RID: 76673
				[Token(Token = "0x4012B81")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
				private int m_scoreThroughBlock;

				// Token: 0x04012B82 RID: 76674
				[Token(Token = "0x4012B82")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private List<int> m_scoreGoalList;

				// Token: 0x04012B83 RID: 76675
				[Token(Token = "0x4012B83")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private int m_originTotalTime;

				// Token: 0x04012B84 RID: 76676
				[Token(Token = "0x4012B84")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
				private int m_extraTime;

				// Token: 0x04012B85 RID: 76677
				[Token(Token = "0x4012B85")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static int MAP_SIZE_REACHABLE;

				// Token: 0x04012B86 RID: 76678
				[Token(Token = "0x4012B86")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				private static int MAP_SIZE_MAX;

				// Token: 0x04012B87 RID: 76679
				[Token(Token = "0x4012B87")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static int BOAT_EXIT_MAP_OFFSET;

				// Token: 0x04012B88 RID: 76680
				[Token(Token = "0x4012B88")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				private static int BOAT_ENTER_TRAN_OFFSET;

				// Token: 0x04012B89 RID: 76681
				[Token(Token = "0x4012B89")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static readonly float POS_OFFSET;

				// Token: 0x04012B8A RID: 76682
				[Token(Token = "0x4012B8A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				private static readonly float MAP_START_OFFSET;

				// Token: 0x04012B8B RID: 76683
				[Token(Token = "0x4012B8B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_get_score;

				// Token: 0x04012B8C RID: 76684
				[Token(Token = "0x4012B8C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_get_originTotalTime;

				// Token: 0x04012B8D RID: 76685
				[Token(Token = "0x4012B8D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_get_extraTime;

				// Token: 0x04012B8E RID: 76686
				[Token(Token = "0x4012B8E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_get_boatMaxForce;

				// Token: 0x04012B8F RID: 76687
				[Token(Token = "0x4012B8F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_Init;

				// Token: 0x04012B90 RID: 76688
				[Token(Token = "0x4012B90")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0_HookGetNextWave;

				// Token: 0x04012B91 RID: 76689
				[Token(Token = "0x4012B91")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge __Hotfix0_TryGetNextWaveIndexInGameMode;

				// Token: 0x04012B92 RID: 76690
				[Token(Token = "0x4012B92")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0_PreprocessEnemy;

				// Token: 0x04012B93 RID: 76691
				[Token(Token = "0x4012B93")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge __Hotfix0_OnFinishGame;

				// Token: 0x04012B94 RID: 76692
				[Token(Token = "0x4012B94")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				private static DelegateBridge __Hotfix0_OnWaveWillStart;

				// Token: 0x04012B95 RID: 76693
				[Token(Token = "0x4012B95")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private static DelegateBridge __Hotfix0_OnWaveWillFinish;

				// Token: 0x04012B96 RID: 76694
				[Token(Token = "0x4012B96")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private static DelegateBridge __Hotfix0_OnBeforeWaveStart;

				// Token: 0x04012B97 RID: 76695
				[Token(Token = "0x4012B97")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				private static DelegateBridge __Hotfix0_OnUnitRegistered;

				// Token: 0x04012B98 RID: 76696
				[Token(Token = "0x4012B98")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				private static DelegateBridge __Hotfix0_OnUnitUnregistered;

				// Token: 0x04012B99 RID: 76697
				[Token(Token = "0x4012B99")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				private static DelegateBridge __Hotfix0_OnLateManualFrameTick;

				// Token: 0x04012B9A RID: 76698
				[Token(Token = "0x4012B9A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
				private static DelegateBridge __Hotfix0_DoRealStart;

				// Token: 0x04012B9B RID: 76699
				[Token(Token = "0x4012B9B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
				private static DelegateBridge __Hotfix0_ApplyDamageByDir;

				// Token: 0x04012B9C RID: 76700
				[Token(Token = "0x4012B9C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
				private static DelegateBridge __Hotfix0_ApplyForce;

				// Token: 0x04012B9D RID: 76701
				[Token(Token = "0x4012B9D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
				private static DelegateBridge __Hotfix0_ApplyForceDirectly;

				// Token: 0x04012B9E RID: 76702
				[Token(Token = "0x4012B9E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
				private static DelegateBridge __Hotfix0_InverseVelocity;

				// Token: 0x04012B9F RID: 76703
				[Token(Token = "0x4012B9F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
				private static DelegateBridge __Hotfix0_GetVelocity;

				// Token: 0x04012BA0 RID: 76704
				[Token(Token = "0x4012BA0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
				private static DelegateBridge __Hotfix0_AddScore;

				// Token: 0x04012BA1 RID: 76705
				[Token(Token = "0x4012BA1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
				private static DelegateBridge __Hotfix0_UpdateWaterFlowForce;

				// Token: 0x04012BA2 RID: 76706
				[Token(Token = "0x4012BA2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
				private static DelegateBridge __Hotfix0_AssignWaterFlowForceInterval;

				// Token: 0x04012BA3 RID: 76707
				[Token(Token = "0x4012BA3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
				private static DelegateBridge __Hotfix0_AssignScoreGoals;

				// Token: 0x04012BA4 RID: 76708
				[Token(Token = "0x4012BA4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
				private static DelegateBridge __Hotfix0_AssignScoreThroughBlock;

				// Token: 0x04012BA5 RID: 76709
				[Token(Token = "0x4012BA5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
				private static DelegateBridge __Hotfix0_AssignGameTime;

				// Token: 0x04012BA6 RID: 76710
				[Token(Token = "0x4012BA6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
				private static DelegateBridge __Hotfix0_GetScoreGoals;

				// Token: 0x04012BA7 RID: 76711
				[Token(Token = "0x4012BA7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
				private static DelegateBridge __Hotfix0_GetBoatExit;

				// Token: 0x04012BA8 RID: 76712
				[Token(Token = "0x4012BA8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
				private static DelegateBridge __Hotfix0_GetBoatPreviousExit;

				// Token: 0x04012BA9 RID: 76713
				[Token(Token = "0x4012BA9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
				private static DelegateBridge __Hotfix0__CheckExitCurMap;

				// Token: 0x04012BAA RID: 76714
				[Token(Token = "0x4012BAA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
				private static DelegateBridge __Hotfix0__CalcuBoatCurPos;

				// Token: 0x04012BAB RID: 76715
				[Token(Token = "0x4012BAB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
				private static DelegateBridge __Hotfix0__CheckBoatTouchBound;

				// Token: 0x04012BAC RID: 76716
				[Token(Token = "0x4012BAC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
				private static DelegateBridge __Hotfix0__CalcuBoatEdgeDistance;

				// Token: 0x04012BAD RID: 76717
				[Token(Token = "0x4012BAD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
				private static DelegateBridge __Hotfix0__TriggerSailBoatUIEvent;

				// Token: 0x04012BAE RID: 76718
				[Token(Token = "0x4012BAE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
				private static DelegateBridge __Hotfix0__UpdateBoatInTransitionRegion;

				// Token: 0x04012BAF RID: 76719
				[Token(Token = "0x4012BAF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
				private static DelegateBridge __Hotfix0__CalcuBoatSize;

				// Token: 0x04012BB0 RID: 76720
				[Token(Token = "0x4012BB0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
				private static DelegateBridge __Hotfix0__LogDataOnBlockStart;

				// Token: 0x04012BB1 RID: 76721
				[Token(Token = "0x4012BB1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
				private static DelegateBridge __Hotfix0__LogWaterForceData;

				// Token: 0x04012BB2 RID: 76722
				[Token(Token = "0x4012BB2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
				private static DelegateBridge __Hotfix0_OnModeDestroy;

				// Token: 0x04012BB3 RID: 76723
				[Token(Token = "0x4012BB3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
				private static DelegateBridge _c__Hotfix0_ctor;

				// Token: 0x020027C2 RID: 10178
				[Token(Token = "0x20027C2")]
				public struct BoatSize
				{
					// Token: 0x170024A9 RID: 9385
					// (get) Token: 0x06010B88 RID: 68488 RVA: 0x00066780 File Offset: 0x00064980
					// (set) Token: 0x06010B89 RID: 68489 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x170024A9")]
					public float up
					{
						[Token(Token = "0x6010B88")]
						[Address(RVA = "0x877290", Offset = "0x875E90", VA = "0x180877290")]
						[CompilerGenerated]
						readonly get
						{
							return 0f;
						}
						[Token(Token = "0x6010B89")]
						[Address(RVA = "0x8772C0", Offset = "0x875EC0", VA = "0x1808772C0")]
						[CompilerGenerated]
						private set
						{
						}
					}

					// Token: 0x170024AA RID: 9386
					// (get) Token: 0x06010B8A RID: 68490 RVA: 0x00066798 File Offset: 0x00064998
					// (set) Token: 0x06010B8B RID: 68491 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x170024AA")]
					public float right
					{
						[Token(Token = "0x6010B8A")]
						[Address(RVA = "0x877280", Offset = "0x875E80", VA = "0x180877280")]
						[CompilerGenerated]
						readonly get
						{
							return 0f;
						}
						[Token(Token = "0x6010B8B")]
						[Address(RVA = "0x8772B0", Offset = "0x875EB0", VA = "0x1808772B0")]
						[CompilerGenerated]
						private set
						{
						}
					}

					// Token: 0x170024AB RID: 9387
					// (get) Token: 0x06010B8C RID: 68492 RVA: 0x000667B0 File Offset: 0x000649B0
					// (set) Token: 0x06010B8D RID: 68493 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x170024AB")]
					public float down
					{
						[Token(Token = "0x6010B8C")]
						[Address(RVA = "0x5DE4D0", Offset = "0x5DD0D0", VA = "0x1805DE4D0")]
						[CompilerGenerated]
						readonly get
						{
							return 0f;
						}
						[Token(Token = "0x6010B8D")]
						[Address(RVA = "0x5DE4E0", Offset = "0x5DD0E0", VA = "0x1805DE4E0")]
						[CompilerGenerated]
						private set
						{
						}
					}

					// Token: 0x170024AC RID: 9388
					// (get) Token: 0x06010B8E RID: 68494 RVA: 0x000667C8 File Offset: 0x000649C8
					// (set) Token: 0x06010B8F RID: 68495 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x170024AC")]
					public float left
					{
						[Token(Token = "0x6010B8E")]
						[Address(RVA = "0x877270", Offset = "0x875E70", VA = "0x180877270")]
						[CompilerGenerated]
						readonly get
						{
							return 0f;
						}
						[Token(Token = "0x6010B8F")]
						[Address(RVA = "0x8772A0", Offset = "0x875EA0", VA = "0x1808772A0")]
						[CompilerGenerated]
						private set
						{
						}
					}

					// Token: 0x06010B90 RID: 68496 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6010B90")]
					[Address(RVA = "0x876ED0", Offset = "0x875AD0", VA = "0x180876ED0")]
					public BoatSize(Vector2 centerPos, HashSet<Vector2> boatSizeList)
					{
					}

					// Token: 0x06010B91 RID: 68497 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6010B91")]
					[Address(RVA = "0x876B00", Offset = "0x875700", VA = "0x180876B00")]
					public void AddBoatPos(Vector2 pos)
					{
					}

					// Token: 0x06010B92 RID: 68498 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6010B92")]
					[Address(RVA = "0x876B90", Offset = "0x875790", VA = "0x180876B90")]
					public void RemoveBoatPos(Vector2 pos)
					{
					}

					// Token: 0x06010B93 RID: 68499 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6010B93")]
					[Address(RVA = "0x876C20", Offset = "0x875820", VA = "0x180876C20")]
					private void _UpdateSize()
					{
					}

					// Token: 0x04012BB8 RID: 76728
					[Token(Token = "0x4012BB8")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					private Vector2 m_centerPos;

					// Token: 0x04012BB9 RID: 76729
					[Token(Token = "0x4012BB9")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
					private HashSet<Vector2Int> m_boatPosSet;
				}
			}

			// Token: 0x020027C5 RID: 10181
			[Token(Token = "0x20027C5")]
			public class CooperateBoatEffectController : IHotfixable
			{
				// Token: 0x06010B9D RID: 68509 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B9D")]
				[Address(RVA = "0x877360", Offset = "0x875F60", VA = "0x180877360")]
				public void OnInit(Vector2 boatMapPos, Vector2 boatInitPos, float speedFactor)
				{
				}

				// Token: 0x06010B9E RID: 68510 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010B9E")]
				[Address(RVA = "0x877590", Offset = "0x876190", VA = "0x180877590")]
				public void OnWaveWillStart(BoatDirection curExit, BoatDirection previousExit, Vector2 boatPos)
				{
				}

				// Token: 0x06010B9F RID: 68511 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010B9F")]
				[Address(RVA = "0x878830", Offset = "0x877430", VA = "0x180878830")]
				private Effect _UpdateEdgeEffect(BoatDirection dir, Vector2 boatPos)
				{
					return null;
				}

				// Token: 0x06010BA0 RID: 68512 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BA0")]
				[Address(RVA = "0x877AA0", Offset = "0x8766A0", VA = "0x180877AA0")]
				public void UpdateEdgePos(Vector2 deltaPos)
				{
				}

				// Token: 0x06010BA1 RID: 68513 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BA1")]
				[Address(RVA = "0x8780B0", Offset = "0x876CB0", VA = "0x1808780B0")]
				public void UpdateWaterRippleEffect(Vector2 boatVelocity)
				{
				}

				// Token: 0x06010BA2 RID: 68514 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BA2")]
				[Address(RVA = "0x8778E0", Offset = "0x8764E0", VA = "0x1808778E0")]
				public void UpdateBoatEdgeDistance(BoatEdgeDistance boatEdgeDistance)
				{
				}

				// Token: 0x06010BA3 RID: 68515 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BA3")]
				[Address(RVA = "0x877F50", Offset = "0x876B50", VA = "0x180877F50")]
				public void UpdateWaterFlowDir(Vector2 waterFlowDir)
				{
				}

				// Token: 0x06010BA4 RID: 68516 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BA4")]
				[Address(RVA = "0x878030", Offset = "0x876C30", VA = "0x180878030")]
				public void UpdateWaterFlowLevel(int level)
				{
				}

				// Token: 0x06010BA5 RID: 68517 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BA5")]
				[Address(RVA = "0x8772D0", Offset = "0x875ED0", VA = "0x1808772D0")]
				public void AddWaterRippleMask(Tile tile)
				{
				}

				// Token: 0x06010BA6 RID: 68518 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BA6")]
				[Address(RVA = "0x877850", Offset = "0x876450", VA = "0x180877850")]
				public void RemoveWaterRippleMask(Tile tile)
				{
				}

				// Token: 0x06010BA7 RID: 68519 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BA7")]
				[Address(RVA = "0x878680", Offset = "0x877280", VA = "0x180878680")]
				private void _ResetEdgeEffect()
				{
				}

				// Token: 0x06010BA8 RID: 68520 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BA8")]
				[Address(RVA = "0x878390", Offset = "0x876F90", VA = "0x180878390")]
				private void _PlayStartEffect()
				{
				}

				// Token: 0x06010BA9 RID: 68521 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BA9")]
				[Address(RVA = "0x878220", Offset = "0x876E20", VA = "0x180878220")]
				private void _InitWaterFlow()
				{
				}

				// Token: 0x06010BAA RID: 68522 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BAA")]
				[Address(RVA = "0x878B40", Offset = "0x877740", VA = "0x180878B40")]
				private void _UpdateWaterFlowEffect()
				{
				}

				// Token: 0x06010BAB RID: 68523 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BAB")]
				[Address(RVA = "0x878C00", Offset = "0x877800", VA = "0x180878C00")]
				public CooperateBoatEffectController()
				{
				}

				// Token: 0x04012BBF RID: 76735
				[Token(Token = "0x4012BBF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private float m_waterFlowSpeedFactor;

				// Token: 0x04012BC0 RID: 76736
				[Token(Token = "0x4012BC0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				private Vector2 m_waterFlowForceDir;

				// Token: 0x04012BC1 RID: 76737
				[Token(Token = "0x4012BC1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private float m_waterFlowIntensitySpeed;

				// Token: 0x04012BC2 RID: 76738
				[Token(Token = "0x4012BC2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private MeshRenderer m_meshRenderer;

				// Token: 0x04012BC3 RID: 76739
				[Token(Token = "0x4012BC3")]
				private const float WATER_RIPPLE_SCALE = 2f;

				// Token: 0x04012BC4 RID: 76740
				[Token(Token = "0x4012BC4")]
				private const float BOAT_SPEED_MAX_FAC = 0.125f;

				// Token: 0x04012BC5 RID: 76741
				[Token(Token = "0x4012BC5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private float m_edgeMiddlePos;

				// Token: 0x04012BC6 RID: 76742
				[Token(Token = "0x4012BC6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private float m_edgeMinPos;

				// Token: 0x04012BC7 RID: 76743
				[Token(Token = "0x4012BC7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private float m_edgeMaxPos;

				// Token: 0x04012BC8 RID: 76744
				[Token(Token = "0x4012BC8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
				private bool m_startEffPlayed;

				// Token: 0x04012BC9 RID: 76745
				[Token(Token = "0x4012BC9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private ObjectPtr<Effect> m_upEdgeEffect;

				// Token: 0x04012BCA RID: 76746
				[Token(Token = "0x4012BCA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private ObjectPtr<Effect> m_leftEdgeEffect;

				// Token: 0x04012BCB RID: 76747
				[Token(Token = "0x4012BCB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private ObjectPtr<Effect> m_downEdgeEffect;

				// Token: 0x04012BCC RID: 76748
				[Token(Token = "0x4012BCC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private ObjectPtr<Effect> m_rightEdgeEffect;

				// Token: 0x04012BCD RID: 76749
				[Token(Token = "0x4012BCD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				private ObjectPtr<Effect> m_boatStartffect;

				// Token: 0x04012BCE RID: 76750
				[Token(Token = "0x4012BCE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				private SailBoatEdgeEffect m_upEffBehaviour;

				// Token: 0x04012BCF RID: 76751
				[Token(Token = "0x4012BCF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
				private SailBoatEdgeEffect m_leftEffBehaviour;

				// Token: 0x04012BD0 RID: 76752
				[Token(Token = "0x4012BD0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
				private SailBoatEdgeEffect m_downEffBehaviour;

				// Token: 0x04012BD1 RID: 76753
				[Token(Token = "0x4012BD1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
				private SailBoatEdgeEffect m_rightEffBehaviour;

				// Token: 0x04012BD2 RID: 76754
				[Token(Token = "0x4012BD2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
				private BoatDirection m_boatExit;

				// Token: 0x04012BD3 RID: 76755
				[Token(Token = "0x4012BD3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
				private BoatDirection m_previousExit;

				// Token: 0x04012BD4 RID: 76756
				[Token(Token = "0x4012BD4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
				private Vector2 m_lastRippleDir;

				// Token: 0x04012BD5 RID: 76757
				[Token(Token = "0x4012BD5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
				private WaterRippleEffect m_waterRippleEff;

				// Token: 0x04012BD6 RID: 76758
				[Token(Token = "0x4012BD6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnInit;

				// Token: 0x04012BD7 RID: 76759
				[Token(Token = "0x4012BD7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_OnWaveWillStart;

				// Token: 0x04012BD8 RID: 76760
				[Token(Token = "0x4012BD8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0__UpdateEdgeEffect;

				// Token: 0x04012BD9 RID: 76761
				[Token(Token = "0x4012BD9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_UpdateEdgePos;

				// Token: 0x04012BDA RID: 76762
				[Token(Token = "0x4012BDA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_UpdateWaterRippleEffect;

				// Token: 0x04012BDB RID: 76763
				[Token(Token = "0x4012BDB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_UpdateBoatEdgeDistance;

				// Token: 0x04012BDC RID: 76764
				[Token(Token = "0x4012BDC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_UpdateWaterFlowDir;

				// Token: 0x04012BDD RID: 76765
				[Token(Token = "0x4012BDD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_UpdateWaterFlowLevel;

				// Token: 0x04012BDE RID: 76766
				[Token(Token = "0x4012BDE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0_AddWaterRippleMask;

				// Token: 0x04012BDF RID: 76767
				[Token(Token = "0x4012BDF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge __Hotfix0_RemoveWaterRippleMask;

				// Token: 0x04012BE0 RID: 76768
				[Token(Token = "0x4012BE0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0__ResetEdgeEffect;

				// Token: 0x04012BE1 RID: 76769
				[Token(Token = "0x4012BE1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge __Hotfix0__PlayStartEffect;

				// Token: 0x04012BE2 RID: 76770
				[Token(Token = "0x4012BE2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				private static DelegateBridge __Hotfix0__InitWaterFlow;

				// Token: 0x04012BE3 RID: 76771
				[Token(Token = "0x4012BE3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private static DelegateBridge __Hotfix0__UpdateWaterFlowEffect;

				// Token: 0x04012BE4 RID: 76772
				[Token(Token = "0x4012BE4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020027C6 RID: 10182
			[Token(Token = "0x20027C6")]
			public class CooperateBoatItemsController : IHotfixable
			{
				// Token: 0x06010BAC RID: 68524 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BAC")]
				[Address(RVA = "0x878CF0", Offset = "0x8778F0", VA = "0x180878CF0")]
				public void OnInit(Vector2 boatMapPos)
				{
				}

				// Token: 0x06010BAD RID: 68525 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BAD")]
				[Address(RVA = "0x878FC0", Offset = "0x877BC0", VA = "0x180878FC0")]
				public void UpdateAllSceneItemPos(Vector2 deltaPos)
				{
				}

				// Token: 0x06010BAE RID: 68526 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BAE")]
				[Address(RVA = "0x879160", Offset = "0x877D60", VA = "0x180879160")]
				private void _InitSceneElement()
				{
				}

				// Token: 0x06010BAF RID: 68527 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BAF")]
				[Address(RVA = "0x879720", Offset = "0x878320", VA = "0x180879720")]
				private void _RelocateOutOfRangeItems()
				{
				}

				// Token: 0x06010BB0 RID: 68528 RVA: 0x00066810 File Offset: 0x00064A10
				[Token(Token = "0x6010BB0")]
				[Address(RVA = "0x879C60", Offset = "0x878860", VA = "0x180879C60")]
				private static float _WrapAxis(float v, float c, float half)
				{
					return 0f;
				}

				// Token: 0x06010BB1 RID: 68529 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BB1")]
				[Address(RVA = "0x878DC0", Offset = "0x8779C0", VA = "0x180878DC0")]
				public void OnModeDestroy()
				{
				}

				// Token: 0x06010BB2 RID: 68530 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BB2")]
				[Address(RVA = "0x879DF0", Offset = "0x8789F0", VA = "0x180879DF0")]
				public CooperateBoatItemsController()
				{
				}

				// Token: 0x04012BE5 RID: 76773
				[Token(Token = "0x4012BE5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private int m_remainCntToRelocate;

				// Token: 0x04012BE6 RID: 76774
				[Token(Token = "0x4012BE6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				private Vector2 m_itemViewRange;

				// Token: 0x04012BE7 RID: 76775
				[Token(Token = "0x4012BE7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Vector2 m_itemMaxRange;

				// Token: 0x04012BE8 RID: 76776
				[Token(Token = "0x4012BE8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector2 m_itemCenter;

				// Token: 0x04012BE9 RID: 76777
				[Token(Token = "0x4012BE9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private List<GameModeFactory.CooperateGameMode.CooperateBoatItemsController.UnderWaterItem> m_randomItems;

				// Token: 0x04012BEA RID: 76778
				[Token(Token = "0x4012BEA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private Transform m_itemGroup;

				// Token: 0x04012BEB RID: 76779
				[Token(Token = "0x4012BEB")]
				private const int RANGE_X_EXTRA = 4;

				// Token: 0x04012BEC RID: 76780
				[Token(Token = "0x4012BEC")]
				private const int RANDOM_ITEM_CNT = 4;

				// Token: 0x04012BED RID: 76781
				[Token(Token = "0x4012BED")]
				private const int FRAME_CNT_TO_RELOCATE = 30;

				// Token: 0x04012BEE RID: 76782
				[Token(Token = "0x4012BEE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static readonly string ITEMS_NAME_1;

				// Token: 0x04012BEF RID: 76783
				[Token(Token = "0x4012BEF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static readonly string ITEMS_NAME_2;

				// Token: 0x04012BF0 RID: 76784
				[Token(Token = "0x4012BF0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_OnInit;

				// Token: 0x04012BF1 RID: 76785
				[Token(Token = "0x4012BF1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_UpdateAllSceneItemPos;

				// Token: 0x04012BF2 RID: 76786
				[Token(Token = "0x4012BF2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0__InitSceneElement;

				// Token: 0x04012BF3 RID: 76787
				[Token(Token = "0x4012BF3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0__RelocateOutOfRangeItems;

				// Token: 0x04012BF4 RID: 76788
				[Token(Token = "0x4012BF4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0__WrapAxis;

				// Token: 0x04012BF5 RID: 76789
				[Token(Token = "0x4012BF5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_OnModeDestroy;

				// Token: 0x04012BF6 RID: 76790
				[Token(Token = "0x4012BF6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge _c__Hotfix0_ctor;

				// Token: 0x020027C7 RID: 10183
				[Token(Token = "0x20027C7")]
				private class UnderWaterItem
				{
					// Token: 0x06010BB4 RID: 68532 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6010BB4")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public UnderWaterItem()
					{
					}

					// Token: 0x04012BF7 RID: 76791
					[Token(Token = "0x4012BF7")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					public Vector2 pos;

					// Token: 0x04012BF8 RID: 76792
					[Token(Token = "0x4012BF8")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
					public Transform obj;
				}
			}

			// Token: 0x020027C8 RID: 10184
			[Token(Token = "0x20027C8")]
			public class BoatMoveController : IHotfixable
			{
				// Token: 0x06010BB5 RID: 68533 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BB5")]
				[Address(RVA = "0x873BF0", Offset = "0x8727F0", VA = "0x180873BF0")]
				public void OnInit(Vector2 boatMapPos, Vector2 boatCurPos, ActMultiV3Data actData)
				{
				}

				// Token: 0x06010BB6 RID: 68534 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BB6")]
				[Address(RVA = "0x874880", Offset = "0x873480", VA = "0x180874880")]
				public void OnWaveWillStart(BoatDirection curExit, BoatDirection previousExit, Vector2 boatPos)
				{
				}

				// Token: 0x06010BB7 RID: 68535 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BB7")]
				[Address(RVA = "0x874090", Offset = "0x872C90", VA = "0x180874090")]
				public void OnLateManualFrameTick(BoatTouchMask touchMask, BoatEdgeDistance boatEdgeDistance)
				{
				}

				// Token: 0x06010BB8 RID: 68536 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BB8")]
				[Address(RVA = "0x873450", Offset = "0x872050", VA = "0x180873450")]
				public void ApplyDamageByDir(SharedConsts.Direction dir, FP damage)
				{
				}

				// Token: 0x06010BB9 RID: 68537 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BB9")]
				[Address(RVA = "0x873690", Offset = "0x872290", VA = "0x180873690")]
				public void ApplyForce(Vector2 mapPos, int force)
				{
				}

				// Token: 0x06010BBA RID: 68538 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BBA")]
				[Address(RVA = "0x8735B0", Offset = "0x8721B0", VA = "0x1808735B0")]
				public void ApplyForceDirectly(Vector2 direct, int force)
				{
				}

				// Token: 0x06010BBB RID: 68539 RVA: 0x00066828 File Offset: 0x00064A28
				[Token(Token = "0x6010BBB")]
				[Address(RVA = "0x873990", Offset = "0x872590", VA = "0x180873990")]
				public Vector2 GetVelocity()
				{
					return default(Vector2);
				}

				// Token: 0x06010BBC RID: 68540 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BBC")]
				[Address(RVA = "0x873A10", Offset = "0x872610", VA = "0x180873A10")]
				public void InverseVelocity(bool inverseX, bool inverseY, FP velocity)
				{
				}

				// Token: 0x06010BBD RID: 68541 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BBD")]
				[Address(RVA = "0x874AB0", Offset = "0x8736B0", VA = "0x180874AB0")]
				public void UpdateWaterFlowForce(int waterForce, int level)
				{
				}

				// Token: 0x06010BBE RID: 68542 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BBE")]
				[Address(RVA = "0x8737D0", Offset = "0x8723D0", VA = "0x1808737D0")]
				public void AssignWaterFlowForceInterval(float waterForceInterval)
				{
				}

				// Token: 0x06010BBF RID: 68543 RVA: 0x00066840 File Offset: 0x00064A40
				[Token(Token = "0x6010BBF")]
				[Address(RVA = "0x8738A0", Offset = "0x8724A0", VA = "0x1808738A0")]
				public Vector2 GetBoatCurPos()
				{
					return default(Vector2);
				}

				// Token: 0x06010BC0 RID: 68544 RVA: 0x00066858 File Offset: 0x00064A58
				[Token(Token = "0x6010BC0")]
				[Address(RVA = "0x873920", Offset = "0x872520", VA = "0x180873920")]
				public float GetBoatMaxForce()
				{
					return 0f;
				}

				// Token: 0x06010BC1 RID: 68545 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BC1")]
				[Address(RVA = "0x873370", Offset = "0x871F70", VA = "0x180873370")]
				public void AddWaterRippleMask(Tile tile)
				{
				}

				// Token: 0x06010BC2 RID: 68546 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BC2")]
				[Address(RVA = "0x8749D0", Offset = "0x8735D0", VA = "0x1808749D0")]
				public void RemoveWaterRippleMask(Tile tile)
				{
				}

				// Token: 0x06010BC3 RID: 68547 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BC3")]
				[Address(RVA = "0x876080", Offset = "0x874C80", VA = "0x180876080")]
				private void _UpdateWaterFlowForceTimer()
				{
				}

				// Token: 0x06010BC4 RID: 68548 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BC4")]
				[Address(RVA = "0x876230", Offset = "0x874E30", VA = "0x180876230")]
				private void _UpdateWaterFlowForce()
				{
				}

				// Token: 0x06010BC5 RID: 68549 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BC5")]
				[Address(RVA = "0x874CB0", Offset = "0x8738B0", VA = "0x180874CB0")]
				private void _ApplyWaterFlowForce()
				{
				}

				// Token: 0x06010BC6 RID: 68550 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BC6")]
				[Address(RVA = "0x874DB0", Offset = "0x8739B0", VA = "0x180874DB0")]
				private void _CalculateForceAndApply()
				{
				}

				// Token: 0x06010BC7 RID: 68551 RVA: 0x00066870 File Offset: 0x00064A70
				[Token(Token = "0x6010BC7")]
				[Address(RVA = "0x875130", Offset = "0x873D30", VA = "0x180875130")]
				private Vector2 _GetForceByDirectionAndDamage(FP damage, Vector2 dir)
				{
					return default(Vector2);
				}

				// Token: 0x06010BC8 RID: 68552 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BC8")]
				[Address(RVA = "0x8755A0", Offset = "0x8741A0", VA = "0x1808755A0")]
				private void _ResetCachedDamage()
				{
				}

				// Token: 0x06010BC9 RID: 68553 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BC9")]
				[Address(RVA = "0x875850", Offset = "0x874450", VA = "0x180875850")]
				private void _UpdateAllUnitDeltaPos(Vector2 deltaPosCurFrame)
				{
				}

				// Token: 0x06010BCA RID: 68554 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BCA")]
				[Address(RVA = "0x875790", Offset = "0x874390", VA = "0x180875790")]
				private void _UpdateAllRoutesOffset(Vector2 deltaPosCurFrame)
				{
				}

				// Token: 0x06010BCB RID: 68555 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BCB")]
				[Address(RVA = "0x874BE0", Offset = "0x8737E0", VA = "0x180874BE0")]
				private void _ApplyForce(Vector2 force)
				{
				}

				// Token: 0x06010BCC RID: 68556 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BCC")]
				[Address(RVA = "0x875C90", Offset = "0x874890", VA = "0x180875C90")]
				private void _UpdateVelocityAndPos(BoatTouchMask touchMask)
				{
				}

				// Token: 0x06010BCD RID: 68557 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BCD")]
				[Address(RVA = "0x874F70", Offset = "0x873B70", VA = "0x180874F70")]
				private void _DealTouchBound(BoatTouchMask touchMask)
				{
				}

				// Token: 0x06010BCE RID: 68558 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BCE")]
				[Address(RVA = "0x875350", Offset = "0x873F50", VA = "0x180875350")]
				private void _InitBoatMoveFactor(ActMultiV3Data actData)
				{
				}

				// Token: 0x06010BCF RID: 68559 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BCF")]
				[Address(RVA = "0x8756A0", Offset = "0x8742A0", VA = "0x1808756A0")]
				private void _TriggerWaterForceChanged()
				{
				}

				// Token: 0x06010BD0 RID: 68560 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BD0")]
				[Address(RVA = "0x8754E0", Offset = "0x8740E0", VA = "0x1808754E0")]
				private void _LogBoatTouchBound()
				{
				}

				// Token: 0x06010BD1 RID: 68561 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BD1")]
				[Address(RVA = "0x8747F0", Offset = "0x8733F0", VA = "0x1808747F0")]
				public void OnModeDestroy()
				{
				}

				// Token: 0x06010BD2 RID: 68562 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010BD2")]
				[Address(RVA = "0x876490", Offset = "0x875090", VA = "0x180876490")]
				public BoatMoveController()
				{
				}

				// Token: 0x04012BF9 RID: 76793
				[Token(Token = "0x4012BF9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private float m_boatAirFactor;

				// Token: 0x04012BFA RID: 76794
				[Token(Token = "0x4012BFA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				private float m_boatFrictionFactor;

				// Token: 0x04012BFB RID: 76795
				[Token(Token = "0x4012BFB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private float m_boatForceInterval;

				// Token: 0x04012BFC RID: 76796
				[Token(Token = "0x4012BFC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private float m_boatExchangeDamageMax;

				// Token: 0x04012BFD RID: 76797
				[Token(Token = "0x4012BFD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private float m_boatExchangeDamageMin;

				// Token: 0x04012BFE RID: 76798
				[Token(Token = "0x4012BFE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private float m_boatExchangeForceMax;

				// Token: 0x04012BFF RID: 76799
				[Token(Token = "0x4012BFF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private float m_boatExchangeForceMin;

				// Token: 0x04012C00 RID: 76800
				[Token(Token = "0x4012C00")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private float m_boatCollisionLossSpeedFactor;

				// Token: 0x04012C01 RID: 76801
				[Token(Token = "0x4012C01")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private float m_frictionBase;

				// Token: 0x04012C02 RID: 76802
				[Token(Token = "0x4012C02")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
				private float m_airBase;

				// Token: 0x04012C03 RID: 76803
				[Token(Token = "0x4012C03")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private int m_mass;

				// Token: 0x04012C04 RID: 76804
				[Token(Token = "0x4012C04")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
				private Vector2 m_velocity;

				// Token: 0x04012C05 RID: 76805
				[Token(Token = "0x4012C05")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
				private Vector2 m_waterFlowForce;

				// Token: 0x04012C06 RID: 76806
				[Token(Token = "0x4012C06")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
				private float m_waterFlowForceInterval;

				// Token: 0x04012C07 RID: 76807
				[Token(Token = "0x4012C07")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private int m_waterFlowIntensity;

				// Token: 0x04012C08 RID: 76808
				[Token(Token = "0x4012C08")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
				private int m_waterForceLevel;

				// Token: 0x04012C09 RID: 76809
				[Token(Token = "0x4012C09")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private float m_deltaTime;

				// Token: 0x04012C0A RID: 76810
				[Token(Token = "0x4012C0A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
				private Vector2 m_boatOriginPos;

				// Token: 0x04012C0B RID: 76811
				[Token(Token = "0x4012C0B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
				private Vector2 m_boatCurPos;

				// Token: 0x04012C0C RID: 76812
				[Token(Token = "0x4012C0C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
				private BoatDirection m_waterDir;

				// Token: 0x04012C0D RID: 76813
				[Token(Token = "0x4012C0D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private GameModeFactory.CooperateGameMode.CooperateBoatEffectController m_boatEffCtrl;

				// Token: 0x04012C0E RID: 76814
				[Token(Token = "0x4012C0E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				private GameModeFactory.CooperateGameMode.CooperateBoatItemsController m_boatItemsCtrl;

				// Token: 0x04012C0F RID: 76815
				[Token(Token = "0x4012C0F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				private FP[] m_dirDamageArray;

				// Token: 0x04012C10 RID: 76816
				[Token(Token = "0x4012C10")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				private Vector2[] m_forceDirArray;

				// Token: 0x04012C11 RID: 76817
				[Token(Token = "0x4012C11")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
				private PrecisePeriodicTimer m_triggerForceTimer;

				// Token: 0x04012C12 RID: 76818
				[Token(Token = "0x4012C12")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
				private PrecisePeriodicTimer m_triggerWaterForceTimer;

				// Token: 0x04012C13 RID: 76819
				[Token(Token = "0x4012C13")]
				private const float MIN_VELOCITY = 0.0001f;

				// Token: 0x04012C14 RID: 76820
				[Token(Token = "0x4012C14")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static readonly string EDGE_EFFECT;

				// Token: 0x04012C15 RID: 76821
				[Token(Token = "0x4012C15")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_OnInit;

				// Token: 0x04012C16 RID: 76822
				[Token(Token = "0x4012C16")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_OnWaveWillStart;

				// Token: 0x04012C17 RID: 76823
				[Token(Token = "0x4012C17")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_OnLateManualFrameTick;

				// Token: 0x04012C18 RID: 76824
				[Token(Token = "0x4012C18")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_ApplyDamageByDir;

				// Token: 0x04012C19 RID: 76825
				[Token(Token = "0x4012C19")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_ApplyForce;

				// Token: 0x04012C1A RID: 76826
				[Token(Token = "0x4012C1A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_ApplyForceDirectly;

				// Token: 0x04012C1B RID: 76827
				[Token(Token = "0x4012C1B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_GetVelocity;

				// Token: 0x04012C1C RID: 76828
				[Token(Token = "0x4012C1C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0_InverseVelocity;

				// Token: 0x04012C1D RID: 76829
				[Token(Token = "0x4012C1D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge __Hotfix0_UpdateWaterFlowForce;

				// Token: 0x04012C1E RID: 76830
				[Token(Token = "0x4012C1E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0_AssignWaterFlowForceInterval;

				// Token: 0x04012C1F RID: 76831
				[Token(Token = "0x4012C1F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge __Hotfix0_GetBoatCurPos;

				// Token: 0x04012C20 RID: 76832
				[Token(Token = "0x4012C20")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				private static DelegateBridge __Hotfix0_GetBoatMaxForce;

				// Token: 0x04012C21 RID: 76833
				[Token(Token = "0x4012C21")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private static DelegateBridge __Hotfix0_AddWaterRippleMask;

				// Token: 0x04012C22 RID: 76834
				[Token(Token = "0x4012C22")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private static DelegateBridge __Hotfix0_RemoveWaterRippleMask;

				// Token: 0x04012C23 RID: 76835
				[Token(Token = "0x4012C23")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				private static DelegateBridge __Hotfix0__UpdateWaterFlowForceTimer;

				// Token: 0x04012C24 RID: 76836
				[Token(Token = "0x4012C24")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				private static DelegateBridge __Hotfix0__UpdateWaterFlowForce;

				// Token: 0x04012C25 RID: 76837
				[Token(Token = "0x4012C25")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				private static DelegateBridge __Hotfix0__ApplyWaterFlowForce;

				// Token: 0x04012C26 RID: 76838
				[Token(Token = "0x4012C26")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
				private static DelegateBridge __Hotfix0__CalculateForceAndApply;

				// Token: 0x04012C27 RID: 76839
				[Token(Token = "0x4012C27")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
				private static DelegateBridge __Hotfix0__GetForceByDirectionAndDamage;

				// Token: 0x04012C28 RID: 76840
				[Token(Token = "0x4012C28")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
				private static DelegateBridge __Hotfix0__ResetCachedDamage;

				// Token: 0x04012C29 RID: 76841
				[Token(Token = "0x4012C29")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
				private static DelegateBridge __Hotfix0__UpdateAllUnitDeltaPos;

				// Token: 0x04012C2A RID: 76842
				[Token(Token = "0x4012C2A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
				private static DelegateBridge __Hotfix0__UpdateAllRoutesOffset;

				// Token: 0x04012C2B RID: 76843
				[Token(Token = "0x4012C2B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
				private static DelegateBridge __Hotfix0__ApplyForce;

				// Token: 0x04012C2C RID: 76844
				[Token(Token = "0x4012C2C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
				private static DelegateBridge __Hotfix0__UpdateVelocityAndPos;

				// Token: 0x04012C2D RID: 76845
				[Token(Token = "0x4012C2D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
				private static DelegateBridge __Hotfix0__DealTouchBound;

				// Token: 0x04012C2E RID: 76846
				[Token(Token = "0x4012C2E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
				private static DelegateBridge __Hotfix0__InitBoatMoveFactor;

				// Token: 0x04012C2F RID: 76847
				[Token(Token = "0x4012C2F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
				private static DelegateBridge __Hotfix0__TriggerWaterForceChanged;

				// Token: 0x04012C30 RID: 76848
				[Token(Token = "0x4012C30")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
				private static DelegateBridge __Hotfix0__LogBoatTouchBound;

				// Token: 0x04012C31 RID: 76849
				[Token(Token = "0x4012C31")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
				private static DelegateBridge __Hotfix0_OnModeDestroy;

				// Token: 0x04012C32 RID: 76850
				[Token(Token = "0x4012C32")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}
		}

		// Token: 0x020027CB RID: 10187
		[Token(Token = "0x20027CB")]
		private class DanmakuGameMode : GameModeFactory.DefaultGameMode
		{
			// Token: 0x06010BDD RID: 68573 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010BDD")]
			[Address(RVA = "0x883880", Offset = "0x882480", VA = "0x180883880", Slot = "140")]
			public override void PostprocessMap(Map map)
			{
			}

			// Token: 0x170024B1 RID: 9393
			// (get) Token: 0x06010BDE RID: 68574 RVA: 0x000668B8 File Offset: 0x00064AB8
			[Token(Token = "0x170024B1")]
			public override GameModeMeta.GameModeType gameModeType
			{
				[Token(Token = "0x6010BDE")]
				[Address(RVA = "0x8839C0", Offset = "0x8825C0", VA = "0x1808839C0", Slot = "119")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x06010BDF RID: 68575 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010BDF")]
			[Address(RVA = "0x8836F0", Offset = "0x8822F0", VA = "0x1808836F0", Slot = "133")]
			public override Tile Hook_MapGetTileFromScreenPos(Vector2 screenPos, out Vector2 mapPos)
			{
				return null;
			}

			// Token: 0x06010BE0 RID: 68576 RVA: 0x000668D0 File Offset: 0x00064AD0
			[Token(Token = "0x6010BE0")]
			[Address(RVA = "0x8837B0", Offset = "0x8823B0", VA = "0x1808837B0", Slot = "134")]
			public override bool IsHook_MapGetTileFromScreenPos()
			{
				return default(bool);
			}

			// Token: 0x06010BE1 RID: 68577 RVA: 0x000668E8 File Offset: 0x00064AE8
			[Token(Token = "0x6010BE1")]
			[Address(RVA = "0x883810", Offset = "0x882410", VA = "0x180883810")]
			public bool IsSchedulerNeedPreprocess(out bool retainMimicEnemy)
			{
				return default(bool);
			}

			// Token: 0x06010BE2 RID: 68578 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010BE2")]
			[Address(RVA = "0x883950", Offset = "0x882550", VA = "0x180883950")]
			public DanmakuGameMode(ref GameModeMeta meta)
			{
			}

			// Token: 0x06010BE3 RID: 68579 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010BE3")]
			[Address(RVA = "0x883940", Offset = "0x882540", VA = "0x180883940")]
			private void <>xLuaBaseProxy_PostprocessMap(Map P0)
			{
			}

			// Token: 0x06010BE4 RID: 68580 RVA: 0x00066900 File Offset: 0x00064B00
			[Token(Token = "0x6010BE4")]
			[Address(RVA = "0x83EAA0", Offset = "0x83D6A0", VA = "0x18083EAA0")]
			private GameModeMeta.GameModeType <>xLuaBaseProxy_get_gameModeType()
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}

			// Token: 0x06010BE5 RID: 68581 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010BE5")]
			[Address(RVA = "0x883920", Offset = "0x882520", VA = "0x180883920")]
			private Tile <>xLuaBaseProxy_Hook_MapGetTileFromScreenPos(Vector2 P0, out Vector2 P1)
			{
				return null;
			}

			// Token: 0x06010BE6 RID: 68582 RVA: 0x00066918 File Offset: 0x00064B18
			[Token(Token = "0x6010BE6")]
			[Address(RVA = "0x883930", Offset = "0x882530", VA = "0x180883930")]
			private bool <>xLuaBaseProxy_IsHook_MapGetTileFromScreenPos()
			{
				return default(bool);
			}

			// Token: 0x04012C38 RID: 76856
			[Token(Token = "0x4012C38")]
			public const string DANMAKU_UI_PLUGIN_PATH = "UI/Activity/ActFun/Actfun3/Battle/act3fun_battle_ui_plugin.prefab";

			// Token: 0x04012C39 RID: 76857
			[Token(Token = "0x4012C39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_PostprocessMap;

			// Token: 0x04012C3A RID: 76858
			[Token(Token = "0x4012C3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_gameModeType;

			// Token: 0x04012C3B RID: 76859
			[Token(Token = "0x4012C3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Hook_MapGetTileFromScreenPos;

			// Token: 0x04012C3C RID: 76860
			[Token(Token = "0x4012C3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_IsHook_MapGetTileFromScreenPos;

			// Token: 0x04012C3D RID: 76861
			[Token(Token = "0x4012C3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IsSchedulerNeedPreprocess;

			// Token: 0x04012C3E RID: 76862
			[Token(Token = "0x4012C3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020027CC RID: 10188
		[Token(Token = "0x20027CC")]
		public class DouququGameMode : GameModeFactory.DefaultGameMode
		{
			// Token: 0x170024B2 RID: 9394
			// (get) Token: 0x06010BE7 RID: 68583 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170024B2")]
			public Act5FunData.BattleData battleData
			{
				[Token(Token = "0x6010BE7")]
				[Address(RVA = "0x885780", Offset = "0x884380", VA = "0x180885780")]
				get
				{
					return null;
				}
			}

			// Token: 0x170024B3 RID: 9395
			// (get) Token: 0x06010BE8 RID: 68584 RVA: 0x00066930 File Offset: 0x00064B30
			[Token(Token = "0x170024B3")]
			public int roundIndex
			{
				[Token(Token = "0x6010BE8")]
				[Address(RVA = "0x885B70", Offset = "0x884770", VA = "0x180885B70")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170024B4 RID: 9396
			// (get) Token: 0x06010BE9 RID: 68585 RVA: 0x00066948 File Offset: 0x00064B48
			[Token(Token = "0x170024B4")]
			public RoundResult roundResult
			{
				[Token(Token = "0x6010BE9")]
				[Address(RVA = "0x885BD0", Offset = "0x8847D0", VA = "0x180885BD0")]
				get
				{
					return RoundResult.LEFT_WIN;
				}
			}

			// Token: 0x170024B5 RID: 9397
			// (get) Token: 0x06010BEA RID: 68586 RVA: 0x00066960 File Offset: 0x00064B60
			[Token(Token = "0x170024B5")]
			public bool isBetMode
			{
				[Token(Token = "0x6010BEA")]
				[Address(RVA = "0x885A50", Offset = "0x884650", VA = "0x180885A50")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170024B6 RID: 9398
			// (get) Token: 0x06010BEB RID: 68587 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170024B6")]
			public string currentRoundId
			{
				[Token(Token = "0x6010BEB")]
				[Address(RVA = "0x885840", Offset = "0x884440", VA = "0x180885840")]
				get
				{
					return null;
				}
			}

			// Token: 0x170024B7 RID: 9399
			// (get) Token: 0x06010BEC RID: 68588 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170024B7")]
			public DouququMoneyManager moneyManager
			{
				[Token(Token = "0x6010BEC")]
				[Address(RVA = "0x885AB0", Offset = "0x8846B0", VA = "0x180885AB0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170024B8 RID: 9400
			// (get) Token: 0x06010BED RID: 68589 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170024B8")]
			public DouququNpcManager npcManager
			{
				[Token(Token = "0x6010BED")]
				[Address(RVA = "0x885B10", Offset = "0x884710", VA = "0x180885B10")]
				get
				{
					return null;
				}
			}

			// Token: 0x170024B9 RID: 9401
			// (get) Token: 0x06010BEE RID: 68590 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170024B9")]
			public DouququWaveManager waveManager
			{
				[Token(Token = "0x6010BEE")]
				[Address(RVA = "0x885C30", Offset = "0x884830", VA = "0x180885C30")]
				get
				{
					return null;
				}
			}

			// Token: 0x06010BEF RID: 68591 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010BEF")]
			[Address(RVA = "0x8855C0", Offset = "0x8841C0", VA = "0x1808855C0")]
			public DouququGameMode(ref GameModeMeta meta)
			{
			}

			// Token: 0x170024BA RID: 9402
			// (get) Token: 0x06010BF0 RID: 68592 RVA: 0x00066978 File Offset: 0x00064B78
			[Token(Token = "0x170024BA")]
			public override GameModeMeta.GameModeType gameModeType
			{
				[Token(Token = "0x6010BF0")]
				[Address(RVA = "0x8859F0", Offset = "0x8845F0", VA = "0x1808859F0", Slot = "119")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x06010BF1 RID: 68593 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010BF1")]
			[Address(RVA = "0x8843D0", Offset = "0x882FD0", VA = "0x1808843D0", Slot = "122")]
			public override void Init(ref GameModeMeta meta, ref int randomSeed, BattlePlayerData playerData, LevelData levelData)
			{
			}

			// Token: 0x06010BF2 RID: 68594 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010BF2")]
			[Address(RVA = "0x884A20", Offset = "0x883620", VA = "0x180884A20", Slot = "126")]
			public override void Tick(Action doDefaultTick)
			{
			}

			// Token: 0x06010BF3 RID: 68595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010BF3")]
			[Address(RVA = "0x884740", Offset = "0x883340", VA = "0x180884740", Slot = "125")]
			public override void OnGameOver(ref BattleController.GameResult result)
			{
			}

			// Token: 0x06010BF4 RID: 68596 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010BF4")]
			[Address(RVA = "0x884940", Offset = "0x883540", VA = "0x180884940", Slot = "148")]
			public override void OnWaveWillStart(LevelData.WaveData waveData)
			{
			}

			// Token: 0x06010BF5 RID: 68597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010BF5")]
			[Address(RVA = "0x8847C0", Offset = "0x8833C0", VA = "0x1808847C0", Slot = "161")]
			public override void OnUnitRegistered(Unit unit)
			{
			}

			// Token: 0x06010BF6 RID: 68598 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010BF6")]
			[Address(RVA = "0x884590", Offset = "0x883190", VA = "0x180884590", Slot = "164")]
			public override void OnEnemyFinished(Enemy enemy, Entity.FinishReason reason)
			{
			}

			// Token: 0x06010BF7 RID: 68599 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010BF7")]
			[Address(RVA = "0x8840B0", Offset = "0x882CB0", VA = "0x1808840B0", Slot = "155")]
			public override Scheduler.SchedulerPreprocessor GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x06010BF8 RID: 68600 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010BF8")]
			[Address(RVA = "0x883C80", Offset = "0x882880", VA = "0x180883C80")]
			public string GetAct5FunLevelId()
			{
				return null;
			}

			// Token: 0x06010BF9 RID: 68601 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010BF9")]
			[Address(RVA = "0x883F50", Offset = "0x882B50", VA = "0x180883F50")]
			public Act5FunNpcData GetNpcItemData(bool isLeft, int position)
			{
				return null;
			}

			// Token: 0x06010BFA RID: 68602 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010BFA")]
			[Address(RVA = "0x883D90", Offset = "0x882990", VA = "0x180883D90")]
			public void GetNpcDataByListPosition(bool isLeft, int position, out string originId, out int cnt)
			{
			}

			// Token: 0x06010BFB RID: 68603 RVA: 0x00066990 File Offset: 0x00064B90
			[Token(Token = "0x6010BFB")]
			[Address(RVA = "0x884C80", Offset = "0x883880", VA = "0x180884C80")]
			public bool TryGetChoiceRewardData(int selection, out Act5FunChoiceRewardData data)
			{
				return default(bool);
			}

			// Token: 0x06010BFC RID: 68604 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010BFC")]
			[Address(RVA = "0x884140", Offset = "0x882D40", VA = "0x180884140")]
			public string GetTeamDetailsBySide(bool isLeft)
			{
				return null;
			}

			// Token: 0x06010BFD RID: 68605 RVA: 0x000669A8 File Offset: 0x00064BA8
			[Token(Token = "0x6010BFD")]
			[Address(RVA = "0x883A20", Offset = "0x882620", VA = "0x180883A20")]
			public float CalculateTeamScoreBySide(bool isLeft, Act5FunNpcData npcInfoData)
			{
				return 0f;
			}

			// Token: 0x06010BFE RID: 68606 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010BFE")]
			[Address(RVA = "0x885130", Offset = "0x883D30", VA = "0x180885130")]
			private static Unit _GetHostEnemyByUid(uint hostUid)
			{
				return null;
			}

			// Token: 0x06010BFF RID: 68607 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010BFF")]
			[Address(RVA = "0x885350", Offset = "0x883F50", VA = "0x180885350")]
			private List<EnemyGenerationData> _GetTeamData(bool isLeft)
			{
				return null;
			}

			// Token: 0x06010C00 RID: 68608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C00")]
			[Address(RVA = "0x885440", Offset = "0x884040", VA = "0x180885440")]
			private void _ProcessDouququMode(LevelData levelData)
			{
			}

			// Token: 0x06010C01 RID: 68609 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C01")]
			[Address(RVA = "0x8854E0", Offset = "0x8840E0", VA = "0x1808854E0")]
			private void _UnregisterEnemy(uint uid)
			{
			}

			// Token: 0x06010C02 RID: 68610 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C02")]
			[Address(RVA = "0x884DB0", Offset = "0x8839B0", VA = "0x180884DB0")]
			private void _CheckRoundFinish()
			{
			}

			// Token: 0x06010C03 RID: 68611 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C03")]
			[Address(RVA = "0x884F50", Offset = "0x883B50", VA = "0x180884F50")]
			private void _FinishRound(RoundResult result)
			{
			}

			// Token: 0x06010C04 RID: 68612 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010C04")]
			[Address(RVA = "0x884EA0", Offset = "0x883AA0", VA = "0x180884EA0")]
			private IEnumerator _CleanMapForNextRound()
			{
				return null;
			}

			// Token: 0x06010C05 RID: 68613 RVA: 0x000669C0 File Offset: 0x00064BC0
			[Token(Token = "0x6010C05")]
			[Address(RVA = "0x83EAA0", Offset = "0x83D6A0", VA = "0x18083EAA0")]
			private GameModeMeta.GameModeType <>xLuaBaseProxy_get_gameModeType()
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}

			// Token: 0x06010C06 RID: 68614 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C06")]
			[Address(RVA = "0x83EA80", Offset = "0x83D680", VA = "0x18083EA80")]
			private void <>xLuaBaseProxy_Init(ref GameModeMeta P0, ref int P1, BattlePlayerData P2, LevelData P3)
			{
			}

			// Token: 0x06010C07 RID: 68615 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C07")]
			[Address(RVA = "0x83EA90", Offset = "0x83D690", VA = "0x18083EA90")]
			private void <>xLuaBaseProxy_Tick(Action P0)
			{
			}

			// Token: 0x06010C08 RID: 68616 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C08")]
			[Address(RVA = "0x884DA0", Offset = "0x8839A0", VA = "0x180884DA0")]
			private void <>xLuaBaseProxy_OnGameOver(ref BattleController.GameResult P0)
			{
			}

			// Token: 0x06010C09 RID: 68617 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C09")]
			[Address(RVA = "0x85E9F0", Offset = "0x85D5F0", VA = "0x18085E9F0")]
			private void <>xLuaBaseProxy_OnWaveWillStart(LevelData.WaveData P0)
			{
			}

			// Token: 0x06010C0A RID: 68618 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C0A")]
			[Address(RVA = "0x840A90", Offset = "0x83F690", VA = "0x180840A90")]
			private void <>xLuaBaseProxy_OnUnitRegistered(Unit P0)
			{
			}

			// Token: 0x06010C0B RID: 68619 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C0B")]
			[Address(RVA = "0x840A70", Offset = "0x83F670", VA = "0x180840A70")]
			private void <>xLuaBaseProxy_OnEnemyFinished(Enemy P0, Entity.FinishReason P1)
			{
			}

			// Token: 0x06010C0C RID: 68620 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010C0C")]
			[Address(RVA = "0x83EA70", Offset = "0x83D670", VA = "0x18083EA70")]
			private Scheduler.SchedulerPreprocessor <>xLuaBaseProxy_GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x04012C3F RID: 76863
			[Token(Token = "0x4012C3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private FP m_roundTime;

			// Token: 0x04012C40 RID: 76864
			[Token(Token = "0x4012C40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int m_roundIndex;

			// Token: 0x04012C41 RID: 76865
			[Token(Token = "0x4012C41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private bool m_isBetMode;

			// Token: 0x04012C42 RID: 76866
			[Token(Token = "0x4012C42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Coroutine m_finalCoroutine;

			// Token: 0x04012C43 RID: 76867
			[Token(Token = "0x4012C43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Act5FunData.BattleData m_battleData;

			// Token: 0x04012C44 RID: 76868
			[Token(Token = "0x4012C44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private RoundResult m_roundResult;

			// Token: 0x04012C45 RID: 76869
			[Token(Token = "0x4012C45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private readonly List<uint> m_teamRight;

			// Token: 0x04012C46 RID: 76870
			[Token(Token = "0x4012C46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private readonly List<uint> m_teamLeft;

			// Token: 0x04012C47 RID: 76871
			[Token(Token = "0x4012C47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private readonly DouququWaveManager m_waveManager;

			// Token: 0x04012C48 RID: 76872
			[Token(Token = "0x4012C48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private readonly DouququMoneyManager m_moneyManager;

			// Token: 0x04012C49 RID: 76873
			[Token(Token = "0x4012C49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private readonly DouququNpcManager m_npcManager;

			// Token: 0x04012C4A RID: 76874
			[Token(Token = "0x4012C4A")]
			private const string NORMAL_MODE_LEVEL_ID = "Activities/act5fun/level_act5fun_01";

			// Token: 0x04012C4B RID: 76875
			[Token(Token = "0x4012C4B")]
			private const int NORMAL_MODE_INIT_INDEX = -1;

			// Token: 0x04012C4C RID: 76876
			[Token(Token = "0x4012C4C")]
			private const int BET_MODE_INIT_INDEX = -2;

			// Token: 0x04012C4D RID: 76877
			[Token(Token = "0x4012C4D")]
			private const float WIN_WAIT_TIME = 2f;

			// Token: 0x04012C4E RID: 76878
			[Token(Token = "0x4012C4E")]
			private const string CHOICE_ID_PREFIX = "act5fun_choice_0";

			// Token: 0x04012C4F RID: 76879
			[Token(Token = "0x4012C4F")]
			private const string ENEMY_DETAILS_FORMAT = "<color=#000000>{0}</color>：{1}\n";

			// Token: 0x04012C50 RID: 76880
			[Token(Token = "0x4012C50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_battleData;

			// Token: 0x04012C51 RID: 76881
			[Token(Token = "0x4012C51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_roundIndex;

			// Token: 0x04012C52 RID: 76882
			[Token(Token = "0x4012C52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_roundResult;

			// Token: 0x04012C53 RID: 76883
			[Token(Token = "0x4012C53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_isBetMode;

			// Token: 0x04012C54 RID: 76884
			[Token(Token = "0x4012C54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_currentRoundId;

			// Token: 0x04012C55 RID: 76885
			[Token(Token = "0x4012C55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_moneyManager;

			// Token: 0x04012C56 RID: 76886
			[Token(Token = "0x4012C56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_npcManager;

			// Token: 0x04012C57 RID: 76887
			[Token(Token = "0x4012C57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_waveManager;

			// Token: 0x04012C58 RID: 76888
			[Token(Token = "0x4012C58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04012C59 RID: 76889
			[Token(Token = "0x4012C59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_gameModeType;

			// Token: 0x04012C5A RID: 76890
			[Token(Token = "0x4012C5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x04012C5B RID: 76891
			[Token(Token = "0x4012C5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_Tick;

			// Token: 0x04012C5C RID: 76892
			[Token(Token = "0x4012C5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_OnGameOver;

			// Token: 0x04012C5D RID: 76893
			[Token(Token = "0x4012C5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_OnWaveWillStart;

			// Token: 0x04012C5E RID: 76894
			[Token(Token = "0x4012C5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_OnUnitRegistered;

			// Token: 0x04012C5F RID: 76895
			[Token(Token = "0x4012C5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_OnEnemyFinished;

			// Token: 0x04012C60 RID: 76896
			[Token(Token = "0x4012C60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_GetSchedulerPreprocessor;

			// Token: 0x04012C61 RID: 76897
			[Token(Token = "0x4012C61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_GetAct5FunLevelId;

			// Token: 0x04012C62 RID: 76898
			[Token(Token = "0x4012C62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_GetNpcItemData;

			// Token: 0x04012C63 RID: 76899
			[Token(Token = "0x4012C63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_GetNpcDataByListPosition;

			// Token: 0x04012C64 RID: 76900
			[Token(Token = "0x4012C64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_TryGetChoiceRewardData;

			// Token: 0x04012C65 RID: 76901
			[Token(Token = "0x4012C65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_GetTeamDetailsBySide;

			// Token: 0x04012C66 RID: 76902
			[Token(Token = "0x4012C66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_CalculateTeamScoreBySide;

			// Token: 0x04012C67 RID: 76903
			[Token(Token = "0x4012C67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0__GetHostEnemyByUid;

			// Token: 0x04012C68 RID: 76904
			[Token(Token = "0x4012C68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0__GetTeamData;

			// Token: 0x04012C69 RID: 76905
			[Token(Token = "0x4012C69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0__ProcessDouququMode;

			// Token: 0x04012C6A RID: 76906
			[Token(Token = "0x4012C6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0__UnregisterEnemy;

			// Token: 0x04012C6B RID: 76907
			[Token(Token = "0x4012C6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0__CheckRoundFinish;

			// Token: 0x04012C6C RID: 76908
			[Token(Token = "0x4012C6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0__FinishRound;

			// Token: 0x04012C6D RID: 76909
			[Token(Token = "0x4012C6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0__CleanMapForNextRound;
		}

		// Token: 0x020027CE RID: 10190
		[Token(Token = "0x20027CE")]
		public class EnemyDuelGameMode : GameModeFactory.DefaultGameMode, IEnemyDuelGameMode, IGameMode, IHotfixable
		{
			// Token: 0x170024BD RID: 9405
			// (get) Token: 0x06010C13 RID: 68627 RVA: 0x000669F0 File Offset: 0x00064BF0
			[Token(Token = "0x170024BD")]
			public bool isMultiplayer
			{
				[Token(Token = "0x6010C13")]
				[Address(RVA = "0x88ACE0", Offset = "0x8898E0", VA = "0x18088ACE0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06010C14 RID: 68628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C14")]
			[Address(RVA = "0x88A5F0", Offset = "0x8891F0", VA = "0x18088A5F0")]
			public EnemyDuelGameMode(ref GameModeMeta meta)
			{
			}

			// Token: 0x170024BE RID: 9406
			// (get) Token: 0x06010C15 RID: 68629 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170024BE")]
			public static GameModeFactory.EnemyDuelGameMode instance
			{
				[Token(Token = "0x6010C15")]
				[Address(RVA = "0x88AB70", Offset = "0x889770", VA = "0x18088AB70")]
				get
				{
					return null;
				}
			}

			// Token: 0x170024BF RID: 9407
			// (get) Token: 0x06010C16 RID: 68630 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170024BF")]
			public string actId
			{
				[Token(Token = "0x6010C16")]
				[Address(RVA = "0x88A9F0", Offset = "0x8895F0", VA = "0x18088A9F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170024C0 RID: 9408
			// (get) Token: 0x06010C17 RID: 68631 RVA: 0x00066A08 File Offset: 0x00064C08
			[Token(Token = "0x170024C0")]
			public override GameModeMeta.GameModeType gameModeType
			{
				[Token(Token = "0x6010C17")]
				[Address(RVA = "0x88AB10", Offset = "0x889710", VA = "0x18088AB10", Slot = "119")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x170024C1 RID: 9409
			// (get) Token: 0x06010C18 RID: 68632 RVA: 0x00066A20 File Offset: 0x00064C20
			[Token(Token = "0x170024C1")]
			public int teamOnSceneLeftCount
			{
				[Token(Token = "0x6010C18")]
				[Address(RVA = "0x88AE60", Offset = "0x889A60", VA = "0x18088AE60")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170024C2 RID: 9410
			// (get) Token: 0x06010C19 RID: 68633 RVA: 0x00066A38 File Offset: 0x00064C38
			[Token(Token = "0x170024C2")]
			public int teamOnSceneRightCount
			{
				[Token(Token = "0x6010C19")]
				[Address(RVA = "0x88AED0", Offset = "0x889AD0", VA = "0x18088AED0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06010C1A RID: 68634 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C1A")]
			[Address(RVA = "0x886180", Offset = "0x884D80", VA = "0x180886180", Slot = "122")]
			public override void Init(ref GameModeMeta meta, ref int randomSeed, BattlePlayerData playerData, LevelData levelData)
			{
			}

			// Token: 0x06010C1B RID: 68635 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C1B")]
			[Address(RVA = "0x887270", Offset = "0x885E70", VA = "0x180887270", Slot = "136")]
			public override void PreprocessLevelData(LevelData levelData)
			{
			}

			// Token: 0x06010C1C RID: 68636 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C1C")]
			[Address(RVA = "0x887850", Offset = "0x886450", VA = "0x180887850", Slot = "126")]
			public override void Tick(Action doDefaultTick)
			{
			}

			// Token: 0x170024C3 RID: 9411
			// (get) Token: 0x06010C1D RID: 68637 RVA: 0x00066A50 File Offset: 0x00064C50
			[Token(Token = "0x170024C3")]
			public override bool allowManualTick
			{
				[Token(Token = "0x6010C1D")]
				[Address(RVA = "0x88AA50", Offset = "0x889650", VA = "0x18088AA50", Slot = "103")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170024C4 RID: 9412
			// (get) Token: 0x06010C1E RID: 68638 RVA: 0x00066A68 File Offset: 0x00064C68
			[Token(Token = "0x170024C4")]
			public override bool HookGetNextWave
			{
				[Token(Token = "0x6010C1E")]
				[Address(RVA = "0x88A990", Offset = "0x889590", VA = "0x18088A990", Slot = "132")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170024C5 RID: 9413
			// (get) Token: 0x06010C1F RID: 68639 RVA: 0x00066A80 File Offset: 0x00064C80
			[Token(Token = "0x170024C5")]
			public override bool allowPoolManagerUnload
			{
				[Token(Token = "0x6010C1F")]
				[Address(RVA = "0x88AAB0", Offset = "0x8896B0", VA = "0x18088AAB0", Slot = "121")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06010C20 RID: 68640 RVA: 0x00066A98 File Offset: 0x00064C98
			[Token(Token = "0x6010C20")]
			[Address(RVA = "0x8879C0", Offset = "0x8865C0", VA = "0x1808879C0", Slot = "177")]
			public override bool TryHookCheckWaveNotFinish(bool schedulerResult, out bool result)
			{
				return default(bool);
			}

			// Token: 0x06010C21 RID: 68641 RVA: 0x00066AB0 File Offset: 0x00064CB0
			[Token(Token = "0x6010C21")]
			[Address(RVA = "0x8878F0", Offset = "0x8864F0", VA = "0x1808878F0", Slot = "185")]
			public override bool TryGetNextWaveIndexInGameMode(out int index)
			{
				return default(bool);
			}

			// Token: 0x06010C22 RID: 68642 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C22")]
			[Address(RVA = "0x887090", Offset = "0x885C90", VA = "0x180887090", Slot = "148")]
			public override void OnWaveWillStart(LevelData.WaveData waveData)
			{
			}

			// Token: 0x06010C23 RID: 68643 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C23")]
			[Address(RVA = "0x887010", Offset = "0x885C10", VA = "0x180887010", Slot = "149")]
			public override void OnWaveWillFinish(LevelData.WaveData waveData)
			{
			}

			// Token: 0x06010C24 RID: 68644 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C24")]
			[Address(RVA = "0x886E60", Offset = "0x885A60", VA = "0x180886E60", Slot = "161")]
			public override void OnUnitRegistered(Unit unit)
			{
			}

			// Token: 0x06010C25 RID: 68645 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C25")]
			[Address(RVA = "0x886600", Offset = "0x885200", VA = "0x180886600", Slot = "164")]
			public override void OnEnemyFinished(Enemy enemy, Entity.FinishReason reason)
			{
			}

			// Token: 0x06010C26 RID: 68646 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C26")]
			[Address(RVA = "0x885DD0", Offset = "0x8849D0", VA = "0x180885DD0", Slot = "182")]
			public override void FinishGame(Action<BattleController.GameResult, bool> gameOverCallback, BattleController.GameResult result, bool silent = false)
			{
			}

			// Token: 0x06010C27 RID: 68647 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010C27")]
			[Address(RVA = "0x885EB0", Offset = "0x884AB0", VA = "0x180885EB0", Slot = "183")]
			public override object GetActMeta()
			{
				return null;
			}

			// Token: 0x06010C28 RID: 68648 RVA: 0x00066AC8 File Offset: 0x00064CC8
			[Token(Token = "0x6010C28")]
			[Address(RVA = "0x885FB0", Offset = "0x884BB0", VA = "0x180885FB0", Slot = "128")]
			public override float GetCompleteProgress()
			{
				return 0f;
			}

			// Token: 0x06010C29 RID: 68649 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C29")]
			[Address(RVA = "0x886010", Offset = "0x884C10", VA = "0x180886010")]
			public void GetRoundSurviveUnits(List<EnemyDuelRoundSurviveUnit> surviveUnits, List<EnemyDuelRoundBornUnit> bornUnits)
			{
			}

			// Token: 0x06010C2A RID: 68650 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010C2A")]
			[Address(RVA = "0x885D40", Offset = "0x884940", VA = "0x180885D40")]
			public List<GridPosition> CollectSummonPositionByTeamSide(SideTypeIndex teamSide)
			{
				return null;
			}

			// Token: 0x06010C2B RID: 68651 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010C2B")]
			[Address(RVA = "0x8860F0", Offset = "0x884CF0", VA = "0x1808860F0", Slot = "155")]
			public override Scheduler.SchedulerPreprocessor GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x06010C2C RID: 68652 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C2C")]
			[Address(RVA = "0x8867C0", Offset = "0x8853C0", VA = "0x1808867C0")]
			public void OnGameQuit()
			{
			}

			// Token: 0x06010C2D RID: 68653 RVA: 0x00066AE0 File Offset: 0x00064CE0
			[Token(Token = "0x6010C2D")]
			[Address(RVA = "0x887BC0", Offset = "0x8867C0", VA = "0x180887BC0")]
			private bool _CheckGameRealStart()
			{
				return default(bool);
			}

			// Token: 0x06010C2E RID: 68654 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010C2E")]
			[Address(RVA = "0x889000", Offset = "0x887C00", VA = "0x180889000")]
			private static Unit _GetHostEnemyByUid(uint hostUid)
			{
				return null;
			}

			// Token: 0x06010C2F RID: 68655 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C2F")]
			[Address(RVA = "0x88A510", Offset = "0x889110", VA = "0x18088A510")]
			private void _UnregisterEnemyOnScene(uint uid)
			{
			}

			// Token: 0x06010C30 RID: 68656 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C30")]
			[Address(RVA = "0x88A230", Offset = "0x888E30", VA = "0x18088A230")]
			private void _UnregisterEnemyInLevel(IUseTeamSide teamSideEnemy)
			{
			}

			// Token: 0x06010C31 RID: 68657 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C31")]
			[Address(RVA = "0x887C80", Offset = "0x886880", VA = "0x180887C80")]
			private void _CheckRoundFinish()
			{
			}

			// Token: 0x06010C32 RID: 68658 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C32")]
			[Address(RVA = "0x888DE0", Offset = "0x8879E0", VA = "0x180888DE0")]
			private void _FinishRound(EnemyDuelRoundResult result)
			{
			}

			// Token: 0x06010C33 RID: 68659 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010C33")]
			[Address(RVA = "0x887E30", Offset = "0x886A30", VA = "0x180887E30")]
			private IEnumerator _CleanMapForNextRound(EnemyDuelRoundResult result)
			{
				return null;
			}

			// Token: 0x06010C34 RID: 68660 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C34")]
			[Address(RVA = "0x8892C0", Offset = "0x887EC0", VA = "0x1808892C0")]
			private void _OnReceiveRoundBet()
			{
			}

			// Token: 0x06010C35 RID: 68661 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C35")]
			[Address(RVA = "0x889350", Offset = "0x887F50", VA = "0x180889350")]
			private void _OnReceiveRoundSettle()
			{
			}

			// Token: 0x06010C36 RID: 68662 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C36")]
			[Address(RVA = "0x888A50", Offset = "0x887650", VA = "0x180888A50")]
			private void _FinishAllUnitsOnRoundEnd()
			{
			}

			// Token: 0x06010C37 RID: 68663 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C37")]
			[Address(RVA = "0x889690", Offset = "0x888290", VA = "0x180889690")]
			private void _PreprocessOnWaveWillStart()
			{
			}

			// Token: 0x06010C38 RID: 68664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C38")]
			[Address(RVA = "0x8894B0", Offset = "0x8880B0", VA = "0x1808894B0")]
			private void _PreprocessLevelTeam(bool isLeft)
			{
			}

			// Token: 0x06010C39 RID: 68665 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C39")]
			[Address(RVA = "0x888580", Offset = "0x887180", VA = "0x180888580")]
			private void _DoResetTrapOnWaveWillFinish()
			{
			}

			// Token: 0x06010C3A RID: 68666 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C3A")]
			[Address(RVA = "0x887EF0", Offset = "0x886AF0", VA = "0x180887EF0")]
			private void _DoClearOnWaveWillStart()
			{
			}

			// Token: 0x06010C3B RID: 68667 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C3B")]
			[Address(RVA = "0x88A0B0", Offset = "0x888CB0", VA = "0x18088A0B0")]
			private void _TriggerNpcFastForward()
			{
			}

			// Token: 0x06010C3C RID: 68668 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C3C")]
			[Address(RVA = "0x889770", Offset = "0x888370", VA = "0x180889770")]
			private void _RecordRoundFinishUnit()
			{
			}

			// Token: 0x06010C3D RID: 68669 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C3D")]
			[Address(RVA = "0x88A180", Offset = "0x888D80", VA = "0x18088A180")]
			private void _UnloadPool()
			{
			}

			// Token: 0x170024C6 RID: 9414
			// (get) Token: 0x06010C3E RID: 68670 RVA: 0x00066AF8 File Offset: 0x00064CF8
			[Token(Token = "0x170024C6")]
			public bool isInPause
			{
				[Token(Token = "0x6010C3E")]
				[Address(RVA = "0x88AC80", Offset = "0x889880", VA = "0x18088AC80")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06010C3F RID: 68671 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C3F")]
			[Address(RVA = "0x8875F0", Offset = "0x8861F0", VA = "0x1808875F0", Slot = "202")]
			public void SetPaused(bool isPaused)
			{
			}

			// Token: 0x06010C40 RID: 68672 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C40")]
			[Address(RVA = "0x887700", Offset = "0x886300", VA = "0x180887700", Slot = "203")]
			public void SetPrepared()
			{
			}

			// Token: 0x06010C41 RID: 68673 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C41")]
			[Address(RVA = "0x887760", Offset = "0x886360", VA = "0x180887760", Slot = "204")]
			public void SetReady()
			{
			}

			// Token: 0x06010C42 RID: 68674 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C42")]
			[Address(RVA = "0x8876A0", Offset = "0x8862A0", VA = "0x1808876A0", Slot = "205")]
			public void SetPlaying()
			{
			}

			// Token: 0x06010C43 RID: 68675 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C43")]
			[Address(RVA = "0x8877C0", Offset = "0x8863C0", VA = "0x1808877C0", Slot = "206")]
			public void SetUnstable()
			{
			}

			// Token: 0x06010C44 RID: 68676 RVA: 0x00066B10 File Offset: 0x00064D10
			[Token(Token = "0x6010C44")]
			[Address(RVA = "0x886500", Offset = "0x885100", VA = "0x180886500", Slot = "207")]
			public bool NextFrame(bool additional = false)
			{
				return default(bool);
			}

			// Token: 0x06010C45 RID: 68677 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C45")]
			[Address(RVA = "0x885C90", Offset = "0x884890", VA = "0x180885C90", Slot = "208")]
			public void ApplyAction(EnemyDuelServiceAction action)
			{
			}

			// Token: 0x06010C46 RID: 68678 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C46")]
			[Address(RVA = "0x887B50", Offset = "0x886750", VA = "0x180887B50")]
			private void _ApplyOprt_Character(EnemyDuelServiceAction oprt)
			{
			}

			// Token: 0x06010C47 RID: 68679 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C47")]
			[Address(RVA = "0x886860", Offset = "0x885460", VA = "0x180886860")]
			public void OnRoundChanged(EnemyDuelBattleStatus status)
			{
			}

			// Token: 0x06010C48 RID: 68680 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C48")]
			[Address(RVA = "0x8869F0", Offset = "0x8855F0", VA = "0x1808869F0", Slot = "209")]
			public void OnStateChanged(EnemyDuelBattleStatus status)
			{
			}

			// Token: 0x06010C49 RID: 68681 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C49")]
			[Address(RVA = "0x889CA0", Offset = "0x8888A0", VA = "0x180889CA0")]
			private void _ResetRandomSeed(EnemyDuelBattleStatus status)
			{
			}

			// Token: 0x170024C7 RID: 9415
			// (get) Token: 0x06010C4A RID: 68682 RVA: 0x00066B28 File Offset: 0x00064D28
			[Token(Token = "0x170024C7")]
			public bool isPrepared
			{
				[Token(Token = "0x6010C4A")]
				[Address(RVA = "0x88AD40", Offset = "0x889940", VA = "0x18088AD40", Slot = "210")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170024C8 RID: 9416
			// (get) Token: 0x06010C4B RID: 68683 RVA: 0x00066B40 File Offset: 0x00064D40
			[Token(Token = "0x170024C8")]
			public bool isRunning
			{
				[Token(Token = "0x6010C4B")]
				[Address(RVA = "0x88AE00", Offset = "0x889A00", VA = "0x18088AE00", Slot = "211")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170024C9 RID: 9417
			// (get) Token: 0x06010C4C RID: 68684 RVA: 0x00066B58 File Offset: 0x00064D58
			[Token(Token = "0x170024C9")]
			public bool isReady
			{
				[Token(Token = "0x6010C4C")]
				[Address(RVA = "0x88ADA0", Offset = "0x8899A0", VA = "0x18088ADA0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06010C4D RID: 68685 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C4D")]
			[Address(RVA = "0x887390", Offset = "0x885F90", VA = "0x180887390")]
			public void SendBetRequest(string playerId, EnemyDuelChoiceSide side, bool isPlayer, bool isAllIn)
			{
			}

			// Token: 0x06010C4E RID: 68686 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C4E")]
			[Address(RVA = "0x887480", Offset = "0x886080", VA = "0x180887480")]
			public void SendEmojiRequest(string emojiGroup, string emojiId)
			{
			}

			// Token: 0x06010C4F RID: 68687 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C4F")]
			[Address(RVA = "0x887560", Offset = "0x886160", VA = "0x180887560")]
			public void SendQuitRequest()
			{
			}

			// Token: 0x06010C50 RID: 68688 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C50")]
			[Address(RVA = "0x889E30", Offset = "0x888A30", VA = "0x180889E30")]
			private void _SendRoundSettleRequest(EnemyDuelRoundResult result)
			{
			}

			// Token: 0x06010C51 RID: 68689 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C51")]
			[Address(RVA = "0x889220", Offset = "0x887E20", VA = "0x180889220")]
			private void _OnReceiveGameFinish()
			{
			}

			// Token: 0x06010C52 RID: 68690 RVA: 0x00066B70 File Offset: 0x00064D70
			[Token(Token = "0x6010C52")]
			[Address(RVA = "0x83EAA0", Offset = "0x83D6A0", VA = "0x18083EAA0")]
			private GameModeMeta.GameModeType <>xLuaBaseProxy_get_gameModeType()
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}

			// Token: 0x06010C53 RID: 68691 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C53")]
			[Address(RVA = "0x83EA80", Offset = "0x83D680", VA = "0x18083EA80")]
			private void <>xLuaBaseProxy_Init(ref GameModeMeta P0, ref int P1, BattlePlayerData P2, LevelData P3)
			{
			}

			// Token: 0x06010C54 RID: 68692 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C54")]
			[Address(RVA = "0x840AA0", Offset = "0x83F6A0", VA = "0x180840AA0")]
			private void <>xLuaBaseProxy_PreprocessLevelData(LevelData P0)
			{
			}

			// Token: 0x06010C55 RID: 68693 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C55")]
			[Address(RVA = "0x83EA90", Offset = "0x83D690", VA = "0x18083EA90")]
			private void <>xLuaBaseProxy_Tick(Action P0)
			{
			}

			// Token: 0x06010C56 RID: 68694 RVA: 0x00066B88 File Offset: 0x00064D88
			[Token(Token = "0x6010C56")]
			[Address(RVA = "0x85AC10", Offset = "0x859810", VA = "0x18085AC10")]
			private bool <>xLuaBaseProxy_get_allowManualTick()
			{
				return default(bool);
			}

			// Token: 0x06010C57 RID: 68695 RVA: 0x00066BA0 File Offset: 0x00064DA0
			[Token(Token = "0x6010C57")]
			[Address(RVA = "0x867A40", Offset = "0x866640", VA = "0x180867A40")]
			private bool <>xLuaBaseProxy_get_HookGetNextWave()
			{
				return default(bool);
			}

			// Token: 0x06010C58 RID: 68696 RVA: 0x00066BB8 File Offset: 0x00064DB8
			[Token(Token = "0x6010C58")]
			[Address(RVA = "0x85AC20", Offset = "0x859820", VA = "0x18085AC20")]
			private bool <>xLuaBaseProxy_get_allowPoolManagerUnload()
			{
				return default(bool);
			}

			// Token: 0x06010C59 RID: 68697 RVA: 0x00066BD0 File Offset: 0x00064DD0
			[Token(Token = "0x6010C59")]
			[Address(RVA = "0x85EA00", Offset = "0x85D600", VA = "0x18085EA00")]
			private bool <>xLuaBaseProxy_TryHookCheckWaveNotFinish(bool P0, out bool P1)
			{
				return default(bool);
			}

			// Token: 0x06010C5A RID: 68698 RVA: 0x00066BE8 File Offset: 0x00064DE8
			[Token(Token = "0x6010C5A")]
			[Address(RVA = "0x867A20", Offset = "0x866620", VA = "0x180867A20")]
			private bool <>xLuaBaseProxy_TryGetNextWaveIndexInGameMode(out int P0)
			{
				return default(bool);
			}

			// Token: 0x06010C5B RID: 68699 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C5B")]
			[Address(RVA = "0x85E9F0", Offset = "0x85D5F0", VA = "0x18085E9F0")]
			private void <>xLuaBaseProxy_OnWaveWillStart(LevelData.WaveData P0)
			{
			}

			// Token: 0x06010C5C RID: 68700 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C5C")]
			[Address(RVA = "0x85E9E0", Offset = "0x85D5E0", VA = "0x18085E9E0")]
			private void <>xLuaBaseProxy_OnWaveWillFinish(LevelData.WaveData P0)
			{
			}

			// Token: 0x06010C5D RID: 68701 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C5D")]
			[Address(RVA = "0x840A90", Offset = "0x83F690", VA = "0x180840A90")]
			private void <>xLuaBaseProxy_OnUnitRegistered(Unit P0)
			{
			}

			// Token: 0x06010C5E RID: 68702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C5E")]
			[Address(RVA = "0x840A70", Offset = "0x83F670", VA = "0x180840A70")]
			private void <>xLuaBaseProxy_OnEnemyFinished(Enemy P0, Entity.FinishReason P1)
			{
			}

			// Token: 0x06010C5F RID: 68703 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010C5F")]
			[Address(RVA = "0x85AB90", Offset = "0x859790", VA = "0x18085AB90")]
			private void <>xLuaBaseProxy_FinishGame(Action<BattleController.GameResult, bool> P0, BattleController.GameResult P1, bool P2)
			{
			}

			// Token: 0x06010C60 RID: 68704 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010C60")]
			[Address(RVA = "0x858C30", Offset = "0x857830", VA = "0x180858C30")]
			private object <>xLuaBaseProxy_GetActMeta()
			{
				return null;
			}

			// Token: 0x06010C61 RID: 68705 RVA: 0x00066C00 File Offset: 0x00064E00
			[Token(Token = "0x6010C61")]
			[Address(RVA = "0x85ABA0", Offset = "0x8597A0", VA = "0x18085ABA0")]
			private float <>xLuaBaseProxy_GetCompleteProgress()
			{
				return 0f;
			}

			// Token: 0x06010C62 RID: 68706 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010C62")]
			[Address(RVA = "0x83EA70", Offset = "0x83D670", VA = "0x18083EA70")]
			private Scheduler.SchedulerPreprocessor <>xLuaBaseProxy_GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x04012C71 RID: 76913
			[Token(Token = "0x4012C71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private GameModeFactory.EnemyDuelGameMode.InternalState m_state;

			// Token: 0x04012C72 RID: 76914
			[Token(Token = "0x4012C72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int m_roundIndex;

			// Token: 0x04012C73 RID: 76915
			[Token(Token = "0x4012C73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool m_isRoundFinish;

			// Token: 0x04012C74 RID: 76916
			[Token(Token = "0x4012C74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private EnemyDuelInput m_inputData;

			// Token: 0x04012C75 RID: 76917
			[Token(Token = "0x4012C75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private ActivityEnemyDuelData m_actData;

			// Token: 0x04012C76 RID: 76918
			[Token(Token = "0x4012C76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ActivityEnemyDuelModeData m_modeData;

			// Token: 0x04012C77 RID: 76919
			[Token(Token = "0x4012C77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private string m_subModeID;

			// Token: 0x04012C78 RID: 76920
			[Token(Token = "0x4012C78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private bool m_isMultiPlayer;

			// Token: 0x04012C79 RID: 76921
			[Token(Token = "0x4012C79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private readonly List<uint> m_teamOnSceneRight;

			// Token: 0x04012C7A RID: 76922
			[Token(Token = "0x4012C7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private readonly List<uint> m_teamOnSceneLeft;

			// Token: 0x04012C7B RID: 76923
			[Token(Token = "0x4012C7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private readonly List<EnemyDuelRoundSurviveUnit> m_roundSurviveUnits;

			// Token: 0x04012C7C RID: 76924
			[Token(Token = "0x4012C7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private readonly List<EnemyDuelRoundBornUnit> m_roundBornUnits;

			// Token: 0x04012C7D RID: 76925
			[Token(Token = "0x4012C7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private EnemyDuelRoundBornUnit m_curRoundBornUnit;

			// Token: 0x04012C7E RID: 76926
			[Token(Token = "0x4012C7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private string m_actId;

			// Token: 0x04012C7F RID: 76927
			[Token(Token = "0x4012C7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private string m_sceneId;

			// Token: 0x04012C80 RID: 76928
			[Token(Token = "0x4012C80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private bool m_isGiveUp;

			// Token: 0x04012C81 RID: 76929
			[Token(Token = "0x4012C81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
			private bool m_canWaveFinish;

			// Token: 0x04012C82 RID: 76930
			[Token(Token = "0x4012C82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private readonly GameModeFactory.EnemyDuelGameMode.EnemyDuelWaveManager m_waveManager;

			// Token: 0x04012C83 RID: 76931
			[Token(Token = "0x4012C83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private readonly GameModeFactory.EnemyDuelGameMode.EnemyDuelPlayerManager m_playerManager;

			// Token: 0x04012C84 RID: 76932
			[Token(Token = "0x4012C84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private readonly BattleController.FrameData m_frameData;

			// Token: 0x04012C85 RID: 76933
			[Token(Token = "0x4012C85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private CoroutineId m_coroutine;

			// Token: 0x04012C86 RID: 76934
			[Token(Token = "0x4012C86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private readonly Dictionary<string, int> m_teamOnRoundLeft;

			// Token: 0x04012C87 RID: 76935
			[Token(Token = "0x4012C87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private readonly Dictionary<string, int> m_teamOnRoundRight;

			// Token: 0x04012C88 RID: 76936
			[Token(Token = "0x4012C88")]
			private const int MULTI_PLAYER_MODE_INIT_INDEX = -2;

			// Token: 0x04012C89 RID: 76937
			[Token(Token = "0x4012C89")]
			private const float WIN_WAIT_TIME = 2f;

			// Token: 0x04012C8A RID: 76938
			[Token(Token = "0x4012C8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private EnemyDuelServiceGameState m_roundState;

			// Token: 0x04012C8B RID: 76939
			[Token(Token = "0x4012C8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			private bool m_isInPause;

			// Token: 0x04012C8C RID: 76940
			[Token(Token = "0x4012C8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private int m_curRoundSeed;

			// Token: 0x04012C8D RID: 76941
			[Token(Token = "0x4012C8D")]
			public const string BRANCH_KEY_LEFT = "branch_key_left";

			// Token: 0x04012C8E RID: 76942
			[Token(Token = "0x4012C8E")]
			public const string BRANCH_KEY_RIGHT = "branch_key_right";

			// Token: 0x04012C8F RID: 76943
			[Token(Token = "0x4012C8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isMultiplayer;

			// Token: 0x04012C90 RID: 76944
			[Token(Token = "0x4012C90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04012C91 RID: 76945
			[Token(Token = "0x4012C91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_instance;

			// Token: 0x04012C92 RID: 76946
			[Token(Token = "0x4012C92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_actId;

			// Token: 0x04012C93 RID: 76947
			[Token(Token = "0x4012C93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_gameModeType;

			// Token: 0x04012C94 RID: 76948
			[Token(Token = "0x4012C94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_teamOnSceneLeftCount;

			// Token: 0x04012C95 RID: 76949
			[Token(Token = "0x4012C95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_teamOnSceneRightCount;

			// Token: 0x04012C96 RID: 76950
			[Token(Token = "0x4012C96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x04012C97 RID: 76951
			[Token(Token = "0x4012C97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_PreprocessLevelData;

			// Token: 0x04012C98 RID: 76952
			[Token(Token = "0x4012C98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_Tick;

			// Token: 0x04012C99 RID: 76953
			[Token(Token = "0x4012C99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_allowManualTick;

			// Token: 0x04012C9A RID: 76954
			[Token(Token = "0x4012C9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_HookGetNextWave;

			// Token: 0x04012C9B RID: 76955
			[Token(Token = "0x4012C9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_allowPoolManagerUnload;

			// Token: 0x04012C9C RID: 76956
			[Token(Token = "0x4012C9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_TryHookCheckWaveNotFinish;

			// Token: 0x04012C9D RID: 76957
			[Token(Token = "0x4012C9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_TryGetNextWaveIndexInGameMode;

			// Token: 0x04012C9E RID: 76958
			[Token(Token = "0x4012C9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_OnWaveWillStart;

			// Token: 0x04012C9F RID: 76959
			[Token(Token = "0x4012C9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_OnWaveWillFinish;

			// Token: 0x04012CA0 RID: 76960
			[Token(Token = "0x4012CA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_OnUnitRegistered;

			// Token: 0x04012CA1 RID: 76961
			[Token(Token = "0x4012CA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_OnEnemyFinished;

			// Token: 0x04012CA2 RID: 76962
			[Token(Token = "0x4012CA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_FinishGame;

			// Token: 0x04012CA3 RID: 76963
			[Token(Token = "0x4012CA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_GetActMeta;

			// Token: 0x04012CA4 RID: 76964
			[Token(Token = "0x4012CA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_GetCompleteProgress;

			// Token: 0x04012CA5 RID: 76965
			[Token(Token = "0x4012CA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_GetRoundSurviveUnits;

			// Token: 0x04012CA6 RID: 76966
			[Token(Token = "0x4012CA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_CollectSummonPositionByTeamSide;

			// Token: 0x04012CA7 RID: 76967
			[Token(Token = "0x4012CA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_GetSchedulerPreprocessor;

			// Token: 0x04012CA8 RID: 76968
			[Token(Token = "0x4012CA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_OnGameQuit;

			// Token: 0x04012CA9 RID: 76969
			[Token(Token = "0x4012CA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0__CheckGameRealStart;

			// Token: 0x04012CAA RID: 76970
			[Token(Token = "0x4012CAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0__GetHostEnemyByUid;

			// Token: 0x04012CAB RID: 76971
			[Token(Token = "0x4012CAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0__UnregisterEnemyOnScene;

			// Token: 0x04012CAC RID: 76972
			[Token(Token = "0x4012CAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0__UnregisterEnemyInLevel;

			// Token: 0x04012CAD RID: 76973
			[Token(Token = "0x4012CAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private static DelegateBridge __Hotfix0__CheckRoundFinish;

			// Token: 0x04012CAE RID: 76974
			[Token(Token = "0x4012CAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private static DelegateBridge __Hotfix0__FinishRound;

			// Token: 0x04012CAF RID: 76975
			[Token(Token = "0x4012CAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			private static DelegateBridge __Hotfix0__CleanMapForNextRound;

			// Token: 0x04012CB0 RID: 76976
			[Token(Token = "0x4012CB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private static DelegateBridge __Hotfix0__OnReceiveRoundBet;

			// Token: 0x04012CB1 RID: 76977
			[Token(Token = "0x4012CB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private static DelegateBridge __Hotfix0__OnReceiveRoundSettle;

			// Token: 0x04012CB2 RID: 76978
			[Token(Token = "0x4012CB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private static DelegateBridge __Hotfix0__FinishAllUnitsOnRoundEnd;

			// Token: 0x04012CB3 RID: 76979
			[Token(Token = "0x4012CB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private static DelegateBridge __Hotfix0__PreprocessOnWaveWillStart;

			// Token: 0x04012CB4 RID: 76980
			[Token(Token = "0x4012CB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private static DelegateBridge __Hotfix0__PreprocessLevelTeam;

			// Token: 0x04012CB5 RID: 76981
			[Token(Token = "0x4012CB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private static DelegateBridge __Hotfix0__DoResetTrapOnWaveWillFinish;

			// Token: 0x04012CB6 RID: 76982
			[Token(Token = "0x4012CB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private static DelegateBridge __Hotfix0__DoClearOnWaveWillStart;

			// Token: 0x04012CB7 RID: 76983
			[Token(Token = "0x4012CB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private static DelegateBridge __Hotfix0__TriggerNpcFastForward;

			// Token: 0x04012CB8 RID: 76984
			[Token(Token = "0x4012CB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			private static DelegateBridge __Hotfix0__RecordRoundFinishUnit;

			// Token: 0x04012CB9 RID: 76985
			[Token(Token = "0x4012CB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			private static DelegateBridge __Hotfix0__UnloadPool;

			// Token: 0x04012CBA RID: 76986
			[Token(Token = "0x4012CBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			private static DelegateBridge __Hotfix0_get_isInPause;

			// Token: 0x04012CBB RID: 76987
			[Token(Token = "0x4012CBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			private static DelegateBridge __Hotfix0_SetPaused;

			// Token: 0x04012CBC RID: 76988
			[Token(Token = "0x4012CBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private static DelegateBridge __Hotfix0_SetPrepared;

			// Token: 0x04012CBD RID: 76989
			[Token(Token = "0x4012CBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			private static DelegateBridge __Hotfix0_SetReady;

			// Token: 0x04012CBE RID: 76990
			[Token(Token = "0x4012CBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private static DelegateBridge __Hotfix0_SetPlaying;

			// Token: 0x04012CBF RID: 76991
			[Token(Token = "0x4012CBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
			private static DelegateBridge __Hotfix0_SetUnstable;

			// Token: 0x04012CC0 RID: 76992
			[Token(Token = "0x4012CC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private static DelegateBridge __Hotfix0_NextFrame;

			// Token: 0x04012CC1 RID: 76993
			[Token(Token = "0x4012CC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
			private static DelegateBridge __Hotfix0_ApplyAction;

			// Token: 0x04012CC2 RID: 76994
			[Token(Token = "0x4012CC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private static DelegateBridge __Hotfix0__ApplyOprt_Character;

			// Token: 0x04012CC3 RID: 76995
			[Token(Token = "0x4012CC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
			private static DelegateBridge __Hotfix0_OnRoundChanged;

			// Token: 0x04012CC4 RID: 76996
			[Token(Token = "0x4012CC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private static DelegateBridge __Hotfix0_OnStateChanged;

			// Token: 0x04012CC5 RID: 76997
			[Token(Token = "0x4012CC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
			private static DelegateBridge __Hotfix0__ResetRandomSeed;

			// Token: 0x04012CC6 RID: 76998
			[Token(Token = "0x4012CC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private static DelegateBridge __Hotfix0_get_isPrepared;

			// Token: 0x04012CC7 RID: 76999
			[Token(Token = "0x4012CC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
			private static DelegateBridge __Hotfix0_get_isRunning;

			// Token: 0x04012CC8 RID: 77000
			[Token(Token = "0x4012CC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private static DelegateBridge __Hotfix0_get_isReady;

			// Token: 0x04012CC9 RID: 77001
			[Token(Token = "0x4012CC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
			private static DelegateBridge __Hotfix0_SendBetRequest;

			// Token: 0x04012CCA RID: 77002
			[Token(Token = "0x4012CCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private static DelegateBridge __Hotfix0_SendEmojiRequest;

			// Token: 0x04012CCB RID: 77003
			[Token(Token = "0x4012CCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private static DelegateBridge __Hotfix0_SendQuitRequest;

			// Token: 0x04012CCC RID: 77004
			[Token(Token = "0x4012CCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private static DelegateBridge __Hotfix0__SendRoundSettleRequest;

			// Token: 0x04012CCD RID: 77005
			[Token(Token = "0x4012CCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private static DelegateBridge __Hotfix0__OnReceiveGameFinish;

			// Token: 0x020027CF RID: 10191
			[Token(Token = "0x20027CF")]
			private enum InternalState
			{
				// Token: 0x04012CCF RID: 77007
				[Token(Token = "0x4012CCF")]
				NONE,
				// Token: 0x04012CD0 RID: 77008
				[Token(Token = "0x4012CD0")]
				PREPARED,
				// Token: 0x04012CD1 RID: 77009
				[Token(Token = "0x4012CD1")]
				READY,
				// Token: 0x04012CD2 RID: 77010
				[Token(Token = "0x4012CD2")]
				PLAYING
			}

			// Token: 0x020027D0 RID: 10192
			[Token(Token = "0x20027D0")]
			public class EnemyDuelPlayerManager : IHotfixable
			{
				// Token: 0x06010C63 RID: 68707 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C63")]
				[Address(RVA = "0x88F870", Offset = "0x88E470", VA = "0x18088F870")]
				public void InitPlayers(LevelData levelData, ActivityEnemyDuelData actData, ActivityEnemyDuelModeData subModeData, EnemyDuelInput inputData)
				{
				}

				// Token: 0x06010C64 RID: 68708 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C64")]
				[Address(RVA = "0x88F9F0", Offset = "0x88E5F0", VA = "0x18088F9F0")]
				public void ResetSeed(int seed)
				{
				}

				// Token: 0x06010C65 RID: 68709 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C65")]
				[Address(RVA = "0x88F980", Offset = "0x88E580", VA = "0x18088F980")]
				public void PreparePlayerDataBeforeWaveStart(int curRoundIndex)
				{
				}

				// Token: 0x06010C66 RID: 68710 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C66")]
				[Address(RVA = "0x88F680", Offset = "0x88E280", VA = "0x18088F680")]
				public void CalculateNpcChoiceOnBet(GameModeFactory.EnemyDuelGameMode gameMode, ActivityEnemyDuelRoundData roundData)
				{
				}

				// Token: 0x06010C67 RID: 68711 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C67")]
				[Address(RVA = "0x88F720", Offset = "0x88E320", VA = "0x18088F720")]
				public void CalculateNpcFinalScore(int remainingRoundCnt, int roundIndex, List<ActivityEnemyDuelRoundData> roundDataList)
				{
				}

				// Token: 0x06010C68 RID: 68712 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C68")]
				[Address(RVA = "0x891CF0", Offset = "0x8908F0", VA = "0x180891CF0")]
				private void _ProcessPlayerData(ActivityEnemyDuelData battleData, EnemyDuelInput inputData)
				{
				}

				// Token: 0x06010C69 RID: 68713 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C69")]
				[Address(RVA = "0x891850", Offset = "0x890450", VA = "0x180891850")]
				private void _ProcessNpcData(ActivityEnemyDuelData battleData, Dictionary<string, EnemyDuelPlayerData> playerDataDict, List<string> npcIds)
				{
				}

				// Token: 0x06010C6A RID: 68714 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C6A")]
				[Address(RVA = "0x891180", Offset = "0x88FD80", VA = "0x180891180")]
				private void _ProcessNpcData(ActivityEnemyDuelData battleData, int npcCnt, Dictionary<string, EnemyDuelPlayerData> playerDataDict)
				{
				}

				// Token: 0x06010C6B RID: 68715 RVA: 0x00066C18 File Offset: 0x00064E18
				[Token(Token = "0x6010C6B")]
				[Address(RVA = "0x890FE0", Offset = "0x88FBE0", VA = "0x180890FE0")]
				private int _GetNpcSurviveCnt(Dictionary<string, EnemyDuelPlayerData> playerDataDict)
				{
					return 0;
				}

				// Token: 0x06010C6C RID: 68716 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C6C")]
				[Address(RVA = "0x8908E0", Offset = "0x88F4E0", VA = "0x1808908E0")]
				private void _CalculateRestNpcResult(List<ActivityEnemyDuelRoundData> roundDataList, int fakeRound, Dictionary<string, EnemyDuelPlayerData> playerDataDic)
				{
				}

				// Token: 0x06010C6D RID: 68717 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C6D")]
				[Address(RVA = "0x890520", Offset = "0x88F120", VA = "0x180890520")]
				private void _CalculateNpcChoice(GameModeFactory.EnemyDuelGameMode gameMode, ActivityEnemyDuelRoundData roundData)
				{
				}

				// Token: 0x06010C6E RID: 68718 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C6E")]
				[Address(RVA = "0x88FE80", Offset = "0x88EA80", VA = "0x18088FE80")]
				private void _CalculateDefaultStrategy(EnemyDuelPlayerData npc, ActivityEnemyDuelNpcData data)
				{
				}

				// Token: 0x06010C6F RID: 68719 RVA: 0x00066C30 File Offset: 0x00064E30
				[Token(Token = "0x6010C6F")]
				[Address(RVA = "0x890BB0", Offset = "0x88F7B0", VA = "0x180890BB0")]
				private float _CalculateTeamScoreBySide(bool isLeft, ActivityEnemyDuelNpcData npcInfoData)
				{
					return 0f;
				}

				// Token: 0x06010C70 RID: 68720 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C70")]
				[Address(RVA = "0x88FCF0", Offset = "0x88E8F0", VA = "0x18088FCF0")]
				private void _CalculateChooseWinStrategy(EnemyDuelPlayerData npc)
				{
				}

				// Token: 0x06010C71 RID: 68721 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C71")]
				[Address(RVA = "0x88FBD0", Offset = "0x88E7D0", VA = "0x18088FBD0")]
				private void _CalculateChooseOddStrategy(EnemyDuelPlayerData npc)
				{
				}

				// Token: 0x06010C72 RID: 68722 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C72")]
				[Address(RVA = "0x890100", Offset = "0x88ED00", VA = "0x180890100")]
				private void _CalculateFollowStrategy(EnemyDuelPlayerData npc, bool isFollowMore, Dictionary<string, EnemyDuelPlayerData> playerDataDict)
				{
				}

				// Token: 0x06010C73 RID: 68723 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C73")]
				[Address(RVA = "0x88FA70", Offset = "0x88E670", VA = "0x18088FA70")]
				private void _CalculateChooseByEnemyCountParityStrategy(EnemyDuelPlayerData npc, bool chooseOdd)
				{
				}

				// Token: 0x06010C74 RID: 68724 RVA: 0x00066C48 File Offset: 0x00064E48
				[Token(Token = "0x6010C74")]
				[Address(RVA = "0x890E40", Offset = "0x88FA40", VA = "0x180890E40")]
				private int _GetEnemyCountParityBySide(bool isLeft)
				{
					return 0;
				}

				// Token: 0x06010C75 RID: 68725 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C75")]
				[Address(RVA = "0x88FFC0", Offset = "0x88EBC0", VA = "0x18088FFC0")]
				private void _CalculateFixedChoiceStrategy(EnemyDuelPlayerData npc, bool alwaysLeft)
				{
				}

				// Token: 0x06010C76 RID: 68726 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C76")]
				[Address(RVA = "0x8922C0", Offset = "0x890EC0", VA = "0x1808922C0")]
				private void _RefreshNpcChoice(EnemyDuelPlayerData npc, float scoreLeft, float scoreRight)
				{
				}

				// Token: 0x06010C77 RID: 68727 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C77")]
				[Address(RVA = "0x892370", Offset = "0x890F70", VA = "0x180892370")]
				public EnemyDuelPlayerManager()
				{
				}

				// Token: 0x04012CD3 RID: 77011
				[Token(Token = "0x4012CD3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private int m_curRoundIndex;

				// Token: 0x04012CD4 RID: 77012
				[Token(Token = "0x4012CD4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private readonly List<EnemyDuelNpcSortData> m_npcSortList;

				// Token: 0x04012CD5 RID: 77013
				[Token(Token = "0x4012CD5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private readonly Dictionary<EnemyDuelNpcSelector, float> m_npcSelectorData;

				// Token: 0x04012CD6 RID: 77014
				[Token(Token = "0x4012CD6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private EnemyDuelPlayerData m_selfPlayerData;

				// Token: 0x04012CD7 RID: 77015
				[Token(Token = "0x4012CD7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private ActivityEnemyDuelModeData m_subModeData;

				// Token: 0x04012CD8 RID: 77016
				[Token(Token = "0x4012CD8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private ActivityEnemyDuelData m_actData;

				// Token: 0x04012CD9 RID: 77017
				[Token(Token = "0x4012CD9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private System.Random m_playerRandom;

				// Token: 0x04012CDA RID: 77018
				[Token(Token = "0x4012CDA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private bool m_hasNpcPlayer;

				// Token: 0x04012CDB RID: 77019
				[Token(Token = "0x4012CDB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_InitPlayers;

				// Token: 0x04012CDC RID: 77020
				[Token(Token = "0x4012CDC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_ResetSeed;

				// Token: 0x04012CDD RID: 77021
				[Token(Token = "0x4012CDD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_PreparePlayerDataBeforeWaveStart;

				// Token: 0x04012CDE RID: 77022
				[Token(Token = "0x4012CDE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_CalculateNpcChoiceOnBet;

				// Token: 0x04012CDF RID: 77023
				[Token(Token = "0x4012CDF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_CalculateNpcFinalScore;

				// Token: 0x04012CE0 RID: 77024
				[Token(Token = "0x4012CE0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0__ProcessPlayerData;

				// Token: 0x04012CE1 RID: 77025
				[Token(Token = "0x4012CE1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0__ProcessNpcData;

				// Token: 0x04012CE2 RID: 77026
				[Token(Token = "0x4012CE2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix1__ProcessNpcData;

				// Token: 0x04012CE3 RID: 77027
				[Token(Token = "0x4012CE3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0__GetNpcSurviveCnt;

				// Token: 0x04012CE4 RID: 77028
				[Token(Token = "0x4012CE4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge __Hotfix0__CalculateRestNpcResult;

				// Token: 0x04012CE5 RID: 77029
				[Token(Token = "0x4012CE5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0__CalculateNpcChoice;

				// Token: 0x04012CE6 RID: 77030
				[Token(Token = "0x4012CE6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge __Hotfix0__CalculateDefaultStrategy;

				// Token: 0x04012CE7 RID: 77031
				[Token(Token = "0x4012CE7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				private static DelegateBridge __Hotfix0__CalculateTeamScoreBySide;

				// Token: 0x04012CE8 RID: 77032
				[Token(Token = "0x4012CE8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private static DelegateBridge __Hotfix0__CalculateChooseWinStrategy;

				// Token: 0x04012CE9 RID: 77033
				[Token(Token = "0x4012CE9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private static DelegateBridge __Hotfix0__CalculateChooseOddStrategy;

				// Token: 0x04012CEA RID: 77034
				[Token(Token = "0x4012CEA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				private static DelegateBridge __Hotfix0__CalculateFollowStrategy;

				// Token: 0x04012CEB RID: 77035
				[Token(Token = "0x4012CEB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				private static DelegateBridge __Hotfix0__CalculateChooseByEnemyCountParityStrategy;

				// Token: 0x04012CEC RID: 77036
				[Token(Token = "0x4012CEC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				private static DelegateBridge __Hotfix0__GetEnemyCountParityBySide;

				// Token: 0x04012CED RID: 77037
				[Token(Token = "0x4012CED")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
				private static DelegateBridge __Hotfix0__CalculateFixedChoiceStrategy;

				// Token: 0x04012CEE RID: 77038
				[Token(Token = "0x4012CEE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
				private static DelegateBridge __Hotfix0__RefreshNpcChoice;

				// Token: 0x04012CEF RID: 77039
				[Token(Token = "0x4012CEF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020027D2 RID: 10194
			[Token(Token = "0x20027D2")]
			public class EnemyDuelWaveManager : IHotfixable
			{
				// Token: 0x06010C7C RID: 68732 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C7C")]
				[Address(RVA = "0x892900", Offset = "0x891500", VA = "0x180892900")]
				public void Init(LevelData levelData, ActivityEnemyDuelData actData, ActivityEnemyDuelModeData modeData)
				{
				}

				// Token: 0x06010C7D RID: 68733 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C7D")]
				[Address(RVA = "0x892530", Offset = "0x891130", VA = "0x180892530")]
				public void GenerateNextWaves(int roundIndex)
				{
				}

				// Token: 0x06010C7E RID: 68734 RVA: 0x00066C90 File Offset: 0x00064E90
				[Token(Token = "0x6010C7E")]
				[Address(RVA = "0x892830", Offset = "0x891430", VA = "0x180892830")]
				public int GetRemainingRoundCnt(int roundIndex)
				{
					return 0;
				}

				// Token: 0x06010C7F RID: 68735 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010C7F")]
				[Address(RVA = "0x892760", Offset = "0x891360", VA = "0x180892760")]
				public ActivityEnemyDuelRoundData GetCurRoundData(int roundIndex)
				{
					return null;
				}

				// Token: 0x06010C80 RID: 68736 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010C80")]
				[Address(RVA = "0x8928A0", Offset = "0x8914A0", VA = "0x1808928A0")]
				public List<ActivityEnemyDuelRoundData> GetRoundData()
				{
					return null;
				}

				// Token: 0x06010C81 RID: 68737 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010C81")]
				[Address(RVA = "0x892480", Offset = "0x891080", VA = "0x180892480")]
				public List<GridPosition> CollectSummonPositionByTeamSide(SideTypeIndex teamSide)
				{
					return null;
				}

				// Token: 0x06010C82 RID: 68738 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C82")]
				[Address(RVA = "0x896200", Offset = "0x894E00", VA = "0x180896200")]
				private void _ProcessRoundData(ActivityEnemyDuelData actData, ActivityEnemyDuelModeData modeData)
				{
				}

				// Token: 0x06010C83 RID: 68739 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C83")]
				[Address(RVA = "0x895D30", Offset = "0x894930", VA = "0x180895D30")]
				private void _ProcessPoolData(ActivityEnemyDuelData actData, string poolKey)
				{
				}

				// Token: 0x06010C84 RID: 68740 RVA: 0x00066CA8 File Offset: 0x00064EA8
				[Token(Token = "0x6010C84")]
				[Address(RVA = "0x8957C0", Offset = "0x8943C0", VA = "0x1808957C0")]
				private float _GetWeightByPoolTypeString(EnemyDuelRoundPoolType poolType, ActivityEnemyDuelPoolData poolData)
				{
					return 0f;
				}

				// Token: 0x06010C85 RID: 68741 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C85")]
				[Address(RVA = "0x895A00", Offset = "0x894600", VA = "0x180895A00")]
				private void _ProcessEnemyData()
				{
				}

				// Token: 0x06010C86 RID: 68742 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010C86")]
				[Address(RVA = "0x894E10", Offset = "0x893A10", VA = "0x180894E10")]
				private LevelData.WaveData _GenerateRound(int round)
				{
					return null;
				}

				// Token: 0x06010C87 RID: 68743 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C87")]
				[Address(RVA = "0x894860", Offset = "0x893460", VA = "0x180894860")]
				private void _GenerateDefaultBranch()
				{
				}

				// Token: 0x06010C88 RID: 68744 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C88")]
				[Address(RVA = "0x896570", Offset = "0x895170", VA = "0x180896570")]
				private void _SelectEnemyForEachTeam(List<EnemyDuelEnemyGenerationData> selected, Dictionary<string, EnemyDuelEnemyGenerationData> enemyForTheRound, int typeCnt, string enemyPoolKey)
				{
				}

				// Token: 0x06010C89 RID: 68745 RVA: 0x00066CC0 File Offset: 0x00064EC0
				[Token(Token = "0x6010C89")]
				[Address(RVA = "0x892F60", Offset = "0x891B60", VA = "0x180892F60")]
				private bool _AvailableEnemy(string enemyId)
				{
					return default(bool);
				}

				// Token: 0x06010C8A RID: 68746 RVA: 0x00066CD8 File Offset: 0x00064ED8
				[Token(Token = "0x6010C8A")]
				[Address(RVA = "0x8952E0", Offset = "0x893EE0", VA = "0x1808952E0")]
				private int _GetActionCnt()
				{
					return 0;
				}

				// Token: 0x06010C8B RID: 68747 RVA: 0x00066CF0 File Offset: 0x00064EF0
				[Token(Token = "0x6010C8B")]
				[Address(RVA = "0x8953C0", Offset = "0x893FC0", VA = "0x1808953C0")]
				private int _GetBranchActionCnt()
				{
					return 0;
				}

				// Token: 0x06010C8C RID: 68748 RVA: 0x00066D08 File Offset: 0x00064F08
				[Token(Token = "0x6010C8C")]
				[Address(RVA = "0x895960", Offset = "0x894560", VA = "0x180895960")]
				private bool _NeedRoute(LevelData.WaveData.FragmentData.ActionData action)
				{
					return default(bool);
				}

				// Token: 0x06010C8D RID: 68749 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C8D")]
				[Address(RVA = "0x896DB0", Offset = "0x8959B0", VA = "0x180896DB0")]
				private void _UpdateRoutes()
				{
				}

				// Token: 0x06010C8E RID: 68750 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C8E")]
				[Address(RVA = "0x896990", Offset = "0x895590", VA = "0x180896990")]
				private void _UpdateExtraRoutes()
				{
				}

				// Token: 0x06010C8F RID: 68751 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010C8F")]
				[Address(RVA = "0x894C90", Offset = "0x893890", VA = "0x180894C90")]
				private LevelData.WaveData _GenerateDefaultWave()
				{
					return null;
				}

				// Token: 0x06010C90 RID: 68752 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C90")]
				[Address(RVA = "0x892A70", Offset = "0x891670", VA = "0x180892A70")]
				private void _AssignPointsToEachEnemy(float score, string tileKey, List<EnemyDuelEnemyGenerationData> enemyList, bool unharmful, LevelData.WaveData outWave)
				{
				}

				// Token: 0x06010C91 RID: 68753 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C91")]
				[Address(RVA = "0x893D80", Offset = "0x892980", VA = "0x180893D80")]
				private void _GenerateActionsByPriority(string tileKey, List<EnemyDuelEnemyGenerationData> enemyList, bool unharmful, LevelData.WaveData outWave)
				{
				}

				// Token: 0x06010C92 RID: 68754 RVA: 0x00066D20 File Offset: 0x00064F20
				[Token(Token = "0x6010C92")]
				[Address(RVA = "0x895600", Offset = "0x894200", VA = "0x180895600")]
				private int _GetDifferentActionCountById(List<LevelData.WaveData.FragmentData.ActionData> actions, bool unharmful, string enemyId)
				{
					return 0;
				}

				// Token: 0x06010C93 RID: 68755 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010C93")]
				[Address(RVA = "0x893620", Offset = "0x892220", VA = "0x180893620")]
				private List<GridPosition> _CollectSpawnPositions(string tileKey)
				{
					return null;
				}

				// Token: 0x06010C94 RID: 68756 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6010C94")]
				[Address(RVA = "0x893040", Offset = "0x891C40", VA = "0x180893040")]
				private List<GridPosition> _CollectSpawnPositionsForSurpriseAttacker(bool isLeft)
				{
					return null;
				}

				// Token: 0x06010C95 RID: 68757 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C95")]
				[Address(RVA = "0x893AA0", Offset = "0x8926A0", VA = "0x180893AA0")]
				private void _GenerateAction(EnemyDuelEnemyGenerationData enemy, GridPosition position, float spawnDelay, bool unharmful, List<RouteData> routes, List<LevelData.WaveData.FragmentData.ActionData> actions)
				{
				}

				// Token: 0x06010C96 RID: 68758 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C96")]
				[Address(RVA = "0x893820", Offset = "0x892420", VA = "0x180893820")]
				private void _GenerateActionForBranch(string enemyId, GridPosition position, float spawnDelay, bool unharmful, List<RouteData> extraRoutes, List<LevelData.WaveData.FragmentData.ActionData> actions)
				{
				}

				// Token: 0x06010C97 RID: 68759 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010C97")]
				[Address(RVA = "0x897150", Offset = "0x895D50", VA = "0x180897150")]
				public EnemyDuelWaveManager()
				{
				}

				// Token: 0x04012CF3 RID: 77043
				[Token(Token = "0x4012CF3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private LevelData m_levelData;

				// Token: 0x04012CF4 RID: 77044
				[Token(Token = "0x4012CF4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private readonly Dictionary<string, EnemyDuelEnemyGenerationData> m_allEnemyExtraData;

				// Token: 0x04012CF5 RID: 77045
				[Token(Token = "0x4012CF5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private readonly List<ActivityEnemyDuelRoundData> m_roundDataList;

				// Token: 0x04012CF6 RID: 77046
				[Token(Token = "0x4012CF6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private readonly Dictionary<string, List<EnemyDuelPoolDataWithWeight>> m_poolDataDict;

				// Token: 0x04012CF7 RID: 77047
				[Token(Token = "0x4012CF7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private readonly Dictionary<string, List<GridPosition>> m_startPos;

				// Token: 0x04012CF8 RID: 77048
				[Token(Token = "0x4012CF8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private readonly List<List<GridPosition>> m_startPosForLeftSurpriseAttacker;

				// Token: 0x04012CF9 RID: 77049
				[Token(Token = "0x4012CF9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private readonly List<List<GridPosition>> m_startPosForRightSurpriseAttacker;

				// Token: 0x04012CFA RID: 77050
				[Token(Token = "0x4012CFA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private int m_maxRoundCnt;

				// Token: 0x04012CFB RID: 77051
				[Token(Token = "0x4012CFB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
				private int m_hasGenerateRound;

				// Token: 0x04012CFC RID: 77052
				[Token(Token = "0x4012CFC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private readonly RouteData.CheckpointData m_checkpointData;

				// Token: 0x04012CFD RID: 77053
				[Token(Token = "0x4012CFD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private readonly Vector2 m_spawnRandomRange;

				// Token: 0x04012CFE RID: 77054
				[Token(Token = "0x4012CFE")]
				private const float ROUND_END_WAIT_TIME = 2f;

				// Token: 0x04012CFF RID: 77055
				[Token(Token = "0x4012CFF")]
				private const float ENEMY_WAVE_INTERVAL = 1.5f;

				// Token: 0x04012D00 RID: 77056
				[Token(Token = "0x4012D00")]
				private const float MAX_ENEMY_COST = 999999f;

				// Token: 0x04012D01 RID: 77057
				[Token(Token = "0x4012D01")]
				private const float MAX_WAIT_TIME = 10000f;

				// Token: 0x04012D02 RID: 77058
				[Token(Token = "0x4012D02")]
				private const float MIN_LAST_ENEMY_PROB = 0.02f;

				// Token: 0x04012D03 RID: 77059
				[Token(Token = "0x4012D03")]
				private const string TILE_START = "tile_start_dqq";

				// Token: 0x04012D04 RID: 77060
				[Token(Token = "0x4012D04")]
				private const string TILE_END = "tile_end_dqq";

				// Token: 0x04012D05 RID: 77061
				[Token(Token = "0x4012D05")]
				private const string SURPRISE_ATTACKER_SPAWN_POSITION = "surprise_attacker_spawn_position";

				// Token: 0x04012D06 RID: 77062
				[Token(Token = "0x4012D06")]
				private const int ENEMY_SPAWN_POSITION_COUNT = 1;

				// Token: 0x04012D07 RID: 77063
				[Token(Token = "0x4012D07")]
				private const float ENEMY_SPAWN_INTERVAL = 0.1f;

				// Token: 0x04012D08 RID: 77064
				[Token(Token = "0x4012D08")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				private readonly GridPosition m_giantEnemySpawnPosition;

				// Token: 0x04012D09 RID: 77065
				[Token(Token = "0x4012D09")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_Init;

				// Token: 0x04012D0A RID: 77066
				[Token(Token = "0x4012D0A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_GenerateNextWaves;

				// Token: 0x04012D0B RID: 77067
				[Token(Token = "0x4012D0B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_GetRemainingRoundCnt;

				// Token: 0x04012D0C RID: 77068
				[Token(Token = "0x4012D0C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_GetCurRoundData;

				// Token: 0x04012D0D RID: 77069
				[Token(Token = "0x4012D0D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_GetRoundData;

				// Token: 0x04012D0E RID: 77070
				[Token(Token = "0x4012D0E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_CollectSummonPositionByTeamSide;

				// Token: 0x04012D0F RID: 77071
				[Token(Token = "0x4012D0F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0__ProcessRoundData;

				// Token: 0x04012D10 RID: 77072
				[Token(Token = "0x4012D10")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0__ProcessPoolData;

				// Token: 0x04012D11 RID: 77073
				[Token(Token = "0x4012D11")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0__GetWeightByPoolTypeString;

				// Token: 0x04012D12 RID: 77074
				[Token(Token = "0x4012D12")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge __Hotfix0__ProcessEnemyData;

				// Token: 0x04012D13 RID: 77075
				[Token(Token = "0x4012D13")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0__GenerateRound;

				// Token: 0x04012D14 RID: 77076
				[Token(Token = "0x4012D14")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge __Hotfix0__GenerateDefaultBranch;

				// Token: 0x04012D15 RID: 77077
				[Token(Token = "0x4012D15")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				private static DelegateBridge __Hotfix0__SelectEnemyForEachTeam;

				// Token: 0x04012D16 RID: 77078
				[Token(Token = "0x4012D16")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private static DelegateBridge __Hotfix0__AvailableEnemy;

				// Token: 0x04012D17 RID: 77079
				[Token(Token = "0x4012D17")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private static DelegateBridge __Hotfix0__GetActionCnt;

				// Token: 0x04012D18 RID: 77080
				[Token(Token = "0x4012D18")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				private static DelegateBridge __Hotfix0__GetBranchActionCnt;

				// Token: 0x04012D19 RID: 77081
				[Token(Token = "0x4012D19")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				private static DelegateBridge __Hotfix0__NeedRoute;

				// Token: 0x04012D1A RID: 77082
				[Token(Token = "0x4012D1A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				private static DelegateBridge __Hotfix0__UpdateRoutes;

				// Token: 0x04012D1B RID: 77083
				[Token(Token = "0x4012D1B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
				private static DelegateBridge __Hotfix0__UpdateExtraRoutes;

				// Token: 0x04012D1C RID: 77084
				[Token(Token = "0x4012D1C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
				private static DelegateBridge __Hotfix0__GenerateDefaultWave;

				// Token: 0x04012D1D RID: 77085
				[Token(Token = "0x4012D1D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
				private static DelegateBridge __Hotfix0__AssignPointsToEachEnemy;

				// Token: 0x04012D1E RID: 77086
				[Token(Token = "0x4012D1E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
				private static DelegateBridge __Hotfix0__GenerateActionsByPriority;

				// Token: 0x04012D1F RID: 77087
				[Token(Token = "0x4012D1F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
				private static DelegateBridge __Hotfix0__GetDifferentActionCountById;

				// Token: 0x04012D20 RID: 77088
				[Token(Token = "0x4012D20")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
				private static DelegateBridge __Hotfix0__CollectSpawnPositions;

				// Token: 0x04012D21 RID: 77089
				[Token(Token = "0x4012D21")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
				private static DelegateBridge __Hotfix0__CollectSpawnPositionsForSurpriseAttacker;

				// Token: 0x04012D22 RID: 77090
				[Token(Token = "0x4012D22")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
				private static DelegateBridge __Hotfix0__GenerateAction;

				// Token: 0x04012D23 RID: 77091
				[Token(Token = "0x4012D23")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
				private static DelegateBridge __Hotfix0__GenerateActionForBranch;

				// Token: 0x04012D24 RID: 77092
				[Token(Token = "0x4012D24")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}
		}

		// Token: 0x020027D5 RID: 10197
		[Token(Token = "0x20027D5")]
		public class FunLiveGameMode : GameModeFactory.DefaultGameMode
		{
			// Token: 0x06010CA1 RID: 68769 RVA: 0x00066D68 File Offset: 0x00064F68
			[Token(Token = "0x6010CA1")]
			[Address(RVA = "0x897F50", Offset = "0x896B50", VA = "0x180897F50")]
			public int GetFarmRemainingTime()
			{
				return 0;
			}

			// Token: 0x06010CA2 RID: 68770 RVA: 0x00066D80 File Offset: 0x00064F80
			[Token(Token = "0x6010CA2")]
			[Address(RVA = "0x897ED0", Offset = "0x896AD0", VA = "0x180897ED0")]
			public int GetFarmMaxTime()
			{
				return 0;
			}

			// Token: 0x06010CA3 RID: 68771 RVA: 0x00066D98 File Offset: 0x00064F98
			[Token(Token = "0x6010CA3")]
			[Address(RVA = "0x897E70", Offset = "0x896A70", VA = "0x180897E70")]
			public int GetEventTotalCnt()
			{
				return 0;
			}

			// Token: 0x170024CC RID: 9420
			// (get) Token: 0x06010CA4 RID: 68772 RVA: 0x00066DB0 File Offset: 0x00064FB0
			[Token(Token = "0x170024CC")]
			public bool HaveDangerousEvent
			{
				[Token(Token = "0x6010CA4")]
				[Address(RVA = "0x899630", Offset = "0x898230", VA = "0x180899630")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170024CD RID: 9421
			// (get) Token: 0x06010CA5 RID: 68773 RVA: 0x00066DC8 File Offset: 0x00064FC8
			[Token(Token = "0x170024CD")]
			public int AttribIconDiffNum
			{
				[Token(Token = "0x6010CA5")]
				[Address(RVA = "0x8995D0", Offset = "0x8981D0", VA = "0x1808995D0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170024CE RID: 9422
			// (get) Token: 0x06010CA6 RID: 68774 RVA: 0x00066DE0 File Offset: 0x00064FE0
			[Token(Token = "0x170024CE")]
			public bool isTrainingLevel
			{
				[Token(Token = "0x6010CA6")]
				[Address(RVA = "0x899750", Offset = "0x898350", VA = "0x180899750")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06010CA7 RID: 68775 RVA: 0x00066DF8 File Offset: 0x00064FF8
			[Token(Token = "0x6010CA7")]
			[Address(RVA = "0x897C00", Offset = "0x896800", VA = "0x180897C00")]
			public int GetDefaultEventTotalCnt()
			{
				return 0;
			}

			// Token: 0x06010CA8 RID: 68776 RVA: 0x00066E10 File Offset: 0x00065010
			[Token(Token = "0x6010CA8")]
			[Address(RVA = "0x897B90", Offset = "0x896790", VA = "0x180897B90")]
			public int GetCurrentLevelIndex()
			{
				return 0;
			}

			// Token: 0x170024CF RID: 9423
			// (get) Token: 0x06010CA9 RID: 68777 RVA: 0x00066E28 File Offset: 0x00065028
			[Token(Token = "0x170024CF")]
			public override GameModeMeta.GameModeType gameModeType
			{
				[Token(Token = "0x6010CA9")]
				[Address(RVA = "0x8996F0", Offset = "0x8982F0", VA = "0x1808996F0", Slot = "119")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x06010CAA RID: 68778 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CAA")]
			[Address(RVA = "0x899250", Offset = "0x897E50", VA = "0x180899250")]
			public FunLiveGameMode(ref GameModeMeta meta)
			{
			}

			// Token: 0x170024D0 RID: 9424
			// (get) Token: 0x06010CAB RID: 68779 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170024D0")]
			public Dictionary<Unit, GameModeFactory.FunLiveGameMode.FunLiveEventType> StoredUnit
			{
				[Token(Token = "0x6010CAB")]
				[Address(RVA = "0x899690", Offset = "0x898290", VA = "0x180899690")]
				get
				{
					return null;
				}
			}

			// Token: 0x06010CAC RID: 68780 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CAC")]
			[Address(RVA = "0x8980F0", Offset = "0x896CF0", VA = "0x1808980F0", Slot = "122")]
			public override void Init(ref GameModeMeta meta, ref int randomSeed, BattlePlayerData playerData, LevelData levelData)
			{
			}

			// Token: 0x06010CAD RID: 68781 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010CAD")]
			[Address(RVA = "0x897930", Offset = "0x896530", VA = "0x180897930")]
			public static Dictionary<ResourceCollector.PreloadType, object> GatherPreloadAssets()
			{
				return null;
			}

			// Token: 0x06010CAE RID: 68782 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010CAE")]
			[Address(RVA = "0x8990A0", Offset = "0x897CA0", VA = "0x1808990A0")]
			private static List<BattleCharacterData> _GetPreGivenTokens(FunLiveInput input)
			{
				return null;
			}

			// Token: 0x06010CAF RID: 68783 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CAF")]
			[Address(RVA = "0x898D00", Offset = "0x897900", VA = "0x180898D00", Slot = "126")]
			public override void Tick(Action doDefaultTick)
			{
			}

			// Token: 0x06010CB0 RID: 68784 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010CB0")]
			[Address(RVA = "0x898060", Offset = "0x896C60", VA = "0x180898060", Slot = "155")]
			public override Scheduler.SchedulerPreprocessor GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x06010CB1 RID: 68785 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CB1")]
			[Address(RVA = "0x898F50", Offset = "0x897B50", VA = "0x180898F50")]
			private void _CheckGameFinish()
			{
			}

			// Token: 0x06010CB2 RID: 68786 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CB2")]
			[Address(RVA = "0x898AF0", Offset = "0x8976F0", VA = "0x180898AF0")]
			public void SetRareAndDangerousEventData(string key, int value)
			{
			}

			// Token: 0x06010CB3 RID: 68787 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CB3")]
			[Address(RVA = "0x897400", Offset = "0x896000", VA = "0x180897400")]
			public void CollectTargetInfo(Unit target, string targetInfo)
			{
			}

			// Token: 0x06010CB4 RID: 68788 RVA: 0x00066E40 File Offset: 0x00065040
			[Token(Token = "0x6010CB4")]
			[Address(RVA = "0x898360", Offset = "0x896F60", VA = "0x180898360")]
			public bool ProcessTargetsInfo()
			{
				return default(bool);
			}

			// Token: 0x06010CB5 RID: 68789 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CB5")]
			[Address(RVA = "0x8989F0", Offset = "0x8975F0", VA = "0x1808989F0")]
			public void ResetData()
			{
			}

			// Token: 0x06010CB6 RID: 68790 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010CB6")]
			[Address(RVA = "0x897C60", Offset = "0x896860", VA = "0x180897C60")]
			public List<string> GetEventIdList()
			{
				return null;
			}

			// Token: 0x06010CB7 RID: 68791 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CB7")]
			[Address(RVA = "0x8975F0", Offset = "0x8961F0", VA = "0x1808975F0")]
			public void FunLiveLogEvent()
			{
			}

			// Token: 0x06010CB8 RID: 68792 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CB8")]
			[Address(RVA = "0x898EB0", Offset = "0x897AB0", VA = "0x180898EB0")]
			public void UpdateNormalAndRareEventCnt()
			{
			}

			// Token: 0x06010CB9 RID: 68793 RVA: 0x00066E58 File Offset: 0x00065058
			[Token(Token = "0x6010CB9")]
			[Address(RVA = "0x88F1C0", Offset = "0x88DDC0", VA = "0x18088F1C0")]
			private GameModeMeta.GameModeType <>xLuaBaseProxy_get_gameModeType()
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}

			// Token: 0x06010CBA RID: 68794 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CBA")]
			[Address(RVA = "0x83EA80", Offset = "0x83D680", VA = "0x18083EA80")]
			private void <>xLuaBaseProxy_Init(ref GameModeMeta P0, ref int P1, BattlePlayerData P2, LevelData P3)
			{
			}

			// Token: 0x06010CBB RID: 68795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CBB")]
			[Address(RVA = "0x88EB00", Offset = "0x88D700", VA = "0x18088EB00")]
			private void <>xLuaBaseProxy_Tick(Action P0)
			{
			}

			// Token: 0x06010CBC RID: 68796 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010CBC")]
			[Address(RVA = "0x83EA70", Offset = "0x83D670", VA = "0x18083EA70")]
			private Scheduler.SchedulerPreprocessor <>xLuaBaseProxy_GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x04012D2B RID: 77099
			[Token(Token = "0x4012D2B")]
			public const string FUNLIVE_UI_PLUGIN_PATH = "UI/Activity/ActFun/Actfun4/Battle/funlive_battle_ui_plugin.prefab";

			// Token: 0x04012D2C RID: 77100
			[Token(Token = "0x4012D2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Dictionary<Unit, string> m_screenShotTargets;

			// Token: 0x04012D2D RID: 77101
			[Token(Token = "0x4012D2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Dictionary<string, int> m_targetInfoCount;

			// Token: 0x04012D2E RID: 77102
			[Token(Token = "0x4012D2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<string, int> m_rareEvent;

			// Token: 0x04012D2F RID: 77103
			[Token(Token = "0x4012D2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<string> m_dangerousEventList;

			// Token: 0x04012D30 RID: 77104
			[Token(Token = "0x4012D30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<string> m_storedRareEventList;

			// Token: 0x04012D31 RID: 77105
			[Token(Token = "0x4012D31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private List<string> m_storedRareEventPerCastList;

			// Token: 0x04012D32 RID: 77106
			[Token(Token = "0x4012D32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Dictionary<Unit, GameModeFactory.FunLiveGameMode.FunLiveEventType> m_storedUnit;

			// Token: 0x04012D33 RID: 77107
			[Token(Token = "0x4012D33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private List<string> m_logEventIdList;

			// Token: 0x04012D34 RID: 77108
			[Token(Token = "0x4012D34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private FP m_maxPlayTime;

			// Token: 0x04012D35 RID: 77109
			[Token(Token = "0x4012D35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private int m_normalEventCnt;

			// Token: 0x04012D36 RID: 77110
			[Token(Token = "0x4012D36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private int m_normalEventCntPerCast;

			// Token: 0x04012D37 RID: 77111
			[Token(Token = "0x4012D37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private int m_rareEventCnt;

			// Token: 0x04012D38 RID: 77112
			[Token(Token = "0x4012D38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private int m_rareEventCntPerCast;

			// Token: 0x04012D39 RID: 77113
			[Token(Token = "0x4012D39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private bool m_haveDangerousEv;

			// Token: 0x04012D3A RID: 77114
			[Token(Token = "0x4012D3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private string m_levelId;

			// Token: 0x04012D3B RID: 77115
			[Token(Token = "0x4012D3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private int m_attribIconDiffNum;

			// Token: 0x04012D3C RID: 77116
			[Token(Token = "0x4012D3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private bool m_isTrainingLevel;

			// Token: 0x04012D3D RID: 77117
			[Token(Token = "0x4012D3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private FunLiveInput m_input;

			// Token: 0x04012D3E RID: 77118
			[Token(Token = "0x4012D3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetFarmRemainingTime;

			// Token: 0x04012D3F RID: 77119
			[Token(Token = "0x4012D3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetFarmMaxTime;

			// Token: 0x04012D40 RID: 77120
			[Token(Token = "0x4012D40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetEventTotalCnt;

			// Token: 0x04012D41 RID: 77121
			[Token(Token = "0x4012D41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_HaveDangerousEvent;

			// Token: 0x04012D42 RID: 77122
			[Token(Token = "0x4012D42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_AttribIconDiffNum;

			// Token: 0x04012D43 RID: 77123
			[Token(Token = "0x4012D43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_isTrainingLevel;

			// Token: 0x04012D44 RID: 77124
			[Token(Token = "0x4012D44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GetDefaultEventTotalCnt;

			// Token: 0x04012D45 RID: 77125
			[Token(Token = "0x4012D45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_GetCurrentLevelIndex;

			// Token: 0x04012D46 RID: 77126
			[Token(Token = "0x4012D46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_gameModeType;

			// Token: 0x04012D47 RID: 77127
			[Token(Token = "0x4012D47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04012D48 RID: 77128
			[Token(Token = "0x4012D48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_StoredUnit;

			// Token: 0x04012D49 RID: 77129
			[Token(Token = "0x4012D49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x04012D4A RID: 77130
			[Token(Token = "0x4012D4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_GatherPreloadAssets;

			// Token: 0x04012D4B RID: 77131
			[Token(Token = "0x4012D4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0__GetPreGivenTokens;

			// Token: 0x04012D4C RID: 77132
			[Token(Token = "0x4012D4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_Tick;

			// Token: 0x04012D4D RID: 77133
			[Token(Token = "0x4012D4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_GetSchedulerPreprocessor;

			// Token: 0x04012D4E RID: 77134
			[Token(Token = "0x4012D4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0__CheckGameFinish;

			// Token: 0x04012D4F RID: 77135
			[Token(Token = "0x4012D4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_SetRareAndDangerousEventData;

			// Token: 0x04012D50 RID: 77136
			[Token(Token = "0x4012D50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_CollectTargetInfo;

			// Token: 0x04012D51 RID: 77137
			[Token(Token = "0x4012D51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_ProcessTargetsInfo;

			// Token: 0x04012D52 RID: 77138
			[Token(Token = "0x4012D52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_ResetData;

			// Token: 0x04012D53 RID: 77139
			[Token(Token = "0x4012D53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_GetEventIdList;

			// Token: 0x04012D54 RID: 77140
			[Token(Token = "0x4012D54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_FunLiveLogEvent;

			// Token: 0x04012D55 RID: 77141
			[Token(Token = "0x4012D55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_UpdateNormalAndRareEventCnt;

			// Token: 0x020027D6 RID: 10198
			[Token(Token = "0x20027D6")]
			public enum FunLiveEventType
			{
				// Token: 0x04012D57 RID: 77143
				[Token(Token = "0x4012D57")]
				NORMAL,
				// Token: 0x04012D58 RID: 77144
				[Token(Token = "0x4012D58")]
				RARE,
				// Token: 0x04012D59 RID: 77145
				[Token(Token = "0x4012D59")]
				DANGEROUS
			}
		}

		// Token: 0x020027D7 RID: 10199
		[Token(Token = "0x20027D7")]
		public class GameCityGameMode : GameModeFactory.DefaultGameMode
		{
			// Token: 0x170024D1 RID: 9425
			// (get) Token: 0x06010CBD RID: 68797 RVA: 0x00066E70 File Offset: 0x00065070
			[Token(Token = "0x170024D1")]
			public override GameModeMeta.GameModeType gameModeType
			{
				[Token(Token = "0x6010CBD")]
				[Address(RVA = "0x89D0D0", Offset = "0x89BCD0", VA = "0x18089D0D0", Slot = "119")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x06010CBE RID: 68798 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CBE")]
			[Address(RVA = "0x89CAE0", Offset = "0x89B6E0", VA = "0x18089CAE0")]
			public GameCityGameMode(ref GameModeMeta meta)
			{
			}

			// Token: 0x06010CBF RID: 68799 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010CBF")]
			[Address(RVA = "0x89AAD0", Offset = "0x8996D0", VA = "0x18089AAD0", Slot = "155")]
			public override Scheduler.SchedulerPreprocessor GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x06010CC0 RID: 68800 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CC0")]
			[Address(RVA = "0x89AF60", Offset = "0x899B60", VA = "0x18089AF60", Slot = "122")]
			public override void Init(ref GameModeMeta meta, ref int randomSeed, BattlePlayerData playerData, LevelData levelData)
			{
			}

			// Token: 0x06010CC1 RID: 68801 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010CC1")]
			[Address(RVA = "0x89A850", Offset = "0x899450", VA = "0x18089A850", Slot = "201")]
			public override List<GlobalEnvSystemData> GatherEnvSystems()
			{
				return null;
			}

			// Token: 0x06010CC2 RID: 68802 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010CC2")]
			[Address(RVA = "0x89A9C0", Offset = "0x8995C0", VA = "0x18089A9C0", Slot = "157")]
			public override List<LevelData.GlobalBuffData> GatherGlobalBuffs()
			{
				return null;
			}

			// Token: 0x06010CC3 RID: 68803 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CC3")]
			[Address(RVA = "0x89BB20", Offset = "0x89A720", VA = "0x18089BB20", Slot = "161")]
			public override void OnUnitRegistered(Unit unit)
			{
			}

			// Token: 0x06010CC4 RID: 68804 RVA: 0x00066E88 File Offset: 0x00065088
			[Token(Token = "0x6010CC4")]
			[Address(RVA = "0x899FF0", Offset = "0x898BF0", VA = "0x180899FF0", Slot = "200")]
			public override bool CheckUnitValidHudPlugin(Unit unit)
			{
				return default(bool);
			}

			// Token: 0x06010CC5 RID: 68805 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CC5")]
			[Address(RVA = "0x89BA60", Offset = "0x89A660", VA = "0x18089BA60", Slot = "160")]
			public override void OnApplyingGlobalModifier(ref Modifier modifier)
			{
			}

			// Token: 0x06010CC6 RID: 68806 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010CC6")]
			[Address(RVA = "0x89AEB0", Offset = "0x899AB0", VA = "0x18089AEB0", Slot = "166")]
			public override string HookTileEffect(string originEffectKey)
			{
				return null;
			}

			// Token: 0x06010CC7 RID: 68807 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CC7")]
			[Address(RVA = "0x89BD50", Offset = "0x89A950", VA = "0x18089BD50", Slot = "148")]
			public override void OnWaveWillStart(LevelData.WaveData waveData)
			{
			}

			// Token: 0x06010CC8 RID: 68808 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CC8")]
			[Address(RVA = "0x89A570", Offset = "0x899170", VA = "0x18089A570", Slot = "182")]
			public override void FinishGame(Action<BattleController.GameResult, bool> gameFinishCallback, BattleController.GameResult result, bool silent = false)
			{
			}

			// Token: 0x06010CC9 RID: 68809 RVA: 0x00066EA0 File Offset: 0x000650A0
			[Token(Token = "0x6010CC9")]
			[Address(RVA = "0x89AA70", Offset = "0x899670", VA = "0x18089AA70", Slot = "184")]
			public override PlayerBattleRank GetBattleCompleteRank()
			{
				return (PlayerBattleRank)0;
			}

			// Token: 0x06010CCA RID: 68810 RVA: 0x00066EB8 File Offset: 0x000650B8
			[Token(Token = "0x6010CCA")]
			[Address(RVA = "0x899EB0", Offset = "0x898AB0", VA = "0x180899EB0", Slot = "169")]
			public override bool CheckCardReadyToSpawn(Deck.Card card)
			{
				return default(bool);
			}

			// Token: 0x06010CCB RID: 68811 RVA: 0x00066ED0 File Offset: 0x000650D0
			[Token(Token = "0x6010CCB")]
			[Address(RVA = "0x89ADE0", Offset = "0x8999E0", VA = "0x18089ADE0", Slot = "173")]
			public override bool HookBattleFinishAudio(BattleController.GameResult result)
			{
				return default(bool);
			}

			// Token: 0x06010CCC RID: 68812 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CCC")]
			[Address(RVA = "0x89C2C0", Offset = "0x89AEC0", VA = "0x18089C2C0", Slot = "126")]
			public override void Tick(Action doDefaultTick)
			{
			}

			// Token: 0x06010CCD RID: 68813 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CCD")]
			[Address(RVA = "0x89A150", Offset = "0x898D50", VA = "0x18089A150", Slot = "190")]
			public override void DestroyEntity(Entity entity, Entity.FinishReason reason)
			{
			}

			// Token: 0x170024D2 RID: 9426
			// (get) Token: 0x06010CCE RID: 68814 RVA: 0x00066EE8 File Offset: 0x000650E8
			[Token(Token = "0x170024D2")]
			public ActArcadeData.SubModeType SubModeType
			{
				[Token(Token = "0x6010CCE")]
				[Address(RVA = "0x89CF50", Offset = "0x89BB50", VA = "0x18089CF50")]
				get
				{
					return ActArcadeData.SubModeType.MINER;
				}
			}

			// Token: 0x170024D3 RID: 9427
			// (get) Token: 0x06010CCF RID: 68815 RVA: 0x00066F00 File Offset: 0x00065100
			[Token(Token = "0x170024D3")]
			public int maxWave
			{
				[Token(Token = "0x6010CCF")]
				[Address(RVA = "0x89D1A0", Offset = "0x89BDA0", VA = "0x18089D1A0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170024D4 RID: 9428
			// (get) Token: 0x06010CD0 RID: 68816 RVA: 0x00066F18 File Offset: 0x00065118
			[Token(Token = "0x170024D4")]
			public int curWave
			{
				[Token(Token = "0x6010CD0")]
				[Address(RVA = "0x89D070", Offset = "0x89BC70", VA = "0x18089D070")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170024D5 RID: 9429
			// (get) Token: 0x06010CD1 RID: 68817 RVA: 0x00066F30 File Offset: 0x00065130
			[Token(Token = "0x170024D5")]
			public bool isResting
			{
				[Token(Token = "0x6010CD1")]
				[Address(RVA = "0x89D130", Offset = "0x89BD30", VA = "0x18089D130")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170024D6 RID: 9430
			// (get) Token: 0x06010CD2 RID: 68818 RVA: 0x00066F48 File Offset: 0x00065148
			// (set) Token: 0x06010CD3 RID: 68819 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170024D6")]
			public bool skipCurWave
			{
				[Token(Token = "0x6010CD2")]
				[Address(RVA = "0x89D320", Offset = "0x89BF20", VA = "0x18089D320")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6010CD3")]
				[Address(RVA = "0x89D600", Offset = "0x89C200", VA = "0x18089D600")]
				set
				{
				}
			}

			// Token: 0x170024D7 RID: 9431
			// (get) Token: 0x06010CD4 RID: 68820 RVA: 0x00066F60 File Offset: 0x00065160
			[Token(Token = "0x170024D7")]
			public FP waveRestTime
			{
				[Token(Token = "0x6010CD4")]
				[Address(RVA = "0x89D4D0", Offset = "0x89C0D0", VA = "0x18089D4D0")]
				get
				{
					return default(FP);
				}
			}

			// Token: 0x170024D8 RID: 9432
			// (get) Token: 0x06010CD5 RID: 68821 RVA: 0x00066F78 File Offset: 0x00065178
			[Token(Token = "0x170024D8")]
			public FP waveRestTimeProgress
			{
				[Token(Token = "0x6010CD5")]
				[Address(RVA = "0x89D410", Offset = "0x89C010", VA = "0x18089D410")]
				get
				{
					return default(FP);
				}
			}

			// Token: 0x170024D9 RID: 9433
			// (get) Token: 0x06010CD6 RID: 68822 RVA: 0x00066F90 File Offset: 0x00065190
			[Token(Token = "0x170024D9")]
			public FP restingTime
			{
				[Token(Token = "0x6010CD6")]
				[Address(RVA = "0x89D260", Offset = "0x89BE60", VA = "0x18089D260")]
				get
				{
					return default(FP);
				}
			}

			// Token: 0x170024DA RID: 9434
			// (get) Token: 0x06010CD7 RID: 68823 RVA: 0x00066FA8 File Offset: 0x000651A8
			[Token(Token = "0x170024DA")]
			public ActArcadeData.Rank curRank
			{
				[Token(Token = "0x6010CD7")]
				[Address(RVA = "0x89D010", Offset = "0x89BC10", VA = "0x18089D010")]
				get
				{
					return ActArcadeData.Rank.B;
				}
			}

			// Token: 0x170024DB RID: 9435
			// (get) Token: 0x06010CD8 RID: 68824 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170024DB")]
			public string actId
			{
				[Token(Token = "0x6010CD8")]
				[Address(RVA = "0x89CFB0", Offset = "0x89BBB0", VA = "0x18089CFB0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170024DC RID: 9436
			// (get) Token: 0x06010CD9 RID: 68825 RVA: 0x00066FC0 File Offset: 0x000651C0
			// (set) Token: 0x06010CDA RID: 68826 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170024DC")]
			public int rainbowScore
			{
				[Token(Token = "0x6010CD9")]
				[Address(RVA = "0x89D200", Offset = "0x89BE00", VA = "0x18089D200")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6010CDA")]
				[Address(RVA = "0x89D590", Offset = "0x89C190", VA = "0x18089D590")]
				set
				{
				}
			}

			// Token: 0x06010CDB RID: 68827 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CDB")]
			[Address(RVA = "0x89C1A0", Offset = "0x89ADA0", VA = "0x18089C1A0")]
			public void SetWaveAndRestTime(FP wave, FP rest)
			{
			}

			// Token: 0x06010CDC RID: 68828 RVA: 0x00066FD8 File Offset: 0x000651D8
			[Token(Token = "0x6010CDC")]
			[Address(RVA = "0x89AB60", Offset = "0x899760", VA = "0x18089AB60")]
			public float GetScoreMaxValue(ActArcadeData.Rank rank)
			{
				return 0f;
			}

			// Token: 0x06010CDD RID: 68829 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CDD")]
			[Address(RVA = "0x899880", Offset = "0x898480", VA = "0x180899880")]
			public void AddArcgachaObjects(List<GameCityModeBattleData.GameCityArcgachaObjectData> data)
			{
			}

			// Token: 0x06010CDE RID: 68830 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CDE")]
			[Address(RVA = "0x8997B0", Offset = "0x8983B0", VA = "0x1808997B0")]
			public void AddArcgachaObjectsStart(List<string> data)
			{
			}

			// Token: 0x06010CDF RID: 68831 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010CDF")]
			[Address(RVA = "0x89BEE0", Offset = "0x89AAE0", VA = "0x18089BEE0")]
			public string RandomGetArcgachaObject()
			{
				return null;
			}

			// Token: 0x06010CE0 RID: 68832 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CE0")]
			[Address(RVA = "0x89B8B0", Offset = "0x89A4B0", VA = "0x18089B8B0")]
			public void MarkBranch(string dataKey, LevelData.BranchData data)
			{
			}

			// Token: 0x06010CE1 RID: 68833 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CE1")]
			[Address(RVA = "0x899950", Offset = "0x898550", VA = "0x180899950")]
			public void AddScore(FP value, Entity target)
			{
			}

			// Token: 0x06010CE2 RID: 68834 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CE2")]
			[Address(RVA = "0x89AC00", Offset = "0x899800", VA = "0x18089AC00")]
			public void GetTileScoreAdd(FP value)
			{
			}

			// Token: 0x06010CE3 RID: 68835 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CE3")]
			[Address(RVA = "0x89A2C0", Offset = "0x898EC0", VA = "0x18089A2C0")]
			public void FinishCurWaveBecauseTimeUp()
			{
			}

			// Token: 0x06010CE4 RID: 68836 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CE4")]
			[Address(RVA = "0x89C080", Offset = "0x89AC80", VA = "0x18089C080")]
			public void SetRestingTimerOnWaveFinish()
			{
			}

			// Token: 0x06010CE5 RID: 68837 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CE5")]
			[Address(RVA = "0x89C230", Offset = "0x89AE30", VA = "0x18089C230")]
			public void SetWaveTimerOnWaveStart(FP restTime)
			{
			}

			// Token: 0x06010CE6 RID: 68838 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CE6")]
			[Address(RVA = "0x89C660", Offset = "0x89B260", VA = "0x18089C660")]
			public void UpdateRestingTimer(FP deltaTime)
			{
			}

			// Token: 0x06010CE7 RID: 68839 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CE7")]
			[Address(RVA = "0x89C750", Offset = "0x89B350", VA = "0x18089C750")]
			public void UpdateWaveTimer(FP deltaTime)
			{
			}

			// Token: 0x06010CE8 RID: 68840 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CE8")]
			[Address(RVA = "0x89C840", Offset = "0x89B440", VA = "0x18089C840")]
			private void _ParseMinerGlobalBuffs()
			{
			}

			// Token: 0x170024DD RID: 9437
			// (get) Token: 0x06010CE9 RID: 68841 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170024DD")]
			public override Scheduler.DefaultWaveHandler waveHandler
			{
				[Token(Token = "0x6010CE9")]
				[Address(RVA = "0x89D380", Offset = "0x89BF80", VA = "0x18089D380", Slot = "120")]
				get
				{
					return null;
				}
			}

			// Token: 0x06010CEA RID: 68842 RVA: 0x00066FF0 File Offset: 0x000651F0
			[Token(Token = "0x6010CEA")]
			[Address(RVA = "0x88F1C0", Offset = "0x88DDC0", VA = "0x18088F1C0")]
			private GameModeMeta.GameModeType <>xLuaBaseProxy_get_gameModeType()
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}

			// Token: 0x06010CEB RID: 68843 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010CEB")]
			[Address(RVA = "0x83EA70", Offset = "0x83D670", VA = "0x18083EA70")]
			private Scheduler.SchedulerPreprocessor <>xLuaBaseProxy_GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x06010CEC RID: 68844 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CEC")]
			[Address(RVA = "0x83EA80", Offset = "0x83D680", VA = "0x18083EA80")]
			private void <>xLuaBaseProxy_Init(ref GameModeMeta P0, ref int P1, BattlePlayerData P2, LevelData P3)
			{
			}

			// Token: 0x06010CED RID: 68845 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010CED")]
			[Address(RVA = "0x88CBD0", Offset = "0x88B7D0", VA = "0x18088CBD0")]
			private List<GlobalEnvSystemData> <>xLuaBaseProxy_GatherEnvSystems()
			{
				return null;
			}

			// Token: 0x06010CEE RID: 68846 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010CEE")]
			[Address(RVA = "0x88CC30", Offset = "0x88B830", VA = "0x18088CC30")]
			private List<LevelData.GlobalBuffData> <>xLuaBaseProxy_GatherGlobalBuffs()
			{
				return null;
			}

			// Token: 0x06010CEF RID: 68847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CEF")]
			[Address(RVA = "0x840A90", Offset = "0x83F690", VA = "0x180840A90")]
			private void <>xLuaBaseProxy_OnUnitRegistered(Unit P0)
			{
			}

			// Token: 0x06010CF0 RID: 68848 RVA: 0x00067008 File Offset: 0x00065208
			[Token(Token = "0x6010CF0")]
			[Address(RVA = "0x88C4C0", Offset = "0x88B0C0", VA = "0x18088C4C0")]
			private bool <>xLuaBaseProxy_CheckUnitValidHudPlugin(Unit P0)
			{
				return default(bool);
			}

			// Token: 0x06010CF1 RID: 68849 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CF1")]
			[Address(RVA = "0x88D8B0", Offset = "0x88C4B0", VA = "0x18088D8B0")]
			private void <>xLuaBaseProxy_OnApplyingGlobalModifier(ref Modifier P0)
			{
			}

			// Token: 0x06010CF2 RID: 68850 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010CF2")]
			[Address(RVA = "0x89C560", Offset = "0x89B160", VA = "0x18089C560")]
			private string <>xLuaBaseProxy_HookTileEffect(string P0)
			{
				return null;
			}

			// Token: 0x06010CF3 RID: 68851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CF3")]
			[Address(RVA = "0x88E340", Offset = "0x88CF40", VA = "0x18088E340")]
			private void <>xLuaBaseProxy_OnWaveWillStart(LevelData.WaveData P0)
			{
			}

			// Token: 0x06010CF4 RID: 68852 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CF4")]
			[Address(RVA = "0x85AB90", Offset = "0x859790", VA = "0x18085AB90")]
			private void <>xLuaBaseProxy_FinishGame(Action<BattleController.GameResult, bool> P0, BattleController.GameResult P1, bool P2)
			{
			}

			// Token: 0x06010CF5 RID: 68853 RVA: 0x00067020 File Offset: 0x00065220
			[Token(Token = "0x6010CF5")]
			[Address(RVA = "0x858C40", Offset = "0x857840", VA = "0x180858C40")]
			private PlayerBattleRank <>xLuaBaseProxy_GetBattleCompleteRank()
			{
				return (PlayerBattleRank)0;
			}

			// Token: 0x06010CF6 RID: 68854 RVA: 0x00067038 File Offset: 0x00065238
			[Token(Token = "0x6010CF6")]
			[Address(RVA = "0x867930", Offset = "0x866530", VA = "0x180867930")]
			private bool <>xLuaBaseProxy_CheckCardReadyToSpawn(Deck.Card P0)
			{
				return default(bool);
			}

			// Token: 0x06010CF7 RID: 68855 RVA: 0x00067050 File Offset: 0x00065250
			[Token(Token = "0x6010CF7")]
			[Address(RVA = "0x88D0C0", Offset = "0x88BCC0", VA = "0x18088D0C0")]
			private bool <>xLuaBaseProxy_HookBattleFinishAudio(BattleController.GameResult P0)
			{
				return default(bool);
			}

			// Token: 0x06010CF8 RID: 68856 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CF8")]
			[Address(RVA = "0x88EB00", Offset = "0x88D700", VA = "0x18088EB00")]
			private void <>xLuaBaseProxy_Tick(Action P0)
			{
			}

			// Token: 0x06010CF9 RID: 68857 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010CF9")]
			[Address(RVA = "0x85AB60", Offset = "0x859760", VA = "0x18085AB60")]
			private void <>xLuaBaseProxy_DestroyEntity(Entity P0, Entity.FinishReason P1)
			{
			}

			// Token: 0x06010CFA RID: 68858 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010CFA")]
			[Address(RVA = "0x89C5D0", Offset = "0x89B1D0", VA = "0x18089C5D0")]
			private Scheduler.DefaultWaveHandler <>xLuaBaseProxy_get_waveHandler()
			{
				return null;
			}

			// Token: 0x04012D5A RID: 77146
			[Token(Token = "0x4012D5A")]
			public const string BATTLE_UI_PLUGIN_PATH = "Activity/[UC]act1arcade/Prefabs/Battle/gamecity_battle_ui_plugin.prefab";

			// Token: 0x04012D5B RID: 77147
			[Token(Token = "0x4012D5B")]
			public const string STAGE_LEVEL_FORMAT = "level_";

			// Token: 0x04012D5C RID: 77148
			[Token(Token = "0x4012D5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private FP m_score;

			// Token: 0x04012D5D RID: 77149
			[Token(Token = "0x4012D5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int m_curWave;

			// Token: 0x04012D5E RID: 77150
			[Token(Token = "0x4012D5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int m_maxWave;

			// Token: 0x04012D5F RID: 77151
			[Token(Token = "0x4012D5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int m_curArcgachaStartCnt;

			// Token: 0x04012D60 RID: 77152
			[Token(Token = "0x4012D60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private string m_actId;

			// Token: 0x04012D61 RID: 77153
			[Token(Token = "0x4012D61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private string m_levelId;

			// Token: 0x04012D62 RID: 77154
			[Token(Token = "0x4012D62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ActArcadeData.Rank m_curRank;

			// Token: 0x04012D63 RID: 77155
			[Token(Token = "0x4012D63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private GameCityModeBattleData.GameCityInput m_input;

			// Token: 0x04012D64 RID: 77156
			[Token(Token = "0x4012D64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private ActArcadeData.SubModeType m_subMode;

			// Token: 0x04012D65 RID: 77157
			[Token(Token = "0x4012D65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private int m_rainbowScore;

			// Token: 0x04012D66 RID: 77158
			[Token(Token = "0x4012D66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private FP m_waveDuration;

			// Token: 0x04012D67 RID: 77159
			[Token(Token = "0x4012D67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private FP m_restDuration;

			// Token: 0x04012D68 RID: 77160
			[Token(Token = "0x4012D68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool m_skipCurWave;

			// Token: 0x04012D69 RID: 77161
			[Token(Token = "0x4012D69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private List<string> m_arcgachaObjectStart;

			// Token: 0x04012D6A RID: 77162
			[Token(Token = "0x4012D6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private List<GameCityModeBattleData.GameCityArcgachaObjectData> m_arcgachaObject;

			// Token: 0x04012D6B RID: 77163
			[Token(Token = "0x4012D6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private List<LegacyInLevelRuneData> m_extraLevelRunes;

			// Token: 0x04012D6C RID: 77164
			[Token(Token = "0x4012D6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private List<string> m_branchMarked;

			// Token: 0x04012D6D RID: 77165
			[Token(Token = "0x4012D6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private List<int> m_branchRoutes;

			// Token: 0x04012D6E RID: 77166
			[Token(Token = "0x4012D6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private List<string> m_enemyHudScoreIds;

			// Token: 0x04012D6F RID: 77167
			[Token(Token = "0x4012D6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private List<string> m_trapNotBuildableInRestIds;

			// Token: 0x04012D70 RID: 77168
			[Token(Token = "0x4012D70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Dictionary<ActArcadeData.Rank, float> m_rankData;

			// Token: 0x04012D71 RID: 77169
			[Token(Token = "0x4012D71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private PeriodicTimer m_restingTimer;

			// Token: 0x04012D72 RID: 77170
			[Token(Token = "0x4012D72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private PeriodicTimer m_waveTimer;

			// Token: 0x04012D73 RID: 77171
			[Token(Token = "0x4012D73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private Dictionary<string, int> m_antiCheatScore;

			// Token: 0x04012D74 RID: 77172
			[Token(Token = "0x4012D74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private GamecityBattleUIPlugin m_plugin;

			// Token: 0x04012D75 RID: 77173
			[Token(Token = "0x4012D75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private readonly List<LevelData.GlobalBuffData> m_globalBuffs;

			// Token: 0x04012D76 RID: 77174
			[Token(Token = "0x4012D76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private readonly List<GlobalEnvSystemData> m_globalEnvSystem;

			// Token: 0x04012D77 RID: 77175
			[Token(Token = "0x4012D77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_gameModeType;

			// Token: 0x04012D78 RID: 77176
			[Token(Token = "0x4012D78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04012D79 RID: 77177
			[Token(Token = "0x4012D79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetSchedulerPreprocessor;

			// Token: 0x04012D7A RID: 77178
			[Token(Token = "0x4012D7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x04012D7B RID: 77179
			[Token(Token = "0x4012D7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GatherEnvSystems;

			// Token: 0x04012D7C RID: 77180
			[Token(Token = "0x4012D7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GatherGlobalBuffs;

			// Token: 0x04012D7D RID: 77181
			[Token(Token = "0x4012D7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnUnitRegistered;

			// Token: 0x04012D7E RID: 77182
			[Token(Token = "0x4012D7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_CheckUnitValidHudPlugin;

			// Token: 0x04012D7F RID: 77183
			[Token(Token = "0x4012D7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OnApplyingGlobalModifier;

			// Token: 0x04012D80 RID: 77184
			[Token(Token = "0x4012D80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_HookTileEffect;

			// Token: 0x04012D81 RID: 77185
			[Token(Token = "0x4012D81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_OnWaveWillStart;

			// Token: 0x04012D82 RID: 77186
			[Token(Token = "0x4012D82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_FinishGame;

			// Token: 0x04012D83 RID: 77187
			[Token(Token = "0x4012D83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_GetBattleCompleteRank;

			// Token: 0x04012D84 RID: 77188
			[Token(Token = "0x4012D84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_CheckCardReadyToSpawn;

			// Token: 0x04012D85 RID: 77189
			[Token(Token = "0x4012D85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_HookBattleFinishAudio;

			// Token: 0x04012D86 RID: 77190
			[Token(Token = "0x4012D86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_Tick;

			// Token: 0x04012D87 RID: 77191
			[Token(Token = "0x4012D87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_DestroyEntity;

			// Token: 0x04012D88 RID: 77192
			[Token(Token = "0x4012D88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_get_SubModeType;

			// Token: 0x04012D89 RID: 77193
			[Token(Token = "0x4012D89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_get_maxWave;

			// Token: 0x04012D8A RID: 77194
			[Token(Token = "0x4012D8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_get_curWave;

			// Token: 0x04012D8B RID: 77195
			[Token(Token = "0x4012D8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_get_isResting;

			// Token: 0x04012D8C RID: 77196
			[Token(Token = "0x4012D8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_get_skipCurWave;

			// Token: 0x04012D8D RID: 77197
			[Token(Token = "0x4012D8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_set_skipCurWave;

			// Token: 0x04012D8E RID: 77198
			[Token(Token = "0x4012D8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_get_waveRestTime;

			// Token: 0x04012D8F RID: 77199
			[Token(Token = "0x4012D8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_get_waveRestTimeProgress;

			// Token: 0x04012D90 RID: 77200
			[Token(Token = "0x4012D90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_get_restingTime;

			// Token: 0x04012D91 RID: 77201
			[Token(Token = "0x4012D91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0_get_curRank;

			// Token: 0x04012D92 RID: 77202
			[Token(Token = "0x4012D92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0_get_actId;

			// Token: 0x04012D93 RID: 77203
			[Token(Token = "0x4012D93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0_get_rainbowScore;

			// Token: 0x04012D94 RID: 77204
			[Token(Token = "0x4012D94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0_set_rainbowScore;

			// Token: 0x04012D95 RID: 77205
			[Token(Token = "0x4012D95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private static DelegateBridge __Hotfix0_SetWaveAndRestTime;

			// Token: 0x04012D96 RID: 77206
			[Token(Token = "0x4012D96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private static DelegateBridge __Hotfix0_GetScoreMaxValue;

			// Token: 0x04012D97 RID: 77207
			[Token(Token = "0x4012D97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			private static DelegateBridge __Hotfix0_AddArcgachaObjects;

			// Token: 0x04012D98 RID: 77208
			[Token(Token = "0x4012D98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private static DelegateBridge __Hotfix0_AddArcgachaObjectsStart;

			// Token: 0x04012D99 RID: 77209
			[Token(Token = "0x4012D99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private static DelegateBridge __Hotfix0_RandomGetArcgachaObject;

			// Token: 0x04012D9A RID: 77210
			[Token(Token = "0x4012D9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private static DelegateBridge __Hotfix0_MarkBranch;

			// Token: 0x04012D9B RID: 77211
			[Token(Token = "0x4012D9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private static DelegateBridge __Hotfix0_AddScore;

			// Token: 0x04012D9C RID: 77212
			[Token(Token = "0x4012D9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private static DelegateBridge __Hotfix0_GetTileScoreAdd;

			// Token: 0x04012D9D RID: 77213
			[Token(Token = "0x4012D9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private static DelegateBridge __Hotfix0_FinishCurWaveBecauseTimeUp;

			// Token: 0x04012D9E RID: 77214
			[Token(Token = "0x4012D9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private static DelegateBridge __Hotfix0_SetRestingTimerOnWaveFinish;

			// Token: 0x04012D9F RID: 77215
			[Token(Token = "0x4012D9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private static DelegateBridge __Hotfix0_SetWaveTimerOnWaveStart;

			// Token: 0x04012DA0 RID: 77216
			[Token(Token = "0x4012DA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			private static DelegateBridge __Hotfix0_UpdateRestingTimer;

			// Token: 0x04012DA1 RID: 77217
			[Token(Token = "0x4012DA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			private static DelegateBridge __Hotfix0_UpdateWaveTimer;

			// Token: 0x04012DA2 RID: 77218
			[Token(Token = "0x4012DA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			private static DelegateBridge __Hotfix0__ParseMinerGlobalBuffs;

			// Token: 0x04012DA3 RID: 77219
			[Token(Token = "0x4012DA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			private static DelegateBridge __Hotfix0_get_waveHandler;
		}

		// Token: 0x020027D8 RID: 10200
		[Token(Token = "0x20027D8")]
		public class DefaultGameMode : IGameMode, IHotfixable
		{
			// Token: 0x170024DE RID: 9438
			// (get) Token: 0x06010CFB RID: 68859 RVA: 0x00067068 File Offset: 0x00065268
			[Token(Token = "0x170024DE")]
			public virtual bool allowManualTick
			{
				[Token(Token = "0x6010CFB")]
				[Address(RVA = "0x88EF20", Offset = "0x88DB20", VA = "0x18088EF20", Slot = "103")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170024DF RID: 9439
			// (get) Token: 0x06010CFC RID: 68860 RVA: 0x00067080 File Offset: 0x00065280
			[Token(Token = "0x170024DF")]
			public virtual bool isOnline
			{
				[Token(Token = "0x6010CFC")]
				[Address(RVA = "0x88F3A0", Offset = "0x88DFA0", VA = "0x18088F3A0", Slot = "104")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170024E0 RID: 9440
			// (get) Token: 0x06010CFD RID: 68861 RVA: 0x00067098 File Offset: 0x00065298
			[Token(Token = "0x170024E0")]
			public virtual bool isLargeMap
			{
				[Token(Token = "0x6010CFD")]
				[Address(RVA = "0x88F2E0", Offset = "0x88DEE0", VA = "0x18088F2E0", Slot = "105")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170024E1 RID: 9441
			// (get) Token: 0x06010CFE RID: 68862 RVA: 0x000670B0 File Offset: 0x000652B0
			[Token(Token = "0x170024E1")]
			public virtual bool hasExtraBuildCondition
			{
				[Token(Token = "0x6010CFE")]
				[Address(RVA = "0x88F220", Offset = "0x88DE20", VA = "0x18088F220", Slot = "106")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170024E2 RID: 9442
			// (get) Token: 0x06010CFF RID: 68863 RVA: 0x000670C8 File Offset: 0x000652C8
			[Token(Token = "0x170024E2")]
			public virtual bool isSupportSlowMotion
			{
				[Token(Token = "0x6010CFF")]
				[Address(RVA = "0x88F400", Offset = "0x88E000", VA = "0x18088F400", Slot = "107")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170024E3 RID: 9443
			// (get) Token: 0x06010D00 RID: 68864 RVA: 0x000670E0 File Offset: 0x000652E0
			[Token(Token = "0x170024E3")]
			public virtual bool doDefaultSchedule
			{
				[Token(Token = "0x6010D00")]
				[Address(RVA = "0x88EFE0", Offset = "0x88DBE0", VA = "0x18088EFE0", Slot = "108")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170024E4 RID: 9444
			// (get) Token: 0x06010D01 RID: 68865 RVA: 0x000670F8 File Offset: 0x000652F8
			[Token(Token = "0x170024E4")]
			public virtual bool useLevelBgm
			{
				[Token(Token = "0x6010D01")]
				[Address(RVA = "0x88F510", Offset = "0x88E110", VA = "0x18088F510", Slot = "109")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170024E5 RID: 9445
			// (get) Token: 0x06010D02 RID: 68866 RVA: 0x00067110 File Offset: 0x00065310
			[Token(Token = "0x170024E5")]
			public virtual bool isLowMemoryGameMode
			{
				[Token(Token = "0x6010D02")]
				[Address(RVA = "0x88F340", Offset = "0x88DF40", VA = "0x18088F340", Slot = "110")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170024E6 RID: 9446
			// (get) Token: 0x06010D03 RID: 68867 RVA: 0x00067128 File Offset: 0x00065328
			[Token(Token = "0x170024E6")]
			public virtual BattleOutlineConfig outlineConfig
			{
				[Token(Token = "0x6010D03")]
				[Address(RVA = "0x88F460", Offset = "0x88E060", VA = "0x18088F460", Slot = "111")]
				get
				{
					return default(BattleOutlineConfig);
				}
			}

			// Token: 0x170024E7 RID: 9447
			// (get) Token: 0x06010D04 RID: 68868 RVA: 0x00067140 File Offset: 0x00065340
			[Token(Token = "0x170024E7")]
			public virtual bool enableParticleEffectManager
			{
				[Token(Token = "0x6010D04")]
				[Address(RVA = "0x88F100", Offset = "0x88DD00", VA = "0x18088F100", Slot = "112")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06010D05 RID: 68869 RVA: 0x00067158 File Offset: 0x00065358
			[Token(Token = "0x6010D05")]
			[Address(RVA = "0x88D3A0", Offset = "0x88BFA0", VA = "0x18088D3A0", Slot = "113")]
			public virtual bool HookSeed(out int seed)
			{
				return default(bool);
			}

			// Token: 0x170024E8 RID: 9448
			// (get) Token: 0x06010D06 RID: 68870 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06010D07 RID: 68871 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170024E8")]
			public virtual Character draggingDummy
			{
				[Token(Token = "0x6010D06")]
				[Address(RVA = "0x88F040", Offset = "0x88DC40", VA = "0x18088F040", Slot = "114")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6010D07")]
				[Address(RVA = "0x88F600", Offset = "0x88E200", VA = "0x18088F600", Slot = "115")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170024E9 RID: 9449
			// (get) Token: 0x06010D08 RID: 68872 RVA: 0x00067170 File Offset: 0x00065370
			[Token(Token = "0x170024E9")]
			public virtual bool isInCommonGameStage
			{
				[Token(Token = "0x6010D08")]
				[Address(RVA = "0x88F280", Offset = "0x88DE80", VA = "0x18088F280", Slot = "116")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170024EA RID: 9450
			// (get) Token: 0x06010D09 RID: 68873 RVA: 0x00067188 File Offset: 0x00065388
			[Token(Token = "0x170024EA")]
			public virtual bool enableHudSlowTicker
			{
				[Token(Token = "0x6010D09")]
				[Address(RVA = "0x88F0A0", Offset = "0x88DCA0", VA = "0x18088F0A0", Slot = "117")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170024EB RID: 9451
			// (get) Token: 0x06010D0A RID: 68874 RVA: 0x000671A0 File Offset: 0x000653A0
			[Token(Token = "0x170024EB")]
			public virtual bool enablePause
			{
				[Token(Token = "0x6010D0A")]
				[Address(RVA = "0x88F160", Offset = "0x88DD60", VA = "0x18088F160", Slot = "118")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170024EC RID: 9452
			// (get) Token: 0x06010D0B RID: 68875 RVA: 0x000671B8 File Offset: 0x000653B8
			[Token(Token = "0x170024EC")]
			public virtual GameModeMeta.GameModeType gameModeType
			{
				[Token(Token = "0x6010D0B")]
				[Address(RVA = "0x88F1C0", Offset = "0x88DDC0", VA = "0x18088F1C0", Slot = "119")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x170024ED RID: 9453
			// (get) Token: 0x06010D0C RID: 68876 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170024ED")]
			public virtual Scheduler.DefaultWaveHandler waveHandler
			{
				[Token(Token = "0x6010D0C")]
				[Address(RVA = "0x88F570", Offset = "0x88E170", VA = "0x18088F570", Slot = "120")]
				get
				{
					return null;
				}
			}

			// Token: 0x170024EE RID: 9454
			// (get) Token: 0x06010D0D RID: 68877 RVA: 0x000671D0 File Offset: 0x000653D0
			[Token(Token = "0x170024EE")]
			public virtual bool allowPoolManagerUnload
			{
				[Token(Token = "0x6010D0D")]
				[Address(RVA = "0x88EF80", Offset = "0x88DB80", VA = "0x18088EF80", Slot = "121")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06010D0E RID: 68878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D0E")]
			[Address(RVA = "0x88D690", Offset = "0x88C290", VA = "0x18088D690", Slot = "122")]
			public virtual void Init(ref GameModeMeta meta, ref int randomSeed, BattlePlayerData playerData, LevelData levelData)
			{
			}

			// Token: 0x06010D0F RID: 68879 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D0F")]
			[Address(RVA = "0x88E090", Offset = "0x88CC90", VA = "0x18088E090", Slot = "123")]
			public virtual void OnPostInit()
			{
			}

			// Token: 0x06010D10 RID: 68880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D10")]
			[Address(RVA = "0x88EA70", Offset = "0x88D670", VA = "0x18088EA70", Slot = "124")]
			public virtual void StartGame(Action doDefaultStart)
			{
			}

			// Token: 0x06010D11 RID: 68881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D11")]
			[Address(RVA = "0x88DF20", Offset = "0x88CB20", VA = "0x18088DF20", Slot = "125")]
			public virtual void OnGameOver(ref BattleController.GameResult result)
			{
			}

			// Token: 0x06010D12 RID: 68882 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D12")]
			[Address(RVA = "0x88EB00", Offset = "0x88D700", VA = "0x18088EB00", Slot = "126")]
			public virtual void Tick(Action doDefaultTick)
			{
			}

			// Token: 0x06010D13 RID: 68883 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D13")]
			[Address(RVA = "0x88DF80", Offset = "0x88CB80", VA = "0x18088DF80", Slot = "127")]
			public virtual void OnModifyLifePoint(ref Modifier modifier)
			{
			}

			// Token: 0x06010D14 RID: 68884 RVA: 0x000671E8 File Offset: 0x000653E8
			[Token(Token = "0x6010D14")]
			[Address(RVA = "0x88CEE0", Offset = "0x88BAE0", VA = "0x18088CEE0", Slot = "128")]
			public virtual float GetCompleteProgress()
			{
				return 0f;
			}

			// Token: 0x06010D15 RID: 68885 RVA: 0x00067200 File Offset: 0x00065400
			[Token(Token = "0x6010D15")]
			[Address(RVA = "0x88D330", Offset = "0x88BF30", VA = "0x18088D330", Slot = "129")]
			public virtual bool HookPlayerOp_Withdraw(Character character)
			{
				return default(bool);
			}

			// Token: 0x06010D16 RID: 68886 RVA: 0x00067218 File Offset: 0x00065418
			[Token(Token = "0x6010D16")]
			[Address(RVA = "0x88D230", Offset = "0x88BE30", VA = "0x18088D230", Slot = "130")]
			public virtual bool HookPlayerOp_Spawn(uint uniqueId, SharedConsts.Direction direction, Tile tile)
			{
				return default(bool);
			}

			// Token: 0x06010D17 RID: 68887 RVA: 0x00067230 File Offset: 0x00065430
			[Token(Token = "0x6010D17")]
			[Address(RVA = "0x88D2C0", Offset = "0x88BEC0", VA = "0x18088D2C0", Slot = "131")]
			public virtual bool HookPlayerOp_TrigSkill(Character character)
			{
				return default(bool);
			}

			// Token: 0x170024EF RID: 9455
			// (get) Token: 0x06010D18 RID: 68888 RVA: 0x00067248 File Offset: 0x00065448
			[Token(Token = "0x170024EF")]
			public virtual bool HookGetNextWave
			{
				[Token(Token = "0x6010D18")]
				[Address(RVA = "0x88EEC0", Offset = "0x88DAC0", VA = "0x18088EEC0", Slot = "132")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06010D19 RID: 68889 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010D19")]
			[Address(RVA = "0x88D560", Offset = "0x88C160", VA = "0x18088D560", Slot = "133")]
			public virtual Tile Hook_MapGetTileFromScreenPos(Vector2 screenPos, out Vector2 mapPos)
			{
				return null;
			}

			// Token: 0x06010D1A RID: 68890 RVA: 0x00067260 File Offset: 0x00065460
			[Token(Token = "0x6010D1A")]
			[Address(RVA = "0x88D730", Offset = "0x88C330", VA = "0x18088D730", Slot = "134")]
			public virtual bool IsHook_MapGetTileFromScreenPos()
			{
				return default(bool);
			}

			// Token: 0x06010D1B RID: 68891 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010D1B")]
			[Address(RVA = "0x88E400", Offset = "0x88D000", VA = "0x18088E400", Slot = "135")]
			public virtual LevelData.Options PostprocessLevelOptions(LevelData.Options options)
			{
				return null;
			}

			// Token: 0x06010D1C RID: 68892 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D1C")]
			[Address(RVA = "0x88E670", Offset = "0x88D270", VA = "0x18088E670", Slot = "136")]
			public virtual void PreprocessLevelData(LevelData levelData)
			{
			}

			// Token: 0x06010D1D RID: 68893 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D1D")]
			[Address(RVA = "0x88E850", Offset = "0x88D450", VA = "0x18088E850", Slot = "137")]
			public virtual void PreprocessRuneInput(IRuneDataHolder runeInput)
			{
			}

			// Token: 0x06010D1E RID: 68894 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D1E")]
			[Address(RVA = "0x88E7F0", Offset = "0x88D3F0", VA = "0x18088E7F0", Slot = "138")]
			public virtual void PreprocessRuneData(RuneManager manager)
			{
			}

			// Token: 0x06010D1F RID: 68895 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D1F")]
			[Address(RVA = "0x88E4D0", Offset = "0x88D0D0", VA = "0x18088E4D0", Slot = "139")]
			public virtual void PostprocessRuneExtraData(Rune.RuneLevelExtraOutput extraData)
			{
			}

			// Token: 0x06010D20 RID: 68896 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D20")]
			[Address(RVA = "0x88E470", Offset = "0x88D070", VA = "0x18088E470", Slot = "140")]
			public virtual void PostprocessMap(Map map)
			{
			}

			// Token: 0x06010D21 RID: 68897 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D21")]
			[Address(RVA = "0x88E730", Offset = "0x88D330", VA = "0x18088E730", Slot = "141")]
			public virtual void PreprocessPlayerData(List<BattlePlayerData> dataList)
			{
			}

			// Token: 0x06010D22 RID: 68898 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D22")]
			[Address(RVA = "0x88E790", Offset = "0x88D390", VA = "0x18088E790", Slot = "142")]
			public virtual void PreprocessPlayerDeckList(ListDict<PlayerSide, Deck> deckList)
			{
			}

			// Token: 0x06010D23 RID: 68899 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D23")]
			[Address(RVA = "0x88E590", Offset = "0x88D190", VA = "0x18088E590", Slot = "143")]
			public virtual void PreprocessCharacterCard(BattleCharacterData data, Character character)
			{
			}

			// Token: 0x06010D24 RID: 68900 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D24")]
			[Address(RVA = "0x88E530", Offset = "0x88D130", VA = "0x18088E530", Slot = "144")]
			public virtual void PreProcessDeckCards(IList<Deck.Card> cards)
			{
			}

			// Token: 0x06010D25 RID: 68901 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D25")]
			[Address(RVA = "0x88E910", Offset = "0x88D510", VA = "0x18088E910", Slot = "145")]
			public virtual void SortDeck(Deck.Card[] cards)
			{
			}

			// Token: 0x06010D26 RID: 68902 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D26")]
			[Address(RVA = "0x88E8B0", Offset = "0x88D4B0", VA = "0x18088E8B0", Slot = "146")]
			public virtual void SortDeckRuntime(Deck.Card[] cards)
			{
			}

			// Token: 0x06010D27 RID: 68903 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D27")]
			[Address(RVA = "0x88E610", Offset = "0x88D210", VA = "0x18088E610", Slot = "147")]
			public virtual void PreprocessEnemy(LevelData.EnemyData data)
			{
			}

			// Token: 0x06010D28 RID: 68904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D28")]
			[Address(RVA = "0x88E340", Offset = "0x88CF40", VA = "0x18088E340", Slot = "148")]
			public virtual void OnWaveWillStart(LevelData.WaveData waveData)
			{
			}

			// Token: 0x06010D29 RID: 68905 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D29")]
			[Address(RVA = "0x88E2E0", Offset = "0x88CEE0", VA = "0x18088E2E0", Slot = "149")]
			public virtual void OnWaveWillFinish(LevelData.WaveData waveData)
			{
			}

			// Token: 0x06010D2A RID: 68906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D2A")]
			[Address(RVA = "0x88E3A0", Offset = "0x88CFA0", VA = "0x18088E3A0", Slot = "150")]
			public virtual void ParseBattleEvents(LevelData.WaveData.FragmentData.ActionData data)
			{
			}

			// Token: 0x06010D2B RID: 68907 RVA: 0x00067278 File Offset: 0x00065478
			[Token(Token = "0x6010D2B")]
			[Address(RVA = "0x88CB70", Offset = "0x88B770", VA = "0x18088CB70", Slot = "151")]
			public virtual bool GameNotFinishCondition()
			{
				return default(bool);
			}

			// Token: 0x06010D2C RID: 68908 RVA: 0x00067290 File Offset: 0x00065490
			[Token(Token = "0x6010D2C")]
			[Address(RVA = "0x88C1D0", Offset = "0x88ADD0", VA = "0x18088C1D0", Slot = "152")]
			public virtual bool CheckBuildable(BuildCondition buildCondition, Tile tile, SharedConsts.Direction direction, bool spawnManually, bool overflowOccupiedCnt, BattleCharacterData sourceData, PlayerSide operationSide = PlayerSide.DEFAULT)
			{
				return default(bool);
			}

			// Token: 0x06010D2D RID: 68909 RVA: 0x000672A8 File Offset: 0x000654A8
			[Token(Token = "0x6010D2D")]
			[Address(RVA = "0x88C160", Offset = "0x88AD60", VA = "0x18088C160", Slot = "153")]
			public virtual bool AllowNoneBuildableType(BattleCharacterData sourceData)
			{
				return default(bool);
			}

			// Token: 0x06010D2E RID: 68910 RVA: 0x000672C0 File Offset: 0x000654C0
			[Token(Token = "0x6010D2E")]
			[Address(RVA = "0x88D7F0", Offset = "0x88C3F0", VA = "0x18088D7F0", Slot = "154")]
			public virtual bool IsSkillClickable()
			{
				return default(bool);
			}

			// Token: 0x06010D2F RID: 68911 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010D2F")]
			[Address(RVA = "0x88D030", Offset = "0x88BC30", VA = "0x18088D030", Slot = "155")]
			public virtual Scheduler.SchedulerPreprocessor GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x06010D30 RID: 68912 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D30")]
			[Address(RVA = "0x88E6D0", Offset = "0x88D2D0", VA = "0x18088E6D0", Slot = "156")]
			public virtual void PreprocessLevelWithScheduler(LevelData levelData)
			{
			}

			// Token: 0x06010D31 RID: 68913 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010D31")]
			[Address(RVA = "0x88CC30", Offset = "0x88B830", VA = "0x18088CC30", Slot = "157")]
			public virtual List<LevelData.GlobalBuffData> GatherGlobalBuffs()
			{
				return null;
			}

			// Token: 0x06010D32 RID: 68914 RVA: 0x000672D8 File Offset: 0x000654D8
			[Token(Token = "0x6010D32")]
			[Address(RVA = "0x88D850", Offset = "0x88C450", VA = "0x18088D850", Slot = "158")]
			public virtual bool NeedPreprocessPredefinedCharacter()
			{
				return default(bool);
			}

			// Token: 0x06010D33 RID: 68915 RVA: 0x000672F0 File Offset: 0x000654F0
			[Token(Token = "0x6010D33")]
			[Address(RVA = "0x88D410", Offset = "0x88C010", VA = "0x18088D410", Slot = "159")]
			public virtual SpeedLevel HookSpeedLevel(SpeedLevel originSpeedLevel)
			{
				return SpeedLevel.SLOW_MOTION;
			}

			// Token: 0x06010D34 RID: 68916 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D34")]
			[Address(RVA = "0x88D8B0", Offset = "0x88C4B0", VA = "0x18088D8B0", Slot = "160")]
			public virtual void OnApplyingGlobalModifier(ref Modifier modifier)
			{
			}

			// Token: 0x06010D35 RID: 68917 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D35")]
			[Address(RVA = "0x88E1B0", Offset = "0x88CDB0", VA = "0x18088E1B0", Slot = "161")]
			public virtual void OnUnitRegistered(Unit unit)
			{
			}

			// Token: 0x06010D36 RID: 68918 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D36")]
			[Address(RVA = "0x88C530", Offset = "0x88B130", VA = "0x18088C530")]
			protected void CreateTDynamicTreeProxyForUnit(Unit unit)
			{
			}

			// Token: 0x06010D37 RID: 68919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D37")]
			[Address(RVA = "0x88E230", Offset = "0x88CE30", VA = "0x18088E230", Slot = "162")]
			public virtual void OnUnitUnregistered(Unit unit)
			{
			}

			// Token: 0x06010D38 RID: 68920 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D38")]
			[Address(RVA = "0x88DA50", Offset = "0x88C650", VA = "0x18088DA50", Slot = "163")]
			public virtual void OnCharacterFinished(Character character, Entity.FinishReason reason)
			{
			}

			// Token: 0x06010D39 RID: 68921 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D39")]
			[Address(RVA = "0x88DD30", Offset = "0x88C930", VA = "0x18088DD30", Slot = "164")]
			public virtual void OnEnemyFinished(Enemy enemy, Entity.FinishReason reason)
			{
			}

			// Token: 0x06010D3A RID: 68922 RVA: 0x00067308 File Offset: 0x00065508
			[Token(Token = "0x6010D3A")]
			[Address(RVA = "0x88C430", Offset = "0x88B030", VA = "0x18088C430", Slot = "165")]
			public virtual bool CheckTileValid(int row, int col)
			{
				return default(bool);
			}

			// Token: 0x06010D3B RID: 68923 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010D3B")]
			[Address(RVA = "0x88D4F0", Offset = "0x88C0F0", VA = "0x18088D4F0", Slot = "166")]
			public virtual string HookTileEffect(string originEffectKey)
			{
				return null;
			}

			// Token: 0x06010D3C RID: 68924 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010D3C")]
			[Address(RVA = "0x88CFA0", Offset = "0x88BBA0", VA = "0x18088CFA0", Slot = "167")]
			public virtual string GetModeTileEffect(Tile tile)
			{
				return null;
			}

			// Token: 0x06010D3D RID: 68925 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010D3D")]
			[Address(RVA = "0x88D480", Offset = "0x88C080", VA = "0x18088D480", Slot = "168")]
			public virtual string HookTileAppendInfoKey(string originTileKey)
			{
				return null;
			}

			// Token: 0x06010D3E RID: 68926 RVA: 0x00067320 File Offset: 0x00065520
			[Token(Token = "0x6010D3E")]
			[Address(RVA = "0x88C2D0", Offset = "0x88AED0", VA = "0x18088C2D0", Slot = "169")]
			public virtual bool CheckCardReadyToSpawn(Deck.Card card)
			{
				return default(bool);
			}

			// Token: 0x06010D3F RID: 68927 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D3F")]
			[Address(RVA = "0x88D970", Offset = "0x88C570", VA = "0x18088D970", Slot = "170")]
			public virtual void OnCardRecycle(Deck.Card card)
			{
			}

			// Token: 0x06010D40 RID: 68928 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D40")]
			[Address(RVA = "0x88D9D0", Offset = "0x88C5D0", VA = "0x18088D9D0", Slot = "171")]
			public virtual void OnCardSpawned(Deck.Card card, bool spawnManually)
			{
			}

			// Token: 0x06010D41 RID: 68929 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D41")]
			[Address(RVA = "0x88D910", Offset = "0x88C510", VA = "0x18088D910", Slot = "172")]
			public virtual void OnCardListChanged(Deck.Card card)
			{
			}

			// Token: 0x06010D42 RID: 68930 RVA: 0x00067338 File Offset: 0x00065538
			[Token(Token = "0x6010D42")]
			[Address(RVA = "0x88D0C0", Offset = "0x88BCC0", VA = "0x18088D0C0", Slot = "173")]
			public virtual bool HookBattleFinishAudio(BattleController.GameResult result)
			{
				return default(bool);
			}

			// Token: 0x06010D43 RID: 68931 RVA: 0x00067350 File Offset: 0x00065550
			[Token(Token = "0x6010D43")]
			[Address(RVA = "0x88D1A0", Offset = "0x88BDA0", VA = "0x18088D1A0", Slot = "174")]
			public virtual bool HookPlayAudioSignal(string ev, Unit unit, bool ignorePredefined)
			{
				return default(bool);
			}

			// Token: 0x06010D44 RID: 68932 RVA: 0x00067368 File Offset: 0x00065568
			[Token(Token = "0x6010D44")]
			[Address(RVA = "0x88D130", Offset = "0x88BD30", VA = "0x18088D130", Slot = "175")]
			public virtual bool HookEnemyReachedExitAudio(Enemy enemy)
			{
				return default(bool);
			}

			// Token: 0x06010D45 RID: 68933 RVA: 0x00067380 File Offset: 0x00065580
			[Token(Token = "0x6010D45")]
			[Address(RVA = "0x88C930", Offset = "0x88B530", VA = "0x18088C930", Slot = "176")]
			public virtual bool EnableGlobalBuffExtraData(GlobalBuff buff, LevelData.GlobalBuffData data)
			{
				return default(bool);
			}

			// Token: 0x06010D46 RID: 68934 RVA: 0x00067398 File Offset: 0x00065598
			[Token(Token = "0x6010D46")]
			[Address(RVA = "0x88ECA0", Offset = "0x88D8A0", VA = "0x18088ECA0", Slot = "177")]
			public virtual bool TryHookCheckWaveNotFinish(bool schedulerResult, out bool result)
			{
				return default(bool);
			}

			// Token: 0x06010D47 RID: 68935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D47")]
			[Address(RVA = "0x88E150", Offset = "0x88CD50", VA = "0x18088E150", Slot = "178")]
			public virtual void OnSpawnSummonedEnemy()
			{
			}

			// Token: 0x06010D48 RID: 68936 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D48")]
			[Address(RVA = "0x88E0F0", Offset = "0x88CCF0", VA = "0x18088E0F0", Slot = "179")]
			public virtual void OnSpawnSummonedEnemyFinished()
			{
			}

			// Token: 0x06010D49 RID: 68937 RVA: 0x000673B0 File Offset: 0x000655B0
			[Token(Token = "0x6010D49")]
			[Address(RVA = "0x88C3A0", Offset = "0x88AFA0", VA = "0x18088C3A0", Slot = "180")]
			public virtual bool CheckRenderInvisible(Entity entity, BattleRenderInvisibleMask mask)
			{
				return default(bool);
			}

			// Token: 0x06010D4A RID: 68938 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010D4A")]
			[Address(RVA = "0x88CA30", Offset = "0x88B630", VA = "0x18088CA30", Slot = "181")]
			public virtual IEnumerator FinalSchedule()
			{
				return null;
			}

			// Token: 0x06010D4B RID: 68939 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D4B")]
			[Address(RVA = "0x88CAC0", Offset = "0x88B6C0", VA = "0x18088CAC0", Slot = "182")]
			public virtual void FinishGame(Action<BattleController.GameResult, bool> gameFinishCallback, BattleController.GameResult result, bool silent = false)
			{
			}

			// Token: 0x06010D4C RID: 68940 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010D4C")]
			[Address(RVA = "0x88CC90", Offset = "0x88B890", VA = "0x18088CC90", Slot = "183")]
			public virtual object GetActMeta()
			{
				return null;
			}

			// Token: 0x06010D4D RID: 68941 RVA: 0x000673C8 File Offset: 0x000655C8
			[Token(Token = "0x6010D4D")]
			[Address(RVA = "0x88CCF0", Offset = "0x88B8F0", VA = "0x18088CCF0", Slot = "184")]
			public virtual PlayerBattleRank GetBattleCompleteRank()
			{
				return (PlayerBattleRank)0;
			}

			// Token: 0x06010D4E RID: 68942 RVA: 0x000673E0 File Offset: 0x000655E0
			[Token(Token = "0x6010D4E")]
			[Address(RVA = "0x88EC30", Offset = "0x88D830", VA = "0x18088EC30", Slot = "185")]
			public virtual bool TryGetNextWaveIndexInGameMode(out int index)
			{
				return default(bool);
			}

			// Token: 0x06010D4F RID: 68943 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D4F")]
			[Address(RVA = "0x88DC90", Offset = "0x88C890", VA = "0x18088DC90", Slot = "186")]
			public virtual void OnDummyTouchedToTile(Character character, Tile tile, Vector3 dummyPos)
			{
			}

			// Token: 0x06010D50 RID: 68944 RVA: 0x000673F8 File Offset: 0x000655F8
			[Token(Token = "0x6010D50")]
			[Address(RVA = "0x88D630", Offset = "0x88C230", VA = "0x18088D630", Slot = "187")]
			public virtual bool Hook_OnDummyDragging()
			{
				return default(bool);
			}

			// Token: 0x06010D51 RID: 68945 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D51")]
			[Address(RVA = "0x88DC10", Offset = "0x88C810", VA = "0x18088DC10", Slot = "188")]
			public virtual void OnDummySetBodyAndFaceDirection(Character character, SharedConsts.Direction direction)
			{
			}

			// Token: 0x06010D52 RID: 68946 RVA: 0x00067410 File Offset: 0x00065610
			[Token(Token = "0x6010D52")]
			[Address(RVA = "0x88DE90", Offset = "0x88CA90", VA = "0x18088DE90", Slot = "189")]
			public virtual bool OnEntityApplyModifier(Entity entity, ref Modifier modifier)
			{
				return default(bool);
			}

			// Token: 0x06010D53 RID: 68947 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D53")]
			[Address(RVA = "0x88C840", Offset = "0x88B440", VA = "0x18088C840", Slot = "190")]
			public virtual void DestroyEntity(Entity entity, Entity.FinishReason reason)
			{
			}

			// Token: 0x06010D54 RID: 68948 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D54")]
			[Address(RVA = "0x88DFE0", Offset = "0x88CBE0", VA = "0x18088DFE0", Slot = "191")]
			public virtual void OnPlayerLifeToZero(PlayerSide side)
			{
			}

			// Token: 0x06010D55 RID: 68949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D55")]
			[Address(RVA = "0x88DDB0", Offset = "0x88C9B0", VA = "0x18088DDB0", Slot = "192")]
			public virtual void OnEnemyReachExit(Enemy enemy, Tile cacheTile)
			{
			}

			// Token: 0x06010D56 RID: 68950 RVA: 0x00067428 File Offset: 0x00065628
			[Token(Token = "0x6010D56")]
			[Address(RVA = "0x88EDC0", Offset = "0x88D9C0", VA = "0x18088EDC0", Slot = "193")]
			public virtual bool TryShowTileInfoToast(Tile tile, out int id)
			{
				return default(bool);
			}

			// Token: 0x06010D57 RID: 68951 RVA: 0x00067440 File Offset: 0x00065640
			[Token(Token = "0x6010D57")]
			[Address(RVA = "0x88ED30", Offset = "0x88D930", VA = "0x18088ED30", Slot = "194")]
			public virtual bool TrySetTileHighlightType(Tile tile, bool isBuildable, BattleCharacterData sourceData)
			{
				return default(bool);
			}

			// Token: 0x06010D58 RID: 68952 RVA: 0x00067458 File Offset: 0x00065658
			[Token(Token = "0x6010D58")]
			[Address(RVA = "0x88EB90", Offset = "0x88D790", VA = "0x18088EB90", Slot = "195")]
			public virtual bool TryGetCustomTileHighlightColor(out Color customColor, out Color emissionColor)
			{
				return default(bool);
			}

			// Token: 0x06010D59 RID: 68953 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D59")]
			[Address(RVA = "0x88DAD0", Offset = "0x88C6D0", VA = "0x18088DAD0", Slot = "196")]
			public virtual void OnCharacterRespawnFailed(Character character, Deck.Card card, PlayerSide playerSide)
			{
			}

			// Token: 0x06010D5A RID: 68954 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D5A")]
			[Address(RVA = "0x88DBB0", Offset = "0x88C7B0", VA = "0x18088DBB0", Slot = "197")]
			public virtual void OnDestroy()
			{
			}

			// Token: 0x06010D5B RID: 68955 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010D5B")]
			[Address(RVA = "0x88C9D0", Offset = "0x88B5D0", VA = "0x18088C9D0", Slot = "198")]
			public virtual HashSet<GridPosition> FetchValidMapGrids()
			{
				return null;
			}

			// Token: 0x06010D5C RID: 68956 RVA: 0x00067470 File Offset: 0x00065670
			[Token(Token = "0x6010D5C")]
			[Address(RVA = "0x88D790", Offset = "0x88C390", VA = "0x18088D790", Slot = "199")]
			public virtual bool IsMultiplayerLocal()
			{
				return default(bool);
			}

			// Token: 0x06010D5D RID: 68957 RVA: 0x00067488 File Offset: 0x00065688
			[Token(Token = "0x6010D5D")]
			[Address(RVA = "0x88C4C0", Offset = "0x88B0C0", VA = "0x18088C4C0", Slot = "200")]
			public virtual bool CheckUnitValidHudPlugin(Unit unit)
			{
				return default(bool);
			}

			// Token: 0x06010D5E RID: 68958 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010D5E")]
			[Address(RVA = "0x88CBD0", Offset = "0x88B7D0", VA = "0x18088CBD0", Slot = "201")]
			public virtual List<GlobalEnvSystemData> GatherEnvSystems()
			{
				return null;
			}

			// Token: 0x06010D5F RID: 68959 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D5F")]
			[Address(RVA = "0x88EE50", Offset = "0x88DA50", VA = "0x18088EE50")]
			public DefaultGameMode(ref GameModeMeta meta)
			{
			}

			// Token: 0x04012DA4 RID: 77220
			[Token(Token = "0x4012DA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool m_allowManualTick;

			// Token: 0x04012DA6 RID: 77222
			[Token(Token = "0x4012DA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_allowManualTick;

			// Token: 0x04012DA7 RID: 77223
			[Token(Token = "0x4012DA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isOnline;

			// Token: 0x04012DA8 RID: 77224
			[Token(Token = "0x4012DA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_isLargeMap;

			// Token: 0x04012DA9 RID: 77225
			[Token(Token = "0x4012DA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_hasExtraBuildCondition;

			// Token: 0x04012DAA RID: 77226
			[Token(Token = "0x4012DAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_isSupportSlowMotion;

			// Token: 0x04012DAB RID: 77227
			[Token(Token = "0x4012DAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_doDefaultSchedule;

			// Token: 0x04012DAC RID: 77228
			[Token(Token = "0x4012DAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_useLevelBgm;

			// Token: 0x04012DAD RID: 77229
			[Token(Token = "0x4012DAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_isLowMemoryGameMode;

			// Token: 0x04012DAE RID: 77230
			[Token(Token = "0x4012DAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_outlineConfig;

			// Token: 0x04012DAF RID: 77231
			[Token(Token = "0x4012DAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_enableParticleEffectManager;

			// Token: 0x04012DB0 RID: 77232
			[Token(Token = "0x4012DB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_HookSeed;

			// Token: 0x04012DB1 RID: 77233
			[Token(Token = "0x4012DB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_draggingDummy;

			// Token: 0x04012DB2 RID: 77234
			[Token(Token = "0x4012DB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_set_draggingDummy;

			// Token: 0x04012DB3 RID: 77235
			[Token(Token = "0x4012DB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_isInCommonGameStage;

			// Token: 0x04012DB4 RID: 77236
			[Token(Token = "0x4012DB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_enableHudSlowTicker;

			// Token: 0x04012DB5 RID: 77237
			[Token(Token = "0x4012DB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_get_enablePause;

			// Token: 0x04012DB6 RID: 77238
			[Token(Token = "0x4012DB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_get_gameModeType;

			// Token: 0x04012DB7 RID: 77239
			[Token(Token = "0x4012DB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_get_waveHandler;

			// Token: 0x04012DB8 RID: 77240
			[Token(Token = "0x4012DB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_get_allowPoolManagerUnload;

			// Token: 0x04012DB9 RID: 77241
			[Token(Token = "0x4012DB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x04012DBA RID: 77242
			[Token(Token = "0x4012DBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_OnPostInit;

			// Token: 0x04012DBB RID: 77243
			[Token(Token = "0x4012DBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_StartGame;

			// Token: 0x04012DBC RID: 77244
			[Token(Token = "0x4012DBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_OnGameOver;

			// Token: 0x04012DBD RID: 77245
			[Token(Token = "0x4012DBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_Tick;

			// Token: 0x04012DBE RID: 77246
			[Token(Token = "0x4012DBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_OnModifyLifePoint;

			// Token: 0x04012DBF RID: 77247
			[Token(Token = "0x4012DBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_GetCompleteProgress;

			// Token: 0x04012DC0 RID: 77248
			[Token(Token = "0x4012DC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0_HookPlayerOp_Withdraw;

			// Token: 0x04012DC1 RID: 77249
			[Token(Token = "0x4012DC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0_HookPlayerOp_Spawn;

			// Token: 0x04012DC2 RID: 77250
			[Token(Token = "0x4012DC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0_HookPlayerOp_TrigSkill;

			// Token: 0x04012DC3 RID: 77251
			[Token(Token = "0x4012DC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0_get_HookGetNextWave;

			// Token: 0x04012DC4 RID: 77252
			[Token(Token = "0x4012DC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private static DelegateBridge __Hotfix0_Hook_MapGetTileFromScreenPos;

			// Token: 0x04012DC5 RID: 77253
			[Token(Token = "0x4012DC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private static DelegateBridge __Hotfix0_IsHook_MapGetTileFromScreenPos;

			// Token: 0x04012DC6 RID: 77254
			[Token(Token = "0x4012DC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			private static DelegateBridge __Hotfix0_PostprocessLevelOptions;

			// Token: 0x04012DC7 RID: 77255
			[Token(Token = "0x4012DC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private static DelegateBridge __Hotfix0_PreprocessLevelData;

			// Token: 0x04012DC8 RID: 77256
			[Token(Token = "0x4012DC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private static DelegateBridge __Hotfix0_PreprocessRuneInput;

			// Token: 0x04012DC9 RID: 77257
			[Token(Token = "0x4012DC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private static DelegateBridge __Hotfix0_PreprocessRuneData;

			// Token: 0x04012DCA RID: 77258
			[Token(Token = "0x4012DCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private static DelegateBridge __Hotfix0_PostprocessRuneExtraData;

			// Token: 0x04012DCB RID: 77259
			[Token(Token = "0x4012DCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private static DelegateBridge __Hotfix0_PostprocessMap;

			// Token: 0x04012DCC RID: 77260
			[Token(Token = "0x4012DCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private static DelegateBridge __Hotfix0_PreprocessPlayerData;

			// Token: 0x04012DCD RID: 77261
			[Token(Token = "0x4012DCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private static DelegateBridge __Hotfix0_PreprocessPlayerDeckList;

			// Token: 0x04012DCE RID: 77262
			[Token(Token = "0x4012DCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private static DelegateBridge __Hotfix0_PreprocessCharacterCard;

			// Token: 0x04012DCF RID: 77263
			[Token(Token = "0x4012DCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			private static DelegateBridge __Hotfix0_PreProcessDeckCards;

			// Token: 0x04012DD0 RID: 77264
			[Token(Token = "0x4012DD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			private static DelegateBridge __Hotfix0_SortDeck;

			// Token: 0x04012DD1 RID: 77265
			[Token(Token = "0x4012DD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			private static DelegateBridge __Hotfix0_SortDeckRuntime;

			// Token: 0x04012DD2 RID: 77266
			[Token(Token = "0x4012DD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			private static DelegateBridge __Hotfix0_PreprocessEnemy;

			// Token: 0x04012DD3 RID: 77267
			[Token(Token = "0x4012DD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private static DelegateBridge __Hotfix0_OnWaveWillStart;

			// Token: 0x04012DD4 RID: 77268
			[Token(Token = "0x4012DD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			private static DelegateBridge __Hotfix0_OnWaveWillFinish;

			// Token: 0x04012DD5 RID: 77269
			[Token(Token = "0x4012DD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private static DelegateBridge __Hotfix0_ParseBattleEvents;

			// Token: 0x04012DD6 RID: 77270
			[Token(Token = "0x4012DD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
			private static DelegateBridge __Hotfix0_GameNotFinishCondition;

			// Token: 0x04012DD7 RID: 77271
			[Token(Token = "0x4012DD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private static DelegateBridge __Hotfix0_CheckBuildable;

			// Token: 0x04012DD8 RID: 77272
			[Token(Token = "0x4012DD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
			private static DelegateBridge __Hotfix0_AllowNoneBuildableType;

			// Token: 0x04012DD9 RID: 77273
			[Token(Token = "0x4012DD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private static DelegateBridge __Hotfix0_IsSkillClickable;

			// Token: 0x04012DDA RID: 77274
			[Token(Token = "0x4012DDA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
			private static DelegateBridge __Hotfix0_GetSchedulerPreprocessor;

			// Token: 0x04012DDB RID: 77275
			[Token(Token = "0x4012DDB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private static DelegateBridge __Hotfix0_PreprocessLevelWithScheduler;

			// Token: 0x04012DDC RID: 77276
			[Token(Token = "0x4012DDC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
			private static DelegateBridge __Hotfix0_GatherGlobalBuffs;

			// Token: 0x04012DDD RID: 77277
			[Token(Token = "0x4012DDD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private static DelegateBridge __Hotfix0_NeedPreprocessPredefinedCharacter;

			// Token: 0x04012DDE RID: 77278
			[Token(Token = "0x4012DDE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
			private static DelegateBridge __Hotfix0_HookSpeedLevel;

			// Token: 0x04012DDF RID: 77279
			[Token(Token = "0x4012DDF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private static DelegateBridge __Hotfix0_OnApplyingGlobalModifier;

			// Token: 0x04012DE0 RID: 77280
			[Token(Token = "0x4012DE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
			private static DelegateBridge __Hotfix0_OnUnitRegistered;

			// Token: 0x04012DE1 RID: 77281
			[Token(Token = "0x4012DE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private static DelegateBridge __Hotfix0_CreateTDynamicTreeProxyForUnit;

			// Token: 0x04012DE2 RID: 77282
			[Token(Token = "0x4012DE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private static DelegateBridge __Hotfix0_OnUnitUnregistered;

			// Token: 0x04012DE3 RID: 77283
			[Token(Token = "0x4012DE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private static DelegateBridge __Hotfix0_OnCharacterFinished;

			// Token: 0x04012DE4 RID: 77284
			[Token(Token = "0x4012DE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private static DelegateBridge __Hotfix0_OnEnemyFinished;

			// Token: 0x04012DE5 RID: 77285
			[Token(Token = "0x4012DE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private static DelegateBridge __Hotfix0_CheckTileValid;

			// Token: 0x04012DE6 RID: 77286
			[Token(Token = "0x4012DE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private static DelegateBridge __Hotfix0_HookTileEffect;

			// Token: 0x04012DE7 RID: 77287
			[Token(Token = "0x4012DE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private static DelegateBridge __Hotfix0_GetModeTileEffect;

			// Token: 0x04012DE8 RID: 77288
			[Token(Token = "0x4012DE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private static DelegateBridge __Hotfix0_HookTileAppendInfoKey;

			// Token: 0x04012DE9 RID: 77289
			[Token(Token = "0x4012DE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private static DelegateBridge __Hotfix0_CheckCardReadyToSpawn;

			// Token: 0x04012DEA RID: 77290
			[Token(Token = "0x4012DEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
			private static DelegateBridge __Hotfix0_OnCardRecycle;

			// Token: 0x04012DEB RID: 77291
			[Token(Token = "0x4012DEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
			private static DelegateBridge __Hotfix0_OnCardSpawned;

			// Token: 0x04012DEC RID: 77292
			[Token(Token = "0x4012DEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
			private static DelegateBridge __Hotfix0_OnCardListChanged;

			// Token: 0x04012DED RID: 77293
			[Token(Token = "0x4012DED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
			private static DelegateBridge __Hotfix0_HookBattleFinishAudio;

			// Token: 0x04012DEE RID: 77294
			[Token(Token = "0x4012DEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
			private static DelegateBridge __Hotfix0_HookPlayAudioSignal;

			// Token: 0x04012DEF RID: 77295
			[Token(Token = "0x4012DEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
			private static DelegateBridge __Hotfix0_HookEnemyReachedExitAudio;

			// Token: 0x04012DF0 RID: 77296
			[Token(Token = "0x4012DF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
			private static DelegateBridge __Hotfix0_EnableGlobalBuffExtraData;

			// Token: 0x04012DF1 RID: 77297
			[Token(Token = "0x4012DF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
			private static DelegateBridge __Hotfix0_TryHookCheckWaveNotFinish;

			// Token: 0x04012DF2 RID: 77298
			[Token(Token = "0x4012DF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
			private static DelegateBridge __Hotfix0_OnSpawnSummonedEnemy;

			// Token: 0x04012DF3 RID: 77299
			[Token(Token = "0x4012DF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
			private static DelegateBridge __Hotfix0_OnSpawnSummonedEnemyFinished;

			// Token: 0x04012DF4 RID: 77300
			[Token(Token = "0x4012DF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
			private static DelegateBridge __Hotfix0_CheckRenderInvisible;

			// Token: 0x04012DF5 RID: 77301
			[Token(Token = "0x4012DF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
			private static DelegateBridge __Hotfix0_FinalSchedule;

			// Token: 0x04012DF6 RID: 77302
			[Token(Token = "0x4012DF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
			private static DelegateBridge __Hotfix0_FinishGame;

			// Token: 0x04012DF7 RID: 77303
			[Token(Token = "0x4012DF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
			private static DelegateBridge __Hotfix0_GetActMeta;

			// Token: 0x04012DF8 RID: 77304
			[Token(Token = "0x4012DF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
			private static DelegateBridge __Hotfix0_GetBattleCompleteRank;

			// Token: 0x04012DF9 RID: 77305
			[Token(Token = "0x4012DF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
			private static DelegateBridge __Hotfix0_TryGetNextWaveIndexInGameMode;

			// Token: 0x04012DFA RID: 77306
			[Token(Token = "0x4012DFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
			private static DelegateBridge __Hotfix0_OnDummyTouchedToTile;

			// Token: 0x04012DFB RID: 77307
			[Token(Token = "0x4012DFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
			private static DelegateBridge __Hotfix0_Hook_OnDummyDragging;

			// Token: 0x04012DFC RID: 77308
			[Token(Token = "0x4012DFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
			private static DelegateBridge __Hotfix0_OnDummySetBodyAndFaceDirection;

			// Token: 0x04012DFD RID: 77309
			[Token(Token = "0x4012DFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
			private static DelegateBridge __Hotfix0_OnEntityApplyModifier;

			// Token: 0x04012DFE RID: 77310
			[Token(Token = "0x4012DFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
			private static DelegateBridge __Hotfix0_DestroyEntity;

			// Token: 0x04012DFF RID: 77311
			[Token(Token = "0x4012DFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
			private static DelegateBridge __Hotfix0_OnPlayerLifeToZero;

			// Token: 0x04012E00 RID: 77312
			[Token(Token = "0x4012E00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
			private static DelegateBridge __Hotfix0_OnEnemyReachExit;

			// Token: 0x04012E01 RID: 77313
			[Token(Token = "0x4012E01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
			private static DelegateBridge __Hotfix0_TryShowTileInfoToast;

			// Token: 0x04012E02 RID: 77314
			[Token(Token = "0x4012E02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
			private static DelegateBridge __Hotfix0_TrySetTileHighlightType;

			// Token: 0x04012E03 RID: 77315
			[Token(Token = "0x4012E03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
			private static DelegateBridge __Hotfix0_TryGetCustomTileHighlightColor;

			// Token: 0x04012E04 RID: 77316
			[Token(Token = "0x4012E04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
			private static DelegateBridge __Hotfix0_OnCharacterRespawnFailed;

			// Token: 0x04012E05 RID: 77317
			[Token(Token = "0x4012E05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
			private static DelegateBridge __Hotfix0_OnDestroy;

			// Token: 0x04012E06 RID: 77318
			[Token(Token = "0x4012E06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
			private static DelegateBridge __Hotfix0_FetchValidMapGrids;

			// Token: 0x04012E07 RID: 77319
			[Token(Token = "0x4012E07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
			private static DelegateBridge __Hotfix0_IsMultiplayerLocal;

			// Token: 0x04012E08 RID: 77320
			[Token(Token = "0x4012E08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
			private static DelegateBridge __Hotfix0_CheckUnitValidHudPlugin;

			// Token: 0x04012E09 RID: 77321
			[Token(Token = "0x4012E09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
			private static DelegateBridge __Hotfix0_GatherEnvSystems;

			// Token: 0x04012E0A RID: 77322
			[Token(Token = "0x4012E0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020027DB RID: 10203
		[Token(Token = "0x20027DB")]
		public class HalfIdleGameMode : GameModeFactory.DefaultGameMode
		{
			// Token: 0x170024F2 RID: 9458
			// (get) Token: 0x06010D69 RID: 68969 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170024F2")]
			public static GameModeFactory.HalfIdleGameMode instance
			{
				[Token(Token = "0x6010D69")]
				[Address(RVA = "0x8AD1E0", Offset = "0x8ABDE0", VA = "0x1808AD1E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170024F3 RID: 9459
			// (get) Token: 0x06010D6A RID: 68970 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170024F3")]
			public Act1VHalfIdleConstData constData
			{
				[Token(Token = "0x6010D6A")]
				[Address(RVA = "0x8ACBA0", Offset = "0x8AB7A0", VA = "0x1808ACBA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170024F4 RID: 9460
			// (get) Token: 0x06010D6B RID: 68971 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170024F4")]
			public EventPool<HalfIdleBattleData.HalfIdleBattleEvent> eventPool
			{
				[Token(Token = "0x6010D6B")]
				[Address(RVA = "0x8AD000", Offset = "0x8ABC00", VA = "0x1808AD000")]
				get
				{
					return null;
				}
			}

			// Token: 0x170024F5 RID: 9461
			// (get) Token: 0x06010D6C RID: 68972 RVA: 0x000674D0 File Offset: 0x000656D0
			[Token(Token = "0x170024F5")]
			public FP bossBranchTriggerTime
			{
				[Token(Token = "0x6010D6C")]
				[Address(RVA = "0x8ACB30", Offset = "0x8AB730", VA = "0x1808ACB30")]
				get
				{
					return default(FP);
				}
			}

			// Token: 0x170024F6 RID: 9462
			// (get) Token: 0x06010D6D RID: 68973 RVA: 0x000674E8 File Offset: 0x000656E8
			[Token(Token = "0x170024F6")]
			public FP maxPlayTime
			{
				[Token(Token = "0x6010D6D")]
				[Address(RVA = "0x8ADA90", Offset = "0x8AC690", VA = "0x1808ADA90")]
				get
				{
					return default(FP);
				}
			}

			// Token: 0x170024F7 RID: 9463
			// (get) Token: 0x06010D6E RID: 68974 RVA: 0x00067500 File Offset: 0x00065700
			[Token(Token = "0x170024F7")]
			public FP playTime
			{
				[Token(Token = "0x6010D6E")]
				[Address(RVA = "0x8ADB70", Offset = "0x8AC770", VA = "0x1808ADB70")]
				get
				{
					return default(FP);
				}
			}

			// Token: 0x170024F8 RID: 9464
			// (get) Token: 0x06010D6F RID: 68975 RVA: 0x00067518 File Offset: 0x00065718
			[Token(Token = "0x170024F8")]
			public int occupiedEnemyCapacity
			{
				[Token(Token = "0x6010D6F")]
				[Address(RVA = "0x8ADB00", Offset = "0x8AC700", VA = "0x1808ADB00")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170024F9 RID: 9465
			// (get) Token: 0x06010D70 RID: 68976 RVA: 0x00067530 File Offset: 0x00065730
			[Token(Token = "0x170024F9")]
			public int maxEnemyCapacity
			{
				[Token(Token = "0x6010D70")]
				[Address(RVA = "0x8ADA20", Offset = "0x8AC620", VA = "0x1808ADA20")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170024FA RID: 9466
			// (get) Token: 0x06010D71 RID: 68977 RVA: 0x00067548 File Offset: 0x00065748
			[Token(Token = "0x170024FA")]
			public int currentLifePoint
			{
				[Token(Token = "0x6010D71")]
				[Address(RVA = "0x8ACD80", Offset = "0x8AB980", VA = "0x1808ACD80")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170024FB RID: 9467
			// (get) Token: 0x06010D72 RID: 68978 RVA: 0x00067560 File Offset: 0x00065760
			[Token(Token = "0x170024FB")]
			public int lostLifePointByEnemyOverload
			{
				[Token(Token = "0x6010D72")]
				[Address(RVA = "0x8AD860", Offset = "0x8AC460", VA = "0x1808AD860")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170024FC RID: 9468
			// (get) Token: 0x06010D73 RID: 68979 RVA: 0x00067578 File Offset: 0x00065778
			[Token(Token = "0x170024FC")]
			public int lostLifePointByOthers
			{
				[Token(Token = "0x6010D73")]
				[Address(RVA = "0x8AD900", Offset = "0x8AC500", VA = "0x1808AD900")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170024FD RID: 9469
			// (get) Token: 0x06010D74 RID: 68980 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170024FD")]
			public List<FP> enemyRushTimeList
			{
				[Token(Token = "0x6010D74")]
				[Address(RVA = "0x8ACF00", Offset = "0x8ABB00", VA = "0x1808ACF00")]
				get
				{
					return null;
				}
			}

			// Token: 0x170024FE RID: 9470
			// (get) Token: 0x06010D75 RID: 68981 RVA: 0x00067590 File Offset: 0x00065790
			[Token(Token = "0x170024FE")]
			public bool isEnemyOverload
			{
				[Token(Token = "0x6010D75")]
				[Address(RVA = "0x8AD550", Offset = "0x8AC150", VA = "0x1808AD550")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170024FF RID: 9471
			// (get) Token: 0x06010D76 RID: 68982 RVA: 0x000675A8 File Offset: 0x000657A8
			[Token(Token = "0x170024FF")]
			public bool isEnemyOverloadWarning
			{
				[Token(Token = "0x6010D76")]
				[Address(RVA = "0x8AD4D0", Offset = "0x8AC0D0", VA = "0x1808AD4D0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002500 RID: 9472
			// (get) Token: 0x06010D77 RID: 68983 RVA: 0x000675C0 File Offset: 0x000657C0
			[Token(Token = "0x17002500")]
			public bool isBattleCountdown
			{
				[Token(Token = "0x6010D77")]
				[Address(RVA = "0x8AD310", Offset = "0x8ABF10", VA = "0x1808AD310")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002501 RID: 9473
			// (get) Token: 0x06010D78 RID: 68984 RVA: 0x000675D8 File Offset: 0x000657D8
			[Token(Token = "0x17002501")]
			public FP lossLifeCountdown
			{
				[Token(Token = "0x6010D78")]
				[Address(RVA = "0x8AD7E0", Offset = "0x8AC3E0", VA = "0x1808AD7E0")]
				get
				{
					return default(FP);
				}
			}

			// Token: 0x17002502 RID: 9474
			// (get) Token: 0x06010D79 RID: 68985 RVA: 0x000675F0 File Offset: 0x000657F0
			[Token(Token = "0x17002502")]
			public bool hasCharacterLevelUp
			{
				[Token(Token = "0x6010D79")]
				[Address(RVA = "0x8AD0F0", Offset = "0x8ABCF0", VA = "0x1808AD0F0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002503 RID: 9475
			// (get) Token: 0x06010D7A RID: 68986 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17002503")]
			public ListDict<string, int[]> resourceCountDict
			{
				[Token(Token = "0x6010D7A")]
				[Address(RVA = "0x8ADC10", Offset = "0x8AC810", VA = "0x1808ADC10")]
				get
				{
					return null;
				}
			}

			// Token: 0x17002504 RID: 9476
			// (get) Token: 0x06010D7B RID: 68987 RVA: 0x00067608 File Offset: 0x00065808
			[Token(Token = "0x17002504")]
			public bool isResourcePanelShow
			{
				[Token(Token = "0x6010D7B")]
				[Address(RVA = "0x8AD760", Offset = "0x8AC360", VA = "0x1808AD760")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002505 RID: 9477
			// (get) Token: 0x06010D7C RID: 68988 RVA: 0x00067620 File Offset: 0x00065820
			[Token(Token = "0x17002505")]
			public bool isResourcePanelShowManually
			{
				[Token(Token = "0x6010D7C")]
				[Address(RVA = "0x8AD6E0", Offset = "0x8AC2E0", VA = "0x1808AD6E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002506 RID: 9478
			// (get) Token: 0x06010D7D RID: 68989 RVA: 0x00067638 File Offset: 0x00065838
			[Token(Token = "0x17002506")]
			public bool isEquipPanelUnfolded
			{
				[Token(Token = "0x6010D7D")]
				[Address(RVA = "0x8AD660", Offset = "0x8AC260", VA = "0x1808AD660")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002507 RID: 9479
			// (get) Token: 0x06010D7E RID: 68990 RVA: 0x00067650 File Offset: 0x00065850
			[Token(Token = "0x17002507")]
			public bool isBattlePanelInteractable
			{
				[Token(Token = "0x6010D7E")]
				[Address(RVA = "0x8AD3D0", Offset = "0x8ABFD0", VA = "0x1808AD3D0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002508 RID: 9480
			// (get) Token: 0x06010D7F RID: 68991 RVA: 0x00067668 File Offset: 0x00065868
			[Token(Token = "0x17002508")]
			public bool isEquipAutoUpgradeOn
			{
				[Token(Token = "0x6010D7F")]
				[Address(RVA = "0x8AD5D0", Offset = "0x8AC1D0", VA = "0x1808AD5D0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002509 RID: 9481
			// (get) Token: 0x06010D80 RID: 68992 RVA: 0x00067680 File Offset: 0x00065880
			[Token(Token = "0x17002509")]
			public Act1VHalfIdleEquipType selectedEquipType
			{
				[Token(Token = "0x6010D80")]
				[Address(RVA = "0x8ADC90", Offset = "0x8AC890", VA = "0x1808ADC90")]
				get
				{
					return Act1VHalfIdleEquipType.WEAPON;
				}
			}

			// Token: 0x1700250A RID: 9482
			// (get) Token: 0x06010D81 RID: 68993 RVA: 0x00067698 File Offset: 0x00065898
			[Token(Token = "0x1700250A")]
			public bool isBossKilled
			{
				[Token(Token = "0x6010D81")]
				[Address(RVA = "0x8AD450", Offset = "0x8AC050", VA = "0x1808AD450")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700250B RID: 9483
			// (get) Token: 0x06010D82 RID: 68994 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700250B")]
			public HalfIdleBattleEquipManager equipManager
			{
				[Token(Token = "0x6010D82")]
				[Address(RVA = "0x8ACF80", Offset = "0x8ABB80", VA = "0x1808ACF80")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700250C RID: 9484
			// (get) Token: 0x06010D83 RID: 68995 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700250C")]
			public string actId
			{
				[Token(Token = "0x6010D83")]
				[Address(RVA = "0x8AC9E0", Offset = "0x8AB5E0", VA = "0x1808AC9E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700250D RID: 9485
			// (get) Token: 0x06010D84 RID: 68996 RVA: 0x000676B0 File Offset: 0x000658B0
			[Token(Token = "0x1700250D")]
			public int curDeckPageIndex
			{
				[Token(Token = "0x6010D84")]
				[Address(RVA = "0x8ACD00", Offset = "0x8AB900", VA = "0x1808ACD00")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700250E RID: 9486
			// (get) Token: 0x06010D85 RID: 68997 RVA: 0x000676C8 File Offset: 0x000658C8
			[Token(Token = "0x1700250E")]
			public int maxDeckPageNum
			{
				[Token(Token = "0x6010D85")]
				[Address(RVA = "0x8AD9A0", Offset = "0x8AC5A0", VA = "0x1808AD9A0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06010D86 RID: 68998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D86")]
			[Address(RVA = "0x8AC780", Offset = "0x8AB380", VA = "0x1808AC780")]
			public HalfIdleGameMode(ref GameModeMeta meta)
			{
			}

			// Token: 0x1700250F RID: 9487
			// (get) Token: 0x06010D87 RID: 68999 RVA: 0x000676E0 File Offset: 0x000658E0
			[Token(Token = "0x1700250F")]
			public override GameModeMeta.GameModeType gameModeType
			{
				[Token(Token = "0x6010D87")]
				[Address(RVA = "0x8AD080", Offset = "0x8ABC80", VA = "0x1808AD080", Slot = "119")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x17002510 RID: 9488
			// (get) Token: 0x06010D88 RID: 69000 RVA: 0x000676F8 File Offset: 0x000658F8
			[Token(Token = "0x17002510")]
			public override bool enableParticleEffectManager
			{
				[Token(Token = "0x6010D88")]
				[Address(RVA = "0x8ACE90", Offset = "0x8ABA90", VA = "0x1808ACE90", Slot = "112")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002511 RID: 9489
			// (get) Token: 0x06010D89 RID: 69001 RVA: 0x00067710 File Offset: 0x00065910
			[Token(Token = "0x17002511")]
			public override bool enableHudSlowTicker
			{
				[Token(Token = "0x6010D89")]
				[Address(RVA = "0x8ACE20", Offset = "0x8ABA20", VA = "0x1808ACE20", Slot = "117")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06010D8A RID: 69002 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010D8A")]
			[Address(RVA = "0x89FDA0", Offset = "0x89E9A0", VA = "0x18089FDA0")]
			public static Dictionary<ResourceCollector.PreloadType, object> GatherPreloadAssets()
			{
				return null;
			}

			// Token: 0x06010D8B RID: 69003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D8B")]
			[Address(RVA = "0x8A1430", Offset = "0x8A0030", VA = "0x1808A1430", Slot = "122")]
			public override void Init(ref GameModeMeta meta, ref int randomSeed, BattlePlayerData playerData, LevelData levelData)
			{
			}

			// Token: 0x06010D8C RID: 69004 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D8C")]
			[Address(RVA = "0x8A2FC0", Offset = "0x8A1BC0", VA = "0x1808A2FC0", Slot = "123")]
			public override void OnPostInit()
			{
			}

			// Token: 0x06010D8D RID: 69005 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D8D")]
			[Address(RVA = "0x8A2DD0", Offset = "0x8A19D0", VA = "0x1808A2DD0", Slot = "192")]
			public override void OnEnemyReachExit(Enemy enemy, Tile cacheTile)
			{
			}

			// Token: 0x06010D8E RID: 69006 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D8E")]
			[Address(RVA = "0x8A3D30", Offset = "0x8A2930", VA = "0x1808A3D30", Slot = "126")]
			public override void Tick(Action doDefaultTick)
			{
			}

			// Token: 0x06010D8F RID: 69007 RVA: 0x00067728 File Offset: 0x00065928
			[Token(Token = "0x6010D8F")]
			[Address(RVA = "0x89FBA0", Offset = "0x89E7A0", VA = "0x18089FBA0", Slot = "151")]
			public override bool GameNotFinishCondition()
			{
				return default(bool);
			}

			// Token: 0x06010D90 RID: 69008 RVA: 0x00067740 File Offset: 0x00065940
			[Token(Token = "0x6010D90")]
			[Address(RVA = "0x8A0660", Offset = "0x89F260", VA = "0x1808A0660", Slot = "184")]
			public override PlayerBattleRank GetBattleCompleteRank()
			{
				return (PlayerBattleRank)0;
			}

			// Token: 0x06010D91 RID: 69009 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D91")]
			[Address(RVA = "0x8A2F30", Offset = "0x8A1B30", VA = "0x1808A2F30", Slot = "191")]
			public override void OnPlayerLifeToZero(PlayerSide side)
			{
			}

			// Token: 0x06010D92 RID: 69010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D92")]
			[Address(RVA = "0x8A2530", Offset = "0x8A1130", VA = "0x1808A2530", Slot = "171")]
			public override void OnCardSpawned(Deck.Card card, bool spawnManually)
			{
			}

			// Token: 0x06010D93 RID: 69011 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D93")]
			[Address(RVA = "0x8A30E0", Offset = "0x8A1CE0", VA = "0x1808A30E0", Slot = "161")]
			public override void OnUnitRegistered(Unit unit)
			{
			}

			// Token: 0x06010D94 RID: 69012 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D94")]
			[Address(RVA = "0x8A2970", Offset = "0x8A1570", VA = "0x1808A2970", Slot = "164")]
			public override void OnEnemyFinished(Enemy enemy, Entity.FinishReason reason)
			{
			}

			// Token: 0x06010D95 RID: 69013 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010D95")]
			[Address(RVA = "0x89FC20", Offset = "0x89E820", VA = "0x18089FC20", Slot = "201")]
			public override List<GlobalEnvSystemData> GatherEnvSystems()
			{
				return null;
			}

			// Token: 0x17002512 RID: 9490
			// (get) Token: 0x06010D96 RID: 69014 RVA: 0x00067758 File Offset: 0x00065958
			[Token(Token = "0x17002512")]
			public override bool hasExtraBuildCondition
			{
				[Token(Token = "0x6010D96")]
				[Address(RVA = "0x8AD170", Offset = "0x8ABD70", VA = "0x1808AD170", Slot = "106")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06010D97 RID: 69015 RVA: 0x00067770 File Offset: 0x00065970
			[Token(Token = "0x6010D97")]
			[Address(RVA = "0x89D8A0", Offset = "0x89C4A0", VA = "0x18089D8A0", Slot = "152")]
			public override bool CheckBuildable(BuildCondition buildCondition, Tile tile, SharedConsts.Direction direction, bool spawnManually, bool overflowOccupiedCnt, BattleCharacterData sourceData, PlayerSide operationSide = PlayerSide.DEFAULT)
			{
				return default(bool);
			}

			// Token: 0x06010D98 RID: 69016 RVA: 0x00067788 File Offset: 0x00065988
			[Token(Token = "0x6010D98")]
			[Address(RVA = "0x89D7D0", Offset = "0x89C3D0", VA = "0x18089D7D0", Slot = "153")]
			public override bool AllowNoneBuildableType(BattleCharacterData sourceData)
			{
				return default(bool);
			}

			// Token: 0x06010D99 RID: 69017 RVA: 0x000677A0 File Offset: 0x000659A0
			[Token(Token = "0x6010D99")]
			[Address(RVA = "0x89E660", Offset = "0x89D260", VA = "0x18089E660", Slot = "176")]
			public override bool EnableGlobalBuffExtraData(GlobalBuff buff, LevelData.GlobalBuffData data)
			{
				return default(bool);
			}

			// Token: 0x06010D9A RID: 69018 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010D9A")]
			[Address(RVA = "0x8A0220", Offset = "0x89EE20", VA = "0x1808A0220", Slot = "183")]
			public override object GetActMeta()
			{
				return null;
			}

			// Token: 0x06010D9B RID: 69019 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D9B")]
			[Address(RVA = "0x8A2270", Offset = "0x8A0E70", VA = "0x1808A2270", Slot = "172")]
			public override void OnCardListChanged(Deck.Card card)
			{
			}

			// Token: 0x06010D9C RID: 69020 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D9C")]
			[Address(RVA = "0x8A38D0", Offset = "0x8A24D0", VA = "0x1808A38D0", Slot = "146")]
			public override void SortDeckRuntime(Deck.Card[] cards)
			{
			}

			// Token: 0x06010D9D RID: 69021 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D9D")]
			[Address(RVA = "0x8A3BA0", Offset = "0x8A27A0", VA = "0x1808A3BA0", Slot = "145")]
			public override void SortDeck(Deck.Card[] cards)
			{
			}

			// Token: 0x06010D9E RID: 69022 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010D9E")]
			[Address(RVA = "0x8A2730", Offset = "0x8A1330", VA = "0x1808A2730", Slot = "197")]
			public override void OnDestroy()
			{
			}

			// Token: 0x06010D9F RID: 69023 RVA: 0x000677B8 File Offset: 0x000659B8
			[Token(Token = "0x6010D9F")]
			[Address(RVA = "0x8A46F0", Offset = "0x8A32F0", VA = "0x1808A46F0", Slot = "194")]
			public override bool TrySetTileHighlightType(Tile tile, bool isBuildable, BattleCharacterData sourceData)
			{
				return default(bool);
			}

			// Token: 0x06010DA0 RID: 69024 RVA: 0x000677D0 File Offset: 0x000659D0
			[Token(Token = "0x6010DA0")]
			[Address(RVA = "0x8A4630", Offset = "0x8A3230", VA = "0x1808A4630", Slot = "195")]
			public override bool TryGetCustomTileHighlightColor(out Color customColor, out Color emissionColor)
			{
				return default(bool);
			}

			// Token: 0x06010DA1 RID: 69025 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DA1")]
			[Address(RVA = "0x8A2E60", Offset = "0x8A1A60", VA = "0x1808A2E60", Slot = "127")]
			public override void OnModifyLifePoint(ref Modifier modifier)
			{
			}

			// Token: 0x06010DA2 RID: 69026 RVA: 0x000677E8 File Offset: 0x000659E8
			[Token(Token = "0x6010DA2")]
			[Address(RVA = "0x8A06D0", Offset = "0x89F2D0", VA = "0x1808A06D0")]
			public Color GetEquipLevelColor(int level)
			{
				return default(Color);
			}

			// Token: 0x06010DA3 RID: 69027 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DA3")]
			[Address(RVA = "0x89E700", Offset = "0x89D300", VA = "0x18089E700")]
			public void FinishGame(bool isGiveUp = false)
			{
			}

			// Token: 0x06010DA4 RID: 69028 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DA4")]
			[Address(RVA = "0x8A3740", Offset = "0x8A2340", VA = "0x1808A3740")]
			public void SetBattlePanelInteractable(bool value)
			{
			}

			// Token: 0x06010DA5 RID: 69029 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DA5")]
			[Address(RVA = "0x8A3830", Offset = "0x8A2430", VA = "0x1808A3830")]
			public void SetResPanelShow(bool isShow)
			{
			}

			// Token: 0x06010DA6 RID: 69030 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DA6")]
			[Address(RVA = "0x8A3C60", Offset = "0x8A2860", VA = "0x1808A3C60")]
			public void SwitchCardListPage()
			{
			}

			// Token: 0x06010DA7 RID: 69031 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010DA7")]
			[Address(RVA = "0x89EBD0", Offset = "0x89D7D0", VA = "0x18089EBD0")]
			public List<Character> GainExp(Enemy enemy, List<Character> characters)
			{
				return null;
			}

			// Token: 0x06010DA8 RID: 69032 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DA8")]
			[Address(RVA = "0x89E480", Offset = "0x89D080", VA = "0x18089E480")]
			public void DropItemOnEnemyDead(string enemyDropPool, Entity source)
			{
			}

			// Token: 0x06010DA9 RID: 69033 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DA9")]
			[Address(RVA = "0x89E9F0", Offset = "0x89D5F0", VA = "0x18089E9F0")]
			public void GainEquip(string equipPool, Entity source)
			{
			}

			// Token: 0x06010DAA RID: 69034 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DAA")]
			[Address(RVA = "0x89E7D0", Offset = "0x89D3D0", VA = "0x18089E7D0")]
			public void GainEquipByAlias(string equipId, int level, string alias, Entity source)
			{
			}

			// Token: 0x06010DAB RID: 69035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DAB")]
			[Address(RVA = "0x89F930", Offset = "0x89E530", VA = "0x18089F930")]
			public void GainTrap(string trapPool, Entity source)
			{
			}

			// Token: 0x06010DAC RID: 69036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DAC")]
			[Address(RVA = "0x89F490", Offset = "0x89E090", VA = "0x18089F490")]
			public void GainTrapById(string trapKey, Entity source, int cnt = 1)
			{
			}

			// Token: 0x06010DAD RID: 69037 RVA: 0x00067800 File Offset: 0x00065A00
			[Token(Token = "0x6010DAD")]
			[Address(RVA = "0x8A4130", Offset = "0x8A2D30", VA = "0x1808A4130")]
			public bool TryGainResourcesFromPool(string poolKey, int num, [Optional] Entity source)
			{
				return default(bool);
			}

			// Token: 0x06010DAE RID: 69038 RVA: 0x00067818 File Offset: 0x00065A18
			[Token(Token = "0x6010DAE")]
			[Address(RVA = "0x8A4520", Offset = "0x8A3120", VA = "0x1808A4520")]
			public bool TryGetCurResourceNum(string resourceId, out int num)
			{
				return default(bool);
			}

			// Token: 0x06010DAF RID: 69039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DAF")]
			[Address(RVA = "0x8A2070", Offset = "0x8A0C70", VA = "0x1808A2070")]
			public void ModifyEnemyCapacity(Entity entity, int levelCapacity, bool isAdd)
			{
			}

			// Token: 0x06010DB0 RID: 69040 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DB0")]
			[Address(RVA = "0x89D6B0", Offset = "0x89C2B0", VA = "0x18089D6B0")]
			public void AddEnemyCapacityWhiteList(Enemy enemy)
			{
			}

			// Token: 0x06010DB1 RID: 69041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DB1")]
			[Address(RVA = "0x8A3620", Offset = "0x8A2220", VA = "0x1808A3620")]
			public void RemoveEnemyCapacityWhiteList(Enemy enemy)
			{
			}

			// Token: 0x06010DB2 RID: 69042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DB2")]
			[Address(RVA = "0x8A41F0", Offset = "0x8A2DF0", VA = "0x1808A41F0")]
			public void TryGetBattleItem(string poolKey, Entity source)
			{
			}

			// Token: 0x06010DB3 RID: 69043 RVA: 0x00067830 File Offset: 0x00065A30
			[Token(Token = "0x6010DB3")]
			[Address(RVA = "0x8A1E00", Offset = "0x8A0A00", VA = "0x1808A1E00")]
			public bool InsertNumericFactor(GameModeFactory.HalfIdleGameMode.NumericInfectFactor.NumericInfectFactorCreateInfo nfci)
			{
				return default(bool);
			}

			// Token: 0x06010DB4 RID: 69044 RVA: 0x00067848 File Offset: 0x00065A48
			[Token(Token = "0x6010DB4")]
			[Address(RVA = "0x8A1260", Offset = "0x89FE60", VA = "0x1808A1260")]
			public bool InactiveNumericFactor(GameModeFactory.HalfIdleGameMode.NumericInfectFactor.NumericInfectFactorCreateInfo nfci)
			{
				return default(bool);
			}

			// Token: 0x06010DB5 RID: 69045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DB5")]
			[Address(RVA = "0x8A4CB0", Offset = "0x8A38B0", VA = "0x1808A4CB0")]
			public void UpgradeRandomEquip()
			{
			}

			// Token: 0x06010DB6 RID: 69046 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DB6")]
			[Address(RVA = "0x8A9910", Offset = "0x8A8510", VA = "0x1808A9910")]
			private void _ResumeLevelBgm()
			{
			}

			// Token: 0x06010DB7 RID: 69047 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DB7")]
			[Address(RVA = "0x8AB7B0", Offset = "0x8AA3B0", VA = "0x1808AB7B0")]
			private void _UpdateLevelCapacity()
			{
			}

			// Token: 0x06010DB8 RID: 69048 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DB8")]
			[Address(RVA = "0x8ABEC0", Offset = "0x8AAAC0", VA = "0x1808ABEC0")]
			private void _UpdateOverloadWarning()
			{
			}

			// Token: 0x06010DB9 RID: 69049 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DB9")]
			[Address(RVA = "0x8A9700", Offset = "0x8A8300", VA = "0x1808A9700")]
			private void _RefreshTrapCardGainDict(Deck deck)
			{
			}

			// Token: 0x06010DBA RID: 69050 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DBA")]
			[Address(RVA = "0x8A9380", Offset = "0x8A7F80", VA = "0x1808A9380")]
			private void _RefreshCurrentCardPage(Deck deck)
			{
			}

			// Token: 0x06010DBB RID: 69051 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DBB")]
			[Address(RVA = "0x8A9520", Offset = "0x8A8120", VA = "0x1808A9520")]
			private void _RefreshMaxCardNum(Deck deck)
			{
			}

			// Token: 0x06010DBC RID: 69052 RVA: 0x00067860 File Offset: 0x00065A60
			[Token(Token = "0x6010DBC")]
			[Address(RVA = "0x8A5B30", Offset = "0x8A4730", VA = "0x1808A5B30")]
			private bool _CheckCardInCurrentPage(int cardIndex, int pageIndex)
			{
				return default(bool);
			}

			// Token: 0x06010DBD RID: 69053 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DBD")]
			[Address(RVA = "0x8A9050", Offset = "0x8A7C50", VA = "0x1808A9050")]
			private void _ParsePreloadEnemy(LevelData levelData)
			{
			}

			// Token: 0x06010DBE RID: 69054 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DBE")]
			[Address(RVA = "0x8A5690", Offset = "0x8A4290", VA = "0x1808A5690")]
			private void _BindBattleEvents()
			{
			}

			// Token: 0x06010DBF RID: 69055 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DBF")]
			[Address(RVA = "0x8AB650", Offset = "0x8AA250", VA = "0x1808AB650")]
			private void _UnbindBattleEvents()
			{
			}

			// Token: 0x06010DC0 RID: 69056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DC0")]
			[Address(RVA = "0x8A8610", Offset = "0x8A7210", VA = "0x1808A8610")]
			private void _InitEquipLevelColors()
			{
			}

			// Token: 0x06010DC1 RID: 69057 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DC1")]
			[Address(RVA = "0x8A9220", Offset = "0x8A7E20", VA = "0x1808A9220")]
			private void _ParsePreloadTraps(BattlePlayerData playerData)
			{
			}

			// Token: 0x06010DC2 RID: 69058 RVA: 0x00067878 File Offset: 0x00065A78
			[Token(Token = "0x6010DC2")]
			[Address(RVA = "0x8A63A0", Offset = "0x8A4FA0", VA = "0x1808A63A0")]
			private bool _CheckTileExcludedBuildable(Tile tile)
			{
				return default(bool);
			}

			// Token: 0x06010DC3 RID: 69059 RVA: 0x00067890 File Offset: 0x00065A90
			[Token(Token = "0x6010DC3")]
			[Address(RVA = "0x8A5EB0", Offset = "0x8A4AB0", VA = "0x1808A5EB0")]
			private bool _CheckSpecialBuildCondition(BuildCondition buildCondition, Tile tile, SharedConsts.Direction direction, bool spawnManually, bool overflowOccupiedCnt, BattleCharacterData sourceData, Act1VHalfIdleTrapMeta trapMeta, PlayerSide operationSide = PlayerSide.DEFAULT)
			{
				return default(bool);
			}

			// Token: 0x06010DC4 RID: 69060 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DC4")]
			[Address(RVA = "0x8A8380", Offset = "0x8A6F80", VA = "0x1808A8380")]
			private void _InitCharacterExpDict()
			{
			}

			// Token: 0x06010DC5 RID: 69061 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DC5")]
			[Address(RVA = "0x8A7E30", Offset = "0x8A6A30", VA = "0x1808A7E30")]
			private void _InitByLevelConfig(Blackboard blackboard)
			{
			}

			// Token: 0x06010DC6 RID: 69062 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DC6")]
			[Address(RVA = "0x8A87D0", Offset = "0x8A73D0", VA = "0x1808A87D0")]
			private void _InitResourceNumDict()
			{
			}

			// Token: 0x06010DC7 RID: 69063 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DC7")]
			[Address(RVA = "0x8A8990", Offset = "0x8A7590", VA = "0x1808A8990")]
			private void _InitTrapItemPool()
			{
			}

			// Token: 0x06010DC8 RID: 69064 RVA: 0x000678A8 File Offset: 0x00065AA8
			[Token(Token = "0x6010DC8")]
			[Address(RVA = "0x8AAB20", Offset = "0x8A9720", VA = "0x1808AAB20")]
			private bool _TryGetItemPool(Act1VBattleItemDropSlot slot, out Act1VWeightedBattleItemPool itemPool)
			{
				return default(bool);
			}

			// Token: 0x06010DC9 RID: 69065 RVA: 0x000678C0 File Offset: 0x00065AC0
			[Token(Token = "0x6010DC9")]
			[Address(RVA = "0x8AB010", Offset = "0x8A9C10", VA = "0x1808AB010")]
			private bool _TryGetTrapFromPool(string poolKey, out string trapKey)
			{
				return default(bool);
			}

			// Token: 0x06010DCA RID: 69066 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DCA")]
			[Address(RVA = "0x8AC070", Offset = "0x8AAC70", VA = "0x1808AC070")]
			private void _UpdateTrapDropWeight(List<HalfIdleWeightedBattleTrap> trapPool, string trapKey)
			{
			}

			// Token: 0x06010DCB RID: 69067 RVA: 0x000678D8 File Offset: 0x00065AD8
			[Token(Token = "0x6010DCB")]
			[Address(RVA = "0x8AADE0", Offset = "0x8A99E0", VA = "0x1808AADE0")]
			private bool _TryGetResourcesFromPool(string poolKey, Entity source)
			{
				return default(bool);
			}

			// Token: 0x06010DCC RID: 69068 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DCC")]
			[Address(RVA = "0x8AACF0", Offset = "0x8A98F0", VA = "0x1808AACF0")]
			private void _TryGetMileStone(int cnt, Entity source)
			{
			}

			// Token: 0x06010DCD RID: 69069 RVA: 0x000678F0 File Offset: 0x00065AF0
			[Token(Token = "0x6010DCD")]
			[Address(RVA = "0x8A6BF0", Offset = "0x8A57F0", VA = "0x1808A6BF0")]
			private GameModeFactory.HalfIdleGameMode.NumericInfectFactor.ValidSourceType _ConvertEntityToFactorSourceType(Entity source)
			{
				return GameModeFactory.HalfIdleGameMode.NumericInfectFactor.ValidSourceType.NONE;
			}

			// Token: 0x06010DCE RID: 69070 RVA: 0x00067908 File Offset: 0x00065B08
			[Token(Token = "0x6010DCE")]
			[Address(RVA = "0x8AA510", Offset = "0x8A9110", VA = "0x1808AA510")]
			private bool _TryGainResource(string resourceId, int num, Entity source)
			{
				return default(bool);
			}

			// Token: 0x06010DCF RID: 69071 RVA: 0x00067920 File Offset: 0x00065B20
			[Token(Token = "0x6010DCF")]
			[Address(RVA = "0x8A5C60", Offset = "0x8A4860", VA = "0x1808A5C60")]
			private bool _CheckMlyssWtrmanNeedAttributeUpdate(Character character)
			{
				return default(bool);
			}

			// Token: 0x06010DD0 RID: 69072 RVA: 0x00067938 File Offset: 0x00065B38
			[Token(Token = "0x6010DD0")]
			[Address(RVA = "0x8A76D0", Offset = "0x8A62D0", VA = "0x1808A76D0")]
			private int _GetEnemyExpValue(string enemyId)
			{
				return 0;
			}

			// Token: 0x06010DD1 RID: 69073 RVA: 0x00067950 File Offset: 0x00065B50
			[Token(Token = "0x6010DD1")]
			[Address(RVA = "0x8A9860", Offset = "0x8A8460", VA = "0x1808A9860")]
			private GameModeFactory.HalfIdleGameMode.NumericInfectFactor.AffectType _ResourceIdToAffectType(string resourceId)
			{
				return GameModeFactory.HalfIdleGameMode.NumericInfectFactor.AffectType.None;
			}

			// Token: 0x06010DD2 RID: 69074 RVA: 0x00067968 File Offset: 0x00065B68
			[Token(Token = "0x6010DD2")]
			[Address(RVA = "0x8A5E00", Offset = "0x8A4A00", VA = "0x1808A5E00")]
			private bool _CheckNumericInfectFactorValidSourceType(GameModeFactory.HalfIdleGameMode.NumericInfectFactor.ValidSourceType targetType, GameModeFactory.HalfIdleGameMode.NumericInfectFactor.ValidSourceType validType)
			{
				return default(bool);
			}

			// Token: 0x06010DD3 RID: 69075 RVA: 0x00067980 File Offset: 0x00065B80
			[Token(Token = "0x6010DD3")]
			[Address(RVA = "0x8A5840", Offset = "0x8A4440", VA = "0x1808A5840")]
			private int _CalculateFinalValue(float rawValue, GameModeFactory.HalfIdleGameMode.NumericInfectFactor.AffectType affectType, GameModeFactory.HalfIdleGameMode.NumericInfectFactor.ValidSourceType validSourceType)
			{
				return 0;
			}

			// Token: 0x06010DD4 RID: 69076 RVA: 0x00067998 File Offset: 0x00065B98
			[Token(Token = "0x6010DD4")]
			[Address(RVA = "0x8A4F50", Offset = "0x8A3B50", VA = "0x1808A4F50")]
			private bool _AddExpToCharacter(Character character, int addExp)
			{
				return default(bool);
			}

			// Token: 0x06010DD5 RID: 69077 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DD5")]
			[Address(RVA = "0x8A8E90", Offset = "0x8A7A90", VA = "0x1808A8E90")]
			private void _LevelUpCharacter(Deck.Card card)
			{
			}

			// Token: 0x06010DD6 RID: 69078 RVA: 0x000679B0 File Offset: 0x00065BB0
			[Token(Token = "0x6010DD6")]
			[Address(RVA = "0x8A9DC0", Offset = "0x8A89C0", VA = "0x1808A9DC0")]
			private bool _TimeIsUp()
			{
				return default(bool);
			}

			// Token: 0x06010DD7 RID: 69079 RVA: 0x000679C8 File Offset: 0x00065BC8
			[Token(Token = "0x6010DD7")]
			[Address(RVA = "0x8A77A0", Offset = "0x8A63A0", VA = "0x1808A77A0")]
			private int _GetEnemyLevelCapacity(EnemyLevelType enemyLevelType)
			{
				return 0;
			}

			// Token: 0x06010DD8 RID: 69080 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DD8")]
			[Address(RVA = "0x8A54F0", Offset = "0x8A40F0", VA = "0x1808A54F0")]
			private void _AdvanceBossBranchTriggerTime(Deck.Card card, bool spawnManually)
			{
			}

			// Token: 0x06010DD9 RID: 69081 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DD9")]
			[Address(RVA = "0x8AB1E0", Offset = "0x8A9DE0", VA = "0x1808AB1E0")]
			private void _TryTriggerBossBranch()
			{
			}

			// Token: 0x06010DDA RID: 69082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DDA")]
			[Address(RVA = "0x8AA020", Offset = "0x8A8C20", VA = "0x1808AA020")]
			private void _TriggerBossBranchPreview()
			{
			}

			// Token: 0x06010DDB RID: 69083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DDB")]
			[Address(RVA = "0x8AB490", Offset = "0x8AA090", VA = "0x1808AB490")]
			private void _TryWarningEnemyRush()
			{
			}

			// Token: 0x06010DDC RID: 69084 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DDC")]
			[Address(RVA = "0x8ABC50", Offset = "0x8AA850", VA = "0x1808ABC50")]
			private void _UpdateLifePointTimer(FP deltaTime)
			{
			}

			// Token: 0x06010DDD RID: 69085 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DDD")]
			[Address(RVA = "0x8AA8F0", Offset = "0x8A94F0", VA = "0x1808AA8F0")]
			private static void _TryGatherTempCharacters(List<BattleCharacterData> tokenList)
			{
			}

			// Token: 0x06010DDE RID: 69086 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DDE")]
			[Address(RVA = "0x8A6D90", Offset = "0x8A5990", VA = "0x1808A6D90")]
			private static void _GatherExBattleTraps()
			{
			}

			// Token: 0x06010DDF RID: 69087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DDF")]
			[Address(RVA = "0x8A9A40", Offset = "0x8A8640", VA = "0x1808A9A40")]
			private void _SetEquipPanelUnfolded(object arg)
			{
			}

			// Token: 0x06010DE0 RID: 69088 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DE0")]
			[Address(RVA = "0x8A9F70", Offset = "0x8A8B70", VA = "0x1808A9F70")]
			private void _ToggleEquipAutoUpgradeOn(object arg)
			{
			}

			// Token: 0x06010DE1 RID: 69089 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DE1")]
			[Address(RVA = "0x8A9BB0", Offset = "0x8A87B0", VA = "0x1808A9BB0")]
			private void _SetResPanelShowManually(object arg)
			{
			}

			// Token: 0x06010DE2 RID: 69090 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DE2")]
			[Address(RVA = "0x8AC580", Offset = "0x8AB180", VA = "0x1808AC580")]
			private void _WearEquip(object arg)
			{
			}

			// Token: 0x06010DE3 RID: 69091 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010DE3")]
			[Address(RVA = "0x8A07C0", Offset = "0x89F3C0", VA = "0x1808A07C0")]
			public GameModeFactory.HalfIdleGameMode.HalfIdleRouteInfo HalfIdleGetRouteInfo(GridPosition gridPosition)
			{
				return null;
			}

			// Token: 0x06010DE4 RID: 69092 RVA: 0x000679E0 File Offset: 0x00065BE0
			[Token(Token = "0x6010DE4")]
			[Address(RVA = "0x8A1170", Offset = "0x89FD70", VA = "0x1808A1170")]
			public static GameModeFactory.HalfIdleGameMode.HalfIdleRangeIdType HalfIdleStringToRangeType(string rangeId)
			{
				return GameModeFactory.HalfIdleGameMode.HalfIdleRangeIdType.None;
			}

			// Token: 0x06010DE5 RID: 69093 RVA: 0x000679F8 File Offset: 0x00065BF8
			[Token(Token = "0x6010DE5")]
			[Address(RVA = "0x8A0DB0", Offset = "0x89F9B0", VA = "0x1808A0DB0")]
			public bool HalfIdleSpawnEnemyInRange(string rangeId, string overrideEnemyKey, GridPosition anchorPos, MotionMode motionMode, bool unharmful, bool alwaysCountAsKilled, bool isSummon, bool managedByScheduler, bool disableBornTweenColor, BuffData buffToEnemy, Blackboard buffBlackboard, [Optional] Entity buffSource, [Optional] Ability sourceAbility)
			{
				return default(bool);
			}

			// Token: 0x06010DE6 RID: 69094 RVA: 0x00067A10 File Offset: 0x00065C10
			[Token(Token = "0x6010DE6")]
			[Address(RVA = "0x8A78A0", Offset = "0x8A64A0", VA = "0x1808A78A0")]
			private bool _HalfIdleCheckTileAbleToSummonEnemy(Tile tile, MotionMode motionMode)
			{
				return default(bool);
			}

			// Token: 0x06010DE7 RID: 69095 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010DE7")]
			[Address(RVA = "0x8A0930", Offset = "0x89F530", VA = "0x1808A0930")]
			public Enemy HalfIdleSpawnEnemyAtCertainPosition(string overrideEnemyKey, GridPosition startPos, MotionMode motionMode, bool unharmful, bool alwaysCountAsKilled, bool isSummon, bool managedByScheduler, bool disableBornTweenColor, BuffData buffToEnemy, Blackboard buffBlackboard, [Optional] Entity buffSource, [Optional] Ability sourceAbility)
			{
				return null;
			}

			// Token: 0x06010DE8 RID: 69096 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DE8")]
			[Address(RVA = "0x8A6920", Offset = "0x8A5520", VA = "0x1808A6920")]
			private void _ConstructMapPosToRouteInfoDict()
			{
			}

			// Token: 0x06010DE9 RID: 69097 RVA: 0x00067A28 File Offset: 0x00065C28
			[Token(Token = "0x6010DE9")]
			[Address(RVA = "0x8AC460", Offset = "0x8AB060", VA = "0x1808AC460")]
			private bool _ValidateTileBeingAddedToMapPosDict(Tile tile)
			{
				return default(bool);
			}

			// Token: 0x06010DEA RID: 69098 RVA: 0x00067A40 File Offset: 0x00065C40
			[Token(Token = "0x6010DEA")]
			[Address(RVA = "0x8A6490", Offset = "0x8A5090", VA = "0x1808A6490")]
			private bool _ComputeRouteInfo(GridPosition gridPosition, GameModeFactory.HalfIdleGameMode.HalfIdleRouteInfo routeCheckPointInfo)
			{
				return default(bool);
			}

			// Token: 0x06010DEB RID: 69099 RVA: 0x00067A58 File Offset: 0x00065C58
			[Token(Token = "0x6010DEB")]
			[Address(RVA = "0x89E200", Offset = "0x89CE00", VA = "0x18089E200")]
			public bool CheckNearByRoad(string rangeId, GridPosition anchorPos)
			{
				return default(bool);
			}

			// Token: 0x06010DEC RID: 69100 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DEC")]
			[Address(RVA = "0x8A7980", Offset = "0x8A6580", VA = "0x1808A7980")]
			private void _HalfIdleUpdateSTilesByRangeId(string rangeId, GridPosition anchorPos)
			{
			}

			// Token: 0x06010DED RID: 69101 RVA: 0x00067A70 File Offset: 0x00065C70
			[Token(Token = "0x6010DED")]
			[Address(RVA = "0x8A4D40", Offset = "0x8A3940", VA = "0x1808A4D40")]
			public bool UpgradeTrap(Trap trapHadle, GameModeFactory.HalfIdleGameMode.HalfIdleTrapUpgradeMsg msg)
			{
				return default(bool);
			}

			// Token: 0x06010DEE RID: 69102 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DEE")]
			[Address(RVA = "0x8A08B0", Offset = "0x89F4B0", VA = "0x1808A08B0")]
			public void HalfIdleNotifyTrapUpgrade()
			{
			}

			// Token: 0x06010DEF RID: 69103 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DEF")]
			[Address(RVA = "0x8AA220", Offset = "0x8A8E20", VA = "0x1808AA220")]
			private void _TriggerTrapUpgradeCheck()
			{
			}

			// Token: 0x06010DF2 RID: 69106 RVA: 0x00067AA0 File Offset: 0x00065CA0
			[Token(Token = "0x6010DF2")]
			[Address(RVA = "0x88F1C0", Offset = "0x88DDC0", VA = "0x18088F1C0")]
			private GameModeMeta.GameModeType <>xLuaBaseProxy_get_gameModeType()
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}

			// Token: 0x06010DF3 RID: 69107 RVA: 0x00067AB8 File Offset: 0x00065CB8
			[Token(Token = "0x6010DF3")]
			[Address(RVA = "0x88F100", Offset = "0x88DD00", VA = "0x18088F100")]
			private bool <>xLuaBaseProxy_get_enableParticleEffectManager()
			{
				return default(bool);
			}

			// Token: 0x06010DF4 RID: 69108 RVA: 0x00067AD0 File Offset: 0x00065CD0
			[Token(Token = "0x6010DF4")]
			[Address(RVA = "0x88F0A0", Offset = "0x88DCA0", VA = "0x18088F0A0")]
			private bool <>xLuaBaseProxy_get_enableHudSlowTicker()
			{
				return default(bool);
			}

			// Token: 0x06010DF5 RID: 69109 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DF5")]
			[Address(RVA = "0x83EA80", Offset = "0x83D680", VA = "0x18083EA80")]
			private void <>xLuaBaseProxy_Init(ref GameModeMeta P0, ref int P1, BattlePlayerData P2, LevelData P3)
			{
			}

			// Token: 0x06010DF6 RID: 69110 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DF6")]
			[Address(RVA = "0x88E090", Offset = "0x88CC90", VA = "0x18088E090")]
			private void <>xLuaBaseProxy_OnPostInit()
			{
			}

			// Token: 0x06010DF7 RID: 69111 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DF7")]
			[Address(RVA = "0x88DDB0", Offset = "0x88C9B0", VA = "0x18088DDB0")]
			private void <>xLuaBaseProxy_OnEnemyReachExit(Enemy P0, Tile P1)
			{
			}

			// Token: 0x06010DF8 RID: 69112 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DF8")]
			[Address(RVA = "0x88EB00", Offset = "0x88D700", VA = "0x18088EB00")]
			private void <>xLuaBaseProxy_Tick(Action P0)
			{
			}

			// Token: 0x06010DF9 RID: 69113 RVA: 0x00067AE8 File Offset: 0x00065CE8
			[Token(Token = "0x6010DF9")]
			[Address(RVA = "0x88CB70", Offset = "0x88B770", VA = "0x18088CB70")]
			private bool <>xLuaBaseProxy_GameNotFinishCondition()
			{
				return default(bool);
			}

			// Token: 0x06010DFA RID: 69114 RVA: 0x00067B00 File Offset: 0x00065D00
			[Token(Token = "0x6010DFA")]
			[Address(RVA = "0x858C40", Offset = "0x857840", VA = "0x180858C40")]
			private PlayerBattleRank <>xLuaBaseProxy_GetBattleCompleteRank()
			{
				return (PlayerBattleRank)0;
			}

			// Token: 0x06010DFB RID: 69115 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DFB")]
			[Address(RVA = "0x88DFE0", Offset = "0x88CBE0", VA = "0x18088DFE0")]
			private void <>xLuaBaseProxy_OnPlayerLifeToZero(PlayerSide P0)
			{
			}

			// Token: 0x06010DFC RID: 69116 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DFC")]
			[Address(RVA = "0x88D9D0", Offset = "0x88C5D0", VA = "0x18088D9D0")]
			private void <>xLuaBaseProxy_OnCardSpawned(Deck.Card P0, bool P1)
			{
			}

			// Token: 0x06010DFD RID: 69117 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DFD")]
			[Address(RVA = "0x840A90", Offset = "0x83F690", VA = "0x180840A90")]
			private void <>xLuaBaseProxy_OnUnitRegistered(Unit P0)
			{
			}

			// Token: 0x06010DFE RID: 69118 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010DFE")]
			[Address(RVA = "0x88DD30", Offset = "0x88C930", VA = "0x18088DD30")]
			private void <>xLuaBaseProxy_OnEnemyFinished(Enemy P0, Entity.FinishReason P1)
			{
			}

			// Token: 0x06010DFF RID: 69119 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010DFF")]
			[Address(RVA = "0x88CBD0", Offset = "0x88B7D0", VA = "0x18088CBD0")]
			private List<GlobalEnvSystemData> <>xLuaBaseProxy_GatherEnvSystems()
			{
				return null;
			}

			// Token: 0x06010E00 RID: 69120 RVA: 0x00067B18 File Offset: 0x00065D18
			[Token(Token = "0x6010E00")]
			[Address(RVA = "0x88F220", Offset = "0x88DE20", VA = "0x18088F220")]
			private bool <>xLuaBaseProxy_get_hasExtraBuildCondition()
			{
				return default(bool);
			}

			// Token: 0x06010E01 RID: 69121 RVA: 0x00067B30 File Offset: 0x00065D30
			[Token(Token = "0x6010E01")]
			[Address(RVA = "0x85AAD0", Offset = "0x8596D0", VA = "0x18085AAD0")]
			private bool <>xLuaBaseProxy_CheckBuildable(BuildCondition P0, Tile P1, SharedConsts.Direction P2, bool P3, bool P4, BattleCharacterData P5, PlayerSide P6)
			{
				return default(bool);
			}

			// Token: 0x06010E02 RID: 69122 RVA: 0x00067B48 File Offset: 0x00065D48
			[Token(Token = "0x6010E02")]
			[Address(RVA = "0x88C160", Offset = "0x88AD60", VA = "0x18088C160")]
			private bool <>xLuaBaseProxy_AllowNoneBuildableType(BattleCharacterData P0)
			{
				return default(bool);
			}

			// Token: 0x06010E03 RID: 69123 RVA: 0x00067B60 File Offset: 0x00065D60
			[Token(Token = "0x6010E03")]
			[Address(RVA = "0x88C930", Offset = "0x88B530", VA = "0x18088C930")]
			private bool <>xLuaBaseProxy_EnableGlobalBuffExtraData(GlobalBuff P0, LevelData.GlobalBuffData P1)
			{
				return default(bool);
			}

			// Token: 0x06010E04 RID: 69124 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010E04")]
			[Address(RVA = "0x88CC90", Offset = "0x88B890", VA = "0x18088CC90")]
			private object <>xLuaBaseProxy_GetActMeta()
			{
				return null;
			}

			// Token: 0x06010E05 RID: 69125 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E05")]
			[Address(RVA = "0x88D910", Offset = "0x88C510", VA = "0x18088D910")]
			private void <>xLuaBaseProxy_OnCardListChanged(Deck.Card P0)
			{
			}

			// Token: 0x06010E06 RID: 69126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E06")]
			[Address(RVA = "0x88E8B0", Offset = "0x88D4B0", VA = "0x18088E8B0")]
			private void <>xLuaBaseProxy_SortDeckRuntime(Deck.Card[] P0)
			{
			}

			// Token: 0x06010E07 RID: 69127 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E07")]
			[Address(RVA = "0x858CC0", Offset = "0x8578C0", VA = "0x180858CC0")]
			private void <>xLuaBaseProxy_SortDeck(Deck.Card[] P0)
			{
			}

			// Token: 0x06010E08 RID: 69128 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E08")]
			[Address(RVA = "0x88DBB0", Offset = "0x88C7B0", VA = "0x18088DBB0")]
			private void <>xLuaBaseProxy_OnDestroy()
			{
			}

			// Token: 0x06010E09 RID: 69129 RVA: 0x00067B78 File Offset: 0x00065D78
			[Token(Token = "0x6010E09")]
			[Address(RVA = "0x85AC00", Offset = "0x859800", VA = "0x18085AC00")]
			private bool <>xLuaBaseProxy_TrySetTileHighlightType(Tile P0, bool P1, BattleCharacterData P2)
			{
				return default(bool);
			}

			// Token: 0x06010E0A RID: 69130 RVA: 0x00067B90 File Offset: 0x00065D90
			[Token(Token = "0x6010E0A")]
			[Address(RVA = "0x88EB90", Offset = "0x88D790", VA = "0x18088EB90")]
			private bool <>xLuaBaseProxy_TryGetCustomTileHighlightColor(out Color P0, out Color P1)
			{
				return default(bool);
			}

			// Token: 0x06010E0B RID: 69131 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E0B")]
			[Address(RVA = "0x88DF80", Offset = "0x88CB80", VA = "0x18088DF80")]
			private void <>xLuaBaseProxy_OnModifyLifePoint(ref Modifier P0)
			{
			}

			// Token: 0x04012E0F RID: 77327
			[Token(Token = "0x4012E0F")]
			private const SlowMotionReason OPEN_EQUIP_PANEL = SlowMotionReason.CUSTOM_1;

			// Token: 0x04012E10 RID: 77328
			[Token(Token = "0x4012E10")]
			private const string LHMINE_TAG = "lhmine";

			// Token: 0x04012E11 RID: 77329
			[Token(Token = "0x4012E11")]
			private const string LHUKMI_TAG = "LHUKMI";

			// Token: 0x04012E12 RID: 77330
			[Token(Token = "0x4012E12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_maxEnemyCapacity;

			// Token: 0x04012E13 RID: 77331
			[Token(Token = "0x4012E13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int m_occupiedEnemyCapacity;

			// Token: 0x04012E14 RID: 77332
			[Token(Token = "0x4012E14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private PeriodicTimer m_enemyOverloadAlertTimer;

			// Token: 0x04012E15 RID: 77333
			[Token(Token = "0x4012E15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private FP m_bossBranchTriggerTime;

			// Token: 0x04012E16 RID: 77334
			[Token(Token = "0x4012E16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool m_hasTriggeredBossBranch;

			// Token: 0x04012E17 RID: 77335
			[Token(Token = "0x4012E17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private FP m_maxPlayTime;

			// Token: 0x04012E18 RID: 77336
			[Token(Token = "0x4012E18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ObjectPtr<Enemy> m_boss;

			// Token: 0x04012E19 RID: 77337
			[Token(Token = "0x4012E19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private bool m_bossKilled;

			// Token: 0x04012E1A RID: 77338
			[Token(Token = "0x4012E1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private HalfIdleInput m_input;

			// Token: 0x04012E1B RID: 77339
			[Token(Token = "0x4012E1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private HalfIdleOutput m_output;

			// Token: 0x04012E1C RID: 77340
			[Token(Token = "0x4012E1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool m_hasCharacterLevelUp;

			// Token: 0x04012E1D RID: 77341
			[Token(Token = "0x4012E1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private ListDict<string, int[]> m_resourceCountDict;

			// Token: 0x04012E1E RID: 77342
			[Token(Token = "0x4012E1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private Dictionary<uint, HalfIdleCharacterExpData> m_characterExpDict;

			// Token: 0x04012E1F RID: 77343
			[Token(Token = "0x4012E1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private HalfIdleBattleEquipManager m_equipManager;

			// Token: 0x04012E20 RID: 77344
			[Token(Token = "0x4012E20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private EventPool<HalfIdleBattleData.HalfIdleBattleEvent> m_eventPool;

			// Token: 0x04012E21 RID: 77345
			[Token(Token = "0x4012E21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private int m_curDeckPageIndex;

			// Token: 0x04012E22 RID: 77346
			[Token(Token = "0x4012E22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private int m_maxDeckPageNum;

			// Token: 0x04012E23 RID: 77347
			[Token(Token = "0x4012E23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Act1VHalfIdleConstData m_constData;

			// Token: 0x04012E24 RID: 77348
			[Token(Token = "0x4012E24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Color m_customTileHighlightColor;

			// Token: 0x04012E25 RID: 77349
			[Token(Token = "0x4012E25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private Color m_customTileEmissionHighlightColor;

			// Token: 0x04012E26 RID: 77350
			[Token(Token = "0x4012E26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private List<Color> m_equipLevelColors;

			// Token: 0x04012E27 RID: 77351
			[Token(Token = "0x4012E27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private Dictionary<ObjectPtr<Entity>, int> m_levelCapacityDict;

			// Token: 0x04012E28 RID: 77352
			[Token(Token = "0x4012E28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private List<Entity> m_enemyCapacityWhiteList;

			// Token: 0x04012E29 RID: 77353
			[Token(Token = "0x4012E29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private bool m_isLevelCapacityDictDirty;

			// Token: 0x04012E2A RID: 77354
			[Token(Token = "0x4012E2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private Dictionary<string, List<HalfIdleWeightedBattleTrap>> m_trapItemPoolDict;

			// Token: 0x04012E2B RID: 77355
			[Token(Token = "0x4012E2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private ListDict<uint, FP> m_trapCardGainTimeDict;

			// Token: 0x04012E2C RID: 77356
			[Token(Token = "0x4012E2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private List<uint> m_trapCardNewAdded;

			// Token: 0x04012E2D RID: 77357
			[Token(Token = "0x4012E2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			private bool m_isEnemyOverloadWarning;

			// Token: 0x04012E2E RID: 77358
			[Token(Token = "0x4012E2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
			private bool m_isEnemyOverloading;

			// Token: 0x04012E2F RID: 77359
			[Token(Token = "0x4012E2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private List<FP> m_enemyRushTimeList;

			// Token: 0x04012E30 RID: 77360
			[Token(Token = "0x4012E30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private FP m_battleFinishWarningTime;

			// Token: 0x04012E31 RID: 77361
			[Token(Token = "0x4012E31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private int m_enemyOverloadWarningCnt;

			// Token: 0x04012E32 RID: 77362
			[Token(Token = "0x4012E32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			private bool m_isResourcePanelShowManually;

			// Token: 0x04012E33 RID: 77363
			[Token(Token = "0x4012E33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11D")]
			private bool m_isResourcePanelShow;

			// Token: 0x04012E34 RID: 77364
			[Token(Token = "0x4012E34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11E")]
			private bool m_isEquipPanelUnfolded;

			// Token: 0x04012E35 RID: 77365
			[Token(Token = "0x4012E35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11F")]
			private bool m_isBattlePanelInteractable;

			// Token: 0x04012E36 RID: 77366
			[Token(Token = "0x4012E36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Act1VHalfIdleEquipType m_selectedEquipType;

			// Token: 0x04012E37 RID: 77367
			[Token(Token = "0x4012E37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private List<GameModeFactory.HalfIdleGameMode.NumericInfectFactor> m_infectFactorList;

			// Token: 0x04012E38 RID: 77368
			[Token(Token = "0x4012E38")]
			private const int MAX_DISTANCE = 1000000;

			// Token: 0x04012E39 RID: 77369
			[Token(Token = "0x4012E39")]
			private const string TILE_MARK_NOT_SUMMON = "tile_not_summon";

			// Token: 0x04012E3A RID: 77370
			[Token(Token = "0x4012E3A")]
			private const float DEFAULT_WAIT_TIME = 1f;

			// Token: 0x04012E3B RID: 77371
			[Token(Token = "0x4012E3B")]
			private const float DEFAULT_OFFSET = 0.1f;

			// Token: 0x04012E3C RID: 77372
			[Token(Token = "0x4012E3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static List<Tile> s_sharedTiles;

			// Token: 0x04012E3D RID: 77373
			[Token(Token = "0x4012E3D")]
			private const string SUMMONABLE_BRANCH_PREFIX = "Circle_";

			// Token: 0x04012E3E RID: 77374
			[Token(Token = "0x4012E3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			protected Dictionary<GridPosition, GameModeFactory.HalfIdleGameMode.HalfIdleRouteInfo> m_mapPosToRouteInfoDict;

			// Token: 0x04012E3F RID: 77375
			[Token(Token = "0x4012E3F")]
			private const string HALF_IDLE_TRAP_TAG = "HalfIdleTrap";

			// Token: 0x04012E40 RID: 77376
			[Token(Token = "0x4012E40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private bool m_needCheckTrapUpgrade;

			// Token: 0x04012E41 RID: 77377
			[Token(Token = "0x4012E41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_instance;

			// Token: 0x04012E42 RID: 77378
			[Token(Token = "0x4012E42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_constData;

			// Token: 0x04012E43 RID: 77379
			[Token(Token = "0x4012E43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_eventPool;

			// Token: 0x04012E44 RID: 77380
			[Token(Token = "0x4012E44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_bossBranchTriggerTime;

			// Token: 0x04012E45 RID: 77381
			[Token(Token = "0x4012E45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_maxPlayTime;

			// Token: 0x04012E46 RID: 77382
			[Token(Token = "0x4012E46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_playTime;

			// Token: 0x04012E47 RID: 77383
			[Token(Token = "0x4012E47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_occupiedEnemyCapacity;

			// Token: 0x04012E48 RID: 77384
			[Token(Token = "0x4012E48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_maxEnemyCapacity;

			// Token: 0x04012E49 RID: 77385
			[Token(Token = "0x4012E49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_currentLifePoint;

			// Token: 0x04012E4A RID: 77386
			[Token(Token = "0x4012E4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_lostLifePointByEnemyOverload;

			// Token: 0x04012E4B RID: 77387
			[Token(Token = "0x4012E4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_lostLifePointByOthers;

			// Token: 0x04012E4C RID: 77388
			[Token(Token = "0x4012E4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_enemyRushTimeList;

			// Token: 0x04012E4D RID: 77389
			[Token(Token = "0x4012E4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_isEnemyOverload;

			// Token: 0x04012E4E RID: 77390
			[Token(Token = "0x4012E4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_isEnemyOverloadWarning;

			// Token: 0x04012E4F RID: 77391
			[Token(Token = "0x4012E4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_get_isBattleCountdown;

			// Token: 0x04012E50 RID: 77392
			[Token(Token = "0x4012E50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_get_lossLifeCountdown;

			// Token: 0x04012E51 RID: 77393
			[Token(Token = "0x4012E51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_get_hasCharacterLevelUp;

			// Token: 0x04012E52 RID: 77394
			[Token(Token = "0x4012E52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_get_resourceCountDict;

			// Token: 0x04012E53 RID: 77395
			[Token(Token = "0x4012E53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_get_isResourcePanelShow;

			// Token: 0x04012E54 RID: 77396
			[Token(Token = "0x4012E54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_get_isResourcePanelShowManually;

			// Token: 0x04012E55 RID: 77397
			[Token(Token = "0x4012E55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_get_isEquipPanelUnfolded;

			// Token: 0x04012E56 RID: 77398
			[Token(Token = "0x4012E56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_get_isBattlePanelInteractable;

			// Token: 0x04012E57 RID: 77399
			[Token(Token = "0x4012E57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_get_isEquipAutoUpgradeOn;

			// Token: 0x04012E58 RID: 77400
			[Token(Token = "0x4012E58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_get_selectedEquipType;

			// Token: 0x04012E59 RID: 77401
			[Token(Token = "0x4012E59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_get_isBossKilled;

			// Token: 0x04012E5A RID: 77402
			[Token(Token = "0x4012E5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0_get_equipManager;

			// Token: 0x04012E5B RID: 77403
			[Token(Token = "0x4012E5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0_get_actId;

			// Token: 0x04012E5C RID: 77404
			[Token(Token = "0x4012E5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0_get_curDeckPageIndex;

			// Token: 0x04012E5D RID: 77405
			[Token(Token = "0x4012E5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0_get_maxDeckPageNum;

			// Token: 0x04012E5E RID: 77406
			[Token(Token = "0x4012E5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04012E5F RID: 77407
			[Token(Token = "0x4012E5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private static DelegateBridge __Hotfix0_get_gameModeType;

			// Token: 0x04012E60 RID: 77408
			[Token(Token = "0x4012E60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			private static DelegateBridge __Hotfix0_get_enableParticleEffectManager;

			// Token: 0x04012E61 RID: 77409
			[Token(Token = "0x4012E61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private static DelegateBridge __Hotfix0_get_enableHudSlowTicker;

			// Token: 0x04012E62 RID: 77410
			[Token(Token = "0x4012E62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private static DelegateBridge __Hotfix0_GatherPreloadAssets;

			// Token: 0x04012E63 RID: 77411
			[Token(Token = "0x4012E63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x04012E64 RID: 77412
			[Token(Token = "0x4012E64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private static DelegateBridge __Hotfix0_OnPostInit;

			// Token: 0x04012E65 RID: 77413
			[Token(Token = "0x4012E65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private static DelegateBridge __Hotfix0_OnEnemyReachExit;

			// Token: 0x04012E66 RID: 77414
			[Token(Token = "0x4012E66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private static DelegateBridge __Hotfix0_Tick;

			// Token: 0x04012E67 RID: 77415
			[Token(Token = "0x4012E67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private static DelegateBridge __Hotfix0_GameNotFinishCondition;

			// Token: 0x04012E68 RID: 77416
			[Token(Token = "0x4012E68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private static DelegateBridge __Hotfix0_GetBattleCompleteRank;

			// Token: 0x04012E69 RID: 77417
			[Token(Token = "0x4012E69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			private static DelegateBridge __Hotfix0_OnPlayerLifeToZero;

			// Token: 0x04012E6A RID: 77418
			[Token(Token = "0x4012E6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			private static DelegateBridge __Hotfix0_OnCardSpawned;

			// Token: 0x04012E6B RID: 77419
			[Token(Token = "0x4012E6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			private static DelegateBridge __Hotfix0_OnUnitRegistered;

			// Token: 0x04012E6C RID: 77420
			[Token(Token = "0x4012E6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			private static DelegateBridge __Hotfix0_OnEnemyFinished;

			// Token: 0x04012E6D RID: 77421
			[Token(Token = "0x4012E6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private static DelegateBridge __Hotfix0_GatherEnvSystems;

			// Token: 0x04012E6E RID: 77422
			[Token(Token = "0x4012E6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			private static DelegateBridge __Hotfix0_get_hasExtraBuildCondition;

			// Token: 0x04012E6F RID: 77423
			[Token(Token = "0x4012E6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private static DelegateBridge __Hotfix0_CheckBuildable;

			// Token: 0x04012E70 RID: 77424
			[Token(Token = "0x4012E70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
			private static DelegateBridge __Hotfix0_AllowNoneBuildableType;

			// Token: 0x04012E71 RID: 77425
			[Token(Token = "0x4012E71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private static DelegateBridge __Hotfix0_EnableGlobalBuffExtraData;

			// Token: 0x04012E72 RID: 77426
			[Token(Token = "0x4012E72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
			private static DelegateBridge __Hotfix0_GetActMeta;

			// Token: 0x04012E73 RID: 77427
			[Token(Token = "0x4012E73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private static DelegateBridge __Hotfix0_OnCardListChanged;

			// Token: 0x04012E74 RID: 77428
			[Token(Token = "0x4012E74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
			private static DelegateBridge __Hotfix0_SortDeckRuntime;

			// Token: 0x04012E75 RID: 77429
			[Token(Token = "0x4012E75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private static DelegateBridge __Hotfix0_SortDeck;

			// Token: 0x04012E76 RID: 77430
			[Token(Token = "0x4012E76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
			private static DelegateBridge __Hotfix0_OnDestroy;

			// Token: 0x04012E77 RID: 77431
			[Token(Token = "0x4012E77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private static DelegateBridge __Hotfix0_TrySetTileHighlightType;

			// Token: 0x04012E78 RID: 77432
			[Token(Token = "0x4012E78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
			private static DelegateBridge __Hotfix0_TryGetCustomTileHighlightColor;

			// Token: 0x04012E79 RID: 77433
			[Token(Token = "0x4012E79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private static DelegateBridge __Hotfix0_OnModifyLifePoint;

			// Token: 0x04012E7A RID: 77434
			[Token(Token = "0x4012E7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
			private static DelegateBridge __Hotfix0_GetEquipLevelColor;

			// Token: 0x04012E7B RID: 77435
			[Token(Token = "0x4012E7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private static DelegateBridge __Hotfix0_FinishGame;

			// Token: 0x04012E7C RID: 77436
			[Token(Token = "0x4012E7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private static DelegateBridge __Hotfix0_SetBattlePanelInteractable;

			// Token: 0x04012E7D RID: 77437
			[Token(Token = "0x4012E7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private static DelegateBridge __Hotfix0_SetResPanelShow;

			// Token: 0x04012E7E RID: 77438
			[Token(Token = "0x4012E7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private static DelegateBridge __Hotfix0_SwitchCardListPage;

			// Token: 0x04012E7F RID: 77439
			[Token(Token = "0x4012E7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private static DelegateBridge __Hotfix0_GainExp;

			// Token: 0x04012E80 RID: 77440
			[Token(Token = "0x4012E80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private static DelegateBridge __Hotfix0_DropItemOnEnemyDead;

			// Token: 0x04012E81 RID: 77441
			[Token(Token = "0x4012E81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private static DelegateBridge __Hotfix0_GainEquip;

			// Token: 0x04012E82 RID: 77442
			[Token(Token = "0x4012E82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private static DelegateBridge __Hotfix0_GainEquipByAlias;

			// Token: 0x04012E83 RID: 77443
			[Token(Token = "0x4012E83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private static DelegateBridge __Hotfix0_GainTrap;

			// Token: 0x04012E84 RID: 77444
			[Token(Token = "0x4012E84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
			private static DelegateBridge __Hotfix0_GainTrapById;

			// Token: 0x04012E85 RID: 77445
			[Token(Token = "0x4012E85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
			private static DelegateBridge __Hotfix0_TryGainResourcesFromPool;

			// Token: 0x04012E86 RID: 77446
			[Token(Token = "0x4012E86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
			private static DelegateBridge __Hotfix0_TryGetCurResourceNum;

			// Token: 0x04012E87 RID: 77447
			[Token(Token = "0x4012E87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
			private static DelegateBridge __Hotfix0_ModifyEnemyCapacity;

			// Token: 0x04012E88 RID: 77448
			[Token(Token = "0x4012E88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
			private static DelegateBridge __Hotfix0_AddEnemyCapacityWhiteList;

			// Token: 0x04012E89 RID: 77449
			[Token(Token = "0x4012E89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
			private static DelegateBridge __Hotfix0_RemoveEnemyCapacityWhiteList;

			// Token: 0x04012E8A RID: 77450
			[Token(Token = "0x4012E8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
			private static DelegateBridge __Hotfix0_TryGetBattleItem;

			// Token: 0x04012E8B RID: 77451
			[Token(Token = "0x4012E8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
			private static DelegateBridge __Hotfix0_InsertNumericFactor;

			// Token: 0x04012E8C RID: 77452
			[Token(Token = "0x4012E8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
			private static DelegateBridge __Hotfix0_InactiveNumericFactor;

			// Token: 0x04012E8D RID: 77453
			[Token(Token = "0x4012E8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
			private static DelegateBridge __Hotfix0_UpgradeRandomEquip;

			// Token: 0x04012E8E RID: 77454
			[Token(Token = "0x4012E8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
			private static DelegateBridge __Hotfix0__ResumeLevelBgm;

			// Token: 0x04012E8F RID: 77455
			[Token(Token = "0x4012E8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
			private static DelegateBridge __Hotfix0__UpdateLevelCapacity;

			// Token: 0x04012E90 RID: 77456
			[Token(Token = "0x4012E90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
			private static DelegateBridge __Hotfix0__UpdateOverloadWarning;

			// Token: 0x04012E91 RID: 77457
			[Token(Token = "0x4012E91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
			private static DelegateBridge __Hotfix0__RefreshTrapCardGainDict;

			// Token: 0x04012E92 RID: 77458
			[Token(Token = "0x4012E92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
			private static DelegateBridge __Hotfix0__RefreshCurrentCardPage;

			// Token: 0x04012E93 RID: 77459
			[Token(Token = "0x4012E93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
			private static DelegateBridge __Hotfix0__RefreshMaxCardNum;

			// Token: 0x04012E94 RID: 77460
			[Token(Token = "0x4012E94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
			private static DelegateBridge __Hotfix0__CheckCardInCurrentPage;

			// Token: 0x04012E95 RID: 77461
			[Token(Token = "0x4012E95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
			private static DelegateBridge __Hotfix0__ParsePreloadEnemy;

			// Token: 0x04012E96 RID: 77462
			[Token(Token = "0x4012E96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
			private static DelegateBridge __Hotfix0__BindBattleEvents;

			// Token: 0x04012E97 RID: 77463
			[Token(Token = "0x4012E97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
			private static DelegateBridge __Hotfix0__UnbindBattleEvents;

			// Token: 0x04012E98 RID: 77464
			[Token(Token = "0x4012E98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
			private static DelegateBridge __Hotfix0__InitEquipLevelColors;

			// Token: 0x04012E99 RID: 77465
			[Token(Token = "0x4012E99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
			private static DelegateBridge __Hotfix0__ParsePreloadTraps;

			// Token: 0x04012E9A RID: 77466
			[Token(Token = "0x4012E9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
			private static DelegateBridge __Hotfix0__CheckTileExcludedBuildable;

			// Token: 0x04012E9B RID: 77467
			[Token(Token = "0x4012E9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
			private static DelegateBridge __Hotfix0__CheckSpecialBuildCondition;

			// Token: 0x04012E9C RID: 77468
			[Token(Token = "0x4012E9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
			private static DelegateBridge __Hotfix0__InitCharacterExpDict;

			// Token: 0x04012E9D RID: 77469
			[Token(Token = "0x4012E9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
			private static DelegateBridge __Hotfix0__InitByLevelConfig;

			// Token: 0x04012E9E RID: 77470
			[Token(Token = "0x4012E9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
			private static DelegateBridge __Hotfix0__InitResourceNumDict;

			// Token: 0x04012E9F RID: 77471
			[Token(Token = "0x4012E9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
			private static DelegateBridge __Hotfix0__InitTrapItemPool;

			// Token: 0x04012EA0 RID: 77472
			[Token(Token = "0x4012EA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
			private static DelegateBridge __Hotfix0__TryGetItemPool;

			// Token: 0x04012EA1 RID: 77473
			[Token(Token = "0x4012EA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
			private static DelegateBridge __Hotfix0__TryGetTrapFromPool;

			// Token: 0x04012EA2 RID: 77474
			[Token(Token = "0x4012EA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
			private static DelegateBridge __Hotfix0__UpdateTrapDropWeight;

			// Token: 0x04012EA3 RID: 77475
			[Token(Token = "0x4012EA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
			private static DelegateBridge __Hotfix0__TryGetResourcesFromPool;

			// Token: 0x04012EA4 RID: 77476
			[Token(Token = "0x4012EA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
			private static DelegateBridge __Hotfix0__TryGetMileStone;

			// Token: 0x04012EA5 RID: 77477
			[Token(Token = "0x4012EA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
			private static DelegateBridge __Hotfix0__ConvertEntityToFactorSourceType;

			// Token: 0x04012EA6 RID: 77478
			[Token(Token = "0x4012EA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
			private static DelegateBridge __Hotfix0__TryGainResource;

			// Token: 0x04012EA7 RID: 77479
			[Token(Token = "0x4012EA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
			private static DelegateBridge __Hotfix0__CheckMlyssWtrmanNeedAttributeUpdate;

			// Token: 0x04012EA8 RID: 77480
			[Token(Token = "0x4012EA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
			private static DelegateBridge __Hotfix0__GetEnemyExpValue;

			// Token: 0x04012EA9 RID: 77481
			[Token(Token = "0x4012EA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
			private static DelegateBridge __Hotfix0__ResourceIdToAffectType;

			// Token: 0x04012EAA RID: 77482
			[Token(Token = "0x4012EAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
			private static DelegateBridge __Hotfix0__CheckNumericInfectFactorValidSourceType;

			// Token: 0x04012EAB RID: 77483
			[Token(Token = "0x4012EAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
			private static DelegateBridge __Hotfix0__CalculateFinalValue;

			// Token: 0x04012EAC RID: 77484
			[Token(Token = "0x4012EAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
			private static DelegateBridge __Hotfix0__AddExpToCharacter;

			// Token: 0x04012EAD RID: 77485
			[Token(Token = "0x4012EAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
			private static DelegateBridge __Hotfix0__LevelUpCharacter;

			// Token: 0x04012EAE RID: 77486
			[Token(Token = "0x4012EAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
			private static DelegateBridge __Hotfix0__TimeIsUp;

			// Token: 0x04012EAF RID: 77487
			[Token(Token = "0x4012EAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
			private static DelegateBridge __Hotfix0__GetEnemyLevelCapacity;

			// Token: 0x04012EB0 RID: 77488
			[Token(Token = "0x4012EB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
			private static DelegateBridge __Hotfix0__AdvanceBossBranchTriggerTime;

			// Token: 0x04012EB1 RID: 77489
			[Token(Token = "0x4012EB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
			private static DelegateBridge __Hotfix0__TryTriggerBossBranch;

			// Token: 0x04012EB2 RID: 77490
			[Token(Token = "0x4012EB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
			private static DelegateBridge __Hotfix0__TriggerBossBranchPreview;

			// Token: 0x04012EB3 RID: 77491
			[Token(Token = "0x4012EB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
			private static DelegateBridge __Hotfix0__TryWarningEnemyRush;

			// Token: 0x04012EB4 RID: 77492
			[Token(Token = "0x4012EB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
			private static DelegateBridge __Hotfix0__UpdateLifePointTimer;

			// Token: 0x04012EB5 RID: 77493
			[Token(Token = "0x4012EB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
			private static DelegateBridge __Hotfix0__TryGatherTempCharacters;

			// Token: 0x04012EB6 RID: 77494
			[Token(Token = "0x4012EB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
			private static DelegateBridge __Hotfix0__GatherExBattleTraps;

			// Token: 0x04012EB7 RID: 77495
			[Token(Token = "0x4012EB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
			private static DelegateBridge __Hotfix0__SetEquipPanelUnfolded;

			// Token: 0x04012EB8 RID: 77496
			[Token(Token = "0x4012EB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
			private static DelegateBridge __Hotfix0__ToggleEquipAutoUpgradeOn;

			// Token: 0x04012EB9 RID: 77497
			[Token(Token = "0x4012EB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
			private static DelegateBridge __Hotfix0__SetResPanelShowManually;

			// Token: 0x04012EBA RID: 77498
			[Token(Token = "0x4012EBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
			private static DelegateBridge __Hotfix0__WearEquip;

			// Token: 0x04012EBB RID: 77499
			[Token(Token = "0x4012EBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
			private static DelegateBridge __Hotfix0_HalfIdleGetRouteInfo;

			// Token: 0x04012EBC RID: 77500
			[Token(Token = "0x4012EBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
			private static DelegateBridge __Hotfix0_HalfIdleStringToRangeType;

			// Token: 0x04012EBD RID: 77501
			[Token(Token = "0x4012EBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
			private static DelegateBridge __Hotfix0_HalfIdleSpawnEnemyInRange;

			// Token: 0x04012EBE RID: 77502
			[Token(Token = "0x4012EBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
			private static DelegateBridge __Hotfix0__HalfIdleCheckTileAbleToSummonEnemy;

			// Token: 0x04012EBF RID: 77503
			[Token(Token = "0x4012EBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
			private static DelegateBridge __Hotfix0_HalfIdleSpawnEnemyAtCertainPosition;

			// Token: 0x04012EC0 RID: 77504
			[Token(Token = "0x4012EC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
			private static DelegateBridge __Hotfix0__ConstructMapPosToRouteInfoDict;

			// Token: 0x04012EC1 RID: 77505
			[Token(Token = "0x4012EC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
			private static DelegateBridge __Hotfix0__ValidateTileBeingAddedToMapPosDict;

			// Token: 0x04012EC2 RID: 77506
			[Token(Token = "0x4012EC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
			private static DelegateBridge __Hotfix0__ComputeRouteInfo;

			// Token: 0x04012EC3 RID: 77507
			[Token(Token = "0x4012EC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
			private static DelegateBridge __Hotfix0_CheckNearByRoad;

			// Token: 0x04012EC4 RID: 77508
			[Token(Token = "0x4012EC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
			private static DelegateBridge __Hotfix0__HalfIdleUpdateSTilesByRangeId;

			// Token: 0x04012EC5 RID: 77509
			[Token(Token = "0x4012EC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
			private static DelegateBridge __Hotfix0_UpgradeTrap;

			// Token: 0x04012EC6 RID: 77510
			[Token(Token = "0x4012EC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
			private static DelegateBridge __Hotfix0_HalfIdleNotifyTrapUpgrade;

			// Token: 0x04012EC7 RID: 77511
			[Token(Token = "0x4012EC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
			private static DelegateBridge __Hotfix0__TriggerTrapUpgradeCheck;

			// Token: 0x020027DC RID: 10204
			[Token(Token = "0x20027DC")]
			public class NumericInfectFactor
			{
				// Token: 0x06010E0C RID: 69132 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010E0C")]
				[Address(RVA = "0x8BB850", Offset = "0x8BA450", VA = "0x1808BB850")]
				public NumericInfectFactor()
				{
				}

				// Token: 0x06010E0D RID: 69133 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010E0D")]
				[Address(RVA = "0x8BB860", Offset = "0x8BA460", VA = "0x1808BB860")]
				public NumericInfectFactor(GameModeFactory.HalfIdleGameMode.NumericInfectFactor.NumericInfectFactorCreateInfo ci)
				{
				}

				// Token: 0x17002513 RID: 9491
				// (get) Token: 0x06010E0E RID: 69134 RVA: 0x00067BA8 File Offset: 0x00065DA8
				// (set) Token: 0x06010E0F RID: 69135 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17002513")]
				public bool valide
				{
					[Token(Token = "0x6010E0E")]
					[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
					get
					{
						return default(bool);
					}
					[Token(Token = "0x6010E0F")]
					[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
					set
					{
					}
				}

				// Token: 0x17002514 RID: 9492
				// (get) Token: 0x06010E10 RID: 69136 RVA: 0x00067BC0 File Offset: 0x00065DC0
				// (set) Token: 0x06010E11 RID: 69137 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17002514")]
				public float value
				{
					[Token(Token = "0x6010E10")]
					[Address(RVA = "0x4F1EB0", Offset = "0x4F0AB0", VA = "0x1804F1EB0")]
					get
					{
						return 0f;
					}
					[Token(Token = "0x6010E11")]
					[Address(RVA = "0x4F1EC0", Offset = "0x4F0AC0", VA = "0x1804F1EC0")]
					set
					{
					}
				}

				// Token: 0x17002515 RID: 9493
				// (get) Token: 0x06010E12 RID: 69138 RVA: 0x00067BD8 File Offset: 0x00065DD8
				// (set) Token: 0x06010E13 RID: 69139 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17002515")]
				public GameModeFactory.HalfIdleGameMode.NumericInfectFactor.AffectType affectType
				{
					[Token(Token = "0x6010E12")]
					[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
					get
					{
						return GameModeFactory.HalfIdleGameMode.NumericInfectFactor.AffectType.None;
					}
					[Token(Token = "0x6010E13")]
					[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
					set
					{
					}
				}

				// Token: 0x17002516 RID: 9494
				// (get) Token: 0x06010E14 RID: 69140 RVA: 0x00067BF0 File Offset: 0x00065DF0
				// (set) Token: 0x06010E15 RID: 69141 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17002516")]
				public GameModeFactory.HalfIdleGameMode.NumericInfectFactor.CalcType calcType
				{
					[Token(Token = "0x6010E14")]
					[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
					get
					{
						return GameModeFactory.HalfIdleGameMode.NumericInfectFactor.CalcType.NONE;
					}
					[Token(Token = "0x6010E15")]
					[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
					set
					{
					}
				}

				// Token: 0x17002517 RID: 9495
				// (get) Token: 0x06010E16 RID: 69142 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x06010E17 RID: 69143 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17002517")]
				public string key
				{
					[Token(Token = "0x6010E16")]
					[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
					get
					{
						return null;
					}
					[Token(Token = "0x6010E17")]
					[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
					set
					{
					}
				}

				// Token: 0x17002518 RID: 9496
				// (get) Token: 0x06010E18 RID: 69144 RVA: 0x00067C08 File Offset: 0x00065E08
				[Token(Token = "0x17002518")]
				public GameModeFactory.HalfIdleGameMode.NumericInfectFactor.ValidSourceType validSource
				{
					[Token(Token = "0x6010E18")]
					[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
					get
					{
						return GameModeFactory.HalfIdleGameMode.NumericInfectFactor.ValidSourceType.NONE;
					}
				}

				// Token: 0x04012EC8 RID: 77512
				[Token(Token = "0x4012EC8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private bool m_valide;

				// Token: 0x04012EC9 RID: 77513
				[Token(Token = "0x4012EC9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				private float m_value;

				// Token: 0x04012ECA RID: 77514
				[Token(Token = "0x4012ECA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private GameModeFactory.HalfIdleGameMode.NumericInfectFactor.AffectType m_affectType;

				// Token: 0x04012ECB RID: 77515
				[Token(Token = "0x4012ECB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private GameModeFactory.HalfIdleGameMode.NumericInfectFactor.CalcType m_calcType;

				// Token: 0x04012ECC RID: 77516
				[Token(Token = "0x4012ECC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private string m_key;

				// Token: 0x04012ECD RID: 77517
				[Token(Token = "0x4012ECD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private GameModeFactory.HalfIdleGameMode.NumericInfectFactor.ValidSourceType m_validSource;

				// Token: 0x020027DD RID: 10205
				[Token(Token = "0x20027DD")]
				public enum AffectType
				{
					// Token: 0x04012ECF RID: 77519
					[Token(Token = "0x4012ECF")]
					None,
					// Token: 0x04012ED0 RID: 77520
					[Token(Token = "0x4012ED0")]
					Exp,
					// Token: 0x04012ED1 RID: 77521
					[Token(Token = "0x4012ED1")]
					ExpBook
				}

				// Token: 0x020027DE RID: 10206
				[Token(Token = "0x20027DE")]
				public enum CalcType
				{
					// Token: 0x04012ED3 RID: 77523
					[Token(Token = "0x4012ED3")]
					NONE,
					// Token: 0x04012ED4 RID: 77524
					[Token(Token = "0x4012ED4")]
					ADD,
					// Token: 0x04012ED5 RID: 77525
					[Token(Token = "0x4012ED5")]
					MUL,
					// Token: 0x04012ED6 RID: 77526
					[Token(Token = "0x4012ED6")]
					FINAL_ADD
				}

				// Token: 0x020027DF RID: 10207
				[Token(Token = "0x20027DF")]
				public enum ValidSourceType
				{
					// Token: 0x04012ED8 RID: 77528
					[Token(Token = "0x4012ED8")]
					NONE,
					// Token: 0x04012ED9 RID: 77529
					[Token(Token = "0x4012ED9")]
					NONE_ENTITY,
					// Token: 0x04012EDA RID: 77530
					[Token(Token = "0x4012EDA")]
					ENEMY,
					// Token: 0x04012EDB RID: 77531
					[Token(Token = "0x4012EDB")]
					CHARACTER = 4,
					// Token: 0x04012EDC RID: 77532
					[Token(Token = "0x4012EDC")]
					ALL = 7
				}

				// Token: 0x020027E0 RID: 10208
				[Token(Token = "0x20027E0")]
				public struct NumericInfectFactorCreateInfo
				{
					// Token: 0x06010E19 RID: 69145 RVA: 0x00067C20 File Offset: 0x00065E20
					[Token(Token = "0x6010E19")]
					[Address(RVA = "0x8BB7E0", Offset = "0x8BA3E0", VA = "0x1808BB7E0")]
					public bool Match(GameModeFactory.HalfIdleGameMode.NumericInfectFactor factor)
					{
						return default(bool);
					}

					// Token: 0x04012EDD RID: 77533
					[Token(Token = "0x4012EDD")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
					public bool valide;

					// Token: 0x04012EDE RID: 77534
					[Token(Token = "0x4012EDE")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
					public float value;

					// Token: 0x04012EDF RID: 77535
					[Token(Token = "0x4012EDF")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
					public GameModeFactory.HalfIdleGameMode.NumericInfectFactor.AffectType affectType;

					// Token: 0x04012EE0 RID: 77536
					[Token(Token = "0x4012EE0")]
					[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
					public GameModeFactory.HalfIdleGameMode.NumericInfectFactor.CalcType calcType;

					// Token: 0x04012EE1 RID: 77537
					[Token(Token = "0x4012EE1")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					public string key;

					// Token: 0x04012EE2 RID: 77538
					[Token(Token = "0x4012EE2")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
					public GameModeFactory.HalfIdleGameMode.NumericInfectFactor.ValidSourceType validSource;
				}
			}

			// Token: 0x020027E1 RID: 10209
			[Token(Token = "0x20027E1")]
			public enum HalfIdleRangeIdType
			{
				// Token: 0x04012EE4 RID: 77540
				[Token(Token = "0x4012EE4")]
				None,
				// Token: 0x04012EE5 RID: 77541
				[Token(Token = "0x4012EE5")]
				R_x_4,
				// Token: 0x04012EE6 RID: 77542
				[Token(Token = "0x4012EE6")]
				R_x_5,
				// Token: 0x04012EE7 RID: 77543
				[Token(Token = "0x4012EE7")]
				R_lhtown
			}

			// Token: 0x020027E2 RID: 10210
			[Token(Token = "0x20027E2")]
			public class HalfIdleRouteInfo
			{
				// Token: 0x06010E1A RID: 69146 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010E1A")]
				[Address(RVA = "0x8AE640", Offset = "0x8AD240", VA = "0x1808AE640")]
				public HalfIdleRouteInfo()
				{
				}

				// Token: 0x04012EE8 RID: 77544
				[Token(Token = "0x4012EE8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string branchId;

				// Token: 0x04012EE9 RID: 77545
				[Token(Token = "0x4012EE9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public float minDistance;

				// Token: 0x04012EEA RID: 77546
				[Token(Token = "0x4012EEA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				public int checkPointIndex;
			}

			// Token: 0x020027E3 RID: 10211
			[Token(Token = "0x20027E3")]
			public struct HalfIdleTrapUpgradeMsg
			{
				// Token: 0x06010E1B RID: 69147 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010E1B")]
				[Address(RVA = "0x8AE6A0", Offset = "0x8AD2A0", VA = "0x1808AE6A0")]
				public HalfIdleTrapUpgradeMsg(Entity source, Entity target, GameModeFactory.HalfIdleGameMode.HalfIdleTrapUpgradeMap upgradeKV, bool force = false)
				{
				}

				// Token: 0x04012EEB RID: 77547
				[Token(Token = "0x4012EEB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string originTrapId;

				// Token: 0x04012EEC RID: 77548
				[Token(Token = "0x4012EEC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string targetTrapId;

				// Token: 0x04012EED RID: 77549
				[Token(Token = "0x4012EED")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public GridPosition originTrapPos;

				// Token: 0x04012EEE RID: 77550
				[Token(Token = "0x4012EEE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public GridPosition targetTrapPos;

				// Token: 0x04012EEF RID: 77551
				[Token(Token = "0x4012EEF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public SharedConsts.Direction direction;

				// Token: 0x04012EF0 RID: 77552
				[Token(Token = "0x4012EF0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				public bool force;
			}

			// Token: 0x020027E4 RID: 10212
			[Token(Token = "0x20027E4")]
			[Serializable]
			public class HalfIdleTrapUpgradeMap
			{
				// Token: 0x06010E1C RID: 69148 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010E1C")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public HalfIdleTrapUpgradeMap()
				{
				}

				// Token: 0x04012EF1 RID: 77553
				[Token(Token = "0x4012EF1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string trapTag;

				// Token: 0x04012EF2 RID: 77554
				[Token(Token = "0x4012EF2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string direvedTrapID;
			}
		}

		// Token: 0x020027E5 RID: 10213
		[Token(Token = "0x20027E5")]
		public class LegionGameMode : GameModeFactory.DefaultGameMode
		{
			// Token: 0x06010E1D RID: 69149 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E1D")]
			[Address(RVA = "0x8B8820", Offset = "0x8B7420", VA = "0x1808B8820")]
			public LegionGameMode(ref GameModeMeta meta)
			{
			}

			// Token: 0x17002519 RID: 9497
			// (get) Token: 0x06010E1E RID: 69150 RVA: 0x00067C38 File Offset: 0x00065E38
			[Token(Token = "0x17002519")]
			public int maxProfessionBuffCount
			{
				[Token(Token = "0x6010E1E")]
				[Address(RVA = "0x8B98E0", Offset = "0x8B84E0", VA = "0x1808B98E0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700251A RID: 9498
			// (get) Token: 0x06010E1F RID: 69151 RVA: 0x00067C50 File Offset: 0x00065E50
			[Token(Token = "0x1700251A")]
			public int professionLevelAdd
			{
				[Token(Token = "0x6010E1F")]
				[Address(RVA = "0x8B99B0", Offset = "0x8B85B0", VA = "0x1808B99B0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700251B RID: 9499
			// (get) Token: 0x06010E20 RID: 69152 RVA: 0x00067C68 File Offset: 0x00065E68
			[Token(Token = "0x1700251B")]
			public int usedCardCount
			{
				[Token(Token = "0x6010E20")]
				[Address(RVA = "0x8B9AF0", Offset = "0x8B86F0", VA = "0x1808B9AF0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700251C RID: 9500
			// (get) Token: 0x06010E21 RID: 69153 RVA: 0x00067C80 File Offset: 0x00065E80
			[Token(Token = "0x1700251C")]
			public int remainingCardCount
			{
				[Token(Token = "0x6010E21")]
				[Address(RVA = "0x8B9A20", Offset = "0x8B8620", VA = "0x1808B9A20")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700251D RID: 9501
			// (get) Token: 0x06010E23 RID: 69155 RVA: 0x00067C98 File Offset: 0x00065E98
			// (set) Token: 0x06010E22 RID: 69154 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700251D")]
			public bool needPlayReshuffle
			{
				[Token(Token = "0x6010E23")]
				[Address(RVA = "0x8B9950", Offset = "0x8B8550", VA = "0x1808B9950")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6010E22")]
				[Address(RVA = "0x8B9DB0", Offset = "0x8B89B0", VA = "0x1808B9DB0")]
				set
				{
				}
			}

			// Token: 0x1700251E RID: 9502
			// (get) Token: 0x06010E24 RID: 69156 RVA: 0x00067CB0 File Offset: 0x00065EB0
			[Token(Token = "0x1700251E")]
			public int goldForEndPrepare
			{
				[Token(Token = "0x6010E24")]
				[Address(RVA = "0x8B9440", Offset = "0x8B8040", VA = "0x1808B9440")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700251F RID: 9503
			// (get) Token: 0x06010E25 RID: 69157 RVA: 0x00067CC8 File Offset: 0x00065EC8
			[Token(Token = "0x1700251F")]
			public int goldForWaveEnd
			{
				[Token(Token = "0x6010E25")]
				[Address(RVA = "0x8B94B0", Offset = "0x8B80B0", VA = "0x1808B94B0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002520 RID: 9504
			// (get) Token: 0x06010E26 RID: 69158 RVA: 0x00067CE0 File Offset: 0x00065EE0
			[Token(Token = "0x17002520")]
			public int initRedrawCount
			{
				[Token(Token = "0x6010E26")]
				[Address(RVA = "0x8B9800", Offset = "0x8B8400", VA = "0x1808B9800")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002521 RID: 9505
			// (get) Token: 0x06010E27 RID: 69159 RVA: 0x00067CF8 File Offset: 0x00065EF8
			[Token(Token = "0x17002521")]
			public int ingameRedrawCount
			{
				[Token(Token = "0x6010E27")]
				[Address(RVA = "0x8B9790", Offset = "0x8B8390", VA = "0x1808B9790")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002522 RID: 9506
			// (get) Token: 0x06010E28 RID: 69160 RVA: 0x00067D10 File Offset: 0x00065F10
			[Token(Token = "0x17002522")]
			public int inHandCardCount
			{
				[Token(Token = "0x6010E28")]
				[Address(RVA = "0x8B9600", Offset = "0x8B8200", VA = "0x1808B9600")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002523 RID: 9507
			// (get) Token: 0x06010E29 RID: 69161 RVA: 0x00067D28 File Offset: 0x00065F28
			[Token(Token = "0x17002523")]
			public int maxCardCount
			{
				[Token(Token = "0x6010E29")]
				[Address(RVA = "0x8B9870", Offset = "0x8B8470", VA = "0x1808B9870")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002524 RID: 9508
			// (get) Token: 0x06010E2A RID: 69162 RVA: 0x00067D40 File Offset: 0x00065F40
			[Token(Token = "0x17002524")]
			public bool ableToDrawNextCard
			{
				[Token(Token = "0x6010E2A")]
				[Address(RVA = "0x8B9040", Offset = "0x8B7C40", VA = "0x1808B9040")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002525 RID: 9509
			// (get) Token: 0x06010E2B RID: 69163 RVA: 0x00067D58 File Offset: 0x00065F58
			[Token(Token = "0x17002525")]
			public bool handCardNotFull
			{
				[Token(Token = "0x6010E2B")]
				[Address(RVA = "0x8B9520", Offset = "0x8B8120", VA = "0x1808B9520")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002526 RID: 9510
			// (get) Token: 0x06010E2C RID: 69164 RVA: 0x00067D70 File Offset: 0x00065F70
			[Token(Token = "0x17002526")]
			public bool currentGoldEnough
			{
				[Token(Token = "0x6010E2C")]
				[Address(RVA = "0x8B9200", Offset = "0x8B7E00", VA = "0x1808B9200")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002527 RID: 9511
			// (get) Token: 0x06010E2D RID: 69165 RVA: 0x00067D88 File Offset: 0x00065F88
			[Token(Token = "0x17002527")]
			public int addPriceWhenReshuffle
			{
				[Token(Token = "0x6010E2D")]
				[Address(RVA = "0x8B90D0", Offset = "0x8B7CD0", VA = "0x1808B90D0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002528 RID: 9512
			// (get) Token: 0x06010E2E RID: 69166 RVA: 0x00067DA0 File Offset: 0x00065FA0
			[Token(Token = "0x17002528")]
			public bool showAddPriceWhenReshuffle
			{
				[Token(Token = "0x6010E2E")]
				[Address(RVA = "0x8B9A90", Offset = "0x8B8690", VA = "0x1808B9A90")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002529 RID: 9513
			// (get) Token: 0x06010E2F RID: 69167 RVA: 0x00067DB8 File Offset: 0x00065FB8
			// (set) Token: 0x06010E30 RID: 69168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002529")]
			public int currentCardPrice
			{
				[Token(Token = "0x6010E2F")]
				[Address(RVA = "0x8B91A0", Offset = "0x8B7DA0", VA = "0x1808B91A0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6010E30")]
				[Address(RVA = "0x8B9B60", Offset = "0x8B8760", VA = "0x1808B9B60")]
				set
				{
				}
			}

			// Token: 0x1700252A RID: 9514
			// (get) Token: 0x06010E31 RID: 69169 RVA: 0x00067DD0 File Offset: 0x00065FD0
			// (set) Token: 0x06010E32 RID: 69170 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700252A")]
			public int currentGold
			{
				[Token(Token = "0x6010E31")]
				[Address(RVA = "0x8B92D0", Offset = "0x8B7ED0", VA = "0x1808B92D0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6010E32")]
				[Address(RVA = "0x8B9BF0", Offset = "0x8B87F0", VA = "0x1808B9BF0")]
				set
				{
				}
			}

			// Token: 0x1700252B RID: 9515
			// (get) Token: 0x06010E33 RID: 69171 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700252B")]
			public Deck.Card cachedCardLastDraw
			{
				[Token(Token = "0x6010E33")]
				[Address(RVA = "0x8B9140", Offset = "0x8B7D40", VA = "0x1808B9140")]
				get
				{
					return null;
				}
			}

			// Token: 0x06010E34 RID: 69172 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010E34")]
			[Address(RVA = "0x8B1770", Offset = "0x8B0370", VA = "0x1808B1770")]
			public List<Deck.Card> GetCardLibraryByType(LegionCardLibraryType cardType)
			{
				return null;
			}

			// Token: 0x06010E35 RID: 69173 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E35")]
			[Address(RVA = "0x8B51A0", Offset = "0x8B3DA0", VA = "0x1808B51A0")]
			public void ShuffleAllPendingAndUsedCards()
			{
			}

			// Token: 0x06010E36 RID: 69174 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E36")]
			[Address(RVA = "0x8B6EB0", Offset = "0x8B5AB0", VA = "0x1808B6EB0")]
			private void _OnCardPutToHand(Deck.Card card)
			{
			}

			// Token: 0x06010E37 RID: 69175 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E37")]
			[Address(RVA = "0x8B63E0", Offset = "0x8B4FE0", VA = "0x1808B63E0")]
			private void _DrawCardToHand(Deck.Card card)
			{
			}

			// Token: 0x06010E38 RID: 69176 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E38")]
			[Address(RVA = "0x8B6160", Offset = "0x8B4D60", VA = "0x1808B6160")]
			private void _DrawCardToHandDirectly(Deck.Card card)
			{
			}

			// Token: 0x06010E39 RID: 69177 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E39")]
			[Address(RVA = "0x8B66B0", Offset = "0x8B52B0", VA = "0x1808B66B0")]
			private void _DrawCardsFromPendingToHand(int count)
			{
			}

			// Token: 0x06010E3A RID: 69178 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E3A")]
			[Address(RVA = "0x8B6060", Offset = "0x8B4C60", VA = "0x1808B6060")]
			private void _DrawCardFromPendingToHand()
			{
			}

			// Token: 0x06010E3B RID: 69179 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E3B")]
			[Address(RVA = "0x8B7A30", Offset = "0x8B6630", VA = "0x1808B7A30")]
			private void _PickDifferentKindCard(List<Deck.Card> sourceList, List<Deck.Card> resultList)
			{
			}

			// Token: 0x06010E3C RID: 69180 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E3C")]
			[Address(RVA = "0x8B75B0", Offset = "0x8B61B0", VA = "0x1808B75B0")]
			private void _PickCardBySpecificKeys(List<string> cardKeys, List<Deck.Card> resultList)
			{
			}

			// Token: 0x06010E3D RID: 69181 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E3D")]
			[Address(RVA = "0x8B4CF0", Offset = "0x8B38F0", VA = "0x1808B4CF0")]
			public void SelectCardToHandFromOtherLibrary(BattleLegionSelectCardParam param)
			{
			}

			// Token: 0x06010E3E RID: 69182 RVA: 0x00067DE8 File Offset: 0x00065FE8
			[Token(Token = "0x6010E3E")]
			[Address(RVA = "0x8B4600", Offset = "0x8B3200", VA = "0x1808B4600")]
			public bool RefreshSelectCardList(ref BattleLegionSelectCardParam param)
			{
				return default(bool);
			}

			// Token: 0x06010E3F RID: 69183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E3F")]
			[Address(RVA = "0x8AF5D0", Offset = "0x8AE1D0", VA = "0x1808AF5D0")]
			public void DrawCardFromCardLibrary(List<uint> selectRangeIds, List<uint> selectIds, BattleLegionSelectCardParam selectData)
			{
			}

			// Token: 0x06010E40 RID: 69184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E40")]
			[Address(RVA = "0x8AE830", Offset = "0x8AD430", VA = "0x1808AE830")]
			public void AddProfessionLevelFromLastSelectCards(Character character)
			{
			}

			// Token: 0x06010E41 RID: 69185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E41")]
			[Address(RVA = "0x8B0480", Offset = "0x8AF080", VA = "0x1808B0480")]
			public void DrawNextCard(bool noCost = false, bool isManual = false)
			{
			}

			// Token: 0x06010E42 RID: 69186 RVA: 0x00067E00 File Offset: 0x00066000
			[Token(Token = "0x6010E42")]
			[Address(RVA = "0x8B0BC0", Offset = "0x8AF7C0", VA = "0x1808B0BC0")]
			public bool DrawNextProfessionCard(ProfessionCategory professionGroup, bool drawCardFromUsedAndPending = false)
			{
				return default(bool);
			}

			// Token: 0x06010E43 RID: 69187 RVA: 0x00067E18 File Offset: 0x00066018
			[Token(Token = "0x6010E43")]
			[Address(RVA = "0x8B07D0", Offset = "0x8AF3D0", VA = "0x1808B07D0")]
			public bool DrawNextProfessionCard(ProfessionCategory professionGroup, int cnt, out List<Deck.Card> cardList, bool drawCardFromUsedAndPending = false)
			{
				return default(bool);
			}

			// Token: 0x06010E44 RID: 69188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E44")]
			[Address(RVA = "0x8B8330", Offset = "0x8B6F30", VA = "0x1808B8330")]
			private void _PutCardToUsed(Deck.Card card)
			{
			}

			// Token: 0x06010E45 RID: 69189 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E45")]
			[Address(RVA = "0x8B8200", Offset = "0x8B6E00", VA = "0x1808B8200")]
			private void _PutCardToPending(Deck.Card card)
			{
			}

			// Token: 0x06010E46 RID: 69190 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E46")]
			[Address(RVA = "0x8B8720", Offset = "0x8B7320", VA = "0x1808B8720")]
			private void _UpdateCharacterCardCnt(Deck.Card card, bool isAdd)
			{
			}

			// Token: 0x06010E47 RID: 69191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E47")]
			[Address(RVA = "0x8B8140", Offset = "0x8B6D40", VA = "0x1808B8140")]
			private void _PutCardToDiscard(Deck.Card card)
			{
			}

			// Token: 0x06010E48 RID: 69192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E48")]
			[Address(RVA = "0x8B8570", Offset = "0x8B7170", VA = "0x1808B8570")]
			private void _ReleaseFromDiscardLibraryIfNeed(Deck.Card card)
			{
			}

			// Token: 0x06010E49 RID: 69193 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E49")]
			[Address(RVA = "0x8B7FC0", Offset = "0x8B6BC0", VA = "0x1808B7FC0")]
			private void _PutCardToBlastCardList(Deck.Card card)
			{
			}

			// Token: 0x06010E4A RID: 69194 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E4A")]
			[Address(RVA = "0x8B84D0", Offset = "0x8B70D0", VA = "0x1808B84D0")]
			private void _RedrawCardToHandNextTick(Deck.Card card)
			{
			}

			// Token: 0x06010E4B RID: 69195 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E4B")]
			[Address(RVA = "0x8B1060", Offset = "0x8AFC60", VA = "0x1808B1060")]
			public void ForceRecycleCard(Deck.Card card)
			{
			}

			// Token: 0x06010E4C RID: 69196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E4C")]
			[Address(RVA = "0x8AF4B0", Offset = "0x8AE0B0", VA = "0x1808AF4B0")]
			public void DiscardCardFromLibrary(LegionCardLibraryType cardType, Deck.Card discardCard)
			{
			}

			// Token: 0x06010E4D RID: 69197 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E4D")]
			[Address(RVA = "0x8B1120", Offset = "0x8AFD20", VA = "0x1808B1120")]
			public void GainCardToLibrary(LegionCardLibraryType libraryType, Deck.Card gainCard)
			{
			}

			// Token: 0x06010E4E RID: 69198 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E4E")]
			[Address(RVA = "0x8B02F0", Offset = "0x8AEEF0", VA = "0x1808B02F0")]
			public void DrawCardFromLibraryViaTag(LegionCardLibraryType cardType, string[] tags, int count)
			{
			}

			// Token: 0x06010E4F RID: 69199 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E4F")]
			[Address(RVA = "0x8B0180", Offset = "0x8AED80", VA = "0x1808B0180")]
			public void DrawCardFromLibraryViaId(LegionCardLibraryType cardType, string id)
			{
			}

			// Token: 0x06010E50 RID: 69200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E50")]
			[Address(RVA = "0x8B4160", Offset = "0x8B2D60", VA = "0x1808B4160")]
			public void RedrawCards(List<Deck.Card> cardList)
			{
			}

			// Token: 0x06010E51 RID: 69201 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E51")]
			[Address(RVA = "0x8B4DF0", Offset = "0x8B39F0", VA = "0x1808B4DF0")]
			public void SetCardUseOnlyOnce(uint uid)
			{
			}

			// Token: 0x06010E52 RID: 69202 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E52")]
			[Address(RVA = "0x8B4050", Offset = "0x8B2C50", VA = "0x1808B4050")]
			public void PutCardToUsed(Deck.Card card)
			{
			}

			// Token: 0x06010E53 RID: 69203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E53")]
			[Address(RVA = "0x8B2850", Offset = "0x8B1450", VA = "0x1808B2850")]
			public void ModifyCharacterOverlapState(Character character, bool noOverlap = true)
			{
			}

			// Token: 0x06010E54 RID: 69204 RVA: 0x00067E30 File Offset: 0x00066030
			[Token(Token = "0x6010E54")]
			[Address(RVA = "0x8B4990", Offset = "0x8B3590", VA = "0x1808B4990")]
			public bool ReleaseDiscardCardByKey(string cardKey)
			{
				return default(bool);
			}

			// Token: 0x06010E55 RID: 69205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E55")]
			[Address(RVA = "0x8B8640", Offset = "0x8B7240", VA = "0x1808B8640")]
			private void _SetCardHidden(Deck.Card card, bool isHide)
			{
			}

			// Token: 0x1700252C RID: 9516
			// (get) Token: 0x06010E56 RID: 69206 RVA: 0x00067E48 File Offset: 0x00066048
			[Token(Token = "0x1700252C")]
			public override bool hasExtraBuildCondition
			{
				[Token(Token = "0x6010E56")]
				[Address(RVA = "0x8B95A0", Offset = "0x8B81A0", VA = "0x1808B95A0", Slot = "106")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700252D RID: 9517
			// (get) Token: 0x06010E57 RID: 69207 RVA: 0x00067E60 File Offset: 0x00066060
			[Token(Token = "0x1700252D")]
			public override GameModeMeta.GameModeType gameModeType
			{
				[Token(Token = "0x6010E57")]
				[Address(RVA = "0x8B93E0", Offset = "0x8B7FE0", VA = "0x1808B93E0", Slot = "119")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x06010E58 RID: 69208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E58")]
			[Address(RVA = "0x8B3250", Offset = "0x8B1E50", VA = "0x1808B3250", Slot = "141")]
			public override void PreprocessPlayerData(List<BattlePlayerData> dataList)
			{
			}

			// Token: 0x06010E59 RID: 69209 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E59")]
			[Address(RVA = "0x8B3C90", Offset = "0x8B2890", VA = "0x1808B3C90", Slot = "142")]
			public override void PreprocessPlayerDeckList(ListDict<PlayerSide, Deck> deckList)
			{
			}

			// Token: 0x06010E5A RID: 69210 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E5A")]
			[Address(RVA = "0x8B2E20", Offset = "0x8B1A20", VA = "0x1808B2E20", Slot = "123")]
			public override void OnPostInit()
			{
			}

			// Token: 0x06010E5B RID: 69211 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010E5B")]
			[Address(RVA = "0x8B31C0", Offset = "0x8B1DC0", VA = "0x1808B31C0", Slot = "135")]
			public override LevelData.Options PostprocessLevelOptions(LevelData.Options options)
			{
				return null;
			}

			// Token: 0x06010E5C RID: 69212 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E5C")]
			[Address(RVA = "0x8B7C20", Offset = "0x8B6820", VA = "0x1808B7C20")]
			private void _ProcessLevelConfig(Blackboard blackboard)
			{
			}

			// Token: 0x06010E5D RID: 69213 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E5D")]
			[Address(RVA = "0x8B2FC0", Offset = "0x8B1BC0", VA = "0x1808B2FC0", Slot = "148")]
			public override void OnWaveWillStart(LevelData.WaveData waveData)
			{
			}

			// Token: 0x06010E5E RID: 69214 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E5E")]
			[Address(RVA = "0x8B3050", Offset = "0x8B1C50", VA = "0x1808B3050", Slot = "150")]
			public override void ParseBattleEvents(LevelData.WaveData.FragmentData.ActionData data)
			{
			}

			// Token: 0x06010E5F RID: 69215 RVA: 0x00067E78 File Offset: 0x00066078
			[Token(Token = "0x6010E5F")]
			[Address(RVA = "0x8AEA90", Offset = "0x8AD690", VA = "0x1808AEA90", Slot = "152")]
			public override bool CheckBuildable(BuildCondition buildCondition, Tile tile, SharedConsts.Direction direction, bool spawnManually, bool overflowOccupiedCnt, BattleCharacterData sourceData, PlayerSide operationSide = PlayerSide.DEFAULT)
			{
				return default(bool);
			}

			// Token: 0x06010E60 RID: 69216 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010E60")]
			[Address(RVA = "0x8B1F40", Offset = "0x8B0B40", VA = "0x1808B1F40", Slot = "155")]
			public override Scheduler.SchedulerPreprocessor GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x06010E61 RID: 69217 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010E61")]
			[Address(RVA = "0x8B12C0", Offset = "0x8AFEC0", VA = "0x1808B12C0", Slot = "157")]
			public override List<LevelData.GlobalBuffData> GatherGlobalBuffs()
			{
				return null;
			}

			// Token: 0x06010E62 RID: 69218 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E62")]
			[Address(RVA = "0x8B2110", Offset = "0x8B0D10", VA = "0x1808B2110", Slot = "122")]
			public override void Init(ref GameModeMeta meta, ref int randomSeed, BattlePlayerData playerData, LevelData levelData)
			{
			}

			// Token: 0x06010E63 RID: 69219 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E63")]
			[Address(RVA = "0x8B5380", Offset = "0x8B3F80", VA = "0x1808B5380", Slot = "126")]
			public override void Tick(Action doDefaultTick)
			{
			}

			// Token: 0x06010E64 RID: 69220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E64")]
			[Address(RVA = "0x8B2D80", Offset = "0x8B1980", VA = "0x1808B2D80", Slot = "163")]
			public override void OnCharacterFinished(Character character, Entity.FinishReason reason)
			{
			}

			// Token: 0x06010E65 RID: 69221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E65")]
			[Address(RVA = "0x8B2B20", Offset = "0x8B1720", VA = "0x1808B2B20", Slot = "172")]
			public override void OnCardListChanged(Deck.Card card)
			{
			}

			// Token: 0x06010E66 RID: 69222 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E66")]
			[Address(RVA = "0x8B2CA0", Offset = "0x8B18A0", VA = "0x1808B2CA0", Slot = "170")]
			public override void OnCardRecycle(Deck.Card card)
			{
			}

			// Token: 0x06010E67 RID: 69223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E67")]
			[Address(RVA = "0x8B7010", Offset = "0x8B5C10", VA = "0x1808B7010")]
			private void _OnCardRecycle(Deck.Card card)
			{
			}

			// Token: 0x06010E68 RID: 69224 RVA: 0x00067E90 File Offset: 0x00066090
			[Token(Token = "0x6010E68")]
			[Address(RVA = "0x8AF0F0", Offset = "0x8ADCF0", VA = "0x1808AF0F0", Slot = "169")]
			public override bool CheckCardReadyToSpawn(Deck.Card card)
			{
				return default(bool);
			}

			// Token: 0x06010E69 RID: 69225 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010E69")]
			[Address(RVA = "0x8B1510", Offset = "0x8B0110", VA = "0x1808B1510")]
			public static Dictionary<ResourceCollector.PreloadType, object> GatherPreloadAssets()
			{
				return null;
			}

			// Token: 0x06010E6A RID: 69226 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010E6A")]
			[Address(RVA = "0x8B6980", Offset = "0x8B5580", VA = "0x1808B6980")]
			private static List<BattleCharacterData> _GetPreGivenTokens(LegionInput input)
			{
				return null;
			}

			// Token: 0x06010E6B RID: 69227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E6B")]
			[Address(RVA = "0x8B5080", Offset = "0x8B3C80", VA = "0x1808B5080")]
			public void ShowStatusMessage(Character character)
			{
			}

			// Token: 0x06010E6C RID: 69228 RVA: 0x00067EA8 File Offset: 0x000660A8
			[Token(Token = "0x6010E6C")]
			[Address(RVA = "0x8B1C90", Offset = "0x8B0890", VA = "0x1808B1C90")]
			public int GetLegionGold(PlayerSide side = PlayerSide.DEFAULT)
			{
				return 0;
			}

			// Token: 0x06010E6D RID: 69229 RVA: 0x00067EC0 File Offset: 0x000660C0
			[Token(Token = "0x6010E6D")]
			[Address(RVA = "0x8B4F00", Offset = "0x8B3B00", VA = "0x1808B4F00")]
			public int SetLegionGold(int value, PlayerSide side = PlayerSide.DEFAULT)
			{
				return 0;
			}

			// Token: 0x06010E6E RID: 69230 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E6E")]
			[Address(RVA = "0x8AE790", Offset = "0x8AD390", VA = "0x1808AE790")]
			public void AddLegionGold(int addValue, PlayerSide side = PlayerSide.DEFAULT)
			{
			}

			// Token: 0x06010E6F RID: 69231 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E6F")]
			[Address(RVA = "0x8B1B70", Offset = "0x8B0770", VA = "0x1808B1B70")]
			public void GetGoldViaProfessionBuffCount(Character source, int goldPerBuff)
			{
			}

			// Token: 0x06010E70 RID: 69232 RVA: 0x00067ED8 File Offset: 0x000660D8
			[Token(Token = "0x6010E70")]
			[Address(RVA = "0x8B1890", Offset = "0x8B0490", VA = "0x1808B1890")]
			public int GetCardsNumByType(LegionCardLibraryType cardType)
			{
				return 0;
			}

			// Token: 0x06010E71 RID: 69233 RVA: 0x00067EF0 File Offset: 0x000660F0
			[Token(Token = "0x6010E71")]
			[Address(RVA = "0x8B1C30", Offset = "0x8B0830", VA = "0x1808B1C30")]
			public int GetLegionDangerLevel()
			{
				return 0;
			}

			// Token: 0x06010E72 RID: 69234 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E72")]
			[Address(RVA = "0x8B4350", Offset = "0x8B2F50", VA = "0x1808B4350")]
			public void RefreshLegionModeDangerLevel(int level)
			{
			}

			// Token: 0x06010E73 RID: 69235 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010E73")]
			[Address(RVA = "0x8B1D70", Offset = "0x8B0970", VA = "0x1808B1D70")]
			public LegionCharacterStatusManager.LegionCharacterStatus GetOwnerStatus(Character character, bool initIfNull = false)
			{
				return null;
			}

			// Token: 0x06010E74 RID: 69236 RVA: 0x00067F08 File Offset: 0x00066108
			[Token(Token = "0x6010E74")]
			[Address(RVA = "0x8B4B00", Offset = "0x8B3700", VA = "0x1808B4B00")]
			public bool ReplaceCharacter(Character source, Character target)
			{
				return default(bool);
			}

			// Token: 0x06010E75 RID: 69237 RVA: 0x00067F20 File Offset: 0x00066120
			[Token(Token = "0x6010E75")]
			[Address(RVA = "0x8AF1C0", Offset = "0x8ADDC0", VA = "0x1808AF1C0")]
			public bool CheckCharacterNoOverlap(Character character)
			{
				return default(bool);
			}

			// Token: 0x06010E76 RID: 69238 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E76")]
			[Address(RVA = "0x8AE9E0", Offset = "0x8AD5E0", VA = "0x1808AE9E0")]
			public void AddTargetProfessionLevelDirectly(ProfessionCategory profession, Character target, int levelCount = 0)
			{
			}

			// Token: 0x06010E77 RID: 69239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E77")]
			[Address(RVA = "0x8AF420", Offset = "0x8AE020", VA = "0x1808AF420")]
			public void ClearTargetProfessionLevel(Character character)
			{
			}

			// Token: 0x06010E78 RID: 69240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E78")]
			[Address(RVA = "0x8B4900", Offset = "0x8B3500", VA = "0x1808B4900")]
			public void RefreshTargetProfessionBuff(Character character)
			{
			}

			// Token: 0x06010E79 RID: 69241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E79")]
			[Address(RVA = "0x8B27A0", Offset = "0x8B13A0", VA = "0x1808B27A0")]
			public void MarkCharReturnToHandAndKeepStatues(Character source, bool isRedrawOnReplace)
			{
			}

			// Token: 0x06010E7A RID: 69242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E7A")]
			[Address(RVA = "0x8B52F0", Offset = "0x8B3EF0", VA = "0x1808B52F0")]
			public void TemporaryAddEachProfessionStatus(Character target)
			{
			}

			// Token: 0x06010E7B RID: 69243 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E7B")]
			[Address(RVA = "0x8B0FD0", Offset = "0x8AFBD0", VA = "0x1808B0FD0")]
			public void FinishTemporaryProfessionStatus(Character target)
			{
			}

			// Token: 0x06010E7C RID: 69244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E7C")]
			[Address(RVA = "0x8B26A0", Offset = "0x8B12A0", VA = "0x1808B26A0")]
			public void MarkCardReturnToHand(Character source, bool needKeepStatus)
			{
			}

			// Token: 0x06010E7D RID: 69245 RVA: 0x00067F38 File Offset: 0x00066138
			[Token(Token = "0x6010E7D")]
			[Address(RVA = "0x8B1E20", Offset = "0x8B0A20", VA = "0x1808B1E20")]
			public int GetProfessionBuffMaxCnt(Character character)
			{
				return 0;
			}

			// Token: 0x06010E7E RID: 69246 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E7E")]
			[Address(RVA = "0x8B2A60", Offset = "0x8B1660", VA = "0x1808B2A60")]
			public void ModifyProfessionBuffMaxCnt(Character character, int addValue, bool isReset)
			{
			}

			// Token: 0x06010E7F RID: 69247 RVA: 0x00067F50 File Offset: 0x00066150
			[Token(Token = "0x6010E7F")]
			[Address(RVA = "0x8AF260", Offset = "0x8ADE60", VA = "0x1808AF260")]
			public bool CheckLastSelectCardsContainsProfessionCategory(ProfessionCategory profession)
			{
				return default(bool);
			}

			// Token: 0x06010E80 RID: 69248 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E80")]
			[Address(RVA = "0x8B29A0", Offset = "0x8B15A0", VA = "0x1808B29A0")]
			public void ModifyProfessionBuffDefaultAddCnt(Character character, int addValue, bool isReset)
			{
			}

			// Token: 0x06010E81 RID: 69249 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010E81")]
			[Address(RVA = "0x8B1AE0", Offset = "0x8B06E0", VA = "0x1808B1AE0")]
			public List<LegionModeProfessionBuffStatus> GetCharacterProfessionStatus(uint characterUid)
			{
				return null;
			}

			// Token: 0x06010E82 RID: 69250 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010E82")]
			[Address(RVA = "0x8B1A20", Offset = "0x8B0620", VA = "0x1808B1A20")]
			public List<LegionModeProfessionBuffStatus> GetCharacterProfessionStatusWithHighLight(Character fromTarget, Character toTarget, List<ProfessionCategory> hlList)
			{
				return null;
			}

			// Token: 0x06010E83 RID: 69251 RVA: 0x00067F68 File Offset: 0x00066168
			[Token(Token = "0x6010E83")]
			[Address(RVA = "0x8B1EB0", Offset = "0x8B0AB0", VA = "0x1808B1EB0")]
			public int GetProfessionBuffNum(Character character)
			{
				return 0;
			}

			// Token: 0x06010E84 RID: 69252 RVA: 0x00067F80 File Offset: 0x00066180
			[Token(Token = "0x6010E84")]
			[Address(RVA = "0x8B2080", Offset = "0x8B0C80", VA = "0x1808B2080")]
			public int GetStatusProfessionCnt(Character character)
			{
				return 0;
			}

			// Token: 0x06010E85 RID: 69253 RVA: 0x00067F98 File Offset: 0x00066198
			[Token(Token = "0x6010E85")]
			[Address(RVA = "0x8B1FD0", Offset = "0x8B0BD0", VA = "0x1808B1FD0")]
			public int GetSpecifiedProfessionStatusBuffCnt(Character character, ProfessionCategory queryProfession)
			{
				return 0;
			}

			// Token: 0x06010E86 RID: 69254 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010E86")]
			[Address(RVA = "0x8B0E20", Offset = "0x8AFA20", VA = "0x1808B0E20")]
			public Deck.Card FindUsingCardByUniqueId(uint uid)
			{
				return null;
			}

			// Token: 0x06010E87 RID: 69255 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E87")]
			[Address(RVA = "0x8B5F90", Offset = "0x8B4B90", VA = "0x1808B5F90")]
			private void _DoAnimForCardFullToHand(Deck.Card card)
			{
			}

			// Token: 0x06010E88 RID: 69256 RVA: 0x00067FB0 File Offset: 0x000661B0
			[Token(Token = "0x6010E88")]
			[Address(RVA = "0x8AEDC0", Offset = "0x8AD9C0", VA = "0x1808AEDC0")]
			public bool CheckCardIsInAllCardLibrary(Deck.Card card)
			{
				return default(bool);
			}

			// Token: 0x06010E89 RID: 69257 RVA: 0x00067FC8 File Offset: 0x000661C8
			[Token(Token = "0x6010E89")]
			[Address(RVA = "0x8AEF50", Offset = "0x8ADB50", VA = "0x1808AEF50")]
			public bool CheckCardIsInSomeCardLibrary(LegionCardLibraryType type, Deck.Card card)
			{
				return default(bool);
			}

			// Token: 0x06010E8A RID: 69258 RVA: 0x00067FE0 File Offset: 0x000661E0
			[Token(Token = "0x6010E8A")]
			[Address(RVA = "0x8AEEA0", Offset = "0x8ADAA0", VA = "0x1808AEEA0")]
			public bool CheckCardIsInOnlyCardLibrary(Deck.Card card)
			{
				return default(bool);
			}

			// Token: 0x06010E8B RID: 69259 RVA: 0x00067FF8 File Offset: 0x000661F8
			[Token(Token = "0x6010E8B")]
			[Address(RVA = "0x8AF060", Offset = "0x8ADC60", VA = "0x1808AF060")]
			public bool CheckCardIsUsing(Deck.Card card)
			{
				return default(bool);
			}

			// Token: 0x06010E8C RID: 69260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E8C")]
			[Address(RVA = "0x8B5D70", Offset = "0x8B4970", VA = "0x1808B5D70")]
			private void _CheckRefreshedTokenCardList()
			{
			}

			// Token: 0x06010E8D RID: 69261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E8D")]
			[Address(RVA = "0x8B5BC0", Offset = "0x8B47C0", VA = "0x1808B5BC0")]
			private void _CheckRedrawToHandCardList()
			{
			}

			// Token: 0x06010E8E RID: 69262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E8E")]
			[Address(RVA = "0x8B55A0", Offset = "0x8B41A0", VA = "0x1808B55A0")]
			private void _CheckBlastCardList()
			{
			}

			// Token: 0x06010E8F RID: 69263 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E8F")]
			[Address(RVA = "0x8B5870", Offset = "0x8B4470", VA = "0x1808B5870")]
			private void _CheckNeedRefillPendingFromUsed(bool isRedraw = false)
			{
			}

			// Token: 0x06010E90 RID: 69264 RVA: 0x00068010 File Offset: 0x00066210
			[Token(Token = "0x6010E90")]
			[Address(RVA = "0x8B56F0", Offset = "0x8B42F0", VA = "0x1808B56F0")]
			private bool _CheckNeedInitReShuffle(List<BattleCharacterData> dataList)
			{
				return default(bool);
			}

			// Token: 0x06010E91 RID: 69265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E91")]
			[Address(RVA = "0x8B71C0", Offset = "0x8B5DC0", VA = "0x1808B71C0")]
			private void _OnDrawNextCardByManualEvent()
			{
			}

			// Token: 0x06010E92 RID: 69266 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E92")]
			[Address(RVA = "0x8B7310", Offset = "0x8B5F10", VA = "0x1808B7310")]
			private void _OnRefreshCardEvent()
			{
			}

			// Token: 0x06010E93 RID: 69267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E93")]
			[Address(RVA = "0x8B7460", Offset = "0x8B6060", VA = "0x1808B7460")]
			private void _OnRefreshDangerLevelEvent()
			{
			}

			// Token: 0x06010E94 RID: 69268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E94")]
			[Address(RVA = "0x8B6D10", Offset = "0x8B5910", VA = "0x1808B6D10")]
			private void _LogDrawCardFromCardLibrary(Deck.Card rewardCard, string logKey)
			{
			}

			// Token: 0x06010E95 RID: 69269 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E95")]
			[Address(RVA = "0x8B6C10", Offset = "0x8B5810", VA = "0x1808B6C10")]
			private void _LogCurrentDangerLevel(int level)
			{
			}

			// Token: 0x06010E96 RID: 69270 RVA: 0x00068028 File Offset: 0x00066228
			[Token(Token = "0x6010E96")]
			[Address(RVA = "0x85AC60", Offset = "0x859860", VA = "0x18085AC60")]
			private bool <>xLuaBaseProxy_get_hasExtraBuildCondition()
			{
				return default(bool);
			}

			// Token: 0x06010E97 RID: 69271 RVA: 0x00068040 File Offset: 0x00066240
			[Token(Token = "0x6010E97")]
			[Address(RVA = "0x83EAA0", Offset = "0x83D6A0", VA = "0x18083EAA0")]
			private GameModeMeta.GameModeType <>xLuaBaseProxy_get_gameModeType()
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}

			// Token: 0x06010E98 RID: 69272 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E98")]
			[Address(RVA = "0x867A00", Offset = "0x866600", VA = "0x180867A00")]
			private void <>xLuaBaseProxy_PreprocessPlayerData(List<BattlePlayerData> P0)
			{
			}

			// Token: 0x06010E99 RID: 69273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E99")]
			[Address(RVA = "0x8B5590", Offset = "0x8B4190", VA = "0x1808B5590")]
			private void <>xLuaBaseProxy_PreprocessPlayerDeckList(ListDict<PlayerSide, Deck> P0)
			{
			}

			// Token: 0x06010E9A RID: 69274 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E9A")]
			[Address(RVA = "0x85ABD0", Offset = "0x8597D0", VA = "0x18085ABD0")]
			private void <>xLuaBaseProxy_OnPostInit()
			{
			}

			// Token: 0x06010E9B RID: 69275 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010E9B")]
			[Address(RVA = "0x8B5580", Offset = "0x8B4180", VA = "0x1808B5580")]
			private LevelData.Options <>xLuaBaseProxy_PostprocessLevelOptions(LevelData.Options P0)
			{
				return null;
			}

			// Token: 0x06010E9C RID: 69276 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E9C")]
			[Address(RVA = "0x85E9F0", Offset = "0x85D5F0", VA = "0x18085E9F0")]
			private void <>xLuaBaseProxy_OnWaveWillStart(LevelData.WaveData P0)
			{
			}

			// Token: 0x06010E9D RID: 69277 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010E9D")]
			[Address(RVA = "0x8B5570", Offset = "0x8B4170", VA = "0x1808B5570")]
			private void <>xLuaBaseProxy_ParseBattleEvents(LevelData.WaveData.FragmentData.ActionData P0)
			{
			}

			// Token: 0x06010E9E RID: 69278 RVA: 0x00068058 File Offset: 0x00066258
			[Token(Token = "0x6010E9E")]
			[Address(RVA = "0x85AAD0", Offset = "0x8596D0", VA = "0x18085AAD0")]
			private bool <>xLuaBaseProxy_CheckBuildable(BuildCondition P0, Tile P1, SharedConsts.Direction P2, bool P3, bool P4, BattleCharacterData P5, PlayerSide P6)
			{
				return default(bool);
			}

			// Token: 0x06010E9F RID: 69279 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010E9F")]
			[Address(RVA = "0x83EA70", Offset = "0x83D670", VA = "0x18083EA70")]
			private Scheduler.SchedulerPreprocessor <>xLuaBaseProxy_GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x06010EA0 RID: 69280 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010EA0")]
			[Address(RVA = "0x867940", Offset = "0x866540", VA = "0x180867940")]
			private List<LevelData.GlobalBuffData> <>xLuaBaseProxy_GatherGlobalBuffs()
			{
				return null;
			}

			// Token: 0x06010EA1 RID: 69281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010EA1")]
			[Address(RVA = "0x83EA80", Offset = "0x83D680", VA = "0x18083EA80")]
			private void <>xLuaBaseProxy_Init(ref GameModeMeta P0, ref int P1, BattlePlayerData P2, LevelData P3)
			{
			}

			// Token: 0x06010EA2 RID: 69282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010EA2")]
			[Address(RVA = "0x83EA90", Offset = "0x83D690", VA = "0x18083EA90")]
			private void <>xLuaBaseProxy_Tick(Action P0)
			{
			}

			// Token: 0x06010EA3 RID: 69283 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010EA3")]
			[Address(RVA = "0x858C90", Offset = "0x857890", VA = "0x180858C90")]
			private void <>xLuaBaseProxy_OnCharacterFinished(Character P0, Entity.FinishReason P1)
			{
			}

			// Token: 0x06010EA4 RID: 69284 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010EA4")]
			[Address(RVA = "0x867980", Offset = "0x866580", VA = "0x180867980")]
			private void <>xLuaBaseProxy_OnCardListChanged(Deck.Card P0)
			{
			}

			// Token: 0x06010EA5 RID: 69285 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010EA5")]
			[Address(RVA = "0x8B5560", Offset = "0x8B4160", VA = "0x1808B5560")]
			private void <>xLuaBaseProxy_OnCardRecycle(Deck.Card P0)
			{
			}

			// Token: 0x06010EA6 RID: 69286 RVA: 0x00068070 File Offset: 0x00066270
			[Token(Token = "0x6010EA6")]
			[Address(RVA = "0x867930", Offset = "0x866530", VA = "0x180867930")]
			private bool <>xLuaBaseProxy_CheckCardReadyToSpawn(Deck.Card P0)
			{
				return default(bool);
			}

			// Token: 0x04012EF3 RID: 77555
			[Token(Token = "0x4012EF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private readonly LegionInput m_input;

			// Token: 0x04012EF4 RID: 77556
			[Token(Token = "0x4012EF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private readonly ListDict<PlayerSide, ObscuredInt> m_legionGoldDict;

			// Token: 0x04012EF5 RID: 77557
			[Token(Token = "0x4012EF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private readonly List<BattleCharacterData> m_preLocatedCharacterCardList;

			// Token: 0x04012EF6 RID: 77558
			[Token(Token = "0x4012EF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private readonly List<Deck.Card> m_usingCharacterCardList;

			// Token: 0x04012EF7 RID: 77559
			[Token(Token = "0x4012EF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private readonly List<Deck.Card> m_pendingCharacterCardList;

			// Token: 0x04012EF8 RID: 77560
			[Token(Token = "0x4012EF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private readonly List<Deck.Card> m_usedCharacterCardList;

			// Token: 0x04012EF9 RID: 77561
			[Token(Token = "0x4012EF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private int m_currentCardPrice;

			// Token: 0x04012EFA RID: 77562
			[Token(Token = "0x4012EFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private int m_drawCardFromLibLogIndex;

			// Token: 0x04012EFB RID: 77563
			[Token(Token = "0x4012EFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private int m_currentDangerLevel;

			// Token: 0x04012EFC RID: 77564
			[Token(Token = "0x4012EFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private int m_addPriceWhenReShuffle;

			// Token: 0x04012EFD RID: 77565
			[Token(Token = "0x4012EFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool m_hasReshuffled;

			// Token: 0x04012EFE RID: 77566
			[Token(Token = "0x4012EFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
			private bool m_needShowAddPrice;

			// Token: 0x04012EFF RID: 77567
			[Token(Token = "0x4012EFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private int m_allCharacterCardCnt;

			// Token: 0x04012F00 RID: 77568
			[Token(Token = "0x4012F00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Deck.Card m_cachedCardLastDraw;

			// Token: 0x04012F01 RID: 77569
			[Token(Token = "0x4012F01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private readonly List<Deck.Card> m_redrawToHandCharacterCardList;

			// Token: 0x04012F02 RID: 77570
			[Token(Token = "0x4012F02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private readonly List<Deck.TokenCard> m_refreshedTokenCardList;

			// Token: 0x04012F03 RID: 77571
			[Token(Token = "0x4012F03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private readonly List<Deck.Card> m_cachedBlastCardList;

			// Token: 0x04012F04 RID: 77572
			[Token(Token = "0x4012F04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private readonly List<Deck.Card> m_rewardCardList;

			// Token: 0x04012F05 RID: 77573
			[Token(Token = "0x4012F05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private readonly List<Deck.Card> m_discardCardCardList;

			// Token: 0x04012F06 RID: 77574
			[Token(Token = "0x4012F06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private readonly List<Deck.Card> m_lastSelectCharacterCardList;

			// Token: 0x04012F07 RID: 77575
			[Token(Token = "0x4012F07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private readonly List<uint> m_useOnlyOnceCardUIDList;

			// Token: 0x04012F08 RID: 77576
			[Token(Token = "0x4012F08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private readonly List<BattleCharacterData> m_characterDataOrderList;

			// Token: 0x04012F09 RID: 77577
			[Token(Token = "0x4012F09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private readonly List<BattleCharacterData> m_preGivenTokenList;

			// Token: 0x04012F0A RID: 77578
			[Token(Token = "0x4012F0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public GameModeFactory.LegionGameMode.LegionModeSettings gameSettings;

			// Token: 0x04012F0B RID: 77579
			[Token(Token = "0x4012F0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public Action<LegionModeOnCardFullParam> onCardFullPutToUsed;

			// Token: 0x04012F0C RID: 77580
			[Token(Token = "0x4012F0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public Action onWaveWillStart;

			// Token: 0x04012F0D RID: 77581
			[Token(Token = "0x4012F0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private readonly List<LevelData.GlobalBuffData> m_globalBuffs;

			// Token: 0x04012F0E RID: 77582
			[Token(Token = "0x4012F0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private LegionCharacterStatusManager m_charStatusManager;

			// Token: 0x04012F0F RID: 77583
			[Token(Token = "0x4012F0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private List<Character> m_bannedOverlapList;

			// Token: 0x04012F10 RID: 77584
			[Token(Token = "0x4012F10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private List<Deck.Card> m_getCardLibraryByTypeResult;

			// Token: 0x04012F11 RID: 77585
			[Token(Token = "0x4012F11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04012F12 RID: 77586
			[Token(Token = "0x4012F12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_maxProfessionBuffCount;

			// Token: 0x04012F13 RID: 77587
			[Token(Token = "0x4012F13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_professionLevelAdd;

			// Token: 0x04012F14 RID: 77588
			[Token(Token = "0x4012F14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_usedCardCount;

			// Token: 0x04012F15 RID: 77589
			[Token(Token = "0x4012F15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_remainingCardCount;

			// Token: 0x04012F16 RID: 77590
			[Token(Token = "0x4012F16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_needPlayReshuffle;

			// Token: 0x04012F17 RID: 77591
			[Token(Token = "0x4012F17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_needPlayReshuffle;

			// Token: 0x04012F18 RID: 77592
			[Token(Token = "0x4012F18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_goldForEndPrepare;

			// Token: 0x04012F19 RID: 77593
			[Token(Token = "0x4012F19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_goldForWaveEnd;

			// Token: 0x04012F1A RID: 77594
			[Token(Token = "0x4012F1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_initRedrawCount;

			// Token: 0x04012F1B RID: 77595
			[Token(Token = "0x4012F1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_ingameRedrawCount;

			// Token: 0x04012F1C RID: 77596
			[Token(Token = "0x4012F1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_inHandCardCount;

			// Token: 0x04012F1D RID: 77597
			[Token(Token = "0x4012F1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_maxCardCount;

			// Token: 0x04012F1E RID: 77598
			[Token(Token = "0x4012F1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_ableToDrawNextCard;

			// Token: 0x04012F1F RID: 77599
			[Token(Token = "0x4012F1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_handCardNotFull;

			// Token: 0x04012F20 RID: 77600
			[Token(Token = "0x4012F20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_get_currentGoldEnough;

			// Token: 0x04012F21 RID: 77601
			[Token(Token = "0x4012F21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_get_addPriceWhenReshuffle;

			// Token: 0x04012F22 RID: 77602
			[Token(Token = "0x4012F22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_get_showAddPriceWhenReshuffle;

			// Token: 0x04012F23 RID: 77603
			[Token(Token = "0x4012F23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_get_currentCardPrice;

			// Token: 0x04012F24 RID: 77604
			[Token(Token = "0x4012F24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_set_currentCardPrice;

			// Token: 0x04012F25 RID: 77605
			[Token(Token = "0x4012F25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_get_currentGold;

			// Token: 0x04012F26 RID: 77606
			[Token(Token = "0x4012F26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_set_currentGold;

			// Token: 0x04012F27 RID: 77607
			[Token(Token = "0x4012F27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_get_cachedCardLastDraw;

			// Token: 0x04012F28 RID: 77608
			[Token(Token = "0x4012F28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_GetCardLibraryByType;

			// Token: 0x04012F29 RID: 77609
			[Token(Token = "0x4012F29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_ShuffleAllPendingAndUsedCards;

			// Token: 0x04012F2A RID: 77610
			[Token(Token = "0x4012F2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0__OnCardPutToHand;

			// Token: 0x04012F2B RID: 77611
			[Token(Token = "0x4012F2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0__DrawCardToHand;

			// Token: 0x04012F2C RID: 77612
			[Token(Token = "0x4012F2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0__DrawCardToHandDirectly;

			// Token: 0x04012F2D RID: 77613
			[Token(Token = "0x4012F2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0__DrawCardsFromPendingToHand;

			// Token: 0x04012F2E RID: 77614
			[Token(Token = "0x4012F2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0__DrawCardFromPendingToHand;

			// Token: 0x04012F2F RID: 77615
			[Token(Token = "0x4012F2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private static DelegateBridge __Hotfix0__PickDifferentKindCard;

			// Token: 0x04012F30 RID: 77616
			[Token(Token = "0x4012F30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private static DelegateBridge __Hotfix0__PickCardBySpecificKeys;

			// Token: 0x04012F31 RID: 77617
			[Token(Token = "0x4012F31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			private static DelegateBridge __Hotfix0_SelectCardToHandFromOtherLibrary;

			// Token: 0x04012F32 RID: 77618
			[Token(Token = "0x4012F32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private static DelegateBridge __Hotfix0_RefreshSelectCardList;

			// Token: 0x04012F33 RID: 77619
			[Token(Token = "0x4012F33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private static DelegateBridge __Hotfix0_DrawCardFromCardLibrary;

			// Token: 0x04012F34 RID: 77620
			[Token(Token = "0x4012F34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private static DelegateBridge __Hotfix0_AddProfessionLevelFromLastSelectCards;

			// Token: 0x04012F35 RID: 77621
			[Token(Token = "0x4012F35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private static DelegateBridge __Hotfix0_DrawNextCard;

			// Token: 0x04012F36 RID: 77622
			[Token(Token = "0x4012F36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private static DelegateBridge __Hotfix0_DrawNextProfessionCard;

			// Token: 0x04012F37 RID: 77623
			[Token(Token = "0x4012F37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private static DelegateBridge __Hotfix1_DrawNextProfessionCard;

			// Token: 0x04012F38 RID: 77624
			[Token(Token = "0x4012F38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private static DelegateBridge __Hotfix0__PutCardToUsed;

			// Token: 0x04012F39 RID: 77625
			[Token(Token = "0x4012F39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private static DelegateBridge __Hotfix0__PutCardToPending;

			// Token: 0x04012F3A RID: 77626
			[Token(Token = "0x4012F3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			private static DelegateBridge __Hotfix0__UpdateCharacterCardCnt;

			// Token: 0x04012F3B RID: 77627
			[Token(Token = "0x4012F3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			private static DelegateBridge __Hotfix0__PutCardToDiscard;

			// Token: 0x04012F3C RID: 77628
			[Token(Token = "0x4012F3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			private static DelegateBridge __Hotfix0__ReleaseFromDiscardLibraryIfNeed;

			// Token: 0x04012F3D RID: 77629
			[Token(Token = "0x4012F3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			private static DelegateBridge __Hotfix0__PutCardToBlastCardList;

			// Token: 0x04012F3E RID: 77630
			[Token(Token = "0x4012F3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private static DelegateBridge __Hotfix0__RedrawCardToHandNextTick;

			// Token: 0x04012F3F RID: 77631
			[Token(Token = "0x4012F3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			private static DelegateBridge __Hotfix0_ForceRecycleCard;

			// Token: 0x04012F40 RID: 77632
			[Token(Token = "0x4012F40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private static DelegateBridge __Hotfix0_DiscardCardFromLibrary;

			// Token: 0x04012F41 RID: 77633
			[Token(Token = "0x4012F41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
			private static DelegateBridge __Hotfix0_GainCardToLibrary;

			// Token: 0x04012F42 RID: 77634
			[Token(Token = "0x4012F42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private static DelegateBridge __Hotfix0_DrawCardFromLibraryViaTag;

			// Token: 0x04012F43 RID: 77635
			[Token(Token = "0x4012F43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
			private static DelegateBridge __Hotfix0_DrawCardFromLibraryViaId;

			// Token: 0x04012F44 RID: 77636
			[Token(Token = "0x4012F44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private static DelegateBridge __Hotfix0_RedrawCards;

			// Token: 0x04012F45 RID: 77637
			[Token(Token = "0x4012F45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
			private static DelegateBridge __Hotfix0_SetCardUseOnlyOnce;

			// Token: 0x04012F46 RID: 77638
			[Token(Token = "0x4012F46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private static DelegateBridge __Hotfix0_PutCardToUsed;

			// Token: 0x04012F47 RID: 77639
			[Token(Token = "0x4012F47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
			private static DelegateBridge __Hotfix0_ModifyCharacterOverlapState;

			// Token: 0x04012F48 RID: 77640
			[Token(Token = "0x4012F48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private static DelegateBridge __Hotfix0_ReleaseDiscardCardByKey;

			// Token: 0x04012F49 RID: 77641
			[Token(Token = "0x4012F49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
			private static DelegateBridge __Hotfix0__SetCardHidden;

			// Token: 0x04012F4A RID: 77642
			[Token(Token = "0x4012F4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private static DelegateBridge __Hotfix0_get_hasExtraBuildCondition;

			// Token: 0x04012F4B RID: 77643
			[Token(Token = "0x4012F4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
			private static DelegateBridge __Hotfix0_get_gameModeType;

			// Token: 0x04012F4C RID: 77644
			[Token(Token = "0x4012F4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private static DelegateBridge __Hotfix0_PreprocessPlayerData;

			// Token: 0x04012F4D RID: 77645
			[Token(Token = "0x4012F4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private static DelegateBridge __Hotfix0_PreprocessPlayerDeckList;

			// Token: 0x04012F4E RID: 77646
			[Token(Token = "0x4012F4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private static DelegateBridge __Hotfix0_OnPostInit;

			// Token: 0x04012F4F RID: 77647
			[Token(Token = "0x4012F4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private static DelegateBridge __Hotfix0_PostprocessLevelOptions;

			// Token: 0x04012F50 RID: 77648
			[Token(Token = "0x4012F50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private static DelegateBridge __Hotfix0__ProcessLevelConfig;

			// Token: 0x04012F51 RID: 77649
			[Token(Token = "0x4012F51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private static DelegateBridge __Hotfix0_OnWaveWillStart;

			// Token: 0x04012F52 RID: 77650
			[Token(Token = "0x4012F52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private static DelegateBridge __Hotfix0_ParseBattleEvents;

			// Token: 0x04012F53 RID: 77651
			[Token(Token = "0x4012F53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private static DelegateBridge __Hotfix0_CheckBuildable;

			// Token: 0x04012F54 RID: 77652
			[Token(Token = "0x4012F54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private static DelegateBridge __Hotfix0_GetSchedulerPreprocessor;

			// Token: 0x04012F55 RID: 77653
			[Token(Token = "0x4012F55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
			private static DelegateBridge __Hotfix0_GatherGlobalBuffs;

			// Token: 0x04012F56 RID: 77654
			[Token(Token = "0x4012F56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x04012F57 RID: 77655
			[Token(Token = "0x4012F57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
			private static DelegateBridge __Hotfix0_Tick;

			// Token: 0x04012F58 RID: 77656
			[Token(Token = "0x4012F58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
			private static DelegateBridge __Hotfix0_OnCharacterFinished;

			// Token: 0x04012F59 RID: 77657
			[Token(Token = "0x4012F59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
			private static DelegateBridge __Hotfix0_OnCardListChanged;

			// Token: 0x04012F5A RID: 77658
			[Token(Token = "0x4012F5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
			private static DelegateBridge __Hotfix0_OnCardRecycle;

			// Token: 0x04012F5B RID: 77659
			[Token(Token = "0x4012F5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
			private static DelegateBridge __Hotfix0__OnCardRecycle;

			// Token: 0x04012F5C RID: 77660
			[Token(Token = "0x4012F5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
			private static DelegateBridge __Hotfix0_CheckCardReadyToSpawn;

			// Token: 0x04012F5D RID: 77661
			[Token(Token = "0x4012F5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
			private static DelegateBridge __Hotfix0_GatherPreloadAssets;

			// Token: 0x04012F5E RID: 77662
			[Token(Token = "0x4012F5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
			private static DelegateBridge __Hotfix0__GetPreGivenTokens;

			// Token: 0x04012F5F RID: 77663
			[Token(Token = "0x4012F5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
			private static DelegateBridge __Hotfix0_ShowStatusMessage;

			// Token: 0x04012F60 RID: 77664
			[Token(Token = "0x4012F60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
			private static DelegateBridge __Hotfix0_GetLegionGold;

			// Token: 0x04012F61 RID: 77665
			[Token(Token = "0x4012F61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
			private static DelegateBridge __Hotfix0_SetLegionGold;

			// Token: 0x04012F62 RID: 77666
			[Token(Token = "0x4012F62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
			private static DelegateBridge __Hotfix0_AddLegionGold;

			// Token: 0x04012F63 RID: 77667
			[Token(Token = "0x4012F63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
			private static DelegateBridge __Hotfix0_GetGoldViaProfessionBuffCount;

			// Token: 0x04012F64 RID: 77668
			[Token(Token = "0x4012F64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
			private static DelegateBridge __Hotfix0_GetCardsNumByType;

			// Token: 0x04012F65 RID: 77669
			[Token(Token = "0x4012F65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
			private static DelegateBridge __Hotfix0_GetLegionDangerLevel;

			// Token: 0x04012F66 RID: 77670
			[Token(Token = "0x4012F66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
			private static DelegateBridge __Hotfix0_RefreshLegionModeDangerLevel;

			// Token: 0x04012F67 RID: 77671
			[Token(Token = "0x4012F67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
			private static DelegateBridge __Hotfix0_GetOwnerStatus;

			// Token: 0x04012F68 RID: 77672
			[Token(Token = "0x4012F68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
			private static DelegateBridge __Hotfix0_ReplaceCharacter;

			// Token: 0x04012F69 RID: 77673
			[Token(Token = "0x4012F69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
			private static DelegateBridge __Hotfix0_CheckCharacterNoOverlap;

			// Token: 0x04012F6A RID: 77674
			[Token(Token = "0x4012F6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
			private static DelegateBridge __Hotfix0_AddTargetProfessionLevelDirectly;

			// Token: 0x04012F6B RID: 77675
			[Token(Token = "0x4012F6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
			private static DelegateBridge __Hotfix0_ClearTargetProfessionLevel;

			// Token: 0x04012F6C RID: 77676
			[Token(Token = "0x4012F6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
			private static DelegateBridge __Hotfix0_RefreshTargetProfessionBuff;

			// Token: 0x04012F6D RID: 77677
			[Token(Token = "0x4012F6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
			private static DelegateBridge __Hotfix0_MarkCharReturnToHandAndKeepStatues;

			// Token: 0x04012F6E RID: 77678
			[Token(Token = "0x4012F6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
			private static DelegateBridge __Hotfix0_TemporaryAddEachProfessionStatus;

			// Token: 0x04012F6F RID: 77679
			[Token(Token = "0x4012F6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
			private static DelegateBridge __Hotfix0_FinishTemporaryProfessionStatus;

			// Token: 0x04012F70 RID: 77680
			[Token(Token = "0x4012F70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
			private static DelegateBridge __Hotfix0_MarkCardReturnToHand;

			// Token: 0x04012F71 RID: 77681
			[Token(Token = "0x4012F71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
			private static DelegateBridge __Hotfix0_GetProfessionBuffMaxCnt;

			// Token: 0x04012F72 RID: 77682
			[Token(Token = "0x4012F72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
			private static DelegateBridge __Hotfix0_ModifyProfessionBuffMaxCnt;

			// Token: 0x04012F73 RID: 77683
			[Token(Token = "0x4012F73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
			private static DelegateBridge __Hotfix0_CheckLastSelectCardsContainsProfessionCategory;

			// Token: 0x04012F74 RID: 77684
			[Token(Token = "0x4012F74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
			private static DelegateBridge __Hotfix0_ModifyProfessionBuffDefaultAddCnt;

			// Token: 0x04012F75 RID: 77685
			[Token(Token = "0x4012F75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
			private static DelegateBridge __Hotfix0_GetCharacterProfessionStatus;

			// Token: 0x04012F76 RID: 77686
			[Token(Token = "0x4012F76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
			private static DelegateBridge __Hotfix0_GetCharacterProfessionStatusWithHighLight;

			// Token: 0x04012F77 RID: 77687
			[Token(Token = "0x4012F77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
			private static DelegateBridge __Hotfix0_GetProfessionBuffNum;

			// Token: 0x04012F78 RID: 77688
			[Token(Token = "0x4012F78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
			private static DelegateBridge __Hotfix0_GetStatusProfessionCnt;

			// Token: 0x04012F79 RID: 77689
			[Token(Token = "0x4012F79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
			private static DelegateBridge __Hotfix0_GetSpecifiedProfessionStatusBuffCnt;

			// Token: 0x04012F7A RID: 77690
			[Token(Token = "0x4012F7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
			private static DelegateBridge __Hotfix0_FindUsingCardByUniqueId;

			// Token: 0x04012F7B RID: 77691
			[Token(Token = "0x4012F7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
			private static DelegateBridge __Hotfix0__DoAnimForCardFullToHand;

			// Token: 0x04012F7C RID: 77692
			[Token(Token = "0x4012F7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
			private static DelegateBridge __Hotfix0_CheckCardIsInAllCardLibrary;

			// Token: 0x04012F7D RID: 77693
			[Token(Token = "0x4012F7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
			private static DelegateBridge __Hotfix0_CheckCardIsInSomeCardLibrary;

			// Token: 0x04012F7E RID: 77694
			[Token(Token = "0x4012F7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
			private static DelegateBridge __Hotfix0_CheckCardIsInOnlyCardLibrary;

			// Token: 0x04012F7F RID: 77695
			[Token(Token = "0x4012F7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
			private static DelegateBridge __Hotfix0_CheckCardIsUsing;

			// Token: 0x04012F80 RID: 77696
			[Token(Token = "0x4012F80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
			private static DelegateBridge __Hotfix0__CheckRefreshedTokenCardList;

			// Token: 0x04012F81 RID: 77697
			[Token(Token = "0x4012F81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
			private static DelegateBridge __Hotfix0__CheckRedrawToHandCardList;

			// Token: 0x04012F82 RID: 77698
			[Token(Token = "0x4012F82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
			private static DelegateBridge __Hotfix0__CheckBlastCardList;

			// Token: 0x04012F83 RID: 77699
			[Token(Token = "0x4012F83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
			private static DelegateBridge __Hotfix0__CheckNeedRefillPendingFromUsed;

			// Token: 0x04012F84 RID: 77700
			[Token(Token = "0x4012F84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
			private static DelegateBridge __Hotfix0__CheckNeedInitReShuffle;

			// Token: 0x04012F85 RID: 77701
			[Token(Token = "0x4012F85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
			private static DelegateBridge __Hotfix0__OnDrawNextCardByManualEvent;

			// Token: 0x04012F86 RID: 77702
			[Token(Token = "0x4012F86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
			private static DelegateBridge __Hotfix0__OnRefreshCardEvent;

			// Token: 0x04012F87 RID: 77703
			[Token(Token = "0x4012F87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
			private static DelegateBridge __Hotfix0__OnRefreshDangerLevelEvent;

			// Token: 0x04012F88 RID: 77704
			[Token(Token = "0x4012F88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
			private static DelegateBridge __Hotfix0__LogDrawCardFromCardLibrary;

			// Token: 0x04012F89 RID: 77705
			[Token(Token = "0x4012F89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
			private static DelegateBridge __Hotfix0__LogCurrentDangerLevel;

			// Token: 0x020027E6 RID: 10214
			[Token(Token = "0x20027E6")]
			public class LegionModeSettings
			{
				// Token: 0x06010EA7 RID: 69287 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010EA7")]
				[Address(RVA = "0x8B9E20", Offset = "0x8B8A20", VA = "0x1808B9E20")]
				public void Init(LegionInput input)
				{
				}

				// Token: 0x06010EA8 RID: 69288 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010EA8")]
				[Address(RVA = "0x8BA2B0", Offset = "0x8B8EB0", VA = "0x1808BA2B0")]
				public LegionModeSettings()
				{
				}

				// Token: 0x04012F8A RID: 77706
				[Token(Token = "0x4012F8A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public Dictionary<ProfessionCategory, int> professionBuffPartDict;

				// Token: 0x04012F8B RID: 77707
				[Token(Token = "0x4012F8B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public readonly HashSet<ProfessionCategory> inheritableBuffProfession;

				// Token: 0x04012F8C RID: 77708
				[Token(Token = "0x4012F8C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public readonly Dictionary<ProfessionCategory, Blackboard> redrawOnReplaceProfession;

				// Token: 0x04012F8D RID: 77709
				[Token(Token = "0x4012F8D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public readonly HashSet<uint> redrawTargetsToHand;
			}
		}

		// Token: 0x020027EF RID: 10223
		[Token(Token = "0x20027EF")]
		private class MultiplayerGameMode : GameModeFactory.DefaultGameMode, IMultiplayerGameMode, IGameMode, IHotfixable
		{
			// Token: 0x1700252E RID: 9518
			// (get) Token: 0x06010EBD RID: 69309 RVA: 0x00068130 File Offset: 0x00066330
			// (set) Token: 0x06010EBE RID: 69310 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700252E")]
			private GameModeFactory.MultiplayerGameMode.InternalState state
			{
				[Token(Token = "0x6010EBD")]
				[Address(RVA = "0x8BB660", Offset = "0x8BA260", VA = "0x1808BB660")]
				get
				{
					return GameModeFactory.MultiplayerGameMode.InternalState.NONE;
				}
				[Token(Token = "0x6010EBE")]
				[Address(RVA = "0x8BB710", Offset = "0x8BA310", VA = "0x1808BB710")]
				set
				{
				}
			}

			// Token: 0x06010EBF RID: 69311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010EBF")]
			[Address(RVA = "0x8BB290", Offset = "0x8B9E90", VA = "0x1808BB290")]
			public MultiplayerGameMode(ref GameModeMeta meta)
			{
			}

			// Token: 0x1700252F RID: 9519
			// (get) Token: 0x06010EC0 RID: 69312 RVA: 0x00068148 File Offset: 0x00066348
			[Token(Token = "0x1700252F")]
			public override bool allowManualTick
			{
				[Token(Token = "0x6010EC0")]
				[Address(RVA = "0x8BB350", Offset = "0x8B9F50", VA = "0x1808BB350", Slot = "103")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002530 RID: 9520
			// (get) Token: 0x06010EC1 RID: 69313 RVA: 0x00068160 File Offset: 0x00066360
			[Token(Token = "0x17002530")]
			public override bool isOnline
			{
				[Token(Token = "0x6010EC1")]
				[Address(RVA = "0x8BB4D0", Offset = "0x8BA0D0", VA = "0x1808BB4D0", Slot = "104")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002531 RID: 9521
			// (get) Token: 0x06010EC2 RID: 69314 RVA: 0x00068178 File Offset: 0x00066378
			[Token(Token = "0x17002531")]
			public override bool isLargeMap
			{
				[Token(Token = "0x6010EC2")]
				[Address(RVA = "0x8BB410", Offset = "0x8BA010", VA = "0x1808BB410", Slot = "105")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002532 RID: 9522
			// (get) Token: 0x06010EC3 RID: 69315 RVA: 0x00068190 File Offset: 0x00066390
			[Token(Token = "0x17002532")]
			public override bool isLowMemoryGameMode
			{
				[Token(Token = "0x6010EC3")]
				[Address(RVA = "0x8BB470", Offset = "0x8BA070", VA = "0x1808BB470", Slot = "110")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002533 RID: 9523
			// (get) Token: 0x06010EC4 RID: 69316 RVA: 0x000681A8 File Offset: 0x000663A8
			[Token(Token = "0x17002533")]
			public override GameModeMeta.GameModeType gameModeType
			{
				[Token(Token = "0x6010EC4")]
				[Address(RVA = "0x8BB3B0", Offset = "0x8B9FB0", VA = "0x1808BB3B0", Slot = "119")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x06010EC5 RID: 69317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010EC5")]
			[Address(RVA = "0x8BAB70", Offset = "0x8B9770", VA = "0x1808BAB70", Slot = "122")]
			public override void Init(ref GameModeMeta meta, ref int randomSeed, BattlePlayerData playerData, LevelData levelData)
			{
			}

			// Token: 0x06010EC6 RID: 69318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010EC6")]
			[Address(RVA = "0x8BAF80", Offset = "0x8B9B80", VA = "0x1808BAF80", Slot = "124")]
			public override void StartGame(Action doDefaultStart)
			{
			}

			// Token: 0x06010EC7 RID: 69319 RVA: 0x000681C0 File Offset: 0x000663C0
			[Token(Token = "0x6010EC7")]
			[Address(RVA = "0x8BA9C0", Offset = "0x8B95C0", VA = "0x1808BA9C0", Slot = "129")]
			public override bool HookPlayerOp_Withdraw(Character character)
			{
				return default(bool);
			}

			// Token: 0x06010EC8 RID: 69320 RVA: 0x000681D8 File Offset: 0x000663D8
			[Token(Token = "0x6010EC8")]
			[Address(RVA = "0x8BA6A0", Offset = "0x8B92A0", VA = "0x1808BA6A0", Slot = "130")]
			public override bool HookPlayerOp_Spawn(uint uniqueId, SharedConsts.Direction direction, Tile tile)
			{
				return default(bool);
			}

			// Token: 0x06010EC9 RID: 69321 RVA: 0x000681F0 File Offset: 0x000663F0
			[Token(Token = "0x6010EC9")]
			[Address(RVA = "0x8BA880", Offset = "0x8B9480", VA = "0x1808BA880", Slot = "131")]
			public override bool HookPlayerOp_TrigSkill(Character character)
			{
				return default(bool);
			}

			// Token: 0x06010ECA RID: 69322 RVA: 0x00068208 File Offset: 0x00066408
			[Token(Token = "0x6010ECA")]
			[Address(RVA = "0x8BAB00", Offset = "0x8B9700", VA = "0x1808BAB00", Slot = "159")]
			public override SpeedLevel HookSpeedLevel(SpeedLevel originSpeedLevel)
			{
				return SpeedLevel.SLOW_MOTION;
			}

			// Token: 0x17002534 RID: 9524
			// (get) Token: 0x06010ECB RID: 69323 RVA: 0x00068220 File Offset: 0x00066420
			[Token(Token = "0x17002534")]
			public bool isPrepared
			{
				[Token(Token = "0x6010ECB")]
				[Address(RVA = "0x8BB590", Offset = "0x8BA190", VA = "0x1808BB590", Slot = "208")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002535 RID: 9525
			// (get) Token: 0x06010ECC RID: 69324 RVA: 0x00068238 File Offset: 0x00066438
			[Token(Token = "0x17002535")]
			public bool isRunning
			{
				[Token(Token = "0x6010ECC")]
				[Address(RVA = "0x8BB5F0", Offset = "0x8BA1F0", VA = "0x1808BB5F0", Slot = "209")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002536 RID: 9526
			// (get) Token: 0x06010ECD RID: 69325 RVA: 0x00068250 File Offset: 0x00066450
			[Token(Token = "0x17002536")]
			public bool isPlaying
			{
				[Token(Token = "0x6010ECD")]
				[Address(RVA = "0x8BB530", Offset = "0x8BA130", VA = "0x1808BB530")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06010ECE RID: 69326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010ECE")]
			[Address(RVA = "0x8BAEC0", Offset = "0x8B9AC0", VA = "0x1808BAEC0", Slot = "203")]
			public void SetReady()
			{
			}

			// Token: 0x06010ECF RID: 69327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010ECF")]
			[Address(RVA = "0x8BAE60", Offset = "0x8B9A60", VA = "0x1808BAE60", Slot = "202")]
			public void SetPrepared()
			{
			}

			// Token: 0x06010ED0 RID: 69328 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010ED0")]
			[Address(RVA = "0x8BAE00", Offset = "0x8B9A00", VA = "0x1808BAE00", Slot = "204")]
			public void SetPlaying()
			{
			}

			// Token: 0x06010ED1 RID: 69329 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010ED1")]
			[Address(RVA = "0x8BAF20", Offset = "0x8B9B20", VA = "0x1808BAF20", Slot = "205")]
			public void SetUnstable()
			{
			}

			// Token: 0x06010ED2 RID: 69330 RVA: 0x00068268 File Offset: 0x00066468
			[Token(Token = "0x6010ED2")]
			[Address(RVA = "0x8BAD10", Offset = "0x8B9910", VA = "0x1808BAD10", Slot = "206")]
			public bool NextFrame(bool additional)
			{
				return default(bool);
			}

			// Token: 0x06010ED3 RID: 69331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010ED3")]
			[Address(RVA = "0x8BA470", Offset = "0x8B9070", VA = "0x1808BA470", Slot = "207")]
			public void ApplyOprt(PlayerOprtData oprt)
			{
			}

			// Token: 0x06010ED4 RID: 69332 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010ED4")]
			[Address(RVA = "0x8BB150", Offset = "0x8B9D50", VA = "0x1808BB150")]
			private void _SendOprt(PlayerOperator oprt, BattleCharacterData.Signiture sig, GridPosition grid, SharedConsts.Direction dir = SharedConsts.Direction.UP)
			{
			}

			// Token: 0x06010ED5 RID: 69333 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010ED5")]
			[Address(RVA = "0x8BB010", Offset = "0x8B9C10", VA = "0x1808BB010")]
			private void _SendOprtCharacter(CharacterAction oprt, BattleCharacterData.Signiture sig, GridPosition grid, SharedConsts.Direction dir = SharedConsts.Direction.UP)
			{
			}

			// Token: 0x06010ED6 RID: 69334 RVA: 0x00068280 File Offset: 0x00066480
			[Token(Token = "0x6010ED6")]
			[Address(RVA = "0x85AC10", Offset = "0x859810", VA = "0x18085AC10")]
			private bool <>xLuaBaseProxy_get_allowManualTick()
			{
				return default(bool);
			}

			// Token: 0x06010ED7 RID: 69335 RVA: 0x00068298 File Offset: 0x00066498
			[Token(Token = "0x6010ED7")]
			[Address(RVA = "0x867A60", Offset = "0x866660", VA = "0x180867A60")]
			private bool <>xLuaBaseProxy_get_isOnline()
			{
				return default(bool);
			}

			// Token: 0x06010ED8 RID: 69336 RVA: 0x000682B0 File Offset: 0x000664B0
			[Token(Token = "0x6010ED8")]
			[Address(RVA = "0x85AC70", Offset = "0x859870", VA = "0x18085AC70")]
			private bool <>xLuaBaseProxy_get_isLargeMap()
			{
				return default(bool);
			}

			// Token: 0x06010ED9 RID: 69337 RVA: 0x000682C8 File Offset: 0x000664C8
			[Token(Token = "0x6010ED9")]
			[Address(RVA = "0x85AC80", Offset = "0x859880", VA = "0x18085AC80")]
			private bool <>xLuaBaseProxy_get_isLowMemoryGameMode()
			{
				return default(bool);
			}

			// Token: 0x06010EDA RID: 69338 RVA: 0x000682E0 File Offset: 0x000664E0
			[Token(Token = "0x6010EDA")]
			[Address(RVA = "0x83EAA0", Offset = "0x83D6A0", VA = "0x18083EAA0")]
			private GameModeMeta.GameModeType <>xLuaBaseProxy_get_gameModeType()
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}

			// Token: 0x06010EDB RID: 69339 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010EDB")]
			[Address(RVA = "0x83EA80", Offset = "0x83D680", VA = "0x18083EA80")]
			private void <>xLuaBaseProxy_Init(ref GameModeMeta P0, ref int P1, BattlePlayerData P2, LevelData P3)
			{
			}

			// Token: 0x06010EDC RID: 69340 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010EDC")]
			[Address(RVA = "0x840AB0", Offset = "0x83F6B0", VA = "0x180840AB0")]
			private void <>xLuaBaseProxy_StartGame(Action P0)
			{
			}

			// Token: 0x06010EDD RID: 69341 RVA: 0x000682F8 File Offset: 0x000664F8
			[Token(Token = "0x6010EDD")]
			[Address(RVA = "0x858C70", Offset = "0x857870", VA = "0x180858C70")]
			private bool <>xLuaBaseProxy_HookPlayerOp_Withdraw(Character P0)
			{
				return default(bool);
			}

			// Token: 0x06010EDE RID: 69342 RVA: 0x00068310 File Offset: 0x00066510
			[Token(Token = "0x6010EDE")]
			[Address(RVA = "0x858C50", Offset = "0x857850", VA = "0x180858C50")]
			private bool <>xLuaBaseProxy_HookPlayerOp_Spawn(uint P0, SharedConsts.Direction P1, Tile P2)
			{
				return default(bool);
			}

			// Token: 0x06010EDF RID: 69343 RVA: 0x00068328 File Offset: 0x00066528
			[Token(Token = "0x6010EDF")]
			[Address(RVA = "0x858C60", Offset = "0x857860", VA = "0x180858C60")]
			private bool <>xLuaBaseProxy_HookPlayerOp_TrigSkill(Character P0)
			{
				return default(bool);
			}

			// Token: 0x06010EE0 RID: 69344 RVA: 0x00068340 File Offset: 0x00066540
			[Token(Token = "0x6010EE0")]
			[Address(RVA = "0x85ABB0", Offset = "0x8597B0", VA = "0x18085ABB0")]
			private SpeedLevel <>xLuaBaseProxy_HookSpeedLevel(SpeedLevel P0)
			{
				return SpeedLevel.SLOW_MOTION;
			}

			// Token: 0x04012F9E RID: 77726
			[Token(Token = "0x4012F9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private readonly BattleController.FrameData m_frameData;

			// Token: 0x04012F9F RID: 77727
			[Token(Token = "0x4012F9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private MultiplayerInput m_data;

			// Token: 0x04012FA0 RID: 77728
			[Token(Token = "0x4012FA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private GameModeFactory.MultiplayerGameMode.InternalState m_state;

			// Token: 0x04012FA1 RID: 77729
			[Token(Token = "0x4012FA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_state;

			// Token: 0x04012FA2 RID: 77730
			[Token(Token = "0x4012FA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_state;

			// Token: 0x04012FA3 RID: 77731
			[Token(Token = "0x4012FA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04012FA4 RID: 77732
			[Token(Token = "0x4012FA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_allowManualTick;

			// Token: 0x04012FA5 RID: 77733
			[Token(Token = "0x4012FA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_isOnline;

			// Token: 0x04012FA6 RID: 77734
			[Token(Token = "0x4012FA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_isLargeMap;

			// Token: 0x04012FA7 RID: 77735
			[Token(Token = "0x4012FA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_isLowMemoryGameMode;

			// Token: 0x04012FA8 RID: 77736
			[Token(Token = "0x4012FA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_gameModeType;

			// Token: 0x04012FA9 RID: 77737
			[Token(Token = "0x4012FA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x04012FAA RID: 77738
			[Token(Token = "0x4012FAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_StartGame;

			// Token: 0x04012FAB RID: 77739
			[Token(Token = "0x4012FAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_HookPlayerOp_Withdraw;

			// Token: 0x04012FAC RID: 77740
			[Token(Token = "0x4012FAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_HookPlayerOp_Spawn;

			// Token: 0x04012FAD RID: 77741
			[Token(Token = "0x4012FAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_HookPlayerOp_TrigSkill;

			// Token: 0x04012FAE RID: 77742
			[Token(Token = "0x4012FAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_HookSpeedLevel;

			// Token: 0x04012FAF RID: 77743
			[Token(Token = "0x4012FAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_isPrepared;

			// Token: 0x04012FB0 RID: 77744
			[Token(Token = "0x4012FB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_get_isRunning;

			// Token: 0x04012FB1 RID: 77745
			[Token(Token = "0x4012FB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_get_isPlaying;

			// Token: 0x04012FB2 RID: 77746
			[Token(Token = "0x4012FB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_SetReady;

			// Token: 0x04012FB3 RID: 77747
			[Token(Token = "0x4012FB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_SetPrepared;

			// Token: 0x04012FB4 RID: 77748
			[Token(Token = "0x4012FB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_SetPlaying;

			// Token: 0x04012FB5 RID: 77749
			[Token(Token = "0x4012FB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_SetUnstable;

			// Token: 0x04012FB6 RID: 77750
			[Token(Token = "0x4012FB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_NextFrame;

			// Token: 0x04012FB7 RID: 77751
			[Token(Token = "0x4012FB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_ApplyOprt;

			// Token: 0x04012FB8 RID: 77752
			[Token(Token = "0x4012FB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0__SendOprt;

			// Token: 0x04012FB9 RID: 77753
			[Token(Token = "0x4012FB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0__SendOprtCharacter;

			// Token: 0x020027F0 RID: 10224
			[Token(Token = "0x20027F0")]
			private enum InternalState
			{
				// Token: 0x04012FBB RID: 77755
				[Token(Token = "0x4012FBB")]
				NONE,
				// Token: 0x04012FBC RID: 77756
				[Token(Token = "0x4012FBC")]
				PREPARED,
				// Token: 0x04012FBD RID: 77757
				[Token(Token = "0x4012FBD")]
				READY,
				// Token: 0x04012FBE RID: 77758
				[Token(Token = "0x4012FBE")]
				PLAYING,
				// Token: 0x04012FBF RID: 77759
				[Token(Token = "0x4012FBF")]
				PAUSE,
				// Token: 0x04012FC0 RID: 77760
				[Token(Token = "0x4012FC0")]
				UNSTABLE
			}
		}

		// Token: 0x020027F1 RID: 10225
		[Token(Token = "0x20027F1")]
		public class RacingGameMode : GameModeFactory.DefaultGameMode
		{
			// Token: 0x06010EE1 RID: 69345 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010EE1")]
			[Address(RVA = "0x8BCFE0", Offset = "0x8BBBE0", VA = "0x1808BCFE0")]
			public RacingGameMode(ref GameModeMeta meta)
			{
			}

			// Token: 0x17002537 RID: 9527
			// (get) Token: 0x06010EE2 RID: 69346 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17002537")]
			public RacingInput input
			{
				[Token(Token = "0x6010EE2")]
				[Address(RVA = "0x8BD330", Offset = "0x8BBF30", VA = "0x1808BD330")]
				get
				{
					return null;
				}
			}

			// Token: 0x17002538 RID: 9528
			// (get) Token: 0x06010EE3 RID: 69347 RVA: 0x00068358 File Offset: 0x00066558
			[Token(Token = "0x17002538")]
			public override GameModeMeta.GameModeType gameModeType
			{
				[Token(Token = "0x6010EE3")]
				[Address(RVA = "0x8BD2D0", Offset = "0x8BBED0", VA = "0x1808BD2D0", Slot = "119")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x17002539 RID: 9529
			// (get) Token: 0x06010EE4 RID: 69348 RVA: 0x00068370 File Offset: 0x00066570
			[Token(Token = "0x17002539")]
			public int circleCheckpointCnt
			{
				[Token(Token = "0x6010EE4")]
				[Address(RVA = "0x8BD210", Offset = "0x8BBE10", VA = "0x1808BD210")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700253A RID: 9530
			// (get) Token: 0x06010EE5 RID: 69349 RVA: 0x00068388 File Offset: 0x00066588
			[Token(Token = "0x1700253A")]
			public int circleCnt
			{
				[Token(Token = "0x6010EE5")]
				[Address(RVA = "0x8BD270", Offset = "0x8BBE70", VA = "0x1808BD270")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700253B RID: 9531
			// (get) Token: 0x06010EE6 RID: 69350 RVA: 0x000683A0 File Offset: 0x000665A0
			// (set) Token: 0x06010EE7 RID: 69351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700253B")]
			public FP realRacingStartTime
			{
				[Token(Token = "0x6010EE6")]
				[Address(RVA = "0x8BD4E0", Offset = "0x8BC0E0", VA = "0x1808BD4E0")]
				get
				{
					return default(FP);
				}
				[Token(Token = "0x6010EE7")]
				[Address(RVA = "0x8BD540", Offset = "0x8BC140", VA = "0x1808BD540")]
				set
				{
				}
			}

			// Token: 0x1700253C RID: 9532
			// (get) Token: 0x06010EE8 RID: 69352 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700253C")]
			public RacingEnemy myRacingEnemy
			{
				[Token(Token = "0x6010EE8")]
				[Address(RVA = "0x8BD390", Offset = "0x8BBF90", VA = "0x1808BD390")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700253D RID: 9533
			// (get) Token: 0x06010EE9 RID: 69353 RVA: 0x000683B8 File Offset: 0x000665B8
			[Token(Token = "0x1700253D")]
			public int myRanking
			{
				[Token(Token = "0x6010EE9")]
				[Address(RVA = "0x8BD400", Offset = "0x8BC000", VA = "0x1808BD400")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700253E RID: 9534
			// (get) Token: 0x06010EEA RID: 69354 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700253E")]
			public List<ObjectPtr<RacingEnemy>> racingEnemies
			{
				[Token(Token = "0x6010EEA")]
				[Address(RVA = "0x8BD470", Offset = "0x8BC070", VA = "0x1808BD470")]
				get
				{
					return null;
				}
			}

			// Token: 0x06010EEB RID: 69355 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010EEB")]
			[Address(RVA = "0x8BBB30", Offset = "0x8BA730", VA = "0x1808BBB30")]
			public static Dictionary<ResourceCollector.PreloadType, object> GatherPreloadAssets()
			{
				return null;
			}

			// Token: 0x06010EEC RID: 69356 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010EEC")]
			[Address(RVA = "0x8BC430", Offset = "0x8BB030", VA = "0x1808BC430")]
			public void UseCurrentItem()
			{
			}

			// Token: 0x06010EED RID: 69357 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010EED")]
			[Address(RVA = "0x8BBDE0", Offset = "0x8BA9E0", VA = "0x1808BBDE0")]
			public SandboxV2RacingItemInfo GetCurrentItemInfo()
			{
				return null;
			}

			// Token: 0x06010EEE RID: 69358 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010EEE")]
			[Address(RVA = "0x8BBEF0", Offset = "0x8BAAF0", VA = "0x1808BBEF0")]
			public void SetRacingInfo(int circleCheckpointCnt, int circleCnt)
			{
			}

			// Token: 0x06010EEF RID: 69359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010EEF")]
			[Address(RVA = "0x8BC0E0", Offset = "0x8BACE0", VA = "0x1808BC0E0")]
			public void UpdateRacingFinish(RacingEnemy enemy)
			{
			}

			// Token: 0x06010EF0 RID: 69360 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010EF0")]
			[Address(RVA = "0x8BB8C0", Offset = "0x8BA4C0", VA = "0x1808BB8C0")]
			public RacingOutput FetchRacingBattleOutput()
			{
				return null;
			}

			// Token: 0x06010EF1 RID: 69361 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010EF1")]
			[Address(RVA = "0x8BBF80", Offset = "0x8BAB80", VA = "0x1808BBF80", Slot = "124")]
			public override void StartGame(Action doDefaultStart)
			{
			}

			// Token: 0x06010EF2 RID: 69362 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010EF2")]
			[Address(RVA = "0x8BBE50", Offset = "0x8BAA50", VA = "0x1808BBE50", Slot = "155")]
			public override Scheduler.SchedulerPreprocessor GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x06010EF3 RID: 69363 RVA: 0x000683D0 File Offset: 0x000665D0
			[Token(Token = "0x6010EF3")]
			[Address(RVA = "0x8BBA40", Offset = "0x8BA640", VA = "0x1808BBA40", Slot = "151")]
			public override bool GameNotFinishCondition()
			{
				return default(bool);
			}

			// Token: 0x06010EF4 RID: 69364 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010EF4")]
			[Address(RVA = "0x8BB920", Offset = "0x8BA520", VA = "0x1808BB920", Slot = "182")]
			public override void FinishGame(Action<BattleController.GameResult, bool> gameOverCallback, BattleController.GameResult result, bool silent = false)
			{
			}

			// Token: 0x06010EF5 RID: 69365 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010EF5")]
			[Address(RVA = "0x8BC010", Offset = "0x8BAC10", VA = "0x1808BC010", Slot = "126")]
			public override void Tick(Action doDefaultTick)
			{
			}

			// Token: 0x06010EF6 RID: 69366 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010EF6")]
			[Address(RVA = "0x8BC4A0", Offset = "0x8BB0A0", VA = "0x1808BC4A0")]
			private Dictionary<string, RacingFinishRecord> _AchieveRacingRecords()
			{
				return null;
			}

			// Token: 0x06010EF7 RID: 69367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010EF7")]
			[Address(RVA = "0x8BC980", Offset = "0x8BB580", VA = "0x1808BC980")]
			private static void _TryGatherDynamicAbilities(RacingInput input, List<object> dynamicAbilities)
			{
			}

			// Token: 0x06010EF8 RID: 69368 RVA: 0x000683E8 File Offset: 0x000665E8
			[Token(Token = "0x6010EF8")]
			[Address(RVA = "0x83EAA0", Offset = "0x83D6A0", VA = "0x18083EAA0")]
			private GameModeMeta.GameModeType <>xLuaBaseProxy_get_gameModeType()
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}

			// Token: 0x06010EF9 RID: 69369 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010EF9")]
			[Address(RVA = "0x840AB0", Offset = "0x83F6B0", VA = "0x180840AB0")]
			private void <>xLuaBaseProxy_StartGame(Action P0)
			{
			}

			// Token: 0x06010EFA RID: 69370 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010EFA")]
			[Address(RVA = "0x83EA70", Offset = "0x83D670", VA = "0x18083EA70")]
			private Scheduler.SchedulerPreprocessor <>xLuaBaseProxy_GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x06010EFB RID: 69371 RVA: 0x00068400 File Offset: 0x00066600
			[Token(Token = "0x6010EFB")]
			[Address(RVA = "0x840A30", Offset = "0x83F630", VA = "0x180840A30")]
			private bool <>xLuaBaseProxy_GameNotFinishCondition()
			{
				return default(bool);
			}

			// Token: 0x06010EFC RID: 69372 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010EFC")]
			[Address(RVA = "0x85AB90", Offset = "0x859790", VA = "0x18085AB90")]
			private void <>xLuaBaseProxy_FinishGame(Action<BattleController.GameResult, bool> P0, BattleController.GameResult P1, bool P2)
			{
			}

			// Token: 0x06010EFD RID: 69373 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010EFD")]
			[Address(RVA = "0x83EA90", Offset = "0x83D690", VA = "0x18083EA90")]
			private void <>xLuaBaseProxy_Tick(Action P0)
			{
			}

			// Token: 0x04012FC1 RID: 77761
			[Token(Token = "0x4012FC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private RacingInput m_input;

			// Token: 0x04012FC2 RID: 77762
			[Token(Token = "0x4012FC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private RacingBattleManager m_racingManager;

			// Token: 0x04012FC3 RID: 77763
			[Token(Token = "0x4012FC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<InternalRacingFinishRecord> m_internalFinishRecords;

			// Token: 0x04012FC4 RID: 77764
			[Token(Token = "0x4012FC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int m_circleCnt;

			// Token: 0x04012FC5 RID: 77765
			[Token(Token = "0x4012FC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int m_circleCheckpointCnt;

			// Token: 0x04012FC6 RID: 77766
			[Token(Token = "0x4012FC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private FP m_realRacingStartTime;

			// Token: 0x04012FC7 RID: 77767
			[Token(Token = "0x4012FC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private bool m_isRacingFinished;

			// Token: 0x04012FC8 RID: 77768
			[Token(Token = "0x4012FC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private RacingOutput m_output;

			// Token: 0x04012FC9 RID: 77769
			[Token(Token = "0x4012FC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04012FCA RID: 77770
			[Token(Token = "0x4012FCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_input;

			// Token: 0x04012FCB RID: 77771
			[Token(Token = "0x4012FCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_gameModeType;

			// Token: 0x04012FCC RID: 77772
			[Token(Token = "0x4012FCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_circleCheckpointCnt;

			// Token: 0x04012FCD RID: 77773
			[Token(Token = "0x4012FCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_circleCnt;

			// Token: 0x04012FCE RID: 77774
			[Token(Token = "0x4012FCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_realRacingStartTime;

			// Token: 0x04012FCF RID: 77775
			[Token(Token = "0x4012FCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_set_realRacingStartTime;

			// Token: 0x04012FD0 RID: 77776
			[Token(Token = "0x4012FD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_myRacingEnemy;

			// Token: 0x04012FD1 RID: 77777
			[Token(Token = "0x4012FD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_myRanking;

			// Token: 0x04012FD2 RID: 77778
			[Token(Token = "0x4012FD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_racingEnemies;

			// Token: 0x04012FD3 RID: 77779
			[Token(Token = "0x4012FD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_GatherPreloadAssets;

			// Token: 0x04012FD4 RID: 77780
			[Token(Token = "0x4012FD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_UseCurrentItem;

			// Token: 0x04012FD5 RID: 77781
			[Token(Token = "0x4012FD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_GetCurrentItemInfo;

			// Token: 0x04012FD6 RID: 77782
			[Token(Token = "0x4012FD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_SetRacingInfo;

			// Token: 0x04012FD7 RID: 77783
			[Token(Token = "0x4012FD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_UpdateRacingFinish;

			// Token: 0x04012FD8 RID: 77784
			[Token(Token = "0x4012FD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_FetchRacingBattleOutput;

			// Token: 0x04012FD9 RID: 77785
			[Token(Token = "0x4012FD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_StartGame;

			// Token: 0x04012FDA RID: 77786
			[Token(Token = "0x4012FDA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_GetSchedulerPreprocessor;

			// Token: 0x04012FDB RID: 77787
			[Token(Token = "0x4012FDB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_GameNotFinishCondition;

			// Token: 0x04012FDC RID: 77788
			[Token(Token = "0x4012FDC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_FinishGame;

			// Token: 0x04012FDD RID: 77789
			[Token(Token = "0x4012FDD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_Tick;

			// Token: 0x04012FDE RID: 77790
			[Token(Token = "0x4012FDE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0__AchieveRacingRecords;

			// Token: 0x04012FDF RID: 77791
			[Token(Token = "0x4012FDF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0__TryGatherDynamicAbilities;
		}

		// Token: 0x020027F2 RID: 10226
		[Token(Token = "0x20027F2")]
		public class RoguelikeDeifyGameMode : GameModeFactory.RoguelikeGameMode
		{
			// Token: 0x1700253F RID: 9535
			// (get) Token: 0x06010EFE RID: 69374 RVA: 0x00068418 File Offset: 0x00066618
			[Token(Token = "0x1700253F")]
			public GameModeFactory.RoguelikeDeifyGameMode.GameStage gameStage
			{
				[Token(Token = "0x6010EFE")]
				[Address(RVA = "0x8BF7D0", Offset = "0x8BE3D0", VA = "0x1808BF7D0")]
				get
				{
					return GameModeFactory.RoguelikeDeifyGameMode.GameStage.STAGE_CHOSEN;
				}
			}

			// Token: 0x17002540 RID: 9536
			// (get) Token: 0x06010EFF RID: 69375 RVA: 0x00068430 File Offset: 0x00066630
			[Token(Token = "0x17002540")]
			public override GameModeMeta.GameModeType gameModeType
			{
				[Token(Token = "0x6010EFF")]
				[Address(RVA = "0x8BF770", Offset = "0x8BE370", VA = "0x1808BF770", Slot = "119")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x17002541 RID: 9537
			// (get) Token: 0x06010F00 RID: 69376 RVA: 0x00068448 File Offset: 0x00066648
			[Token(Token = "0x17002541")]
			public override bool isInCommonGameStage
			{
				[Token(Token = "0x6010F00")]
				[Address(RVA = "0x8BF830", Offset = "0x8BE430", VA = "0x1808BF830", Slot = "116")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06010F01 RID: 69377 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F01")]
			[Address(RVA = "0x8BF4F0", Offset = "0x8BE0F0", VA = "0x1808BF4F0")]
			public RoguelikeDeifyGameMode(ref GameModeMeta meta)
			{
			}

			// Token: 0x06010F02 RID: 69378 RVA: 0x00068460 File Offset: 0x00066660
			[Token(Token = "0x6010F02")]
			[Address(RVA = "0x8BD970", Offset = "0x8BC570", VA = "0x1808BD970")]
			public int GetRemainingTime()
			{
				return 0;
			}

			// Token: 0x06010F03 RID: 69379 RVA: 0x00068478 File Offset: 0x00066678
			[Token(Token = "0x6010F03")]
			[Address(RVA = "0x8BD8F0", Offset = "0x8BC4F0", VA = "0x1808BD8F0")]
			public int GetMaxTime()
			{
				return 0;
			}

			// Token: 0x06010F04 RID: 69380 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F04")]
			[Address(RVA = "0x8BEF40", Offset = "0x8BDB40", VA = "0x1808BEF40")]
			public void SetChooseTime()
			{
			}

			// Token: 0x17002542 RID: 9538
			// (get) Token: 0x06010F05 RID: 69381 RVA: 0x00068490 File Offset: 0x00066690
			[Token(Token = "0x17002542")]
			public int deifyTrapCnt
			{
				[Token(Token = "0x6010F05")]
				[Address(RVA = "0x8BF700", Offset = "0x8BE300", VA = "0x1808BF700")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002543 RID: 9539
			// (get) Token: 0x06010F06 RID: 69382 RVA: 0x000684A8 File Offset: 0x000666A8
			[Token(Token = "0x17002543")]
			public int deifyCharacterCnt
			{
				[Token(Token = "0x6010F06")]
				[Address(RVA = "0x8BF690", Offset = "0x8BE290", VA = "0x1808BF690")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002544 RID: 9540
			// (get) Token: 0x06010F07 RID: 69383 RVA: 0x000684C0 File Offset: 0x000666C0
			[Token(Token = "0x17002544")]
			public GameModeFactory.RoguelikeDeifyGameMode.DeifyBattleResult battleResult
			{
				[Token(Token = "0x6010F07")]
				[Address(RVA = "0x8BF630", Offset = "0x8BE230", VA = "0x1808BF630")]
				get
				{
					return (GameModeFactory.RoguelikeDeifyGameMode.DeifyBattleResult)0;
				}
			}

			// Token: 0x06010F08 RID: 69384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F08")]
			[Address(RVA = "0x8BDB30", Offset = "0x8BC730", VA = "0x1808BDB30", Slot = "202")]
			public virtual void InitGameStartStage()
			{
			}

			// Token: 0x06010F09 RID: 69385 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F09")]
			[Address(RVA = "0x8BDA90", Offset = "0x8BC690", VA = "0x1808BDA90", Slot = "203")]
			public virtual void InitDeifyStartBattleStage()
			{
			}

			// Token: 0x06010F0A RID: 69386 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F0A")]
			[Address(RVA = "0x8BD5B0", Offset = "0x8BC1B0", VA = "0x1808BD5B0", Slot = "204")]
			protected virtual void CheckGameFinish()
			{
			}

			// Token: 0x06010F0B RID: 69387 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F0B")]
			[Address(RVA = "0x8BDF80", Offset = "0x8BCB80", VA = "0x1808BDF80", Slot = "205")]
			protected virtual void ModifyCardsInStageChosen(Deck.Card card)
			{
			}

			// Token: 0x06010F0C RID: 69388 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F0C")]
			[Address(RVA = "0x8BDD10", Offset = "0x8BC910", VA = "0x1808BDD10", Slot = "206")]
			protected virtual void ModifyCardsInStageBattle()
			{
			}

			// Token: 0x06010F0D RID: 69389 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F0D")]
			[Address(RVA = "0x8BED80", Offset = "0x8BD980", VA = "0x1808BED80")]
			protected void SetCardCostZero(Deck.Card card)
			{
			}

			// Token: 0x06010F0E RID: 69390 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F0E")]
			[Address(RVA = "0x8BEFC0", Offset = "0x8BDBC0", VA = "0x1808BEFC0")]
			protected void SetRespawnTimeAndMultCntZero(Deck.Card card)
			{
			}

			// Token: 0x06010F0F RID: 69391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F0F")]
			[Address(RVA = "0x8BEC60", Offset = "0x8BD860", VA = "0x1808BEC60")]
			protected void RemoveCardBuff()
			{
			}

			// Token: 0x06010F10 RID: 69392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F10")]
			[Address(RVA = "0x8BE9E0", Offset = "0x8BD5E0", VA = "0x1808BE9E0")]
			public void ReceiveUIBtnStartConfirm()
			{
			}

			// Token: 0x06010F11 RID: 69393 RVA: 0x000684D8 File Offset: 0x000666D8
			[Token(Token = "0x6010F11")]
			[Address(RVA = "0x8BEA60", Offset = "0x8BD660", VA = "0x1808BEA60")]
			public bool RegisterChosenCharacter(Character character)
			{
				return default(bool);
			}

			// Token: 0x06010F12 RID: 69394 RVA: 0x000684F0 File Offset: 0x000666F0
			[Token(Token = "0x6010F12")]
			[Address(RVA = "0x8BEB60", Offset = "0x8BD760", VA = "0x1808BEB60")]
			public bool RegisterDeifyTrap(Trap deifyTrap)
			{
				return default(bool);
			}

			// Token: 0x06010F13 RID: 69395 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F13")]
			[Address(RVA = "0x8BF3A0", Offset = "0x8BDFA0", VA = "0x1808BF3A0")]
			private void _SwitchDeifyTrapMode()
			{
			}

			// Token: 0x06010F14 RID: 69396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F14")]
			[Address(RVA = "0x8BDBC0", Offset = "0x8BC7C0", VA = "0x1808BDBC0", Slot = "122")]
			public override void Init(ref GameModeMeta meta, ref int randomSeed, BattlePlayerData playerData, LevelData levelData)
			{
			}

			// Token: 0x06010F15 RID: 69397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F15")]
			[Address(RVA = "0x8BF1A0", Offset = "0x8BDDA0", VA = "0x1808BF1A0", Slot = "126")]
			public override void Tick(Action doDefaultTick)
			{
			}

			// Token: 0x06010F16 RID: 69398 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F16")]
			[Address(RVA = "0x8BE440", Offset = "0x8BD040", VA = "0x1808BE440", Slot = "163")]
			public override void OnCharacterFinished(Character character, Entity.FinishReason reason)
			{
			}

			// Token: 0x06010F17 RID: 69399 RVA: 0x00068508 File Offset: 0x00066708
			[Token(Token = "0x6010F17")]
			[Address(RVA = "0x8BF250", Offset = "0x8BDE50", VA = "0x1808BF250", Slot = "177")]
			public override bool TryHookCheckWaveNotFinish(bool schedulerResult, out bool result)
			{
				return default(bool);
			}

			// Token: 0x06010F18 RID: 69400 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F18")]
			[Address(RVA = "0x8BE7A0", Offset = "0x8BD3A0", VA = "0x1808BE7A0", Slot = "144")]
			public override void PreProcessDeckCards(IList<Deck.Card> cards)
			{
			}

			// Token: 0x06010F19 RID: 69401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F19")]
			[Address(RVA = "0x8BE330", Offset = "0x8BCF30", VA = "0x1808BE330", Slot = "160")]
			public override void OnApplyingGlobalModifier(ref Modifier modifier)
			{
			}

			// Token: 0x06010F1A RID: 69402 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F1A")]
			[Address(RVA = "0x8BE550", Offset = "0x8BD150", VA = "0x1808BE550", Slot = "125")]
			public override void OnGameOver(ref BattleController.GameResult result)
			{
			}

			// Token: 0x06010F1B RID: 69403 RVA: 0x00068520 File Offset: 0x00066720
			[Token(Token = "0x6010F1B")]
			[Address(RVA = "0x8BF320", Offset = "0x8BDF20", VA = "0x1808BF320")]
			private GameModeMeta.GameModeType <>xLuaBaseProxy_get_gameModeType()
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}

			// Token: 0x06010F1C RID: 69404 RVA: 0x00068538 File Offset: 0x00066738
			[Token(Token = "0x6010F1C")]
			[Address(RVA = "0x8BF390", Offset = "0x8BDF90", VA = "0x1808BF390")]
			private bool <>xLuaBaseProxy_get_isInCommonGameStage()
			{
				return default(bool);
			}

			// Token: 0x06010F1D RID: 69405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F1D")]
			[Address(RVA = "0x8BF2F0", Offset = "0x8BDEF0", VA = "0x1808BF2F0")]
			private void <>xLuaBaseProxy_Init(ref GameModeMeta P0, ref int P1, BattlePlayerData P2, LevelData P3)
			{
			}

			// Token: 0x06010F1E RID: 69406 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F1E")]
			[Address(RVA = "0x83EA90", Offset = "0x83D690", VA = "0x18083EA90")]
			private void <>xLuaBaseProxy_Tick(Action P0)
			{
			}

			// Token: 0x06010F1F RID: 69407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F1F")]
			[Address(RVA = "0x858C90", Offset = "0x857890", VA = "0x180858C90")]
			private void <>xLuaBaseProxy_OnCharacterFinished(Character P0, Entity.FinishReason P1)
			{
			}

			// Token: 0x06010F20 RID: 69408 RVA: 0x00068550 File Offset: 0x00066750
			[Token(Token = "0x6010F20")]
			[Address(RVA = "0x85EA00", Offset = "0x85D600", VA = "0x18085EA00")]
			private bool <>xLuaBaseProxy_TryHookCheckWaveNotFinish(bool P0, out bool P1)
			{
				return default(bool);
			}

			// Token: 0x06010F21 RID: 69409 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F21")]
			[Address(RVA = "0x8BF310", Offset = "0x8BDF10", VA = "0x1808BF310")]
			private void <>xLuaBaseProxy_PreProcessDeckCards(IList<Deck.Card> P0)
			{
			}

			// Token: 0x06010F22 RID: 69410 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F22")]
			[Address(RVA = "0x8BF300", Offset = "0x8BDF00", VA = "0x1808BF300")]
			private void <>xLuaBaseProxy_OnApplyingGlobalModifier(ref Modifier P0)
			{
			}

			// Token: 0x06010F23 RID: 69411 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F23")]
			[Address(RVA = "0x884DA0", Offset = "0x8839A0", VA = "0x180884DA0")]
			private void <>xLuaBaseProxy_OnGameOver(ref BattleController.GameResult P0)
			{
			}

			// Token: 0x04012FE0 RID: 77792
			[Token(Token = "0x4012FE0")]
			private const string COST_ZERO_CARD_BUFF_KEY = "set_cost_zero";

			// Token: 0x04012FE1 RID: 77793
			[Token(Token = "0x4012FE1")]
			private const string RESPAWN_ZERO_CARD_BUFF_KEY = "set_respawn_zero";

			// Token: 0x04012FE2 RID: 77794
			[Token(Token = "0x4012FE2")]
			private const int COST_DELTA = -999;

			// Token: 0x04012FE3 RID: 77795
			[Token(Token = "0x4012FE3")]
			private const float RESPAWN_TIME_DELTA = -999f;

			// Token: 0x04012FE4 RID: 77796
			[Token(Token = "0x4012FE4")]
			public const string DEIFY_UI_PLUGIN_PATH = "UI/RoguelikeTopic/Topics/rogue_5/RoguelikeDeify/roguelike_deify_ui_plugin.prefab";

			// Token: 0x04012FE5 RID: 77797
			[Token(Token = "0x4012FE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private GameModeFactory.RoguelikeDeifyGameMode.GameStage m_gameStage;

			// Token: 0x04012FE6 RID: 77798
			[Token(Token = "0x4012FE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private GameModeFactory.RoguelikeDeifyGameMode.DeifyBattleResult m_battleResult;

			// Token: 0x04012FE7 RID: 77799
			[Token(Token = "0x4012FE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private FP m_maxPlayTime;

			// Token: 0x04012FE8 RID: 77800
			[Token(Token = "0x4012FE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private FP m_chooseTime;

			// Token: 0x04012FE9 RID: 77801
			[Token(Token = "0x4012FE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private List<Trap> m_deifyTrapList;

			// Token: 0x04012FEA RID: 77802
			[Token(Token = "0x4012FEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private List<Character> m_chosenCharacterList;

			// Token: 0x04012FEB RID: 77803
			[Token(Token = "0x4012FEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_gameStage;

			// Token: 0x04012FEC RID: 77804
			[Token(Token = "0x4012FEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_gameModeType;

			// Token: 0x04012FED RID: 77805
			[Token(Token = "0x4012FED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_isInCommonGameStage;

			// Token: 0x04012FEE RID: 77806
			[Token(Token = "0x4012FEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04012FEF RID: 77807
			[Token(Token = "0x4012FEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetRemainingTime;

			// Token: 0x04012FF0 RID: 77808
			[Token(Token = "0x4012FF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetMaxTime;

			// Token: 0x04012FF1 RID: 77809
			[Token(Token = "0x4012FF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_SetChooseTime;

			// Token: 0x04012FF2 RID: 77810
			[Token(Token = "0x4012FF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_deifyTrapCnt;

			// Token: 0x04012FF3 RID: 77811
			[Token(Token = "0x4012FF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_deifyCharacterCnt;

			// Token: 0x04012FF4 RID: 77812
			[Token(Token = "0x4012FF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_battleResult;

			// Token: 0x04012FF5 RID: 77813
			[Token(Token = "0x4012FF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_InitGameStartStage;

			// Token: 0x04012FF6 RID: 77814
			[Token(Token = "0x4012FF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_InitDeifyStartBattleStage;

			// Token: 0x04012FF7 RID: 77815
			[Token(Token = "0x4012FF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_CheckGameFinish;

			// Token: 0x04012FF8 RID: 77816
			[Token(Token = "0x4012FF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_ModifyCardsInStageChosen;

			// Token: 0x04012FF9 RID: 77817
			[Token(Token = "0x4012FF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_ModifyCardsInStageBattle;

			// Token: 0x04012FFA RID: 77818
			[Token(Token = "0x4012FFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_SetCardCostZero;

			// Token: 0x04012FFB RID: 77819
			[Token(Token = "0x4012FFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_SetRespawnTimeAndMultCntZero;

			// Token: 0x04012FFC RID: 77820
			[Token(Token = "0x4012FFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_RemoveCardBuff;

			// Token: 0x04012FFD RID: 77821
			[Token(Token = "0x4012FFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_ReceiveUIBtnStartConfirm;

			// Token: 0x04012FFE RID: 77822
			[Token(Token = "0x4012FFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_RegisterChosenCharacter;

			// Token: 0x04012FFF RID: 77823
			[Token(Token = "0x4012FFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_RegisterDeifyTrap;

			// Token: 0x04013000 RID: 77824
			[Token(Token = "0x4013000")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0__SwitchDeifyTrapMode;

			// Token: 0x04013001 RID: 77825
			[Token(Token = "0x4013001")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x04013002 RID: 77826
			[Token(Token = "0x4013002")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_Tick;

			// Token: 0x04013003 RID: 77827
			[Token(Token = "0x4013003")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_OnCharacterFinished;

			// Token: 0x04013004 RID: 77828
			[Token(Token = "0x4013004")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_TryHookCheckWaveNotFinish;

			// Token: 0x04013005 RID: 77829
			[Token(Token = "0x4013005")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0_PreProcessDeckCards;

			// Token: 0x04013006 RID: 77830
			[Token(Token = "0x4013006")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0_OnApplyingGlobalModifier;

			// Token: 0x04013007 RID: 77831
			[Token(Token = "0x4013007")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0_OnGameOver;

			// Token: 0x020027F3 RID: 10227
			[Token(Token = "0x20027F3")]
			public enum DeifyBattleResult
			{
				// Token: 0x04013009 RID: 77833
				[Token(Token = "0x4013009")]
				Lose = 1,
				// Token: 0x0401300A RID: 77834
				[Token(Token = "0x401300A")]
				Win
			}

			// Token: 0x020027F4 RID: 10228
			[Token(Token = "0x20027F4")]
			public enum GameStage
			{
				// Token: 0x0401300C RID: 77836
				[Token(Token = "0x401300C")]
				STAGE_CHOSEN,
				// Token: 0x0401300D RID: 77837
				[Token(Token = "0x401300D")]
				STAGE_BATTLE
			}

			// Token: 0x020027F5 RID: 10229
			[Token(Token = "0x20027F5")]
			public enum BattleResult
			{
				// Token: 0x0401300F RID: 77839
				[Token(Token = "0x401300F")]
				Lose = 1,
				// Token: 0x04013010 RID: 77840
				[Token(Token = "0x4013010")]
				Win
			}
		}

		// Token: 0x020027F6 RID: 10230
		[Token(Token = "0x20027F6")]
		public class RoguelikeDuelGameMode : GameModeFactory.RoguelikeGameMode
		{
			// Token: 0x17002545 RID: 9541
			// (get) Token: 0x06010F24 RID: 69412 RVA: 0x00068568 File Offset: 0x00066768
			[Token(Token = "0x17002545")]
			public GameModeFactory.RoguelikeDuelGameMode.DuelBattleResult duelBattleResult
			{
				[Token(Token = "0x6010F24")]
				[Address(RVA = "0x8C3940", Offset = "0x8C2540", VA = "0x1808C3940")]
				get
				{
					return (GameModeFactory.RoguelikeDuelGameMode.DuelBattleResult)0;
				}
			}

			// Token: 0x17002546 RID: 9542
			// (get) Token: 0x06010F25 RID: 69413 RVA: 0x00068580 File Offset: 0x00066780
			[Token(Token = "0x17002546")]
			public int deployedCharacterCount
			{
				[Token(Token = "0x6010F25")]
				[Address(RVA = "0x8C38C0", Offset = "0x8C24C0", VA = "0x1808C38C0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002547 RID: 9543
			// (get) Token: 0x06010F26 RID: 69414 RVA: 0x00068598 File Offset: 0x00066798
			[Token(Token = "0x17002547")]
			public int chosenEnemyCount
			{
				[Token(Token = "0x6010F26")]
				[Address(RVA = "0x8C3840", Offset = "0x8C2440", VA = "0x1808C3840")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002548 RID: 9544
			// (get) Token: 0x06010F27 RID: 69415 RVA: 0x000685B0 File Offset: 0x000667B0
			[Token(Token = "0x17002548")]
			public int duelModeToInt
			{
				[Token(Token = "0x6010F27")]
				[Address(RVA = "0x8C39A0", Offset = "0x8C25A0", VA = "0x1808C39A0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002549 RID: 9545
			// (get) Token: 0x06010F28 RID: 69416 RVA: 0x000685C8 File Offset: 0x000667C8
			[Token(Token = "0x17002549")]
			public GameModeFactory.RoguelikeDuelGameMode.GameStage gameStage
			{
				[Token(Token = "0x6010F28")]
				[Address(RVA = "0x8C3A60", Offset = "0x8C2660", VA = "0x1808C3A60")]
				get
				{
					return GameModeFactory.RoguelikeDuelGameMode.GameStage.STAGE_CHOSEN;
				}
			}

			// Token: 0x1700254A RID: 9546
			// (get) Token: 0x06010F29 RID: 69417 RVA: 0x000685E0 File Offset: 0x000667E0
			[Token(Token = "0x1700254A")]
			public override bool isInCommonGameStage
			{
				[Token(Token = "0x6010F29")]
				[Address(RVA = "0x8C3B20", Offset = "0x8C2720", VA = "0x1808C3B20", Slot = "116")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700254B RID: 9547
			// (get) Token: 0x06010F2A RID: 69418 RVA: 0x000685F8 File Offset: 0x000667F8
			[Token(Token = "0x1700254B")]
			public override bool hasExtraBuildCondition
			{
				[Token(Token = "0x6010F2A")]
				[Address(RVA = "0x8C3AC0", Offset = "0x8C26C0", VA = "0x1808C3AC0", Slot = "106")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700254C RID: 9548
			// (get) Token: 0x06010F2B RID: 69419 RVA: 0x00068610 File Offset: 0x00066810
			[Token(Token = "0x1700254C")]
			public override GameModeMeta.GameModeType gameModeType
			{
				[Token(Token = "0x6010F2B")]
				[Address(RVA = "0x8C3A00", Offset = "0x8C2600", VA = "0x1808C3A00", Slot = "119")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x06010F2C RID: 69420 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F2C")]
			[Address(RVA = "0x8C03A0", Offset = "0x8BEFA0", VA = "0x1808C03A0", Slot = "122")]
			public override void Init(ref GameModeMeta meta, ref int randomSeed, BattlePlayerData playerData, LevelData levelData)
			{
			}

			// Token: 0x06010F2D RID: 69421 RVA: 0x00068628 File Offset: 0x00066828
			[Token(Token = "0x6010F2D")]
			[Address(RVA = "0x8C1C80", Offset = "0x8C0880", VA = "0x1808C1C80", Slot = "177")]
			public override bool TryHookCheckWaveNotFinish(bool schedulerResult, out bool result)
			{
				return default(bool);
			}

			// Token: 0x06010F2E RID: 69422 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010F2E")]
			[Address(RVA = "0x8C0340", Offset = "0x8BEF40", VA = "0x1808C0340", Slot = "155")]
			public override Scheduler.SchedulerPreprocessor GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x06010F2F RID: 69423 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F2F")]
			[Address(RVA = "0x8C1BF0", Offset = "0x8C07F0", VA = "0x1808C1BF0", Slot = "126")]
			public override void Tick(Action doDefaultTick)
			{
			}

			// Token: 0x06010F30 RID: 69424 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F30")]
			[Address(RVA = "0x8C1180", Offset = "0x8BFD80", VA = "0x1808C1180", Slot = "164")]
			public override void OnEnemyFinished(Enemy enemy, Entity.FinishReason reason)
			{
			}

			// Token: 0x06010F31 RID: 69425 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F31")]
			[Address(RVA = "0x8C12D0", Offset = "0x8BFED0", VA = "0x1808C12D0", Slot = "161")]
			public override void OnUnitRegistered(Unit unit)
			{
			}

			// Token: 0x06010F32 RID: 69426 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F32")]
			[Address(RVA = "0x8C1530", Offset = "0x8C0130", VA = "0x1808C1530", Slot = "144")]
			public override void PreProcessDeckCards(IList<Deck.Card> cards)
			{
			}

			// Token: 0x06010F33 RID: 69427 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F33")]
			[Address(RVA = "0x8C0C80", Offset = "0x8BF880", VA = "0x1808C0C80", Slot = "172")]
			public override void OnCardListChanged(Deck.Card card)
			{
			}

			// Token: 0x06010F34 RID: 69428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F34")]
			[Address(RVA = "0x8C0E10", Offset = "0x8BFA10", VA = "0x1808C0E10", Slot = "163")]
			public override void OnCharacterFinished(Character character, Entity.FinishReason reason)
			{
			}

			// Token: 0x06010F35 RID: 69429 RVA: 0x00068640 File Offset: 0x00066840
			[Token(Token = "0x6010F35")]
			[Address(RVA = "0x8BFB50", Offset = "0x8BE750", VA = "0x1808BFB50", Slot = "152")]
			public override bool CheckBuildable(BuildCondition buildCondition, Tile tile, SharedConsts.Direction direction, bool spawnManually, bool overflowOccupiedCnt, BattleCharacterData sourceData, PlayerSide operationSide = PlayerSide.DEFAULT)
			{
				return default(bool);
			}

			// Token: 0x06010F36 RID: 69430 RVA: 0x00068658 File Offset: 0x00066858
			[Token(Token = "0x6010F36")]
			[Address(RVA = "0x8C00D0", Offset = "0x8BECD0", VA = "0x1808C00D0", Slot = "184")]
			public override PlayerBattleRank GetBattleCompleteRank()
			{
				return (PlayerBattleRank)0;
			}

			// Token: 0x06010F37 RID: 69431 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F37")]
			[Address(RVA = "0x8C0B70", Offset = "0x8BF770", VA = "0x1808C0B70", Slot = "160")]
			public override void OnApplyingGlobalModifier(ref Modifier modifier)
			{
			}

			// Token: 0x06010F38 RID: 69432 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F38")]
			[Address(RVA = "0x8C3660", Offset = "0x8C2260", VA = "0x1808C3660")]
			public RoguelikeDuelGameMode(ref GameModeMeta meta)
			{
			}

			// Token: 0x06010F39 RID: 69433 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F39")]
			[Address(RVA = "0x8C1020", Offset = "0x8BFC20", VA = "0x1808C1020")]
			public void OnDuelBattleStart()
			{
			}

			// Token: 0x06010F3A RID: 69434 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F3A")]
			[Address(RVA = "0x8C1DB0", Offset = "0x8C09B0", VA = "0x1808C1DB0")]
			public void WithDrawAllCharacters()
			{
			}

			// Token: 0x06010F3B RID: 69435 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F3B")]
			[Address(RVA = "0x8C0620", Offset = "0x8BF220", VA = "0x1808C0620")]
			public void KillAllEnemies()
			{
			}

			// Token: 0x06010F3C RID: 69436 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F3C")]
			[Address(RVA = "0x8C1B80", Offset = "0x8C0780", VA = "0x1808C1B80")]
			public void SetDuelMode(GameModeFactory.RoguelikeDuelGameMode.DuelMode duelMode)
			{
			}

			// Token: 0x06010F3D RID: 69437 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F3D")]
			[Address(RVA = "0x8BFA40", Offset = "0x8BE640", VA = "0x1808BFA40")]
			public void AddChosenTrapCol(int col)
			{
			}

			// Token: 0x06010F3E RID: 69438 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F3E")]
			[Address(RVA = "0x8C1AA0", Offset = "0x8C06A0", VA = "0x1808C1AA0")]
			public void SetChosenGroupId(int groupid)
			{
			}

			// Token: 0x06010F3F RID: 69439 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F3F")]
			[Address(RVA = "0x8C1B10", Offset = "0x8C0710", VA = "0x1808C1B10")]
			public void SetChosenSync(bool flag)
			{
			}

			// Token: 0x06010F40 RID: 69440 RVA: 0x00068670 File Offset: 0x00066870
			[Token(Token = "0x6010F40")]
			[Address(RVA = "0x8BFE50", Offset = "0x8BEA50", VA = "0x1808BFE50")]
			public bool CheckConvertBattleStage()
			{
				return default(bool);
			}

			// Token: 0x06010F41 RID: 69441 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F41")]
			[Address(RVA = "0x8C0AA0", Offset = "0x8BF6A0", VA = "0x1808C0AA0")]
			public void ModifyPlaceAreaData(Blackboard blackboard)
			{
			}

			// Token: 0x06010F42 RID: 69442 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F42")]
			[Address(RVA = "0x8BF970", Offset = "0x8BE570", VA = "0x1808BF970")]
			public void AddChosenEnemy(Enemy enemy)
			{
			}

			// Token: 0x06010F43 RID: 69443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F43")]
			[Address(RVA = "0x8BF8A0", Offset = "0x8BE4A0", VA = "0x1808BF8A0")]
			public void AddChosenCharacter(string charId)
			{
			}

			// Token: 0x06010F44 RID: 69444 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F44")]
			[Address(RVA = "0x8C17D0", Offset = "0x8C03D0", VA = "0x1808C17D0")]
			public void ReceiveUIBtnStartConfirm()
			{
			}

			// Token: 0x06010F45 RID: 69445 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F45")]
			[Address(RVA = "0x8C2850", Offset = "0x8C1450", VA = "0x1808C2850")]
			private void _OnTileClicked(object args)
			{
			}

			// Token: 0x06010F46 RID: 69446 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F46")]
			[Address(RVA = "0x8C3160", Offset = "0x8C1D60", VA = "0x1808C3160")]
			private void _ShowEnemyToast(Enemy enemy, string desc)
			{
			}

			// Token: 0x06010F47 RID: 69447 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F47")]
			[Address(RVA = "0x8C25E0", Offset = "0x8C11E0", VA = "0x1808C25E0")]
			private void _HideCardExceptChosenCharacters()
			{
			}

			// Token: 0x06010F48 RID: 69448 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F48")]
			[Address(RVA = "0x8C3420", Offset = "0x8C2020", VA = "0x1808C3420")]
			private void _SummonChosenEnemies()
			{
			}

			// Token: 0x06010F49 RID: 69449 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F49")]
			[Address(RVA = "0x8C3330", Offset = "0x8C1F30", VA = "0x1808C3330")]
			private void _StartSummonEnemy(string branchId, string enemyId)
			{
			}

			// Token: 0x06010F4A RID: 69450 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F4A")]
			[Address(RVA = "0x8C2DC0", Offset = "0x8C19C0", VA = "0x1808C2DC0")]
			private void _SetCardCostZero(Deck.Card card)
			{
			}

			// Token: 0x06010F4B RID: 69451 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F4B")]
			[Address(RVA = "0x8C2F80", Offset = "0x8C1B80", VA = "0x1808C2F80")]
			private void _SetRespawnTimeAndMultCntZero(Deck.Card card)
			{
			}

			// Token: 0x06010F4C RID: 69452 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F4C")]
			[Address(RVA = "0x8C2CA0", Offset = "0x8C18A0", VA = "0x1808C2CA0")]
			private void _RemoveCardBuff()
			{
			}

			// Token: 0x06010F4D RID: 69453 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F4D")]
			[Address(RVA = "0x8C22F0", Offset = "0x8C0EF0", VA = "0x1808C22F0")]
			private void _CheckGameFinish()
			{
			}

			// Token: 0x06010F4E RID: 69454 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F4E")]
			[Address(RVA = "0x8C1FF0", Offset = "0x8C0BF0", VA = "0x1808C1FF0")]
			private void _AddDuelGameInfoLog(int chosenGroup, string gameResult)
			{
			}

			// Token: 0x06010F4F RID: 69455 RVA: 0x00068688 File Offset: 0x00066888
			[Token(Token = "0x6010F4F")]
			[Address(RVA = "0x8C0180", Offset = "0x8BED80", VA = "0x1808C0180")]
			public int GetMaxTime()
			{
				return 0;
			}

			// Token: 0x06010F50 RID: 69456 RVA: 0x000686A0 File Offset: 0x000668A0
			[Token(Token = "0x6010F50")]
			[Address(RVA = "0x8C0210", Offset = "0x8BEE10", VA = "0x1808C0210")]
			public int GetRemainingTime()
			{
				return 0;
			}

			// Token: 0x06010F51 RID: 69457 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F51")]
			[Address(RVA = "0x8C1A10", Offset = "0x8C0610", VA = "0x1808C1A10")]
			public void SetChooseTime()
			{
			}

			// Token: 0x06010F52 RID: 69458 RVA: 0x000686B8 File Offset: 0x000668B8
			[Token(Token = "0x6010F52")]
			[Address(RVA = "0x8BFDD0", Offset = "0x8BE9D0", VA = "0x1808BFDD0")]
			public bool CheckCanRefresh()
			{
				return default(bool);
			}

			// Token: 0x06010F53 RID: 69459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F53")]
			[Address(RVA = "0x8C1950", Offset = "0x8C0550", VA = "0x1808C1950")]
			public void RefreshEnemy()
			{
			}

			// Token: 0x06010F54 RID: 69460 RVA: 0x000686D0 File Offset: 0x000668D0
			[Token(Token = "0x6010F54")]
			[Address(RVA = "0x8BFEC0", Offset = "0x8BEAC0", VA = "0x1808BFEC0")]
			public bool CheckInRefreshStatus()
			{
				return default(bool);
			}

			// Token: 0x06010F55 RID: 69461 RVA: 0x000686E8 File Offset: 0x000668E8
			[Token(Token = "0x6010F55")]
			[Address(RVA = "0x8C0000", Offset = "0x8BEC00", VA = "0x1808C0000")]
			public bool ExtraStartCheck()
			{
				return default(bool);
			}

			// Token: 0x06010F56 RID: 69462 RVA: 0x00068700 File Offset: 0x00066900
			[Token(Token = "0x6010F56")]
			[Address(RVA = "0x8BF390", Offset = "0x8BDF90", VA = "0x1808BF390")]
			private bool <>xLuaBaseProxy_get_isInCommonGameStage()
			{
				return default(bool);
			}

			// Token: 0x06010F57 RID: 69463 RVA: 0x00068718 File Offset: 0x00066918
			[Token(Token = "0x6010F57")]
			[Address(RVA = "0x85AC60", Offset = "0x859860", VA = "0x18085AC60")]
			private bool <>xLuaBaseProxy_get_hasExtraBuildCondition()
			{
				return default(bool);
			}

			// Token: 0x06010F58 RID: 69464 RVA: 0x00068730 File Offset: 0x00066930
			[Token(Token = "0x6010F58")]
			[Address(RVA = "0x8BF320", Offset = "0x8BDF20", VA = "0x1808BF320")]
			private GameModeMeta.GameModeType <>xLuaBaseProxy_get_gameModeType()
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}

			// Token: 0x06010F59 RID: 69465 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F59")]
			[Address(RVA = "0x8BF2F0", Offset = "0x8BDEF0", VA = "0x1808BF2F0")]
			private void <>xLuaBaseProxy_Init(ref GameModeMeta P0, ref int P1, BattlePlayerData P2, LevelData P3)
			{
			}

			// Token: 0x06010F5A RID: 69466 RVA: 0x00068748 File Offset: 0x00066948
			[Token(Token = "0x6010F5A")]
			[Address(RVA = "0x85EA00", Offset = "0x85D600", VA = "0x18085EA00")]
			private bool <>xLuaBaseProxy_TryHookCheckWaveNotFinish(bool P0, out bool P1)
			{
				return default(bool);
			}

			// Token: 0x06010F5B RID: 69467 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010F5B")]
			[Address(RVA = "0x8C1D20", Offset = "0x8C0920", VA = "0x1808C1D20")]
			private Scheduler.SchedulerPreprocessor <>xLuaBaseProxy_GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x06010F5C RID: 69468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F5C")]
			[Address(RVA = "0x83EA90", Offset = "0x83D690", VA = "0x18083EA90")]
			private void <>xLuaBaseProxy_Tick(Action P0)
			{
			}

			// Token: 0x06010F5D RID: 69469 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F5D")]
			[Address(RVA = "0x840A70", Offset = "0x83F670", VA = "0x180840A70")]
			private void <>xLuaBaseProxy_OnEnemyFinished(Enemy P0, Entity.FinishReason P1)
			{
			}

			// Token: 0x06010F5E RID: 69470 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F5E")]
			[Address(RVA = "0x840A90", Offset = "0x83F690", VA = "0x180840A90")]
			private void <>xLuaBaseProxy_OnUnitRegistered(Unit P0)
			{
			}

			// Token: 0x06010F5F RID: 69471 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F5F")]
			[Address(RVA = "0x8BF310", Offset = "0x8BDF10", VA = "0x1808BF310")]
			private void <>xLuaBaseProxy_PreProcessDeckCards(IList<Deck.Card> P0)
			{
			}

			// Token: 0x06010F60 RID: 69472 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F60")]
			[Address(RVA = "0x867980", Offset = "0x866580", VA = "0x180867980")]
			private void <>xLuaBaseProxy_OnCardListChanged(Deck.Card P0)
			{
			}

			// Token: 0x06010F61 RID: 69473 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F61")]
			[Address(RVA = "0x858C90", Offset = "0x857890", VA = "0x180858C90")]
			private void <>xLuaBaseProxy_OnCharacterFinished(Character P0, Entity.FinishReason P1)
			{
			}

			// Token: 0x06010F62 RID: 69474 RVA: 0x00068760 File Offset: 0x00066960
			[Token(Token = "0x6010F62")]
			[Address(RVA = "0x85AAD0", Offset = "0x8596D0", VA = "0x18085AAD0")]
			private bool <>xLuaBaseProxy_CheckBuildable(BuildCondition P0, Tile P1, SharedConsts.Direction P2, bool P3, bool P4, BattleCharacterData P5, PlayerSide P6)
			{
				return default(bool);
			}

			// Token: 0x06010F63 RID: 69475 RVA: 0x00068778 File Offset: 0x00066978
			[Token(Token = "0x6010F63")]
			[Address(RVA = "0x858C40", Offset = "0x857840", VA = "0x180858C40")]
			private PlayerBattleRank <>xLuaBaseProxy_GetBattleCompleteRank()
			{
				return (PlayerBattleRank)0;
			}

			// Token: 0x06010F64 RID: 69476 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F64")]
			[Address(RVA = "0x8BF300", Offset = "0x8BDF00", VA = "0x1808BF300")]
			private void <>xLuaBaseProxy_OnApplyingGlobalModifier(ref Modifier P0)
			{
			}

			// Token: 0x04013011 RID: 77841
			[Token(Token = "0x4013011")]
			public const string DUEL_UI_PLUGIN_PATH = "UI/RoguelikeTopic/Topics/rogue_4/RoguelikeDuel/roguelike_duel_ui_plugin.prefab";

			// Token: 0x04013012 RID: 77842
			[Token(Token = "0x4013012")]
			public const string DUEL_CAMERA_PLUGIN_PATH = "UI/RoguelikeTopic/Topics/rogue_4/RoguelikeDuel/roguelike_duel_camera_plugin.prefab";

			// Token: 0x04013013 RID: 77843
			[Token(Token = "0x4013013")]
			private const string LOG_LOSS = "1";

			// Token: 0x04013014 RID: 77844
			[Token(Token = "0x4013014")]
			private const string LOG_DRAW = "2";

			// Token: 0x04013015 RID: 77845
			[Token(Token = "0x4013015")]
			private const string LOG_WIN = "3";

			// Token: 0x04013016 RID: 77846
			[Token(Token = "0x4013016")]
			private const string SINGLE_ROUTE = "Walk";

			// Token: 0x04013017 RID: 77847
			[Token(Token = "0x4013017")]
			private const string DOUBLE_ROUTE_1 = "Walk_1";

			// Token: 0x04013018 RID: 77848
			[Token(Token = "0x4013018")]
			private const string DOUBLE_ROUTE_2 = "Walk_2";

			// Token: 0x04013019 RID: 77849
			[Token(Token = "0x4013019")]
			private const string GROUP_ID = "group_id";

			// Token: 0x0401301A RID: 77850
			[Token(Token = "0x401301A")]
			private const string REFRESH_LIMIT_TIME = "refresh_limit_time";

			// Token: 0x0401301B RID: 77851
			[Token(Token = "0x401301B")]
			private const string COST_ZERO_CARD_BUFF_KEY = "set_cost_zero";

			// Token: 0x0401301C RID: 77852
			[Token(Token = "0x401301C")]
			private const string RESPAWN_ZERO_CARD_BUFF_KEY = "set_respawn_zero";

			// Token: 0x0401301D RID: 77853
			[Token(Token = "0x401301D")]
			private const int COST_DELTA = -999;

			// Token: 0x0401301E RID: 77854
			[Token(Token = "0x401301E")]
			private const float RESPAWN_TIME_DELTA = -999f;

			// Token: 0x0401301F RID: 77855
			[Token(Token = "0x401301F")]
			private const int GROUP_NUM = 3;

			// Token: 0x04013020 RID: 77856
			[Token(Token = "0x4013020")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private int m_battleAreaBegin;

			// Token: 0x04013021 RID: 77857
			[Token(Token = "0x4013021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private int m_battleAreaEnd;

			// Token: 0x04013022 RID: 77858
			[Token(Token = "0x4013022")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private FP m_maxPlayTime;

			// Token: 0x04013023 RID: 77859
			[Token(Token = "0x4013023")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private FP m_chooseTime;

			// Token: 0x04013024 RID: 77860
			[Token(Token = "0x4013024")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private GameModeFactory.RoguelikeDuelGameMode.GameStage m_gameStage;

			// Token: 0x04013025 RID: 77861
			[Token(Token = "0x4013025")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private GameModeFactory.RoguelikeDuelGameMode.DuelMode m_duelMode;

			// Token: 0x04013026 RID: 77862
			[Token(Token = "0x4013026")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private GameModeFactory.RoguelikeDuelGameMode.DuelBattleResult m_duelBattleResult;

			// Token: 0x04013027 RID: 77863
			[Token(Token = "0x4013027")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private List<int> m_chosenTrapCols;

			// Token: 0x04013028 RID: 77864
			[Token(Token = "0x4013028")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private int m_chosenGroupId;

			// Token: 0x04013029 RID: 77865
			[Token(Token = "0x4013029")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private string m_withdrawCardName;

			// Token: 0x0401302A RID: 77866
			[Token(Token = "0x401302A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private int m_refreshLimitTimes;

			// Token: 0x0401302B RID: 77867
			[Token(Token = "0x401302B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private int m_currentRefreshTimes;

			// Token: 0x0401302C RID: 77868
			[Token(Token = "0x401302C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool m_receiveUIBtnStartConfirm;

			// Token: 0x0401302D RID: 77869
			[Token(Token = "0x401302D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
			private bool m_chosenSync;

			// Token: 0x0401302E RID: 77870
			[Token(Token = "0x401302E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private RoguelikeDuelSchedulerPreprocessor m_schedulerPreprocessor;

			// Token: 0x0401302F RID: 77871
			[Token(Token = "0x401302F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private List<Enemy> m_chosenEnemyList;

			// Token: 0x04013030 RID: 77872
			[Token(Token = "0x4013030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private List<string> m_chosenCharacterList;

			// Token: 0x04013031 RID: 77873
			[Token(Token = "0x4013031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private List<string> m_chosenCharacterLogList;

			// Token: 0x04013032 RID: 77874
			[Token(Token = "0x4013032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_duelBattleResult;

			// Token: 0x04013033 RID: 77875
			[Token(Token = "0x4013033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_deployedCharacterCount;

			// Token: 0x04013034 RID: 77876
			[Token(Token = "0x4013034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_chosenEnemyCount;

			// Token: 0x04013035 RID: 77877
			[Token(Token = "0x4013035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_duelModeToInt;

			// Token: 0x04013036 RID: 77878
			[Token(Token = "0x4013036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_gameStage;

			// Token: 0x04013037 RID: 77879
			[Token(Token = "0x4013037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_isInCommonGameStage;

			// Token: 0x04013038 RID: 77880
			[Token(Token = "0x4013038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_hasExtraBuildCondition;

			// Token: 0x04013039 RID: 77881
			[Token(Token = "0x4013039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_gameModeType;

			// Token: 0x0401303A RID: 77882
			[Token(Token = "0x401303A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0401303B RID: 77883
			[Token(Token = "0x401303B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_TryHookCheckWaveNotFinish;

			// Token: 0x0401303C RID: 77884
			[Token(Token = "0x401303C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_GetSchedulerPreprocessor;

			// Token: 0x0401303D RID: 77885
			[Token(Token = "0x401303D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_Tick;

			// Token: 0x0401303E RID: 77886
			[Token(Token = "0x401303E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_OnEnemyFinished;

			// Token: 0x0401303F RID: 77887
			[Token(Token = "0x401303F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_OnUnitRegistered;

			// Token: 0x04013040 RID: 77888
			[Token(Token = "0x4013040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_PreProcessDeckCards;

			// Token: 0x04013041 RID: 77889
			[Token(Token = "0x4013041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_OnCardListChanged;

			// Token: 0x04013042 RID: 77890
			[Token(Token = "0x4013042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_OnCharacterFinished;

			// Token: 0x04013043 RID: 77891
			[Token(Token = "0x4013043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_CheckBuildable;

			// Token: 0x04013044 RID: 77892
			[Token(Token = "0x4013044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_GetBattleCompleteRank;

			// Token: 0x04013045 RID: 77893
			[Token(Token = "0x4013045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_OnApplyingGlobalModifier;

			// Token: 0x04013046 RID: 77894
			[Token(Token = "0x4013046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04013047 RID: 77895
			[Token(Token = "0x4013047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_OnDuelBattleStart;

			// Token: 0x04013048 RID: 77896
			[Token(Token = "0x4013048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_WithDrawAllCharacters;

			// Token: 0x04013049 RID: 77897
			[Token(Token = "0x4013049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_KillAllEnemies;

			// Token: 0x0401304A RID: 77898
			[Token(Token = "0x401304A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_SetDuelMode;

			// Token: 0x0401304B RID: 77899
			[Token(Token = "0x401304B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_AddChosenTrapCol;

			// Token: 0x0401304C RID: 77900
			[Token(Token = "0x401304C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0_SetChosenGroupId;

			// Token: 0x0401304D RID: 77901
			[Token(Token = "0x401304D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0_SetChosenSync;

			// Token: 0x0401304E RID: 77902
			[Token(Token = "0x401304E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0_CheckConvertBattleStage;

			// Token: 0x0401304F RID: 77903
			[Token(Token = "0x401304F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0_ModifyPlaceAreaData;

			// Token: 0x04013050 RID: 77904
			[Token(Token = "0x4013050")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private static DelegateBridge __Hotfix0_AddChosenEnemy;

			// Token: 0x04013051 RID: 77905
			[Token(Token = "0x4013051")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private static DelegateBridge __Hotfix0_AddChosenCharacter;

			// Token: 0x04013052 RID: 77906
			[Token(Token = "0x4013052")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			private static DelegateBridge __Hotfix0_ReceiveUIBtnStartConfirm;

			// Token: 0x04013053 RID: 77907
			[Token(Token = "0x4013053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private static DelegateBridge __Hotfix0__OnTileClicked;

			// Token: 0x04013054 RID: 77908
			[Token(Token = "0x4013054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private static DelegateBridge __Hotfix0__ShowEnemyToast;

			// Token: 0x04013055 RID: 77909
			[Token(Token = "0x4013055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private static DelegateBridge __Hotfix0__HideCardExceptChosenCharacters;

			// Token: 0x04013056 RID: 77910
			[Token(Token = "0x4013056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private static DelegateBridge __Hotfix0__SummonChosenEnemies;

			// Token: 0x04013057 RID: 77911
			[Token(Token = "0x4013057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private static DelegateBridge __Hotfix0__StartSummonEnemy;

			// Token: 0x04013058 RID: 77912
			[Token(Token = "0x4013058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private static DelegateBridge __Hotfix0__SetCardCostZero;

			// Token: 0x04013059 RID: 77913
			[Token(Token = "0x4013059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private static DelegateBridge __Hotfix0__SetRespawnTimeAndMultCntZero;

			// Token: 0x0401305A RID: 77914
			[Token(Token = "0x401305A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private static DelegateBridge __Hotfix0__RemoveCardBuff;

			// Token: 0x0401305B RID: 77915
			[Token(Token = "0x401305B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			private static DelegateBridge __Hotfix0__CheckGameFinish;

			// Token: 0x0401305C RID: 77916
			[Token(Token = "0x401305C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			private static DelegateBridge __Hotfix0__AddDuelGameInfoLog;

			// Token: 0x0401305D RID: 77917
			[Token(Token = "0x401305D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			private static DelegateBridge __Hotfix0_GetMaxTime;

			// Token: 0x0401305E RID: 77918
			[Token(Token = "0x401305E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			private static DelegateBridge __Hotfix0_GetRemainingTime;

			// Token: 0x0401305F RID: 77919
			[Token(Token = "0x401305F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private static DelegateBridge __Hotfix0_SetChooseTime;

			// Token: 0x04013060 RID: 77920
			[Token(Token = "0x4013060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			private static DelegateBridge __Hotfix0_CheckCanRefresh;

			// Token: 0x04013061 RID: 77921
			[Token(Token = "0x4013061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private static DelegateBridge __Hotfix0_RefreshEnemy;

			// Token: 0x04013062 RID: 77922
			[Token(Token = "0x4013062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
			private static DelegateBridge __Hotfix0_CheckInRefreshStatus;

			// Token: 0x04013063 RID: 77923
			[Token(Token = "0x4013063")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private static DelegateBridge __Hotfix0_ExtraStartCheck;

			// Token: 0x020027F7 RID: 10231
			[Token(Token = "0x20027F7")]
			public enum DuelBattleResult
			{
				// Token: 0x04013065 RID: 77925
				[Token(Token = "0x4013065")]
				Lose = 1,
				// Token: 0x04013066 RID: 77926
				[Token(Token = "0x4013066")]
				Draw,
				// Token: 0x04013067 RID: 77927
				[Token(Token = "0x4013067")]
				Win
			}

			// Token: 0x020027F8 RID: 10232
			[Token(Token = "0x20027F8")]
			public enum DuelMode
			{
				// Token: 0x04013069 RID: 77929
				[Token(Token = "0x4013069")]
				Single,
				// Token: 0x0401306A RID: 77930
				[Token(Token = "0x401306A")]
				Double
			}

			// Token: 0x020027F9 RID: 10233
			[Token(Token = "0x20027F9")]
			public enum GameStage
			{
				// Token: 0x0401306C RID: 77932
				[Token(Token = "0x401306C")]
				STAGE_CHOSEN,
				// Token: 0x0401306D RID: 77933
				[Token(Token = "0x401306D")]
				STAGE_READY,
				// Token: 0x0401306E RID: 77934
				[Token(Token = "0x401306E")]
				STAGE_BATTLE
			}
		}

		// Token: 0x020027FA RID: 10234
		[Token(Token = "0x20027FA")]
		public class RoguelikeGameMode : GameModeFactory.DefaultGameMode
		{
			// Token: 0x1700254D RID: 9549
			// (get) Token: 0x06010F65 RID: 69477 RVA: 0x00068790 File Offset: 0x00066990
			// (set) Token: 0x06010F66 RID: 69478 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700254D")]
			public int diceRoll
			{
				[Token(Token = "0x6010F65")]
				[Address(RVA = "0x8C6880", Offset = "0x8C5480", VA = "0x1808C6880")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6010F66")]
				[Address(RVA = "0x8C71B0", Offset = "0x8C5DB0", VA = "0x1808C71B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700254E RID: 9550
			// (get) Token: 0x06010F67 RID: 69479 RVA: 0x000687A8 File Offset: 0x000669A8
			[Token(Token = "0x1700254E")]
			public int san
			{
				[Token(Token = "0x6010F67")]
				[Address(RVA = "0x8C7030", Offset = "0x8C5C30", VA = "0x1808C7030")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700254F RID: 9551
			// (get) Token: 0x06010F68 RID: 69480 RVA: 0x000687C0 File Offset: 0x000669C0
			[Token(Token = "0x1700254F")]
			public int gold
			{
				[Token(Token = "0x6010F68")]
				[Address(RVA = "0x8C6C10", Offset = "0x8C5810", VA = "0x1808C6C10")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002550 RID: 9552
			// (get) Token: 0x06010F69 RID: 69481 RVA: 0x000687D8 File Offset: 0x000669D8
			[Token(Token = "0x17002550")]
			public bool isFragmentWeightLimit
			{
				[Token(Token = "0x6010F69")]
				[Address(RVA = "0x8C6E10", Offset = "0x8C5A10", VA = "0x1808C6E10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002551 RID: 9553
			// (get) Token: 0x06010F6A RID: 69482 RVA: 0x000687F0 File Offset: 0x000669F0
			[Token(Token = "0x17002551")]
			public bool hasInspiration
			{
				[Token(Token = "0x6010F6A")]
				[Address(RVA = "0x8C6C90", Offset = "0x8C5890", VA = "0x1808C6C90")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002552 RID: 9554
			// (get) Token: 0x06010F6B RID: 69483 RVA: 0x00068808 File Offset: 0x00066A08
			[Token(Token = "0x17002552")]
			public int inputHp
			{
				[Token(Token = "0x6010F6B")]
				[Address(RVA = "0x8C6D10", Offset = "0x8C5910", VA = "0x1808C6D10")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002553 RID: 9555
			// (get) Token: 0x06010F6C RID: 69484 RVA: 0x00068820 File Offset: 0x00066A20
			[Token(Token = "0x17002553")]
			public int inputShield
			{
				[Token(Token = "0x6010F6C")]
				[Address(RVA = "0x8C6D90", Offset = "0x8C5990", VA = "0x1808C6D90")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17002554 RID: 9556
			// (get) Token: 0x06010F6D RID: 69485 RVA: 0x00068838 File Offset: 0x00066A38
			[Token(Token = "0x17002554")]
			public PlayerNodeForesightType foresightType
			{
				[Token(Token = "0x6010F6D")]
				[Address(RVA = "0x8C6B00", Offset = "0x8C5700", VA = "0x1808C6B00")]
				get
				{
					return PlayerNodeForesightType.NORMAL;
				}
			}

			// Token: 0x17002555 RID: 9557
			// (get) Token: 0x06010F6E RID: 69486 RVA: 0x00068850 File Offset: 0x00066A50
			[Token(Token = "0x17002555")]
			public RoguelikeEventType eventType
			{
				[Token(Token = "0x6010F6E")]
				[Address(RVA = "0x8C6A00", Offset = "0x8C5600", VA = "0x1808C6A00")]
				get
				{
					return RoguelikeEventType.NONE;
				}
			}

			// Token: 0x17002556 RID: 9558
			// (get) Token: 0x06010F6F RID: 69487 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17002556")]
			public string eventTypeString
			{
				[Token(Token = "0x6010F6F")]
				[Address(RVA = "0x8C6980", Offset = "0x8C5580", VA = "0x1808C6980")]
				get
				{
					return null;
				}
			}

			// Token: 0x17002557 RID: 9559
			// (get) Token: 0x06010F70 RID: 69488 RVA: 0x00068868 File Offset: 0x00066A68
			[Token(Token = "0x17002557")]
			public bool isSpecialExpUIStyle
			{
				[Token(Token = "0x6010F70")]
				[Address(RVA = "0x8C6E90", Offset = "0x8C5A90", VA = "0x1808C6E90")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002558 RID: 9560
			// (get) Token: 0x06010F71 RID: 69489 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17002558")]
			public RoguelikeBattleManager battleManager
			{
				[Token(Token = "0x6010F71")]
				[Address(RVA = "0x8C6810", Offset = "0x8C5410", VA = "0x1808C6810")]
				get
				{
					return null;
				}
			}

			// Token: 0x17002559 RID: 9561
			// (get) Token: 0x06010F72 RID: 69490 RVA: 0x00068880 File Offset: 0x00066A80
			[Token(Token = "0x17002559")]
			public PlayerRoguelikeZoneType zoneType
			{
				[Token(Token = "0x6010F72")]
				[Address(RVA = "0x8C7130", Offset = "0x8C5D30", VA = "0x1808C7130")]
				get
				{
					return PlayerRoguelikeZoneType.NORMAL;
				}
			}

			// Token: 0x1700255A RID: 9562
			// (get) Token: 0x06010F73 RID: 69491 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700255A")]
			public List<uint> fragmentCarryCharUniqueList
			{
				[Token(Token = "0x6010F73")]
				[Address(RVA = "0x8C6B80", Offset = "0x8C5780", VA = "0x1808C6B80")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700255B RID: 9563
			// (get) Token: 0x06010F74 RID: 69492 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700255B")]
			public Dictionary<string, float> enemyHpInfo
			{
				[Token(Token = "0x6010F74")]
				[Address(RVA = "0x8C68F0", Offset = "0x8C54F0", VA = "0x1808C68F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700255C RID: 9564
			// (get) Token: 0x06010F75 RID: 69493 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700255C")]
			public static System.Random randomRogueScheduler
			{
				[Token(Token = "0x6010F75")]
				[Address(RVA = "0x8C6FA0", Offset = "0x8C5BA0", VA = "0x1808C6FA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700255D RID: 9565
			// (get) Token: 0x06010F76 RID: 69494 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700255D")]
			public static System.Random randomRogueRelic
			{
				[Token(Token = "0x6010F76")]
				[Address(RVA = "0x8C6F10", Offset = "0x8C5B10", VA = "0x1808C6F10")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700255E RID: 9566
			// (get) Token: 0x06010F77 RID: 69495 RVA: 0x00068898 File Offset: 0x00066A98
			[Token(Token = "0x1700255E")]
			public override GameModeMeta.GameModeType gameModeType
			{
				[Token(Token = "0x6010F77")]
				[Address(RVA = "0x8BF320", Offset = "0x8BDF20", VA = "0x1808BF320", Slot = "119")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x06010F78 RID: 69496 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010F78")]
			[Address(RVA = "0x8C1D20", Offset = "0x8C0920", VA = "0x1808C1D20", Slot = "155")]
			public override Scheduler.SchedulerPreprocessor GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x1700255F RID: 9567
			// (get) Token: 0x06010F79 RID: 69497 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700255F")]
			public RoguelikeBattleTopicHolder topicHolder
			{
				[Token(Token = "0x6010F79")]
				[Address(RVA = "0x8C70B0", Offset = "0x8C5CB0", VA = "0x1808C70B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17002560 RID: 9568
			// (get) Token: 0x06010F7A RID: 69498 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17002560")]
			public RoguelikeBattleExpManager expManager
			{
				[Token(Token = "0x6010F7A")]
				[Address(RVA = "0x8C6A80", Offset = "0x8C5680", VA = "0x1808C6A80")]
				get
				{
					return null;
				}
			}

			// Token: 0x06010F7B RID: 69499 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F7B")]
			[Address(RVA = "0x8C4660", Offset = "0x8C3260", VA = "0x1808C4660", Slot = "122")]
			public override void Init(ref GameModeMeta meta, ref int randomSeed, BattlePlayerData playerData, LevelData levelData)
			{
			}

			// Token: 0x06010F7C RID: 69500 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F7C")]
			[Address(RVA = "0x8C49D0", Offset = "0x8C35D0", VA = "0x1808C49D0", Slot = "123")]
			public override void OnPostInit()
			{
			}

			// Token: 0x06010F7D RID: 69501 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F7D")]
			[Address(RVA = "0x8C5370", Offset = "0x8C3F70", VA = "0x1808C5370", Slot = "141")]
			public override void PreprocessPlayerData(List<BattlePlayerData> dataList)
			{
			}

			// Token: 0x06010F7E RID: 69502 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F7E")]
			[Address(RVA = "0x8C5950", Offset = "0x8C4550", VA = "0x1808C5950")]
			private void _ProcessExtraProfession(BattleCharacterData data, Blackboard blackboard)
			{
			}

			// Token: 0x06010F7F RID: 69503 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010F7F")]
			[Address(RVA = "0x8C4AA0", Offset = "0x8C36A0", VA = "0x1808C4AA0", Slot = "135")]
			public override LevelData.Options PostprocessLevelOptions(LevelData.Options options)
			{
				return null;
			}

			// Token: 0x06010F80 RID: 69504 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F80")]
			[Address(RVA = "0x8C52B0", Offset = "0x8C3EB0", VA = "0x1808C52B0", Slot = "136")]
			public override void PreprocessLevelData(LevelData levelData)
			{
			}

			// Token: 0x06010F81 RID: 69505 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F81")]
			[Address(RVA = "0x8C4B60", Offset = "0x8C3760", VA = "0x1808C4B60", Slot = "139")]
			public override void PostprocessRuneExtraData(Rune.RuneLevelExtraOutput extraData)
			{
			}

			// Token: 0x06010F82 RID: 69506 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F82")]
			[Address(RVA = "0x8C5010", Offset = "0x8C3C10", VA = "0x1808C5010", Slot = "143")]
			public override void PreprocessCharacterCard(BattleCharacterData data, Character character)
			{
			}

			// Token: 0x06010F83 RID: 69507 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F83")]
			[Address(RVA = "0x8C4D00", Offset = "0x8C3900", VA = "0x1808C4D00", Slot = "144")]
			public override void PreProcessDeckCards(IList<Deck.Card> cards)
			{
			}

			// Token: 0x06010F84 RID: 69508 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F84")]
			[Address(RVA = "0x8C5160", Offset = "0x8C3D60", VA = "0x1808C5160", Slot = "147")]
			public override void PreprocessEnemy(LevelData.EnemyData data)
			{
			}

			// Token: 0x06010F85 RID: 69509 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F85")]
			[Address(RVA = "0x8C6590", Offset = "0x8C5190", VA = "0x1808C6590")]
			public RoguelikeGameMode(ref GameModeMeta meta)
			{
			}

			// Token: 0x06010F86 RID: 69510 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010F86")]
			[Address(RVA = "0x8C3D90", Offset = "0x8C2990", VA = "0x1808C3D90", Slot = "157")]
			public override List<LevelData.GlobalBuffData> GatherGlobalBuffs()
			{
				return null;
			}

			// Token: 0x06010F87 RID: 69511 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010F87")]
			[Address(RVA = "0x8C3D00", Offset = "0x8C2900", VA = "0x1808C3D00", Slot = "201")]
			public override List<GlobalEnvSystemData> GatherEnvSystems()
			{
				return null;
			}

			// Token: 0x06010F88 RID: 69512 RVA: 0x000688B0 File Offset: 0x00066AB0
			[Token(Token = "0x6010F88")]
			[Address(RVA = "0x8C48A0", Offset = "0x8C34A0", VA = "0x1808C48A0", Slot = "158")]
			public override bool NeedPreprocessPredefinedCharacter()
			{
				return default(bool);
			}

			// Token: 0x06010F89 RID: 69513 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010F89")]
			[Address(RVA = "0x8C3E20", Offset = "0x8C2A20", VA = "0x1808C3E20")]
			public static Dictionary<ResourceCollector.PreloadType, object> GatherPreloadAssets()
			{
				return null;
			}

			// Token: 0x06010F8A RID: 69514 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F8A")]
			[Address(RVA = "0x8C5EB0", Offset = "0x8C4AB0", VA = "0x1808C5EB0")]
			private static void _TryGatherGlobalbuffIds(RoguelikeBuff buff, HashSet<string> global_buff_ids)
			{
			}

			// Token: 0x06010F8B RID: 69515 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F8B")]
			[Address(RVA = "0x8C5D00", Offset = "0x8C4900", VA = "0x1808C5D00")]
			private static void _TryGatherEnvSystemIds(RoguelikeBuff buff, HashSet<string> env_system_ids)
			{
			}

			// Token: 0x06010F8C RID: 69516 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F8C")]
			[Address(RVA = "0x8C5AC0", Offset = "0x8C46C0", VA = "0x1808C5AC0")]
			private static void _TryGatherDynamicAbility(RoguelikeBuff buff, List<object> list)
			{
			}

			// Token: 0x06010F8D RID: 69517 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F8D")]
			[Address(RVA = "0x8C6340", Offset = "0x8C4F40", VA = "0x1808C6340")]
			private static void _TryGatherTempTokens(RoguelikeBuff buff, List<BattleCharacterData> list)
			{
			}

			// Token: 0x06010F8E RID: 69518 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F8E")]
			[Address(RVA = "0x8C6140", Offset = "0x8C4D40", VA = "0x1808C6140")]
			private static void _TryGatherTempCharacters(RoguelikeInput input, List<BattleCharacterData> charList, List<BattleCharacterData> tokenList)
			{
			}

			// Token: 0x06010F8F RID: 69519 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F8F")]
			[Address(RVA = "0x8C4930", Offset = "0x8C3530", VA = "0x1808C4930", Slot = "160")]
			public override void OnApplyingGlobalModifier(ref Modifier modifier)
			{
			}

			// Token: 0x06010F90 RID: 69520 RVA: 0x000688C8 File Offset: 0x00066AC8
			[Token(Token = "0x6010F90")]
			[Address(RVA = "0x8C5720", Offset = "0x8C4320", VA = "0x1808C5720")]
			public bool TryRollDice(out int diceVal)
			{
				return default(bool);
			}

			// Token: 0x06010F91 RID: 69521 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010F91")]
			[Address(RVA = "0x8C3B90", Offset = "0x8C2790", VA = "0x1808C3B90")]
			public RoguelikeOutput FetchGameOverBattleSnapshot()
			{
				return null;
			}

			// Token: 0x06010F92 RID: 69522 RVA: 0x000688E0 File Offset: 0x00066AE0
			[Token(Token = "0x6010F92")]
			[Address(RVA = "0x8C3C20", Offset = "0x8C2820", VA = "0x1808C3C20")]
			public bool FilterCharacterInCandleHolder(Character target)
			{
				return default(bool);
			}

			// Token: 0x06010F94 RID: 69524 RVA: 0x000688F8 File Offset: 0x00066AF8
			[Token(Token = "0x6010F94")]
			[Address(RVA = "0x83EAA0", Offset = "0x83D6A0", VA = "0x18083EAA0")]
			private GameModeMeta.GameModeType <>xLuaBaseProxy_get_gameModeType()
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}

			// Token: 0x06010F95 RID: 69525 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010F95")]
			[Address(RVA = "0x83EA70", Offset = "0x83D670", VA = "0x18083EA70")]
			private Scheduler.SchedulerPreprocessor <>xLuaBaseProxy_GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x06010F96 RID: 69526 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F96")]
			[Address(RVA = "0x83EA80", Offset = "0x83D680", VA = "0x18083EA80")]
			private void <>xLuaBaseProxy_Init(ref GameModeMeta P0, ref int P1, BattlePlayerData P2, LevelData P3)
			{
			}

			// Token: 0x06010F97 RID: 69527 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F97")]
			[Address(RVA = "0x85ABD0", Offset = "0x8597D0", VA = "0x18085ABD0")]
			private void <>xLuaBaseProxy_OnPostInit()
			{
			}

			// Token: 0x06010F98 RID: 69528 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F98")]
			[Address(RVA = "0x867A00", Offset = "0x866600", VA = "0x180867A00")]
			private void <>xLuaBaseProxy_PreprocessPlayerData(List<BattlePlayerData> P0)
			{
			}

			// Token: 0x06010F99 RID: 69529 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010F99")]
			[Address(RVA = "0x8B5580", Offset = "0x8B4180", VA = "0x1808B5580")]
			private LevelData.Options <>xLuaBaseProxy_PostprocessLevelOptions(LevelData.Options P0)
			{
				return null;
			}

			// Token: 0x06010F9A RID: 69530 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F9A")]
			[Address(RVA = "0x840AA0", Offset = "0x83F6A0", VA = "0x180840AA0")]
			private void <>xLuaBaseProxy_PreprocessLevelData(LevelData P0)
			{
			}

			// Token: 0x06010F9B RID: 69531 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F9B")]
			[Address(RVA = "0x8C5920", Offset = "0x8C4520", VA = "0x1808C5920")]
			private void <>xLuaBaseProxy_PostprocessRuneExtraData(Rune.RuneLevelExtraOutput P0)
			{
			}

			// Token: 0x06010F9C RID: 69532 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F9C")]
			[Address(RVA = "0x8C5940", Offset = "0x8C4540", VA = "0x1808C5940")]
			private void <>xLuaBaseProxy_PreprocessCharacterCard(BattleCharacterData P0, Character P1)
			{
			}

			// Token: 0x06010F9D RID: 69533 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F9D")]
			[Address(RVA = "0x8C5930", Offset = "0x8C4530", VA = "0x1808C5930")]
			private void <>xLuaBaseProxy_PreProcessDeckCards(IList<Deck.Card> P0)
			{
			}

			// Token: 0x06010F9E RID: 69534 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010F9E")]
			[Address(RVA = "0x85ABE0", Offset = "0x8597E0", VA = "0x18085ABE0")]
			private void <>xLuaBaseProxy_PreprocessEnemy(LevelData.EnemyData P0)
			{
			}

			// Token: 0x06010F9F RID: 69535 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010F9F")]
			[Address(RVA = "0x867940", Offset = "0x866540", VA = "0x180867940")]
			private List<LevelData.GlobalBuffData> <>xLuaBaseProxy_GatherGlobalBuffs()
			{
				return null;
			}

			// Token: 0x06010FA0 RID: 69536 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010FA0")]
			[Address(RVA = "0x8C5900", Offset = "0x8C4500", VA = "0x1808C5900")]
			private List<GlobalEnvSystemData> <>xLuaBaseProxy_GatherEnvSystems()
			{
				return null;
			}

			// Token: 0x06010FA1 RID: 69537 RVA: 0x00068910 File Offset: 0x00066B10
			[Token(Token = "0x6010FA1")]
			[Address(RVA = "0x8C5910", Offset = "0x8C4510", VA = "0x1808C5910")]
			private bool <>xLuaBaseProxy_NeedPreprocessPredefinedCharacter()
			{
				return default(bool);
			}

			// Token: 0x06010FA2 RID: 69538 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FA2")]
			[Address(RVA = "0x858C80", Offset = "0x857880", VA = "0x180858C80")]
			private void <>xLuaBaseProxy_OnApplyingGlobalModifier(ref Modifier P0)
			{
			}

			// Token: 0x0401306F RID: 77935
			[Token(Token = "0x401306F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected RoguelikeInput m_input;

			// Token: 0x04013070 RID: 77936
			[Token(Token = "0x4013070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			protected RoguelikeOutput m_output;

			// Token: 0x04013071 RID: 77937
			[Token(Token = "0x4013071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private RoguelikeBattleManager m_roguelikeManager;

			// Token: 0x04013072 RID: 77938
			[Token(Token = "0x4013072")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private RoguelikeBattleExpManager m_expManager;

			// Token: 0x04013073 RID: 77939
			[Token(Token = "0x4013073")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private RoguelikeBattleTopicHolder m_topicHolder;

			// Token: 0x04013074 RID: 77940
			[Token(Token = "0x4013074")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private List<int> m_diceRoll;

			// Token: 0x04013075 RID: 77941
			[Token(Token = "0x4013075")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private int m_diceIndex;

			// Token: 0x04013077 RID: 77943
			[Token(Token = "0x4013077")]
			private const RandomFactory.AlgorithmType RANDOM_ALGORITHM = RandomFactory.AlgorithmType.DEFAULT;

			// Token: 0x04013078 RID: 77944
			[Token(Token = "0x4013078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static System.Random s_randomRogueScheduler;

			// Token: 0x04013079 RID: 77945
			[Token(Token = "0x4013079")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static System.Random s_randomRogueRelic;

			// Token: 0x0401307A RID: 77946
			[Token(Token = "0x401307A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_diceRoll;

			// Token: 0x0401307B RID: 77947
			[Token(Token = "0x401307B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_diceRoll;

			// Token: 0x0401307C RID: 77948
			[Token(Token = "0x401307C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_san;

			// Token: 0x0401307D RID: 77949
			[Token(Token = "0x401307D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_gold;

			// Token: 0x0401307E RID: 77950
			[Token(Token = "0x401307E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_isFragmentWeightLimit;

			// Token: 0x0401307F RID: 77951
			[Token(Token = "0x401307F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_hasInspiration;

			// Token: 0x04013080 RID: 77952
			[Token(Token = "0x4013080")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_inputHp;

			// Token: 0x04013081 RID: 77953
			[Token(Token = "0x4013081")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_inputShield;

			// Token: 0x04013082 RID: 77954
			[Token(Token = "0x4013082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_foresightType;

			// Token: 0x04013083 RID: 77955
			[Token(Token = "0x4013083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_eventType;

			// Token: 0x04013084 RID: 77956
			[Token(Token = "0x4013084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_eventTypeString;

			// Token: 0x04013085 RID: 77957
			[Token(Token = "0x4013085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_isSpecialExpUIStyle;

			// Token: 0x04013086 RID: 77958
			[Token(Token = "0x4013086")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_battleManager;

			// Token: 0x04013087 RID: 77959
			[Token(Token = "0x4013087")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_get_zoneType;

			// Token: 0x04013088 RID: 77960
			[Token(Token = "0x4013088")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_get_fragmentCarryCharUniqueList;

			// Token: 0x04013089 RID: 77961
			[Token(Token = "0x4013089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_get_enemyHpInfo;

			// Token: 0x0401308A RID: 77962
			[Token(Token = "0x401308A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_get_randomRogueScheduler;

			// Token: 0x0401308B RID: 77963
			[Token(Token = "0x401308B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_get_randomRogueRelic;

			// Token: 0x0401308C RID: 77964
			[Token(Token = "0x401308C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_get_gameModeType;

			// Token: 0x0401308D RID: 77965
			[Token(Token = "0x401308D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_GetSchedulerPreprocessor;

			// Token: 0x0401308E RID: 77966
			[Token(Token = "0x401308E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_get_topicHolder;

			// Token: 0x0401308F RID: 77967
			[Token(Token = "0x401308F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_get_expManager;

			// Token: 0x04013090 RID: 77968
			[Token(Token = "0x4013090")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x04013091 RID: 77969
			[Token(Token = "0x4013091")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_OnPostInit;

			// Token: 0x04013092 RID: 77970
			[Token(Token = "0x4013092")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0_PreprocessPlayerData;

			// Token: 0x04013093 RID: 77971
			[Token(Token = "0x4013093")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0__ProcessExtraProfession;

			// Token: 0x04013094 RID: 77972
			[Token(Token = "0x4013094")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0_PostprocessLevelOptions;

			// Token: 0x04013095 RID: 77973
			[Token(Token = "0x4013095")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0_PreprocessLevelData;

			// Token: 0x04013096 RID: 77974
			[Token(Token = "0x4013096")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private static DelegateBridge __Hotfix0_PostprocessRuneExtraData;

			// Token: 0x04013097 RID: 77975
			[Token(Token = "0x4013097")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private static DelegateBridge __Hotfix0_PreprocessCharacterCard;

			// Token: 0x04013098 RID: 77976
			[Token(Token = "0x4013098")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			private static DelegateBridge __Hotfix0_PreProcessDeckCards;

			// Token: 0x04013099 RID: 77977
			[Token(Token = "0x4013099")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private static DelegateBridge __Hotfix0_PreprocessEnemy;

			// Token: 0x0401309A RID: 77978
			[Token(Token = "0x401309A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401309B RID: 77979
			[Token(Token = "0x401309B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private static DelegateBridge __Hotfix0_GatherGlobalBuffs;

			// Token: 0x0401309C RID: 77980
			[Token(Token = "0x401309C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private static DelegateBridge __Hotfix0_GatherEnvSystems;

			// Token: 0x0401309D RID: 77981
			[Token(Token = "0x401309D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private static DelegateBridge __Hotfix0_NeedPreprocessPredefinedCharacter;

			// Token: 0x0401309E RID: 77982
			[Token(Token = "0x401309E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private static DelegateBridge __Hotfix0_GatherPreloadAssets;

			// Token: 0x0401309F RID: 77983
			[Token(Token = "0x401309F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private static DelegateBridge __Hotfix0__TryGatherGlobalbuffIds;

			// Token: 0x040130A0 RID: 77984
			[Token(Token = "0x40130A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private static DelegateBridge __Hotfix0__TryGatherEnvSystemIds;

			// Token: 0x040130A1 RID: 77985
			[Token(Token = "0x40130A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			private static DelegateBridge __Hotfix0__TryGatherDynamicAbility;

			// Token: 0x040130A2 RID: 77986
			[Token(Token = "0x40130A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			private static DelegateBridge __Hotfix0__TryGatherTempTokens;

			// Token: 0x040130A3 RID: 77987
			[Token(Token = "0x40130A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			private static DelegateBridge __Hotfix0__TryGatherTempCharacters;

			// Token: 0x040130A4 RID: 77988
			[Token(Token = "0x40130A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			private static DelegateBridge __Hotfix0_OnApplyingGlobalModifier;

			// Token: 0x040130A5 RID: 77989
			[Token(Token = "0x40130A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private static DelegateBridge __Hotfix0_TryRollDice;

			// Token: 0x040130A6 RID: 77990
			[Token(Token = "0x40130A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			private static DelegateBridge __Hotfix0_FetchGameOverBattleSnapshot;

			// Token: 0x040130A7 RID: 77991
			[Token(Token = "0x40130A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private static DelegateBridge __Hotfix0_FilterCharacterInCandleHolder;
		}

		// Token: 0x020027FB RID: 10235
		[Token(Token = "0x20027FB")]
		public class SandboxGameMode : GameModeFactory.DefaultGameMode
		{
			// Token: 0x17002561 RID: 9569
			// (get) Token: 0x06010FA3 RID: 69539 RVA: 0x00068928 File Offset: 0x00066B28
			[Token(Token = "0x17002561")]
			private BattleRenderInvisibleMask renderInvisibleMask
			{
				[Token(Token = "0x6010FA3")]
				[Address(RVA = "0x8FE860", Offset = "0x8FD460", VA = "0x1808FE860")]
				get
				{
					return BattleRenderInvisibleMask.NONE;
				}
			}

			// Token: 0x17002562 RID: 9570
			// (get) Token: 0x06010FA4 RID: 69540 RVA: 0x00068940 File Offset: 0x00066B40
			[Token(Token = "0x17002562")]
			private BattleRenderInvisibleMask renderCameraVisibleMask
			{
				[Token(Token = "0x6010FA4")]
				[Address(RVA = "0x8FE800", Offset = "0x8FD400", VA = "0x1808FE800")]
				get
				{
					return BattleRenderInvisibleMask.NONE;
				}
			}

			// Token: 0x06010FA5 RID: 69541 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FA5")]
			[Address(RVA = "0x8FDCC0", Offset = "0x8FC8C0", VA = "0x1808FDCC0")]
			public SandboxGameMode(ref GameModeMeta meta)
			{
			}

			// Token: 0x17002563 RID: 9571
			// (get) Token: 0x06010FA6 RID: 69542 RVA: 0x00068958 File Offset: 0x00066B58
			[Token(Token = "0x17002563")]
			public bool isInMonthlyBattle
			{
				[Token(Token = "0x6010FA6")]
				[Address(RVA = "0x8FE270", Offset = "0x8FCE70", VA = "0x1808FE270")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002564 RID: 9572
			// (get) Token: 0x06010FA7 RID: 69543 RVA: 0x00068970 File Offset: 0x00066B70
			[Token(Token = "0x17002564")]
			public bool isRushEnemyMode
			{
				[Token(Token = "0x6010FA7")]
				[Address(RVA = "0x8FE530", Offset = "0x8FD130", VA = "0x1808FE530")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002565 RID: 9573
			// (get) Token: 0x06010FA8 RID: 69544 RVA: 0x00068988 File Offset: 0x00066B88
			[Token(Token = "0x17002565")]
			public bool isRacerCatchMode
			{
				[Token(Token = "0x6010FA8")]
				[Address(RVA = "0x8FE4D0", Offset = "0x8FD0D0", VA = "0x1808FE4D0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002566 RID: 9574
			// (get) Token: 0x06010FA9 RID: 69545 RVA: 0x000689A0 File Offset: 0x00066BA0
			[Token(Token = "0x17002566")]
			public bool isTimingMode
			{
				[Token(Token = "0x6010FA9")]
				[Address(RVA = "0x8FE590", Offset = "0x8FD190", VA = "0x1808FE590")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002567 RID: 9575
			// (get) Token: 0x06010FAA RID: 69546 RVA: 0x000689B8 File Offset: 0x00066BB8
			[Token(Token = "0x17002567")]
			public bool isInfiniteTimeLevel
			{
				[Token(Token = "0x6010FAA")]
				[Address(RVA = "0x8FE380", Offset = "0x8FCF80", VA = "0x1808FE380")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002568 RID: 9576
			// (get) Token: 0x06010FAB RID: 69547 RVA: 0x000689D0 File Offset: 0x00066BD0
			[Token(Token = "0x17002568")]
			public bool isInMarketType
			{
				[Token(Token = "0x6010FAB")]
				[Address(RVA = "0x8FE200", Offset = "0x8FCE00", VA = "0x1808FE200")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002569 RID: 9577
			// (get) Token: 0x06010FAC RID: 69548 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17002569")]
			public SandboxV2Data configData
			{
				[Token(Token = "0x6010FAC")]
				[Address(RVA = "0x8FDF00", Offset = "0x8FCB00", VA = "0x1808FDF00")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700256A RID: 9578
			// (get) Token: 0x06010FAD RID: 69549 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700256A")]
			public Dictionary<string, string> materialKeywordData
			{
				[Token(Token = "0x6010FAD")]
				[Address(RVA = "0x8FE6B0", Offset = "0x8FD2B0", VA = "0x1808FE6B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700256B RID: 9579
			// (get) Token: 0x06010FAE RID: 69550 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700256B")]
			public SandboxBattleManager battleManager
			{
				[Token(Token = "0x6010FAE")]
				[Address(RVA = "0x8FDEA0", Offset = "0x8FCAA0", VA = "0x1808FDEA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700256C RID: 9580
			// (get) Token: 0x06010FAF RID: 69551 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700256C")]
			public string topicId
			{
				[Token(Token = "0x6010FAF")]
				[Address(RVA = "0x8FE8C0", Offset = "0x8FD4C0", VA = "0x1808FE8C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700256D RID: 9581
			// (get) Token: 0x06010FB0 RID: 69552 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700256D")]
			public SandboxInput input
			{
				[Token(Token = "0x6010FB0")]
				[Address(RVA = "0x8FE140", Offset = "0x8FCD40", VA = "0x1808FE140")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700256E RID: 9582
			// (get) Token: 0x06010FB1 RID: 69553 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700256E")]
			public SandboxOutput output
			{
				[Token(Token = "0x6010FB1")]
				[Address(RVA = "0x8FE7A0", Offset = "0x8FD3A0", VA = "0x1808FE7A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700256F RID: 9583
			// (get) Token: 0x06010FB2 RID: 69554 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700256F")]
			public LevelData levelData
			{
				[Token(Token = "0x6010FB2")]
				[Address(RVA = "0x8FE650", Offset = "0x8FD250", VA = "0x1808FE650")]
				get
				{
					return null;
				}
			}

			// Token: 0x17002570 RID: 9584
			// (get) Token: 0x06010FB3 RID: 69555 RVA: 0x000689E8 File Offset: 0x00066BE8
			[Token(Token = "0x17002570")]
			public SandboxV2NodeType currentNodeType
			{
				[Token(Token = "0x6010FB3")]
				[Address(RVA = "0x8FDF60", Offset = "0x8FCB60", VA = "0x1808FDF60")]
				get
				{
					return SandboxV2NodeType.NONE;
				}
			}

			// Token: 0x17002571 RID: 9585
			// (get) Token: 0x06010FB4 RID: 69556 RVA: 0x00068A00 File Offset: 0x00066C00
			[Token(Token = "0x17002571")]
			public SandboxV2SeasonType currentSeasonType
			{
				[Token(Token = "0x6010FB4")]
				[Address(RVA = "0x8FDFE0", Offset = "0x8FCBE0", VA = "0x1808FDFE0")]
				get
				{
					return SandboxV2SeasonType.NONE;
				}
			}

			// Token: 0x17002572 RID: 9586
			// (get) Token: 0x06010FB5 RID: 69557 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17002572")]
			public string currentWeatherId
			{
				[Token(Token = "0x6010FB5")]
				[Address(RVA = "0x8FE060", Offset = "0x8FCC60", VA = "0x1808FE060")]
				get
				{
					return null;
				}
			}

			// Token: 0x17002573 RID: 9587
			// (get) Token: 0x06010FB6 RID: 69558 RVA: 0x00068A18 File Offset: 0x00066C18
			[Token(Token = "0x17002573")]
			public bool isInBuildType
			{
				[Token(Token = "0x6010FB6")]
				[Address(RVA = "0x8FE1A0", Offset = "0x8FCDA0", VA = "0x1808FE1A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06010FB7 RID: 69559 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010FB7")]
			[Address(RVA = "0x8FBAB0", Offset = "0x8FA6B0", VA = "0x1808FBAB0")]
			public SandboxOutput FetchGameOverOutput()
			{
				return null;
			}

			// Token: 0x06010FB8 RID: 69560 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FB8")]
			[Address(RVA = "0x8FC720", Offset = "0x8FB320", VA = "0x1808FC720", Slot = "122")]
			public override void Init(ref GameModeMeta meta, ref int randomSeed, BattlePlayerData playerData, LevelData levelData)
			{
			}

			// Token: 0x06010FB9 RID: 69561 RVA: 0x00068A30 File Offset: 0x00066C30
			[Token(Token = "0x6010FB9")]
			[Address(RVA = "0x8FC440", Offset = "0x8FB040", VA = "0x1808FC440")]
			public bool HaveRemainAp()
			{
				return default(bool);
			}

			// Token: 0x06010FBA RID: 69562 RVA: 0x00068A48 File Offset: 0x00066C48
			[Token(Token = "0x6010FBA")]
			[Address(RVA = "0x8FC3D0", Offset = "0x8FAFD0", VA = "0x1808FC3D0")]
			public bool HaveEscapeTrap()
			{
				return default(bool);
			}

			// Token: 0x06010FBB RID: 69563 RVA: 0x00068A60 File Offset: 0x00066C60
			[Token(Token = "0x6010FBB")]
			[Address(RVA = "0x8FC250", Offset = "0x8FAE50", VA = "0x1808FC250")]
			public int GetFarmRemainingTime()
			{
				return 0;
			}

			// Token: 0x06010FBC RID: 69564 RVA: 0x00068A78 File Offset: 0x00066C78
			[Token(Token = "0x6010FBC")]
			[Address(RVA = "0x8FC0F0", Offset = "0x8FACF0", VA = "0x1808FC0F0")]
			public int GetFarmMaxTime()
			{
				return 0;
			}

			// Token: 0x06010FBD RID: 69565 RVA: 0x00068A90 File Offset: 0x00066C90
			[Token(Token = "0x6010FBD")]
			[Address(RVA = "0x8FC180", Offset = "0x8FAD80", VA = "0x1808FC180")]
			public float GetFarmProgress()
			{
				return 0f;
			}

			// Token: 0x17002574 RID: 9588
			// (get) Token: 0x06010FBE RID: 69566 RVA: 0x00068AA8 File Offset: 0x00066CA8
			[Token(Token = "0x17002574")]
			public override GameModeMeta.GameModeType gameModeType
			{
				[Token(Token = "0x6010FBE")]
				[Address(RVA = "0x8FE0E0", Offset = "0x8FCCE0", VA = "0x1808FE0E0", Slot = "119")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x17002575 RID: 9589
			// (get) Token: 0x06010FBF RID: 69567 RVA: 0x00068AC0 File Offset: 0x00066CC0
			[Token(Token = "0x17002575")]
			public override bool isLargeMap
			{
				[Token(Token = "0x6010FBF")]
				[Address(RVA = "0x8FE470", Offset = "0x8FD070", VA = "0x1808FE470", Slot = "105")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06010FC0 RID: 69568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FC0")]
			[Address(RVA = "0x8FD5B0", Offset = "0x8FC1B0", VA = "0x1808FD5B0", Slot = "126")]
			public override void Tick(Action doDefaultTick)
			{
			}

			// Token: 0x06010FC1 RID: 69569 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FC1")]
			[Address(RVA = "0x8FDB30", Offset = "0x8FC730", VA = "0x1808FDB30")]
			private void _CheckGameFinish()
			{
			}

			// Token: 0x06010FC2 RID: 69570 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010FC2")]
			[Address(RVA = "0x8FC5E0", Offset = "0x8FB1E0", VA = "0x1808FC5E0", Slot = "166")]
			public override string HookTileEffect(string originEffectKey)
			{
				return null;
			}

			// Token: 0x06010FC3 RID: 69571 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010FC3")]
			[Address(RVA = "0x8FC4B0", Offset = "0x8FB0B0", VA = "0x1808FC4B0", Slot = "168")]
			public override string HookTileAppendInfoKey(string originTileKey)
			{
				return null;
			}

			// Token: 0x06010FC4 RID: 69572 RVA: 0x00068AD8 File Offset: 0x00066CD8
			[Token(Token = "0x6010FC4")]
			[Address(RVA = "0x8FBA10", Offset = "0x8FA610", VA = "0x1808FBA10", Slot = "165")]
			public override bool CheckTileValid(int row, int col)
			{
				return default(bool);
			}

			// Token: 0x06010FC5 RID: 69573 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FC5")]
			[Address(RVA = "0x8FCD70", Offset = "0x8FB970", VA = "0x1808FCD70", Slot = "125")]
			public override void OnGameOver(ref BattleController.GameResult result)
			{
			}

			// Token: 0x06010FC6 RID: 69574 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FC6")]
			[Address(RVA = "0x8FD320", Offset = "0x8FBF20", VA = "0x1808FD320", Slot = "142")]
			public override void PreprocessPlayerDeckList(ListDict<PlayerSide, Deck> deckList)
			{
			}

			// Token: 0x06010FC7 RID: 69575 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FC7")]
			[Address(RVA = "0x8FD140", Offset = "0x8FBD40", VA = "0x1808FD140", Slot = "143")]
			public override void PreprocessCharacterCard(BattleCharacterData data, Character character)
			{
			}

			// Token: 0x06010FC8 RID: 69576 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FC8")]
			[Address(RVA = "0x8FD200", Offset = "0x8FBE00", VA = "0x1808FD200", Slot = "147")]
			public override void PreprocessEnemy(LevelData.EnemyData data)
			{
			}

			// Token: 0x06010FC9 RID: 69577 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FC9")]
			[Address(RVA = "0x8FD3B0", Offset = "0x8FBFB0", VA = "0x1808FD3B0", Slot = "138")]
			public override void PreprocessRuneData(RuneManager manager)
			{
			}

			// Token: 0x06010FCA RID: 69578 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FCA")]
			[Address(RVA = "0x8FD440", Offset = "0x8FC040", VA = "0x1808FD440", Slot = "145")]
			public override void SortDeck(Deck.Card[] cards)
			{
			}

			// Token: 0x06010FCB RID: 69579 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010FCB")]
			[Address(RVA = "0x8FC360", Offset = "0x8FAF60", VA = "0x1808FC360", Slot = "155")]
			public override Scheduler.SchedulerPreprocessor GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x06010FCC RID: 69580 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010FCC")]
			[Address(RVA = "0x8FBF00", Offset = "0x8FAB00", VA = "0x1808FBF00", Slot = "157")]
			public override List<LevelData.GlobalBuffData> GatherGlobalBuffs()
			{
				return null;
			}

			// Token: 0x06010FCD RID: 69581 RVA: 0x00068AF0 File Offset: 0x00066CF0
			[Token(Token = "0x6010FCD")]
			[Address(RVA = "0x8FB720", Offset = "0x8FA320", VA = "0x1808FB720", Slot = "169")]
			public override bool CheckCardReadyToSpawn(Deck.Card card)
			{
				return default(bool);
			}

			// Token: 0x06010FCE RID: 69582 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FCE")]
			[Address(RVA = "0x8FCC10", Offset = "0x8FB810", VA = "0x1808FCC10", Slot = "163")]
			public override void OnCharacterFinished(Character character, Entity.FinishReason reason)
			{
			}

			// Token: 0x06010FCF RID: 69583 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FCF")]
			[Address(RVA = "0x8FCCC0", Offset = "0x8FB8C0", VA = "0x1808FCCC0", Slot = "164")]
			public override void OnEnemyFinished(Enemy enemy, Entity.FinishReason reason)
			{
			}

			// Token: 0x06010FD0 RID: 69584 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FD0")]
			[Address(RVA = "0x8FCF60", Offset = "0x8FBB60", VA = "0x1808FCF60", Slot = "161")]
			public override void OnUnitRegistered(Unit unit)
			{
			}

			// Token: 0x06010FD1 RID: 69585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FD1")]
			[Address(RVA = "0x8FCB80", Offset = "0x8FB780", VA = "0x1808FCB80", Slot = "172")]
			public override void OnCardListChanged(Deck.Card card)
			{
			}

			// Token: 0x06010FD2 RID: 69586 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FD2")]
			[Address(RVA = "0x8FD520", Offset = "0x8FC120", VA = "0x1808FD520", Slot = "124")]
			public override void StartGame(Action doDefaultStart)
			{
			}

			// Token: 0x06010FD3 RID: 69587 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010FD3")]
			[Address(RVA = "0x8FBB20", Offset = "0x8FA720", VA = "0x1808FBB20", Slot = "181")]
			public override IEnumerator FinalSchedule()
			{
				return null;
			}

			// Token: 0x06010FD4 RID: 69588 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FD4")]
			[Address(RVA = "0x8FD290", Offset = "0x8FBE90", VA = "0x1808FD290", Slot = "156")]
			public override void PreprocessLevelWithScheduler(LevelData levelData)
			{
			}

			// Token: 0x06010FD5 RID: 69589 RVA: 0x00068B08 File Offset: 0x00066D08
			[Token(Token = "0x6010FD5")]
			[Address(RVA = "0x8FBD80", Offset = "0x8FA980", VA = "0x1808FBD80", Slot = "151")]
			public override bool GameNotFinishCondition()
			{
				return default(bool);
			}

			// Token: 0x06010FD6 RID: 69590 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010FD6")]
			[Address(RVA = "0x8FBF70", Offset = "0x8FAB70", VA = "0x1808FBF70", Slot = "183")]
			public override object GetActMeta()
			{
				return null;
			}

			// Token: 0x06010FD7 RID: 69591 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FD7")]
			[Address(RVA = "0x8FBBD0", Offset = "0x8FA7D0", VA = "0x1808FBBD0", Slot = "182")]
			public override void FinishGame(Action<BattleController.GameResult, bool> gameFinishCallback, BattleController.GameResult result, bool silent = false)
			{
			}

			// Token: 0x06010FD8 RID: 69592 RVA: 0x00068B20 File Offset: 0x00066D20
			[Token(Token = "0x6010FD8")]
			[Address(RVA = "0x8FC030", Offset = "0x8FAC30", VA = "0x1808FC030", Slot = "184")]
			public override PlayerBattleRank GetBattleCompleteRank()
			{
				return (PlayerBattleRank)0;
			}

			// Token: 0x06010FD9 RID: 69593 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FD9")]
			[Address(RVA = "0x8FD0B0", Offset = "0x8FBCB0", VA = "0x1808FD0B0", Slot = "140")]
			public override void PostprocessMap(Map map)
			{
			}

			// Token: 0x06010FDA RID: 69594 RVA: 0x00068B38 File Offset: 0x00066D38
			[Token(Token = "0x6010FDA")]
			[Address(RVA = "0x8FB7C0", Offset = "0x8FA3C0", VA = "0x1808FB7C0", Slot = "180")]
			public override bool CheckRenderInvisible(Entity entity, BattleRenderInvisibleMask mask)
			{
				return default(bool);
			}

			// Token: 0x06010FDB RID: 69595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FDB")]
			[Address(RVA = "0x8FCE00", Offset = "0x8FBA00", VA = "0x1808FCE00", Slot = "123")]
			public override void OnPostInit()
			{
			}

			// Token: 0x06010FDD RID: 69597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FDD")]
			[Address(RVA = "0x83EA80", Offset = "0x83D680", VA = "0x18083EA80")]
			private void <>xLuaBaseProxy_Init(ref GameModeMeta P0, ref int P1, BattlePlayerData P2, LevelData P3)
			{
			}

			// Token: 0x06010FDE RID: 69598 RVA: 0x00068B68 File Offset: 0x00066D68
			[Token(Token = "0x6010FDE")]
			[Address(RVA = "0x83EAA0", Offset = "0x83D6A0", VA = "0x18083EAA0")]
			private GameModeMeta.GameModeType <>xLuaBaseProxy_get_gameModeType()
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}

			// Token: 0x06010FDF RID: 69599 RVA: 0x00068B80 File Offset: 0x00066D80
			[Token(Token = "0x6010FDF")]
			[Address(RVA = "0x85AC70", Offset = "0x859870", VA = "0x18085AC70")]
			private bool <>xLuaBaseProxy_get_isLargeMap()
			{
				return default(bool);
			}

			// Token: 0x06010FE0 RID: 69600 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FE0")]
			[Address(RVA = "0x83EA90", Offset = "0x83D690", VA = "0x18083EA90")]
			private void <>xLuaBaseProxy_Tick(Action P0)
			{
			}

			// Token: 0x06010FE1 RID: 69601 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010FE1")]
			[Address(RVA = "0x8FDB00", Offset = "0x8FC700", VA = "0x1808FDB00")]
			private string <>xLuaBaseProxy_HookTileEffect(string P0)
			{
				return null;
			}

			// Token: 0x06010FE2 RID: 69602 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010FE2")]
			[Address(RVA = "0x840A60", Offset = "0x83F660", VA = "0x180840A60")]
			private string <>xLuaBaseProxy_HookTileAppendInfoKey(string P0)
			{
				return null;
			}

			// Token: 0x06010FE3 RID: 69603 RVA: 0x00068B98 File Offset: 0x00066D98
			[Token(Token = "0x6010FE3")]
			[Address(RVA = "0x8FDAE0", Offset = "0x8FC6E0", VA = "0x1808FDAE0")]
			private bool <>xLuaBaseProxy_CheckTileValid(int P0, int P1)
			{
				return default(bool);
			}

			// Token: 0x06010FE4 RID: 69604 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FE4")]
			[Address(RVA = "0x884DA0", Offset = "0x8839A0", VA = "0x180884DA0")]
			private void <>xLuaBaseProxy_OnGameOver(ref BattleController.GameResult P0)
			{
			}

			// Token: 0x06010FE5 RID: 69605 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FE5")]
			[Address(RVA = "0x8B5590", Offset = "0x8B4190", VA = "0x1808B5590")]
			private void <>xLuaBaseProxy_PreprocessPlayerDeckList(ListDict<PlayerSide, Deck> P0)
			{
			}

			// Token: 0x06010FE6 RID: 69606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FE6")]
			[Address(RVA = "0x8C5940", Offset = "0x8C4540", VA = "0x1808C5940")]
			private void <>xLuaBaseProxy_PreprocessCharacterCard(BattleCharacterData P0, Character P1)
			{
			}

			// Token: 0x06010FE7 RID: 69607 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FE7")]
			[Address(RVA = "0x85ABE0", Offset = "0x8597E0", VA = "0x18085ABE0")]
			private void <>xLuaBaseProxy_PreprocessEnemy(LevelData.EnemyData P0)
			{
			}

			// Token: 0x06010FE8 RID: 69608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FE8")]
			[Address(RVA = "0x8FDB20", Offset = "0x8FC720", VA = "0x1808FDB20")]
			private void <>xLuaBaseProxy_PreprocessRuneData(RuneManager P0)
			{
			}

			// Token: 0x06010FE9 RID: 69609 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FE9")]
			[Address(RVA = "0x858CC0", Offset = "0x8578C0", VA = "0x180858CC0")]
			private void <>xLuaBaseProxy_SortDeck(Deck.Card[] P0)
			{
			}

			// Token: 0x06010FEA RID: 69610 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010FEA")]
			[Address(RVA = "0x83EA70", Offset = "0x83D670", VA = "0x18083EA70")]
			private Scheduler.SchedulerPreprocessor <>xLuaBaseProxy_GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x06010FEB RID: 69611 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010FEB")]
			[Address(RVA = "0x867940", Offset = "0x866540", VA = "0x180867940")]
			private List<LevelData.GlobalBuffData> <>xLuaBaseProxy_GatherGlobalBuffs()
			{
				return null;
			}

			// Token: 0x06010FEC RID: 69612 RVA: 0x00068BB0 File Offset: 0x00066DB0
			[Token(Token = "0x6010FEC")]
			[Address(RVA = "0x867930", Offset = "0x866530", VA = "0x180867930")]
			private bool <>xLuaBaseProxy_CheckCardReadyToSpawn(Deck.Card P0)
			{
				return default(bool);
			}

			// Token: 0x06010FED RID: 69613 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FED")]
			[Address(RVA = "0x858C90", Offset = "0x857890", VA = "0x180858C90")]
			private void <>xLuaBaseProxy_OnCharacterFinished(Character P0, Entity.FinishReason P1)
			{
			}

			// Token: 0x06010FEE RID: 69614 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FEE")]
			[Address(RVA = "0x840A70", Offset = "0x83F670", VA = "0x180840A70")]
			private void <>xLuaBaseProxy_OnEnemyFinished(Enemy P0, Entity.FinishReason P1)
			{
			}

			// Token: 0x06010FEF RID: 69615 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FEF")]
			[Address(RVA = "0x840A90", Offset = "0x83F690", VA = "0x180840A90")]
			private void <>xLuaBaseProxy_OnUnitRegistered(Unit P0)
			{
			}

			// Token: 0x06010FF0 RID: 69616 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FF0")]
			[Address(RVA = "0x867980", Offset = "0x866580", VA = "0x180867980")]
			private void <>xLuaBaseProxy_OnCardListChanged(Deck.Card P0)
			{
			}

			// Token: 0x06010FF1 RID: 69617 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FF1")]
			[Address(RVA = "0x840AB0", Offset = "0x83F6B0", VA = "0x180840AB0")]
			private void <>xLuaBaseProxy_StartGame(Action P0)
			{
			}

			// Token: 0x06010FF2 RID: 69618 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010FF2")]
			[Address(RVA = "0x8FDAF0", Offset = "0x8FC6F0", VA = "0x1808FDAF0")]
			private IEnumerator <>xLuaBaseProxy_FinalSchedule()
			{
				return null;
			}

			// Token: 0x06010FF3 RID: 69619 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FF3")]
			[Address(RVA = "0x8FDB10", Offset = "0x8FC710", VA = "0x1808FDB10")]
			private void <>xLuaBaseProxy_PreprocessLevelWithScheduler(LevelData P0)
			{
			}

			// Token: 0x06010FF4 RID: 69620 RVA: 0x00068BC8 File Offset: 0x00066DC8
			[Token(Token = "0x6010FF4")]
			[Address(RVA = "0x840A30", Offset = "0x83F630", VA = "0x180840A30")]
			private bool <>xLuaBaseProxy_GameNotFinishCondition()
			{
				return default(bool);
			}

			// Token: 0x06010FF5 RID: 69621 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010FF5")]
			[Address(RVA = "0x858C30", Offset = "0x857830", VA = "0x180858C30")]
			private object <>xLuaBaseProxy_GetActMeta()
			{
				return null;
			}

			// Token: 0x06010FF6 RID: 69622 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FF6")]
			[Address(RVA = "0x85AB90", Offset = "0x859790", VA = "0x18085AB90")]
			private void <>xLuaBaseProxy_FinishGame(Action<BattleController.GameResult, bool> P0, BattleController.GameResult P1, bool P2)
			{
			}

			// Token: 0x06010FF7 RID: 69623 RVA: 0x00068BE0 File Offset: 0x00066DE0
			[Token(Token = "0x6010FF7")]
			[Address(RVA = "0x858C40", Offset = "0x857840", VA = "0x180858C40")]
			private PlayerBattleRank <>xLuaBaseProxy_GetBattleCompleteRank()
			{
				return (PlayerBattleRank)0;
			}

			// Token: 0x06010FF8 RID: 69624 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FF8")]
			[Address(RVA = "0x883940", Offset = "0x882540", VA = "0x180883940")]
			private void <>xLuaBaseProxy_PostprocessMap(Map P0)
			{
			}

			// Token: 0x06010FF9 RID: 69625 RVA: 0x00068BF8 File Offset: 0x00066DF8
			[Token(Token = "0x6010FF9")]
			[Address(RVA = "0x85AB50", Offset = "0x859750", VA = "0x18085AB50")]
			private bool <>xLuaBaseProxy_CheckRenderInvisible(Entity P0, BattleRenderInvisibleMask P1)
			{
				return default(bool);
			}

			// Token: 0x06010FFA RID: 69626 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010FFA")]
			[Address(RVA = "0x85ABD0", Offset = "0x8597D0", VA = "0x18085ABD0")]
			private void <>xLuaBaseProxy_OnPostInit()
			{
			}

			// Token: 0x040130A8 RID: 77992
			[Token(Token = "0x40130A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private SandboxInput m_input;

			// Token: 0x040130A9 RID: 77993
			[Token(Token = "0x40130A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private SandboxOutput m_output;

			// Token: 0x040130AA RID: 77994
			[Token(Token = "0x40130AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private SandboxBattleManager m_battleManager;

			// Token: 0x040130AB RID: 77995
			[Token(Token = "0x40130AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private string m_topicId;

			// Token: 0x040130AC RID: 77996
			[Token(Token = "0x40130AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private SandboxV2Data m_configData;

			// Token: 0x040130AD RID: 77997
			[Token(Token = "0x40130AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private LevelData m_levelData;

			// Token: 0x040130AE RID: 77998
			[Token(Token = "0x40130AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private bool m_gameHasFinished;

			// Token: 0x040130AF RID: 77999
			[Token(Token = "0x40130AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private FP m_maxPlayTime;

			// Token: 0x040130B0 RID: 78000
			[Token(Token = "0x40130B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool m_isInBuildType;

			// Token: 0x040130B1 RID: 78001
			[Token(Token = "0x40130B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
			private bool m_isTimingNode;

			// Token: 0x040130B2 RID: 78002
			[Token(Token = "0x40130B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
			private bool m_isRushEnemyMode;

			// Token: 0x040130B3 RID: 78003
			[Token(Token = "0x40130B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
			private bool m_isRacerCatchMode;

			// Token: 0x040130B4 RID: 78004
			[Token(Token = "0x40130B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Dictionary<string, string> m_materialKeywordData;

			// Token: 0x040130B5 RID: 78005
			[Token(Token = "0x40130B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_renderInvisibleMask;

			// Token: 0x040130B6 RID: 78006
			[Token(Token = "0x40130B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_renderCameraVisibleMask;

			// Token: 0x040130B7 RID: 78007
			[Token(Token = "0x40130B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040130B8 RID: 78008
			[Token(Token = "0x40130B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_isInMonthlyBattle;

			// Token: 0x040130B9 RID: 78009
			[Token(Token = "0x40130B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_isRushEnemyMode;

			// Token: 0x040130BA RID: 78010
			[Token(Token = "0x40130BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_isRacerCatchMode;

			// Token: 0x040130BB RID: 78011
			[Token(Token = "0x40130BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_isTimingMode;

			// Token: 0x040130BC RID: 78012
			[Token(Token = "0x40130BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_isInfiniteTimeLevel;

			// Token: 0x040130BD RID: 78013
			[Token(Token = "0x40130BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_isInMarketType;

			// Token: 0x040130BE RID: 78014
			[Token(Token = "0x40130BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_configData;

			// Token: 0x040130BF RID: 78015
			[Token(Token = "0x40130BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_materialKeywordData;

			// Token: 0x040130C0 RID: 78016
			[Token(Token = "0x40130C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_battleManager;

			// Token: 0x040130C1 RID: 78017
			[Token(Token = "0x40130C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_topicId;

			// Token: 0x040130C2 RID: 78018
			[Token(Token = "0x40130C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_input;

			// Token: 0x040130C3 RID: 78019
			[Token(Token = "0x40130C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_output;

			// Token: 0x040130C4 RID: 78020
			[Token(Token = "0x40130C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_get_levelData;

			// Token: 0x040130C5 RID: 78021
			[Token(Token = "0x40130C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_get_currentNodeType;

			// Token: 0x040130C6 RID: 78022
			[Token(Token = "0x40130C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_get_currentSeasonType;

			// Token: 0x040130C7 RID: 78023
			[Token(Token = "0x40130C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_get_currentWeatherId;

			// Token: 0x040130C8 RID: 78024
			[Token(Token = "0x40130C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_get_isInBuildType;

			// Token: 0x040130C9 RID: 78025
			[Token(Token = "0x40130C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_FetchGameOverOutput;

			// Token: 0x040130CA RID: 78026
			[Token(Token = "0x40130CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x040130CB RID: 78027
			[Token(Token = "0x40130CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_HaveRemainAp;

			// Token: 0x040130CC RID: 78028
			[Token(Token = "0x40130CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_HaveEscapeTrap;

			// Token: 0x040130CD RID: 78029
			[Token(Token = "0x40130CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_GetFarmRemainingTime;

			// Token: 0x040130CE RID: 78030
			[Token(Token = "0x40130CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_GetFarmMaxTime;

			// Token: 0x040130CF RID: 78031
			[Token(Token = "0x40130CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0_GetFarmProgress;

			// Token: 0x040130D0 RID: 78032
			[Token(Token = "0x40130D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0_get_gameModeType;

			// Token: 0x040130D1 RID: 78033
			[Token(Token = "0x40130D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0_get_isLargeMap;

			// Token: 0x040130D2 RID: 78034
			[Token(Token = "0x40130D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0_Tick;

			// Token: 0x040130D3 RID: 78035
			[Token(Token = "0x40130D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private static DelegateBridge __Hotfix0__CheckGameFinish;

			// Token: 0x040130D4 RID: 78036
			[Token(Token = "0x40130D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private static DelegateBridge __Hotfix0_HookTileEffect;

			// Token: 0x040130D5 RID: 78037
			[Token(Token = "0x40130D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			private static DelegateBridge __Hotfix0_HookTileAppendInfoKey;

			// Token: 0x040130D6 RID: 78038
			[Token(Token = "0x40130D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private static DelegateBridge __Hotfix0_CheckTileValid;

			// Token: 0x040130D7 RID: 78039
			[Token(Token = "0x40130D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private static DelegateBridge __Hotfix0_OnGameOver;

			// Token: 0x040130D8 RID: 78040
			[Token(Token = "0x40130D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private static DelegateBridge __Hotfix0_PreprocessPlayerDeckList;

			// Token: 0x040130D9 RID: 78041
			[Token(Token = "0x40130D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private static DelegateBridge __Hotfix0_PreprocessCharacterCard;

			// Token: 0x040130DA RID: 78042
			[Token(Token = "0x40130DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private static DelegateBridge __Hotfix0_PreprocessEnemy;

			// Token: 0x040130DB RID: 78043
			[Token(Token = "0x40130DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private static DelegateBridge __Hotfix0_PreprocessRuneData;

			// Token: 0x040130DC RID: 78044
			[Token(Token = "0x40130DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private static DelegateBridge __Hotfix0_SortDeck;

			// Token: 0x040130DD RID: 78045
			[Token(Token = "0x40130DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private static DelegateBridge __Hotfix0_GetSchedulerPreprocessor;

			// Token: 0x040130DE RID: 78046
			[Token(Token = "0x40130DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			private static DelegateBridge __Hotfix0_GatherGlobalBuffs;

			// Token: 0x040130DF RID: 78047
			[Token(Token = "0x40130DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			private static DelegateBridge __Hotfix0_CheckCardReadyToSpawn;

			// Token: 0x040130E0 RID: 78048
			[Token(Token = "0x40130E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			private static DelegateBridge __Hotfix0_OnCharacterFinished;

			// Token: 0x040130E1 RID: 78049
			[Token(Token = "0x40130E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			private static DelegateBridge __Hotfix0_OnEnemyFinished;

			// Token: 0x040130E2 RID: 78050
			[Token(Token = "0x40130E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private static DelegateBridge __Hotfix0_OnUnitRegistered;

			// Token: 0x040130E3 RID: 78051
			[Token(Token = "0x40130E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			private static DelegateBridge __Hotfix0_OnCardListChanged;

			// Token: 0x040130E4 RID: 78052
			[Token(Token = "0x40130E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private static DelegateBridge __Hotfix0_StartGame;

			// Token: 0x040130E5 RID: 78053
			[Token(Token = "0x40130E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
			private static DelegateBridge __Hotfix0_FinalSchedule;

			// Token: 0x040130E6 RID: 78054
			[Token(Token = "0x40130E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private static DelegateBridge __Hotfix0_PreprocessLevelWithScheduler;

			// Token: 0x040130E7 RID: 78055
			[Token(Token = "0x40130E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
			private static DelegateBridge __Hotfix0_GameNotFinishCondition;

			// Token: 0x040130E8 RID: 78056
			[Token(Token = "0x40130E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private static DelegateBridge __Hotfix0_GetActMeta;

			// Token: 0x040130E9 RID: 78057
			[Token(Token = "0x40130E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
			private static DelegateBridge __Hotfix0_FinishGame;

			// Token: 0x040130EA RID: 78058
			[Token(Token = "0x40130EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private static DelegateBridge __Hotfix0_GetBattleCompleteRank;

			// Token: 0x040130EB RID: 78059
			[Token(Token = "0x40130EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
			private static DelegateBridge __Hotfix0_PostprocessMap;

			// Token: 0x040130EC RID: 78060
			[Token(Token = "0x40130EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private static DelegateBridge __Hotfix0_CheckRenderInvisible;

			// Token: 0x040130ED RID: 78061
			[Token(Token = "0x40130ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
			private static DelegateBridge __Hotfix0_OnPostInit;
		}

		// Token: 0x020027FE RID: 10238
		[Token(Token = "0x20027FE")]
		public class StrifeGameMode : GameModeFactory.DefaultGameMode
		{
			// Token: 0x17002578 RID: 9592
			// (get) Token: 0x06011003 RID: 69635 RVA: 0x00068C28 File Offset: 0x00066E28
			[Token(Token = "0x17002578")]
			public override GameModeMeta.GameModeType gameModeType
			{
				[Token(Token = "0x6011003")]
				[Address(RVA = "0x8FF1A0", Offset = "0x8FDDA0", VA = "0x1808FF1A0", Slot = "119")]
				get
				{
					return GameModeMeta.GameModeType.DEFAULT;
				}
			}

			// Token: 0x06011004 RID: 69636 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011004")]
			[Address(RVA = "0x8FF030", Offset = "0x8FDC30", VA = "0x1808FF030")]
			public StrifeGameMode(ref GameModeMeta meta)
			{
			}

			// Token: 0x06011005 RID: 69637 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6011005")]
			[Address(RVA = "0x8FECB0", Offset = "0x8FD8B0", VA = "0x1808FECB0", Slot = "155")]
			public override Scheduler.SchedulerPreprocessor GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x06011006 RID: 69638 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011006")]
			[Address(RVA = "0x8FED40", Offset = "0x8FD940", VA = "0x1808FED40")]
			public void InitWaveInfo(int totalWave, bool isKillAll)
			{
			}

			// Token: 0x06011007 RID: 69639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011007")]
			[Address(RVA = "0x8FE920", Offset = "0x8FD520", VA = "0x1808FE920")]
			public void FinishCurrentWave(int finishedWave)
			{
			}

			// Token: 0x06011008 RID: 69640 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011008")]
			[Address(RVA = "0x8FEDD0", Offset = "0x8FD9D0", VA = "0x1808FEDD0", Slot = "125")]
			public override void OnGameOver(ref BattleController.GameResult result)
			{
			}

			// Token: 0x06011009 RID: 69641 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011009")]
			[Address(RVA = "0x8FEF80", Offset = "0x8FDB80", VA = "0x1808FEF80", Slot = "148")]
			public override void OnWaveWillStart(LevelData.WaveData waveData)
			{
			}

			// Token: 0x0601100A RID: 69642 RVA: 0x00068C40 File Offset: 0x00066E40
			[Token(Token = "0x601100A")]
			[Address(RVA = "0x83EAA0", Offset = "0x83D6A0", VA = "0x18083EAA0")]
			private GameModeMeta.GameModeType <>xLuaBaseProxy_get_gameModeType()
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}

			// Token: 0x0601100B RID: 69643 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601100B")]
			[Address(RVA = "0x83EA70", Offset = "0x83D670", VA = "0x18083EA70")]
			private Scheduler.SchedulerPreprocessor <>xLuaBaseProxy_GetSchedulerPreprocessor()
			{
				return null;
			}

			// Token: 0x0601100C RID: 69644 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601100C")]
			[Address(RVA = "0x884DA0", Offset = "0x8839A0", VA = "0x180884DA0")]
			private void <>xLuaBaseProxy_OnGameOver(ref BattleController.GameResult P0)
			{
			}

			// Token: 0x0601100D RID: 69645 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601100D")]
			[Address(RVA = "0x85E9F0", Offset = "0x85D5F0", VA = "0x18085E9F0")]
			private void <>xLuaBaseProxy_OnWaveWillStart(LevelData.WaveData P0)
			{
			}

			// Token: 0x040130F4 RID: 78068
			[Token(Token = "0x40130F4")]
			public const string STRIFE_UI_PLUGIN_PATH = "UI/Strife/Battle/strife_battle_ui_plugin.prefab";

			// Token: 0x040130F5 RID: 78069
			[Token(Token = "0x40130F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private StrifeInput m_input;

			// Token: 0x040130F6 RID: 78070
			[Token(Token = "0x40130F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int m_finishedWave;

			// Token: 0x040130F7 RID: 78071
			[Token(Token = "0x40130F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int m_totalWave;

			// Token: 0x040130F8 RID: 78072
			[Token(Token = "0x40130F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int m_remainingCntLastWave;

			// Token: 0x040130F9 RID: 78073
			[Token(Token = "0x40130F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private bool m_killAllModeInOneWave;

			// Token: 0x040130FA RID: 78074
			[Token(Token = "0x40130FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_gameModeType;

			// Token: 0x040130FB RID: 78075
			[Token(Token = "0x40130FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040130FC RID: 78076
			[Token(Token = "0x40130FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetSchedulerPreprocessor;

			// Token: 0x040130FD RID: 78077
			[Token(Token = "0x40130FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_InitWaveInfo;

			// Token: 0x040130FE RID: 78078
			[Token(Token = "0x40130FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_FinishCurrentWave;

			// Token: 0x040130FF RID: 78079
			[Token(Token = "0x40130FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnGameOver;

			// Token: 0x04013100 RID: 78080
			[Token(Token = "0x4013100")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnWaveWillStart;
		}
	}
}
