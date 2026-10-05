using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Hypergryph.SDK
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public struct UrlParams
	{
		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x0")]
		public Dictionary<string, string> query;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x8")]
		public string fragment;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, string> param;
	}
}
