using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000B7 RID: 183
	[Token(Token = "0x20000B7")]
	[Flags]
	public enum GenericUriParserOptions
	{
		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		Default = 0,
		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		GenericAuthority = 1,
		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		AllowEmptyAuthority = 2,
		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		NoUserInfo = 4,
		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		NoPort = 8,
		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		NoQuery = 16,
		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		NoFragment = 32,
		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		DontConvertPathBackslashes = 64,
		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		DontCompressPath = 128,
		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		DontUnescapePathDotsAndSlashes = 256,
		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		Idn = 512,
		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		IriParsing = 1024
	}
}
