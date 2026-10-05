using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000855 RID: 2133
	[Token(Token = "0x2000855")]
	public class BuyEPGSGoodRequest
	{
		// Token: 0x060064EC RID: 25836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064EC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuyEPGSGoodRequest()
		{
		}

		// Token: 0x04003167 RID: 12647
		[Token(Token = "0x4003167")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x04003168 RID: 12648
		[Token(Token = "0x4003168")]
		[FieldOffset(Offset = "0x18")]
		public int count;
	}
}
