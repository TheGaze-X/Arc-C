using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000872 RID: 2162
	[Token(Token = "0x2000872")]
	public class GetCashGoodListResponse : PlayerDeltaResponse, IShopGetResposne
	{
		// Token: 0x0600650B RID: 25867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600650B")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GetCashGoodListResponse()
		{
		}

		// Token: 0x040031E1 RID: 12769
		[Token(Token = "0x40031E1")]
		[FieldOffset(Offset = "0x28")]
		public List<CashShopObject> goodList;
	}
}
