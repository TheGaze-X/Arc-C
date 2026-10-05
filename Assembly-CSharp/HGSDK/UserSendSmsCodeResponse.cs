using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace HGSDK
{
	// Token: 0x0200013B RID: 315
	[Token(Token = "0x200013B")]
	public class UserSendSmsCodeResponse
	{
		// Token: 0x060004F8 RID: 1272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UserSendSmsCodeResponse()
		{
		}

		// Token: 0x04000637 RID: 1591
		[Token(Token = "0x4000637")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x04000638 RID: 1592
		[Token(Token = "0x4000638")]
		[FieldOffset(Offset = "0x18")]
		public string code;

		// Token: 0x04000639 RID: 1593
		[Token(Token = "0x4000639")]
		[FieldOffset(Offset = "0x20")]
		public JObject captcha;
	}
}
