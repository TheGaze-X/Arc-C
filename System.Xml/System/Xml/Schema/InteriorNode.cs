using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000CB RID: 203
	[Token(Token = "0x20000CB")]
	internal abstract class InteriorNode : SyntaxTreeNode
	{
		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000832 RID: 2098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001FC")]
		public SyntaxTreeNode LeftChild
		{
			[Token(Token = "0x6000831")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000832")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001FD")]
		public SyntaxTreeNode RightChild
		{
			[Token(Token = "0x6000833")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000834")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x4FE1590", Offset = "0x4FE0190", VA = "0x184FE1590")]
		protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x4FE17E0", Offset = "0x4FE03E0", VA = "0x184FE17E0", Slot = "4")]
		public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected InteriorNode()
		{
		}

		// Token: 0x04000426 RID: 1062
		[Token(Token = "0x4000426")]
		[FieldOffset(Offset = "0x10")]
		private SyntaxTreeNode leftChild;

		// Token: 0x04000427 RID: 1063
		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0x18")]
		private SyntaxTreeNode rightChild;
	}
}
