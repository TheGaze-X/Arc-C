using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E68 RID: 3688
	[Token(Token = "0x2000E68")]
	public class ActVecBreakV2StageRewardData
	{
		// Token: 0x06006B37 RID: 27447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B37")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActVecBreakV2StageRewardData()
		{
		}

		// Token: 0x04004D2F RID: 19759
		[Token(Token = "0x4004D2F")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04004D30 RID: 19760
		[Token(Token = "0x4004D30")]
		[FieldOffset(Offset = "0x18")]
		public int completeRewardCnt;

		// Token: 0x04004D31 RID: 19761
		[Token(Token = "0x4004D31")]
		[FieldOffset(Offset = "0x1C")]
		public int normalRewardCnt;

		// Token: 0x04004D32 RID: 19762
		[Token(Token = "0x4004D32")]
		[FieldOffset(Offset = "0x20")]
		public ActVecBreakV2StageRewardData.LimitedRewardData limitReward;

		// Token: 0x02000E69 RID: 3689
		[Token(Token = "0x2000E69")]
		public class LimitedRewardData
		{
			// Token: 0x06006B38 RID: 27448 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B38")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LimitedRewardData()
			{
			}

			// Token: 0x04004D33 RID: 19763
			[Token(Token = "0x4004D33")]
			[FieldOffset(Offset = "0x10")]
			public long startTs;

			// Token: 0x04004D34 RID: 19764
			[Token(Token = "0x4004D34")]
			[FieldOffset(Offset = "0x18")]
			public long endTs;

			// Token: 0x04004D35 RID: 19765
			[Token(Token = "0x4004D35")]
			[FieldOffset(Offset = "0x20")]
			public int rewardCnt;
		}
	}
}
