using System;
using Il2CppDummyDll;

namespace System.Collections
{
	// Token: 0x020005BF RID: 1471
	[Token(Token = "0x20005BF")]
	public interface IEqualityComparer
	{
		// Token: 0x06002BA6 RID: 11174
		[Token(Token = "0x6002BA6")]
		bool Equals(object x, object y);

		// Token: 0x06002BA7 RID: 11175
		[Token(Token = "0x6002BA7")]
		int GetHashCode(object obj);
	}
}
