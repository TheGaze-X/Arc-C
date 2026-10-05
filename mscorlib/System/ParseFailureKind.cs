using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	internal enum ParseFailureKind
	{
		// Token: 0x040003A9 RID: 937
		[Token(Token = "0x40003A9")]
		None,
		// Token: 0x040003AA RID: 938
		[Token(Token = "0x40003AA")]
		ArgumentNull,
		// Token: 0x040003AB RID: 939
		[Token(Token = "0x40003AB")]
		Format,
		// Token: 0x040003AC RID: 940
		[Token(Token = "0x40003AC")]
		FormatWithParameter,
		// Token: 0x040003AD RID: 941
		[Token(Token = "0x40003AD")]
		FormatWithOriginalDateTime,
		// Token: 0x040003AE RID: 942
		[Token(Token = "0x40003AE")]
		FormatWithFormatSpecifier,
		// Token: 0x040003AF RID: 943
		[Token(Token = "0x40003AF")]
		FormatWithOriginalDateTimeAndParameter,
		// Token: 0x040003B0 RID: 944
		[Token(Token = "0x40003B0")]
		FormatBadDateTimeCalendar
	}
}
