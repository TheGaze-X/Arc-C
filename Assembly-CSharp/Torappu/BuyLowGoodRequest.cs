using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200084B RID: 2123
	[Token(Token = "0x200084B")]
	public class BuyLowGoodRequest
	{
		// Token: 0x060064E2 RID: 25826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuyLowGoodRequest()
		{
		}

		// Token: 0x04003158 RID: 12632
		[Token(Token = "0x4003158")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x04003159 RID: 12633
		[Token(Token = "0x4003159")]
		[FieldOffset(Offset = "0x18")]
		public int count;
	}
}
