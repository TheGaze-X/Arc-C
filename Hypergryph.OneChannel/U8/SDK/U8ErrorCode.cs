using System;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	public static class U8ErrorCode
	{
		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		public const int DESERIALIZE_ERROR_CODE = 10001;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		public const int CAPTCHA_ERROR_BASE = 11000;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		public const int AUTH_PARSE_DATA_FAILED = 1001;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		public const int VERIFY_ACCOUNT_UID_EMPTY = 3001;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		public const int AUTHV2_SESSION_EMPTY = 4001;
	}
}
