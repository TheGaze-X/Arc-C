using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200088B RID: 2187
	[Token(Token = "0x200088B")]
	public class PayCreateOrderRequest
	{
		// Token: 0x0600652B RID: 25899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600652B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PayCreateOrderRequest()
		{
		}

		// Token: 0x0400321F RID: 12831
		[Token(Token = "0x400321F")]
		[FieldOffset(Offset = "0x10")]
		public int storeId;

		// Token: 0x04003220 RID: 12832
		[Token(Token = "0x4003220")]
		[FieldOffset(Offset = "0x18")]
		public string goodId;
	}
}
