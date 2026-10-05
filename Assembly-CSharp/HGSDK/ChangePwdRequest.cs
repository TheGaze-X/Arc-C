using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x0200014C RID: 332
	[Token(Token = "0x200014C")]
	public class ChangePwdRequest
	{
		// Token: 0x06000509 RID: 1289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChangePwdRequest()
		{
		}

		// Token: 0x0400067C RID: 1660
		[Token(Token = "0x400067C")]
		[FieldOffset(Offset = "0x10")]
		public string token;

		// Token: 0x0400067D RID: 1661
		[Token(Token = "0x400067D")]
		[FieldOffset(Offset = "0x18")]
		public string newPassword;

		// Token: 0x0400067E RID: 1662
		[Token(Token = "0x400067E")]
		[FieldOffset(Offset = "0x20")]
		public string phoneCode;
	}
}
