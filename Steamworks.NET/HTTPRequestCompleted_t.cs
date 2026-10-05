using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	[CallbackIdentity(2101)]
	public struct HTTPRequestCompleted_t
	{
		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		public const int k_iCallback = 2101;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x0")]
		public HTTPRequestHandle m_hRequest;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulContextValue;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x10")]
		public bool m_bRequestSuccessful;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x14")]
		public EHTTPStatusCode m_eStatusCode;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x18")]
		public uint m_unBodySize;
	}
}
