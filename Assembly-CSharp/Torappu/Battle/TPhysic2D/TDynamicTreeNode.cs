using System;
using Il2CppDummyDll;

namespace Torappu.Battle.TPhysic2D
{
	// Token: 0x02002699 RID: 9881
	[Token(Token = "0x2002699")]
	public class TDynamicTreeNode<T>
	{
		// Token: 0x06010236 RID: 66102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010236")]
		private void _Reset()
		{
		}

		// Token: 0x06010237 RID: 66103 RVA: 0x00062670 File Offset: 0x00060870
		[Token(Token = "0x6010237")]
		public bool IsLeaf()
		{
			return default(bool);
		}

		// Token: 0x06010238 RID: 66104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010238")]
		public TDynamicTreeNode()
		{
		}

		// Token: 0x04011FCF RID: 73679
		[Token(Token = "0x4011FCF")]
		[FieldOffset(Offset = "0x0")]
		public int parent;

		// Token: 0x04011FD0 RID: 73680
		[Token(Token = "0x4011FD0")]
		[FieldOffset(Offset = "0x0")]
		public int child1;

		// Token: 0x04011FD1 RID: 73681
		[Token(Token = "0x4011FD1")]
		[FieldOffset(Offset = "0x0")]
		public int child2;

		// Token: 0x04011FD2 RID: 73682
		[Token(Token = "0x4011FD2")]
		[FieldOffset(Offset = "0x0")]
		public int height;

		// Token: 0x04011FD3 RID: 73683
		[Token(Token = "0x4011FD3")]
		[FieldOffset(Offset = "0x0")]
		public T nodeData;

		// Token: 0x04011FD4 RID: 73684
		[Token(Token = "0x4011FD4")]
		[FieldOffset(Offset = "0x0")]
		public TAABB aabb;

		// Token: 0x04011FD5 RID: 73685
		[Token(Token = "0x4011FD5")]
		[FieldOffset(Offset = "0x0")]
		public int next;

		// Token: 0x04011FD6 RID: 73686
		[Token(Token = "0x4011FD6")]
		[FieldOffset(Offset = "0x0")]
		public bool moved;
	}
}
