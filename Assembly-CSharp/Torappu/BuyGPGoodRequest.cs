using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000847 RID: 2119
	[Token(Token = "0x2000847")]
	public class BuyGPGoodRequest
	{
		// Token: 0x060064DE RID: 25822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064DE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuyGPGoodRequest()
		{
		}

		// Token: 0x04003152 RID: 12626
		[Token(Token = "0x4003152")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x04003153 RID: 12627
		[Token(Token = "0x4003153")]
		[FieldOffset(Offset = "0x18")]
		public long enterTs;
	}
}
