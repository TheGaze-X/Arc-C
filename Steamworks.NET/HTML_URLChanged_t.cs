using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	[CallbackIdentity(4505)]
	public struct HTML_URLChanged_t
	{
		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		public const int k_iCallback = 4505;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x8")]
		public string pchURL;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x10")]
		public string pchPostData;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x18")]
		public bool bIsRedirect;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x20")]
		public string pchPageTitle;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x28")]
		public bool bNewNavigation;
	}
}
