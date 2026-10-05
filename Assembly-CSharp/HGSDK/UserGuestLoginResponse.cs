using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace HGSDK
{
	// Token: 0x0200013D RID: 317
	[Token(Token = "0x200013D")]
	public class UserGuestLoginResponse
	{
		// Token: 0x060004FA RID: 1274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x10344C0", Offset = "0x10330C0", VA = "0x1810344C0")]
		public UserGuestLoginResponse()
		{
		}

		// Token: 0x0400063C RID: 1596
		[Token(Token = "0x400063C")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x0400063D RID: 1597
		[Token(Token = "0x400063D")]
		[FieldOffset(Offset = "0x18")]
		public string message;

		// Token: 0x0400063E RID: 1598
		[Token(Token = "0x400063E")]
		[FieldOffset(Offset = "0x20")]
		public string uid;

		// Token: 0x0400063F RID: 1599
		[Token(Token = "0x400063F")]
		[FieldOffset(Offset = "0x28")]
		public int role;

		// Token: 0x04000640 RID: 1600
		[Token(Token = "0x4000640")]
		[FieldOffset(Offset = "0x30")]
		public string token;

		// Token: 0x04000641 RID: 1601
		[Token(Token = "0x4000641")]
		[FieldOffset(Offset = "0x38")]
		public long issueAt;

		// Token: 0x04000642 RID: 1602
		[Token(Token = "0x4000642")]
		[FieldOffset(Offset = "0x40")]
		public long expiresIn;

		// Token: 0x04000643 RID: 1603
		[Token(Token = "0x4000643")]
		[FieldOffset(Offset = "0x48")]
		public bool isLatestUserAgreement;

		// Token: 0x04000644 RID: 1604
		[Token(Token = "0x4000644")]
		[FieldOffset(Offset = "0x50")]
		public string captchaTips;

		// Token: 0x04000645 RID: 1605
		[Token(Token = "0x4000645")]
		[FieldOffset(Offset = "0x58")]
		public JObject captcha;
	}
}
