using System;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	public interface ISDKPromise
	{
		// Token: 0x0600025F RID: 607
		[Token(Token = "0x600025F")]
		void Fulfill(object param);

		// Token: 0x06000260 RID: 608
		[Token(Token = "0x6000260")]
		void Reject(object reason);
	}
}
