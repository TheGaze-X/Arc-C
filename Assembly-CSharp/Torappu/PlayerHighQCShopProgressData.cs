using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A20 RID: 2592
	[Token(Token = "0x2000A20")]
	public class PlayerHighQCShopProgressData
	{
		// Token: 0x060066DF RID: 26335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066DF")]
		[Address(RVA = "0x1EFAC70", Offset = "0x1EF9870", VA = "0x181EFAC70")]
		public PlayerHighQCShopProgressData()
		{
		}

		// Token: 0x040037C2 RID: 14274
		[Token(Token = "0x40037C2")]
		[FieldOffset(Offset = "0x10")]
		public List<PlayerGoodItemData> info;

		// Token: 0x040037C3 RID: 14275
		[Token(Token = "0x40037C3")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, PlayerGoodProgressData> progressInfo;
	}
}
