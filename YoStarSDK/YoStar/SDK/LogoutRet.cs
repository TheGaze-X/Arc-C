using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	public class LogoutRet
	{
		// Token: 0x0600023E RID: 574 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LogoutRet()
		{
		}

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x10")]
		public int R_CODE;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x18")]
		public string R_MSG;
	}
}
