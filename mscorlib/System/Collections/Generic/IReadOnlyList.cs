using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x0200060B RID: 1547
	[Token(Token = "0x200060B")]
	public interface IReadOnlyList<out T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable
	{
		// Token: 0x17000794 RID: 1940
		[Token(Token = "0x17000794")]
		T this[int index]
		{
			[Token(Token = "0x6002E8D")]
			get;
		}
	}
}
