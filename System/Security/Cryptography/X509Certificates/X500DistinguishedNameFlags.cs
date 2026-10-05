using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200012D RID: 301
	[Token(Token = "0x200012D")]
	[Flags]
	public enum X500DistinguishedNameFlags
	{
		// Token: 0x04000540 RID: 1344
		[Token(Token = "0x4000540")]
		None = 0,
		// Token: 0x04000541 RID: 1345
		[Token(Token = "0x4000541")]
		Reversed = 1,
		// Token: 0x04000542 RID: 1346
		[Token(Token = "0x4000542")]
		UseSemicolons = 16,
		// Token: 0x04000543 RID: 1347
		[Token(Token = "0x4000543")]
		DoNotUsePlusSign = 32,
		// Token: 0x04000544 RID: 1348
		[Token(Token = "0x4000544")]
		DoNotUseQuotes = 64,
		// Token: 0x04000545 RID: 1349
		[Token(Token = "0x4000545")]
		UseCommas = 128,
		// Token: 0x04000546 RID: 1350
		[Token(Token = "0x4000546")]
		UseNewLines = 256,
		// Token: 0x04000547 RID: 1351
		[Token(Token = "0x4000547")]
		UseUTF8Encoding = 4096,
		// Token: 0x04000548 RID: 1352
		[Token(Token = "0x4000548")]
		UseT61Encoding = 8192,
		// Token: 0x04000549 RID: 1353
		[Token(Token = "0x4000549")]
		ForceUTF8Encoding = 16384
	}
}
