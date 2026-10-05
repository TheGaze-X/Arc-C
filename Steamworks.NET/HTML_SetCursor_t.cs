using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	[CallbackIdentity(4522)]
	public struct HTML_SetCursor_t
	{
		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		public const int k_iCallback = 4522;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x4")]
		public uint eMouseCursor;
	}
}
