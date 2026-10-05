using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000CA RID: 202
	[Token(Token = "0x20000CA")]
	internal class NamespaceListNode : SyntaxTreeNode
	{
		// Token: 0x0600082C RID: 2092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		public NamespaceListNode(NamespaceList namespaceList, object particle)
		{
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x4FE1DE0", Offset = "0x4FE09E0", VA = "0x184FE1DE0", Slot = "8")]
		public virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols)
		{
			return null;
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x4FE19F0", Offset = "0x4FE05F0", VA = "0x184FE19F0", Slot = "4")]
		public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x4FE19A0", Offset = "0x4FE05A0", VA = "0x184FE19A0", Slot = "5")]
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x00004890 File Offset: 0x00002A90
		[Token(Token = "0x170001FB")]
		public override bool IsNullable
		{
			[Token(Token = "0x6000830")]
			[Address(RVA = "0x4FE1E10", Offset = "0x4FE0A10", VA = "0x184FE1E10", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000424 RID: 1060
		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0x10")]
		protected NamespaceList namespaceList;

		// Token: 0x04000425 RID: 1061
		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0x18")]
		protected object particle;
	}
}
