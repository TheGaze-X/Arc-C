using System;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x0200056F RID: 1391
	[Token(Token = "0x200056F")]
	[System.Flags]
	public enum NumberStyles
	{
		// Token: 0x0400177E RID: 6014
		[Token(Token = "0x400177E")]
		None = 0,
		// Token: 0x0400177F RID: 6015
		[Token(Token = "0x400177F")]
		AllowLeadingWhite = 1,
		// Token: 0x04001780 RID: 6016
		[Token(Token = "0x4001780")]
		AllowTrailingWhite = 2,
		// Token: 0x04001781 RID: 6017
		[Token(Token = "0x4001781")]
		AllowLeadingSign = 4,
		// Token: 0x04001782 RID: 6018
		[Token(Token = "0x4001782")]
		AllowTrailingSign = 8,
		// Token: 0x04001783 RID: 6019
		[Token(Token = "0x4001783")]
		AllowParentheses = 16,
		// Token: 0x04001784 RID: 6020
		[Token(Token = "0x4001784")]
		AllowDecimalPoint = 32,
		// Token: 0x04001785 RID: 6021
		[Token(Token = "0x4001785")]
		AllowThousands = 64,
		// Token: 0x04001786 RID: 6022
		[Token(Token = "0x4001786")]
		AllowExponent = 128,
		// Token: 0x04001787 RID: 6023
		[Token(Token = "0x4001787")]
		AllowCurrencySymbol = 256,
		// Token: 0x04001788 RID: 6024
		[Token(Token = "0x4001788")]
		AllowHexSpecifier = 512,
		// Token: 0x04001789 RID: 6025
		[Token(Token = "0x4001789")]
		Integer = 7,
		// Token: 0x0400178A RID: 6026
		[Token(Token = "0x400178A")]
		HexNumber = 515,
		// Token: 0x0400178B RID: 6027
		[Token(Token = "0x400178B")]
		Number = 111,
		// Token: 0x0400178C RID: 6028
		[Token(Token = "0x400178C")]
		Float = 167,
		// Token: 0x0400178D RID: 6029
		[Token(Token = "0x400178D")]
		Currency = 383,
		// Token: 0x0400178E RID: 6030
		[Token(Token = "0x400178E")]
		Any = 511
	}
}
