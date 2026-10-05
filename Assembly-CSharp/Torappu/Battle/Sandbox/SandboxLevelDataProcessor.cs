using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A7F RID: 10879
	[Token(Token = "0x2002A7F")]
	public class SandboxLevelDataProcessor : IHotfixable
	{
		// Token: 0x06012125 RID: 74021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012125")]
		[Address(RVA = "0xA31F60", Offset = "0xA30B60", VA = "0x180A31F60")]
		public SandboxLevelDataProcessor(GameModeFactory.SandboxGameMode gameMode, SandboxBattleManager manager)
		{
		}

		// Token: 0x170027AB RID: 10155
		// (get) Token: 0x06012126 RID: 74022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170027AB")]
		public SandboxInput input
		{
			[Token(Token = "0x6012126")]
			[Address(RVA = "0xA323D0", Offset = "0xA30FD0", VA = "0x180A323D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170027AC RID: 10156
		// (get) Token: 0x06012127 RID: 74023 RVA: 0x0006E9D0 File Offset: 0x0006CBD0
		[Token(Token = "0x170027AC")]
		public SandboxLevelConfig levelConfig
		{
			[Token(Token = "0x6012127")]
			[Address(RVA = "0xA32440", Offset = "0xA31040", VA = "0x180A32440")]
			get
			{
				return default(SandboxLevelConfig);
			}
		}

		// Token: 0x170027AD RID: 10157
		// (get) Token: 0x06012128 RID: 74024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170027AD")]
		public SandboxV2Data configData
		{
			[Token(Token = "0x6012128")]
			[Address(RVA = "0xA32360", Offset = "0xA30F60", VA = "0x180A32360")]
			get
			{
				return null;
			}
		}

		// Token: 0x170027AE RID: 10158
		// (get) Token: 0x06012129 RID: 74025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170027AE")]
		public List<LevelData.PredefinedData.PredefinedCharacter> originPredefinedInsts
		{
			[Token(Token = "0x6012129")]
			[Address(RVA = "0xA324D0", Offset = "0xA310D0", VA = "0x180A324D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170027AF RID: 10159
		// (get) Token: 0x0601212A RID: 74026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170027AF")]
		public List<string> charactersWithFoodBuff
		{
			[Token(Token = "0x601212A")]
			[Address(RVA = "0xA32300", Offset = "0xA30F00", VA = "0x180A32300")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601212B RID: 74027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601212B")]
		[Address(RVA = "0xA2D2E0", Offset = "0xA2BEE0", VA = "0x180A2D2E0")]
		public Scheduler.SchedulerPreprocessor GetSchedulerPreprocessor()
		{
			return null;
		}

		// Token: 0x0601212C RID: 74028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601212C")]
		[Address(RVA = "0xA2D460", Offset = "0xA2C060", VA = "0x180A2D460")]
		public void Init(LevelData levelData, BattlePlayerData playerData)
		{
		}

		// Token: 0x0601212D RID: 74029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601212D")]
		[Address(RVA = "0xA2D720", Offset = "0xA2C320", VA = "0x180A2D720")]
		public void OnStartGame()
		{
		}

		// Token: 0x0601212E RID: 74030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601212E")]
		[Address(RVA = "0xA2D670", Offset = "0xA2C270", VA = "0x180A2D670")]
		public IEnumerator OnFinalSchedule()
		{
			return null;
		}

		// Token: 0x0601212F RID: 74031 RVA: 0x0006E9E8 File Offset: 0x0006CBE8
		[Token(Token = "0x601212F")]
		[Address(RVA = "0xA2D190", Offset = "0xA2BD90", VA = "0x180A2D190")]
		public float CheckBlockRushEnemyActionTime()
		{
			return 0f;
		}

		// Token: 0x06012130 RID: 74032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012130")]
		[Address(RVA = "0xA2E180", Offset = "0xA2CD80", VA = "0x180A2E180")]
		public void SummonNextInsectPhase()
		{
		}

		// Token: 0x06012131 RID: 74033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012131")]
		[Address(RVA = "0xA2EF90", Offset = "0xA2DB90", VA = "0x180A2EF90")]
		private void _ParseFoodRune()
		{
		}

		// Token: 0x06012132 RID: 74034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012132")]
		[Address(RVA = "0xA2F360", Offset = "0xA2DF60", VA = "0x180A2F360")]
		private void _ParseMiscLevelData(LevelData levelData)
		{
		}

		// Token: 0x06012133 RID: 74035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012133")]
		[Address(RVA = "0xA312E0", Offset = "0xA2FEE0", VA = "0x180A312E0")]
		private void _ParseRushEnemy(LevelData levelData)
		{
		}

		// Token: 0x06012134 RID: 74036 RVA: 0x0006EA00 File Offset: 0x0006CC00
		[Token(Token = "0x6012134")]
		[Address(RVA = "0xA2E550", Offset = "0xA2D150", VA = "0x180A2E550")]
		private float _CalculateRushEnemyPreDelayOffset()
		{
			return 0f;
		}

		// Token: 0x06012135 RID: 74037 RVA: 0x0006EA18 File Offset: 0x0006CC18
		[Token(Token = "0x6012135")]
		[Address(RVA = "0xA31950", Offset = "0xA30550", VA = "0x180A31950")]
		private bool _ParseRushEnemy(LevelData levelData, RushEnemy rushEnemy, float preDelayOffset)
		{
			return default(bool);
		}

		// Token: 0x06012136 RID: 74038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012136")]
		[Address(RVA = "0xA2F210", Offset = "0xA2DE10", VA = "0x180A2F210")]
		private void _ParseLureRacer(LevelData levelData, RushEnemy rushEnemy)
		{
		}

		// Token: 0x06012137 RID: 74039 RVA: 0x0006EA30 File Offset: 0x0006CC30
		[Token(Token = "0x6012137")]
		[Address(RVA = "0xA30A90", Offset = "0xA2F690", VA = "0x180A30A90")]
		private bool _ParseRushEnemyAction(LevelData levelData, RushEnemy rushEnemy, float preDelayOffset, out LevelData.WaveData.FragmentData.ActionData actionData)
		{
			return default(bool);
		}

		// Token: 0x06012138 RID: 74040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012138")]
		[Address(RVA = "0xA2E880", Offset = "0xA2D480", VA = "0x180A2E880")]
		private LevelData.WaveData.FragmentData.ActionData _GetFallbackAction(LevelData levelData)
		{
			return null;
		}

		// Token: 0x06012139 RID: 74041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012139")]
		[Address(RVA = "0xA2EE30", Offset = "0xA2DA30", VA = "0x180A2EE30")]
		private void _ParseExtraLoadEnemy(string enemyId, List<LevelData.EnemyDataDbReference> extraLoadEnemies)
		{
		}

		// Token: 0x0601213A RID: 74042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601213A")]
		[Address(RVA = "0xA30310", Offset = "0xA2EF10", VA = "0x180A30310")]
		private void _ParseRuneDatas(LevelData levelData)
		{
		}

		// Token: 0x0601213B RID: 74043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601213B")]
		[Address(RVA = "0xA2FD60", Offset = "0xA2E960", VA = "0x180A2FD60")]
		private void _ParsePredefinedData(LevelData levelData, BattlePlayerData playerData)
		{
		}

		// Token: 0x0601213C RID: 74044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601213C")]
		[Address(RVA = "0xA2EA30", Offset = "0xA2D630", VA = "0x180A2EA30")]
		private void _ParseConstructItems()
		{
		}

		// Token: 0x0601213D RID: 74045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601213D")]
		[Address(RVA = "0xA2F9E0", Offset = "0xA2E5E0", VA = "0x180A2F9E0")]
		private void _ParsePlacedItems()
		{
		}

		// Token: 0x0601213E RID: 74046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601213E")]
		[Address(RVA = "0xA2D930", Offset = "0xA2C530", VA = "0x180A2D930")]
		public void PostPreprocessLevel(LevelData levelData)
		{
		}

		// Token: 0x0601213F RID: 74047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601213F")]
		[Address(RVA = "0xA2F4F0", Offset = "0xA2E0F0", VA = "0x180A2F4F0")]
		private void _ParseNPCPredefinedData(LevelData levelData)
		{
		}

		// Token: 0x06012140 RID: 74048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012140")]
		[Address(RVA = "0xA31B00", Offset = "0xA30700", VA = "0x180A31B00")]
		private void _ParseShinyAnimals(LevelData levelData)
		{
		}

		// Token: 0x06012141 RID: 74049 RVA: 0x0006EA48 File Offset: 0x0006CC48
		[Token(Token = "0x6012141")]
		[Address(RVA = "0xA2DFB0", Offset = "0xA2CBB0", VA = "0x180A2DFB0")]
		public bool ProcessSpecialEnemy(Enemy enemy)
		{
			return default(bool);
		}

		// Token: 0x040146FA RID: 83706
		[Token(Token = "0x40146FA")]
		[FieldOffset(Offset = "0x10")]
		private GameModeFactory.SandboxGameMode m_gameMode;

		// Token: 0x040146FB RID: 83707
		[Token(Token = "0x40146FB")]
		[FieldOffset(Offset = "0x18")]
		private SandboxBattleManager m_manager;

		// Token: 0x040146FC RID: 83708
		[Token(Token = "0x40146FC")]
		[FieldOffset(Offset = "0x20")]
		private List<LevelData.WaveData.FragmentData.ActionData> m_rushEnemyActions;

		// Token: 0x040146FD RID: 83709
		[Token(Token = "0x40146FD")]
		[FieldOffset(Offset = "0x28")]
		private LevelData.BranchData.PhaseData m_rushEnemyPhase;

		// Token: 0x040146FE RID: 83710
		[Token(Token = "0x40146FE")]
		[FieldOffset(Offset = "0x30")]
		private List<LevelData.WaveData.FragmentData.ActionData> m_rareAnimalActions;

		// Token: 0x040146FF RID: 83711
		[Token(Token = "0x40146FF")]
		[FieldOffset(Offset = "0x38")]
		private LevelData.BranchData.PhaseData m_rareAnimalPhase;

		// Token: 0x04014700 RID: 83712
		[Token(Token = "0x4014700")]
		[FieldOffset(Offset = "0x40")]
		private List<LevelData.WaveData.FragmentData.ActionData> m_lureRacerActions;

		// Token: 0x04014701 RID: 83713
		[Token(Token = "0x4014701")]
		[FieldOffset(Offset = "0x48")]
		private List<BattleCharacterData> m_predefinedTokenCards;

		// Token: 0x04014702 RID: 83714
		[Token(Token = "0x4014702")]
		[FieldOffset(Offset = "0x50")]
		private List<LevelData.PredefinedData.PredefinedCharacter> m_predefinedTokenInsts;

		// Token: 0x04014703 RID: 83715
		[Token(Token = "0x4014703")]
		[FieldOffset(Offset = "0x58")]
		private List<LevelData.PredefinedData.PredefinedCharacter> m_originPredefinedInsts;

		// Token: 0x04014704 RID: 83716
		[Token(Token = "0x4014704")]
		[FieldOffset(Offset = "0x60")]
		private List<LegacyInLevelRuneData> m_extraLevelRunes;

		// Token: 0x04014705 RID: 83717
		[Token(Token = "0x4014705")]
		[FieldOffset(Offset = "0x68")]
		private ListDict<string, Vector2Int> m_shinyAnimalStatus;

		// Token: 0x04014706 RID: 83718
		[Token(Token = "0x4014706")]
		[FieldOffset(Offset = "0x70")]
		private List<string> m_charactersWithFoodBuff;

		// Token: 0x04014707 RID: 83719
		[Token(Token = "0x4014707")]
		[FieldOffset(Offset = "0x78")]
		private int m_insectPhaseIndex;

		// Token: 0x04014708 RID: 83720
		[Token(Token = "0x4014708")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04014709 RID: 83721
		[Token(Token = "0x4014709")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_input;

		// Token: 0x0401470A RID: 83722
		[Token(Token = "0x401470A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_levelConfig;

		// Token: 0x0401470B RID: 83723
		[Token(Token = "0x401470B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_configData;

		// Token: 0x0401470C RID: 83724
		[Token(Token = "0x401470C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_originPredefinedInsts;

		// Token: 0x0401470D RID: 83725
		[Token(Token = "0x401470D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_charactersWithFoodBuff;

		// Token: 0x0401470E RID: 83726
		[Token(Token = "0x401470E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetSchedulerPreprocessor;

		// Token: 0x0401470F RID: 83727
		[Token(Token = "0x401470F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04014710 RID: 83728
		[Token(Token = "0x4014710")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnStartGame;

		// Token: 0x04014711 RID: 83729
		[Token(Token = "0x4014711")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnFinalSchedule;

		// Token: 0x04014712 RID: 83730
		[Token(Token = "0x4014712")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckBlockRushEnemyActionTime;

		// Token: 0x04014713 RID: 83731
		[Token(Token = "0x4014713")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SummonNextInsectPhase;

		// Token: 0x04014714 RID: 83732
		[Token(Token = "0x4014714")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ParseFoodRune;

		// Token: 0x04014715 RID: 83733
		[Token(Token = "0x4014715")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ParseMiscLevelData;

		// Token: 0x04014716 RID: 83734
		[Token(Token = "0x4014716")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ParseRushEnemy;

		// Token: 0x04014717 RID: 83735
		[Token(Token = "0x4014717")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CalculateRushEnemyPreDelayOffset;

		// Token: 0x04014718 RID: 83736
		[Token(Token = "0x4014718")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix1__ParseRushEnemy;

		// Token: 0x04014719 RID: 83737
		[Token(Token = "0x4014719")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ParseLureRacer;

		// Token: 0x0401471A RID: 83738
		[Token(Token = "0x401471A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ParseRushEnemyAction;

		// Token: 0x0401471B RID: 83739
		[Token(Token = "0x401471B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GetFallbackAction;

		// Token: 0x0401471C RID: 83740
		[Token(Token = "0x401471C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ParseExtraLoadEnemy;

		// Token: 0x0401471D RID: 83741
		[Token(Token = "0x401471D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__ParseRuneDatas;

		// Token: 0x0401471E RID: 83742
		[Token(Token = "0x401471E")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ParsePredefinedData;

		// Token: 0x0401471F RID: 83743
		[Token(Token = "0x401471F")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__ParseConstructItems;

		// Token: 0x04014720 RID: 83744
		[Token(Token = "0x4014720")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__ParsePlacedItems;

		// Token: 0x04014721 RID: 83745
		[Token(Token = "0x4014721")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_PostPreprocessLevel;

		// Token: 0x04014722 RID: 83746
		[Token(Token = "0x4014722")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__ParseNPCPredefinedData;

		// Token: 0x04014723 RID: 83747
		[Token(Token = "0x4014723")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__ParseShinyAnimals;

		// Token: 0x04014724 RID: 83748
		[Token(Token = "0x4014724")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_ProcessSpecialEnemy;
	}
}
