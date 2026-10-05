using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	[CallbackIdentity(4507)]
	public struct HTML_OpenLinkInNewTab_t
	{
		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		public const int k_iCallback = 4507;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x8")]
		public string pchURL;
	}
}
