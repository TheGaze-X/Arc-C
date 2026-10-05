using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000CE RID: 206
	[Token(Token = "0x20000CE")]
	internal sealed class ChoiceNode : InteriorNode
	{
		// Token: 0x0600083D RID: 2109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x4FD8200", Offset = "0x4FD6E00", VA = "0x184FD8200")]
		private static void ConstructChildPos(SyntaxTreeNode child, BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x4FD8470", Offset = "0x4FD7070", VA = "0x184FD8470", Slot = "5")]
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x000048C0 File Offset: 0x00002AC0
		[Token(Token = "0x170001FF")]
		public override bool IsNullable
		{
			[Token(Token = "0x600083F")]
			[Address(RVA = "0x4FD8730", Offset = "0x4FD7330", VA = "0x184FD8730", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000840")]
		[Address(RVA = "0x4FD8720", Offset = "0x4FD7320", VA = "0x184FD8720", Slot = "4")]
		public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000841")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChoiceNode()
		{
		}
	}
}
