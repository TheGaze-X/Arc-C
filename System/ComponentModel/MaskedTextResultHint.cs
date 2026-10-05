using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001CD RID: 461
	[Token(Token = "0x20001CD")]
	public enum MaskedTextResultHint
	{
		// Token: 0x04000712 RID: 1810
		[Token(Token = "0x4000712")]
		Unknown,
		// Token: 0x04000713 RID: 1811
		[Token(Token = "0x4000713")]
		CharacterEscaped,
		// Token: 0x04000714 RID: 1812
		[Token(Token = "0x4000714")]
		NoEffect,
		// Token: 0x04000715 RID: 1813
		[Token(Token = "0x4000715")]
		SideEffect,
		// Token: 0x04000716 RID: 1814
		[Token(Token = "0x4000716")]
		Success,
		// Token: 0x04000717 RID: 1815
		[Token(Token = "0x4000717")]
		AsciiCharacterExpected = -1,
		// Token: 0x04000718 RID: 1816
		[Token(Token = "0x4000718")]
		AlphanumericCharacterExpected = -2,
		// Token: 0x04000719 RID: 1817
		[Token(Token = "0x4000719")]
		DigitExpected = -3,
		// Token: 0x0400071A RID: 1818
		[Token(Token = "0x400071A")]
		LetterExpected = -4,
		// Token: 0x0400071B RID: 1819
		[Token(Token = "0x400071B")]
		SignedDigitExpected = -5,
		// Token: 0x0400071C RID: 1820
		[Token(Token = "0x400071C")]
		InvalidInput = -51,
		// Token: 0x0400071D RID: 1821
		[Token(Token = "0x400071D")]
		PromptCharNotAllowed = -52,
		// Token: 0x0400071E RID: 1822
		[Token(Token = "0x400071E")]
		UnavailableEditPosition = -53,
		// Token: 0x0400071F RID: 1823
		[Token(Token = "0x400071F")]
		NonEditPosition = -54,
		// Token: 0x04000720 RID: 1824
		[Token(Token = "0x4000720")]
		PositionOutOfRange = -55
	}
}
