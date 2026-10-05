using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A3E RID: 2622
	[Token(Token = "0x2000A3E")]
	public class PlayerFormulaUnlockRecord
	{
		// Token: 0x060066FD RID: 26365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066FD")]
		[Address(RVA = "0x1EFA440", Offset = "0x1EF9040", VA = "0x181EFA440")]
		public PlayerFormulaUnlockRecord()
		{
		}

		// Token: 0x04003819 RID: 14361
		[Token(Token = "0x4003819")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, int> manufacture;

		// Token: 0x0400381A RID: 14362
		[Token(Token = "0x400381A")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, int> workshop;
	}
}
