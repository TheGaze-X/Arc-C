using System;
using System.Xml;
using System.Xml.XPath;
using Il2CppDummyDll;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x02000170 RID: 368
	[Token(Token = "0x2000170")]
	internal sealed class XPathDocumentNavigator : XPathNavigator
	{
		// Token: 0x06000CA4 RID: 3236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CA4")]
		[Address(RVA = "0x5023E90", Offset = "0x5022A90", VA = "0x185023E90")]
		public XPathDocumentNavigator(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent)
		{
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034D")]
		public override string Value
		{
			[Token(Token = "0x6000CA5")]
			[Address(RVA = "0x5024080", Offset = "0x5022C80", VA = "0x185024080", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA6")]
		[Address(RVA = "0x5023800", Offset = "0x5022400", VA = "0x185023800", Slot = "21")]
		public override XPathNavigator Clone()
		{
			return null;
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x00006828 File Offset: 0x00004A28
		[Token(Token = "0x1700034E")]
		public override XPathNodeType NodeType
		{
			[Token(Token = "0x6000CA7")]
			[Address(RVA = "0x5024000", Offset = "0x5022C00", VA = "0x185024000", Slot = "22")]
			get
			{
				return XPathNodeType.Root;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034F")]
		public override string LocalName
		{
			[Token(Token = "0x6000CA8")]
			[Address(RVA = "0x5023F30", Offset = "0x5022B30", VA = "0x185023F30", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000350")]
		public override string NamespaceURI
		{
			[Token(Token = "0x6000CA9")]
			[Address(RVA = "0x5023FC0", Offset = "0x5022BC0", VA = "0x185023FC0", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000351")]
		public override string Prefix
		{
			[Token(Token = "0x6000CAA")]
			[Address(RVA = "0x5024040", Offset = "0x5022C40", VA = "0x185024040", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000352")]
		public override XmlNameTable NameTable
		{
			[Token(Token = "0x6000CAB")]
			[Address(RVA = "0x5023F70", Offset = "0x5022B70", VA = "0x185023F70", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00006840 File Offset: 0x00004A40
		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0x5023980", Offset = "0x5022580", VA = "0x185023980", Slot = "28")]
		public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope)
		{
			return default(bool);
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00006858 File Offset: 0x00004A58
		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x5023BD0", Offset = "0x50227D0", VA = "0x185023BD0", Slot = "29")]
		public override bool MoveToNextNamespace(XPathNamespaceScope scope)
		{
			return default(bool);
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00006870 File Offset: 0x00004A70
		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x5023DA0", Offset = "0x50229A0", VA = "0x185023DA0", Slot = "30")]
		public override bool MoveToParent()
		{
			return default(bool);
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00006888 File Offset: 0x00004A88
		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x50238F0", Offset = "0x50224F0", VA = "0x1850238F0", Slot = "31")]
		public override bool IsSamePosition(XPathNavigator other)
		{
			return default(bool);
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000353")]
		public override object UnderlyingObject
		{
			[Token(Token = "0x6000CB0")]
			[Address(RVA = "0x4FEC2F0", Offset = "0x4FEAEF0", VA = "0x184FEC2F0", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x000068A0 File Offset: 0x00004AA0
		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x50238E0", Offset = "0x50224E0", VA = "0x1850238E0")]
		public int GetPositionHashCode()
		{
			return 0;
		}

		// Token: 0x04000686 RID: 1670
		[Token(Token = "0x4000686")]
		[FieldOffset(Offset = "0x10")]
		private XPathNode[] _pageCurrent;

		// Token: 0x04000687 RID: 1671
		[Token(Token = "0x4000687")]
		[FieldOffset(Offset = "0x18")]
		private XPathNode[] _pageParent;

		// Token: 0x04000688 RID: 1672
		[Token(Token = "0x4000688")]
		[FieldOffset(Offset = "0x20")]
		private int _idxCurrent;

		// Token: 0x04000689 RID: 1673
		[Token(Token = "0x4000689")]
		[FieldOffset(Offset = "0x24")]
		private int _idxParent;
	}
}
