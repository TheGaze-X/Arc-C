using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A1E RID: 2590
	[Token(Token = "0x2000A1E")]
	public class PlayerCommonShopProgressData
	{
		// Token: 0x060066DD RID: 26333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066DD")]
		[Address(RVA = "0x1EF4210", Offset = "0x1EF2E10", VA = "0x181EF4210")]
		public PlayerCommonShopProgressData()
		{
		}

		// Token: 0x040037BE RID: 14270
		[Token(Token = "0x40037BE")]
		[FieldOffset(Offset = "0x10")]
		public string curShopId;

		// Token: 0x040037BF RID: 14271
		[Token(Token = "0x40037BF")]
		[FieldOffset(Offset = "0x18")]
		public List<PlayerGoodItemData> info;
	}
}
