using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	public class LocNotificationRet
	{
		// Token: 0x0600024A RID: 586 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LocNotificationRet()
		{
		}

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x10")]
		public int R_CODE;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x18")]
		public string R_MSG;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x20")]
		public int IDENTIFIER;
	}
}
