using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x0200015E RID: 350
	[Token(Token = "0x200015E")]
	public class VerifyCloudAuthRequest
	{
		// Token: 0x06000520 RID: 1312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VerifyCloudAuthRequest()
		{
		}

		// Token: 0x040006AC RID: 1708
		[Token(Token = "0x40006AC")]
		[FieldOffset(Offset = "0x10")]
		public string token;

		// Token: 0x040006AD RID: 1709
		[Token(Token = "0x40006AD")]
		[FieldOffset(Offset = "0x18")]
		public string bizId;
	}
}
