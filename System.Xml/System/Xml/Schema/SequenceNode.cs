using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000CC RID: 204
	[Token(Token = "0x20000CC")]
	internal sealed class SequenceNode : InteriorNode
	{
		// Token: 0x06000838 RID: 2104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x4FE6160", Offset = "0x4FE4D60", VA = "0x184FE6160", Slot = "5")]
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x000048A8 File Offset: 0x00002AA8
		[Token(Token = "0x170001FE")]
		public override bool IsNullable
		{
			[Token(Token = "0x6000839")]
			[Address(RVA = "0x4FE6A40", Offset = "0x4FE5640", VA = "0x184FE6A40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x4FD8720", Offset = "0x4FD7320", VA = "0x184FD8720", Slot = "4")]
		public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SequenceNode()
		{
		}

		// Token: 0x020000CD RID: 205
		[Token(Token = "0x20000CD")]
		private struct SequenceConstructPosContext
		{
			// Token: 0x0600083C RID: 2108 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600083C")]
			[Address(RVA = "0x4FE60F0", Offset = "0x4FE4CF0", VA = "0x184FE60F0")]
			public SequenceConstructPosContext(SequenceNode node, BitSet firstpos, BitSet lastpos)
			{
			}

			// Token: 0x04000428 RID: 1064
			[Token(Token = "0x4000428")]
			[FieldOffset(Offset = "0x0")]
			public SequenceNode this_;

			// Token: 0x04000429 RID: 1065
			[Token(Token = "0x4000429")]
			[FieldOffset(Offset = "0x8")]
			public BitSet firstpos;

			// Token: 0x0400042A RID: 1066
			[Token(Token = "0x400042A")]
			[FieldOffset(Offset = "0x10")]
			public BitSet lastpos;

			// Token: 0x0400042B RID: 1067
			[Token(Token = "0x400042B")]
			[FieldOffset(Offset = "0x18")]
			public BitSet lastposLeft;

			// Token: 0x0400042C RID: 1068
			[Token(Token = "0x400042C")]
			[FieldOffset(Offset = "0x20")]
			public BitSet firstposRight;
		}
	}
}
