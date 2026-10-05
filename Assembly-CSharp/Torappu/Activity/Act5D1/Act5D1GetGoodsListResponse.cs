using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x0200721E RID: 29214
	[Token(Token = "0x200721E")]
	public class Act5D1GetGoodsListResponse
	{
		// Token: 0x06029699 RID: 169625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029699")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act5D1GetGoodsListResponse()
		{
		}

		// Token: 0x0403B244 RID: 242244
		[Token(Token = "0x403B244")]
		[FieldOffset(Offset = "0x10")]
		public Act5D1ShopGood[] goodList;

		// Token: 0x0403B245 RID: 242245
		[Token(Token = "0x403B245")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Act5D1ProgressGoodItem[]> progressGoodList;
	}
}
