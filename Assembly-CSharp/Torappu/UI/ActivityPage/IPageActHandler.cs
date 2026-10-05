using System;
using System.Collections;
using Il2CppDummyDll;

namespace Torappu.UI.ActivityPage
{
	// Token: 0x02006778 RID: 26488
	[Token(Token = "0x2006778")]
	public interface IPageActHandler : IHotfixable
	{
		// Token: 0x06025FEE RID: 155630
		[Token(Token = "0x6025FEE")]
		void InitHandler(IActEntry page);

		// Token: 0x06025FEF RID: 155631
		[Token(Token = "0x6025FEF")]
		void DisposeHandler();

		// Token: 0x06025FF0 RID: 155632
		[Token(Token = "0x6025FF0")]
		void TriggerInitState(StateEngine stateEngine);

		// Token: 0x06025FF1 RID: 155633
		[Token(Token = "0x6025FF1")]
		void TriggerStart(bool isFromStack);

		// Token: 0x06025FF2 RID: 155634
		[Token(Token = "0x6025FF2")]
		IEnumerator TriggerActEnterEffect();

		// Token: 0x06025FF3 RID: 155635
		[Token(Token = "0x6025FF3")]
		IEnumerator TriggerActExitEffect();

		// Token: 0x06025FF4 RID: 155636
		[Token(Token = "0x6025FF4")]
		void ResetActEntryState(bool isShow);

		// Token: 0x06025FF5 RID: 155637
		[Token(Token = "0x6025FF5")]
		bool CanSkipAnim(TransitionContext context);
	}
}
