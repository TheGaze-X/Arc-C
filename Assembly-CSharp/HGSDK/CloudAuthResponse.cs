using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x0200015D RID: 349
	[Token(Token = "0x200015D")]
	public class CloudAuthResponse
	{
		// Token: 0x0600051F RID: 1311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CloudAuthResponse()
		{
		}

		// Token: 0x040006A8 RID: 1704
		[Token(Token = "0x40006A8")]
		public const int STATUS_NEED_AUTH = 100;

		// Token: 0x040006A9 RID: 1705
		[Token(Token = "0x40006A9")]
		public const int STATUS_TOO_OFTEN = 102;

		// Token: 0x040006AA RID: 1706
		[Token(Token = "0x40006AA")]
		[FieldOffset(Offset = "0x10")]
		public string token;

		// Token: 0x040006AB RID: 1707
		[Token(Token = "0x40006AB")]
		[FieldOffset(Offset = "0x18")]
		public string bizId;
	}
}
