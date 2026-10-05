using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200014D RID: 333
	[Token(Token = "0x200014D")]
	internal interface IValueTupleInternal : System.Runtime.CompilerServices.ITuple
	{
		// Token: 0x06000BE5 RID: 3045
		[Token(Token = "0x6000BE5")]
		int GetHashCode(System.Collections.IEqualityComparer comparer);

		// Token: 0x06000BE6 RID: 3046
		[Token(Token = "0x6000BE6")]
		string ToStringEnd();
	}
}
