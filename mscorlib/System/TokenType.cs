using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000E7 RID: 231
	[Token(Token = "0x20000E7")]
	internal enum TokenType
	{
		// Token: 0x040003DD RID: 989
		[Token(Token = "0x40003DD")]
		NumberToken = 1,
		// Token: 0x040003DE RID: 990
		[Token(Token = "0x40003DE")]
		YearNumberToken,
		// Token: 0x040003DF RID: 991
		[Token(Token = "0x40003DF")]
		Am,
		// Token: 0x040003E0 RID: 992
		[Token(Token = "0x40003E0")]
		Pm,
		// Token: 0x040003E1 RID: 993
		[Token(Token = "0x40003E1")]
		MonthToken,
		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		EndOfString,
		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		DayOfWeekToken,
		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		TimeZoneToken,
		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		EraToken,
		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		DateWordToken,
		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		UnknownToken,
		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		HebrewNumber,
		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		JapaneseEraToken,
		// Token: 0x040003EA RID: 1002
		[Token(Token = "0x40003EA")]
		TEraToken,
		// Token: 0x040003EB RID: 1003
		[Token(Token = "0x40003EB")]
		IgnorableSymbol,
		// Token: 0x040003EC RID: 1004
		[Token(Token = "0x40003EC")]
		SEP_Unk = 256,
		// Token: 0x040003ED RID: 1005
		[Token(Token = "0x40003ED")]
		SEP_End = 512,
		// Token: 0x040003EE RID: 1006
		[Token(Token = "0x40003EE")]
		SEP_Space = 768,
		// Token: 0x040003EF RID: 1007
		[Token(Token = "0x40003EF")]
		SEP_Am = 1024,
		// Token: 0x040003F0 RID: 1008
		[Token(Token = "0x40003F0")]
		SEP_Pm = 1280,
		// Token: 0x040003F1 RID: 1009
		[Token(Token = "0x40003F1")]
		SEP_Date = 1536,
		// Token: 0x040003F2 RID: 1010
		[Token(Token = "0x40003F2")]
		SEP_Time = 1792,
		// Token: 0x040003F3 RID: 1011
		[Token(Token = "0x40003F3")]
		SEP_YearSuff = 2048,
		// Token: 0x040003F4 RID: 1012
		[Token(Token = "0x40003F4")]
		SEP_MonthSuff = 2304,
		// Token: 0x040003F5 RID: 1013
		[Token(Token = "0x40003F5")]
		SEP_DaySuff = 2560,
		// Token: 0x040003F6 RID: 1014
		[Token(Token = "0x40003F6")]
		SEP_HourSuff = 2816,
		// Token: 0x040003F7 RID: 1015
		[Token(Token = "0x40003F7")]
		SEP_MinuteSuff = 3072,
		// Token: 0x040003F8 RID: 1016
		[Token(Token = "0x40003F8")]
		SEP_SecondSuff = 3328,
		// Token: 0x040003F9 RID: 1017
		[Token(Token = "0x40003F9")]
		SEP_LocalTimeMark = 3584,
		// Token: 0x040003FA RID: 1018
		[Token(Token = "0x40003FA")]
		SEP_DateOrOffset = 3840,
		// Token: 0x040003FB RID: 1019
		[Token(Token = "0x40003FB")]
		RegularTokenMask = 255,
		// Token: 0x040003FC RID: 1020
		[Token(Token = "0x40003FC")]
		SeparatorTokenMask = 65280
	}
}
