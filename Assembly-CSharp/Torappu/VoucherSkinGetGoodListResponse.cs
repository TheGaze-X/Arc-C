using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008DE RID: 2270
	[Token(Token = "0x20008DE")]
	public class VoucherSkinGetGoodListResponse
	{
		// Token: 0x06006593 RID: 26003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006593")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VoucherSkinGetGoodListResponse()
		{
		}

		// Token: 0x040032EF RID: 13039
		[Token(Token = "0x40032EF")]
		[FieldOffset(Offset = "0x10")]
		public List<ShopSkinItemViewModel> goodList;
	}
}
