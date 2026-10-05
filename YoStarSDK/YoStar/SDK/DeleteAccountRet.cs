using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	public class DeleteAccountRet
	{
		// Token: 0x06000243 RID: 579 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DeleteAccountRet()
		{
		}

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x10")]
		public int R_CODE;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x18")]
		public string R_MSG;
	}
}
