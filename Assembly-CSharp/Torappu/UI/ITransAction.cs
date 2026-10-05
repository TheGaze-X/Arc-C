using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003685 RID: 13957
	[Token(Token = "0x2003685")]
	public interface ITransAction
	{
		// Token: 0x06016344 RID: 90948
		[Token(Token = "0x6016344")]
		void Execute(State fromState, State toState, TransActionListener mustInvokeEnd);

		// Token: 0x06016345 RID: 90949
		[Token(Token = "0x6016345")]
		void ExecuteFastMode(State fromState, State toState, TransActionListener mustInvokeEnd);

		// Token: 0x1700355F RID: 13663
		// (get) Token: 0x06016346 RID: 90950
		[Token(Token = "0x1700355F")]
		TransActionType ActionType { [Token(Token = "0x6016346")] get; }
	}
}
