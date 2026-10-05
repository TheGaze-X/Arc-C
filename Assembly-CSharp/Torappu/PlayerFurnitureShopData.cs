using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A28 RID: 2600
	[Token(Token = "0x2000A28")]
	public class PlayerFurnitureShopData
	{
		// Token: 0x060066E7 RID: 26343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E7")]
		[Address(RVA = "0x1EFA5A0", Offset = "0x1EF91A0", VA = "0x181EFA5A0")]
		public PlayerFurnitureShopData()
		{
		}

		// Token: 0x040037CE RID: 14286
		[Token(Token = "0x40037CE")]
		[FieldOffset(Offset = "0x10")]
		public List<PlayerGoodItemData> info;

		// Token: 0x040037CF RID: 14287
		[Token(Token = "0x40037CF")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, int> groupInfo;
	}
}
