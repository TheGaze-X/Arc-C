using System;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x020002C0 RID: 704
	[Token(Token = "0x20002C0")]
	[Flags]
	public enum HotfixFlag
	{
		// Token: 0x04000CFE RID: 3326
		[Token(Token = "0x4000CFE")]
		Stateless = 0,
		// Token: 0x04000CFF RID: 3327
		[Token(Token = "0x4000CFF")]
		[Obsolete("use xlua.util.state instead!", true)]
		Stateful = 1,
		// Token: 0x04000D00 RID: 3328
		[Token(Token = "0x4000D00")]
		ValueTypeBoxing = 2,
		// Token: 0x04000D01 RID: 3329
		[Token(Token = "0x4000D01")]
		IgnoreProperty = 4,
		// Token: 0x04000D02 RID: 3330
		[Token(Token = "0x4000D02")]
		IgnoreNotPublic = 8,
		// Token: 0x04000D03 RID: 3331
		[Token(Token = "0x4000D03")]
		Inline = 16,
		// Token: 0x04000D04 RID: 3332
		[Token(Token = "0x4000D04")]
		IntKey = 32,
		// Token: 0x04000D05 RID: 3333
		[Token(Token = "0x4000D05")]
		AdaptByDelegate = 64,
		// Token: 0x04000D06 RID: 3334
		[Token(Token = "0x4000D06")]
		IgnoreCompilerGenerated = 128,
		// Token: 0x04000D07 RID: 3335
		[Token(Token = "0x4000D07")]
		NoBaseProxy = 256
	}
}
