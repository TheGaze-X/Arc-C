using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007B5 RID: 1973
	[Token(Token = "0x20007B5")]
	public class RemoveAllRecievedMailRequest : RemoveAllCommonRecievedMailRequest
	{
		// Token: 0x06006433 RID: 25651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006433")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RemoveAllRecievedMailRequest()
		{
		}

		// Token: 0x040030C6 RID: 12486
		[Token(Token = "0x40030C6")]
		[FieldOffset(Offset = "0x18")]
		public List<long> sysMailIdList;

		// Token: 0x040030C7 RID: 12487
		[Token(Token = "0x40030C7")]
		[FieldOffset(Offset = "0x20")]
		public List<string> surveyMailIdList;
	}
}
