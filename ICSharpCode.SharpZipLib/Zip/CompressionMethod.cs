using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	public enum CompressionMethod
	{
		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		Stored,
		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		Deflated = 8,
		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		Deflate64,
		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		BZip2 = 11,
		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		WinZipAES = 99
	}
}
