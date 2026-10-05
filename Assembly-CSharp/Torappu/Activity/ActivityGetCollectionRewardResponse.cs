using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006D34 RID: 27956
	[Token(Token = "0x2006D34")]
	public class ActivityGetCollectionRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x06027D9F RID: 163231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D9F")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ActivityGetCollectionRewardResponse()
		{
		}

		// Token: 0x040387D0 RID: 231376
		[Token(Token = "0x40387D0")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
