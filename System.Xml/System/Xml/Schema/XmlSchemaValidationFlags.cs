using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000158 RID: 344
	[Token(Token = "0x2000158")]
	[Flags]
	public enum XmlSchemaValidationFlags
	{
		// Token: 0x040005C3 RID: 1475
		[Token(Token = "0x40005C3")]
		None = 0,
		// Token: 0x040005C4 RID: 1476
		[Token(Token = "0x40005C4")]
		ProcessInlineSchema = 1,
		// Token: 0x040005C5 RID: 1477
		[Token(Token = "0x40005C5")]
		ProcessSchemaLocation = 2,
		// Token: 0x040005C6 RID: 1478
		[Token(Token = "0x40005C6")]
		ReportValidationWarnings = 4,
		// Token: 0x040005C7 RID: 1479
		[Token(Token = "0x40005C7")]
		ProcessIdentityConstraints = 8,
		// Token: 0x040005C8 RID: 1480
		[Token(Token = "0x40005C8")]
		AllowXmlAttributes = 16
	}
}
