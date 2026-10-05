using System;
using Il2CppDummyDll;
using Torappu;

namespace HGSDK
{
	// Token: 0x0200012F RID: 303
	[Token(Token = "0x200012F")]
	public class LoginRequest
	{
		// Token: 0x060004EE RID: 1262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LoginRequest()
		{
		}

		// Token: 0x0400060A RID: 1546
		[Token(Token = "0x400060A")]
		[FieldOffset(Offset = "0x10")]
		public string account;

		// Token: 0x0400060B RID: 1547
		[Token(Token = "0x400060B")]
		[FieldOffset(Offset = "0x18")]
		public string password;

		// Token: 0x0400060C RID: 1548
		[Token(Token = "0x400060C")]
		[FieldOffset(Offset = "0x20")]
		public string deviceId;

		// Token: 0x0400060D RID: 1549
		[Token(Token = "0x400060D")]
		[FieldOffset(Offset = "0x28")]
		public PlatformKey platform;

		// Token: 0x0400060E RID: 1550
		[Token(Token = "0x400060E")]
		[FieldOffset(Offset = "0x30")]
		public string captcha;
	}
}
