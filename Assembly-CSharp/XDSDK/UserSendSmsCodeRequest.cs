using System;
using Il2CppDummyDll;

namespace XDSDK
{
	// Token: 0x020000D8 RID: 216
	[Token(Token = "0x20000D8")]
	public class UserSendSmsCodeRequest
	{
		// Token: 0x060003A2 RID: 930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UserSendSmsCodeRequest()
		{
		}

		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x10")]
		public string account;

		// Token: 0x0400045C RID: 1116
		[Token(Token = "0x400045C")]
		[FieldOffset(Offset = "0x18")]
		public int type;
	}
}
