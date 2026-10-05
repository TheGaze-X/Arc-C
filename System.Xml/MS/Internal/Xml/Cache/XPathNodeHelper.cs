using System;
using Il2CppDummyDll;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x02000173 RID: 371
	[Token(Token = "0x2000173")]
	internal abstract class XPathNodeHelper
	{
		// Token: 0x06000CC4 RID: 3268 RVA: 0x000069A8 File Offset: 0x00004BA8
		[Token(Token = "0x6000CC4")]
		[Address(RVA = "0x5024490", Offset = "0x5023090", VA = "0x185024490")]
		public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp)
		{
			return 0;
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x000069C0 File Offset: 0x00004BC0
		[Token(Token = "0x6000CC5")]
		[Address(RVA = "0x5024370", Offset = "0x5022F70", VA = "0x185024370")]
		public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp)
		{
			return 0;
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x000069D8 File Offset: 0x00004BD8
		[Token(Token = "0x6000CC6")]
		[Address(RVA = "0x5024640", Offset = "0x5023240", VA = "0x185024640")]
		public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode)
		{
			return default(bool);
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x000069F0 File Offset: 0x00004BF0
		[Token(Token = "0x6000CC7")]
		[Address(RVA = "0x5024510", Offset = "0x5023110", VA = "0x185024510")]
		public static int GetLocation(XPathNode[] pageNode, int idxNode)
		{
			return 0;
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00006A08 File Offset: 0x00004C08
		[Token(Token = "0x6000CC8")]
		[Address(RVA = "0x50246E0", Offset = "0x50232E0", VA = "0x1850246E0")]
		public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd)
		{
			return default(bool);
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00006A20 File Offset: 0x00004C20
		[Token(Token = "0x6000CC9")]
		[Address(RVA = "0x5024550", Offset = "0x5023150", VA = "0x185024550")]
		public static bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode)
		{
			return default(bool);
		}
	}
}
