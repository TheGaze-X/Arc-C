using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200088F RID: 2191
	[Token(Token = "0x200088F")]
	public class PayConfirmOrderRequest
	{
		// Token: 0x0600652F RID: 25903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600652F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PayConfirmOrderRequest()
		{
		}

		// Token: 0x04003228 RID: 12840
		[Token(Token = "0x4003228")]
		[FieldOffset(Offset = "0x10")]
		public string orderId;

		// Token: 0x04003229 RID: 12841
		[Token(Token = "0x4003229")]
		[FieldOffset(Offset = "0x18")]
		public long enterTs;
	}
}
