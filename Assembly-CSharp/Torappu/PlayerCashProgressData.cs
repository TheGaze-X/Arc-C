using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A25 RID: 2597
	[Token(Token = "0x2000A25")]
	public class PlayerCashProgressData
	{
		// Token: 0x060066E4 RID: 26340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E4")]
		[Address(RVA = "0x1EF2DD0", Offset = "0x1EF19D0", VA = "0x181EF2DD0")]
		public PlayerCashProgressData()
		{
		}

		// Token: 0x040037CB RID: 14283
		[Token(Token = "0x40037CB")]
		[FieldOffset(Offset = "0x10")]
		public List<PlayerGoodItemData> info;
	}
}
