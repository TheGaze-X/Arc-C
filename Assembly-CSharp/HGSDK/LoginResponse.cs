using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace HGSDK
{
	// Token: 0x02000130 RID: 304
	[Token(Token = "0x2000130")]
	public class LoginResponse
	{
		// Token: 0x060004EF RID: 1263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x10344C0", Offset = "0x10330C0", VA = "0x1810344C0")]
		public LoginResponse()
		{
		}

		// Token: 0x0400060F RID: 1551
		[Token(Token = "0x400060F")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x04000610 RID: 1552
		[Token(Token = "0x4000610")]
		[FieldOffset(Offset = "0x18")]
		public string uid;

		// Token: 0x04000611 RID: 1553
		[Token(Token = "0x4000611")]
		[FieldOffset(Offset = "0x20")]
		public int role;

		// Token: 0x04000612 RID: 1554
		[Token(Token = "0x4000612")]
		[FieldOffset(Offset = "0x28")]
		public string token;

		// Token: 0x04000613 RID: 1555
		[Token(Token = "0x4000613")]
		[FieldOffset(Offset = "0x30")]
		public bool isAuthenticate;

		// Token: 0x04000614 RID: 1556
		[Token(Token = "0x4000614")]
		[FieldOffset(Offset = "0x31")]
		public bool isMinor;

		// Token: 0x04000615 RID: 1557
		[Token(Token = "0x4000615")]
		[FieldOffset(Offset = "0x32")]
		public bool needAuthenticate;

		// Token: 0x04000616 RID: 1558
		[Token(Token = "0x4000616")]
		[FieldOffset(Offset = "0x38")]
		public DateTime issuedAt;

		// Token: 0x04000617 RID: 1559
		[Token(Token = "0x4000617")]
		[FieldOffset(Offset = "0x40")]
		public DateTime expiresIn;

		// Token: 0x04000618 RID: 1560
		[Token(Token = "0x4000618")]
		[FieldOffset(Offset = "0x48")]
		public bool isLatestUserAgreement;

		// Token: 0x04000619 RID: 1561
		[Token(Token = "0x4000619")]
		[FieldOffset(Offset = "0x50")]
		public JObject captcha;
	}
}
