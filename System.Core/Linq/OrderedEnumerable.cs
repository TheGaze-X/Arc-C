using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Linq
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	internal abstract class OrderedEnumerable<TElement> : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable
	{
		// Token: 0x0600013F RID: 319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013F")]
		public IEnumerator<TElement> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000140 RID: 320
		[Token(Token = "0x6000140")]
		internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next);

		// Token: 0x06000141 RID: 321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000141")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000142")]
		private IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
		{
			return null;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000143")]
		protected OrderedEnumerable()
		{
		}

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x0")]
		internal IEnumerable<TElement> source;
	}
}
