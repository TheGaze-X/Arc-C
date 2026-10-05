using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace HGSDK
{
	// Token: 0x02000141 RID: 321
	[Token(Token = "0x2000141")]
	public class UserRegisterResponse
	{
		// Token: 0x060004FE RID: 1278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x103FF30", Offset = "0x103EB30", VA = "0x18103FF30")]
		public UserRegisterResponse()
		{
		}

		// Token: 0x0400064F RID: 1615
		[Token(Token = "0x400064F")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x04000650 RID: 1616
		[Token(Token = "0x4000650")]
		[FieldOffset(Offset = "0x18")]
		public string uid;

		// Token: 0x04000651 RID: 1617
		[Token(Token = "0x4000651")]
		[FieldOffset(Offset = "0x20")]
		public int role;

		// Token: 0x04000652 RID: 1618
		[Token(Token = "0x4000652")]
		[FieldOffset(Offset = "0x28")]
		public string token;

		// Token: 0x04000653 RID: 1619
		[Token(Token = "0x4000653")]
		[FieldOffset(Offset = "0x30")]
		public long issuedAt;

		// Token: 0x04000654 RID: 1620
		[Token(Token = "0x4000654")]
		[FieldOffset(Offset = "0x38")]
		public long expiresIn;

		// Token: 0x04000655 RID: 1621
		[Token(Token = "0x4000655")]
		[FieldOffset(Offset = "0x40")]
		public string errMsg;

		// Token: 0x04000656 RID: 1622
		[Token(Token = "0x4000656")]
		[FieldOffset(Offset = "0x48")]
		public bool needAuthenticate;

		// Token: 0x04000657 RID: 1623
		[Token(Token = "0x4000657")]
		[FieldOffset(Offset = "0x49")]
		public bool isLatestUserAgreement;

		// Token: 0x04000658 RID: 1624
		[Token(Token = "0x4000658")]
		[FieldOffset(Offset = "0x50")]
		public JObject captcha;
	}
}
