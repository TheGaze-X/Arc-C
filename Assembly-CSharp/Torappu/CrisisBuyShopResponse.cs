using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006DF RID: 1759
	[Token(Token = "0x20006DF")]
	public class CrisisBuyShopResponse : PlayerDeltaResponse
	{
		// Token: 0x0600632E RID: 25390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600632E")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public CrisisBuyShopResponse()
		{
		}

		// Token: 0x04002EF1 RID: 12017
		[Token(Token = "0x4002EF1")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
