using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200083F RID: 2111
	[Token(Token = "0x200083F")]
	public class BuySkinGoodRequest
	{
		// Token: 0x060064D7 RID: 25815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064D7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuySkinGoodRequest()
		{
		}

		// Token: 0x04003143 RID: 12611
		[Token(Token = "0x4003143")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x04003144 RID: 12612
		[Token(Token = "0x4003144")]
		[FieldOffset(Offset = "0x18")]
		public bool isSpecial;

		// Token: 0x04003145 RID: 12613
		[Token(Token = "0x4003145")]
		[FieldOffset(Offset = "0x20")]
		public long enterTs;
	}
}
