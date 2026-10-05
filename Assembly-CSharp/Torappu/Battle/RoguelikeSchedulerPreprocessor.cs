using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Roguelike;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002405 RID: 9221
	[Token(Token = "0x2002405")]
	public class RoguelikeSchedulerPreprocessor : Scheduler.SchedulerPreprocessor
	{
		// Token: 0x17001E1E RID: 7710
		// (get) Token: 0x0600EBC2 RID: 60354 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EBC3 RID: 60355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001E1E")]
		protected Dictionary<RoguelikeSchedulerPreprocessor.RandomGroupKey, List<RoguelikeSchedulerPreprocessor.RandomActionPtr>> randomActionGroups
		{
			[Token(Token = "0x600EBC2")]
			[Address(RVA = "0x618AC0", Offset = "0x6176C0", VA = "0x180618AC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600EBC3")]
			[Address(RVA = "0x618CF0", Offset = "0x6178F0", VA = "0x180618CF0")]
			set
			{
			}
		}

		// Token: 0x17001E1F RID: 7711
		// (get) Token: 0x0600EBC4 RID: 60356 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EBC5 RID: 60357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001E1F")]
		protected Dictionary<RoguelikeSchedulerPreprocessor.RandomGroupKey, RoguelikeSchedulerPreprocessor.RandomGroupWeightData> mimicEnemyGroups
		{
			[Token(Token = "0x600EBC4")]
			[Address(RVA = "0x618960", Offset = "0x617560", VA = "0x180618960")]
			get
			{
				return null;
			}
			[Token(Token = "0x600EBC5")]
			[Address(RVA = "0x618BF0", Offset = "0x6177F0", VA = "0x180618BF0")]
			set
			{
			}
		}

		// Token: 0x17001E20 RID: 7712
		// (get) Token: 0x0600EBC6 RID: 60358 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EBC7 RID: 60359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001E20")]
		protected Dictionary<RoguelikeSchedulerPreprocessor.RandomGroupKey, RoguelikeSchedulerPreprocessor.RandomGroupWeightData> mimicTrapGroups
		{
			[Token(Token = "0x600EBC6")]
			[Address(RVA = "0x618A10", Offset = "0x617610", VA = "0x180618A10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600EBC7")]
			[Address(RVA = "0x618C70", Offset = "0x617870", VA = "0x180618C70")]
			set
			{
			}
		}

		// Token: 0x17001E21 RID: 7713
		// (get) Token: 0x0600EBC8 RID: 60360 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EBC9 RID: 60361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001E21")]
		protected PriorityQueue<RoguelikeSchedulerPreprocessor.RandomActionPtr> actionsToDelete
		{
			[Token(Token = "0x600EBC8")]
			[Address(RVA = "0x6188B0", Offset = "0x6174B0", VA = "0x1806188B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600EBC9")]
			[Address(RVA = "0x618B70", Offset = "0x617770", VA = "0x180618B70")]
			set
			{
			}
		}

		// Token: 0x0600EBCA RID: 60362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBCA")]
		[Address(RVA = "0x6186E0", Offset = "0x6172E0", VA = "0x1806186E0")]
		public RoguelikeSchedulerPreprocessor(RoguelikeInput input)
		{
		}

		// Token: 0x0600EBCB RID: 60363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBCB")]
		[Address(RVA = "0x617130", Offset = "0x615D30", VA = "0x180617130", Slot = "5")]
		public override void DoPreprocess(LevelData levelData)
		{
		}

		// Token: 0x0600EBCC RID: 60364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EBCC")]
		[Address(RVA = "0x6185A0", Offset = "0x6171A0", VA = "0x1806185A0")]
		protected string GetPredefinedTokenKey(LevelData levelData, LevelData.WaveData.FragmentData.ActionData actionData)
		{
			return null;
		}

		// Token: 0x0600EBCD RID: 60365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBCD")]
		[Address(RVA = "0x617060", Offset = "0x615C60", VA = "0x180617060", Slot = "6")]
		public override void Dispose()
		{
		}

		// Token: 0x0401047E RID: 66686
		[Token(Token = "0x401047E")]
		[FieldOffset(Offset = "0x10")]
		private string m_topidId;

		// Token: 0x0401047F RID: 66687
		[Token(Token = "0x401047F")]
		[FieldOffset(Offset = "0x18")]
		private RoguelikeSchedulerPreprocessor.RoguelikeRetainData m_retainData;

		// Token: 0x04010480 RID: 66688
		[Token(Token = "0x4010480")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<RoguelikeSchedulerPreprocessor.RandomGroupKey, List<RoguelikeSchedulerPreprocessor.RandomActionPtr>> m_randomActionGroups;

		// Token: 0x04010481 RID: 66689
		[Token(Token = "0x4010481")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<RoguelikeSchedulerPreprocessor.RandomGroupKey, RoguelikeSchedulerPreprocessor.RandomGroupWeightData> m_mimicEnemyGroups;

		// Token: 0x04010482 RID: 66690
		[Token(Token = "0x4010482")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<RoguelikeSchedulerPreprocessor.RandomGroupKey, RoguelikeSchedulerPreprocessor.RandomGroupWeightData> m_mimicTrapGroups;

		// Token: 0x04010483 RID: 66691
		[Token(Token = "0x4010483")]
		[FieldOffset(Offset = "0x38")]
		private PriorityQueue<RoguelikeSchedulerPreprocessor.RandomActionPtr> m_actionsToDelete;

		// Token: 0x04010484 RID: 66692
		[Token(Token = "0x4010484")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_randomActionGroups;

		// Token: 0x04010485 RID: 66693
		[Token(Token = "0x4010485")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_randomActionGroups;

		// Token: 0x04010486 RID: 66694
		[Token(Token = "0x4010486")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_mimicEnemyGroups;

		// Token: 0x04010487 RID: 66695
		[Token(Token = "0x4010487")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_mimicEnemyGroups;

		// Token: 0x04010488 RID: 66696
		[Token(Token = "0x4010488")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_mimicTrapGroups;

		// Token: 0x04010489 RID: 66697
		[Token(Token = "0x4010489")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_mimicTrapGroups;

		// Token: 0x0401048A RID: 66698
		[Token(Token = "0x401048A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_actionsToDelete;

		// Token: 0x0401048B RID: 66699
		[Token(Token = "0x401048B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_actionsToDelete;

		// Token: 0x0401048C RID: 66700
		[Token(Token = "0x401048C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401048D RID: 66701
		[Token(Token = "0x401048D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_DoPreprocess;

		// Token: 0x0401048E RID: 66702
		[Token(Token = "0x401048E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetPredefinedTokenKey;

		// Token: 0x0401048F RID: 66703
		[Token(Token = "0x401048F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x02002406 RID: 9222
		[Token(Token = "0x2002406")]
		public struct RoguelikeRetainData
		{
			// Token: 0x17001E22 RID: 7714
			// (get) Token: 0x0600EBCE RID: 60366 RVA: 0x00056340 File Offset: 0x00054540
			[Token(Token = "0x17001E22")]
			public bool hasMimicEnemy
			{
				[Token(Token = "0x600EBCE")]
				[Address(RVA = "0x6144B0", Offset = "0x6130B0", VA = "0x1806144B0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001E23 RID: 7715
			// (get) Token: 0x0600EBCF RID: 60367 RVA: 0x00056358 File Offset: 0x00054558
			[Token(Token = "0x17001E23")]
			public bool hasGoldTrap
			{
				[Token(Token = "0x600EBCF")]
				[Address(RVA = "0x6144A0", Offset = "0x6130A0", VA = "0x1806144A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x04010490 RID: 66704
			[Token(Token = "0x4010490")]
			[FieldOffset(Offset = "0x0")]
			public static readonly RoguelikeSchedulerPreprocessor.RoguelikeRetainData DEFAULT;

			// Token: 0x04010491 RID: 66705
			[Token(Token = "0x4010491")]
			[FieldOffset(Offset = "0x0")]
			public int mimicEnemyCnt;

			// Token: 0x04010492 RID: 66706
			[Token(Token = "0x4010492")]
			[FieldOffset(Offset = "0x4")]
			public int goldTrapCnt;
		}

		// Token: 0x02002407 RID: 9223
		[Token(Token = "0x2002407")]
		public struct RandomGroupKey
		{
			// Token: 0x04010493 RID: 66707
			[Token(Token = "0x4010493")]
			[FieldOffset(Offset = "0x0")]
			public int waveIndex;

			// Token: 0x04010494 RID: 66708
			[Token(Token = "0x4010494")]
			[FieldOffset(Offset = "0x4")]
			public int fragIndex;

			// Token: 0x04010495 RID: 66709
			[Token(Token = "0x4010495")]
			[FieldOffset(Offset = "0x8")]
			public string randomKey;
		}

		// Token: 0x02002408 RID: 9224
		[Token(Token = "0x2002408")]
		protected class RandomActionPtr : IItemWithWeight, IComparable<RoguelikeSchedulerPreprocessor.RandomActionPtr>
		{
			// Token: 0x17001E24 RID: 7716
			// (get) Token: 0x0600EBD1 RID: 60369 RVA: 0x00056370 File Offset: 0x00054570
			[Token(Token = "0x17001E24")]
			public float weightValue
			{
				[Token(Token = "0x600EBD1")]
				[Address(RVA = "0x621E30", Offset = "0x620A30", VA = "0x180621E30", Slot = "4")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600EBD2 RID: 60370 RVA: 0x00056388 File Offset: 0x00054588
			[Token(Token = "0x600EBD2")]
			[Address(RVA = "0x621DE0", Offset = "0x6209E0", VA = "0x180621DE0", Slot = "5")]
			public int CompareTo(RoguelikeSchedulerPreprocessor.RandomActionPtr action)
			{
				return 0;
			}

			// Token: 0x0600EBD3 RID: 60371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EBD3")]
			[Address(RVA = "0x621E20", Offset = "0x620A20", VA = "0x180621E20")]
			public RandomActionPtr()
			{
			}

			// Token: 0x04010496 RID: 66710
			[Token(Token = "0x4010496")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeSchedulerPreprocessor.RandomGroupKey key;

			// Token: 0x04010497 RID: 66711
			[Token(Token = "0x4010497")]
			[FieldOffset(Offset = "0x20")]
			public string packKey;

			// Token: 0x04010498 RID: 66712
			[Token(Token = "0x4010498")]
			[FieldOffset(Offset = "0x28")]
			public int actionIndex;

			// Token: 0x04010499 RID: 66713
			[Token(Token = "0x4010499")]
			[FieldOffset(Offset = "0x2C")]
			public int weight;

			// Token: 0x0401049A RID: 66714
			[Token(Token = "0x401049A")]
			[FieldOffset(Offset = "0x30")]
			public bool isEmpty;

			// Token: 0x0401049B RID: 66715
			[Token(Token = "0x401049B")]
			[FieldOffset(Offset = "0x34")]
			public int order;

			// Token: 0x0401049C RID: 66716
			[Token(Token = "0x401049C")]
			[FieldOffset(Offset = "0x38")]
			public bool retainFlag;
		}

		// Token: 0x02002409 RID: 9225
		[Token(Token = "0x2002409")]
		protected class RandomGroupWeightData : IItemWithWeight
		{
			// Token: 0x17001E25 RID: 7717
			// (get) Token: 0x0600EBD4 RID: 60372 RVA: 0x000563A0 File Offset: 0x000545A0
			[Token(Token = "0x17001E25")]
			public float weightValue
			{
				[Token(Token = "0x600EBD4")]
				[Address(RVA = "0x621E40", Offset = "0x620A40", VA = "0x180621E40", Slot = "4")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600EBD5 RID: 60373 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EBD5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RandomGroupWeightData()
			{
			}

			// Token: 0x0401049D RID: 66717
			[Token(Token = "0x401049D")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeSchedulerPreprocessor.RandomGroupKey randomGroupKey;

			// Token: 0x0401049E RID: 66718
			[Token(Token = "0x401049E")]
			[FieldOffset(Offset = "0x20")]
			public float totalWeight;
		}
	}
}
