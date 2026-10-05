using System;
using System.ComponentModel;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200013D RID: 317
	[Token(Token = "0x200013D")]
	public class XmlSchemaAnyAttribute : XmlSchemaAnnotated
	{
		// Token: 0x17000310 RID: 784
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000310")]
		[DefaultValue(XmlSchemaContentProcessing.None)]
		[XmlAttribute("processContents")]
		public XmlSchemaContentProcessing ProcessContents
		{
			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			set
			{
			}
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x501E670", Offset = "0x501D270", VA = "0x18501E670")]
		internal void BuildNamespaceList(string targetNamespace)
		{
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public XmlSchemaAnyAttribute()
		{
		}

		// Token: 0x04000572 RID: 1394
		[Token(Token = "0x4000572")]
		[FieldOffset(Offset = "0x10")]
		private string ns;

		// Token: 0x04000573 RID: 1395
		[Token(Token = "0x4000573")]
		[FieldOffset(Offset = "0x18")]
		private XmlSchemaContentProcessing processContents;

		// Token: 0x04000574 RID: 1396
		[Token(Token = "0x4000574")]
		[FieldOffset(Offset = "0x20")]
		private NamespaceList namespaceList;
	}
}
