using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000606 RID: 1542
	[Token(Token = "0x2000606")]
	public interface IEnumerator<out T> : System.IDisposable, IEnumerator
	{
		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06002E83 RID: 11907
		[Token(Token = "0x17000791")]
		T Current { [Token(Token = "0x6002E83")] get; }
	}
}
