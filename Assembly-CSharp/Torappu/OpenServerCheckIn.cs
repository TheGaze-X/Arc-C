using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020009F5 RID: 2549
	[Token(Token = "0x20009F5")]
	public class OpenServerCheckIn
	{
		// Token: 0x060066BB RID: 26299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066BB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public OpenServerCheckIn()
		{
		}

		// Token: 0x04003732 RID: 14130
		[Token(Token = "0x4003732")]
		[FieldOffset(Offset = "0x10")]
		public bool isAvailable;

		// Token: 0x04003733 RID: 14131
		[Token(Token = "0x4003733")]
		[FieldOffset(Offset = "0x18")]
		public List<bool> history;
	}
}
