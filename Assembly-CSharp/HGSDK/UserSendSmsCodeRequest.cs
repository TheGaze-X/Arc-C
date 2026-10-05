using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x0200013A RID: 314
	[Token(Token = "0x200013A")]
	public class UserSendSmsCodeRequest
	{
		// Token: 0x060004F7 RID: 1271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UserSendSmsCodeRequest()
		{
		}

		// Token: 0x04000634 RID: 1588
		[Token(Token = "0x4000634")]
		[FieldOffset(Offset = "0x10")]
		public string account;

		// Token: 0x04000635 RID: 1589
		[Token(Token = "0x4000635")]
		[FieldOffset(Offset = "0x18")]
		public int type;

		// Token: 0x04000636 RID: 1590
		[Token(Token = "0x4000636")]
		[FieldOffset(Offset = "0x20")]
		public string captcha;
	}
}
