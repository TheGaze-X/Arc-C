using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000859 RID: 2137
	[Token(Token = "0x2000859")]
	public class BuySocialGoodRequest
	{
		// Token: 0x060064F0 RID: 25840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuySocialGoodRequest()
		{
		}

		// Token: 0x0400316D RID: 12653
		[Token(Token = "0x400316D")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x0400316E RID: 12654
		[Token(Token = "0x400316E")]
		[FieldOffset(Offset = "0x18")]
		public int count;
	}
}
