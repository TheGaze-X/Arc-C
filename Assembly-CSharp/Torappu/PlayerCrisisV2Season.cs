using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A98 RID: 2712
	[Token(Token = "0x2000A98")]
	public class PlayerCrisisV2Season
	{
		// Token: 0x0600675C RID: 26460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600675C")]
		[Address(RVA = "0x1EF4400", Offset = "0x1EF3000", VA = "0x181EF4400")]
		public PlayerCrisisV2Season()
		{
		}

		// Token: 0x0400394B RID: 14667
		[Token(Token = "0x400394B")]
		[FieldOffset(Offset = "0x10")]
		public int coin;

		// Token: 0x0400394C RID: 14668
		[Token(Token = "0x400394C")]
		[FieldOffset(Offset = "0x18")]
		public PlayerCrisisV2Season.PermanentMapInfo permanent;

		// Token: 0x0400394D RID: 14669
		[Token(Token = "0x400394D")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, PlayerCrisisV2Season.BasicMapInfo> temporary;

		// Token: 0x0400394E RID: 14670
		[Token(Token = "0x400394E")]
		[FieldOffset(Offset = "0x28")]
		public PlayerCrisisSocialInfo social;

		// Token: 0x02000A99 RID: 2713
		[Token(Token = "0x2000A99")]
		public enum RuneState
		{
			// Token: 0x04003950 RID: 14672
			[Token(Token = "0x4003950")]
			UNKNOWN,
			// Token: 0x04003951 RID: 14673
			[Token(Token = "0x4003951")]
			LOCKED,
			// Token: 0x04003952 RID: 14674
			[Token(Token = "0x4003952")]
			UNLOCK,
			// Token: 0x04003953 RID: 14675
			[Token(Token = "0x4003953")]
			FINISH
		}

		// Token: 0x02000A9A RID: 2714
		[Token(Token = "0x2000A9A")]
		public enum NodeState
		{
			// Token: 0x04003955 RID: 14677
			[Token(Token = "0x4003955")]
			INACTIVE,
			// Token: 0x04003956 RID: 14678
			[Token(Token = "0x4003956")]
			ACTIVED,
			// Token: 0x04003957 RID: 14679
			[Token(Token = "0x4003957")]
			CLAIMED
		}

		// Token: 0x02000A9B RID: 2715
		[Token(Token = "0x2000A9B")]
		public enum BagState
		{
			// Token: 0x04003959 RID: 14681
			[Token(Token = "0x4003959")]
			INCOMPLETE,
			// Token: 0x0400395A RID: 14682
			[Token(Token = "0x400395A")]
			COMPLETED,
			// Token: 0x0400395B RID: 14683
			[Token(Token = "0x400395B")]
			CLAIMED
		}

		// Token: 0x02000A9C RID: 2716
		[Token(Token = "0x2000A9C")]
		public class RewardInfo
		{
			// Token: 0x0600675D RID: 26461 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600675D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RewardInfo()
			{
			}

			// Token: 0x0400395C RID: 14684
			[Token(Token = "0x400395C")]
			[FieldOffset(Offset = "0x10")]
			public PlayerCrisisV2Season.NodeState state;

			// Token: 0x0400395D RID: 14685
			[Token(Token = "0x400395D")]
			[FieldOffset(Offset = "0x14")]
			public int progress;
		}

		// Token: 0x02000A9D RID: 2717
		[Token(Token = "0x2000A9D")]
		public class PermanentMapInfo : PlayerCrisisV2Season.BasicMapInfo
		{
			// Token: 0x0600675E RID: 26462 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600675E")]
			[Address(RVA = "0x1EED3C0", Offset = "0x1EEBFC0", VA = "0x181EED3C0")]
			public PermanentMapInfo()
			{
			}

			// Token: 0x0400395E RID: 14686
			[Token(Token = "0x400395E")]
			[FieldOffset(Offset = "0x30")]
			public List<int> scoreSingle;

			// Token: 0x0400395F RID: 14687
			[Token(Token = "0x400395F")]
			[FieldOffset(Offset = "0x38")]
			public List<string> comment;

			// Token: 0x04003960 RID: 14688
			[Token(Token = "0x4003960")]
			[FieldOffset(Offset = "0x40")]
			public Dictionary<string, PlayerCrisisV2Season.RuneState> exRunes;

			// Token: 0x04003961 RID: 14689
			[Token(Token = "0x4003961")]
			[FieldOffset(Offset = "0x48")]
			public Dictionary<string, PlayerCrisisV2Season.BagState> runePack;

			// Token: 0x04003962 RID: 14690
			[Token(Token = "0x4003962")]
			[FieldOffset(Offset = "0x50")]
			public Dictionary<string, PlayerCrisisV2Season.RewardInfo> reward;
		}

		// Token: 0x02000A9E RID: 2718
		[Token(Token = "0x2000A9E")]
		public class BasicMapInfo
		{
			// Token: 0x0600675F RID: 26463 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600675F")]
			[Address(RVA = "0x1EE6E50", Offset = "0x1EE5A50", VA = "0x181EE6E50")]
			public BasicMapInfo()
			{
			}

			// Token: 0x04003963 RID: 14691
			[Token(Token = "0x4003963")]
			[FieldOffset(Offset = "0x10")]
			public bool state;

			// Token: 0x04003964 RID: 14692
			[Token(Token = "0x4003964")]
			[FieldOffset(Offset = "0x18")]
			public List<int> scoreTotal;

			// Token: 0x04003965 RID: 14693
			[Token(Token = "0x4003965")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, PlayerCrisisV2Season.RuneState> rune;

			// Token: 0x04003966 RID: 14694
			[Token(Token = "0x4003966")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<string, PlayerCrisisV2Season.NodeState> challenge;
		}
	}
}
