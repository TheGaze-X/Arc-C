using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000607 RID: 1543
	[Token(Token = "0x2000607")]
	public interface IEqualityComparer<in T>
	{
		// Token: 0x06002E84 RID: 11908
		[Token(Token = "0x6002E84")]
		bool Equals(T x, T y);

		// Token: 0x06002E85 RID: 11909
		[Token(Token = "0x6002E85")]
		int GetHashCode(T obj);
	}
}
