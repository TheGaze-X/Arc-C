using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A2C RID: 2604
	[Token(Token = "0x2000A2C")]
	public class PlayerTemplateShop
	{
		// Token: 0x060066EB RID: 26347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066EB")]
		[Address(RVA = "0x1EFF750", Offset = "0x1EFE350", VA = "0x181EFF750")]
		public PlayerTemplateShop()
		{
		}

		// Token: 0x040037D9 RID: 14297
		[Token(Token = "0x40037D9")]
		[FieldOffset(Offset = "0x10")]
		public int coin;

		// Token: 0x040037DA RID: 14298
		[Token(Token = "0x40037DA")]
		[FieldOffset(Offset = "0x18")]
		public List<PlayerGoodItemData> info;

		// Token: 0x040037DB RID: 14299
		[Token(Token = "0x40037DB")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, PlayerGoodProgressData> progressInfo;
	}
}
