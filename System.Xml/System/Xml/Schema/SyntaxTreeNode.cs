using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000C8 RID: 200
	[Token(Token = "0x20000C8")]
	internal abstract class SyntaxTreeNode
	{
		// Token: 0x06000821 RID: 2081
		[Token(Token = "0x6000821")]
		public abstract void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions);

		// Token: 0x06000822 RID: 2082
		[Token(Token = "0x6000822")]
		public abstract void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos);

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000823 RID: 2083
		[Token(Token = "0x170001F7")]
		public abstract bool IsNullable { [Token(Token = "0x6000823")] get; }

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x00004848 File Offset: 0x00002A48
		[Token(Token = "0x170001F8")]
		public virtual bool IsRangeNode
		{
			[Token(Token = "0x6000824")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000825")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected SyntaxTreeNode()
		{
		}
	}
}
