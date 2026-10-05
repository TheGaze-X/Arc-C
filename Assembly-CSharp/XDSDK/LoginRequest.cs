using System;
using Il2CppDummyDll;
using Torappu;

namespace XDSDK
{
	// Token: 0x020000CD RID: 205
	[Token(Token = "0x20000CD")]
	public class LoginRequest
	{
		// Token: 0x06000399 RID: 921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LoginRequest()
		{
		}

		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x10")]
		public string account;

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x18")]
		public string password;

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x20")]
		public string deviceId;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x28")]
		public PlatformKey platform;
	}
}
