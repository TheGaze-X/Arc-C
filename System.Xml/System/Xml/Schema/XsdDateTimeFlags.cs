using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000168 RID: 360
	[Token(Token = "0x2000168")]
	[Flags]
	internal enum XsdDateTimeFlags
	{
		// Token: 0x04000631 RID: 1585
		[Token(Token = "0x4000631")]
		DateTime = 1,
		// Token: 0x04000632 RID: 1586
		[Token(Token = "0x4000632")]
		Time = 2,
		// Token: 0x04000633 RID: 1587
		[Token(Token = "0x4000633")]
		Date = 4,
		// Token: 0x04000634 RID: 1588
		[Token(Token = "0x4000634")]
		GYearMonth = 8,
		// Token: 0x04000635 RID: 1589
		[Token(Token = "0x4000635")]
		GYear = 16,
		// Token: 0x04000636 RID: 1590
		[Token(Token = "0x4000636")]
		GMonthDay = 32,
		// Token: 0x04000637 RID: 1591
		[Token(Token = "0x4000637")]
		GDay = 64,
		// Token: 0x04000638 RID: 1592
		[Token(Token = "0x4000638")]
		GMonth = 128,
		// Token: 0x04000639 RID: 1593
		[Token(Token = "0x4000639")]
		XdrDateTimeNoTz = 256,
		// Token: 0x0400063A RID: 1594
		[Token(Token = "0x400063A")]
		XdrDateTime = 512,
		// Token: 0x0400063B RID: 1595
		[Token(Token = "0x400063B")]
		XdrTimeNoTz = 1024,
		// Token: 0x0400063C RID: 1596
		[Token(Token = "0x400063C")]
		AllXsd = 255
	}
}
