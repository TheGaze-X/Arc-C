using System;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x0200020D RID: 525
	[Token(Token = "0x200020D")]
	internal class SparselyPopulatedArrayFragment<T> where T : class
	{
		// Token: 0x0600121E RID: 4638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600121E")]
		internal SparselyPopulatedArrayFragment(int size)
		{
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600121F")]
		internal SparselyPopulatedArrayFragment(int size, SparselyPopulatedArrayFragment<T> prev)
		{
		}

		// Token: 0x170001B0 RID: 432
		[Token(Token = "0x170001B0")]
		internal T this[int index]
		{
			[Token(Token = "0x6001220")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
		[Token(Token = "0x170001B1")]
		internal int Length
		{
			[Token(Token = "0x6001221")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001B2")]
		internal SparselyPopulatedArrayFragment<T> Prev
		{
			[Token(Token = "0x6001222")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001223")]
		internal T SafeAtomicRemove(int index, T expectedElement)
		{
			return null;
		}

		// Token: 0x04000A43 RID: 2627
		[Token(Token = "0x4000A43")]
		[FieldOffset(Offset = "0x0")]
		internal readonly T[] _elements;

		// Token: 0x04000A44 RID: 2628
		[Token(Token = "0x4000A44")]
		[FieldOffset(Offset = "0x0")]
		internal int _freeCount;

		// Token: 0x04000A45 RID: 2629
		[Token(Token = "0x4000A45")]
		[FieldOffset(Offset = "0x0")]
		internal SparselyPopulatedArrayFragment<T> _next;

		// Token: 0x04000A46 RID: 2630
		[Token(Token = "0x4000A46")]
		[FieldOffset(Offset = "0x0")]
		internal SparselyPopulatedArrayFragment<T> _prev;
	}
}
