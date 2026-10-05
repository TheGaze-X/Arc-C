using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	[CallbackIdentity(4523)]
	public struct HTML_StatusText_t
	{
		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		public const int k_iCallback = 4523;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x8")]
		public string pchMsg;
	}
}
