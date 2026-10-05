using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	[CallbackIdentity(4527)]
	public struct HTML_BrowserRestarted_t
	{
		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		public const int k_iCallback = 4527;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x4")]
		public HHTMLBrowser unOldBrowserHandle;
	}
}
