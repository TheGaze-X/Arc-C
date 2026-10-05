using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001F0 RID: 496
	[Token(Token = "0x20001F0")]
	public interface IChangeTracking
	{
		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000D30 RID: 3376
		[Token(Token = "0x170002B5")]
		bool IsChanged { [Token(Token = "0x6000D30")] get; }

		// Token: 0x06000D31 RID: 3377
		[Token(Token = "0x6000D31")]
		void AcceptChanges();
	}
}
