using System;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x0200056A RID: 1386
	[Token(Token = "0x200056A")]
	internal enum HebrewNumberParsingState
	{
		// Token: 0x04001754 RID: 5972
		[Token(Token = "0x4001754")]
		InvalidHebrewNumber,
		// Token: 0x04001755 RID: 5973
		[Token(Token = "0x4001755")]
		NotHebrewDigit,
		// Token: 0x04001756 RID: 5974
		[Token(Token = "0x4001756")]
		FoundEndOfHebrewNumber,
		// Token: 0x04001757 RID: 5975
		[Token(Token = "0x4001757")]
		ContinueParsing
	}
}
