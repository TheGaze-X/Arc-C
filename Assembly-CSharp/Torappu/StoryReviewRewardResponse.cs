using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008C3 RID: 2243
	[Token(Token = "0x20008C3")]
	public class StoryReviewRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x06006575 RID: 25973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006575")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public StoryReviewRewardResponse()
		{
		}

		// Token: 0x040032B5 RID: 12981
		[Token(Token = "0x40032B5")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
