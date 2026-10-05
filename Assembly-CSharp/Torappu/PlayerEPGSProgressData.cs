using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A24 RID: 2596
	[Token(Token = "0x2000A24")]
	public class PlayerEPGSProgressData
	{
		// Token: 0x060066E3 RID: 26339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E3")]
		[Address(RVA = "0x1EF9E20", Offset = "0x1EF8A20", VA = "0x181EF9E20")]
		public PlayerEPGSProgressData()
		{
		}

		// Token: 0x040037CA RID: 14282
		[Token(Token = "0x40037CA")]
		[FieldOffset(Offset = "0x10")]
		public List<PlayerGoodItemData> info;
	}
}
