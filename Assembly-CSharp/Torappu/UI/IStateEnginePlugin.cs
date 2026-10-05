using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200364E RID: 13902
	[Token(Token = "0x200364E")]
	public interface IStateEnginePlugin
	{
		// Token: 0x060161E9 RID: 90601
		[Token(Token = "0x60161E9")]
		void NotifyStateEnter(State.TransEvent evt);

		// Token: 0x060161EA RID: 90602
		[Token(Token = "0x60161EA")]
		void NotifyStatePreResume(State.TransEvent evt);

		// Token: 0x060161EB RID: 90603
		[Token(Token = "0x60161EB")]
		void NotifyStateResume(State.TransEvent evt);

		// Token: 0x060161EC RID: 90604
		[Token(Token = "0x60161EC")]
		void NotifyStatePause(State.TransEvent evt);

		// Token: 0x060161ED RID: 90605
		[Token(Token = "0x60161ED")]
		void NotifyStateExit(State.TransEvent evt);

		// Token: 0x060161EE RID: 90606
		[Token(Token = "0x60161EE")]
		void NotifyBeforeStateTrans(StateTransContext transContext);
	}
}
