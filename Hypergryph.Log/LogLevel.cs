using System;
using Il2CppDummyDll;

namespace Hypergryph.Log
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[Flags]
	public enum LogLevel
	{
		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		Info = 1,
		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		Warning = 2,
		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		Error = 4,
		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		Exception = 8,
		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		All = 15
	}
}
