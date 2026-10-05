using System;
using Il2CppDummyDll;

namespace XDSDK
{
	// Token: 0x020000DA RID: 218
	[Token(Token = "0x20000DA")]
	public class UserGuestLoginRequest
	{
		// Token: 0x060003A4 RID: 932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UserGuestLoginRequest()
		{
		}

		// Token: 0x0400045F RID: 1119
		[Token(Token = "0x400045F")]
		[FieldOffset(Offset = "0x10")]
		public string deviceId;

		// Token: 0x04000460 RID: 1120
		[Token(Token = "0x4000460")]
		[FieldOffset(Offset = "0x18")]
		public string captcha;
	}
}
