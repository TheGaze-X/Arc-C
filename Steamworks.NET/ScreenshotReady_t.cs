using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000C4 RID: 196
	[Token(Token = "0x20000C4")]
	[CallbackIdentity(2301)]
	public struct ScreenshotReady_t
	{
		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		public const int k_iCallback = 2301;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x0")]
		public ScreenshotHandle m_hLocal;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x4")]
		public EResult m_eResult;
	}
}
