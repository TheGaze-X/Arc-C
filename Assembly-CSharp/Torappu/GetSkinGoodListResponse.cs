using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200086A RID: 2154
	[Token(Token = "0x200086A")]
	public class GetSkinGoodListResponse : PlayerDeltaResponse, IShopGetResposne
	{
		// Token: 0x06006505 RID: 25861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006505")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GetSkinGoodListResponse()
		{
		}

		// Token: 0x040031B1 RID: 12721
		[Token(Token = "0x40031B1")]
		[FieldOffset(Offset = "0x28")]
		public List<ShopSkinItemViewModel> goodList;

		// Token: 0x040031B2 RID: 12722
		[Token(Token = "0x40031B2")]
		[FieldOffset(Offset = "0x30")]
		public List<ShopBlindboxItemViewModel> gachaGoodList;
	}
}
