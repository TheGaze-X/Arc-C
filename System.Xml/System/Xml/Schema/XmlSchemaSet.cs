using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000151 RID: 337
	[Token(Token = "0x2000151")]
	public class XmlSchemaSet
	{
		// Token: 0x06000B04 RID: 2820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x50211E0", Offset = "0x501FDE0", VA = "0x1850211E0")]
		public XmlSchemaSet()
		{
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x5021250", Offset = "0x501FE50", VA = "0x185021250")]
		public XmlSchemaSet(XmlNameTable nameTable)
		{
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x5021190", Offset = "0x501FD90", VA = "0x185021190")]
		private void InternalValidationCallback(object sender, ValidationEventArgs e)
		{
		}

		// Token: 0x040005AA RID: 1450
		[Token(Token = "0x40005AA")]
		[FieldOffset(Offset = "0x10")]
		private XmlNameTable nameTable;

		// Token: 0x040005AB RID: 1451
		[Token(Token = "0x40005AB")]
		[FieldOffset(Offset = "0x18")]
		private SortedList schemas;

		// Token: 0x040005AC RID: 1452
		[Token(Token = "0x40005AC")]
		[FieldOffset(Offset = "0x20")]
		private ValidationEventHandler internalEventHandler;

		// Token: 0x040005AD RID: 1453
		[Token(Token = "0x40005AD")]
		[FieldOffset(Offset = "0x28")]
		private ValidationEventHandler eventHandler;

		// Token: 0x040005AE RID: 1454
		[Token(Token = "0x40005AE")]
		[FieldOffset(Offset = "0x30")]
		private Hashtable schemaLocations;

		// Token: 0x040005AF RID: 1455
		[Token(Token = "0x40005AF")]
		[FieldOffset(Offset = "0x38")]
		private Hashtable chameleonSchemas;

		// Token: 0x040005B0 RID: 1456
		[Token(Token = "0x40005B0")]
		[FieldOffset(Offset = "0x40")]
		private Hashtable targetNamespaces;

		// Token: 0x040005B1 RID: 1457
		[Token(Token = "0x40005B1")]
		[FieldOffset(Offset = "0x48")]
		private bool compileAll;

		// Token: 0x040005B2 RID: 1458
		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0x50")]
		private SchemaInfo cachedCompiledInfo;

		// Token: 0x040005B3 RID: 1459
		[Token(Token = "0x40005B3")]
		[FieldOffset(Offset = "0x58")]
		private XmlReaderSettings readerSettings;

		// Token: 0x040005B4 RID: 1460
		[Token(Token = "0x40005B4")]
		[FieldOffset(Offset = "0x60")]
		private XmlSchemaCompilationSettings compilationSettings;
	}
}
