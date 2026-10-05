using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000618 RID: 1560
	[Token(Token = "0x2000618")]
	public static class CollectionExtensions
	{
		// Token: 0x06002F0C RID: 12044 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002F0C")]
		public static TValue GetValueOrDefault<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key)
		{
			return null;
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002F0D")]
		public static TValue GetValueOrDefault<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue)
		{
			return null;
		}

		// Token: 0x06002F0E RID: 12046 RVA: 0x000197D0 File Offset: 0x000179D0
		[Token(Token = "0x6002F0E")]
		public static bool TryAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
		{
			return default(bool);
		}
	}
}
