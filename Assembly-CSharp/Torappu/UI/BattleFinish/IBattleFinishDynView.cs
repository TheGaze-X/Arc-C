using System;
using System.Collections;
using Il2CppDummyDll;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x0200621B RID: 25115
	[Token(Token = "0x200621B")]
	public interface IBattleFinishDynView
	{
		// Token: 0x060243C6 RID: 148422
		[Token(Token = "0x60243C6")]
		void TriggerInit(State state);

		// Token: 0x060243C7 RID: 148423
		[Token(Token = "0x60243C7")]
		IEnumerator ShowEnterEffectCoroutine();
	}
}
