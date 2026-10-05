using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001008 RID: 4104
	[Token(Token = "0x2001008")]
	public class MailSenderData
	{
		// Token: 0x06006D5F RID: 27999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D5F")]
		[Address(RVA = "0x2107260", Offset = "0x2105E60", VA = "0x182107260")]
		public MailSenderData()
		{
		}

		// Token: 0x0400570F RID: 22287
		[Token(Token = "0x400570F")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, MailSenderSingleInfo> senderDict;
	}
}
