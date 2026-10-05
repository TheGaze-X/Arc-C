using System;
using Il2CppDummyDll;

namespace Torappu.Multiplayer.Mode
{
	// Token: 0x020015D1 RID: 5585
	[Token(Token = "0x20015D1")]
	public interface IMultiplayerBattleVideo
	{
		// Token: 0x06007EB2 RID: 32434
		[Token(Token = "0x6007EB2")]
		void ReadBattleInfo(BattleInfo bi);

		// Token: 0x06007EB3 RID: 32435
		[Token(Token = "0x6007EB3")]
		void ReadTeamInfo(TeamInfo ti);

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06007EB4 RID: 32436
		[Token(Token = "0x17000F0C")]
		int stepCount { [Token(Token = "0x6007EB4")] get; }

		// Token: 0x06007EB5 RID: 32437
		[Token(Token = "0x6007EB5")]
		StepData GetStep(uint idx);
	}
}
