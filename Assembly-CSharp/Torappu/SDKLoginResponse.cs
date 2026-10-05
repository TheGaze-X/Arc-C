using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200060C RID: 1548
	[Token(Token = "0x200060C")]
	public class SDKLoginResponse
	{
		// Token: 0x06006233 RID: 25139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006233")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SDKLoginResponse()
		{
		}

		// Token: 0x04002D8F RID: 11663
		[Token(Token = "0x4002D8F")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x04002D90 RID: 11664
		[Token(Token = "0x4002D90")]
		[FieldOffset(Offset = "0x18")]
		public string uid;

		// Token: 0x04002D91 RID: 11665
		[Token(Token = "0x4002D91")]
		[FieldOffset(Offset = "0x20")]
		public int role;

		// Token: 0x04002D92 RID: 11666
		[Token(Token = "0x4002D92")]
		[FieldOffset(Offset = "0x28")]
		public string token;

		// Token: 0x04002D93 RID: 11667
		[Token(Token = "0x4002D93")]
		[FieldOffset(Offset = "0x30")]
		public DateTime issuedAt;

		// Token: 0x04002D94 RID: 11668
		[Token(Token = "0x4002D94")]
		[FieldOffset(Offset = "0x38")]
		public DateTime expiresIn;
	}
}
