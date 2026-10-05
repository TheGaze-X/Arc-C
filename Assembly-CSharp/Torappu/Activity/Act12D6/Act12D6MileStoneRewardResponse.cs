using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AC1 RID: 31425
	[Token(Token = "0x2007AC1")]
	public class Act12D6MileStoneRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x0602C04A RID: 180298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C04A")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act12D6MileStoneRewardResponse()
		{
		}

		// Token: 0x0403FC92 RID: 261266
		[Token(Token = "0x403FC92")]
		[FieldOffset(Offset = "0x28")]
		public List<ActivityItemModel> items;
	}
}
