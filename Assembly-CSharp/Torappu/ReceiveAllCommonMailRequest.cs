using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007B7 RID: 1975
	[Token(Token = "0x20007B7")]
	public class ReceiveAllCommonMailRequest
	{
		// Token: 0x06006435 RID: 25653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006435")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ReceiveAllCommonMailRequest()
		{
		}

		// Token: 0x040030C8 RID: 12488
		[Token(Token = "0x40030C8")]
		[FieldOffset(Offset = "0x10")]
		public List<long> mailIdList;
	}
}
