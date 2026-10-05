using System;
using Il2CppDummyDll;

namespace System.Linq
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	internal abstract class EnumerableSorter<TElement>
	{
		// Token: 0x0600014C RID: 332
		[Token(Token = "0x600014C")]
		internal abstract void ComputeKeys(TElement[] elements, int count);

		// Token: 0x0600014D RID: 333
		[Token(Token = "0x600014D")]
		internal abstract int CompareKeys(int index1, int index2);

		// Token: 0x0600014E RID: 334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014E")]
		internal int[] Sort(TElement[] elements, int count)
		{
			return null;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600014F")]
		private void QuickSort(int[] map, int left, int right)
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000150")]
		protected EnumerableSorter()
		{
		}
	}
}
