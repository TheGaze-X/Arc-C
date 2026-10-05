using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A29 RID: 2601
	[Token(Token = "0x2000A29")]
	public class PlayerSkinShopData
	{
		// Token: 0x060066E8 RID: 26344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E8")]
		[Address(RVA = "0x1EFE810", Offset = "0x1EFD410", VA = "0x181EFE810")]
		public PlayerSkinShopData()
		{
		}

		// Token: 0x040037D0 RID: 14288
		[Token(Token = "0x40037D0")]
		[FieldOffset(Offset = "0x10")]
		public List<PlayerGoodItemData> info;

		// Token: 0x040037D1 RID: 14289
		[Token(Token = "0x40037D1")]
		[FieldOffset(Offset = "0x18")]
		public PlayerBlindboxData gachaGood;
	}
}
