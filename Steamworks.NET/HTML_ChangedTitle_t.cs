using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	[CallbackIdentity(4508)]
	public struct HTML_ChangedTitle_t
	{
		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		public const int k_iCallback = 4508;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x8")]
		public string pchTitle;
	}
}
