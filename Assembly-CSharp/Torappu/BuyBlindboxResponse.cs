using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000842 RID: 2114
	[Token(Token = "0x2000842")]
	public class BuyBlindboxResponse : PlayerDeltaResponse
	{
		// Token: 0x060064DA RID: 25818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064DA")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuyBlindboxResponse()
		{
		}

		// Token: 0x04003147 RID: 12615
		[Token(Token = "0x4003147")]
		[FieldOffset(Offset = "0x28")]
		public string skinId;

		// Token: 0x04003148 RID: 12616
		[Token(Token = "0x4003148")]
		[FieldOffset(Offset = "0x30")]
		public List<RewardItemModel> items;
	}
}
