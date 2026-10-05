using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007B2 RID: 1970
	[Token(Token = "0x20007B2")]
	public class ReceiveMailRequest : ReceiveCommonMailRequest
	{
		// Token: 0x06006430 RID: 25648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006430")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ReceiveMailRequest()
		{
		}

		// Token: 0x040030C2 RID: 12482
		[Token(Token = "0x40030C2")]
		[FieldOffset(Offset = "0x18")]
		public MailFromInfo type;
	}
}
