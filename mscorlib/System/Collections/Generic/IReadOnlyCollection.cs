using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000609 RID: 1545
	[Token(Token = "0x2000609")]
	public interface IReadOnlyCollection<out T> : IEnumerable<T>, IEnumerable
	{
		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06002E8B RID: 11915
		[Token(Token = "0x17000793")]
		int Count { [Token(Token = "0x6002E8B")] get; }
	}
}
