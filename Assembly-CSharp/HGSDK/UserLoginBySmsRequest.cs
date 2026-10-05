using System;
using Il2CppDummyDll;
using Torappu;

namespace HGSDK
{
	// Token: 0x02000142 RID: 322
	[Token(Token = "0x2000142")]
	public class UserLoginBySmsRequest
	{
		// Token: 0x060004FF RID: 1279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UserLoginBySmsRequest()
		{
		}

		// Token: 0x04000659 RID: 1625
		[Token(Token = "0x4000659")]
		[FieldOffset(Offset = "0x10")]
		public string account;

		// Token: 0x0400065A RID: 1626
		[Token(Token = "0x400065A")]
		[FieldOffset(Offset = "0x18")]
		public string smsCode;

		// Token: 0x0400065B RID: 1627
		[Token(Token = "0x400065B")]
		[FieldOffset(Offset = "0x20")]
		public string deviceId;

		// Token: 0x0400065C RID: 1628
		[Token(Token = "0x400065C")]
		[FieldOffset(Offset = "0x28")]
		public PlatformKey platform;

		// Token: 0x0400065D RID: 1629
		[Token(Token = "0x400065D")]
		[FieldOffset(Offset = "0x30")]
		public string captcha;
	}
}
