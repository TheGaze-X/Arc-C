using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A52 RID: 2642
	[Token(Token = "0x2000A52")]
	public class PlayerBuildingShop
	{
		// Token: 0x06006711 RID: 26385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006711")]
		[Address(RVA = "0x1EF1F10", Offset = "0x1EF0B10", VA = "0x181EF1F10")]
		public PlayerBuildingShop()
		{
		}

		// Token: 0x04003855 RID: 14421
		[Token(Token = "0x4003855")]
		[FieldOffset(Offset = "0x10")]
		public PlayerBuildingShopStock[] stock;

		// Token: 0x04003856 RID: 14422
		[Token(Token = "0x4003856")]
		[FieldOffset(Offset = "0x18")]
		public List<PlayerBuildingShopOutputItem> outputItem;
	}
}
