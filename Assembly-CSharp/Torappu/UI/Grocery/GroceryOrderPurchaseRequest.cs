using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D32 RID: 19762
	[Token(Token = "0x2004D32")]
	public class GroceryOrderPurchaseRequest
	{
		// Token: 0x0601D966 RID: 121190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D966")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GroceryOrderPurchaseRequest()
		{
		}

		// Token: 0x04027129 RID: 160041
		[Token(Token = "0x4027129")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0402712A RID: 160042
		[Token(Token = "0x402712A")]
		[FieldOffset(Offset = "0x18")]
		public List<int> strategyIds;
	}
}
