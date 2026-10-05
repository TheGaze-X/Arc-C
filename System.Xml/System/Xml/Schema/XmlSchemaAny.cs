using System;
using System.ComponentModel;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200013C RID: 316
	[Token(Token = "0x200013C")]
	public class XmlSchemaAny : XmlSchemaParticle
	{
		// Token: 0x1700030E RID: 782
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700030E")]
		[XmlAttribute("processContents")]
		[DefaultValue(XmlSchemaContentProcessing.None)]
		public XmlSchemaContentProcessing ProcessContents
		{
			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0xE30780", Offset = "0xE2F380", VA = "0x180E30780")]
			set
			{
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030F")]
		[XmlIgnore]
		internal NamespaceList NamespaceList
		{
			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x501E710", Offset = "0x501D310", VA = "0x18501E710")]
		internal void BuildNamespaceList(string targetNamespace)
		{
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x501E7B0", Offset = "0x501D3B0", VA = "0x18501E7B0")]
		public XmlSchemaAny()
		{
		}

		// Token: 0x0400056F RID: 1391
		[Token(Token = "0x400056F")]
		[FieldOffset(Offset = "0x38")]
		private string ns;

		// Token: 0x04000570 RID: 1392
		[Token(Token = "0x4000570")]
		[FieldOffset(Offset = "0x40")]
		private XmlSchemaContentProcessing processContents;

		// Token: 0x04000571 RID: 1393
		[Token(Token = "0x4000571")]
		[FieldOffset(Offset = "0x48")]
		private NamespaceList namespaceList;
	}
}
