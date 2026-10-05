using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A01 RID: 2561
	[Token(Token = "0x2000A01")]
	public class PlayerAutoChessPerm
	{
		// Token: 0x060066C5 RID: 26309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066C5")]
		[Address(RVA = "0x1EF0F50", Offset = "0x1EEFB50", VA = "0x181EF0F50")]
		public PlayerAutoChessPerm()
		{
		}

		// Token: 0x04003754 RID: 14164
		[Token(Token = "0x4003754")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, int> band;

		// Token: 0x04003755 RID: 14165
		[Token(Token = "0x4003755")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, int> trainingModeFin;
	}
}
