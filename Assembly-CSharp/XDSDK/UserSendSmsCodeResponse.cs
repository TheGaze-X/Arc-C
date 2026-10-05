using System;
using Il2CppDummyDll;

namespace XDSDK
{
	// Token: 0x020000D9 RID: 217
	[Token(Token = "0x20000D9")]
	public class UserSendSmsCodeResponse
	{
		// Token: 0x060003A3 RID: 931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UserSendSmsCodeResponse()
		{
		}

		// Token: 0x0400045D RID: 1117
		[Token(Token = "0x400045D")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x400045E")]
		[FieldOffset(Offset = "0x18")]
		public string code;
	}
}
