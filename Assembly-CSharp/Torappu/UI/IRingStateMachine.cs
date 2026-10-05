using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020036D8 RID: 14040
	[Token(Token = "0x20036D8")]
	public interface IRingStateMachine : IHotfixable
	{
		// Token: 0x060164F5 RID: 91381
		[Token(Token = "0x60164F5")]
		bool ResetToState(string stateId);

		// Token: 0x060164F6 RID: 91382
		[Token(Token = "0x60164F6")]
		bool TransToState(string fromStateId, string toStateId);

		// Token: 0x060164F7 RID: 91383
		[Token(Token = "0x60164F7")]
		void Stop();
	}
}
