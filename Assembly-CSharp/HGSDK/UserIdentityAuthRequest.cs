using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x02000144 RID: 324
	[Token(Token = "0x2000144")]
	public class UserIdentityAuthRequest
	{
		// Token: 0x06000501 RID: 1281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UserIdentityAuthRequest()
		{
		}

		// Token: 0x04000669 RID: 1641
		[Token(Token = "0x4000669")]
		[FieldOffset(Offset = "0x10")]
		public string token;

		// Token: 0x0400066A RID: 1642
		[Token(Token = "0x400066A")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0400066B RID: 1643
		[Token(Token = "0x400066B")]
		[FieldOffset(Offset = "0x20")]
		public string idCardNum;

		// Token: 0x0400066C RID: 1644
		[Token(Token = "0x400066C")]
		[FieldOffset(Offset = "0x28")]
		public string captcha;
	}
}
