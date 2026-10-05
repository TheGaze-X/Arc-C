using System;
using Il2CppDummyDll;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000F6 RID: 246
	[Token(Token = "0x20000F6")]
	[Flags]
	public enum RegexOptions
	{
		// Token: 0x04000409 RID: 1033
		[Token(Token = "0x4000409")]
		None = 0,
		// Token: 0x0400040A RID: 1034
		[Token(Token = "0x400040A")]
		IgnoreCase = 1,
		// Token: 0x0400040B RID: 1035
		[Token(Token = "0x400040B")]
		Multiline = 2,
		// Token: 0x0400040C RID: 1036
		[Token(Token = "0x400040C")]
		ExplicitCapture = 4,
		// Token: 0x0400040D RID: 1037
		[Token(Token = "0x400040D")]
		Compiled = 8,
		// Token: 0x0400040E RID: 1038
		[Token(Token = "0x400040E")]
		Singleline = 16,
		// Token: 0x0400040F RID: 1039
		[Token(Token = "0x400040F")]
		IgnorePatternWhitespace = 32,
		// Token: 0x04000410 RID: 1040
		[Token(Token = "0x4000410")]
		RightToLeft = 64,
		// Token: 0x04000411 RID: 1041
		[Token(Token = "0x4000411")]
		ECMAScript = 256,
		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000412")]
		CultureInvariant = 512
	}
}
