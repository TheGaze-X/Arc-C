using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200060B RID: 1547
	[Token(Token = "0x200060B")]
	public class SDKLoginRequest
	{
		// Token: 0x06006232 RID: 25138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006232")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SDKLoginRequest()
		{
		}

		// Token: 0x04002D8A RID: 11658
		[Token(Token = "0x4002D8A")]
		[FieldOffset(Offset = "0x10")]
		public string account;

		// Token: 0x04002D8B RID: 11659
		[Token(Token = "0x4002D8B")]
		[FieldOffset(Offset = "0x18")]
		public string password;

		// Token: 0x04002D8C RID: 11660
		[Token(Token = "0x4002D8C")]
		[FieldOffset(Offset = "0x20")]
		public string deviceId;

		// Token: 0x04002D8D RID: 11661
		[Token(Token = "0x4002D8D")]
		[FieldOffset(Offset = "0x28")]
		public PlatformKey platform;

		// Token: 0x04002D8E RID: 11662
		[Token(Token = "0x4002D8E")]
		[FieldOffset(Offset = "0x2C")]
		public SDKType sdk;
	}
}
