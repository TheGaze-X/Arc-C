using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act42side
{
	// Token: 0x020072F6 RID: 29430
	[Token(Token = "0x20072F6")]
	public class Act42sideDailyRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x06029A56 RID: 170582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A56")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act42sideDailyRewardResponse()
		{
		}

		// Token: 0x0403B921 RID: 244001
		[Token(Token = "0x403B921")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> rewards;
	}
}
