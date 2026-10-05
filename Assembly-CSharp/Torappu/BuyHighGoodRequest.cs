using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200084F RID: 2127
	[Token(Token = "0x200084F")]
	public class BuyHighGoodRequest
	{
		// Token: 0x060064E6 RID: 25830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuyHighGoodRequest()
		{
		}

		// Token: 0x0400315E RID: 12638
		[Token(Token = "0x400315E")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x0400315F RID: 12639
		[Token(Token = "0x400315F")]
		[FieldOffset(Offset = "0x18")]
		public int count;
	}
}
