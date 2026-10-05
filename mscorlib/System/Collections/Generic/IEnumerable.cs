using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000605 RID: 1541
	[Token(Token = "0x2000605")]
	public interface IEnumerable<out T> : IEnumerable
	{
		// Token: 0x06002E82 RID: 11906
		[Token(Token = "0x6002E82")]
		IEnumerator<T> GetEnumerator();
	}
}
