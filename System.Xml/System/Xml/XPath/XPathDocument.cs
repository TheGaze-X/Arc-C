using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using MS.Internal.Xml.Cache;

namespace System.Xml.XPath
{
	// Token: 0x020000B4 RID: 180
	[Token(Token = "0x20000B4")]
	public class XPathDocument
	{
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D3")]
		internal XmlNameTable NameTable
		{
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00004590 File Offset: 0x00002790
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x4FEB870", Offset = "0x4FEA470", VA = "0x184FEB870")]
		internal int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp)
		{
			return 0;
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x000045A8 File Offset: 0x000027A8
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x4FEB8A0", Offset = "0x4FEA4A0", VA = "0x184FEB8A0")]
		internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp)
		{
			return 0;
		}

		// Token: 0x040003F0 RID: 1008
		[Token(Token = "0x40003F0")]
		[FieldOffset(Offset = "0x10")]
		private XPathNode[] pageXmlNmsp;

		// Token: 0x040003F1 RID: 1009
		[Token(Token = "0x40003F1")]
		[FieldOffset(Offset = "0x18")]
		private int idxXmlNmsp;

		// Token: 0x040003F2 RID: 1010
		[Token(Token = "0x40003F2")]
		[FieldOffset(Offset = "0x20")]
		private XmlNameTable nameTable;

		// Token: 0x040003F3 RID: 1011
		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp;
	}
}
