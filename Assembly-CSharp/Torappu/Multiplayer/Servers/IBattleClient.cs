using System;
using Il2CppDummyDll;

namespace Torappu.Multiplayer.Servers
{
	// Token: 0x0200156A RID: 5482
	[Token(Token = "0x200156A")]
	public interface IBattleClient : IServerSupport, IHotfixable
	{
		// Token: 0x06007D56 RID: 32086
		[Token(Token = "0x6007D56")]
		void UpdateBattleStatus(bool inBattle);

		// Token: 0x06007D57 RID: 32087
		[Token(Token = "0x6007D57")]
		void RevStep(StepData step);
	}
}
