using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008A1 RID: 2209
	[Token(Token = "0x20008A1")]
	public class GetGoodPurchaseStateResponse : PlayerDeltaResponse, IShopGetResposne
	{
		// Token: 0x06006540 RID: 25920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006540")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GetGoodPurchaseStateResponse()
		{
		}

		// Token: 0x04003269 RID: 12905
		[Token(Token = "0x4003269")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, int> result;
	}
}
