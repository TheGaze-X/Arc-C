using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000128 RID: 296
	[Token(Token = "0x2000128")]
	internal enum AsnDecodeStatus
	{
		// Token: 0x04000525 RID: 1317
		[Token(Token = "0x4000525")]
		NotDecoded = -1,
		// Token: 0x04000526 RID: 1318
		[Token(Token = "0x4000526")]
		Ok,
		// Token: 0x04000527 RID: 1319
		[Token(Token = "0x4000527")]
		BadAsn,
		// Token: 0x04000528 RID: 1320
		[Token(Token = "0x4000528")]
		BadTag,
		// Token: 0x04000529 RID: 1321
		[Token(Token = "0x4000529")]
		BadLength,
		// Token: 0x0400052A RID: 1322
		[Token(Token = "0x400052A")]
		InformationNotAvailable
	}
}
