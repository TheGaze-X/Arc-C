using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Linq
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	internal class EnumerableSorter<TElement, TKey> : EnumerableSorter<TElement>
	{
		// Token: 0x06000151 RID: 337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000151")]
		internal EnumerableSorter(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, EnumerableSorter<TElement> next)
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000152")]
		internal override void ComputeKeys(TElement[] elements, int count)
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x6000153")]
		internal override int CompareKeys(int index1, int index2)
		{
			return 0;
		}

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x0")]
		internal Func<TElement, TKey> keySelector;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x0")]
		internal IComparer<TKey> comparer;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x0")]
		internal bool descending;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x0")]
		internal EnumerableSorter<TElement> next;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x0")]
		internal TKey[] keys;
	}
}
