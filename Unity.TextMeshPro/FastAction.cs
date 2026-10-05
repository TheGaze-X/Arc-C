using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TMPro
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	public class FastAction
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x586A340", Offset = "0x5868F40", VA = "0x18586A340")]
		public void Add(Action rhs)
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x586A490", Offset = "0x5869090", VA = "0x18586A490")]
		public void Remove(Action rhs)
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x586A400", Offset = "0x5869000", VA = "0x18586A400")]
		public void Call()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x586A550", Offset = "0x5869150", VA = "0x18586A550")]
		public FastAction()
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		private LinkedList<Action> delegates;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<Action, LinkedListNode<Action>> lookup;
	}
}
