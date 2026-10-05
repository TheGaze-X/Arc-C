using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007B8 RID: 1976
	[Token(Token = "0x20007B8")]
	public class ReceiveAllMailResponse : PlayerDeltaResponse
	{
		// Token: 0x06006436 RID: 25654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006436")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ReceiveAllMailResponse()
		{
		}

		// Token: 0x040030C9 RID: 12489
		[Token(Token = "0x40030C9")]
		[FieldOffset(Offset = "0x28")]
		public List<MailGet> items;
	}
}
