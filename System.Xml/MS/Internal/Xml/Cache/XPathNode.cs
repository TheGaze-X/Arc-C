using System;
using System.Xml.XPath;
using Il2CppDummyDll;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x02000171 RID: 369
	[Token(Token = "0x2000171")]
	internal struct XPathNode
	{
		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x000068B8 File Offset: 0x00004AB8
		[Token(Token = "0x17000354")]
		public XPathNodeType NodeType
		{
			[Token(Token = "0x6000CB2")]
			[Address(RVA = "0x5024AA0", Offset = "0x50236A0", VA = "0x185024AA0")]
			get
			{
				return XPathNodeType.Root;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000355")]
		public string Prefix
		{
			[Token(Token = "0x6000CB3")]
			[Address(RVA = "0x5024AD0", Offset = "0x50236D0", VA = "0x185024AD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000356")]
		public string LocalName
		{
			[Token(Token = "0x6000CB4")]
			[Address(RVA = "0x4AB1620", Offset = "0x4AB0220", VA = "0x184AB1620")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000357")]
		public string NamespaceUri
		{
			[Token(Token = "0x6000CB5")]
			[Address(RVA = "0x5024A80", Offset = "0x5023680", VA = "0x185024A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000358")]
		public XPathDocument Document
		{
			[Token(Token = "0x6000CB6")]
			[Address(RVA = "0x5024990", Offset = "0x5023590", VA = "0x185024990")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000359")]
		public XPathNodePageInfo PageInfo
		{
			[Token(Token = "0x6000CB7")]
			[Address(RVA = "0x5024AB0", Offset = "0x50236B0", VA = "0x185024AB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x000068D0 File Offset: 0x00004AD0
		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0x5024910", Offset = "0x5023510", VA = "0x185024910")]
		public int GetParent(out XPathNode[] pageNode)
		{
			return 0;
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x000068E8 File Offset: 0x00004AE8
		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0x5024950", Offset = "0x5023550", VA = "0x185024950")]
		public int GetSibling(out XPathNode[] pageNode)
		{
			return 0;
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x00006900 File Offset: 0x00004B00
		[Token(Token = "0x1700035A")]
		public bool IsXmlNamespaceNode
		{
			[Token(Token = "0x6000CBA")]
			[Address(RVA = "0x5024A10", Offset = "0x5023610", VA = "0x185024A10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x00006918 File Offset: 0x00004B18
		[Token(Token = "0x1700035B")]
		public bool HasSibling
		{
			[Token(Token = "0x6000CBB")]
			[Address(RVA = "0x50249B0", Offset = "0x50235B0", VA = "0x1850249B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x00006930 File Offset: 0x00004B30
		[Token(Token = "0x1700035C")]
		public bool HasCollapsedText
		{
			[Token(Token = "0x6000CBC")]
			[Address(RVA = "0xF5B860", Offset = "0xF5A460", VA = "0x180F5B860")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x00006948 File Offset: 0x00004B48
		[Token(Token = "0x1700035D")]
		public bool IsText
		{
			[Token(Token = "0x6000CBD")]
			[Address(RVA = "0x50249C0", Offset = "0x50235C0", VA = "0x1850249C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x00006960 File Offset: 0x00004B60
		[Token(Token = "0x1700035E")]
		public bool HasNamespaceDecls
		{
			[Token(Token = "0x6000CBE")]
			[Address(RVA = "0xF5B820", Offset = "0xF5A420", VA = "0x180F5B820")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035F")]
		public string Value
		{
			[Token(Token = "0x6000CBF")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400068A RID: 1674
		[Token(Token = "0x400068A")]
		[FieldOffset(Offset = "0x0")]
		private XPathNodeInfoAtom _info;

		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x400068B")]
		[FieldOffset(Offset = "0x8")]
		private ushort _idxSibling;

		// Token: 0x0400068C RID: 1676
		[Token(Token = "0x400068C")]
		[FieldOffset(Offset = "0xA")]
		private ushort _idxParent;

		// Token: 0x0400068D RID: 1677
		[Token(Token = "0x400068D")]
		[FieldOffset(Offset = "0xC")]
		private ushort _idxSimilar;

		// Token: 0x0400068E RID: 1678
		[Token(Token = "0x400068E")]
		[FieldOffset(Offset = "0xE")]
		private ushort _posOffset;

		// Token: 0x0400068F RID: 1679
		[Token(Token = "0x400068F")]
		[FieldOffset(Offset = "0x10")]
		private uint _props;

		// Token: 0x04000690 RID: 1680
		[Token(Token = "0x4000690")]
		[FieldOffset(Offset = "0x18")]
		private string _value;
	}
}
