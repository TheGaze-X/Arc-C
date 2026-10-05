using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TMPro
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public class FastAction<A, B, C>
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000D")]
		public void Add(Action<A, B, C> rhs)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000E")]
		public void Remove(Action<A, B, C> rhs)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000F")]
		public void Call(A a, B b, C c)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		public FastAction()
		{
		}

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x0")]
		private LinkedList<Action<A, B, C>> delegates;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>> lookup;
	}
}
