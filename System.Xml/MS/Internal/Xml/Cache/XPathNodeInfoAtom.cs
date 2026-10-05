using System;
using System.Xml.XPath;
using Il2CppDummyDll;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x02000175 RID: 373
	[Token(Token = "0x2000175")]
	internal sealed class XPathNodeInfoAtom
	{
		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000365")]
		public XPathNodePageInfo PageInfo
		{
			[Token(Token = "0x6000CCD")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000366")]
		public string LocalName
		{
			[Token(Token = "0x6000CCE")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000367")]
		public string NamespaceUri
		{
			[Token(Token = "0x6000CCF")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000368")]
		public string Prefix
		{
			[Token(Token = "0x6000CD0")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000369")]
		public XPathNode[] SiblingPage
		{
			[Token(Token = "0x6000CD1")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036A")]
		public XPathNode[] ParentPage
		{
			[Token(Token = "0x6000CD2")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036B")]
		public XPathDocument Document
		{
			[Token(Token = "0x6000CD3")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000696 RID: 1686
		[Token(Token = "0x4000696")]
		[FieldOffset(Offset = "0x10")]
		private string _localName;

		// Token: 0x04000697 RID: 1687
		[Token(Token = "0x4000697")]
		[FieldOffset(Offset = "0x18")]
		private string _namespaceUri;

		// Token: 0x04000698 RID: 1688
		[Token(Token = "0x4000698")]
		[FieldOffset(Offset = "0x20")]
		private string _prefix;

		// Token: 0x04000699 RID: 1689
		[Token(Token = "0x4000699")]
		[FieldOffset(Offset = "0x28")]
		private XPathNode[] _pageParent;

		// Token: 0x0400069A RID: 1690
		[Token(Token = "0x400069A")]
		[FieldOffset(Offset = "0x30")]
		private XPathNode[] _pageSibling;

		// Token: 0x0400069B RID: 1691
		[Token(Token = "0x400069B")]
		[FieldOffset(Offset = "0x38")]
		private XPathDocument _doc;

		// Token: 0x0400069C RID: 1692
		[Token(Token = "0x400069C")]
		[FieldOffset(Offset = "0x40")]
		private XPathNodePageInfo _pageInfo;
	}
}
