using System;
using Il2CppDummyDll;

namespace XDSDK
{
	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	public class PayCreateOrderAppstoreResponse
	{
		// Token: 0x0600039D RID: 925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PayCreateOrderAppstoreResponse()
		{
		}

		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x10")]
		public string err;

		// Token: 0x0400044D RID: 1101
		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0x18")]
		public string orderId;
	}
}
