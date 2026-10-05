using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005847 RID: 22599
	[Token(Token = "0x2005847")]
	public class RL03UseTotemRequest
	{
		// Token: 0x06021051 RID: 135249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021051")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RL03UseTotemRequest()
		{
		}

		// Token: 0x0402CE9E RID: 183966
		[Token(Token = "0x402CE9E")]
		[FieldOffset(Offset = "0x10")]
		public List<string> totemIndex;

		// Token: 0x0402CE9F RID: 183967
		[Token(Token = "0x402CE9F")]
		[FieldOffset(Offset = "0x18")]
		public List<string> nodeIndex;
	}
}
