using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A32 RID: 2610
	[Token(Token = "0x2000A32")]
	public class PlayerTicketItem
	{
		// Token: 0x060066F0 RID: 26352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066F0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerTicketItem()
		{
		}

		// Token: 0x040037F3 RID: 14323
		[Token(Token = "0x40037F3")]
		[FieldOffset(Offset = "0x10")]
		public long ts;

		// Token: 0x040037F4 RID: 14324
		[Token(Token = "0x40037F4")]
		[FieldOffset(Offset = "0x18")]
		public int count;
	}
}
