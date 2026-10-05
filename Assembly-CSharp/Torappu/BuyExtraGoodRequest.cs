using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200084D RID: 2125
	[Token(Token = "0x200084D")]
	public class BuyExtraGoodRequest
	{
		// Token: 0x060064E4 RID: 25828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuyExtraGoodRequest()
		{
		}

		// Token: 0x0400315B RID: 12635
		[Token(Token = "0x400315B")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x0400315C RID: 12636
		[Token(Token = "0x400315C")]
		[FieldOffset(Offset = "0x18")]
		public int count;
	}
}
