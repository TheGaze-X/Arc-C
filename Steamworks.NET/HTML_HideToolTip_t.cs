using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	[CallbackIdentity(4526)]
	public struct HTML_HideToolTip_t
	{
		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		public const int k_iCallback = 4526;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;
	}
}
