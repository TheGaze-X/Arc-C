using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	[CallbackIdentity(4504)]
	public struct HTML_CloseBrowser_t
	{
		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		public const int k_iCallback = 4504;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;
	}
}
