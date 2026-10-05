using System;
using Il2CppDummyDll;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x02000174 RID: 372
	[Token(Token = "0x2000174")]
	internal sealed class XPathNodePageInfo
	{
		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x00006A38 File Offset: 0x00004C38
		[Token(Token = "0x17000362")]
		public int PageNumber
		{
			[Token(Token = "0x6000CCA")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x00006A50 File Offset: 0x00004C50
		[Token(Token = "0x17000363")]
		public int NodeCount
		{
			[Token(Token = "0x6000CCB")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000364")]
		public XPathNode[] NextPage
		{
			[Token(Token = "0x6000CCC")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000693 RID: 1683
		[Token(Token = "0x4000693")]
		[FieldOffset(Offset = "0x10")]
		private int _pageNum;

		// Token: 0x04000694 RID: 1684
		[Token(Token = "0x4000694")]
		[FieldOffset(Offset = "0x14")]
		private int _nodeCount;

		// Token: 0x04000695 RID: 1685
		[Token(Token = "0x4000695")]
		[FieldOffset(Offset = "0x18")]
		private XPathNode[] _pageNext;
	}
}
