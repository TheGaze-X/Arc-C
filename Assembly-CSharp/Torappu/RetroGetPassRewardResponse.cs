using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007DF RID: 2015
	[Token(Token = "0x20007DF")]
	public class RetroGetPassRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x0600646A RID: 25706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600646A")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public RetroGetPassRewardResponse()
		{
		}

		// Token: 0x04003102 RID: 12546
		[Token(Token = "0x4003102")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemGet> items;
	}
}
