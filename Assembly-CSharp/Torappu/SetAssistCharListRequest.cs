using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200072C RID: 1836
	[Token(Token = "0x200072C")]
	public class SetAssistCharListRequest
	{
		// Token: 0x06006397 RID: 25495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006397")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SetAssistCharListRequest()
		{
		}

		// Token: 0x04002F9A RID: 12186
		[Token(Token = "0x4002F9A")]
		[FieldOffset(Offset = "0x10")]
		public List<RequestAssistChar> assistCharList;
	}
}
