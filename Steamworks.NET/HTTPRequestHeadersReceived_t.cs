using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	[CallbackIdentity(2102)]
	public struct HTTPRequestHeadersReceived_t
	{
		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		public const int k_iCallback = 2102;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x0")]
		public HTTPRequestHandle m_hRequest;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulContextValue;
	}
}
