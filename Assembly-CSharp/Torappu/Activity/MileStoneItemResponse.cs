using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006D8E RID: 28046
	[Token(Token = "0x2006D8E")]
	public class MileStoneItemResponse : PlayerDeltaResponse
	{
		// Token: 0x06027F38 RID: 163640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F38")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public MileStoneItemResponse()
		{
		}

		// Token: 0x040389E8 RID: 231912
		[Token(Token = "0x40389E8")]
		[FieldOffset(Offset = "0x28")]
		public List<ActivityItemModel> reward;
	}
}
