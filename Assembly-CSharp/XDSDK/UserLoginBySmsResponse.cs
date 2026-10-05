using System;
using Il2CppDummyDll;

namespace XDSDK
{
	// Token: 0x020000E1 RID: 225
	[Token(Token = "0x20000E1")]
	public class UserLoginBySmsResponse
	{
		// Token: 0x060003AB RID: 939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UserLoginBySmsResponse()
		{
		}

		// Token: 0x0400047A RID: 1146
		[Token(Token = "0x400047A")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x0400047B RID: 1147
		[Token(Token = "0x400047B")]
		[FieldOffset(Offset = "0x18")]
		public string uid;

		// Token: 0x0400047C RID: 1148
		[Token(Token = "0x400047C")]
		[FieldOffset(Offset = "0x20")]
		public int role;

		// Token: 0x0400047D RID: 1149
		[Token(Token = "0x400047D")]
		[FieldOffset(Offset = "0x28")]
		public string token;

		// Token: 0x0400047E RID: 1150
		[Token(Token = "0x400047E")]
		[FieldOffset(Offset = "0x30")]
		public bool isAuthenticate;

		// Token: 0x0400047F RID: 1151
		[Token(Token = "0x400047F")]
		[FieldOffset(Offset = "0x31")]
		public bool isMinor;

		// Token: 0x04000480 RID: 1152
		[Token(Token = "0x4000480")]
		[FieldOffset(Offset = "0x38")]
		public long issuedAt;

		// Token: 0x04000481 RID: 1153
		[Token(Token = "0x4000481")]
		[FieldOffset(Offset = "0x40")]
		public long expiresIn;
	}
}
