using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020009F4 RID: 2548
	[Token(Token = "0x20009F4")]
	public class OpenServerChainLogin
	{
		// Token: 0x060066BA RID: 26298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066BA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public OpenServerChainLogin()
		{
		}

		// Token: 0x0400372F RID: 14127
		[Token(Token = "0x400372F")]
		[FieldOffset(Offset = "0x10")]
		public bool isAvailable;

		// Token: 0x04003730 RID: 14128
		[Token(Token = "0x4003730")]
		[FieldOffset(Offset = "0x14")]
		public int nowIndex;

		// Token: 0x04003731 RID: 14129
		[Token(Token = "0x4003731")]
		[FieldOffset(Offset = "0x18")]
		public List<bool> history;
	}
}
