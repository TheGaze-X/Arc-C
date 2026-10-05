using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006D2B RID: 27947
	[Token(Token = "0x2006D2B")]
	public class ActivityRewardMilestoneResponse : PlayerDeltaResponse
	{
		// Token: 0x06027D96 RID: 163222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D96")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ActivityRewardMilestoneResponse()
		{
		}

		// Token: 0x040387BE RID: 231358
		[Token(Token = "0x40387BE")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
