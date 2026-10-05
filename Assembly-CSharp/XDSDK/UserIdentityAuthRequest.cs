using System;
using Il2CppDummyDll;

namespace XDSDK
{
	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000E2")]
	public class UserIdentityAuthRequest
	{
		// Token: 0x060003AC RID: 940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UserIdentityAuthRequest()
		{
		}

		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		[FieldOffset(Offset = "0x10")]
		public string token;

		// Token: 0x04000483 RID: 1155
		[Token(Token = "0x4000483")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04000484 RID: 1156
		[Token(Token = "0x4000484")]
		[FieldOffset(Offset = "0x20")]
		public string idCardNum;
	}
}
