using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000852 RID: 2130
	[Token(Token = "0x2000852")]
	public class BuyClassicGoodRequest
	{
		// Token: 0x060064E9 RID: 25833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuyClassicGoodRequest()
		{
		}

		// Token: 0x04003163 RID: 12643
		[Token(Token = "0x4003163")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x04003164 RID: 12644
		[Token(Token = "0x4003164")]
		[FieldOffset(Offset = "0x18")]
		public int count;
	}
}
