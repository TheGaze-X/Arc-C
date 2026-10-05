using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007B3 RID: 1971
	[Token(Token = "0x20007B3")]
	public class ReceiveMailResponse : PlayerDeltaResponse
	{
		// Token: 0x06006431 RID: 25649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006431")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ReceiveMailResponse()
		{
		}

		// Token: 0x040030C3 RID: 12483
		[Token(Token = "0x40030C3")]
		[FieldOffset(Offset = "0x28")]
		public int result;

		// Token: 0x040030C4 RID: 12484
		[Token(Token = "0x40030C4")]
		[FieldOffset(Offset = "0x30")]
		public List<MailGet> items;
	}
}
