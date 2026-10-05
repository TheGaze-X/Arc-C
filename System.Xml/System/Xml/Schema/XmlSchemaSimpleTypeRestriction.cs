using System;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000155 RID: 341
	[Token(Token = "0x2000155")]
	public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent
	{
		// Token: 0x1700032E RID: 814
		// (set) Token: 0x06000B0F RID: 2831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700032E")]
		[XmlAttribute("base")]
		public XmlQualifiedName BaseTypeName
		{
			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0x50217B0", Offset = "0x50203B0", VA = "0x1850217B0")]
			set
			{
			}
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x50216F0", Offset = "0x50202F0", VA = "0x1850216F0")]
		public XmlSchemaSimpleTypeRestriction()
		{
		}

		// Token: 0x040005B9 RID: 1465
		[Token(Token = "0x40005B9")]
		[FieldOffset(Offset = "0x10")]
		private XmlQualifiedName baseTypeName;

		// Token: 0x040005BA RID: 1466
		[Token(Token = "0x40005BA")]
		[FieldOffset(Offset = "0x18")]
		private XmlSchemaObjectCollection facets;
	}
}
