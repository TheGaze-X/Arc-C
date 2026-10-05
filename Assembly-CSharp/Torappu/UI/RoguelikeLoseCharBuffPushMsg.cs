using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003B07 RID: 15111
	[Token(Token = "0x2003B07")]
	public class RoguelikeLoseCharBuffPushMsg
	{
		// Token: 0x06017CE3 RID: 97507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CE3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeLoseCharBuffPushMsg()
		{
		}

		// Token: 0x0401CC17 RID: 117783
		[Token(Token = "0x401CC17")]
		[FieldOffset(Offset = "0x10")]
		public List<string> charList;
	}
}
