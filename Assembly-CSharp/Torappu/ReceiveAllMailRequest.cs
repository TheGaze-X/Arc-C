using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007B9 RID: 1977
	[Token(Token = "0x20007B9")]
	public class ReceiveAllMailRequest : ReceiveAllCommonMailRequest
	{
		// Token: 0x06006437 RID: 25655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006437")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ReceiveAllMailRequest()
		{
		}

		// Token: 0x040030CA RID: 12490
		[Token(Token = "0x40030CA")]
		[FieldOffset(Offset = "0x18")]
		public List<long> sysMailIdList;
	}
}
