using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007B4 RID: 1972
	[Token(Token = "0x20007B4")]
	public class RemoveAllCommonRecievedMailRequest
	{
		// Token: 0x06006432 RID: 25650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006432")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RemoveAllCommonRecievedMailRequest()
		{
		}

		// Token: 0x040030C5 RID: 12485
		[Token(Token = "0x40030C5")]
		[FieldOffset(Offset = "0x10")]
		public List<long> mailIdList;
	}
}
