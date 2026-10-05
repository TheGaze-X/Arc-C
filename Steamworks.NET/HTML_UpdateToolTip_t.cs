using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	[CallbackIdentity(4525)]
	public struct HTML_UpdateToolTip_t
	{
		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		public const int k_iCallback = 4525;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x8")]
		public string pchMsg;
	}
}
