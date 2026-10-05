using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A90 RID: 2704
	[Token(Token = "0x2000A90")]
	public class PlayerCrisisShop
	{
		// Token: 0x06006754 RID: 26452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006754")]
		[Address(RVA = "0x1EF42A0", Offset = "0x1EF2EA0", VA = "0x181EF42A0")]
		public PlayerCrisisShop()
		{
		}

		// Token: 0x04003937 RID: 14647
		[Token(Token = "0x4003937")]
		[FieldOffset(Offset = "0x10")]
		public int coin;

		// Token: 0x04003938 RID: 14648
		[Token(Token = "0x4003938")]
		[FieldOffset(Offset = "0x18")]
		public List<PlayerGoodItemData> info;

		// Token: 0x04003939 RID: 14649
		[Token(Token = "0x4003939")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, PlayerGoodProgressData> progressInfo;
	}
}
