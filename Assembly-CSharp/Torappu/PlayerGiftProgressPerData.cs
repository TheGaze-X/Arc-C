using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A26 RID: 2598
	[Token(Token = "0x2000A26")]
	public class PlayerGiftProgressPerData
	{
		// Token: 0x060066E5 RID: 26341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E5")]
		[Address(RVA = "0x1EFAB10", Offset = "0x1EF9710", VA = "0x181EFAB10")]
		public PlayerGiftProgressPerData()
		{
		}

		// Token: 0x040037CC RID: 14284
		[Token(Token = "0x40037CC")]
		[FieldOffset(Offset = "0x10")]
		public List<PlayerGoodItemData> info;
	}
}
