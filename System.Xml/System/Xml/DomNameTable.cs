using System;
using System.Xml.Schema;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	internal class DomNameTable
	{
		// Token: 0x0600045F RID: 1119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x4FA44A0", Offset = "0x4FA30A0", VA = "0x184FA44A0")]
		public DomNameTable(XmlDocument document)
		{
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x4FA41E0", Offset = "0x4FA2DE0", VA = "0x184FA41E0")]
		public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo)
		{
			return null;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x4FA3DB0", Offset = "0x4FA29B0", VA = "0x184FA3DB0")]
		public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo)
		{
			return null;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x4FA4330", Offset = "0x4FA2F30", VA = "0x184FA4330")]
		private void Grow()
		{
		}

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x10")]
		private XmlName[] entries;

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x18")]
		private int count;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x1C")]
		private int mask;

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x20")]
		private XmlDocument ownerDocument;

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x28")]
		private XmlNameTable nameTable;
	}
}
