using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A22 RID: 2594
	[Token(Token = "0x2000A22")]
	public class PlayerExtraQCShopProgressData
	{
		// Token: 0x060066E1 RID: 26337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E1")]
		[Address(RVA = "0x1EFA110", Offset = "0x1EF8D10", VA = "0x181EFA110")]
		public PlayerExtraQCShopProgressData()
		{
		}

		// Token: 0x040037C6 RID: 14278
		[Token(Token = "0x40037C6")]
		[FieldOffset(Offset = "0x10")]
		public List<PlayerGoodItemData> info;

		// Token: 0x040037C7 RID: 14279
		[Token(Token = "0x40037C7")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, PlayerGoodProgressData> progressInfo;

		// Token: 0x040037C8 RID: 14280
		[Token(Token = "0x40037C8")]
		[FieldOffset(Offset = "0x20")]
		public long lastClick;
	}
}
