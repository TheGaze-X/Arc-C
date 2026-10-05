using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x20000C9")]
	internal class LeafNode : SyntaxTreeNode
	{
		// Token: 0x06000826 RID: 2086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000826")]
		[Address(RVA = "0x50EDE0", Offset = "0x50D9E0", VA = "0x18050EDE0")]
		public LeafNode(int pos)
		{
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x00004860 File Offset: 0x00002A60
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001F9")]
		public int Pos
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			set
			{
			}
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x4FE1880", Offset = "0x4FE0480", VA = "0x184FE1880", Slot = "5")]
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x00004878 File Offset: 0x00002A78
		[Token(Token = "0x170001FA")]
		public override bool IsNullable
		{
			[Token(Token = "0x600082B")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000423 RID: 1059
		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x10")]
		private int pos;
	}
}
