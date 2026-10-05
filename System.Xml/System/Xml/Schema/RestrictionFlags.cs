using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000DA RID: 218
	[Token(Token = "0x20000DA")]
	[Flags]
	internal enum RestrictionFlags
	{
		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4000453")]
		Length = 1,
		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000454")]
		MinLength = 2,
		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4000455")]
		MaxLength = 4,
		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000456")]
		Pattern = 8,
		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4000457")]
		Enumeration = 16,
		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		WhiteSpace = 32,
		// Token: 0x04000459 RID: 1113
		[Token(Token = "0x4000459")]
		MaxInclusive = 64,
		// Token: 0x0400045A RID: 1114
		[Token(Token = "0x400045A")]
		MaxExclusive = 128,
		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x400045B")]
		MinInclusive = 256,
		// Token: 0x0400045C RID: 1116
		[Token(Token = "0x400045C")]
		MinExclusive = 512,
		// Token: 0x0400045D RID: 1117
		[Token(Token = "0x400045D")]
		TotalDigits = 1024,
		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x400045E")]
		FractionDigits = 2048
	}
}
