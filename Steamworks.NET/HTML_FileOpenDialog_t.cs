using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	[CallbackIdentity(4516)]
	public struct HTML_FileOpenDialog_t
	{
		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		public const int k_iCallback = 4516;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x8")]
		public string pchTitle;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x10")]
		public string pchInitialFile;
	}
}
