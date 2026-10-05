using System;
using Il2CppDummyDll;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x02000172 RID: 370
	[Token(Token = "0x2000172")]
	internal struct XPathNodeRef
	{
		// Token: 0x06000CC0 RID: 3264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x21178B0", Offset = "0x21164B0", VA = "0x1821178B0")]
		public XPathNodeRef(XPathNode[] page, int idx)
		{
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000360")]
		public XPathNode[] Page
		{
			[Token(Token = "0x6000CC1")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x00006978 File Offset: 0x00004B78
		[Token(Token = "0x17000361")]
		public int Index
		{
			[Token(Token = "0x6000CC2")]
			[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00006990 File Offset: 0x00004B90
		[Token(Token = "0x6000CC3")]
		[Address(RVA = "0x50248D0", Offset = "0x50234D0", VA = "0x1850248D0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000691 RID: 1681
		[Token(Token = "0x4000691")]
		[FieldOffset(Offset = "0x0")]
		private XPathNode[] _page;

		// Token: 0x04000692 RID: 1682
		[Token(Token = "0x4000692")]
		[FieldOffset(Offset = "0x8")]
		private int _idx;
	}
}
