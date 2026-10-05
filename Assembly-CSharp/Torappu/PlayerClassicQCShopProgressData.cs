using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A21 RID: 2593
	[Token(Token = "0x2000A21")]
	public class PlayerClassicQCShopProgressData
	{
		// Token: 0x060066E0 RID: 26336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E0")]
		[Address(RVA = "0x1EF3FE0", Offset = "0x1EF2BE0", VA = "0x181EF3FE0")]
		public PlayerClassicQCShopProgressData()
		{
		}

		// Token: 0x040037C4 RID: 14276
		[Token(Token = "0x40037C4")]
		[FieldOffset(Offset = "0x10")]
		public List<PlayerGoodItemData> info;

		// Token: 0x040037C5 RID: 14277
		[Token(Token = "0x40037C5")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, PlayerGoodProgressData> progressInfo;
	}
}
