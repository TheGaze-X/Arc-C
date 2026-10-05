using System;
using Il2CppDummyDll;
using Torappu.UI.Squad;

namespace Torappu.UI
{
	// Token: 0x020035E2 RID: 13794
	[Token(Token = "0x20035E2")]
	public interface ICommonSquadItemStructSquad : ICommonSquadPlugin, IHotfixable
	{
		// Token: 0x06015F89 RID: 89993
		[Token(Token = "0x6015F89")]
		SquadItemStruct[] ParseBattleSquad();
	}
}
