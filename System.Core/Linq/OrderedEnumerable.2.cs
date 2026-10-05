using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Linq
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	internal class OrderedEnumerable<TElement, TKey> : OrderedEnumerable<TElement>
	{
		// Token: 0x0600014A RID: 330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600014A")]
		internal OrderedEnumerable(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014B")]
		internal override EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next)
		{
			return null;
		}

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x0")]
		internal OrderedEnumerable<TElement> parent;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x0")]
		internal Func<TElement, TKey> keySelector;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x0")]
		internal IComparer<TKey> comparer;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x0")]
		internal bool descending;
	}
}
