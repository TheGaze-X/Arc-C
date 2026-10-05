using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	[CallbackIdentity(4515)]
	public struct HTML_JSConfirm_t
	{
		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		public const int k_iCallback = 4515;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x8")]
		public string pchMessage;
	}
}
