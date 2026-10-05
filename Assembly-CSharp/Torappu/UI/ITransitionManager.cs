using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200368F RID: 13967
	[Token(Token = "0x200368F")]
	public interface ITransitionManager
	{
		// Token: 0x0601637B RID: 91003
		[Token(Token = "0x601637B")]
		Transition FindTransition(Type fromState, Type toState, TransitionType transType, bool reset);

		// Token: 0x0601637C RID: 91004
		[Token(Token = "0x601637C")]
		void PutTransition(Transition transition, Type fromState, Type toState, TransitionType transType);
	}
}
