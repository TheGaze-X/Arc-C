using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Linq
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	public interface IGrouping<out TKey, out TElement> : IEnumerable<TElement>, IEnumerable
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000111 RID: 273
		[Token(Token = "0x17000026")]
		TKey Key { [Token(Token = "0x6000111")] get; }
	}
}
