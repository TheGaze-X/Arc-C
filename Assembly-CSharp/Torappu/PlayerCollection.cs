using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A4A RID: 2634
	[Token(Token = "0x2000A4A")]
	public class PlayerCollection
	{
		// Token: 0x06006709 RID: 26377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006709")]
		[Address(RVA = "0x1EF4180", Offset = "0x1EF2D80", VA = "0x181EF4180")]
		public PlayerCollection()
		{
		}

		// Token: 0x04003836 RID: 14390
		[Token(Token = "0x4003836")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, int> team;
	}
}
