using System;
using Il2CppDummyDll;

namespace Torappu.Multiplayer.Servers
{
	// Token: 0x020015C5 RID: 5573
	[Token(Token = "0x20015C5")]
	public interface ITeamClient : IServerSupport, IHotfixable
	{
		// Token: 0x06007E43 RID: 32323
		[Token(Token = "0x6007E43")]
		void UpdateTeamStatus();

		// Token: 0x06007E44 RID: 32324
		[Token(Token = "0x6007E44")]
		void StartBattle(BattleEntry entry);
	}
}
