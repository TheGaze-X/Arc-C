using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A23 RID: 2595
	[Token(Token = "0x2000A23")]
	public class PlayerLMTGSProgressData
	{
		// Token: 0x060066E2 RID: 26338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E2")]
		[Address(RVA = "0x1EFB000", Offset = "0x1EF9C00", VA = "0x181EFB000")]
		public PlayerLMTGSProgressData()
		{
		}

		// Token: 0x040037C9 RID: 14281
		[Token(Token = "0x40037C9")]
		[FieldOffset(Offset = "0x10")]
		public List<PlayerGoodItemData> info;
	}
}
