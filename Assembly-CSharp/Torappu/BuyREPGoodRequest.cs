using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000857 RID: 2135
	[Token(Token = "0x2000857")]
	public class BuyREPGoodRequest
	{
		// Token: 0x060064EE RID: 25838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064EE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuyREPGoodRequest()
		{
		}

		// Token: 0x0400316A RID: 12650
		[Token(Token = "0x400316A")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x0400316B RID: 12651
		[Token(Token = "0x400316B")]
		[FieldOffset(Offset = "0x18")]
		public int count;
	}
}
