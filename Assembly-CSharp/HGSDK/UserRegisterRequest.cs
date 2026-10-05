using System;
using Il2CppDummyDll;
using Torappu;

namespace HGSDK
{
	// Token: 0x02000140 RID: 320
	[Token(Token = "0x2000140")]
	public class UserRegisterRequest
	{
		// Token: 0x060004FD RID: 1277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UserRegisterRequest()
		{
		}

		// Token: 0x04000649 RID: 1609
		[Token(Token = "0x4000649")]
		[FieldOffset(Offset = "0x10")]
		public string account;

		// Token: 0x0400064A RID: 1610
		[Token(Token = "0x400064A")]
		[FieldOffset(Offset = "0x18")]
		public string password;

		// Token: 0x0400064B RID: 1611
		[Token(Token = "0x400064B")]
		[FieldOffset(Offset = "0x20")]
		public string smsCode;

		// Token: 0x0400064C RID: 1612
		[Token(Token = "0x400064C")]
		[FieldOffset(Offset = "0x28")]
		public PlatformKey platform;

		// Token: 0x0400064D RID: 1613
		[Token(Token = "0x400064D")]
		[FieldOffset(Offset = "0x30")]
		public string deviceId;

		// Token: 0x0400064E RID: 1614
		[Token(Token = "0x400064E")]
		[FieldOffset(Offset = "0x38")]
		public string captcha;
	}
}
