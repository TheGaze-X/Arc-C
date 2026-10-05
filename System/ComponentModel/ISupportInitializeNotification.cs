using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001AF RID: 431
	[Token(Token = "0x20001AF")]
	public interface ISupportInitializeNotification : ISupportInitialize
	{
		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000B11 RID: 2833
		[Token(Token = "0x1700023B")]
		bool IsInitialized { [Token(Token = "0x6000B11")] get; }

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000B12 RID: 2834
		// (remove) Token: 0x06000B13 RID: 2835
		[Token(Token = "0x14000008")]
		event EventHandler Initialized;
	}
}
