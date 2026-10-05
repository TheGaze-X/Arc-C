using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act42side
{
	// Token: 0x020072FC RID: 29436
	[Token(Token = "0x20072FC")]
	public class Act42sideSubmitTaskResponse : PlayerDeltaResponse
	{
		// Token: 0x06029A5C RID: 170588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A5C")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act42sideSubmitTaskResponse()
		{
		}

		// Token: 0x0403B927 RID: 244007
		[Token(Token = "0x403B927")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> rewards;
	}
}
