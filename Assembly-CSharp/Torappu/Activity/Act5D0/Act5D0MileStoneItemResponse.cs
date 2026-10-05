using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071E6 RID: 29158
	[Token(Token = "0x20071E6")]
	public class Act5D0MileStoneItemResponse : PlayerDeltaResponse
	{
		// Token: 0x060295DA RID: 169434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295DA")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act5D0MileStoneItemResponse()
		{
		}

		// Token: 0x0403B136 RID: 241974
		[Token(Token = "0x403B136")]
		[FieldOffset(Offset = "0x28")]
		public List<ActivityItemModel> reward;
	}
}
