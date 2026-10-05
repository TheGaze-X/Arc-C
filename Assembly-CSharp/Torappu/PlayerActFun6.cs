using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000B81 RID: 2945
	[Token(Token = "0x2000B81")]
	public class PlayerActFun6
	{
		// Token: 0x06006820 RID: 26656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006820")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerActFun6()
		{
		}

		// Token: 0x04003D13 RID: 15635
		[Token(Token = "0x4003D13")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, PlayerActFun6Stage> stages;

		// Token: 0x04003D14 RID: 15636
		[Token(Token = "0x4003D14")]
		[FieldOffset(Offset = "0x18")]
		public List<string> recvList;
	}
}
