using System;
using Il2CppDummyDll;
using Torappu;

namespace XDSDK
{
	// Token: 0x020000DE RID: 222
	[Token(Token = "0x20000DE")]
	public class UserRegisterRequest
	{
		// Token: 0x060003A8 RID: 936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UserRegisterRequest()
		{
		}

		// Token: 0x0400046A RID: 1130
		[Token(Token = "0x400046A")]
		[FieldOffset(Offset = "0x10")]
		public string account;

		// Token: 0x0400046B RID: 1131
		[Token(Token = "0x400046B")]
		[FieldOffset(Offset = "0x18")]
		public string password;

		// Token: 0x0400046C RID: 1132
		[Token(Token = "0x400046C")]
		[FieldOffset(Offset = "0x20")]
		public string smsCode;

		// Token: 0x0400046D RID: 1133
		[Token(Token = "0x400046D")]
		[FieldOffset(Offset = "0x28")]
		public PlatformKey platform;

		// Token: 0x0400046E RID: 1134
		[Token(Token = "0x400046E")]
		[FieldOffset(Offset = "0x30")]
		public string deviceId;
	}
}
