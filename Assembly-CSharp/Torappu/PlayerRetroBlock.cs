using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A47 RID: 2631
	[Token(Token = "0x2000A47")]
	public class PlayerRetroBlock
	{
		// Token: 0x06006706 RID: 26374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006706")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerRetroBlock()
		{
		}

		// Token: 0x04003831 RID: 14385
		[Token(Token = "0x4003831")]
		[FieldOffset(Offset = "0x10")]
		public bool locked;

		// Token: 0x04003832 RID: 14386
		[Token(Token = "0x4003832")]
		[FieldOffset(Offset = "0x11")]
		public bool open;
	}
}
