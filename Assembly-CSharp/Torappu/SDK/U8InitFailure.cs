using System;
using Il2CppDummyDll;

namespace Torappu.SDK
{
	// Token: 0x02001508 RID: 5384
	[Token(Token = "0x2001508")]
	public class U8InitFailure
	{
		// Token: 0x06007BB7 RID: 31671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BB7")]
		[Address(RVA = "0x274F5B0", Offset = "0x274E1B0", VA = "0x18274F5B0")]
		public static U8InitFailure Create(string rejectInfo)
		{
			return null;
		}

		// Token: 0x06007BB8 RID: 31672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BB8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public U8InitFailure()
		{
		}

		// Token: 0x04007A3B RID: 31291
		[Token(Token = "0x4007A3B")]
		public const int ERROR_UNKNOWN = 10000;

		// Token: 0x04007A3C RID: 31292
		[Token(Token = "0x4007A3C")]
		public const int ERROR_INVALID_INFO = 10001;

		// Token: 0x04007A3D RID: 31293
		[Token(Token = "0x4007A3D")]
		public const int ERROR_NETWORK_FAIL = -1000;

		// Token: 0x04007A3E RID: 31294
		[Token(Token = "0x4007A3E")]
		public const int ERROR_CONCURRENT_CALL = -1001;

		// Token: 0x04007A3F RID: 31295
		[Token(Token = "0x4007A3F")]
		public const int ERROR_NEED_EXIT = -1002;

		// Token: 0x04007A40 RID: 31296
		[Token(Token = "0x4007A40")]
		[FieldOffset(Offset = "0x10")]
		public int errorCode;

		// Token: 0x04007A41 RID: 31297
		[Token(Token = "0x4007A41")]
		[FieldOffset(Offset = "0x18")]
		public string errorMsg;
	}
}
