using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AC3 RID: 31427
	[Token(Token = "0x2007AC3")]
	public class Act12D6MileStoneRewardTryBestResponse : PlayerDeltaResponse
	{
		// Token: 0x0602C04C RID: 180300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C04C")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act12D6MileStoneRewardTryBestResponse()
		{
		}

		// Token: 0x0403FC94 RID: 261268
		[Token(Token = "0x403FC94")]
		[FieldOffset(Offset = "0x28")]
		public List<ActivityItemModel> items;
	}
}
