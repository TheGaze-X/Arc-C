using System;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000142 RID: 322
	[Token(Token = "0x2000142")]
	public enum XmlSchemaContentProcessing
	{
		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x400057F")]
		[XmlIgnore]
		None,
		// Token: 0x04000580 RID: 1408
		[Token(Token = "0x4000580")]
		[XmlEnum("skip")]
		Skip,
		// Token: 0x04000581 RID: 1409
		[Token(Token = "0x4000581")]
		[XmlEnum("lax")]
		Lax,
		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		[XmlEnum("strict")]
		Strict
	}
}
