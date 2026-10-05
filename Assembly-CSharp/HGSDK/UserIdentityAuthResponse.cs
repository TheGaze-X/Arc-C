using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace HGSDK
{
	// Token: 0x02000145 RID: 325
	[Token(Token = "0x2000145")]
	public class UserIdentityAuthResponse
	{
		// Token: 0x06000502 RID: 1282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UserIdentityAuthResponse()
		{
		}

		// Token: 0x0400066D RID: 1645
		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x0400066E RID: 1646
		[Token(Token = "0x400066E")]
		[FieldOffset(Offset = "0x14")]
		public bool isMinor;

		// Token: 0x0400066F RID: 1647
		[Token(Token = "0x400066F")]
		[FieldOffset(Offset = "0x18")]
		public string message;

		// Token: 0x04000670 RID: 1648
		[Token(Token = "0x4000670")]
		[FieldOffset(Offset = "0x20")]
		public JObject captcha;
	}
}
