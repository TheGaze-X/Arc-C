using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000601 RID: 1537
	[Token(Token = "0x2000601")]
	public interface IDictionary<TKey, TValue> : ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		// Token: 0x1700078E RID: 1934
		[Token(Token = "0x1700078E")]
		TValue this[TKey key]
		{
			[Token(Token = "0x6002E7A")]
			get;
			[Token(Token = "0x6002E7B")]
			set;
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06002E7C RID: 11900
		[Token(Token = "0x1700078F")]
		ICollection<TKey> Keys { [Token(Token = "0x6002E7C")] get; }

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06002E7D RID: 11901
		[Token(Token = "0x17000790")]
		ICollection<TValue> Values { [Token(Token = "0x6002E7D")] get; }

		// Token: 0x06002E7E RID: 11902
		[Token(Token = "0x6002E7E")]
		bool ContainsKey(TKey key);

		// Token: 0x06002E7F RID: 11903
		[Token(Token = "0x6002E7F")]
		void Add(TKey key, TValue value);

		// Token: 0x06002E80 RID: 11904
		[Token(Token = "0x6002E80")]
		bool Remove(TKey key);

		// Token: 0x06002E81 RID: 11905
		[Token(Token = "0x6002E81")]
		bool TryGetValue(TKey key, out TValue value);
	}
}
