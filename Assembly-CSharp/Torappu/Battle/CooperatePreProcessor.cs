using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002434 RID: 9268
	[Token(Token = "0x2002434")]
	public class CooperatePreProcessor : Scheduler.SchedulerPreprocessor
	{
		// Token: 0x17001E74 RID: 7796
		[Token(Token = "0x17001E74")]
		public int this[int difficultyIndex]
		{
			[Token(Token = "0x600ED02")]
			[Address(RVA = "0x61F8B0", Offset = "0x61E4B0", VA = "0x18061F8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001E75 RID: 7797
		// (get) Token: 0x0600ED03 RID: 60675 RVA: 0x000569A0 File Offset: 0x00054BA0
		[Token(Token = "0x17001E75")]
		public int waveCnt
		{
			[Token(Token = "0x600ED03")]
			[Address(RVA = "0x61FB50", Offset = "0x61E750", VA = "0x18061FB50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x0600ED04 RID: 60676 RVA: 0x000569B8 File Offset: 0x00054BB8
		[Token(Token = "0x17001E76")]
		public bool isFail
		{
			[Token(Token = "0x600ED04")]
			[Address(RVA = "0x61FA70", Offset = "0x61E670", VA = "0x18061FA70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600ED05 RID: 60677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED05")]
		[Address(RVA = "0x61DD00", Offset = "0x61C900", VA = "0x18061DD00", Slot = "5")]
		public override void DoPreprocess(LevelData levelData)
		{
		}

		// Token: 0x0600ED06 RID: 60678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED06")]
		[Address(RVA = "0x61F0F0", Offset = "0x61DCF0", VA = "0x18061F0F0")]
		private void _ReplaceTeamPlayerWithEnemyKey(LevelData.WaveData.FragmentData.ActionData action)
		{
		}

		// Token: 0x0600ED07 RID: 60679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED07")]
		[Address(RVA = "0x61F3A0", Offset = "0x61DFA0", VA = "0x18061F3A0")]
		private void _SelectTeamPlayers()
		{
		}

		// Token: 0x0600ED08 RID: 60680 RVA: 0x000569D0 File Offset: 0x00054BD0
		[Token(Token = "0x600ED08")]
		[Address(RVA = "0x61EEF0", Offset = "0x61DAF0", VA = "0x18061EEF0")]
		private bool _CheckNeedReplaceTeamInFootball(LevelData levelData)
		{
			return default(bool);
		}

		// Token: 0x0600ED09 RID: 60681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED09")]
		[Address(RVA = "0x61DC40", Offset = "0x61C840", VA = "0x18061DC40", Slot = "6")]
		public override void Dispose()
		{
		}

		// Token: 0x0600ED0A RID: 60682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED0A")]
		[Address(RVA = "0x61F5A0", Offset = "0x61E1A0", VA = "0x18061F5A0")]
		public CooperatePreProcessor()
		{
		}

		// Token: 0x04010607 RID: 67079
		[Token(Token = "0x4010607")]
		private const string RANDOM_BONUS_KEY = "bonus";

		// Token: 0x04010608 RID: 67080
		[Token(Token = "0x4010608")]
		private const string FAIL_RANDOM_BONUS_KEY = "bonus_f";

		// Token: 0x04010609 RID: 67081
		[Token(Token = "0x4010609")]
		private const string TEAM_PLAYER_FORWARD = "forward";

		// Token: 0x0401060A RID: 67082
		[Token(Token = "0x401060A")]
		private const string TEAM_PLAYER_GOALKEEPER = "goalkeeper";

		// Token: 0x0401060B RID: 67083
		[Token(Token = "0x401060B")]
		private const string TEAM_PLAYER_MUSCLEMAN = "muscleman";

		// Token: 0x0401060C RID: 67084
		[Token(Token = "0x401060C")]
		private const string MULTI_STAGE_TAG = "stage";

		// Token: 0x0401060D RID: 67085
		[Token(Token = "0x401060D")]
		private const string HIGH_LEVEL_END = "_2";

		// Token: 0x0401060E RID: 67086
		[Token(Token = "0x401060E")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<CooperatePreProcessor.RandomGroupKey, List<CooperatePreProcessor.RandomActionPtr>> m_randomActionGroups;

		// Token: 0x0401060F RID: 67087
		[Token(Token = "0x401060F")]
		[FieldOffset(Offset = "0x18")]
		private PriorityQueue<CooperatePreProcessor.RandomActionPtr> m_actionsToDelete;

		// Token: 0x04010610 RID: 67088
		[Token(Token = "0x4010610")]
		[FieldOffset(Offset = "0x20")]
		private readonly HashSet<string> m_actionPacksToDelete;

		// Token: 0x04010611 RID: 67089
		[Token(Token = "0x4010611")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<int, List<int>> m_footballLevelWithWaves;

		// Token: 0x04010612 RID: 67090
		[Token(Token = "0x4010612")]
		[FieldOffset(Offset = "0x30")]
		private int m_waveCnt;

		// Token: 0x04010613 RID: 67091
		[Token(Token = "0x4010613")]
		[FieldOffset(Offset = "0x34")]
		private int m_lastWaveIndex;

		// Token: 0x04010614 RID: 67092
		[Token(Token = "0x4010614")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, string> m_selectTeamPlayer;

		// Token: 0x04010615 RID: 67093
		[Token(Token = "0x4010615")]
		[FieldOffset(Offset = "0x40")]
		public readonly List<int> enemyCntStats;

		// Token: 0x04010616 RID: 67094
		[Token(Token = "0x4010616")]
		[FieldOffset(Offset = "0x48")]
		public readonly List<int> stageWave;

		// Token: 0x04010617 RID: 67095
		[Token(Token = "0x4010617")]
		[FieldOffset(Offset = "0x50")]
		public readonly List<float> stageDistCar;

		// Token: 0x04010618 RID: 67096
		[Token(Token = "0x4010618")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_Item;

		// Token: 0x04010619 RID: 67097
		[Token(Token = "0x4010619")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_waveCnt;

		// Token: 0x0401061A RID: 67098
		[Token(Token = "0x401061A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isFail;

		// Token: 0x0401061B RID: 67099
		[Token(Token = "0x401061B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoPreprocess;

		// Token: 0x0401061C RID: 67100
		[Token(Token = "0x401061C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ReplaceTeamPlayerWithEnemyKey;

		// Token: 0x0401061D RID: 67101
		[Token(Token = "0x401061D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SelectTeamPlayers;

		// Token: 0x0401061E RID: 67102
		[Token(Token = "0x401061E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckNeedReplaceTeamInFootball;

		// Token: 0x0401061F RID: 67103
		[Token(Token = "0x401061F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x04010620 RID: 67104
		[Token(Token = "0x4010620")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002435 RID: 9269
		[Token(Token = "0x2002435")]
		public struct RandomGroupKey
		{
			// Token: 0x04010621 RID: 67105
			[Token(Token = "0x4010621")]
			[FieldOffset(Offset = "0x0")]
			public int waveIndex;

			// Token: 0x04010622 RID: 67106
			[Token(Token = "0x4010622")]
			[FieldOffset(Offset = "0x4")]
			public int fragIndex;

			// Token: 0x04010623 RID: 67107
			[Token(Token = "0x4010623")]
			[FieldOffset(Offset = "0x8")]
			public string randomKey;
		}

		// Token: 0x02002436 RID: 9270
		[Token(Token = "0x2002436")]
		protected class RandomActionPtr : IItemWithWeight, IComparable<CooperatePreProcessor.RandomActionPtr>
		{
			// Token: 0x17001E77 RID: 7799
			// (get) Token: 0x0600ED0B RID: 60683 RVA: 0x000569E8 File Offset: 0x00054BE8
			[Token(Token = "0x17001E77")]
			public float weightValue
			{
				[Token(Token = "0x600ED0B")]
				[Address(RVA = "0x621E30", Offset = "0x620A30", VA = "0x180621E30", Slot = "4")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600ED0C RID: 60684 RVA: 0x00056A00 File Offset: 0x00054C00
			[Token(Token = "0x600ED0C")]
			[Address(RVA = "0x621DE0", Offset = "0x6209E0", VA = "0x180621DE0", Slot = "5")]
			public int CompareTo(CooperatePreProcessor.RandomActionPtr action)
			{
				return 0;
			}

			// Token: 0x0600ED0D RID: 60685 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ED0D")]
			[Address(RVA = "0x621E20", Offset = "0x620A20", VA = "0x180621E20")]
			public RandomActionPtr()
			{
			}

			// Token: 0x04010624 RID: 67108
			[Token(Token = "0x4010624")]
			[FieldOffset(Offset = "0x10")]
			public CooperatePreProcessor.RandomGroupKey key;

			// Token: 0x04010625 RID: 67109
			[Token(Token = "0x4010625")]
			[FieldOffset(Offset = "0x20")]
			public string packKey;

			// Token: 0x04010626 RID: 67110
			[Token(Token = "0x4010626")]
			[FieldOffset(Offset = "0x28")]
			public int actionIndex;

			// Token: 0x04010627 RID: 67111
			[Token(Token = "0x4010627")]
			[FieldOffset(Offset = "0x2C")]
			public int weight;

			// Token: 0x04010628 RID: 67112
			[Token(Token = "0x4010628")]
			[FieldOffset(Offset = "0x30")]
			public bool isEmpty;

			// Token: 0x04010629 RID: 67113
			[Token(Token = "0x4010629")]
			[FieldOffset(Offset = "0x34")]
			public int order;

			// Token: 0x0401062A RID: 67114
			[Token(Token = "0x401062A")]
			[FieldOffset(Offset = "0x38")]
			public bool retainFlag;
		}
	}
}
