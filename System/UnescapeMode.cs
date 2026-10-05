using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x20000C5")]
	[Flags]
	internal enum UnescapeMode
	{
		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		CopyOnly = 0,
		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		Escape = 1,
		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		Unescape = 2,
		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		EscapeUnescape = 3,
		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		V1ToStringFlag = 4,
		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		UnescapeAll = 8,
		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		UnescapeAllOrThrow = 24
	}
}
