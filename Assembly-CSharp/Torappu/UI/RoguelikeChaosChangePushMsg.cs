using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003B13 RID: 15123
	[Token(Token = "0x2003B13")]
	public class RoguelikeChaosChangePushMsg
	{
		// Token: 0x06017D03 RID: 97539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D03")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeChaosChangePushMsg()
		{
		}

		// Token: 0x0401CC38 RID: 117816
		[Token(Token = "0x401CC38")]
		[FieldOffset(Offset = "0x10")]
		public bool upgrade;

		// Token: 0x0401CC39 RID: 117817
		[Token(Token = "0x401CC39")]
		[FieldOffset(Offset = "0x18")]
		public List<string> changeList;
	}
}
