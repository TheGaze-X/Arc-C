using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001F2 RID: 498
	[Token(Token = "0x20001F2")]
	public interface IRevertibleChangeTracking : IChangeTracking
	{
		// Token: 0x06000D35 RID: 3381
		[Token(Token = "0x6000D35")]
		void RejectChanges();
	}
}
