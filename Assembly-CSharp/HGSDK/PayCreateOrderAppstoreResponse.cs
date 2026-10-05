using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x02000134 RID: 308
	[Token(Token = "0x2000134")]
	public class PayCreateOrderAppstoreResponse
	{
		// Token: 0x060004F2 RID: 1266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PayCreateOrderAppstoreResponse()
		{
		}

		// Token: 0x04000624 RID: 1572
		[Token(Token = "0x4000624")]
		[FieldOffset(Offset = "0x10")]
		public string err;

		// Token: 0x04000625 RID: 1573
		[Token(Token = "0x4000625")]
		[FieldOffset(Offset = "0x18")]
		public string orderId;

		// Token: 0x04000626 RID: 1574
		[Token(Token = "0x4000626")]
		[FieldOffset(Offset = "0x20")]
		public string appUsername;
	}
}
