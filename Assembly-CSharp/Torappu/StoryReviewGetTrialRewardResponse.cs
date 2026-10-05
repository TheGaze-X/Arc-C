using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008C5 RID: 2245
	[Token(Token = "0x20008C5")]
	public class StoryReviewGetTrialRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x06006577 RID: 25975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006577")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public StoryReviewGetTrialRewardResponse()
		{
		}

		// Token: 0x040032B8 RID: 12984
		[Token(Token = "0x40032B8")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
