using System;
using Il2CppDummyDll;

namespace XDSDK
{
	// Token: 0x020000DF RID: 223
	[Token(Token = "0x20000DF")]
	public class UserRegisterResponse
	{
		// Token: 0x060003A9 RID: 937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UserRegisterResponse()
		{
		}

		// Token: 0x0400046F RID: 1135
		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x04000470 RID: 1136
		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0x18")]
		public string uid;

		// Token: 0x04000471 RID: 1137
		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0x20")]
		public int role;

		// Token: 0x04000472 RID: 1138
		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0x28")]
		public string token;

		// Token: 0x04000473 RID: 1139
		[Token(Token = "0x4000473")]
		[FieldOffset(Offset = "0x30")]
		public long issuedAt;

		// Token: 0x04000474 RID: 1140
		[Token(Token = "0x4000474")]
		[FieldOffset(Offset = "0x38")]
		public long expiresIn;

		// Token: 0x04000475 RID: 1141
		[Token(Token = "0x4000475")]
		[FieldOffset(Offset = "0x40")]
		public string errMsg;
	}
}
