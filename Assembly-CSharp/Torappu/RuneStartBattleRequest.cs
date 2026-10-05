using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000831 RID: 2097
	[Token(Token = "0x2000831")]
	public class RuneStartBattleRequest : CommonStartBattleRequest
	{
		// Token: 0x060064C0 RID: 25792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RuneStartBattleRequest()
		{
		}

		// Token: 0x04003135 RID: 12597
		[Token(Token = "0x4003135")]
		[FieldOffset(Offset = "0x40")]
		public List<string> rune;

		// Token: 0x04003136 RID: 12598
		[Token(Token = "0x4003136")]
		[FieldOffset(Offset = "0x48")]
		public bool isPractice;
	}
}
