using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200552E RID: 21806
	[Token(Token = "0x200552E")]
	public interface IRoguelikeSquadBattleStartHandler : IHotfixable
	{
		// Token: 0x06020122 RID: 131362
		[Token(Token = "0x6020122")]
		void CheckAndHandle(RoguelikeSquadStateBean bean, Action<List<RequestSquadSlot>> battleStarter);
	}
}
