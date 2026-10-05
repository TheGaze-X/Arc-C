using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	public class UniversalLinkRet
	{
		// Token: 0x06000248 RID: 584 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UniversalLinkRet()
		{
		}

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x10")]
		public int R_CODE;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x18")]
		public string R_MSG;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x20")]
		public string DATA;
	}
}
