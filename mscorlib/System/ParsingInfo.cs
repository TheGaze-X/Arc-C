using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000E6 RID: 230
	[Token(Token = "0x20000E6")]
	internal struct ParsingInfo
	{
		// Token: 0x060007B6 RID: 1974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x4CD5300", Offset = "0x4CD3F00", VA = "0x184CD5300")]
		internal void Init()
		{
		}

		// Token: 0x040003D3 RID: 979
		[Token(Token = "0x40003D3")]
		[FieldOffset(Offset = "0x0")]
		internal System.Globalization.Calendar calendar;

		// Token: 0x040003D4 RID: 980
		[Token(Token = "0x40003D4")]
		[FieldOffset(Offset = "0x8")]
		internal int dayOfWeek;

		// Token: 0x040003D5 RID: 981
		[Token(Token = "0x40003D5")]
		[FieldOffset(Offset = "0xC")]
		internal DateTimeParse.TM timeMark;

		// Token: 0x040003D6 RID: 982
		[Token(Token = "0x40003D6")]
		[FieldOffset(Offset = "0x10")]
		internal bool fUseHour12;

		// Token: 0x040003D7 RID: 983
		[Token(Token = "0x40003D7")]
		[FieldOffset(Offset = "0x11")]
		internal bool fUseTwoDigitYear;

		// Token: 0x040003D8 RID: 984
		[Token(Token = "0x40003D8")]
		[FieldOffset(Offset = "0x12")]
		internal bool fAllowInnerWhite;

		// Token: 0x040003D9 RID: 985
		[Token(Token = "0x40003D9")]
		[FieldOffset(Offset = "0x13")]
		internal bool fAllowTrailingWhite;

		// Token: 0x040003DA RID: 986
		[Token(Token = "0x40003DA")]
		[FieldOffset(Offset = "0x14")]
		internal bool fCustomNumberParser;

		// Token: 0x040003DB RID: 987
		[Token(Token = "0x40003DB")]
		[FieldOffset(Offset = "0x18")]
		internal DateTimeParse.MatchNumberDelegate parseNumberDelegate;
	}
}
