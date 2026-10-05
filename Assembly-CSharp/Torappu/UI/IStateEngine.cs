using System;
using System.Collections;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200364C RID: 13900
	[Token(Token = "0x200364C")]
	public interface IStateEngine : IHotfixable
	{
		// Token: 0x060161D4 RID: 90580
		[Token(Token = "0x60161D4")]
		bool AddTop(Type state, StateTransOptions config);

		// Token: 0x060161D5 RID: 90581
		[Token(Token = "0x60161D5")]
		bool AddTop(Type state);

		// Token: 0x060161D6 RID: 90582
		[Token(Token = "0x60161D6")]
		bool AddTop<T>(StateTransOptions config) where T : State;

		// Token: 0x060161D7 RID: 90583
		[Token(Token = "0x60161D7")]
		bool AddTop<T>() where T : State;

		// Token: 0x060161D8 RID: 90584
		[Token(Token = "0x60161D8")]
		bool ReplaceTop(Type state, StateTransOptions config, StateReplaceTransMode transMode = StateReplaceTransMode.REPLACE_MODE);

		// Token: 0x060161D9 RID: 90585
		[Token(Token = "0x60161D9")]
		bool ReplaceTop(Type state, StateReplaceTransMode transMode = StateReplaceTransMode.REPLACE_MODE);

		// Token: 0x060161DA RID: 90586
		[Token(Token = "0x60161DA")]
		bool ReplaceTop<T>(StateTransOptions config, StateReplaceTransMode transMode = StateReplaceTransMode.REPLACE_MODE) where T : State;

		// Token: 0x060161DB RID: 90587
		[Token(Token = "0x60161DB")]
		bool ReplaceTop<T>(StateReplaceTransMode transMode = StateReplaceTransMode.REPLACE_MODE) where T : State;

		// Token: 0x060161DC RID: 90588
		[Token(Token = "0x60161DC")]
		bool RemoveTop(StateTransOptions config);

		// Token: 0x060161DD RID: 90589
		[Token(Token = "0x60161DD")]
		bool RemoveTop();

		// Token: 0x060161DE RID: 90590
		[Token(Token = "0x60161DE")]
		bool RemoveToState(Type state, StateTransOptions config);

		// Token: 0x060161DF RID: 90591
		[Token(Token = "0x60161DF")]
		bool RemoveToState(Type state);

		// Token: 0x060161E0 RID: 90592
		[Token(Token = "0x60161E0")]
		bool RemoveToState<T>(StateTransOptions config) where T : State;

		// Token: 0x060161E1 RID: 90593
		[Token(Token = "0x60161E1")]
		bool RemoveToState<T>() where T : State;

		// Token: 0x060161E2 RID: 90594
		[Token(Token = "0x60161E2")]
		State GetFrontState();

		// Token: 0x060161E3 RID: 90595
		[Token(Token = "0x60161E3")]
		bool IsTransitting();

		// Token: 0x060161E4 RID: 90596
		[Token(Token = "0x60161E4")]
		StateEngineRuntime SaveToCache();

		// Token: 0x060161E5 RID: 90597
		[Token(Token = "0x60161E5")]
		IEnumerator LoadFromCache(StateEngineRuntime runtime);

		// Token: 0x060161E6 RID: 90598
		[Token(Token = "0x60161E6")]
		UIPage GetPage();

		// Token: 0x060161E7 RID: 90599
		[Token(Token = "0x60161E7")]
		IStateEnginePlugin GetPlugin();

		// Token: 0x060161E8 RID: 90600
		[Token(Token = "0x60161E8")]
		bool CheckIsExistInStack(Type stateType);
	}
}
