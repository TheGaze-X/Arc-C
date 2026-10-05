using System;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x0200020B RID: 523
	[Token(Token = "0x200020B")]
	internal class SparselyPopulatedArray<T> where T : class
	{
		// Token: 0x06001218 RID: 4632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001218")]
		internal SparselyPopulatedArray(int initialSize)
		{
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06001219 RID: 4633 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001AD")]
		internal SparselyPopulatedArrayFragment<T> Tail
		{
			[Token(Token = "0x6001219")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0000E778 File Offset: 0x0000C978
		[Token(Token = "0x600121A")]
		internal SparselyPopulatedArrayAddInfo<T> Add(T element)
		{
			return default(SparselyPopulatedArrayAddInfo<T>);
		}

		// Token: 0x04000A3F RID: 2623
		[Token(Token = "0x4000A3F")]
		[FieldOffset(Offset = "0x0")]
		private readonly SparselyPopulatedArrayFragment<T> _head;

		// Token: 0x04000A40 RID: 2624
		[Token(Token = "0x4000A40")]
		[FieldOffset(Offset = "0x0")]
		private SparselyPopulatedArrayFragment<T> _tail;
	}
}
