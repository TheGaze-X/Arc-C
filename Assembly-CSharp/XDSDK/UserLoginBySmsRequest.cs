using System;
using Il2CppDummyDll;
using Torappu;

namespace XDSDK
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	public class UserLoginBySmsRequest
	{
		// Token: 0x060003AA RID: 938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UserLoginBySmsRequest()
		{
		}

		// Token: 0x04000476 RID: 1142
		[Token(Token = "0x4000476")]
		[FieldOffset(Offset = "0x10")]
		public string account;

		// Token: 0x04000477 RID: 1143
		[Token(Token = "0x4000477")]
		[FieldOffset(Offset = "0x18")]
		public string smsCode;

		// Token: 0x04000478 RID: 1144
		[Token(Token = "0x4000478")]
		[FieldOffset(Offset = "0x20")]
		public string deviceId;

		// Token: 0x04000479 RID: 1145
		[Token(Token = "0x4000479")]
		[FieldOffset(Offset = "0x28")]
		public PlatformKey platform;
	}
}
