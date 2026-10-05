using System;
using Il2CppDummyDll;

namespace XDSDK
{
	// Token: 0x020000DB RID: 219
	[Token(Token = "0x20000DB")]
	public class UserGuestLoginResponse
	{
		// Token: 0x060003A5 RID: 933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UserGuestLoginResponse()
		{
		}

		// Token: 0x04000461 RID: 1121
		[Token(Token = "0x4000461")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x04000462 RID: 1122
		[Token(Token = "0x4000462")]
		[FieldOffset(Offset = "0x18")]
		public string uid;

		// Token: 0x04000463 RID: 1123
		[Token(Token = "0x4000463")]
		[FieldOffset(Offset = "0x20")]
		public int role;

		// Token: 0x04000464 RID: 1124
		[Token(Token = "0x4000464")]
		[FieldOffset(Offset = "0x28")]
		public string token;

		// Token: 0x04000465 RID: 1125
		[Token(Token = "0x4000465")]
		[FieldOffset(Offset = "0x30")]
		public long issueAt;

		// Token: 0x04000466 RID: 1126
		[Token(Token = "0x4000466")]
		[FieldOffset(Offset = "0x38")]
		public long expiresIn;
	}
}
