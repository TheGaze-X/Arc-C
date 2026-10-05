using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	[CallbackIdentity(4509)]
	public struct HTML_SearchResults_t
	{
		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		public const int k_iCallback = 4509;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x4")]
		public uint unResults;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x8")]
		public uint unCurrentMatch;
	}
}
