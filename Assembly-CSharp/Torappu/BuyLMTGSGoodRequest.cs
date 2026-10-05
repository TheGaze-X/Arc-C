using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000851 RID: 2129
	[Token(Token = "0x2000851")]
	public class BuyLMTGSGoodRequest
	{
		// Token: 0x060064E8 RID: 25832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuyLMTGSGoodRequest()
		{
		}

		// Token: 0x04003161 RID: 12641
		[Token(Token = "0x4003161")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x04003162 RID: 12642
		[Token(Token = "0x4003162")]
		[FieldOffset(Offset = "0x18")]
		public int count;
	}
}
