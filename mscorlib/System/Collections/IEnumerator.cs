using System;
using Il2CppDummyDll;

namespace System.Collections
{
	// Token: 0x020005BE RID: 1470
	[Token(Token = "0x20005BE")]
	public interface IEnumerator
	{
		// Token: 0x06002BA3 RID: 11171
		[Token(Token = "0x6002BA3")]
		bool MoveNext();

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06002BA4 RID: 11172
		[Token(Token = "0x170006C0")]
		object Current { [Token(Token = "0x6002BA4")] get; }

		// Token: 0x06002BA5 RID: 11173
		[Token(Token = "0x6002BA5")]
		void Reset();
	}
}
