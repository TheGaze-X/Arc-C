using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x0200013C RID: 316
	[Token(Token = "0x200013C")]
	public class UserGuestLoginRequest
	{
		// Token: 0x060004F9 RID: 1273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UserGuestLoginRequest()
		{
		}

		// Token: 0x0400063A RID: 1594
		[Token(Token = "0x400063A")]
		[FieldOffset(Offset = "0x10")]
		public string deviceId;

		// Token: 0x0400063B RID: 1595
		[Token(Token = "0x400063B")]
		[FieldOffset(Offset = "0x18")]
		public string captcha;
	}
}
