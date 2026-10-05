using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	[CallbackIdentity(4501)]
	public struct HTML_BrowserReady_t
	{
		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		public const int k_iCallback = 4501;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;
	}
}
