using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000790 RID: 1936
	[Token(Token = "0x2000790")]
	public class GetVoucherDetailRequest
	{
		// Token: 0x06006410 RID: 25616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006410")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GetVoucherDetailRequest()
		{
		}

		// Token: 0x04003059 RID: 12377
		[Token(Token = "0x4003059")]
		[FieldOffset(Offset = "0x10")]
		public string instId;

		// Token: 0x0400305A RID: 12378
		[Token(Token = "0x400305A")]
		[FieldOffset(Offset = "0x18")]
		public string itemId;
	}
}
