using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TMPro
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class FastAction<A, B>
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000009")]
		public void Add(Action<A, B> rhs)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		public void Remove(Action<A, B> rhs)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		public void Call(A a, B b)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000C")]
		public FastAction()
		{
		}

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x0")]
		private LinkedList<Action<A, B>> delegates;

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> lookup;
	}
}
