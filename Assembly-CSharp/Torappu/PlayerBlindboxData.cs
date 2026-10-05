using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A2A RID: 2602
	[Token(Token = "0x2000A2A")]
	public class PlayerBlindboxData
	{
		// Token: 0x060066E9 RID: 26345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E9")]
		[Address(RVA = "0x1EF1230", Offset = "0x1EEFE30", VA = "0x181EF1230")]
		public PlayerBlindboxData()
		{
		}

		// Token: 0x040037D2 RID: 14290
		[Token(Token = "0x40037D2")]
		[FieldOffset(Offset = "0x10")]
		public List<PlayerGoodItemData> info;
	}
}
