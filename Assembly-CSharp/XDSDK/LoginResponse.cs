using System;
using Il2CppDummyDll;

namespace XDSDK
{
	// Token: 0x020000CE RID: 206
	[Token(Token = "0x20000CE")]
	public class LoginResponse
	{
		// Token: 0x0600039A RID: 922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LoginResponse()
		{
		}

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x18")]
		public string uid;

		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x20")]
		public int role;

		// Token: 0x0400043F RID: 1087
		[Token(Token = "0x400043F")]
		[FieldOffset(Offset = "0x28")]
		public string token;

		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x30")]
		public bool isAuthenticate;

		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x31")]
		public bool isMinor;

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x38")]
		public DateTime issuedAt;

		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x40")]
		public DateTime expiresIn;
	}
}
