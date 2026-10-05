using System;
using System.Threading;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000EE RID: 238
	[Token(Token = "0x20000EE")]
	public interface IAsyncResult
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060007F0 RID: 2032
		[Token(Token = "0x17000094")]
		bool IsCompleted { [Token(Token = "0x60007F0")] get; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060007F1 RID: 2033
		[Token(Token = "0x17000095")]
		System.Threading.WaitHandle AsyncWaitHandle { [Token(Token = "0x60007F1")] get; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060007F2 RID: 2034
		[Token(Token = "0x17000096")]
		object AsyncState { [Token(Token = "0x60007F2")] get; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060007F3 RID: 2035
		[Token(Token = "0x17000097")]
		bool CompletedSynchronously { [Token(Token = "0x60007F3")] get; }
	}
}
