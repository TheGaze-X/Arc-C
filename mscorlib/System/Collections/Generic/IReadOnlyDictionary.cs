using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x0200060A RID: 1546
	[Token(Token = "0x200060A")]
	[System.Reflection.DefaultMember("Item")]
	public interface IReadOnlyDictionary<TKey, TValue> : IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		// Token: 0x06002E8C RID: 11916
		[Token(Token = "0x6002E8C")]
		bool TryGetValue(TKey key, out TValue value);
	}
}
