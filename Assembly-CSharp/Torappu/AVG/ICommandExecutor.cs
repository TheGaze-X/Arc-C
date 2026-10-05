using System;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001E70 RID: 7792
	[Token(Token = "0x2001E70")]
	public interface ICommandExecutor : IHotfixable
	{
		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x0600C127 RID: 49447
		[Token(Token = "0x17001737")]
		string command { [Token(Token = "0x600C127")] get; }

		// Token: 0x0600C128 RID: 49448
		[Token(Token = "0x600C128")]
		void Execute(Command command, Action<ICommandExecutor> finishCb);

		// Token: 0x0600C129 RID: 49449
		[Token(Token = "0x600C129")]
		void RaiseSignal(Command command);

		// Token: 0x0600C12A RID: 49450
		[Token(Token = "0x600C12A")]
		void ForceEnd();
	}
}
