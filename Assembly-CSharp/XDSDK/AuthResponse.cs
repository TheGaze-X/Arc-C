using System;
using Il2CppDummyDll;

namespace XDSDK
{
	// Token: 0x020000D0 RID: 208
	[Token(Token = "0x20000D0")]
	public class AuthResponse
	{
		// Token: 0x0600039C RID: 924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AuthResponse()
		{
		}

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x18")]
		public bool isAuthenticate;

		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x19")]
		public bool isMinor;
	}
}
