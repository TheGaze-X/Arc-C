using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Spine.Collections
{
	// Token: 0x020000D8 RID: 216
	[Token(Token = "0x20000D8")]
	public static class CollectionExtensions
	{
		// Token: 0x060007BB RID: 1979 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60007BB")]
		public static OrderedDictionary<TKey, TSource> ToOrderedDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60007BC")]
		public static OrderedDictionary<TKey, TSource> ToOrderedDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}
	}
}
