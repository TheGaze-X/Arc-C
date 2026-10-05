using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Linq
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	internal class GroupedEnumerable<TSource, TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600013C")]
		public GroupedEnumerable(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013D")]
		public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013E")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerable<TSource> source;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x0")]
		private Func<TSource, TKey> keySelector;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x0")]
		private Func<TSource, TElement> elementSelector;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TKey> comparer;
	}
}
