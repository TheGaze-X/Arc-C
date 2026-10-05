using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace HGSDK
{
	// Token: 0x02000143 RID: 323
	[Token(Token = "0x2000143")]
	public class UserLoginBySmsResponse
	{
		// Token: 0x06000500 RID: 1280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x10344C0", Offset = "0x10330C0", VA = "0x1810344C0")]
		public UserLoginBySmsResponse()
		{
		}

		// Token: 0x0400065E RID: 1630
		[Token(Token = "0x400065E")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x0400065F RID: 1631
		[Token(Token = "0x400065F")]
		[FieldOffset(Offset = "0x18")]
		public string uid;

		// Token: 0x04000660 RID: 1632
		[Token(Token = "0x4000660")]
		[FieldOffset(Offset = "0x20")]
		public int role;

		// Token: 0x04000661 RID: 1633
		[Token(Token = "0x4000661")]
		[FieldOffset(Offset = "0x28")]
		public string token;

		// Token: 0x04000662 RID: 1634
		[Token(Token = "0x4000662")]
		[FieldOffset(Offset = "0x30")]
		public bool isAuthenticate;

		// Token: 0x04000663 RID: 1635
		[Token(Token = "0x4000663")]
		[FieldOffset(Offset = "0x31")]
		public bool isMinor;

		// Token: 0x04000664 RID: 1636
		[Token(Token = "0x4000664")]
		[FieldOffset(Offset = "0x32")]
		public bool needAuthenticate;

		// Token: 0x04000665 RID: 1637
		[Token(Token = "0x4000665")]
		[FieldOffset(Offset = "0x38")]
		public long issuedAt;

		// Token: 0x04000666 RID: 1638
		[Token(Token = "0x4000666")]
		[FieldOffset(Offset = "0x40")]
		public long expiresIn;

		// Token: 0x04000667 RID: 1639
		[Token(Token = "0x4000667")]
		[FieldOffset(Offset = "0x48")]
		public bool isLatestUserAgreement;

		// Token: 0x04000668 RID: 1640
		[Token(Token = "0x4000668")]
		[FieldOffset(Offset = "0x50")]
		public JObject captcha;
	}
}
