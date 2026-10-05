using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x0200015F RID: 351
	[Token(Token = "0x200015F")]
	public class VerifyCloudAuthResponse
	{
		// Token: 0x06000521 RID: 1313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VerifyCloudAuthResponse()
		{
		}

		// Token: 0x040006AE RID: 1710
		[Token(Token = "0x40006AE")]
		public const int STATUS_AUTH_FAIL = 101;

		// Token: 0x040006AF RID: 1711
		[Token(Token = "0x40006AF")]
		[FieldOffset(Offset = "0x10")]
		public int verifyStatus;
	}
}
