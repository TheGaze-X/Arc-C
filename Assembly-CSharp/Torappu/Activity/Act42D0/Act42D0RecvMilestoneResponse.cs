using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007340 RID: 29504
	[Token(Token = "0x2007340")]
	public class Act42D0RecvMilestoneResponse : PlayerDeltaResponse
	{
		// Token: 0x06029BAE RID: 170926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BAE")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act42D0RecvMilestoneResponse()
		{
		}

		// Token: 0x0403BBB2 RID: 244658
		[Token(Token = "0x403BBB2")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
