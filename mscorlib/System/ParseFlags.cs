using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000E4 RID: 228
	[Token(Token = "0x20000E4")]
	[System.Flags]
	internal enum ParseFlags
	{
		// Token: 0x040003B2 RID: 946
		[Token(Token = "0x40003B2")]
		HaveYear = 1,
		// Token: 0x040003B3 RID: 947
		[Token(Token = "0x40003B3")]
		HaveMonth = 2,
		// Token: 0x040003B4 RID: 948
		[Token(Token = "0x40003B4")]
		HaveDay = 4,
		// Token: 0x040003B5 RID: 949
		[Token(Token = "0x40003B5")]
		HaveHour = 8,
		// Token: 0x040003B6 RID: 950
		[Token(Token = "0x40003B6")]
		HaveMinute = 16,
		// Token: 0x040003B7 RID: 951
		[Token(Token = "0x40003B7")]
		HaveSecond = 32,
		// Token: 0x040003B8 RID: 952
		[Token(Token = "0x40003B8")]
		HaveTime = 64,
		// Token: 0x040003B9 RID: 953
		[Token(Token = "0x40003B9")]
		HaveDate = 128,
		// Token: 0x040003BA RID: 954
		[Token(Token = "0x40003BA")]
		TimeZoneUsed = 256,
		// Token: 0x040003BB RID: 955
		[Token(Token = "0x40003BB")]
		TimeZoneUtc = 512,
		// Token: 0x040003BC RID: 956
		[Token(Token = "0x40003BC")]
		ParsedMonthName = 1024,
		// Token: 0x040003BD RID: 957
		[Token(Token = "0x40003BD")]
		CaptureOffset = 2048,
		// Token: 0x040003BE RID: 958
		[Token(Token = "0x40003BE")]
		YearDefault = 4096,
		// Token: 0x040003BF RID: 959
		[Token(Token = "0x40003BF")]
		Rfc1123Pattern = 8192,
		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		UtcSortPattern = 16384
	}
}
