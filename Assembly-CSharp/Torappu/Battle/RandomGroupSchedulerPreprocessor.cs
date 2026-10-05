using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002438 RID: 9272
	[Token(Token = "0x2002438")]
	public class RandomGroupSchedulerPreprocessor : Scheduler.DefaultSchedulerPreprocessor
	{
		// Token: 0x0600ED1C RID: 60700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED1C")]
		[Address(RVA = "0x64B680", Offset = "0x64A280", VA = "0x18064B680", Slot = "5")]
		public override void DoPreprocess(LevelData levelData)
		{
		}

		// Token: 0x0600ED1D RID: 60701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED1D")]
		[Address(RVA = "0x64B580", Offset = "0x64A180", VA = "0x18064B580", Slot = "6")]
		public override void Dispose()
		{
		}

		// Token: 0x0600ED1E RID: 60702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED1E")]
		[Address(RVA = "0x64C500", Offset = "0x64B100", VA = "0x18064C500")]
		public RandomGroupSchedulerPreprocessor()
		{
		}

		// Token: 0x0600ED1F RID: 60703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED1F")]
		[Address(RVA = "0x64C4F0", Offset = "0x64B0F0", VA = "0x18064C4F0")]
		private void <>xLuaBaseProxy_DoPreprocess(LevelData P0)
		{
		}

		// Token: 0x0600ED20 RID: 60704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED20")]
		[Address(RVA = "0x64C4E0", Offset = "0x64B0E0", VA = "0x18064C4E0")]
		private void <>xLuaBaseProxy_Dispose()
		{
		}

		// Token: 0x0401063B RID: 67131
		[Token(Token = "0x401063B")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<RandomGroupSchedulerPreprocessor.RandomGroupKey, List<RandomGroupSchedulerPreprocessor.RandomActionPtr>> m_randomActionGroups;

		// Token: 0x0401063C RID: 67132
		[Token(Token = "0x401063C")]
		[FieldOffset(Offset = "0x18")]
		private readonly PriorityQueue<RandomGroupSchedulerPreprocessor.RandomActionPtr> m_actionsToDelete;

		// Token: 0x0401063D RID: 67133
		[Token(Token = "0x401063D")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<RandomGroupSchedulerPreprocessor.RandomGroupKey, RandomGroupSchedulerPreprocessor.RandomGroupWeightData> m_mimicEnemyGroups;

		// Token: 0x0401063E RID: 67134
		[Token(Token = "0x401063E")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<RandomGroupSchedulerPreprocessor.RandomGroupKey, RandomGroupSchedulerPreprocessor.RandomGroupWeightData> m_mimicTrapGroups;

		// Token: 0x0401063F RID: 67135
		[Token(Token = "0x401063F")]
		[FieldOffset(Offset = "0x30")]
		private readonly HashSet<string> m_actionPacksToDelete;

		// Token: 0x04010640 RID: 67136
		[Token(Token = "0x4010640")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocess;

		// Token: 0x04010641 RID: 67137
		[Token(Token = "0x4010641")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x04010642 RID: 67138
		[Token(Token = "0x4010642")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002439 RID: 9273
		[Token(Token = "0x2002439")]
		public struct RandomGroupKey
		{
			// Token: 0x04010643 RID: 67139
			[Token(Token = "0x4010643")]
			[FieldOffset(Offset = "0x0")]
			public int waveIndex;

			// Token: 0x04010644 RID: 67140
			[Token(Token = "0x4010644")]
			[FieldOffset(Offset = "0x4")]
			public int fragIndex;

			// Token: 0x04010645 RID: 67141
			[Token(Token = "0x4010645")]
			[FieldOffset(Offset = "0x8")]
			public string randomKey;
		}

		// Token: 0x0200243A RID: 9274
		[Token(Token = "0x200243A")]
		private class RandomActionPtr : IItemWithWeight, IComparable<RandomGroupSchedulerPreprocessor.RandomActionPtr>
		{
			// Token: 0x17001E78 RID: 7800
			// (get) Token: 0x0600ED21 RID: 60705 RVA: 0x00056A18 File Offset: 0x00054C18
			[Token(Token = "0x17001E78")]
			public float weightValue
			{
				[Token(Token = "0x600ED21")]
				[Address(RVA = "0x621E30", Offset = "0x620A30", VA = "0x180621E30", Slot = "4")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600ED22 RID: 60706 RVA: 0x00056A30 File Offset: 0x00054C30
			[Token(Token = "0x600ED22")]
			[Address(RVA = "0x621DE0", Offset = "0x6209E0", VA = "0x180621DE0", Slot = "5")]
			public int CompareTo(RandomGroupSchedulerPreprocessor.RandomActionPtr action)
			{
				return 0;
			}

			// Token: 0x0600ED23 RID: 60707 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ED23")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RandomActionPtr()
			{
			}

			// Token: 0x04010646 RID: 67142
			[Token(Token = "0x4010646")]
			[FieldOffset(Offset = "0x10")]
			public RandomGroupSchedulerPreprocessor.RandomGroupKey key;

			// Token: 0x04010647 RID: 67143
			[Token(Token = "0x4010647")]
			[FieldOffset(Offset = "0x20")]
			public string packKey;

			// Token: 0x04010648 RID: 67144
			[Token(Token = "0x4010648")]
			[FieldOffset(Offset = "0x28")]
			public int actionIndex;

			// Token: 0x04010649 RID: 67145
			[Token(Token = "0x4010649")]
			[FieldOffset(Offset = "0x2C")]
			public int weight;

			// Token: 0x0401064A RID: 67146
			[Token(Token = "0x401064A")]
			[FieldOffset(Offset = "0x30")]
			public bool isEmpty;

			// Token: 0x0401064B RID: 67147
			[Token(Token = "0x401064B")]
			[FieldOffset(Offset = "0x34")]
			public int order;
		}

		// Token: 0x0200243B RID: 9275
		[Token(Token = "0x200243B")]
		private class RandomGroupWeightData : IItemWithWeight
		{
			// Token: 0x17001E79 RID: 7801
			// (get) Token: 0x0600ED24 RID: 60708 RVA: 0x00056A48 File Offset: 0x00054C48
			[Token(Token = "0x17001E79")]
			public float weightValue
			{
				[Token(Token = "0x600ED24")]
				[Address(RVA = "0x621E40", Offset = "0x620A40", VA = "0x180621E40", Slot = "4")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600ED25 RID: 60709 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ED25")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RandomGroupWeightData()
			{
			}

			// Token: 0x0401064C RID: 67148
			[Token(Token = "0x401064C")]
			[FieldOffset(Offset = "0x10")]
			public RandomGroupSchedulerPreprocessor.RandomGroupKey randomGroupKey;

			// Token: 0x0401064D RID: 67149
			[Token(Token = "0x401064D")]
			[FieldOffset(Offset = "0x20")]
			public float totalWeight;
		}
	}
}
