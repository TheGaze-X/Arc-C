using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000726 RID: 1830
	[Token(Token = "0x2000726")]
	public class SearchPlayerRequest
	{
		// Token: 0x06006391 RID: 25489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006391")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SearchPlayerRequest()
		{
		}

		// Token: 0x04002F8F RID: 12175
		[Token(Token = "0x4002F8F")]
		[FieldOffset(Offset = "0x10")]
		public List<string> idList;
	}
}
