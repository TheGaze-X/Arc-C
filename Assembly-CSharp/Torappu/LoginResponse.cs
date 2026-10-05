using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007A2 RID: 1954
	[Token(Token = "0x20007A2")]
	public class LoginResponse
	{
		// Token: 0x06006422 RID: 25634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006422")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LoginResponse()
		{
		}

		// Token: 0x04003083 RID: 12419
		[Token(Token = "0x4003083")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x04003084 RID: 12420
		[Token(Token = "0x4003084")]
		[FieldOffset(Offset = "0x18")]
		public string uid;

		// Token: 0x04003085 RID: 12421
		[Token(Token = "0x4003085")]
		[FieldOffset(Offset = "0x20")]
		public string secret;

		// Token: 0x04003086 RID: 12422
		[Token(Token = "0x4003086")]
		[FieldOffset(Offset = "0x28")]
		public int serviceLicenseVersion;

		// Token: 0x04003087 RID: 12423
		[Token(Token = "0x4003087")]
		[FieldOffset(Offset = "0x30")]
		public string majorVersion;
	}
}
