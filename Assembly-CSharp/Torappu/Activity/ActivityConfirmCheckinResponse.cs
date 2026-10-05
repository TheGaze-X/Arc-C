using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006DA4 RID: 28068
	[Token(Token = "0x2006DA4")]
	public class ActivityConfirmCheckinResponse : PlayerDeltaResponse
	{
		// Token: 0x06027F9B RID: 163739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F9B")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ActivityConfirmCheckinResponse()
		{
		}

		// Token: 0x04038A7B RID: 232059
		[Token(Token = "0x4038A7B")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
