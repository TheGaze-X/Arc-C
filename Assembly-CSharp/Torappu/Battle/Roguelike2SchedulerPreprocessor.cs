using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.Roguelike;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002402 RID: 9218
	[Token(Token = "0x2002402")]
	public class Roguelike2SchedulerPreprocessor : RoguelikeSchedulerPreprocessor
	{
		// Token: 0x0600EBB4 RID: 60340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBB4")]
		[Address(RVA = "0x616B50", Offset = "0x615750", VA = "0x180616B50")]
		public Roguelike2SchedulerPreprocessor(RoguelikeInput input, GameModeFactory.RoguelikeGameMode gameMode)
		{
		}

		// Token: 0x0600EBB5 RID: 60341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBB5")]
		[Address(RVA = "0x6145B0", Offset = "0x6131B0", VA = "0x1806145B0", Slot = "5")]
		public override void DoPreprocess(LevelData levelData)
		{
		}

		// Token: 0x0600EBB6 RID: 60342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBB6")]
		[Address(RVA = "0x614500", Offset = "0x613100", VA = "0x180614500", Slot = "6")]
		public override void Dispose()
		{
		}

		// Token: 0x0600EBB7 RID: 60343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBB7")]
		[Address(RVA = "0x616470", Offset = "0x615070", VA = "0x180616470")]
		private void _InitValidation(LevelData levelData)
		{
		}

		// Token: 0x0600EBB8 RID: 60344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBB8")]
		[Address(RVA = "0x616670", Offset = "0x615270", VA = "0x180616670")]
		private void _ProcessActionSingleCountViaInputResults(LevelData levelData)
		{
		}

		// Token: 0x0600EBB9 RID: 60345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBB9")]
		[Address(RVA = "0x616460", Offset = "0x615060", VA = "0x180616460")]
		private void <>xLuaBaseProxy_DoPreprocess(LevelData P0)
		{
		}

		// Token: 0x0600EBBA RID: 60346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBBA")]
		[Address(RVA = "0x616450", Offset = "0x615050", VA = "0x180616450")]
		private void <>xLuaBaseProxy_Dispose()
		{
		}

		// Token: 0x04010467 RID: 66663
		[Token(Token = "0x4010467")]
		[FieldOffset(Offset = "0x40")]
		private GameModeFactory.RoguelikeGameMode m_gameMode;

		// Token: 0x04010468 RID: 66664
		[Token(Token = "0x4010468")]
		[FieldOffset(Offset = "0x48")]
		private Roguelike2SchedulerPreprocessor.Roguelike2RetainData m_retainData;

		// Token: 0x04010469 RID: 66665
		[Token(Token = "0x4010469")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<RoguelikeSchedulerPreprocessor.RandomGroupKey, RoguelikeSchedulerPreprocessor.RandomGroupWeightData> m_rogue2TrapGroups;

		// Token: 0x0401046A RID: 66666
		[Token(Token = "0x401046A")]
		[FieldOffset(Offset = "0x60")]
		private readonly HashSet<string> m_actionPacksToDelete;

		// Token: 0x0401046B RID: 66667
		[Token(Token = "0x401046B")]
		[FieldOffset(Offset = "0x68")]
		private ListDict<LevelData.ActionID, int> m_singleActionKilledCount;

		// Token: 0x0401046C RID: 66668
		[Token(Token = "0x401046C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401046D RID: 66669
		[Token(Token = "0x401046D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreprocess;

		// Token: 0x0401046E RID: 66670
		[Token(Token = "0x401046E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0401046F RID: 66671
		[Token(Token = "0x401046F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitValidation;

		// Token: 0x04010470 RID: 66672
		[Token(Token = "0x4010470")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ProcessActionSingleCountViaInputResults;

		// Token: 0x02002403 RID: 9219
		[Token(Token = "0x2002403")]
		public struct Roguelike2RetainData
		{
			// Token: 0x17001E1A RID: 7706
			// (get) Token: 0x0600EBBB RID: 60347 RVA: 0x000562F8 File Offset: 0x000544F8
			[Token(Token = "0x17001E1A")]
			public bool hasMimicEnemy
			{
				[Token(Token = "0x600EBBB")]
				[Address(RVA = "0x6144B0", Offset = "0x6130B0", VA = "0x1806144B0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001E1B RID: 7707
			// (get) Token: 0x0600EBBC RID: 60348 RVA: 0x00056310 File Offset: 0x00054510
			[Token(Token = "0x17001E1B")]
			public bool hasGoldTrap
			{
				[Token(Token = "0x600EBBC")]
				[Address(RVA = "0x6144A0", Offset = "0x6130A0", VA = "0x1806144A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001E1C RID: 7708
			// (get) Token: 0x0600EBBD RID: 60349 RVA: 0x00056328 File Offset: 0x00054528
			[Token(Token = "0x17001E1C")]
			public bool hasRogue2Box
			{
				[Token(Token = "0x600EBBD")]
				[Address(RVA = "0x6144C0", Offset = "0x6130C0", VA = "0x1806144C0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x04010471 RID: 66673
			[Token(Token = "0x4010471")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Roguelike2SchedulerPreprocessor.Roguelike2RetainData DEFAULT;

			// Token: 0x04010472 RID: 66674
			[Token(Token = "0x4010472")]
			[FieldOffset(Offset = "0x0")]
			public int mimicEnemyCnt;

			// Token: 0x04010473 RID: 66675
			[Token(Token = "0x4010473")]
			[FieldOffset(Offset = "0x4")]
			public int goldTrapCnt;

			// Token: 0x04010474 RID: 66676
			[Token(Token = "0x4010474")]
			[FieldOffset(Offset = "0x8")]
			public Dictionary<string, int> boxinfo;
		}
	}
}
