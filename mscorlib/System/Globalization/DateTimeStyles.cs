using System;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x02000566 RID: 1382
	[Token(Token = "0x2000566")]
	[System.Flags]
	public enum DateTimeStyles
	{
		// Token: 0x04001741 RID: 5953
		[Token(Token = "0x4001741")]
		None = 0,
		// Token: 0x04001742 RID: 5954
		[Token(Token = "0x4001742")]
		AllowLeadingWhite = 1,
		// Token: 0x04001743 RID: 5955
		[Token(Token = "0x4001743")]
		AllowTrailingWhite = 2,
		// Token: 0x04001744 RID: 5956
		[Token(Token = "0x4001744")]
		AllowInnerWhite = 4,
		// Token: 0x04001745 RID: 5957
		[Token(Token = "0x4001745")]
		AllowWhiteSpaces = 7,
		// Token: 0x04001746 RID: 5958
		[Token(Token = "0x4001746")]
		NoCurrentDateDefault = 8,
		// Token: 0x04001747 RID: 5959
		[Token(Token = "0x4001747")]
		AdjustToUniversal = 16,
		// Token: 0x04001748 RID: 5960
		[Token(Token = "0x4001748")]
		AssumeLocal = 32,
		// Token: 0x04001749 RID: 5961
		[Token(Token = "0x4001749")]
		AssumeUniversal = 64,
		// Token: 0x0400174A RID: 5962
		[Token(Token = "0x400174A")]
		RoundtripKind = 128
	}
}
