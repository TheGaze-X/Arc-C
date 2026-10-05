using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;

namespace Torappu.UI
{
	// Token: 0x020035E3 RID: 13795
	[Token(Token = "0x20035E3")]
	public interface ICommonBattlePlayerDataSquad : ICommonSquadPlugin, IHotfixable
	{
		// Token: 0x06015F8A RID: 89994
		[Token(Token = "0x6015F8A")]
		BattlePlayerData ParseBattleSquad(string stageId, List<AdvancedCharacterInst> advancedCharList);

		// Token: 0x06015F8B RID: 89995
		[Token(Token = "0x6015F8B")]
		List<AdvancedCharacterInst> GenAdvancedCharList(CommonSquadSingleSquadViewModel curSelectSquad);
	}
}
