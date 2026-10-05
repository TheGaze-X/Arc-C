using System;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000145 RID: 325
	[Token(Token = "0x2000145")]
	[Flags]
	public enum XmlSchemaDerivationMethod
	{
		// Token: 0x04000589 RID: 1417
		[Token(Token = "0x4000589")]
		[XmlEnum("")]
		Empty = 0,
		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400058A")]
		[XmlEnum("substitution")]
		Substitution = 1,
		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400058B")]
		[XmlEnum("extension")]
		Extension = 2,
		// Token: 0x0400058C RID: 1420
		[Token(Token = "0x400058C")]
		[XmlEnum("restriction")]
		Restriction = 4,
		// Token: 0x0400058D RID: 1421
		[Token(Token = "0x400058D")]
		[XmlEnum("list")]
		List = 8,
		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400058E")]
		[XmlEnum("union")]
		Union = 16,
		// Token: 0x0400058F RID: 1423
		[Token(Token = "0x400058F")]
		[XmlEnum("#all")]
		All = 255,
		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000590")]
		[XmlIgnore]
		None = 256
	}
}
